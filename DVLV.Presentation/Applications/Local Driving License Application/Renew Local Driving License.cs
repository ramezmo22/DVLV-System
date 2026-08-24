using DVLV.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DVLV.UI.Licenses.Local_License
{
    public partial class Renew_Local_Driving_License : Form
    {
        private int _SelectedLicenseID = -1;

        public Renew_Local_Driving_License()
        {
            InitializeComponent();
            btn_Renew_License.Click += btn_Renew_License_Click;
            btn_Close.Click += btn_Close_Click;
            lnk_Show_License_history.Click += lnk_Show_License_history_Click;
            btn_Show_New_License_Info.Click += btn_Show_New_License_Info_Click;
        }

        private void ctr_License_Filter1_OnLicenseSelected(int obj)
        {
            _SelectedLicenseID = obj;

            // Get ApplicationID from LicenseID and load driver info
            int ApplicationID = ApplicationsBLL.GetApplicationIDByLicenseID(_SelectedLicenseID);

            if (ApplicationID == -1)
            {
                MessageBox.Show(
                    "No License Found with this ID.",
                    "Not Found",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            // Load data 
            ctr_Driver_License_Info1.LoudControlData(ApplicationID);
            ctr_Application_New_License_info1.LoadData(_SelectedLicenseID);

            // Check if the license is expired
            if (!LicenseBLL.IsLicenseExpiared(_SelectedLicenseID))
            {
                MessageBox.Show("Selected License is not expired yet, you cannot renew it.", "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);

                btn_Renew_License.Enabled = false;
                lnk_Show_License_history.Enabled = true;
                return;
            }
            if (!BLL.LicenseBLL.IsLicenseActive(_SelectedLicenseID))
            {
                MessageBox.Show("Selected License is not Active, you cannot renew it.", "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);

                btn_Renew_License.Enabled = false;
                lnk_Show_License_history.Enabled = true;
                return;
            }


            // Enable Renew 
            btn_Renew_License.Enabled = true;
            lnk_Show_License_history.Enabled = true;
            ctr_Application_New_License_info1.Enabled = true;
            ctr_Driver_License_Info1.Enabled = true;
        }

        private void btn_Renew_License_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to renew this license?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }

            if (ctr_Application_New_License_info1.RenewLicense())
            {
                btn_Renew_License.Enabled = false;
                ctr_License_Filter1.Enabled = false;
                btn_Show_New_License_Info.Enabled = true;
            }
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lnk_Show_License_history_Click(object sender, EventArgs e)
        {
            int DriverID = DriverBLL.GetDriverIDByLicenseID(_SelectedLicenseID);
            int PersonID = PeopleBLL.GetPersonIDByDriverID(DriverID);

            License_History frm = new License_History(DriverID, PersonID);
            frm.ShowDialog();
        }

        private void btn_Show_New_License_Info_Click(object sender, EventArgs e)
        {
            int renewedAppID = ctr_Application_New_License_info1.RenewedApplicationID;
            if (renewedAppID != -1)
            {
                License_Info frm = new License_Info(renewedAppID);
                frm.ShowDialog();
            }
        }

        private void ctr_Driver_License_Info1_Load(object sender, EventArgs e)
        {

        }

        private void btn_Show_New_License_Info_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
        }

        private void btn_Close_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
