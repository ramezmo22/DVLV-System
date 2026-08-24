using DVLV.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;

namespace DVLV.UI.Detains
{
    public partial class ctr_detained_view : UserControl
    {
        public ctr_detained_view()
        {
            InitializeComponent();
        }
        private int _application_Fees = 0;
        private int _applicationID = -1;
        //We Need Here From Tabels
        //1) DetainedLicenses .
        //2) ApplicationTypes .
        public void LoadData(int LicenseID)
        {
            (int DetainID, DateTime DetainDate, int FineFees, int CreatedByUserID) = BLL.DetainedLicensesBLL.GetDetainData(LicenseID);
            if (DetainID != -1)
            {
                lbl_License_ID.Text = LicenseID.ToString();
                lbl_Detain_ID.Text = DetainID.ToString();
                lbl_Detain_Date.Text = DetainDate.ToString("dd/MM,yyyy");
                lbl_Fine_Fees.Text = FineFees.ToString();
                // Get Application Type Info
                int ApplicationTypeID = 5; // For Releas Detaon License
                string Title = "";
                int Fees = 0;
                BLL.ApplicationTypesBLL.GetType(ref ApplicationTypeID, ref Title, ref Fees);
                this._application_Fees = Fees;
                int TotalFees = Fees + FineFees;
                lbl_Application_Fees.Text = Fees.ToString();
                lbl_Total_Fees.Text = TotalFees.ToString();
                lbl_Created_By.Text = BLL.UserBLL.GetUsreName(CreatedByUserID);
            }
            else MessageBox.Show("Error Accour While Extract Data .", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public bool Relase_Detained_License_Application(int LicenseID)
        {
            int DriverID = BLL.DriverBLL.GetDriverIDByLicenseID(LicenseID);
            int PersonID = BLL.PeopleBLL.GetPersonIDByDriverID(DriverID);
            BLL.ApplicationsBLL ReleaseApplication = new BLL.ApplicationsBLL(PersonID, DateTime.Now, 5, 3, _application_Fees, DateTime.Now, CurrentUserBLL.UserID);
            if (ReleaseApplication.Save())
            {
                this._applicationID = ReleaseApplication.ApplicationID;
                lbl_Application_ID.Text = _applicationID.ToString();
                if (BLL.DetainedLicensesBLL.Release_License(LicenseID, _applicationID, DateTime.Now, CurrentUserBLL.UserID))
                {
                    MessageBox.Show("License Released Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
                else
                {
                    MessageBox.Show("Failed to Release License", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Failed to Save Release Application", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }
    }
}
