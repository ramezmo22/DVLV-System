using DVLV.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace DVLV.BLL
{
    public class ApplicationsBLL
    {
        public int ApplicationID { get; set; } = -1; // سيتم تعيينه من قاعدة البيانات
        public int PersonID { get; set; } = -1;
        public DateTime Date { get; set; }
        public int TypeID { get; set; } = -1;
        public int StutusID { get; set; } = 1; // 1: New, 2: Cancelled, 3: Completed
        public DateTime LastStutusDate { get; set; }
        public int PaidFees { get; set; } = 0;
        public int CreatedByUser { get; set; } = CurrentUserBLL.UserID;


        public enum enMood { New = 0, Update = 1 };
        private enMood Mood = enMood.New;






        // Constructor for updating information
        public ApplicationsBLL(
            int applicationID,
            int applicationPersonID,
            DateTime? applicationDate = null,
            int applicatrionTypeID = 1,// For New Local License 
            int applicationStutusID = 1,
            int applicationPaidFees = 0,
            DateTime? lastStutusDate = null,
            int createdByUser = 0)
        {
            ApplicationID = applicationID;
            PersonID = applicationPersonID;
            Date = applicationDate ?? DateTime.Now; // Default to current date
            TypeID = applicatrionTypeID;
            StutusID = applicationStutusID;
            PaidFees = applicationPaidFees;
            LastStutusDate = lastStutusDate ?? DateTime.Now; // Default to current date
            CreatedByUser = CurrentUserBLL.UserID;
            Mood = enMood.Update;
        }
                public ApplicationsBLL(
            int applicationPersonID,
            DateTime? applicationDate = null,
            int applicatrionTypeID = 1,// For New Local License 
            int applicationStutusID = 1,
            int applicationPaidFees = 0,
            DateTime? lastStutusDate = null,
            int createdByUser = 0)
        {
            PersonID = applicationPersonID;
            Date = applicationDate ?? DateTime.Now; // Default to current date
            TypeID = applicatrionTypeID;
            StutusID = applicationStutusID;
            PaidFees = applicationPaidFees;
            LastStutusDate = lastStutusDate ?? DateTime.Now; // Default to current date
            CreatedByUser = CurrentUserBLL.UserID;
            Mood = enMood.New;
        }


        public ApplicationsBLL(int applicationPersonID)
        {
            PersonID = applicationPersonID;
            Date = DateTime.Now; // Set to current date
            TypeID = 1; 
            StutusID = 1; // New application status
            PaidFees = -1;
            LastStutusDate = DateTime.Now; // Set to current date
            CreatedByUser = CurrentUserBLL.UserID;
            Mood = enMood.New;
        }


        public static ApplicationsBLL Find(int ApplicaID)
        {
            DataRow row = DVLV.DAL.ApplicationsDAL.GetApplicationData(ApplicaID);

            if (row != null)
            {
                return new ApplicationsBLL(
                    ApplicaID,
                    Convert.ToInt32(row["ApplicantPersonID"]),
                    Convert.ToDateTime(row["ApplicationDate"]),
                    Convert.ToInt32(row["ApplicationTypeID"]),
                    Convert.ToInt32(row["ApplicationStatus"]),
                    Convert.ToInt16(row["PaidFees"]),
                    Convert.ToDateTime(row["LastStatusDate"]),
                    Convert.ToInt32(row["CreatedByUserID"])
                );
            }
            else return null;
        }

        public void setPaydFees(int TypeID)
        {
            PaidFees = (int)DVLV.DAL.ApplicationTypesDAL.GetApplicationTypePrice(TypeID);
        }

        public int AddNew()
        {
            int NewAppID = -1;
            NewAppID= DVLV.DAL.ApplicationsDAL.AddApplication(PersonID, Date, TypeID, StutusID, LastStutusDate, PaidFees, CreatedByUser);
            return NewAppID != -1 ? NewAppID : -1;
        }


        private bool Update()
        {
            return false;
        }


        public bool Save()
        {
            switch (Mood)
            {
                case enMood.New:
                    {
                        int NewAppl = AddNew();
                        if (NewAppl > 0)
                        {
                            this.ApplicationID = NewAppl;
                            return true;
                        }
                        else return false;
                    }
                case enMood.Update:
                    {
                        return Update();
                    }
            }
            return false;
        }





        //public static int IsPersonHasApplication(int PersonID,int ApplicationTypeID,int ApplicationStatus)
        //{


        //    return -1;
        //}


        public static bool ChangeApplicationStatus(int ApplciationID,int ApplcationStatus,DateTime LastStatusDate)
        {
            return DVLV.DAL.ApplicationsDAL.UpdateApplicationStatus(ApplciationID, ApplcationStatus,LastStatusDate);
        }

        public static bool DeleteApplication(int ApplicationID)
        {
            return DVLV.DAL.ApplicationsDAL.DeleteApplication(ApplicationID);
        }


        
        public static int GetApplicationIDByLicenseID(int LicenseID)
        {
            return DVLV.DAL.ApplicationsDAL.GetApplicationIDByLicenseID(LicenseID);
        }






    }
}
