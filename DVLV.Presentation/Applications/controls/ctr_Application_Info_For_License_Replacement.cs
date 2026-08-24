using DVLV.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DVLV.UI.Applications_Manage
{
    public partial class ctr_Application_Info_For_License_Replacement : UserControl
    {
        private int _LicenseID = -1;
        private int _ApplicationFees = -1;
        private int _ApplicationTypeID = -1;

        public enum enReplacementMood { enDamaged = 1, enLost = 2 }
        enReplacementMood _Mood = enReplacementMood.enDamaged;
        public ctr_Application_Info_For_License_Replacement()
        {
            InitializeComponent();

        }
        public void LoudData(int LicenseID, enReplacementMood Mood)
        {
            _LicenseID = LicenseID;
            this._Mood = Mood;
            SetApplicationFees(_Mood);
            lbl_Application_Date.Text = DateTime.Now.ToString("dd/MM/yyyy");
            lbl_Old_License_ID.Text = _LicenseID.ToString();
            lbl_Application_Fees.Text = _ApplicationFees.ToString();
            lbl_Created_By.Text = CurrentUserBLL.UserName;

        }
        public void SetApplicationFees(enReplacementMood mood)
        {
            _Mood = mood;
            int ID = -1;
            string Title = "";
            int Fees = 0;
            switch (mood)
            {
                case enReplacementMood.enDamaged:
                    {
                        ID = 3;
                        ApplicationTypesBLL.GetType(ref ID, ref Title, ref Fees);

                        break;
                    }
                case enReplacementMood.enLost:
                    {
                        ID = 4;
                        ApplicationTypesBLL.GetType(ref ID, ref Title, ref Fees);
                        break;
                    }
            }
            _ApplicationTypeID = ID;
            _ApplicationFees = Fees;
            lbl_Application_Fees.Text = Fees.ToString();
        }

        public int ReplacementApplication()
        {
            int NewLicenseID = -1;

            int DriverID = BLL.DriverBLL.GetDriverIDByLicenseID(_LicenseID);
            int PersonID = BLL.PeopleBLL.GetPersonIDByDriverID(DriverID);
            ApplicationsBLL ReplacementApplication = new ApplicationsBLL(PersonID, DateTime.Now, _ApplicationTypeID, 1, _ApplicationFees, DateTime.Now, CurrentUserBLL.UserID);
            if (ReplacementApplication.Save())
            {
                lbl_Renew_License_Application_ID.Text = ReplacementApplication.ApplicationID.ToString();
                int licenseClassID = BLL.LocalDrivingLicenseApplicationBLL.GetLicanseClassIDByLicenseID(_LicenseID);
                DateTime ExpirationDate = LicenseBLL.GetExpirationDate(_LicenseID);
                int LicenseFees = BLL.LicenseClassesBLL.GetFees(licenseClassID);
                NewLicenseID = LicenseBLL.AddNewLicense(ReplacementApplication, PersonID, DriverID, licenseClassID, ExpirationDate, "", LicenseFees, _ApplicationTypeID);
                lbl_Renew_License_ID.Text = NewLicenseID.ToString();

            }
            return NewLicenseID;
        }
    }
}
