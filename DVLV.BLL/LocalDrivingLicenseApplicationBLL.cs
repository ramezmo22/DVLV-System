using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks.Dataflow;
using DVLV.DAL;
using Microsoft.Identity.Client;

namespace DVLV.BLL
{
    public class LocalDrivingLicenseApplicationBLL
    {
        public int ApplicationID { set; get; } = -1;
        public int LicenseClassID { set; get; } = -1;

        public LocalDrivingLicenseApplicationBLL()
        {
            this.ApplicationID = -1;
            this.LicenseClassID = -1;
        }

        public LocalDrivingLicenseApplicationBLL(int ApplicationID, int LicenseClassID)
        {
            this.ApplicationID = ApplicationID;
            this.LicenseClassID = LicenseClassID;
        }

        public static bool IsPersonUnderAllowedAge(int PersonID, int LicenseClass)
        {
            DateTime BirthDate = PeopleDAL.GetPersonAge(PersonID);

            if (BirthDate == DateTime.MinValue)
            {
                throw new Exception("Invalid BirthDate retrieved for the person.");
            }

            int IsYonger = (LicenseClass == 1 || LicenseClass == 3)
                ? DateTime.Compare(DateTime.Now.AddYears(-18), BirthDate)
                : DateTime.Compare(DateTime.Now.AddYears(-21), BirthDate);

            return IsYonger == 1;
        }

        public static bool IsPersonCanApplicateNewLicense(int PersonID, int LicenseClass)
        {
            return LocalDrivingLicensesApplicationsDAL.CanPersonApplicatieNewLicense(PersonID, LicenseClass);
        }

        public static (int ApplicationID, int LocalDrivingLicenseApplicationID) AddNewDrivingLicenseApplication(ApplicationsBLL currentApplication, int licenseClass)
        {
            int applicationID = -1;
            int localDrivingLicenseApplicationID = -1;

            if (currentApplication.Save())
            {
                applicationID = currentApplication.ApplicationID;
                localDrivingLicenseApplicationID = LocalDrivingLicensesApplicationsDAL.AddNewLocalDrivingLicenseApplication(applicationID, licenseClass);
            }

            return (applicationID, localDrivingLicenseApplicationID);
        }

        public static int FindLocalDrivingLicenseID(int ApplicationID)
        {
            return LocalDrivingLicensesApplicationsDAL.FindLocalAppID(ApplicationID);
        }

        public static bool Update(int LocalDLAPPID, int LicanseClass)
        {
            return DAL.LocalDrivingLicensesApplicationsDAL.UpdateLocalDrivingLicenseClass(LocalDLAPPID, LicanseClass);
        }

        public static int GetLicanseClassIDByApplicationID(int ApplicationID)
        {
            return DAL.LocalDrivingLicensesApplicationsDAL.GetLicenseClassIDByApplicationID(ApplicationID);
        }

        public static int GetLicanseClassIDByLicenseID(int LicenseID)
        {
            return DAL.LocalDrivingLicensesApplicationsDAL.GetLicanseClassIDByLicenseID(LicenseID);
        }

        public static DataTable GetAllLocalDrivingLicenseApplications()
        {
            return DAL.LocalDrivingLicensesApplicationsDAL.GetLocalDrivingLicenseTable();
        }

        public static (string licenseClassDescribtion, int NumberOfPassedTests) GetLocalDrivingLicenseApplicationInfo(int DrivingLicenseApplicationID)
        {
            return DAL.LocalDrivingLicensesApplicationsDAL.Getdrivinglicenseapplicationinfo(DrivingLicenseApplicationID);
        }

        public static int GetApplicationID(int LocalDrivingLicenseApplicationID)
        {
            return DAL.LocalDrivingLicensesApplicationsDAL.GetApplicationIDByLocalDrivingLicenseID(LocalDrivingLicenseApplicationID);
        }

        public static (string DclassName, string Name, int Trials, int Fees) GetApplicationDataForScheduleTest(int DrivingLicenseApplicationID, int TestType = 1)
        {
            return DAL.LocalDrivingLicensesApplicationsDAL.GetLocalApplicationDataForScheduleTest(DrivingLicenseApplicationID, TestType);
        }

        public static bool DeleteLocalDrivingLicenseApplication(int LDLAppID)
        {
            return DAL.LocalDrivingLicensesApplicationsDAL.DeleteLocalDrivingLicenseApplication(LDLAppID);
        }

        public static (int RLAppID, DateTime ApplicationDate, DateTime IssueDate, int ApplicationFees, int LicenseFees, string Notes, int RenewedLicenseID, int OldLicenseID, DateTime ExpirationDate, string CreatedBy, int TotalFees) GetRenewLocalLicenseApplicationInfo(int LicenseID)
        {
            return DAL.LocalDrivingLicensesApplicationsDAL.GetRenewLocalLicenseApplicationInfo(LicenseID);
        }
    }
}