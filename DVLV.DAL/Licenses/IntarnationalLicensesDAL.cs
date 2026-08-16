using Microsoft.Data.SqlClient;
using System;
using System.Data;

namespace DVLV.DAL
{
    public class IntarnationalLicensesDAL
    {



        public static (
            int InternationalApplicationID,
            DateTime ApplicationDate,
            DateTime IssueDate,
            int Fees,
            int InternationalLicenseID,
            DateTime ExpirationDate,
            string CreatedByUserName
        ) 
            GetApplicationInfo(int licenseID)
        {
            int internationalApplicationID = -1;
            DateTime applicationDate = DateTime.MinValue;
            DateTime issueDate = DateTime.MinValue;
            int fees = 0;
            int internationalLicenseID = -1;
            DateTime expirationDate = DateTime.MinValue;
            string createdByUserName = string.Empty;

            using SqlConnection connection = new SqlConnection(ConnectionsDAL.ConnectionString);
            string query = @"Select
                                InternationalLicenses.ApplicationID,
                                Applications.ApplicationDate,
                                InternationalLicenses.IssueDate,
                                Fees=(SELECT ApplicationFees FROM ApplicationTypes WHERE ApplicationTypeID = 6) ,
                                InternationalLicenses.InternationalLicenseID,
                                InternationalLicenses.ExpirationDate,
                                Users.UserName
                            FROM InternationalLicenses
                            INNER JOIN Applications ON InternationalLicenses.ApplicationID = Applications.ApplicationID
                            INNER JOIN Users ON Users.UserID = InternationalLicenses.CreatedByUserID
                            WHERE InternationalLicenses.IssuedUsingLocalLicenseID =@LicenseID;";

            using SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@LicenseID", licenseID);

            try
            {
                connection.Open();
                using SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    internationalApplicationID = reader.GetInt32(reader.GetOrdinal("ApplicationID"));
                    applicationDate = reader.GetDateTime(reader.GetOrdinal("ApplicationDate"));
                    issueDate = reader.GetDateTime(reader.GetOrdinal("IssueDate"));
                    fees = Convert.ToInt16(reader["Fees"]);
                    internationalLicenseID = reader.GetInt32(reader.GetOrdinal("InternationalLicenseID"));
                    expirationDate = reader.GetDateTime(reader.GetOrdinal("ExpirationDate"));
                    createdByUserName = reader.GetString(reader.GetOrdinal("UserName"));
                }
            }
            catch(Exception ex)
            {
                // keep default values
            }

            return (
                internationalApplicationID,
                applicationDate,
                issueDate,
                fees,
                internationalLicenseID,
                expirationDate,
                createdByUserName
            );
        }


        public static bool HasInternationalLicense(int LocalLicenseID)
        {
            using SqlConnection connection = new SqlConnection(ConnectionsDAL.ConnectionString);
            string query = @"SELECT TOP 1 1
                             FROM InternationalLicenses
                             WHERE IssuedUsingLocalLicenseID = @LocalLicenseID;";

            using SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@LocalLicenseID", LocalLicenseID);

            try
            {
                connection.Open();
                var result = command.ExecuteScalar();
                return result != null;
            }
            catch
            {
                return false;
            }
        }

        public static int AddNewInrternationalLicense(int ApplicationID, int DriverID, int LocalLicenseID, DateTime issueDate, DateTime ExpirationDate, bool IsActive, int CurrentUserID)
        {
            int NewInterLicenseID = -1;
            SqlConnection connection = new SqlConnection(ConnectionsDAL.ConnectionString);
            string query = @"Insert into InternationalLicenses (ApplicationID,
                             DriverID,
                             IssuedUsingLocalLicenseID,
                             IssueDate,
                             ExpirationDate,
                             IsActive,
                             CreatedByUserID)
                             values (@ApplicationID,@DriverID,@LocalLicenseID,@issueDate,@ExpirationDate,@IsActive,@CurrentUserID)
                             Select SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            command.Parameters.AddWithValue("@DriverID", DriverID);
            command.Parameters.AddWithValue("@LocalLicenseID", LocalLicenseID);
            command.Parameters.AddWithValue("@issueDate", issueDate);
            command.Parameters.AddWithValue("@ExpirationDate", ExpirationDate);
            command.Parameters.AddWithValue("@IsActive", IsActive);
            command.Parameters.AddWithValue("@CurrentUserID", CurrentUserID);
            try
            {
                connection.Open();
                var result =command.ExecuteScalar();
                int.TryParse(result.ToString(), out NewInterLicenseID);
                return NewInterLicenseID;
            }
            catch(Exception ex)
            {

            }
            finally
            {
                connection.Close();
            }
                return NewInterLicenseID;

        }


        public static DataTable GetInternationalDrivingLicenseTable()
        {
            DataTable Table = new DataTable();
            SqlConnection connection = new SqlConnection(ConnectionsDAL.ConnectionString);
            String query = @"Select * From InternationalLicenses;";
            SqlCommand command = new SqlCommand(query, connection);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                    Table.Load(reader);

            }
            catch (Exception ex)
            {

            }
            finally
            {
                connection.Close();
            }
            return Table;

        }


    }
}
