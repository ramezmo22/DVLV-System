using Microsoft.Data.SqlClient;
using Microsoft.Data.SqlClient.Server;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;
using System.Text;

namespace DVLV.DAL
{
    public class LicensesDAL
    {


        public static int AddNewLicense(int ApplicationID, int DriverID,int ClassID,DateTime IssueDate,DateTime ExpirationDate,string Notes, int PaidFees,bool IsActive,int IssueReason, int CreatedByUserID)
        {
            int NewLicenseID = -1;
            SqlConnection connection = new SqlConnection(ConnectionsDAL.ConnectionString);
            string query = @"insert into Licenses (
                            ApplicationID
                            ,DriverID
                            ,LicenseClass
                            ,IssueDate
                            ,ExpirationDate	
                            ,Notes
                            ,PaidFees
                            ,IsActive
                            ,IssueReason
                            ,CreatedByUserID)

                            values(
                             @ApplicationID
                            ,@DriverID
                            ,@ClassID
                            ,@IssueDate
                            ,@ExpirationDate
                            ,@Notes
                            ,@PaidFees
                            ,@IsActive
                            ,@IssueReason
                            ,@CreatedByUserID
                            )
                            SELECT SCOPE_IDENTITY();";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            command.Parameters.AddWithValue("@DriverID", DriverID);
            command.Parameters.AddWithValue("@ClassID", ClassID);
            command.Parameters.AddWithValue("@IssueDate", IssueDate);
            command.Parameters.AddWithValue("@ExpirationDate", ExpirationDate);
            command.Parameters.AddWithValue("@PaidFees", PaidFees);
            command.Parameters.AddWithValue("@IsActive", IsActive);
            command.Parameters.AddWithValue("@IssueReason", IssueReason);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
            if (Notes.IsNullOrEmpty())
            {
                command.Parameters.AddWithValue("@Notes", DBNull.Value);
            }
            else command.Parameters.AddWithValue("@Notes", Notes);

            try
            {
                connection.Open();
                var result = command.ExecuteScalar();
                int.TryParse(result.ToString(), out NewLicenseID);

            }
            catch(Exception ex)
            {

            }
            finally
            {
                connection.Close();
            }
            return NewLicenseID;
        }


        public static bool HasLicense(int ApplicationID)
        {
            SqlConnection connection = new SqlConnection(ConnectionsDAL.ConnectionString);
            string qeury = "@Select 1 From Licenses where ApplicationID=@ApplicationID";
            SqlCommand command = new SqlCommand(qeury, connection);
            command.Parameters.AddWithValue("ApplicationID", ApplicationID);
            try
            {
                connection.Open();
                var result = command.ExecuteScalar();
                return result != null && Convert.ToInt16(result) == 1;
            }
            catch (Exception ex )
            {
                return false;
            }
            finally
            {
                connection.Close();
            }

        }
        public static int GetLicenseIDByApplicationID(int ApplicationID)
        {
            int LicenseID = -1;
            SqlConnection connection = new SqlConnection(ConnectionsDAL.ConnectionString);
            string qeury = @"Select Licenses.LicenseID From Licenses where Licenses.ApplicationID=@ApplicationID";
            SqlCommand command = new SqlCommand(qeury, connection);
            command.Parameters.AddWithValue("ApplicationID", ApplicationID);
            try
            {
                connection.Open();
                var result = command.ExecuteScalar();
                int.TryParse(result.ToString(), out LicenseID);
                return LicenseID;
               
            }
            catch (Exception ex)
            {
                return -1;
            }
            finally
            {
                connection.Close();
            }
        }

        public static bool IsLicenseDetaind(int LicenseID)
        {
            SqlConnection connection = new SqlConnection(ConnectionsDAL.ConnectionString);
            string query = @"Select 1 From DetainedLicenses where DetainedLicenses.LicenseID=@LicenseID and IsReleased = 0;";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@LicenseID", LicenseID);
            try
            {
                connection.Open();
                var result = command.ExecuteScalar();
                return result != null && Convert.ToInt16(result) == 1;
            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                connection.Close();
            }
        }
        public static (bool IsActive,DateTime ExpiarationDate) LicenseActivationAndExpiareationDate(int LicenseID)
        {
            bool IsActive = new Boolean();
            DateTime ExpiarationDate = new DateTime();

            SqlConnection connection = new SqlConnection(ConnectionsDAL.ConnectionString);
            string query = @"Select Licenses.IsActive ,Licenses.ExpirationDate From Licenses where LicenseID=@LicenseID;";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@LicenseID", LicenseID);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    IsActive = Convert.ToBoolean(reader["IsActive"]);
                    ExpiarationDate = Convert.ToDateTime(reader["ExpirationDate"]);
                }
                reader.Close();
                return (IsActive, ExpiarationDate);
            }
            catch (Exception ex)
            {

            }
            finally
            {
                connection.Close();
            }
            return (false, DateTime.MinValue);
        }

        public static int GetLicenseClassID(int LocalLicenseID)
        {
            SqlConnection connection = new SqlConnection(ConnectionsDAL.ConnectionString);
            string query = @"Select Licenses.LicenseClass From Licenses where LicenseID=@LicenseID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@LicenseID", LocalLicenseID);
            try
            {
                connection.Open();
                var result = command.ExecuteScalar();
                if(result!=null)
                return  Convert.ToInt16(result);
            }
            catch (Exception ex)
            {
                return -1;
            }
            finally
            {
                connection.Close();
            }
            return -1;

        }
        public static DataTable GetLocalLicensesHistoryTable(int DriverID)
        {
            DataTable Table = new DataTable();
            SqlConnection connection = new SqlConnection(ConnectionsDAL.ConnectionString);
            string query = @"Select Licenses.LicenseID,Licenses.ApplicationID,LicenseClasses.ClassName,
                            Licenses.IssueDate,Licenses.ExpirationDate,Licenses.IsActive From Licenses
                            inner join LicenseClasses on Licenses.LicenseClass=LicenseClasses.LicenseClassID
                            where DriverID=@DriverID;";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@DriverID", DriverID);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader != null)
                {
                    Table.Load(reader);
                    return Table;
                }
                
            }
            catch (Exception ex )
            {
                return Table;
            }

            return Table;


        }
        public static DataTable GetInternationalLicensesHistoryTable(int DriverID)
        {
            DataTable Table = new DataTable();
            SqlConnection connection = new SqlConnection(ConnectionsDAL.ConnectionString);
            string query = @"Select 
							InternationalLicenses.InternationalLicenseID,
							InternationalLicenses.ApplicationID,
							LicenseClasses.ClassName,
							InternationalLicenses.IssueDate,
							InternationalLicenses.ExpirationDate,
							InternationalLicenses.IsActive 
							From InternationalLicenses
							inner join Licenses on Licenses.LicenseID=InternationalLicenses.IssuedUsingLocalLicenseID
							inner join LicenseClasses on Licenses.LicenseClass=LicenseClasses.LicenseClassID
                            where InternationalLicenses.DriverID=@DriverID;";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@DriverID", DriverID);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader != null)
                {
                    Table.Load(reader);
                    return Table;
                }

            }
            catch (Exception ex)
            {
                return Table;
            }

            return Table;
        }

        public static int GetInternationalLicenseIDByLicenseID(int LocalLicenseID)
        {
            int InternationalLicenseID = -1;
            SqlConnection connection = new SqlConnection(ConnectionsDAL.ConnectionString);
            string query = @"Select InternationalLicenses.InternationalLicenseID From InternationalLicenses where InternationalLicenses.IssuedUsingLocalLicenseID=@LocalLicenseID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@LocalLicenseID", LocalLicenseID);

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                if (result != null && int.TryParse(result.ToString(), out int id))
                {
                    InternationalLicenseID = id;
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                connection.Close();
            }

            return InternationalLicenseID;
        }

        public static bool ChangeLicenseStatus(int LicenseID)
        {
            SqlConnection connection = new SqlConnection(ConnectionsDAL.ConnectionString);
            string query = @"Update Licenses Set Licenses.IsActive=0 where LicenseID=@LicenseID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@LicenseID", LicenseID);
            try
            {
                connection.Open();
                int rowsAffected = command.ExecuteNonQuery();
                return rowsAffected > 0;
            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                connection.Close();
            }
        }

        public static DTO_DetainedLicenseInfo GetLicenseFullInfo(int LicenseID)
        {
            SqlConnection connection = new SqlConnection(ConnectionsDAL.ConnectionString);
            string query = @"
                SELECT 
                    LicenseClasses.ClassName,
					FullName = ( People.FirstName + ' ' + People.SecondName + ' ' + ISNULL(People.ThirdName,'') + ' ' + ISNULL(People.LastName,'')),
                    Licenses.LicenseID,
                    People.NationalNo,
					People.ImagePath,
                    CASE WHEN People.Gendor = 0 THEN 'Male' ELSE 'Female' END AS Gender,
                    FORMAT(Licenses.IssueDate, 'dd/MM/yyyy') AS IssueDate,
                    case 
					when Licenses.IssueReason = 1 then 'First Time.'
					when Licenses.IssueReason = 2 then 'Renew Licensen.'
					when Licenses.IssueReason = 3 then 'Replace For Damaged.'
					when Licenses.IssueReason = 4 then 'Replace For Lost.'
					 END as Issuereson,
                    ISNULL(Licenses.Notes, 'No Notes') AS Notes,
                    CASE WHEN Licenses.IsActive = 1 THEN 'Yes' ELSE 'No' END AS IsActive,
                    FORMAT(People.DateOfBirth, 'dd/MM/yyyy') AS DateOfBirth,
                    Drivers.DriverID,
                    FORMAT(Licenses.ExpirationDate, 'dd/MM/yyyy') AS ExpirationDate,
                    CASE WHEN EXISTS(SELECT 1 FROM DetainedLicenses WHERE LicenseID = @LicenseID AND IsReleased = 0) THEN 'Yes' ELSE 'No' END AS IsDetained
                    
                FROM 
                    Licenses
                    INNER JOIN LicenseClasses ON Licenses.LicenseClass = LicenseClasses.LicenseClassID
                    INNER JOIN Drivers ON Licenses.DriverID = Drivers.DriverID
                    INNER JOIN People ON Drivers.PersonID = People.PersonID
                   
                WHERE 
                    Licenses.LicenseID = @LicenseID ;";

                         SqlCommand command = new SqlCommand(query, connection);
                        command.Parameters.AddWithValue("@LicenseID", LicenseID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    return new DTO_DetainedLicenseInfo()
                    {
                        ClassName = reader["ClassName"].ToString(),
                        FullName = reader["FullName"].ToString(),
                        LicenseID = Convert.ToInt32(reader["LicenseID"]),
                        NationalNumber = reader["NationalNo"].ToString(),
                        Gender = reader["Gender"].ToString(),
                        IssueDate = reader["IssueDate"].ToString(),
                        IssueReason = reader["Issuereson"].ToString(),
                        Notes = reader["Notes"].ToString(),
                        IsActive = reader["IsActive"].ToString(),
                        DateOfBirth = reader["DateOfBirth"].ToString(),
                        DriverID = Convert.ToInt32(reader["DriverID"]),
                        ExpirationDate = reader["ExpirationDate"].ToString(),
                        IsDetained = reader["IsDetained"].ToString(),
                        ImageURL = reader["ImagePath"].ToString(),
                    };
                }

                return null;
            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
