using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using static System.Net.Mime.MediaTypeNames;

namespace DVLV.DAL
{
    public class ApplicationsDAL
    {
        public static bool UpdateApplicationStatus(int applicationID, int applicationStatus,DateTime LastStatusDate)
        {
            SqlConnection connection = new SqlConnection(ConnectionsDAL.ConnectionString);

            string query = @"UPDATE Applications
                             SET ApplicationStatus = @ApplicationStatus,
							 LastStatusDate=@LastStatusDate
                             WHERE ApplicationID = @ApplicationID;";
            SqlCommand command = new SqlCommand(query,connection);
            command.Parameters.AddWithValue("@ApplicationID", applicationID);
            command.Parameters.AddWithValue("@ApplicationStatus", applicationStatus);
            command.Parameters.AddWithValue("@LastStatusDate", LastStatusDate);
                
            try
            {
                connection.Open();

                // Execute the query and check if any rows were affected
                int rowsAffected = command.ExecuteNonQuery();
                return rowsAffected > 0;
            }
            catch (Exception ex)
            {
            }
            finally
            {

                connection.Close();
                
            }
            return false;
        }
        public static DataTable GetAllApplicationsData()
        {
            SqlConnection connection = new SqlConnection(ConnectionsDAL.ConnectionString);
            SqlCommand command = null;
            SqlDataReader reader = null;
            DataTable dataTable = new DataTable();

            string query = @"
                SELECT 
                    ApplicationID,
                    ApplicationTypeID,
                    NationalNo,
                    FullName,
                    ApplicationDate,
                    PassedTests,
                    ApplicationStatus
                FROM Applications
                INNER JOIN Persons ON Applications.ApplicantPersonID = Persons.PersonID;";

            try
            {
                connection.Open();
                command = new SqlCommand(query, connection);
                reader = command.ExecuteReader();

                // Load the data from the reader into the DataTable
                dataTable.Load(reader);
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while retrieving applications data.", ex);
            }
            finally
            {
                reader?.Close();
                command?.Dispose();
                if (connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                }
            }

            return dataTable;
        }

        public static DataRow GetApplicationData(int ApplicationID)
        {
            if (ApplicationID <= 0)
                return null;

            SqlConnection connection = new SqlConnection(ConnectionsDAL.ConnectionString);
            DataTable Table = new DataTable();
            string query = @"Select 
                             Applications.ApplicantPersonID,
                             Applications.ApplicationDate,
                             Applications.ApplicationTypeID,
                             Applications.ApplicationStatus,
                             Applications.LastStatusDate,
                             Applications.PaidFees,
                             Applications.CreatedByUserID
                             from  Applications
                             where Applications.ApplicationID=@ApplicationID;";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                Table.Load(reader);

                reader.Close();


            }
            catch (Exception ex)
            {

            }
            finally
            {
                connection.Close();
            }

            if (Table.Rows.Count == 0)
                return null;

            DataRow row = Table.Rows[0];
            return row;
        }

        public static int AddApplication(int PersonID, DateTime Date, int TypeID, int status, DateTime LastStatusDate, int PaidFees, int UserID)
        {
            SqlConnection connection = new SqlConnection(ConnectionsDAL.ConnectionString);
            string Query = @"
            INSERT INTO Applications
                (ApplicantPersonID, ApplicationDate, ApplicationTypeID, ApplicationStatus, LastStatusDate, PaidFees, CreatedByUserID)
            VALUES
                (@PersonID, @Date, @TypeID, @status, @LastStatusDate, @PaidFees, @UserID);
            SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(Query, connection);

            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@Date", Date);
            command.Parameters.AddWithValue("@TypeID", TypeID);
            command.Parameters.AddWithValue("@status", status);
            command.Parameters.AddWithValue("@LastStatusDate", LastStatusDate);
            command.Parameters.AddWithValue("@PaidFees", PaidFees);
            command.Parameters.AddWithValue("@UserID", UserID);

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                if (result != null )
                {
                    int.TryParse(result.ToString(), out int newID);
                    return newID;
                }
            }
            catch (Exception ex)
            {
                // يمكنك تسجيل الخطأ هنا إذا أردت
            }
            finally
            {
                connection.Close();
            }
            return -1; // في حال حدوث خطأ
        }


        public static bool DeleteApplication(int ApplicationID)
        {
            int AffectedRows = 0;
            SqlConnection connection = new SqlConnection(ConnectionsDAL.ConnectionString);
            string query = @"Delete From Applications
                             where ApplicationID=@ApplicationID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            try
            {
                connection.Open();
                AffectedRows = command.ExecuteNonQuery();
                if (AffectedRows > 0)
                {
                    return true;
                }
                else return false;
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



        public static int GetApplicationIDByLicenseID(int LicenseID)
        {
            int ApplcationID = -1;
            SqlConnection connection = new SqlConnection(ConnectionsDAL.ConnectionString);
            string qeury = @"Select Licenses.ApplicationID  From Licenses where Licenses.LicenseID=@LicenseID";
            SqlCommand command = new SqlCommand(qeury, connection);
            command.Parameters.AddWithValue("@LicenseID", LicenseID);
            try
            {
                connection.Open();
                var result = command.ExecuteScalar();
                if(result!=null)
                {
                    int.TryParse(result.ToString(), out ApplcationID);

                }
                return ApplcationID;

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






    }
}
