using DVLV.BLL;
using DVLV.UI.Licenses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DVLV.UI.Applications_Manage
{
    public partial class Replacement_For_Damaged_or_Lost_License : Form
    {
        private int _LicenseID = -1;
        private int _DriverID = -1;
        private int _PersonID = -1;
        private int _NewLicenseID = -1;



        public Replacement_For_Damaged_or_Lost_License()
        {
            InitializeComponent();
            rdb_Damaged_License.Checked = true;
            lnk_Show_New_License_Info.Enabled = false;
            btn_Replace_License.Enabled = false;
            ctr_Driver_License_Info1.Enabled = false;
            ctr_Application_Info_For_License_Replacement1.Enabled = false;
        }

        private void ctr_License_Filter1_OnLicenseSelected(int obj)
        {
            _LicenseID = obj;
            if (!BLL.LicenseBLL.IsLicenseActive(_LicenseID))
            {
                MessageBox.Show("You Can`t Replace an unActive License", "Not Allowed !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (BLL.LicenseBLL.IsLicenseExpiared(_LicenseID))
            {
                MessageBox.Show("You Can`t Replace an Expiared License", "Not Allowed !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            if (BLL.LicenseBLL.IsLicenseDetaind(_LicenseID))
            {
                MessageBox.Show("You Can`t Replace a Detaind License", "Not Allowed !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            btn_Replace_License.Enabled = true;
            ctr_Driver_License_Info1.Enabled = true;
            ctr_Driver_License_Info1.LoudControlData(BLL.ApplicationsBLL.GetApplicationIDByLicenseID(_LicenseID));
            ctr_Application_Info_For_License_Replacement1.Enabled = true;
            lnk_Show_License_history.Enabled = true;
            LoudApplicationReplacementData();

            //
        }
        private void LoudApplicationReplacementData()
        {
            if (rdb_Damaged_License.Checked == true)
            {
                ctr_Application_Info_For_License_Replacement1.LoudData(_LicenseID, ctr_Application_Info_For_License_Replacement.enReplacementMood.enDamaged);
            }
            else//For Lose
            {
                ctr_Application_Info_For_License_Replacement1.LoudData(_LicenseID, ctr_Application_Info_For_License_Replacement.enReplacementMood.enLost);

            }
        }
        private void lnk_Show_License_history_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (_LicenseID != -1)
            {
                this._DriverID = BLL.DriverBLL.GetDriverIDByLicenseID(_LicenseID);
                this._PersonID = BLL.PeopleBLL.GetPersonIDByDriverID(_DriverID);
                Form frmLicensesHistory = new Licenses.License_History(_DriverID, _PersonID);
            }
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Replace_License_Click(object sender, EventArgs e)
        {
            if (_LicenseID == -1)
                return;
            _NewLicenseID = ctr_Application_Info_For_License_Replacement1.ReplacementApplication();
            if (_NewLicenseID == -1)
            {
                MessageBox.Show("Error Occure While Saving .", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                MessageBox.Show("The license replaced the new license ID is " + _NewLicenseID, "Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lnk_Show_New_License_Info.Enabled = true;
                ctr_License_Filter1.Enabled=false;
                btn_Replace_License.Enabled = false;

            }
        }

        private void rdb_Damaged_License_CheckedChanged(object sender, EventArgs e)
        {
            LoudApplicationReplacementData();
        }

        private void rdb_Lost_License_CheckedChanged(object sender, EventArgs e)
        {
            LoudApplicationReplacementData();
        }

        private void lnk_Show_New_License_Info_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if(_NewLicenseID!=-1)
            {
                int renewedAppID = ApplicationsBLL.GetApplicationIDByLicenseID(_NewLicenseID);
                License_Info frm = new License_Info(renewedAppID);
                frm.ShowDialog();
            }
        }
    }
}
