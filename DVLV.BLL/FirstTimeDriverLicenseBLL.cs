using System;
using System.Collections.Generic;
using System.Text;
using DVLV;

namespace DVLV.BLL
{
    public class FirstTimeDriverLicenseBLL
    {
        int LocalDrivingLicenseApplcaitionID = -1;
        int ApplcaitionID = -1;
        int PersonID = -1;
        int DriverID = -1;
        int LicenseClassID = 3;//default class
        DateTime IssueDate = DateTime.Now;
        DateTime LicenseExperationDate;
        int LicenseFees = -1;
        int IssueReason = 1;
        bool IsActive = true;
        int CreatedByUserID = CurrentUserBLL.UserID;

        public FirstTimeDriverLicenseBLL(int LocalDringLicenseAppID)
        {
            this.LocalDrivingLicenseApplcaitionID = LocalDringLicenseAppID;
            InitializingDriverData();

        }


        public void InitializingDriverData()
        {
            //ApplciationID
            this.ApplcaitionID = BLL.LocalDrivingLicenseApplicationBLL.GetApplicationID(LocalDrivingLicenseApplcaitionID);
            //PersonID
            if (ApplcaitionID != -1)
            {
                ApplicationsBLL application = DVLV.BLL.ApplicationsBLL.Find(this.ApplcaitionID);

                if (application != null)
                {
                    this.PersonID = application.PersonID;
                }
            }
            //License Class ID
            this.LicenseClassID = BLL.LocalDrivingLicenseApplicationBLL.GetLicanseClassIDByApplicationID(this.ApplcaitionID);
            //License fees and ExperationDate'
            (int Fees, int Validity) = DAL.LicenseClassesDAL.GetFeesAndValidityLength(this.LicenseClassID);
            LicenseExperationDate = IssueDate.AddYears(Validity);
            this.LicenseFees = Fees;
            //IssueReason
            this.IssueReason = 1;
            //IsActive
            this.IsActive = true;

        }

        public int AddNewLicense(string Notes)
        {
            this.DriverID = BLL.DriverBLL.GetDriverIDByPersonID(PersonID);
            if(this.DriverID==-1)
            {
                this.DriverID = BLL.DriverBLL.AddNewDriver(PersonID);
            }


            if(this.DriverID!=-1)
            {
                int LicenseID=DAL.LicensesDAL.AddNewLicense(ApplcaitionID, DriverID, LicenseClassID, IssueDate, LicenseExperationDate, Notes, LicenseFees, IsActive, IssueReason, CreatedByUserID);
                if(LicenseID!=-1)
                {
                    ApplicationsBLL.ChangeApplicationStatus(this.ApplcaitionID, 3,DateTime.Now);
                }
                return LicenseID;

            }
            else
            {
                return -1;
            }
        }

    }
}
