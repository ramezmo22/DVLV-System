using Microsoft.Data.SqlClient;
using System.Data;

namespace DVLV.DAL
{
    public class TestAppointmentsDAL
    {
        public static DataTable GetPersonAppointmentsGridView(int LDLAID,int TestID=1)
        {
            DataTable Table = new DataTable();

            SqlConnection connection = new SqlConnection(ConnectionsDAL.ConnectionString);
            string query = @"Select TestAppointmentID,AppointmentDate,PaidFees,IsLocked From TestAppointments 
                                where TestAppointments.LocalDrivingLicenseApplicationID=@LocalDrivingLicenseApplicationID and TestAppointments.TestTypeID=@TestID;";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LDLAID);
            command.Parameters.AddWithValue("@TestID", TestID);
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
            return Table;

        }
        public static bool IsPersonHasAcctiveAppointment(int LocalDrivingLicenseApplicationID, int TestType)
        {
            //if Is Locked ==0 so its Loced Appointment
            bool HasActiveAppointment = false;
            SqlConnection connection = new SqlConnection(ConnectionsDAL.ConnectionString);

            String query = @"Select IsLocked from TestAppointments
                            where
                LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID 
                and TestAppointments.TestTypeID = @TestTypeID and IsLocked=0;";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@TestTypeID", TestType);
            command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                if (result != null)
                {
                    int temp = Convert.ToInt16(result);
                    HasActiveAppointment = temp == 0;
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                connection.Close();
            }
            return HasActiveAppointment;
        }
        public static int AddNewTestAppointment(int TestType, int LocalDrivingLicenseApplicationID, DateTime AppointmentDate, int Fees, int CurrentUserID, bool IsLocked)
        {
            int AppointmentID = -1;
            SqlConnection connection = new SqlConnection(ConnectionsDAL.ConnectionString);
            string Query = @"Insert Into TestAppointments (TestTypeID, LocalDrivingLicenseApplicationID, 
                          AppointmentDate, PaidFees, CreatedByUserID,  IsLocked)
                          Values (@TestType, @LocalDrivingLicenseApplicationID, @AppointmentDate, @Fees, @CurrentUserID, @IsLocked)
                                   SELECT SCOPE_IDENTITY();";
            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@TestType", TestType);
            command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
            command.Parameters.AddWithValue("@AppointmentDate", AppointmentDate);
            command.Parameters.AddWithValue("@Fees", Fees);
            command.Parameters.AddWithValue("@CurrentUserID", CurrentUserID);
            command.Parameters.AddWithValue("@IsLocked", Convert.ToByte( IsLocked));
            try
            {
                connection.Open();
                var NewID = command.ExecuteScalar();
                int.TryParse(NewID.ToString(), out AppointmentID);
            }
            catch(Exception ex)
            {

            }
            finally
            {
                connection.Close();
            }

            return AppointmentID;

        }
        public static bool IsAppointmentLocked(int AppointemntID)
        {
            bool IsLocked = false;
            SqlConnection connection = new SqlConnection(ConnectionsDAL.ConnectionString);
            string query = @"
                                Select TestAppointments.IsLocked From TestAppointments 
                                where TestAppointmentID=@AppointemntID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@AppointemntID", AppointemntID);
            try
            {
                connection.Open();
                SqlDataReader reader= command.ExecuteReader();
                if (reader.Read())
                {
                    IsLocked = Convert.ToBoolean(reader["IsLocked"]);

                }
            }
            catch(Exception ex)
            {

            }
            finally
            {
                connection.Close();
            }



            return IsLocked;
        }
        public static DateTime GetAppointmentDate(int AppointmentID)
        {
            DateTime Date = DateTime.MinValue;//to chatch if didnt get value
            SqlConnection connection = new SqlConnection(DAL.ConnectionsDAL.ConnectionString);
            string Query = @"Select dbo.TestAppointments.AppointmentDate From TestAppointments
	                        where TestAppointmentID=@TestAppointmentID ";
            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@TestAppointmentID", AppointmentID);
            try
            {
                connection.Open();
                var resutl = command.ExecuteScalar();
                Date= Convert.ToDateTime(resutl.ToString());
            }
            catch(Exception ex)
            {

            }
            finally
            {
                connection.Close();
            }
            return Date;


        }
        public static bool UpdateDate(int AppointmentID, DateTime Date)
        {
            bool IsSaved = false;
            SqlConnection connection = new SqlConnection(ConnectionsDAL.ConnectionString);
            string query = @"Update TestAppointments set AppointmentDate=@AppointmentDate 
	                        where TestAppointmentID=@TestAppointmentID;";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@TestAppointmentID", AppointmentID);
            command.Parameters.AddWithValue("@AppointmentDate", Date);
            try
            {
                connection.Open();
                int NumberOfAffectedRows = 0;
                var result = command.ExecuteNonQuery();
                int.TryParse(result.ToString(), out NumberOfAffectedRows);
                if(NumberOfAffectedRows>0)
                {
                    IsSaved = true;
                }
            } 
            catch(Exception ex)
            {

            }
            finally
            {
                connection.Close();
            }
            return IsSaved;
        }

        public static bool UpdateLockStutus(int TestAppointmentID,bool Stutus)
        {

            SqlConnection connection = new SqlConnection(ConnectionsDAL.ConnectionString);
            string query = @"Update TestAppointments 
                            Set IsLocked=@Stutus
                            where TestAppointmentID=@AppointemntID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@AppointemntID", TestAppointmentID);
            command.Parameters.AddWithValue("@Stutus",Stutus );
            try
            {
                connection.Open();
                int AffectedRows = command.ExecuteNonQuery();
                return AffectedRows > 0 ? true : false;
                
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
    }
}
