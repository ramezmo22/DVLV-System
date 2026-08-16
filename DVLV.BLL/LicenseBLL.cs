using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Text;
using static System.Net.Mime.MediaTypeNames;

namespace DVLV.BLL
{
    public class LicenseBLL
    {

        public static bool HasLicense(int ApplcationID)
        {
            return DAL.LicensesDAL.HasLicense(ApplcationID);
        }
        public static int GetLicenseIDByApplicationID(int ApplicationID)
        {
            return DAL.LicensesDAL.GetLicenseIDByApplicationID(ApplicationID);
        }

        public static bool IsLicenseDetaind(int LicenseID)
        {
            return DAL.LicensesDAL.IsLicenseDetaind(LicenseID);
        }
        public static DataTable GetLocalLicensesHistoryTable(int DriverID)
        {
            return DAL.LicensesDAL.GetLocalLicensesHistoryTable(DriverID);
        }
        public static DataTable GetInternationalLicensesHistoryTable(int DriverID)
        {
            return DAL.LicensesDAL.GetInternationalLicensesHistoryTable(DriverID);
        }
        public static bool IsLicenseActiveAndNonExpiared(int LicenseID)
        {
            (bool IsActive, DateTime ExpiarationDate) =DAL.LicensesDAL.LicenseActivationAndExpiareationDate(LicenseID);
            return IsActive && DateTime.Now <= ExpiarationDate;
        }
        public static bool IsLicenseActive(int LicenseID)
        {
            (bool IsActive, DateTime ExpiarationDate) = DAL.LicensesDAL.LicenseActivationAndExpiareationDate(LicenseID);
            return IsActive;
        }
        public static bool IsLicenseExpiared(int LicenseID)
        {
            (bool IsActive, DateTime ExpiarationDate) = DAL.LicensesDAL.LicenseActivationAndExpiareationDate(LicenseID);
            return DateTime.Now > ExpiarationDate;
        }
        public static DateTime GetExpirationDate(int LicenseID)
        {
            (bool IsActive, DateTime ExpiarationDate) = DAL.LicensesDAL.LicenseActivationAndExpiareationDate(LicenseID);
            return ExpiarationDate;
        }
        public static int GetLicenseClassID(int LocalLicenseID)
        {
            return DAL.LicensesDAL.GetLicenseClassID(LocalLicenseID);
        }

        public static int GetInternationalLicenseIDByLicenseID(int LocalLicenseID)
        {
            return DAL.LicensesDAL.GetInternationalLicenseIDByLicenseID(LocalLicenseID);
        }


        public static int AddNewLicense(BLL.ApplicationsBLL application,int PersonID,int DriverID,int LicenseClassID,DateTime ExpirationDate,string Notes,int LicenseFees,int IssueReason)
        {
            DriverID = BLL.DriverBLL.GetDriverIDByPersonID(PersonID);

            if (DriverID != -1)
            {
                int LicenseID = DAL.LicensesDAL.AddNewLicense(application.ApplicationID, DriverID, LicenseClassID, DateTime.Now, ExpirationDate, Notes, LicenseFees, true, IssueReason, application.CreatedByUser);
                if (LicenseID != -1)
                {
                    ApplicationsBLL.ChangeApplicationStatus(application.ApplicationID, 3, DateTime.Now);
                }
                return LicenseID;

            }
            else
            {
                return -1;
            }
        }

        public static bool ChangeLicenseStatus(int LicenseID)
        {
            return DAL.LicensesDAL.ChangeLicenseStatus(LicenseID);
        }


    }
}
