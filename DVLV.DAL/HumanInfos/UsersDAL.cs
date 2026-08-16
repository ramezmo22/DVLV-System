using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace DVLV.DAL
{
    public class UsersDAL
    {

        public static bool DeleteUser(int UserID)
        {
            SqlConnection connection = new SqlConnection(ConnectionsDAL.ConnectionString);
            String query = @"Delete From Users where UserID = @UserID";
            SqlCommand command = new SqlCommand(query, connection);
            bool isSuccess = false;

            //Parameters
            command.Parameters.AddWithValue("@UserID", UserID);

            try
            {
                connection.Open();
                if (command.ExecuteNonQuery() > 0)
                {
                    isSuccess = true;
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                connection.Close();
            }
            return isSuccess;
        }



        //public static bool UpdateUserInfo(UserDataTransferObject UserData)
        //{
        //    // إنشاء اتصال بقاعدة البيانات
        //    SqlConnection connection = new SqlConnection(ConnectionsDAL.ConnectionString);

        //}

        public static int CheckUserNamePassword(string UserName, string Password)
        {
            int UserId = -1;
            SqlConnection connection = new SqlConnection(ConnectionsDAL.ConnectionString);
            String query = @"Select UserID From Users where UserName = @UserName and Password = @Password";
            SqlCommand command = new SqlCommand(query, connection);
            //Parameters
            command.Parameters.AddWithValue("@UserName", UserName);
            command.Parameters.AddWithValue("@Password", Password);

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();//ExecuteScalar() is used to retrieve a single value from the database, which is the UserID in this case. It returns null if no matching record is found.
                if (result != null)
                {
                    UserId = Convert.ToInt32(result);
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions (e.g., log the error)
            }
            finally
            {
                connection.Close();
            }
            return UserId;
        }


        public static bool IsUserActive(int UserID)
        {
            bool isActive = false;
            SqlConnection connection = new SqlConnection(ConnectionsDAL.ConnectionString);
            String query = @"Select IsActive From Users where UserID = @UserID";
            SqlCommand command = new SqlCommand(query, connection);
            //Parameters
            command.Parameters.AddWithValue("@UserID", UserID);
            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                if (result != null)
                {
                    isActive = Convert.ToBoolean(result);
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions (e.g., log the error)
            }
            finally
            {
                connection.Close();
            }
            return isActive;
        }


        public static DataTable GetUsersData()
        {
            DataTable UsersTable = new DataTable();

            using (SqlConnection connection = new SqlConnection(ConnectionsDAL.ConnectionString))
            {
                string query = "SELECT \r\n    [User ID]   = Users.UserID,\r\n    [Person ID] = Users.PersonID,\r\n    [Full Name] = CONCAT(COALESCE(People.FirstName, ''), ' ', \r\n        COALESCE(People.SecondName, ''), ' ', \r\n        COALESCE(People.ThirdName, ''), ' ', \r\n        COALESCE(People.LastName, '')),\r\n    Users.UserName,\r\n    Users.IsActive\r\nFROM Users\r\nINNER JOIN People \r\n    ON People.PersonID = Users.PersonID;";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        connection.Open(); // Open the connection
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            UsersTable.Load(reader);
                        }
                    }
                    catch (Exception ex)
                    {
                        // Log or handle the exception
                        throw new Exception("An error occurred while fetching users data.", ex);
                    }
                }
            }

            return UsersTable;
        }


        public static bool CheckIfPersonIsAUser(int PersonID)
        {
            SqlConnection connection = new SqlConnection(ConnectionsDAL.ConnectionString);
            String Query = "Select PersonID From Users \r\nwhere PersonID=@PersonID;";
            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@PersonID", PersonID);
            try
            {
                // فتح الاتصال
                connection.Open();

                // تنفيذ الاستعلام وجلب أول نتيجة (إن وجدت)
                object result = command.ExecuteScalar();

                // إذا كانت النتيجة ليست null، إذًا الشخص موجود
                if (result != null)
                    return true;
                else
                    return false;


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
        public static int GetUserIDByPersonID(int PersonID)
        {
            int UserID = -1; // القيمة الافتراضية إذا لم يتم العثور على نتيجة
            SqlConnection connection = new SqlConnection(ConnectionsDAL.ConnectionString);
            string Query = "Select UserID From Users where PersonID=@PersonID;";
            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@PersonID", PersonID); // تأكد من استخدام الباراميتر الصحيح

            try
            {
                // فتح الاتصال
                connection.Open();

                // تنفيذ الاستعلام وجلب أول نتيجة (إن وجدت)
                object result = command.ExecuteScalar();

                // إذا كانت النتيجة ليست null، قم بتعيينها إلى UserID
                if (result != null)
                {
                    UserID = Convert.ToInt32(result);
                }
            }
            catch (Exception ex)
            {
                // يمكن تسجيل الخطأ هنا إذا لزم الأمر
            }
            finally
            {
                // إغلاق الاتصال
                connection.Close();
            }

            return UserID; // إرجاع UserID الصحيح
        }


        public static int AdddNewUser(UserDataTransferObject userData)
        {
            SqlConnection connection = new SqlConnection(ConnectionsDAL.ConnectionString);
            string query = "Insert Into Users (PersonID, UserName, Password, IsActive) " +
                           "values (@PersonID, @UserName, @Password, @IsActive); " +
                           "SELECT SCOPE_IDENTITY();"; // للحصول على المعرف الجديد الذي تم إنشاؤه
            SqlCommand command = new SqlCommand(query, connection);
            int newUserId = -1;

            // إضافة المعاملات
            command.Parameters.AddWithValue("@PersonID", userData.PersonID);
            command.Parameters.AddWithValue("@UserName", userData.UserName);
            command.Parameters.AddWithValue("@Password", userData.Password);
            command.Parameters.AddWithValue("@IsActive", userData.IsActive); // افتراض أن المستخدم الجديد نشط

            try
            {
                connection.Open();
                object result = command.ExecuteScalar(); // استرجاع المعرف الجديد
                if (result != null)
                {
                    newUserId = Convert.ToInt32(result);
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                connection.Close();
            }

            return newUserId;
        }


        public static bool CheckUserExistance(int UserID)
        {
            SqlConnection connection = new SqlConnection(ConnectionsDAL.ConnectionString);
            string query = @"Select UserID From Users 
                             Where UserID = @UserID";

            // إنشاء أمر SQL وربطه بالاتصال
            SqlCommand command = new SqlCommand(query, connection);

            // إضافة قيمة الباراميتر
            command.Parameters.AddWithValue("@UserID", UserID);

            try
            {
                // فتح الاتصال
                connection.Open();

                // تنفيذ الاستعلام وجلب أول نتيجة (إن وجدت)
                object result = command.ExecuteScalar();

                // إذا كانت النتيجة ليست null، إذًا الشخص موجود
                if (result != null)
                    return true;

            }
            catch (Exception ex)
            {
                // في حال حدوث خطأ، نعيد false

            }
            finally
            {
                // إغلاق الاتصال
                connection.Close();
            }
            return false;


        }

        public static UserDataTransferObject UserData(int userID)
        {
            UserDataTransferObject userData = null;
            SqlConnection connection = new SqlConnection(ConnectionsDAL.ConnectionString);
            string query = @"SELECT UserID, PersonID, UserName, Password , IsActive 
                             FROM Users 
                             WHERE UserID = @UserID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@UserID", userID);

            try
            {
                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {

                    if (reader.Read())
                    {
                        userData = new UserDataTransferObject
                        {
                            UserID = Convert.ToInt32(reader["UserID"]),
                            PersonID = Convert.ToInt32(reader["PersonID"]),
                            UserName = reader["UserName"].ToString(),
                            Password = PasswordEncryption.Decrypt(reader["Password"].ToString()),
                            IsActive = Convert.ToBoolean(reader["IsActive"])
                        };
                    }
                }
            }
            catch (Exception ex)
            {
                // Log or handle the exception
                throw new Exception("An error occurred while fetching user data.", ex);
            }
            finally
            {
                connection.Close();
            }

            return userData;
        }
        public static bool UpdateUser(UserDataTransferObject Data)
        {
            SqlConnection connection = new SqlConnection(ConnectionsDAL.ConnectionString);
            string query = @"UPDATE Users 
                           SET UserName = @UserName ,
                               Password = @Password ,
                               IsActive = @IsActive
                               WHERE UserID = @UserID; ";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@UserName", Data.UserName);
            command.Parameters.AddWithValue("@Password", Data.Password);
            command.Parameters.AddWithValue("@IsActive", Data.IsActive);
            command.Parameters.AddWithValue("@UserID", Data.UserID);
            try
            {
                connection.Open();
                if (command.ExecuteNonQuery() > 0)
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                // Log error
            }
            finally
            {
                connection.Close();
            }
            return false;
        }
        public static bool UpdatePassword(string UserID, string NewPassword)
        {
            SqlConnection connection = new SqlConnection(ConnectionsDAL.ConnectionString);
            string query = @"UPDATE Users 
                           SET 
                               Password = @Password ,
                               
                               WHERE UserID = @UserID; ";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Password", NewPassword);
            command.Parameters.AddWithValue("@UserID", UserID);
            try
            {
                connection.Open();
                if (command.ExecuteNonQuery() > 0)
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                // Log error
            }
            finally
            {
                connection.Close();
            }
            return false;
        }

        public static bool DeleteSelectedUser(int UserID)
        {
            SqlConnection connection = new SqlConnection(ConnectionsDAL.ConnectionString);
            String query = @"Delete From Users where UserID= @UserID";
            SqlCommand command = new SqlCommand(query, connection);
            bool isSuccess = false;

            //Parameters
            command.Parameters.AddWithValue("@UserID", UserID);

            try
            {
                connection.Open();
                if (command.ExecuteNonQuery() > 0)
                {
                    isSuccess = true;
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                connection.Close();
            }
            return isSuccess;
        }

        public static String GetUserName(int UserID)
        {
            string UserName = "";
            SqlConnection connection = new SqlConnection(ConnectionsDAL.ConnectionString);
            String Query = "Select Username From Users where UserID=@UserID;";
            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@UserID", UserID);
            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null)
                    UserName = result.ToString();
                else
                    UserName = "Non Found !";


            }
            catch (Exception ex)
            {

            }
            finally
            {
                connection.Close();
            }

            return UserName;
        }
    }


}
        public class UserDataTransferObject
        {
            public int UserID { get; set; }
            public int PersonID { get; set; }
            public string UserName { get; set; }
            public string Password { get; set; }

            public bool IsActive { get; set; }



        }
    

