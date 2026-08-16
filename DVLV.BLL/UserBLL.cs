using DVLV.DAL;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Data;
using System.Diagnostics;
using static DVLV.DAL.UsersDAL;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace DVLV.BLL
{
    public class UserBLL
    {

        public int UserID { get; set; } = -1;
        public int PersonID { get; set; } = -1;
        public string UserName { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;

        public bool IsActive { get; set; } = false;
        public enum enMode { AddNew, Update }
        public enMode Mode;
        public UserBLL()
        {
            Mode = enMode.AddNew;
            this.UserID = -1;
            this.PersonID = -1;
            this.UserName = string.Empty;
            this.Password = string.Empty;
            this.IsActive = false;

        }
        public UserBLL(UserDataTransferObject obj)
        {
            this.UserID = obj.UserID;
            this.PersonID = obj.PersonID;
            this.UserName = obj.UserName;
            this.Password = obj.Password;
            this.IsActive = obj.IsActive;
            this.Mode = enMode.Update;
        }

        public bool CheckUserNamePassword()
        {
            int UserID = UsersDAL.CheckUserNamePassword(this.UserName, PasswordEncryption.Encrypt(this.Password));
            if (UserID != -1)
            {
                this.UserID = UserID;
                return true;
            }
            else return false;
        }
        public bool IsUserActive()
        {
            return UsersDAL.IsUserActive(this.UserID);
        }

        private bool _AddUser()
        {

            // Build DTO from current BLL instance
            UserDataTransferObject obj = new UserDataTransferObject();

            obj.UserName = this.UserName;



            obj.Password = PasswordEncryption.Encrypt(this.Password);
            obj.PersonID = this.PersonID;
            obj.IsActive = this.IsActive;
            obj.UserID = -1;


            this.UserID = UsersDAL.AdddNewUser(obj);

            return (this.UserID != -1);
        }
        private bool _UpdateUser()
        {
            UserDataTransferObject Data = new UserDataTransferObject();
            
            Data.UserID = this.UserID;
            Data.PersonID = this.PersonID;
            Data.UserName = this.UserName;
            Data.Password = PasswordEncryption.Encrypt(this.Password);
            Data.IsActive = this.IsActive;
            
            return UsersDAL.UpdateUser(Data);
        }
        public bool Save()
        {



            switch (Mode)
            {

                case enMode.AddNew:
                    {

                        if (_AddUser())
                        {
                            Mode = enMode.Update;
                            return true;
                        }
                        else return false;
                    }
                case enMode.Update:
                    {
                        return (_UpdateUser());
                    }


            }



            return false;
        }

        public static int GetUserID(string UserName, string Password)
        {
            int UserID = DAL.UsersDAL.CheckUserNamePassword(UserName, PasswordEncryption.Encrypt(Password));
            if (UserID != -1)
            {
                return UserID;
            }
            else return -1;
        }


        enum enFilterationType
        {
            None = 0,
            UserID = 1,
            PersonID = 2,
            FullName = 3,
            UserName = 4,
            IsActive=5
        };
        public static DataTable LoadDataToGridView(int FilterationNumber = 0, string filterValue = "")
        {
            // تحميل البيانات من المصدر
            DataTable filteredUserData = UsersDAL.GetUsersData();

            // تحديد نوع التصفية
            enFilterationType filter = (enFilterationType)FilterationNumber;

            switch (filter)
            {
                case enFilterationType.None:
                    // إذا لم يتم تحديد أي تصفية، يتم إرجاع البيانات كما هي
                    return filteredUserData;

                case enFilterationType.UserID:
                    // تصفية بناءً على UserID (رقمي)
                    return FilterDataTable(filteredUserData, "UserID", filterValue, isInt: true);

                case enFilterationType.PersonID:
                    // تصفية بناءً على PersonID (رقمي)
                    return FilterDataTable(filteredUserData, "PersonID", filterValue, isInt: true);

                case enFilterationType.FullName:
                    // تصفية بناءً على FullName (نصي، باستخدام LIKE)
                    return FilterDataTable(filteredUserData, "FullName", filterValue, useLike: true);

                case enFilterationType.UserName:
                    // تصفية بناءً على UserName (نصي، باستخدام LIKE)
                    return FilterDataTable(filteredUserData, "UserName", filterValue, useLike: true);

                case enFilterationType.IsActive:
                    return FilterDataTable(filteredUserData, "IsActive", filterValue);//all,Yes,No
                default:
                    // إذا كان نوع التصفية غير معروف، يتم إرجاع البيانات كما هي
                    return filteredUserData;
            }
        }
        private static DataTable FilterDataTable(DataTable data, string columnName, string value, bool isInt = false, bool useLike = false)
        {
            if (string.IsNullOrEmpty(value))
            {
                return data; // إذا لم يتم تحديد قيمة، يتم إرجاع الجدول الأصلي
            }

            // Normalize column names to remove spaces
            string normalizedColumnName = columnName.Replace(" ", "");
            foreach (DataColumn column in data.Columns)
            {
                if (column.ColumnName.Replace(" ", "").Equals(normalizedColumnName, StringComparison.OrdinalIgnoreCase))
                {
                    columnName = column.ColumnName;
                    break;
                }
            }

            string filteringQuery;

            if (isInt)
            {
                filteringQuery = $"[{columnName}] = {value}"; // Escaping column names with brackets
            }
            else if (useLike)
            {
                filteringQuery = $"[{columnName}] LIKE '%{value}%'"; // Escaping column names with brackets
            }
            else
            {
                filteringQuery = $"[{columnName}] = '{value}'"; // Escaping column names with brackets
            }
            if (columnName == "IsActive")
            {
                if (value == "All")
                {
                    return data; // إذا كانت القيمة "All"، يتم إرجاع الجدول الأصلي بدون تصفية
                }
                if (value == "Yes")
                {
                    filteringQuery = $"{columnName} = 'True'"; // تصفية القيم النشطة
                }
                if (value == "No")
                {
                    filteringQuery = $"{columnName} = 'False'"; // تصفية القيم غير النشطة
                }
            }

            DataRow[] filteringRows = data.Select(filteringQuery); // تصفية الصفوف بناءً على الشرط
            DataTable filteredTable = data.Clone(); // إنشاء نسخة من هيكل الجدول

            foreach (DataRow row in filteringRows)
            {
                filteredTable.ImportRow(row); // نسخ الصفوف المصفاة إلى الجدول الجديد
            }

            return filteredTable; // إرجاع الجدول المصفى
        }


        public static bool ISPersonAUser(int PersonID)
        {
            if (CheckIfPersonIsAUser(PersonID))
            {
                return true;
            }
            else return false;
        }

        public static bool IsUserExists(int UserID)
        {
            return (UsersDAL.CheckUserExistance(UserID));
        }

        public static UserDataTransferObject GetUsersDataByUserID(int UserID)
        {     
                return UserData(UserID);    
        }

        public static UserBLL FindUser(int PersonID)
        {
            if (IsUserExists(PersonID))
            {
                return new UserBLL(GetUsersDataByUserID(PersonID));
            }
            else
            return new UserBLL();

        }
        public static UserBLL FindUserByPersonID(int PersonID)
        {
        
            
            int GettenUserID=GetUserIDByPersonID(PersonID);
            if(GettenUserID!=-1)    
            return new UserBLL(UserData(GettenUserID));
            else
            return new UserBLL();

        }
        public static bool DeleteUser(int UserID)
        {
            return DeleteSelectedUser(UserID);


        }



        public static String GetUsreName(int UserID)
        {

            return DAL.UsersDAL.GetUserName(UserID);

        }
    }
}


