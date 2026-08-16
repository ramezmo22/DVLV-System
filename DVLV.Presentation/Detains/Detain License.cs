using DVLV.UI.Licenses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DVLV.UI
{
    public partial class Detain_License : Form
    {
        private int _license_id = -1;
        public Detain_License()
        {
            InitializeComponent();
            this.btn_Detain_License.Enabled = false;
            this.lnk_Show_License_history.Enabled = false;
            this.lnk_Show_License_Info.Enabled = false;
        }

        private bool is_license_detained()
        {
            return (BLL.LicenseBLL.IsLicenseDetaind(_license_id));
        }

        private bool is_license_Active()
        {
            return BLL.LicenseBLL.IsLicenseActive(_license_id);
        }

        private bool is_license_expiarad()
        {
            return (BLL.LicenseBLL.IsLicenseExpiared(_license_id));
        }

        private void Disable_Detained()
        {
            this.btn_Detain_License.Enabled = false;
            this.ctr_Detain_License_Info1.Enabled = false;
            this.ctr_detain_info1.Enabled = false;
            this.lnk_Show_License_history.Enabled = false;
            this.lnk_Show_License_Info.Enabled = false;
        }

        private void Enable_Detained()
        {
            this.btn_Detain_License.Enabled = true;
            this.ctr_Detain_License_Info1.Enabled = true;
            this.ctr_detain_info1.Enabled = true;
            this.lnk_Show_License_history.Enabled = true;
            this.lnk_Show_License_Info.Enabled = true;
        }

        private bool check_license()
        {
            if (!is_license_Active())
            {
                MessageBox.Show("The License You try to Detained is not active .", "Can`t Detain.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Disable_Detained();
                return false;
            }
            if (is_license_detained())
            {
                MessageBox.Show("The License Is Already Detained .", "Can`t Detain.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Disable_Detained();
                return false;
            }
            if (is_license_expiarad())
            {
                MessageBox.Show("The License Is Expiared .", "Can`t Detain.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Disable_Detained();
                return false;
            }
            this.btn_Detain_License.Enabled = true;
            this.ctr_Detain_License_Info1.Enabled = true;
            this.ctr_detain_info1.Enabled = true;
            return true;
        }

        private void ctr_License_Filter1_OnLicenseSelected(int obj)
        {
            this._license_id = obj;
            ctr_Detain_License_Info1.LoadData(_license_id);
            if (check_license())
            {
                Enable_Detained();
                ctr_detain_info1.Load_Data(_license_id);

            }
        }

        private void lnk_Show_License_history_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            int DriverID = BLL.DriverBLL.GetDriverIDByLicenseID(_license_id);
            int PersonID = BLL.PeopleBLL.GetPersonIDByDriverID(DriverID);
            Form frmLicenseHistory = new License_History(DriverID, PersonID);
            frmLicenseHistory.ShowDialog();
        }

        private void lnk_Show_License_Info_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form frmShowLicense = new License_Info(BLL.ApplicationsBLL.GetApplicationIDByLicenseID(_license_id));
            frmShowLicense.ShowDialog();
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Detain_License_Click(object sender, EventArgs e)
        {
            if (ctr_detain_info1.Detain_Save())
            {
                MessageBox.Show("License Detained Successfully .", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btn_Detain_License.Enabled = false;
            }
        }
    }
}
