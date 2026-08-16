using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Diagnostics.Metrics;
using System.Globalization;
using System.IO;


namespace DVLV.DAL
{
    public class PeopleDAL
    {
        //CRUD : Add Delete Update get 

        public static bool DeletePerson(int PersonID)
        {
            SqlConnection connection = new SqlConnection(ConnectionsDAL.ConnectionString);
            String query = @"Delete From People where PersonID = @PersonID";
            SqlCommand command = new SqlCommand(query, connection);
            bool isSuccess = false;

            //Parameters
            command.Parameters.AddWithValue("@PersonID", PersonID);

            try
            {
                connection.Open();
               if( command.ExecuteNonQuery() > 0)
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
        public static DataTable PeopleDataSet()
        {
            SqlConnection connection = new SqlConnection(ConnectionsDAL.ConnectionString);
            string query = "Select * From People";
            SqlCommand command = new SqlCommand(query, connection);
            DataTable PeopleTable = new DataTable("People");

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                PeopleTable.Load(reader);
                reader.Close();


            }
            catch
            {

            }
            finally
            {
                connection.Close();
            }
            return PeopleTable;

        }
        public static DataTable PeopleDataTable_GridRows()
        {
            SqlConnection connection = new SqlConnection(ConnectionsDAL.ConnectionString);
            string query = @"SELECT 
                                PersonID, 
                                NationalNo, 
                                FirstName, 
                                SecondName, 
                                ThirdName, 
                                LastName, 
                                Gendor, 
                                DateOfBirth, 
                                Countries.CountryName,
                                Phone, 
                                Email 
                            FROM People
							join Countries on People.NationalityCountryID=Countries.CountryID;";
            SqlCommand command = new SqlCommand(query, connection);
            DataTable PeopleTable = new DataTable("People");

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                PeopleTable.Load(reader);
                reader.Close();
            }
            catch
            {

            }
            finally
            {
                connection.Close();
            }
            return PeopleTable;

        }
        public static int GetCountryID(string Country)
        {
            int ID = 90;
            SqlConnection connection = new SqlConnection(ConnectionsDAL.ConnectionString);
            String query = @"Select Countries.CountryID from Countries where CountryName = @Country";
            SqlCommand command = new SqlCommand(query, connection);

            //Parameters
            command.Parameters.AddWithValue("@Country", Country);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read()) // التأكد من وجود صف
                {
                    ID = (int)reader["CountryID"];
                }
                reader.Close();
                return ID;
            }
            catch (Exception ex)
            {

            }
            finally
            {
                connection.Close();
            }
            return ID;

        }
        public static int FindPersonByNationalNumber(String NutionalNum)
        {
            int ID = -1;
            SqlConnection connection = new SqlConnection(ConnectionsDAL.ConnectionString);
            String query = @"Select personID from People where NationalNo = @NutionalNum";
            SqlCommand command = new SqlCommand(query, connection);

            //Parameters
            command.Parameters.AddWithValue("@NutionalNum", NutionalNum);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read()) // التأكد من وجود صف
                {
                    ID = (int)reader["personID"];
                }
                reader.Close();
                return ID;
            }
            catch (Exception ex)
            {

            }
            finally
            {
                connection.Close();
            }
            return ID;






        }
        public static int AddNewPerson(PersonDataTransferObject PersonData)
        {
            int PersonID = -1;
            SqlConnection connection = new SqlConnection(ConnectionsDAL.ConnectionString);
            String query = @"
                INSERT INTO People (
                   
                    NationalNo,
                    FirstName,
                    SecondName,
                    ThirdName,
                    LastName,
                    DateOfBirth,
                    Gendor,
                    Address,
                    Phone,
                    Email,
                    NationalityCountryID,
                    ImagePath
                )
                VALUES (
                  
                    @NationalNo,
                    @FirstName,
                    @SecondName,
                    @ThirdName,
                    @LastName,
                    @DateOfBirth,
                    @Gendor,
                    @Address,
                    @Phone,
                    @Email,
                    @NationalityCountryID,
                    @ImagePath
                )";
            SqlCommand command = new SqlCommand(query, connection);


            command.Parameters.AddWithValue("@NationalNo", PersonData.NationalNo);
            command.Parameters.AddWithValue("@FirstName", PersonData.FirstName);
            command.Parameters.AddWithValue("@SecondName", PersonData.SecondName);
            command.Parameters.AddWithValue("@LastName", PersonData.LastName);
            command.Parameters.AddWithValue("@DateOfBirth", PersonData.DateOfBirth);
            command.Parameters.AddWithValue("@Gendor", PersonData.Gendor);
            command.Parameters.AddWithValue("@Address", PersonData.Address);
            command.Parameters.AddWithValue("@Phone", PersonData.Phone);
            command.Parameters.AddWithValue("@NationalityCountryID", PersonData.CountryID);
            if (PersonData.ThirdName != "" && PersonData.ThirdName != null)
            {
                command.Parameters.AddWithValue("@ThirdName", PersonData.ThirdName);
            }
            else command.Parameters.AddWithValue("@ThirdName", DBNull.Value);
            if (PersonData.Email != "" && PersonData.Email != null)
            {
                command.Parameters.AddWithValue("@Email", PersonData.Email);
            }
            else command.Parameters.AddWithValue("@Email", DBNull.Value);
            if (PersonData.Email != "" && PersonData.Email != null)
            {
                command.Parameters.AddWithValue("@ImagePath", PersonData.ImagePath);
            }
            else command.Parameters.AddWithValue("@ImagePath", DBNull.Value);





            try
            {
                connection.Open();
                command.CommandText += "; SELECT SCOPE_IDENTITY();";
                object result = command.ExecuteScalar();


                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    PersonID = insertedID;
                    PersonData.PersonID = PersonID;//for Future
                    return PersonID;
                }

            }
            catch (Exception ex)
            {

            }
            finally
            {
                connection.Close();
            }
            return PersonID;
        }

        public static bool IsPersonExists(int ID)
        {
            // إنشاء اتصال بقاعدة البيانات
            SqlConnection connection = new SqlConnection(ConnectionsDAL.ConnectionString);

            // جملة الاستعلام للبحث عن الشخص حسب الـ ID
            string query = @"Select PersonID From People 
                             Where PersonID = @PersonID";

            // إنشاء أمر SQL وربطه بالاتصال
            SqlCommand command = new SqlCommand(query, connection);

            // إضافة قيمة الباراميتر
            command.Parameters.AddWithValue("@PersonID", ID);

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
                // في حال حدوث خطأ، نعيد false
                return false;
            }
            finally
            {
                // إغلاق الاتصال
                connection.Close();
            }
        }

        public static PersonDataTransferObject FindPersonByID(int ID)
        {
            // إنشاء اتصال بقاعدة البيانات
            SqlConnection connection = new SqlConnection(ConnectionsDAL.ConnectionString);

            // جملة الاستعلام لجلب بيانات الشخص حسب الـ ID
            string query = @"Select * From People 
                             Where PersonID = @PersonID";

            // إنشاء أمر SQL وربطه بالاتصال
            SqlCommand command = new SqlCommand(query, connection);

            // إضافة قيمة الباراميتر
            command.Parameters.AddWithValue("@PersonID", ID);

            // إنشاء كائن فارغ من نوع PersonDataTransferObject
            PersonDataTransferObject person = new PersonDataTransferObject();

            try
            {
                // فتح الاتصال
                connection.Open();

                // تنفيذ الاستعلام وجلب البيانات
                SqlDataReader reader = command.ExecuteReader();

                // إذا وجد صف واحد على الأقل
                if (reader.Read())
                {
                    // تعبئة بيانات الشخص من النتائج
                    person.PersonID = Convert.ToInt32(reader["PersonID"]);
                    person.NationalNo = reader["NationalNo"].ToString();
                    person.FirstName = reader["FirstName"].ToString();
                    person.SecondName = reader["SecondName"].ToString();
                    person.ThirdName = reader["ThirdName"] != DBNull.Value ? reader["ThirdName"].ToString() : "";
                    person.LastName = reader["LastName"].ToString();
                    person.DateOfBirth = Convert.ToDateTime(reader["DateOfBirth"]);
                    person.Gendor = Convert.ToInt16(reader["Gendor"]);
                    person.Address = reader["Address"].ToString();
                    person.Phone = reader["Phone"].ToString();
                    person.Email = reader["Email"] != DBNull.Value ? reader["Email"].ToString() : "";
                    person.CountryID = Convert.ToInt32(reader["NationalityCountryID"]);
                    person.ImagePath = reader["ImagePath"] != DBNull.Value ? reader["ImagePath"].ToString() : "";
                }

                // إغلاق القارئ
                reader.Close();
            }
            catch (Exception ex)
            {
                // في حال حدوث خطأ، نعيد الكائن كما هو (فارغ)
            }
            finally
            {
                // إغلاق الاتصال
                connection.Close();
            }

            // إعادة الكائن المعبأ أو الفارغ
            return person;
        }

        public static bool UpdatePersonInfo(PersonDataTransferObject PersonData)
        {
            // إنشاء اتصال بقاعدة البيانات
            SqlConnection connection = new SqlConnection(ConnectionsDAL.ConnectionString);
            // جملة الاستعلام لتحديث بيانات الشخص
            string query = @"
                UPDATE People
                SET 
                    NationalNo = @NationalNo,
                    FirstName = @FirstName,
                    SecondName = @SecondName,
                    ThirdName = @ThirdName,
                    LastName = @LastName,
                    DateOfBirth = @DateOfBirth,
                    Gendor = @Gendor,
                    Address = @Address,
                    Phone = @Phone,
                    Email = @Email,
                    NationalityCountryID = @NationalityCountryID,
                    ImagePath = @ImagePath
                WHERE PersonID = @PersonID";
            // إنشاء أمر SQL وربطه بالاتصال
            SqlCommand command = new SqlCommand(query, connection);
            // إضافة قيم الباراميترات
            command.Parameters.AddWithValue("@NationalNo", PersonData.NationalNo);
            command.Parameters.AddWithValue("@FirstName", PersonData.FirstName);
            command.Parameters.AddWithValue("@SecondName", PersonData.SecondName);
            command.Parameters.AddWithValue("@LastName", PersonData.LastName);
            command.Parameters.AddWithValue("@DateOfBirth", PersonData.DateOfBirth);
            command.Parameters.AddWithValue("@Gendor", PersonData.Gendor);
            command.Parameters.AddWithValue("@Address", PersonData.Address);
            command.Parameters.AddWithValue("@Phone", PersonData.Phone);
            command.Parameters.AddWithValue("@NationalityCountryID", PersonData.CountryID);
            if (PersonData.ThirdName != "" && PersonData.ThirdName != null)
            {
                command.Parameters.AddWithValue("@ThirdName", PersonData.ThirdName);
            }
            else command.Parameters.AddWithValue("@ThirdName", DBNull.Value);
            if (PersonData.Email != "" && PersonData.Email != null)
            {
                command.Parameters.AddWithValue("@Email", PersonData.Email);
            }
            else command.Parameters.AddWithValue("@Email", DBNull.Value);
            if (PersonData.Email != "" && PersonData.Email != null)
            {
                command.Parameters.AddWithValue("@ImagePath", PersonData.ImagePath);
            }
            else command.Parameters.AddWithValue("@ImagePath", DBNull.Value);
            command.Parameters.AddWithValue("@PersonID", PersonData.PersonID);
            try
            {
                // فتح الاتصال
                connection.Open();
                int result = command.ExecuteNonQuery();
                if (result == 0)
                    return false;

                // تنفيذ الأمر وتحقق من عدد الصفوف
            }
            catch (Exception ex)
            {
                // في حال حدوث خطأ، نعيد false
                return false;
            }
            finally
            {
                // إغلاق الاتصال
                connection.Close();
            }
            return true;
        }

        public static DateTime GetPersonAge(int PersonID)
        {
            DateTime BirthDate = DateTime.Now.AddYears(-18);
            SqlConnection connection = new SqlConnection(ConnectionsDAL.ConnectionString);
            string q = @"Select DateOfBirth From People
                       Where PersonID=@PersonID";
            SqlCommand command = new SqlCommand(q, connection);
            command.Parameters.AddWithValue("@PersonID", PersonID);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    BirthDate = Convert.ToDateTime(reader["DateOfBirth"]);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                // Optionally log the exception
            }
            finally
            {
                connection.Close();
            }
            return BirthDate;
        }

        public static String GetPersonFullName(int PersonID)
        {
            string FullName = "";
            SqlConnection connection = new SqlConnection(ConnectionsDAL.ConnectionString);

            string q = @"
                        	SELECT 
                            FullName = LTRIM(RTRIM(
                                ISNULL(People.FirstName, '') + ' ' +
                                ISNULL(People.SecondName, '') + ' ' +
                                ISNULL(People.ThirdName, '') + ' ' +
                                ISNULL(People.LastName, '')
                            ))
                        FROM People
                        where PersonID=@PersonID;";

            SqlCommand command = new SqlCommand(q, connection);
            command.Parameters.AddWithValue("@PersonID", PersonID);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    FullName = Convert.ToString(reader["FullName"]);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                // Optionally log the exception
            }
            finally
            {
                connection.Close();
            }
            return FullName;
        }

        public static int GetPersonIDByApplicationID(int ApplicaionID)
            {
            int PersonID = -1;
            SqlConnection connection = new SqlConnection(ConnectionsDAL.ConnectionString);
            string query = @"Select Applications.ApplicantPersonID From Applications 
                        where ApplicationID=@ApplicaionID;";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ApplicaionID", ApplicaionID);
            try
            {
                connection.Open();
                var result = command.ExecuteScalar();
                if(result==null)
                {
                    return -1;
                }
                else
                {
                    int.TryParse(result.ToString(), out PersonID);
                }

            }
            catch (Exception ex )
            {

            }
            finally
            {
                connection.Close();
            }
            return PersonID;

        }

        public static int GetPersonIDByDriverID(int DriverID)
        {
            int PersonID = -1;
            SqlConnection connection = new SqlConnection(ConnectionsDAL.ConnectionString);
            string query = @"Select PersonID From Drivers 
                        where DriverID=@DriverID;";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@DriverID", DriverID);
            try
            {
                connection.Open();
                var result = command.ExecuteScalar();
                if (result == null)
                {
                    return -1;
                }
                else
                {
                    int.TryParse(result.ToString(), out PersonID);
                }

            }
            catch (Exception ex)
            {

            }
            finally
            {
                connection.Close();
            }
            return PersonID;
        }


    }
    public class PersonDataTransferObject
    {
        public int PersonID { get; set; }
        public string NationalNo { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string ThirdName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public short Gendor { get; set; }// 0 or 1  : 0 Male 1 Female
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public int CountryID { get; set; }
        public string ImagePath { get; set; }


    }
}
