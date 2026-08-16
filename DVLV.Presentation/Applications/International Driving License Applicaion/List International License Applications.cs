using DVLV.UI.Licenses;
using DVLV.UI.Licenses.International_License;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Windows.Forms;

namespace DVLV.UI.Applications_Manage.International_Driving_License_Applicaion
{
    public partial class List_International_License_Applications : Form
    {
        public List_International_License_Applications()
        {
            InitializeComponent();
            cbx_Filter.SelectedIndex = 0;
            Grid_Initialize();
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void Grid_Initialize(int FilterationNumber = 0, string filterValue = "")
        {

            DataTable GridData = BLL.InternationalLicenseApplicationBLL.LoadDataToGridView(FilterationNumber, filterValue);
            //InternationalLicenseID	ApplicationID	DriverID	IssuedUsingLocalLicenseID	IssueDate	ExpirationDate	IsActive	

            dgv_International_Driving_License_Applications.Columns.Clear();

            dgv_International_Driving_License_Applications.Columns.Add(new DataGridViewTextBoxColumn() { Name = "InternationalLicenseID", HeaderText = "I.License ID", DataPropertyName = "InternationalLicenseID" });

            dgv_International_Driving_License_Applications.Columns.Add(new DataGridViewTextBoxColumn() { Name = "ApplicationID", HeaderText = "Application ID", DataPropertyName = "ApplicationID" });

            dgv_International_Driving_License_Applications.Columns.Add(new DataGridViewTextBoxColumn() { Name = "DriverID", HeaderText = "Driver ID", DataPropertyName = "DriverID" });

            dgv_International_Driving_License_Applications.Columns.Add(new DataGridViewTextBoxColumn() { Name = "LocalLicenseID", HeaderText = "L.License ID", DataPropertyName = "IssuedUsingLocalLicenseID" });

            dgv_International_Driving_License_Applications.Columns.Add(new DataGridViewTextBoxColumn() { Name = "IssueDate", HeaderText = "Issue Date", DataPropertyName = "IssueDate", Width = 70 });

            dgv_International_Driving_License_Applications.Columns.Add(new DataGridViewTextBoxColumn() { Name = "ExpirationDate", HeaderText = "Expiration Date", DataPropertyName = "ExpirationDate" });

            dgv_International_Driving_License_Applications.Columns.Add(new DataGridViewCheckBoxColumn() { Name = "IsActive", HeaderText = "Is Active", DataPropertyName = "IsActive" });

            dgv_International_Driving_License_Applications.AutoGenerateColumns = false;
            dgv_International_Driving_License_Applications.DataSource = GridData;
            dgv_International_Driving_License_Applications.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            lbl_Number_Of_Records.Text = dgv_International_Driving_License_Applications.Rows.Count.ToString();

        }
        private int GetLocalDrivingLicenseApplicationIDFromGrid()
        {
            if (dgv_International_Driving_License_Applications.SelectedRows.Count != 1)
            {
                MessageBox.Show("You must Select Just One Row", "Error", MessageBoxButtons.OK);
                return -1;
            }

            var result = dgv_International_Driving_License_Applications.SelectedRows[0].Cells["LocalDrivingLicenseApplicationID"];

            if (result.Value != null && int.TryParse(result.Value.ToString(), out int ID))
            {
                return ID;
            }

            return -1;
        }
        public int GetDriverIDdFromGrid()
        {
            if (dgv_International_Driving_License_Applications.SelectedRows.Count != 1)
            {
                MessageBox.Show("You must Select Just One Row", "Error", MessageBoxButtons.OK);
                return -1;
            }
            var result = dgv_International_Driving_License_Applications.SelectedRows[0].Cells["DriverID"];
            if (result.Value != null && int.TryParse(result.Value.ToString(), out int ID))
            {
                return ID;
            }

            return -1;
        }

        public int GetInternationalDrivingLicenseIDFromGrid()
        {
            if (dgv_International_Driving_License_Applications.SelectedRows.Count != 1)
            {
                MessageBox.Show("You must Select Just One Row", "Error", MessageBoxButtons.OK);
                return -1;
            }

            var result = dgv_International_Driving_License_Applications.SelectedRows[0].Cells["InternationalLicenseID"];
            if (result.Value != null && int.TryParse(result.Value.ToString(), out int ID))
            {
                return ID;
            }
            return -1;
        }
        private void btn_AddNewApplication_Click_1(object sender, EventArgs e)
        {
            Form frmNewInternationalDrivingApplication = new New_International_License_Application();
            frmNewInternationalDrivingApplication.ShowDialog();
            Grid_Initialize();
        }

        private void txt_Filter_TextChanged(object sender, EventArgs e)
        {

            string text;
            switch (cbx_Filter.SelectedIndex)
            {
                case 1:
                case 2:
                case 3:
                    {
                        ValidationHelper.PhoneNumberValidation(txt_Filter, errorProvider1);
                        Grid_Initialize(cbx_Filter.SelectedIndex, txt_Filter.Text);
                        break;
                    }


            }
        }


        private void cbx_Filter_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbx_Filter.SelectedIndex)
            {
                case 0:
                    txt_Filter.Visible = false;
                    cbx_isActive.Visible = false;
                    break;
                case 1:
                case 2:
                case 3:
                    txt_Filter.Visible = true;
                    cbx_isActive.Visible = false;
                    break;
                case 4:
                    txt_Filter.Visible = false;
                    cbx_isActive.Visible = true;
                    break;

            }
        }

        private void cbx_isActive_SelectedIndexChanged(object sender, EventArgs e)
        {
            Grid_Initialize(4, cbx_isActive.SelectedIndex == 0 ? "true" : "false");
        }

        private void showPersonDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int DriverID = GetDriverIDdFromGrid();
            int PersonID = BLL.PeopleBLL.GetPersonIDByDriverID(DriverID);
            Form personDetails = new PersonDetails(PersonID);
            personDetails.ShowDialog();

        }

        private void showLicenseDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int ILID = GetInternationalDrivingLicenseIDFromGrid();
            Form frmInternationalLicenseDetailes = new Driver_Information_License_Info(ILID);
            frmInternationalLicenseDetailes.ShowDialog();
        }

        private void showPersonLicenseHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int DriverID = GetDriverIDdFromGrid();
            int PersonID = BLL.PeopleBLL.GetPersonIDByDriverID(DriverID);
            Form frmPersonLicenseHistory = new License_History(DriverID, PersonID);
            frmPersonLicenseHistory.ShowDialog();
            
        }
    }
}
