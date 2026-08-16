using DVLV.UI.Licenses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DVLV.UI.Detains
{
    public partial class Release_Detained_License : Form
    {
        private int _licenseID = -1;
        public Release_Detained_License()
        {
            InitializeComponent();
        }

        private void Disable_Release()
        {
            ctr_Detain_License_Info1.Enabled = false;
            ctr_detained_view1.Enabled = false;
            btn_Release_License.Enabled = false;
        }
        private void Enable_Release()
        {
            ctr_Detain_License_Info1.Enabled = true;
            ctr_detained_view1.Enabled = true;
            btn_Release_License.Enabled = true;
            lnk_Show_License_history.Enabled = true;
            lnk_Show_License_Info.Enabled = true;
        }

        public void Release_Selected_License(int LicenseID)
        {
            this._licenseID = LicenseID;
            ctr_License_Filter1.LoadLicenseID(LicenseID);
        }
        private void ctr_License_Filter1_OnLicenseSelected(int obj)
        {
            this._licenseID = obj;
            if (BLL.LicenseBLL.IsLicenseDetaind(obj))
            {
                if (BLL.LicenseBLL.IsLicenseActive(_licenseID))
                {

                    Enable_Release();
                    ctr_License_Filter1.Enabled = false;
                    ctr_detained_view1.LoadData(_licenseID);
                }
                else
                {
                    MessageBox.Show("The License Is not Active You Cant`t Release it.", "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("The License Isn`t Detaind You cant Release it .", "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Disable_Release();
            }
            ctr_Detain_License_Info1.LoadData(_licenseID);

        }
        private void btn_Release_License_Click(object sender, EventArgs e)
        {
            if (_licenseID != -1)
                if (ctr_detained_view1.Relase_Detained_License_Application(_licenseID))
                    btn_Release_License.Enabled = false;

        }

        private void lnk_Show_License_history_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            int DriverID = BLL.DriverBLL.GetDriverIDByLicenseID(_licenseID);
            int PersonID = BLL.PeopleBLL.GetPersonIDByDriverID(DriverID);
            Form frmLicenseHistory = new License_History(DriverID, PersonID);
            frmLicenseHistory.ShowDialog();
        }

        private void lnk_Show_License_Info_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form frmShowLicense = new License_Info(BLL.ApplicationsBLL.GetApplicationIDByLicenseID(_licenseID));
            frmShowLicense.ShowDialog();
        }
    }
}
