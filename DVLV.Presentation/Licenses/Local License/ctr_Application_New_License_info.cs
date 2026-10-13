using DVLV.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Text;
using System.Windows.Forms;

namespace DVLV.UI.Licenses.Local_License
{
    public partial class ctr_Application_New_License_info : UserControl
    {
        // Constants for hardcoded values
        private const int RENEW_LICENSE_TYPE_ID = 2;
        private const int ACTIVE_STATUS = 1;
        private const string DATE_FORMAT = "dd/MM/yyyy";

        private int _LicenseID = -1;
        private int _LicenseClassID = -1;
        private int _TotalFees = 0;
        private int _LicenseFees = 0;
        private int _DriverID = -1;
        private int _LicenseValidity = 0;

        public int RenewedApplicationID { get; private set; } = -1;

        public ctr_Application_New_License_info()
        {
            InitializeComponent();
        }


        public void LoadData(int licenseID)
        {
            try
            {
                this._LicenseID = licenseID;
                this._LicenseClassID = BLL.LocalDrivingLicenseApplicationBLL.GetLicanseClassIDByLicenseID(_LicenseID);

                (int licenseFees, int licenseValidity) = LicenseClassesBLL.GetFeesAndValidityLength(this._LicenseClassID);
                this._LicenseValidity = licenseValidity;
                this._LicenseFees = licenseFees;

                var applicationInfo = GetApplicationTypeInfo();
                this._TotalFees = applicationInfo.Fees + licenseFees;

                PopulateUIFields(applicationInfo, DateTime.Now, licenseID, licenseFees, licenseValidity);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"خطأ في تحميل البيانات: {ex.Message}", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private (string Title, int Fees) GetApplicationTypeInfo()
        {
            int applicationID = RENEW_LICENSE_TYPE_ID;
            int applicationFees = 0;
            string applicationTitle = "";

            BLL.ApplicationTypesBLL.GetType(ref applicationID, ref applicationTitle, ref applicationFees);
            return (applicationTitle, applicationFees);
        }


        private void PopulateUIFields(
            (string Title, int Fees) applicationInfo,
            DateTime currentDate,
            int licenseID,
            int licenseFees,
            int licenseValidity)
        {
            string formattedDate = currentDate.ToString(DATE_FORMAT);
            string expirationDate = currentDate.AddYears(licenseValidity).ToString(DATE_FORMAT);

            lbl_Application_Date.Text = formattedDate;
            lbl_Issue_Date.Text = formattedDate;
            lbl_Application_Fees.Text = applicationInfo.Fees.ToString();
            lbl_License_Fees.Text = licenseFees.ToString();
            lbl_Old_License_ID.Text = licenseID.ToString();
            lbl_Expiration_Date.Text = expirationDate;
            lbl_Created_By.Text = CurrentUserBLL.UserName;
            lbl_Total_Fees.Text = this._TotalFees.ToString();
        }


        public bool RenewLicense()
        {
            try
            {
                _DriverID = BLL.DriverBLL.GetDriverIDByLicenseID(_LicenseID);
                int PersonID = BLL.PeopleBLL.GetPersonIDByDriverID(_DriverID);

                var renewApp = CreateRenewalApplication(PersonID);
                if (renewApp?.Save() == true)
                {
                    return ProcessLicenseRenewal(renewApp, PersonID);
                }

                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"خطأ في تجديد الترخيص: {ex.Message}", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }


        private BLL.ApplicationsBLL CreateRenewalApplication(int personID)
        {
            return new ApplicationsBLL
            (
                personID,
                DateTime.Now,
                RENEW_LICENSE_TYPE_ID,
                ACTIVE_STATUS,
                Convert.ToInt16(lbl_Application_Fees.Text),
                DateTime.Now,
                CurrentUserBLL.UserID
            );
        }

        private bool ProcessLicenseRenewal(BLL.ApplicationsBLL renewApp, int personID)
        {
            int newLicenseID = BLL.LicenseBLL.AddNewLicense(
                renewApp,
                personID,
                this._DriverID,
                this._LicenseClassID,
                DateTime.Now.AddYears(this._LicenseValidity),
                textBox1.Text,
                _LicenseFees,
                RENEW_LICENSE_TYPE_ID);

            lbl_Renew_License_ID.Text = newLicenseID.ToString();
            lbl_Renew_License_Application_ID.Text = renewApp.ApplicationID.ToString();
            this.RenewedApplicationID = renewApp.ApplicationID;

            if (BLL.LicenseBLL.ChangeLicenseStatus(_LicenseID))
            {
                MessageBox.Show(
                    $"تم تجديد الترخيص بنجاح. رقم الترخيص الجديد: {newLicenseID}",
                    "نجح",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                return true;
            }

            return false;
        }
    }
}
