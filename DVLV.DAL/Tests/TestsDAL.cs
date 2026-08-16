using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace DVLV.DAL
{
    public class TestsDAL
    {

        public static bool IsPersonHasPassedTheTest(int LocalDrivingLicenseApplicationID, int TestType)
        {
            bool HasPassed = false;
            SqlConnection connection = new SqlConnection(DAL.ConnectionsDAL.ConnectionString);
            string query = @"Select Tests.TestResult From Tests 
                           inner join TestAppointments on Tests.TestAppointmentID=TestAppointments.TestAppointmentID
                           where TestAppointments.LocalDrivingLicenseApplicationID=@LocalDrivingLicenseApplicationID and TestAppointments.TestTypeID=@TestTypeID and TestResult=1;";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@TestTypeID", TestType);
            command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                if (result != null)
                {
                    HasPassed = Convert.ToBoolean(result);
                }
            }
            catch(Exception ex)
            {

            }
            finally
            {
                connection.Close();
            }
            return HasPassed;

        }

        public static int AddTest(int TestAppointmentID, bool result, String Notes,int CurrentUserID)
        {
            int TestID = -1;
            SqlConnection connection = new SqlConnection(DAL.ConnectionsDAL.ConnectionString);
            string query = @"Insert into Tests (Tests.TestAppointmentID,TestResult,Notes,CreatedByUserID)
                            values (@TestAppointmentID,@result,@Notes,@CurrentUserID)
                            SELECT SCOPE_IDENTITY();";
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);
            command.Parameters.AddWithValue("@result", result);
            command.Parameters.AddWithValue("@CurrentUserID", CurrentUserID);

            if(Notes=="")
                command.Parameters.AddWithValue("@Notes", DBNull.Value);
            else
                command.Parameters.AddWithValue("@Notes", Notes);
            
            try
            {
                connection.Open();
                var res = command.ExecuteScalar();
                int.TryParse(res.ToString(), out TestID);
            }
            catch (Exception ex)
            {

            }
            finally
            {
                connection.Close();
            }
            return TestID;



        }


    }
}
