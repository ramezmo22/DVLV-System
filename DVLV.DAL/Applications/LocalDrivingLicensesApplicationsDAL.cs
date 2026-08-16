using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Runtime.CompilerServices;
using static System.Net.Mime.MediaTypeNames;

namespace DVLV.DAL
{



    public class LocalDrivingLicensesApplicationsDAL
    {

        public static bool CanPersonApplicatieNewLicense(int PersonID,int LicenseClass)
        {
            SqlConnection connection = new SqlConnection(ConnectionsDAL.ConnectionString);
            string Query = @"Select  LocalDrivingLicenseApplications.ApplicationID From Applications
                            inner join LocalDrivingLicenseApplications on
                            LocalDrivingLicenseApplications.ApplicationID = Applications.ApplicationID
		                    where (ApplicantPersonID=@PersonID and ApplicationTypeID=1 and (ApplicationStatus=1 or ApplicationStatus=3)) 
		                    and LocalDrivingLicenseApplications.LicenseClassID=@LicenseClass;";
            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@LicenseClass", LicenseClass);
            try
            {
                connection.Open();
                var result = command.ExecuteScalar();
                return result == null;
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


        //Add a new local driving license application  By putting the application ID and the license class The license class is one Base 
        public static int AddNewLocalDrivingLicenseApplication(int ApplicationID,int LicenseClass)
        {
            SqlConnection connection = new SqlConnection(ConnectionsDAL.ConnectionString);
            string Query = @"Insert Into LocalDrivingLicenseApplications 
                                (ApplicationID,LicenseClassID)
                             values 
                                (@AppplicationID,@LicanseClass) 
                             SELECT SCOPE_IDENTITY();
             ";
            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@AppplicationID", ApplicationID);
            command.Parameters.AddWithValue("@LicanseClass", LicenseClass);
            try
            {
                connection.Open();
                var result = command.ExecuteScalar();
                int NLDLID = -1;
                if(int.TryParse(result.ToString(),out NLDLID))
                {
                    return NLDLID;
                }

            }
            catch(Exception ex)
            {

            }
            finally
            {
                connection.Close();
            }
            return -1;
        }


        public static int FindLocalAppID(int ApplicationID)
        {
            int localDrivingLicenseApplicationID = -1;
            SqlConnection connection = new SqlConnection(ConnectionsDAL.ConnectionString);
            string query = @"Select LocalDrivingLicenseApplications.ApplicationID From LocalDrivingLicenseApplications
                        where ApplicationID = @ApplicationID;";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            try
            {
                connection.Open();
                var result = command.ExecuteScalar();
                int.TryParse(result.ToString(), out localDrivingLicenseApplicationID);
            }
            catch (Exception ex)
            {

            }
            finally
            {
                connection.Close();
            }
            return localDrivingLicenseApplicationID;
        }


        public static bool UpdateLocalDrivingLicenseClass(int LocaldlappID,int LicanseClassID)
        {
            SqlConnection connection = new SqlConnection(ConnectionsDAL.ConnectionString);
            string query = @"UPDATE LocalDrivingLicenseApplications 
                    SET LicenseClassID = @LicanseClassID
                    WHERE LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@LicanseClassID", LicanseClassID);
            command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocaldlappID);
            try
            {
                connection.Open();
                var result= command.ExecuteNonQuery();
                int AffectedRows = -1;
                int.TryParse(result.ToString(), out AffectedRows);
                return AffectedRows > 0 ? true : false;
            }
            catch (Exception ex )
            { }
            finally
            {
                connection.Close();
            }
            return false;
        }

        public static int GetLicenseClassIDByApplicationID(int ApplicationID)
        {
            SqlConnection connection = new SqlConnection(ConnectionsDAL.ConnectionString);
            string Query = @"
                    Select LocalDrivingLicenseApplications.LicenseClassID From LocalDrivingLicenseApplications
                    where LocalDrivingLicenseApplications.ApplicationID=@ApplicationID ";
            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            try
            {
                connection.Open();
                var result = command.ExecuteScalar();
                int classID = -1;
                int.TryParse(result.ToString(), out classID);
                return classID;
            }
            catch (Exception e) { return 3; }
            finally
            {
                connection.Close();
            }
        }
        public static int GetLicanseClassIDByLicenseID(int LicenseID)
        {
            SqlConnection connection = new SqlConnection(ConnectionsDAL.ConnectionString);
            string Query = @"Select Licenses.LicenseClass From Licenses where LicenseID= @LicenseID ";
            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@LicenseID", LicenseID);
            try
            {
                connection.Open();
                var result = command.ExecuteScalar();
                int classID = -1;
                int.TryParse(result.ToString(), out classID);
                return classID;
            }
            catch (Exception e) { return 3; }
            finally
            {
                connection.Close();
            }
        }


        public static DataTable GetLocalDrivingLicenseTable()
        {
            DataTable Table = new DataTable();
            SqlConnection connection = new SqlConnection(ConnectionsDAL.ConnectionString);
            string query = "Select * From LocalDrivingLicenseApplications_View;";
            SqlCommand command = new SqlCommand(query, connection);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if(reader.Read())
                {
                    Table.Load(reader);
                    return Table;
                }

            }
            catch(Exception ex)
            {
                return null;
            }
            finally
            {
                connection.Close();
            }
            return Table;
        }


        public static  (string licenseClassDescribtion, int NumberOfPassedTests) Getdrivinglicenseapplicationinfo (int DrivingLicenseApplicationID)
        {
            string ClassDes = "";
            int PassTests = -1;
            SqlConnection connection = new SqlConnection(ConnectionsDAL.ConnectionString);

            string Query = @"Select PassedTestCount , ClassName From LocalDrivingLicenseApplications_View
                                    where LocalDrivingLicenseApplications_View.LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID;";

            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", DrivingLicenseApplicationID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if(reader.Read())
                {
                    ClassDes = Convert.ToString( reader["ClassName"]);
                    int.TryParse(reader["PassedTestCount"].ToString(), out PassTests);
                }
                reader.Close();
                connection.Close();

            }
            catch(Exception ex)
            {

            }
            finally
            {

            }
            return (ClassDes, PassTests);



        }
		public static int GetApplicationIDByLocalDrivingLicenseID(int LocalDrivingLicenseApplicationID)
		{
			if (LocalDrivingLicenseApplicationID <= 0)
				return -1;

			int ApplicationID = -1;
			SqlConnection connection = new SqlConnection(ConnectionsDAL.ConnectionString);
			string Query = @"
							 Select LocalDrivingLicenseApplications.ApplicationID from LocalDrivingLicenseApplications
								  where LocalDrivingLicenseApplicationID=@LocalDrivingLicenseApplicationID;";
			SqlCommand command = new SqlCommand(Query, connection);
			command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);

			try
			{
				connection.Open();
				SqlDataReader reader = command.ExecuteReader();

				if (reader.Read())
				{
					int.TryParse(reader["ApplicationID"].ToString(), out ApplicationID);
				}
				reader.Close();
				connection.Close();

			}
			catch (Exception ex)
			{

			}
			finally
			{

			}
			return ApplicationID;
		}

        public static (string DclassName, string Name, int Trials, int Fees) GetLocalApplicationDataForScheduleTest(int DrivingLicenseApplicationID,int TestType=1)
        {
            string className = "";
            string Name = "";
            int Trial = -1;
            int Fee = -1;

            SqlConnection connection = new SqlConnection(ConnectionsDAL.ConnectionString);
            String Query = @"SELECT 
                        dbo.LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID,
                        dbo.LicenseClasses.ClassName,
                        dbo.People.FirstName +
                        ' ' + dbo.People.SecondName +
                        ' ' + ISNULL(dbo.People.ThirdName, '') +
                        ' ' + dbo.People.LastName AS FullName,
                    
                        (Select  COUNT( * ) From Tests 
                    		inner join TestAppointments on Tests.TestAppointmentID=TestAppointments.TestAppointmentID
                    		inner join LocalDrivingLicenseApplications on                   TestAppointments.LocalDrivingLicenseApplicationID=LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID
                    		where LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID=
                            @LocalDrivingLicenseApplicationID and TestAppointments.TestTypeID=@TestType ) as Trial,
                    		(Select TestTypes.TestTypeFees From TestTypes
                    		WHERE TestTypeID=@TestType ) as TestTypeFees
                    FROM dbo.LocalDrivingLicenseApplications
                    INNER JOIN dbo.Applications 
                        ON dbo.LocalDrivingLicenseApplications.ApplicationID = dbo.Applications.ApplicationID
                    INNER JOIN dbo.LicenseClasses 
                        ON dbo.LocalDrivingLicenseApplications.LicenseClassID = dbo.LicenseClasses.LicenseClassID
                    INNER JOIN dbo.People 
                        ON dbo.Applications.ApplicantPersonID = dbo.People.PersonID
                    	where LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID;";

            //parameturs ...
            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", DrivingLicenseApplicationID);
            command.Parameters.AddWithValue("@TestType", TestType);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if(reader.Read())
                {
                    className =reader["ClassName"].ToString();
                    Name = reader["FullName"].ToString();
                    Trial = Convert.ToInt16(reader["Trial"]);
                    Fee = Convert.ToInt16(reader["TestTypeFees"]);
                    reader.Close();
                    return (className, Name, Trial, Fee);
                }
            }
            catch(Exception ex )
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }

            return ("", "", -1, -1);
        }


        public static bool DeleteLocalDrivingLicenseApplication(int LDLAppID)
        {
            int AffectedRows = 0;
            SqlConnection connection = new SqlConnection(ConnectionsDAL.ConnectionString);
            string query = @"Delete From LocalDrivingLicenseApplications
                             where LocalDrivingLicenseApplicationID=@LocalDrivingLicenseApplicationID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LDLAppID);
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


        public static
            (int RLAppID,
        DateTime ApplicationDate,
        DateTime IssueDate,
        int ApplicationFees,
        int LicenseFees,
        string Notes,
        int RenewedLicenseID,
        int OldLicenseID,
        DateTime ExpirationDate,
        string CreatedBy,
        int TotalFees) GetRenewLocalLicenseApplicationInfo(int LicenseID)
        {
            int RLAppID = -1;
            DateTime ApplicationDate = DateTime.MinValue;
            DateTime IssueDate = DateTime.MinValue;
            int ApplicationFees = -1;
            int LicenseFees = -1;
            string Notes = "";
            int RenewedLicenseID = -1;
            int OldLicenseID = -1;
            DateTime ExpirationDate = DateTime.MinValue;
            string CreatedBy = "";
            int TotalFees = -1;


            SqlConnection connection = new SqlConnection(ConnectionsDAL.ConnectionString);
            string query = @"";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@LicenseID", LicenseID);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();










                reader.Close();
            }
            catch(Exception ex)
            {

            }
            finally
            {
                connection.Close();
            }



            return (RLAppID, ApplicationDate, IssueDate, ApplicationFees, LicenseFees, Notes, RenewedLicenseID, OldLicenseID, ExpirationDate, CreatedBy, TotalFees);




        }





    }
}
