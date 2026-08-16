using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace DVLV.DAL
{
    public class DriversDAL
    {
        public static int AddNewDriver(int PersonID, int CurrentUserID, DateTime CreatedDate)
        {
            int DriverID = -1;
            SqlConnection connection = new SqlConnection(ConnectionsDAL.ConnectionString);
            string query = @"insert into Drivers (PersonID,CreatedByUserID,CreatedDate)
                           values(@PersonID,@CreatedByUserID,@CreatedDate)
                           Select SCOPE_IDENTITY();
                           ";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@CreatedByUserID", CurrentUserID);
            command.Parameters.AddWithValue("@CreatedDate", CreatedDate);

            try
            {
                connection.Open();
                var result = command.ExecuteScalar();
                int.TryParse(result.ToString(), out DriverID);

            }
            catch (Exception ex)
            {

            }
            finally
            {
                connection.Close();
            }
            return DriverID;
        }
        public static void GetDriverinfo(
            ref string className,
            ref string fullname,
            ref int licenseID,
            ref string nationalNumber,
            ref int gendor,
            ref DateTime issueDate,
            ref int issueReason,
            ref string notes,
            ref bool isActive,
            ref DateTime dateOfBirth,
            ref int driverID,
            ref DateTime expirationDate,
            ref string ImagePath)
        {
            SqlConnection connection = new SqlConnection(ConnectionsDAL.ConnectionString);
            string query = @"Select LicenseClasses.ClassName,
                            FullName=
                            	(ISNULL(People.FirstName,'')
                            +' '+ISNULL(People.SecondName,'')
                            +' '+ISNULL(People.ThirdName	,'')
                            +' '+ISNULL(People.LastName,''))
                            ,Licenses.LicenseID,
                            People.NationalNo,
                            People.Gendor,
                            Licenses.IssueDate,
                            Licenses.IssueReason,
                            Licenses.Notes,
                            Licenses.IsActive,
                            People.DateOfBirth,
                            Licenses.DriverID,
                            Licenses.ExpirationDate,
                            People.ImagePath
                            From Licenses inner join Drivers on Licenses.DriverID=Drivers.DriverID
                            inner join LicenseClasses on Licenses.LicenseClass=LicenseClasses.LicenseClassID
                            inner join People on Drivers.PersonID=People.PersonID
                            where Licenses.LicenseID=@LicenseID;";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@LicenseID", licenseID);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    className = Convert.ToString(reader["ClassName"]);
                    fullname = Convert.ToString(reader["FullName"]);
                    licenseID = Convert.ToInt32(reader["LicenseID"]);
                    nationalNumber = Convert.ToString(reader["NationalNo"]);
                    gendor = Convert.ToInt16(reader["Gendor"]);
                    issueDate = Convert.ToDateTime(reader["IssueDate"]);
                    issueReason = Convert.ToInt16(reader["IssueReason"]);
                    notes = !reader.IsDBNull(reader.GetOrdinal("Notes")) ? Convert.ToString(reader["Notes"]) : string.Empty;
                    isActive = Convert.ToBoolean(reader["IsActive"]);
                    dateOfBirth = Convert.ToDateTime(reader["DateOfBirth"]);
                    driverID = Convert.ToInt32(reader["DriverID"]);
                    expirationDate = Convert.ToDateTime(reader["ExpirationDate"]);
                    ImagePath = !reader.IsDBNull(reader.GetOrdinal("ImagePath")) ? Convert.ToString(reader["ImagePath"]) : string.Empty;
                }
                reader.Close();
            }
            catch (Exception ex)
            {

            }
            finally
            {
                connection.Close();
            }
        }
        public static int GetDriverIDByPersonID(int PersonID)
        {
            int DriverID = -1;
            SqlConnection connection = new SqlConnection(ConnectionsDAL.ConnectionString);
            string Query = @"Select DriverID From Drivers where PersonID=@PersonID;";
            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@PersonID", PersonID);
            try
            {
                connection.Open();
                var result = command.ExecuteScalar();
                if (result != null)
                    int.TryParse(result.ToString(), out DriverID);
            }
            catch (Exception ex)
            {

            }
            finally
            {
                connection.Close();
            }
            return DriverID;
        }
        public static int GetDriverIDByApplcationID(int ApplicationID)
        {
            int DriverID = -1;
            SqlConnection connection = new SqlConnection(ConnectionsDAL.ConnectionString);
            string Query = @"Select DriverID From Licenses
                            where ApplicationID=@ApplicationID;";
            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            try
            {
                connection.Open();
                var result = command.ExecuteScalar();
                if (result != null)
                    int.TryParse(result.ToString(), out DriverID);
            }
            catch (Exception ex)
            {

            }
            finally
            {
                connection.Close();
            }
            return DriverID;


        }
        public static DataTable GetDriversData()
        {
            DataTable Data = new DataTable();
            SqlConnection connection = new SqlConnection(ConnectionsDAL.ConnectionString);
            string query = @"SELECT 
                            d.DriverID,
                            d.PersonID,
                            p.NationalNo,
                            FullName = (
                                p.FirstName + ' ' +
                                ISNULL(p.SecondName, '') + ' ' +
                                ISNULL(p.ThirdName, '') + ' ' +
                                ISNULL(p.LastName, '')
                            ),
                            d.CreatedDate,
                            (
                                SELECT COUNT(l.LicenseID) 
                                FROM dbo.Licenses l
                                WHERE l.IsActive = 1 
                                  AND l.DriverID = d.DriverID
                            ) AS NumberOfActiveLicenses
                        FROM dbo.Drivers d
                        INNER JOIN dbo.People p 
                            ON d.PersonID = p.PersonID;";
            SqlCommand command = new SqlCommand(query, connection);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if(reader!=null)
                    Data.Load(reader);

                reader.Close();
            }
            catch(Exception ex)
            {
                return new DataTable();
            }
            finally
            {
                connection.Close();
            }
            return Data;


        }
        public static int GetDriverIDByLicenseID(int LicenseID)
        {
            int DriverID = -1;
            SqlConnection connection = new SqlConnection(ConnectionsDAL.ConnectionString);
            string Query = @"Select DriverID From Licenses where LicenseID=@LicenseID;";
            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@LicenseID", LicenseID);
            try
            {
                connection.Open();
                var result = command.ExecuteScalar();
                if (result != null)
                    int.TryParse(result.ToString(), out DriverID);
            }
            catch (Exception ex)
            {

            }
            finally
            {
                connection.Close();
            }
            return DriverID;


        }



        public static (string FullName,
        int LicenseID,
        string NationalNumber,
        int Gender,
        DateTime IssueDate,
        DateTime ExpirationDate,
        int DriverID,
        DateTime DateOfBirth,
        bool IsActive,
        int ApplicationID)
            GetDriverInternationalLicenseInfo(int InternationalLicenseID)
        {
            string FullName = "";
            int LicenseID = -1;
            string NationalNumber = "";
            int Gender = -1;
            DateTime IssueDate = DateTime.MinValue;
            DateTime ExpirationDate = DateTime.MinValue;
            int DriverID = -1;
            DateTime DateOfBirth = DateTime.MinValue;
            bool IsActive = false;
            int ApplicationID = -1;

            SqlConnection connection = new SqlConnection(ConnectionsDAL.ConnectionString);
            string query = @"
                            SELECT       FullName=(ISNULL( People.FirstName,'')
                            +' '+ISNULL(People.SecondName,'')
                            +' '+ISNULL( People.ThirdName,'')
                            +' '+ISNULL( People.LastName,''))
                            ,InternationalLicenses.IssuedUsingLocalLicenseID
                            , People.NationalNo, InternationalLicenses.IssueDate
                            , InternationalLicenses.ExpirationDate
                            , InternationalLicenses.DriverID
                            , People.DateOfBirth
                            , InternationalLicenses.IsActive
                            , InternationalLicenses.ApplicationID
                            , People.Gendor
                            FROM            InternationalLicenses 
                            INNER JOIN Licenses ON Licenses.LicenseID=InternationalLicenses.IssuedUsingLocalLicenseID
                            INNER JOIN Drivers ON Licenses.DriverID=Drivers.DriverID
                            INNER JOIN People ON People.PersonID=Drivers.PersonID
                            WHERE        (InternationalLicenses.InternationalLicenseID = @InternationalLicenseID);
                            ";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@InternationalLicenseID", InternationalLicenseID);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                //Filling
                if (reader.Read())
                {
                    FullName = Convert.ToString(reader["FullName"]);
                    LicenseID = Convert.ToInt16(reader["IssuedUsingLocalLicenseID"]);
                    NationalNumber = Convert.ToString(reader["NationalNo"]);
                    Gender = Convert.ToByte(reader["Gendor"]);
                    IssueDate = Convert.ToDateTime(reader["IssueDate"]);
                    ExpirationDate = Convert.ToDateTime(reader["ExpirationDate"]);
                    DriverID = Convert.ToInt16(reader["DriverID"]);
                    DateOfBirth = Convert.ToDateTime(reader["DateOfBirth"]);
                    IsActive = Convert.ToBoolean(reader["IsActive"]);
                    ApplicationID = Convert.ToInt16(reader["ApplicationID"]);
                }

                reader.Close();
            }
            catch(Exception ex)
            {

            }
            finally
            {
                connection.Close();
            }

            return (FullName,
            LicenseID,
            NationalNumber,
            Gender,
            IssueDate,
            ExpirationDate,
            DriverID,
            DateOfBirth,
            IsActive,
            ApplicationID);

        }





    }
}

