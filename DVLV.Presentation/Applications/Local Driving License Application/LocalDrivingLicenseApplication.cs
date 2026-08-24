using DVLV.BLL;
using DVLV.UI.Licenses;
using DVLV.UI.Tests_Manage;
using DVLV.UI.Tests_Manage.VisionTest.Street_Test;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DVLV.UI
{
    public partial class LocalDrivingLicenseApplications : Form
    {
        public LocalDrivingLicenseApplications()
        {
            InitializeComponent();
            Grid_Initialize();
            cbx_Filter.SelectedIndex = 0;
            txt_Filter.Visible = false;
        }
        public void Grid_Initialize(int FilterationNumber = 0, string filterValue = "")
        {

            DataTable GridData = BLL.LocalDrivingLicenseApplicationBLL.LoadDataToGridView(FilterationNumber, filterValue);


            dgv_Local_Driving_License_Applications.Columns.Clear();
            dgv_Local_Driving_License_Applications.Columns.Add(new DataGridViewTextBoxColumn() { Name = "LocalDrivingLicenseApplicationID", HeaderText = "L.D.L.AppID", DataPropertyName = "LocalDrivingLicenseApplicationID" });
            dgv_Local_Driving_License_Applications.Columns.Add(new DataGridViewTextBoxColumn() { Name = "ClassName", HeaderText = "Driving Class", DataPropertyName = "ClassName" });
            dgv_Local_Driving_License_Applications.Columns.Add(new DataGridViewTextBoxColumn() { Name = "NationalNo", HeaderText = "National No.", DataPropertyName = "NationalNo" });
            dgv_Local_Driving_License_Applications.Columns.Add(new DataGridViewTextBoxColumn() { Name = "FullName", HeaderText = "Full Name.", DataPropertyName = "FullName", Width = 200 });
            dgv_Local_Driving_License_Applications.Columns.Add(new DataGridViewTextBoxColumn() { Name = "ApplicationDate", HeaderText = "Application Date", DataPropertyName = "ApplicationDate", Width = 70 });
            dgv_Local_Driving_License_Applications.Columns.Add(new DataGridViewTextBoxColumn() { Name = "PassedTestCount", HeaderText = "Passed Tests", DataPropertyName = "PassedTestCount" });
            dgv_Local_Driving_License_Applications.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Status", HeaderText = "Status", DataPropertyName = "Status" });

            dgv_Local_Driving_License_Applications.AutoGenerateColumns = false;
            dgv_Local_Driving_License_Applications.DataSource = GridData;
            dgv_Local_Driving_License_Applications.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            lbl_Number_Of_Records.Text = dgv_Local_Driving_License_Applications.Rows.Count.ToString();

        }
        private void btn_AddNewApplication_Click(object sender, EventArgs e)
        {
            Form frmNewLocalDrivingApplication = new New_Local_Driving_License_Application();
            frmNewLocalDrivingApplication.ShowDialog();
            Grid_Initialize();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void cbx_Filter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbx_Filter.SelectedIndex != 0)
                txt_Filter.Visible = true;
            else
                txt_Filter.Visible = false;
        }
        private void txt_Filter_TextChanged(object sender, EventArgs e)
        {
            if (txt_Filter.Text == "")
            {
                Grid_Initialize();
                return;
            }
            switch (cbx_Filter.SelectedIndex)
            {
                case 0:
                    {
                        Grid_Initialize();
                        break;
                    }
                case 1:
                    {
                        if (!string.IsNullOrEmpty(txt_Filter.Text) && int.TryParse(txt_Filter.Text, out _))
                        {
                            Grid_Initialize(1, txt_Filter.Text);
                        }
                        break;
                    }
                case 2:
                    {
                        Grid_Initialize(2, txt_Filter.Text);
                        break;
                    }
                case 3:
                    {
                        Grid_Initialize(3, txt_Filter.Text);
                        break;
                    }
                case 4:
                    {
                        Grid_Initialize(4, txt_Filter.Text);
                        break;
                    }
            }
        }
        public (int PassedTests, string Status) GetPassedTestsAndStatusFromGrid()
        {

            var selectedRow = dgv_Local_Driving_License_Applications.SelectedRows[0];
            int passedTests = Convert.ToInt32(selectedRow.Cells["PassedTestCount"].Value);
            string status = selectedRow.Cells["Status"].Value?.ToString() ?? "";

            return (passedTests, status);
        }
        private void ResetContextMenu()
        {
            sechduleTestsToolStripMenuItem.Enabled = true;

            schedualVisionTestToolStripMenuItem.Enabled = true;
            SchedualWritenTestToolStripMenuItem.Enabled = true;
            schedualStreetTestToolStripMenuItem.Enabled = true;

            showApplicationDetailsToolStripMenuItem.Enabled = true;
            editApplicationToolStripMenuItem.Enabled = true;
            deleteApplicationToolStripMenuItem.Enabled = true;
            cancelApplicationToolStripMenuItem.Enabled = true;
            issueDrivingLicenseFirstTimeToolStripMenuItem.Enabled = true;
            showLicenseToolStripMenuItem.Enabled = true;
            showPersonalLicenseHistoryToolStripMenuItem.Enabled = true;

        }
        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            ResetContextMenu();
            (int Passtest, string Status) = GetPassedTestsAndStatusFromGrid();
            if (Passtest < 0 || Passtest > 3 || Status == "")
            {
                contextMenuStrip1.Close();
                MessageBox.Show("operation  Failed !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            } //error in values or out of range
            else
            {
                Status = Status.Trim().ToLower();
                if (Status == "completed")
                {
                    editApplicationToolStripMenuItem.Enabled = false;
                    deleteApplicationToolStripMenuItem.Enabled = false;
                    cancelApplicationToolStripMenuItem.Enabled = false;
                    sechduleTestsToolStripMenuItem.Enabled = false;
                    issueDrivingLicenseFirstTimeToolStripMenuItem.Enabled = false;
                    showLicenseToolStripMenuItem.Enabled = true;



                }
                else if (Status == "cancelled")
                {
                    editApplicationToolStripMenuItem.Enabled = false;
                    cancelApplicationToolStripMenuItem.Enabled = false;
                    sechduleTestsToolStripMenuItem.Enabled = false;
                    showLicenseToolStripMenuItem.Enabled = false;



                }
                else
                {
                    if (HasLicense())
                    {
                        //To Handel non Refreshed Grid and Take the realtime Data From Database
                        //Ist an Additinal Function
                        sechduleTestsToolStripMenuItem.Enabled = false;
                        schedualVisionTestToolStripMenuItem.Enabled = false;
                        SchedualWritenTestToolStripMenuItem.Enabled = false;
                        schedualStreetTestToolStripMenuItem.Enabled = false;
                        issueDrivingLicenseFirstTimeToolStripMenuItem.Enabled = false;


                    }
                    if (Passtest == 0)
                    {
                        SchedualWritenTestToolStripMenuItem.Enabled = false;
                        schedualStreetTestToolStripMenuItem.Enabled = false;
                        issueDrivingLicenseFirstTimeToolStripMenuItem.Enabled = false;
                        showLicenseToolStripMenuItem.Enabled = false;
                        showPersonalLicenseHistoryToolStripMenuItem.Enabled = false;
                    }
                    else if (Passtest == 1)
                    {
                        showPersonalLicenseHistoryToolStripMenuItem.Enabled = false;
                        schedualVisionTestToolStripMenuItem.Enabled = false;
                        schedualStreetTestToolStripMenuItem.Enabled = false;
                        deleteApplicationToolStripMenuItem.Enabled = false;
                        issueDrivingLicenseFirstTimeToolStripMenuItem.Enabled = false;
                        showLicenseToolStripMenuItem.Enabled = false;
                    }
                    else if (Passtest == 2)
                    {
                        showPersonalLicenseHistoryToolStripMenuItem.Enabled = false;
                        schedualVisionTestToolStripMenuItem.Enabled = false;
                        SchedualWritenTestToolStripMenuItem.Enabled = false;
                        deleteApplicationToolStripMenuItem.Enabled = false;
                        issueDrivingLicenseFirstTimeToolStripMenuItem.Enabled = false;
                        showLicenseToolStripMenuItem.Enabled = false;
                    }
                    else if (Passtest == 3)
                    {
                        sechduleTestsToolStripMenuItem.Enabled = false;
                        schedualVisionTestToolStripMenuItem.Enabled = false;
                        SchedualWritenTestToolStripMenuItem.Enabled = false;
                        schedualStreetTestToolStripMenuItem.Enabled = false;
                        deleteApplicationToolStripMenuItem.Enabled = false;
                        showLicenseToolStripMenuItem.Enabled = false;
                        editApplicationToolStripMenuItem.Enabled = false;

                    }
                }

            }
        }
        private bool HasLicense()
        {

            int LocalDrivingLicenseAppID = GetLocalDrivingLicenseApplicationIDFromGrid();
            if (LocalDrivingLicenseAppID <= 0)
            {
                MessageBox.Show("Invalid selection. Please select a valid application.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                int ApplicationID = BLL.LocalDrivingLicenseApplicationBLL.GetApplicationID(LocalDrivingLicenseAppID);
                return BLL.LicenseBLL.HasLicense(ApplicationID);



            }
            return false;
        }
        private int GetLocalDrivingLicenseApplicationIDFromGrid()
        {
            if (dgv_Local_Driving_License_Applications.SelectedRows.Count != 1)
            {
                MessageBox.Show("You must Select Just One Row", "Error", MessageBoxButtons.OK);
                return -1;
            }

            var result = dgv_Local_Driving_License_Applications.SelectedRows[0].Cells["LocalDrivingLicenseApplicationID"];

            if (result.Value != null && int.TryParse(result.Value.ToString(), out int ID))
            {
                return ID;
            }

            return -1;
        }
        private void schedualVisionTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int LocalDrivingLisAppID = GetLocalDrivingLicenseApplicationIDFromGrid();

            if (LocalDrivingLisAppID <= 0)
            {
                MessageBox.Show("Invalid selection. Please select a valid application.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Form frmVisionTest = new Vision_Test_Appointments(LocalDrivingLisAppID);
            frmVisionTest.ShowDialog();
            Grid_Initialize();


        }
        private void SchedualWritenTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int LocalDrivingLicenseAppID = GetLocalDrivingLicenseApplicationIDFromGrid();
            if (LocalDrivingLicenseAppID <= 0)
            {
                MessageBox.Show("Invalid selection. Please select a valid application.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Form frmWrittenTest = new Written_Test_Appointments(LocalDrivingLicenseAppID);
            frmWrittenTest.ShowDialog();
            Grid_Initialize();
        }
        private void schedualStreetTestToolStripMenuItem_Click(object sender, EventArgs e)
        {

            int LocalDrivingLicenseAppID = GetLocalDrivingLicenseApplicationIDFromGrid();
            if (LocalDrivingLicenseAppID <= 0)
            {
                MessageBox.Show("Invalid selection. Please select a valid application.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Form frmStreetTestAppointments = new Street_Test_Appointments(LocalDrivingLicenseAppID);
            frmStreetTestAppointments.ShowDialog();
            Grid_Initialize();
        }
        private void issueDrivingLicenseFirstTimeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int LocalDrivingLicenseAppID = GetLocalDrivingLicenseApplicationIDFromGrid();
            if (LocalDrivingLicenseAppID <= 0)
            {
                MessageBox.Show("Invalid selection. Please select a valid application.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Form frmIssueLicenseForTheFirstTime = new Issue_Driver_License_For_The_First_Time(LocalDrivingLicenseAppID);
            frmIssueLicenseForTheFirstTime.ShowDialog();
            Grid_Initialize();
        }
        private void showLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int LocalDrivingLicenseAppID = GetLocalDrivingLicenseApplicationIDFromGrid();
            if (LocalDrivingLicenseAppID <= 0)
            {
                MessageBox.Show("Invalid selection. Please select a valid application.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                int ApplicationID = BLL.LocalDrivingLicenseApplicationBLL.GetApplicationID(LocalDrivingLicenseAppID);
                Form frmDriverInfo = new License_Info(ApplicationID);
                frmDriverInfo.ShowDialog();

            }
        }
        private void showPersonalLicenseHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int ApplicationID = BLL.LocalDrivingLicenseApplicationBLL.GetApplicationID(GetLocalDrivingLicenseApplicationIDFromGrid());
            int DriverID = BLL.DriverBLL.GetDriverIDByApplcationID(ApplicationID);
            int PersonID = BLL.PeopleBLL.GetPersonIDByApplicationID(ApplicationID);
            if (DriverID != -1)
            {
                Form frmLicenseHistory = new License_History(DriverID, PersonID);
                frmLicenseHistory.ShowDialog();
            }
            else
            {
                MessageBox.Show("This Person Isn`t a Driver.", "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

        }
        private void cancelApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var selectedRow = dgv_Local_Driving_License_Applications.SelectedRows[0];
            string status = selectedRow.Cells["Status"].Value?.ToString() ?? "";
            int LDLAppID = GetLocalDrivingLicenseApplicationIDFromGrid();
            if (MessageBox.Show("Are You sureto cancel this local Driving license Application with ID: " + LDLAppID.ToString(), "Conform ?", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                if (status != "Completed")
                {
                    int ApplicationID = BLL.LocalDrivingLicenseApplicationBLL.GetApplicationID(LDLAppID);
                    if (ApplicationsBLL.ChangeApplicationStatus(ApplicationID, 2, DateTime.Now))
                    {
                        Grid_Initialize();
                    }
                }

            }

        }
        private void deleteApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var selectedRow = dgv_Local_Driving_License_Applications.SelectedRows[0];
            string status = selectedRow.Cells["Status"].Value?.ToString() ?? "";
            string PassedTests = selectedRow.Cells["PassedTestCount"].Value?.ToString().Trim() ?? "";
            if ((status == "New" && PassedTests == "0") || (status == "Cancelled" && PassedTests == "0"))
            {
                int LDLAppID = GetLocalDrivingLicenseApplicationIDFromGrid();
                if (MessageBox.Show("Are You sure to delete this local Driving license Application with ID: " + LDLAppID.ToString(), "Conform ?", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    int ApplicationID = BLL.LocalDrivingLicenseApplicationBLL.GetApplicationID(LDLAppID);

                    if (BLL.LocalDrivingLicenseApplicationBLL.DeleteLocalDrivingLicenseApplication(LDLAppID))
                    {
                        if (BLL.ApplicationsBLL.DeleteApplication(ApplicationID))
                        {
                            MessageBox.Show("Application Deleted ", "Complete", MessageBoxButtons.OK);
                            Grid_Initialize();

                        }


                    }
                    else
                    {
                        MessageBox.Show("Error occure while Deleting", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

            }
        }

        private void editApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int LDLAppID = GetLocalDrivingLicenseApplicationIDFromGrid();
            (int PassedTests, string Status) = GetPassedTestsAndStatusFromGrid();
            if (Status == "New")
            {
                if (Convert.ToInt16(PassedTests) < 3)
                {
                    Form frmUpdateLoccalDrivingLicenseApplcaition = new New_Local_Driving_License_Application(LDLAppID);
                    frmUpdateLoccalDrivingLicenseApplcaition.ShowDialog();


                }
                else
                {
                    MessageBox.Show("You can't edit this application because he already take three tests .", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                Grid_Initialize();
            }
            else if (Status == "Completed")
            {
                MessageBox.Show("You can't edit this application because he already Has a license  .", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (Status == "Cancelled")
            {
                MessageBox.Show("You can't edit this application because It is cancelled", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }
    }
}
