using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DVLV.UI.Detains
{
    public partial class List_Detained_Licenses : Form
    {
        private DataTable _AllDetainedLicenses = new DataTable();

        public List_Detained_Licenses()
        {
            InitializeComponent();
            cmb_filter.SelectedIndex = 0;
            dgv_List_Detained.ContextMenuStrip = contextMenuStrip1;
            Refresh_Detein_Grid();

        }

        private void Refresh_Detein_Grid()
        {
            Load_Grid_Data();
            UpdateRecordsCount();
        }

        private void Load_Grid_Data(int FilterMood = 0, string FilterQuery = "")
        {
            DataTable Data = BLL.DetainedLicensesBLL.GetAllDetainedLicenses(FilterMood, FilterQuery);

            //Grid inisilization :

            DataGridViewTextBoxColumn colDetainID = new DataGridViewTextBoxColumn();
            colDetainID.DataPropertyName = "DetainID";
            colDetainID.HeaderText = "D.ID";
            colDetainID.Name = "D.ID";
            colDetainID.Width = 80;
            colDetainID.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;

            DataGridViewTextBoxColumn colLicenseID = new DataGridViewTextBoxColumn();
            colLicenseID.DataPropertyName = "LicenseID";
            colLicenseID.HeaderText = "L.ID";
            colLicenseID.Name = "L.ID";
            colLicenseID.Width = 80;

            DataGridViewTextBoxColumn colDetainDate = new DataGridViewTextBoxColumn();
            colDetainDate.DataPropertyName = "DetainDate";
            colDetainDate.HeaderText = "D.Date";
            colDetainDate.Name = "D.Date";
            colDetainDate.Width = 100;

            DataGridViewCheckBoxColumn colIsReleased = new DataGridViewCheckBoxColumn();
            colIsReleased.DataPropertyName = "IsReleased";
            colIsReleased.HeaderText = "Is Released";
            colIsReleased.Name = "Is Released";
            colIsReleased.Width = 100;

            DataGridViewTextBoxColumn colFineFees = new DataGridViewTextBoxColumn();
            colFineFees.DataPropertyName = "FineFees";
            colFineFees.HeaderText = "Fine Fees";
            colFineFees.Name = "Fine Fees";
            colFineFees.Width = 100;

            DataGridViewTextBoxColumn colReleaseDate = new DataGridViewTextBoxColumn();
            colReleaseDate.DataPropertyName = "ReleaseDate";
            colReleaseDate.HeaderText = "Release Date";
            colReleaseDate.Name = "Release Date";
            colReleaseDate.Width = 120;

            DataGridViewTextBoxColumn colNationalNo = new DataGridViewTextBoxColumn();
            colNationalNo.DataPropertyName = "NationalNo";
            colNationalNo.HeaderText = "N.No";
            colNationalNo.Name = "N.No";
            colNationalNo.Width = 100;

            DataGridViewTextBoxColumn colFullName = new DataGridViewTextBoxColumn();
            colFullName.DataPropertyName = "Full Name";
            colFullName.HeaderText = "Full Name";
            colFullName.Name = "Full Name";
            colFullName.Width = 300;

            DataGridViewTextBoxColumn colReleaseAppID = new DataGridViewTextBoxColumn();
            colReleaseAppID.DataPropertyName = "ReleaseApplicationID";
            colReleaseAppID.HeaderText = "Release App ID";
            colReleaseAppID.Name = "Release App ID";
            colReleaseAppID.Width = 120;

            // إضافة الأعمدة للـ DataGridView
            dgv_List_Detained.Columns.Clear();
            dgv_List_Detained.Columns.Add(colDetainID);
            dgv_List_Detained.Columns.Add(colLicenseID);
            dgv_List_Detained.Columns.Add(colDetainDate);
            dgv_List_Detained.Columns.Add(colIsReleased);
            dgv_List_Detained.Columns.Add(colFineFees);
            dgv_List_Detained.Columns.Add(colReleaseDate);
            dgv_List_Detained.Columns.Add(colNationalNo);
            dgv_List_Detained.Columns.Add(colFullName);
            dgv_List_Detained.Columns.Add(colReleaseAppID);

            // ربط البيانات بعد تعريف الأعمدة
            dgv_List_Detained.DataSource = Data;

            UpdateRecordsCount();
        }

        private void UpdateRecordsCount()
        {
            label3.Text = "# Records : " + dgv_List_Detained.RowCount.ToString();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*
            None
            Detain ID
            Is Released
            National No.
            Full Name
            Release Application ID
            */

            switch (cmb_filter.SelectedIndex)
            {
                case 0:
                    txt_To_Find.Text = "";
                    txt_To_Find.Visible = false;
                    cmb_Is_Release.Visible = false;
                    Refresh_Detein_Grid();
                    break;
                case 1:
                    txt_To_Find.Text = "";
                    txt_To_Find.Visible = true;
                    cmb_Is_Release.Visible = false;
                    break;
                case 2:
                    txt_To_Find.Text = "";
                    txt_To_Find.Visible = false;
                    cmb_Is_Release.Visible = true;
                    break;
                case 3:
                    txt_To_Find.Text = "";
                    txt_To_Find.Visible = true;
                    cmb_Is_Release.Visible = false;
                    break;
                case 4:
                    txt_To_Find.Text = "";
                    txt_To_Find.Visible = true;
                    cmb_Is_Release.Visible = false;
                    break;
                case 5:
                    txt_To_Find.Text = "";
                    txt_To_Find.Visible = true;
                    cmb_Is_Release.Visible = false;
                    break;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            switch (cmb_filter.SelectedIndex)
            {
                case 1:
                    ValidationHelper.PhoneNumberValidation(txt_To_Find, errorProvider1);
                    break;
                case 5:
                    ValidationHelper.PhoneNumberValidation(txt_To_Find, errorProvider1);
                    break;
            }
            Load_Grid_Data(cmb_filter.SelectedIndex, txt_To_Find.Text);
        }


        private int GetSelectedLicenseID()
        {
            if (dgv_List_Detained.SelectedRows.Count == 0)
                return -1;

            if (int.TryParse(dgv_List_Detained.SelectedRows[0].Cells["L.ID"].Value?.ToString(), out int licenseID))
                return licenseID;

            return -1;
        }

        private void showPersonDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int licenseID = GetSelectedLicenseID();
            if (licenseID == -1)
                return;

            int driverID = BLL.DriverBLL.GetDriverIDByLicenseID(licenseID);
            if (driverID == -1)
            {
                MessageBox.Show("Cannot retrieve driver information", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int personID = BLL.PeopleBLL.GetPersonIDByDriverID(driverID);
            if (personID == -1)
            {
                MessageBox.Show("Cannot retrieve person information", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Show person details form
            Form frmPersonDetails = new PersonDetails(personID);
            frmPersonDetails.ShowDialog();
        }

        private void showLicenseDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int licenseID = GetSelectedLicenseID();
            if (licenseID == -1)
                return;
            int appID = BLL.ApplicationsBLL.GetApplicationIDByLicenseID(licenseID);
            Form frmLicenseDetails = new DVLV.UI.Licenses.License_Info(appID);
            frmLicenseDetails.ShowDialog();
        }

        private void showPersonLicenseHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int licenseID = GetSelectedLicenseID();
            if (licenseID == -1)
                return;

            int driverID = BLL.DriverBLL.GetDriverIDByLicenseID(licenseID);
            if (driverID == -1)
            {
                MessageBox.Show("Cannot retrieve driver information", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int personID = BLL.PeopleBLL.GetPersonIDByDriverID(driverID);
            Form frmLicenseHistory = new DVLV.UI.Licenses.License_History(driverID, personID);
            frmLicenseHistory.ShowDialog();
        }
        private void btn_Release_Click(object sender, EventArgs e)
        {
            Form frmReleaseDetain = new Release_Detained_License();
            frmReleaseDetain.ShowDialog();
            Refresh_Detein_Grid();
        }

        private void btn_Detained_Click(object sender, EventArgs e)
        {
            Form frmDetainLicense = new Detain_License();
            frmDetainLicense.ShowDialog();
            Refresh_Detein_Grid();
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void releaseDetainedLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int licenseID = GetSelectedLicenseID();
            if (licenseID == -1)
                return;

            Release_Detained_License frmReleaseDetain = new Release_Detained_License();
            frmReleaseDetain.Release_Selected_License(licenseID);
            frmReleaseDetain.ShowDialog();
            Refresh_Detein_Grid();
        }

        private void cmb_Is_Release_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_Is_Release.SelectedIndex == 0)
                Load_Grid_Data(2, "1");
            if (cmb_Is_Release.SelectedIndex == 1)
                Load_Grid_Data(2, "0");
        }

        //private int GetSelectedDetainID()
        //{
        //    if (dgv_List_Detained.SelectedRows.Count == 0)
        //    {
        //        MessageBox.Show("Please select a detained license record", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //        return -1;
        //    }

        //    if (int.TryParse(dgv_List_Detained.SelectedRows[0].Cells["D.ID"].Value?.ToString(), out int detainID))
        //        return detainID;

        //    MessageBox.Show("Error retrieving Detain ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    return -1;
        //}

    }
}
