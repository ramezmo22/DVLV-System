using DVLV.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DVLV.BLL;
using DVLV.UI.controlls;

namespace DVLV.UI.Tests_Manage
{
    public partial class Vision_Test_Appointments : Form
    {
        public int LocalDrivingLicenseApplicationID = -1;
        public int ApplicationID = -1;
        public Vision_Test_Appointments(int LocalDrivingLicenseApplicationID)
        {
            this.LocalDrivingLicenseApplicationID = LocalDrivingLicenseApplicationID;
            ApplicationID = BLL.LocalDrivingLicenseApplicationBLL.GetApplicationID(LocalDrivingLicenseApplicationID);
            InitializeComponent();
            ctr_Application_basic_Info1.loudData(ApplicationID);
            driving_License_Application_Info1.LoudControlData(LocalDrivingLicenseApplicationID, controlls.Driving_License_Application_Info.enLicenseType.enLocal);
            AppointmentGridInitilaization();
            //Just one time at the beginning of form 
            //Driving License Application Control Initialize 
            //Application basic info initial 
            //Appointments Data Grid view initialize 
        }

        public void AppointmentGridInitilaization()
        {
            DataTable AppointmentsTable = BLL.TestAppointmentsBLL.GetAppointmentsDataTable(LocalDrivingLicenseApplicationID,1);

            if (AppointmentsTable.Rows.Count < 1)
            {
                return;
            }


            // تعطيل التوليد التلقائي للأعمدة
            dataGridView1.AutoGenerateColumns = false;

            // Clear existing columns if any
            dataGridView1.Columns.Clear();

            // Add columns matching the database structure
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "TestAppointmentID", HeaderText = "Test Appointment ID", DataPropertyName = "TestAppointmentID", Width = 150 });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "AppointmentDate", HeaderText = "Appointment Date", DataPropertyName = "AppointmentDate", Width = 150 });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "PaidFees", HeaderText = "Paid Fees", DataPropertyName = "PaidFees", Width = 100 });
            dataGridView1.Columns.Add(new DataGridViewCheckBoxColumn() { Name = "IsLocked", HeaderText = "Is Locked", DataPropertyName = "IsLocked", Width = 80 });

            // Bind the DataTable to the DataGridView
            dataGridView1.DataSource = AppointmentsTable;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count < 1)
            {
                e.Cancel = true;  // This prevents the menu from showing
                return;
            }
        }

        private void btn_Add_Appointment_Click(object sender, EventArgs e)
        {
            if (TestsBLL.IsPersonHasPassedTheTest(LocalDrivingLicenseApplicationID, 1))//1 For Vision Test
            {
                MessageBox.Show("This person already Passed the vision exam ", "Alert ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (BLL.TestAppointmentsBLL.IsPersonHasAcctiveAppointment(LocalDrivingLicenseApplicationID, 1)) //(non-locked Appointment)
            {
                MessageBox.Show(" Person already have an active appointment for this test You cannot add new appointment.", "Not allowed ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }




            if (LocalDrivingLicenseApplicationID != -1)
            {
                Form frmSchedualTest = new Schedule_Test(LocalDrivingLicenseApplicationID, Schedule_Test.enTestType.enVisionTest, Schedule_Test.enTestTypeMood.enAddNew);
                frmSchedualTest.ShowDialog();
                AppointmentGridInitilaization();
            }
            else
            {

                return;
            }

        }


        private int GetAppointmentIDFromGrid()
        {
            int AppointmentID = -1;
            if (dataGridView1.SelectedRows.Count > 0)
            {
                AppointmentID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["TestAppointmentID"].Value);

            }
            else
            {
                MessageBox.Show(" You must select a Row.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return AppointmentID;
        }

        //
        //
        //
        //
        
        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int AppointemntID = GetAppointmentIDFromGrid();
            if (AppointemntID != -1)
            {
                //Yes Here we have a row but ist locked or not?? 🙂
                if (!BLL.TestAppointmentsBLL.IsAppointmentLocked(AppointemntID))
                {
                    Form frmSchedualTest = new Schedule_Test(LocalDrivingLicenseApplicationID, Schedule_Test.enTestType.enVisionTest, Schedule_Test.enTestTypeMood.enEdit, AppointemntID);
                    frmSchedualTest.ShowDialog();
                    AppointmentGridInitilaization();

                }
                else
                {
                    Form frmSchedualTest = new Schedule_Test(LocalDrivingLicenseApplicationID, Schedule_Test.enTestType.enVisionTest, Schedule_Test.enTestTypeMood.enEditLocked, AppointemntID);
                    frmSchedualTest.ShowDialog();
                }
            }
            else
            {
                return;
            }
        }

        private void takeTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int AppointemntID = GetAppointmentIDFromGrid();
            if(AppointemntID !=-1)
            {
                if (!BLL.TestAppointmentsBLL.IsAppointmentLocked(AppointemntID))
                {
                    Form frmTakeTest = new Take_Test(AppointemntID, LocalDrivingLicenseApplicationID, Take_Test.enTestType.enVisionTest);
                    frmTakeTest.ShowDialog();
                    AppointmentGridInitilaization();
                    driving_License_Application_Info1.LoudControlData(LocalDrivingLicenseApplicationID, Driving_License_Application_Info.enLicenseType.enLocal);

                }
                else
                {
                    MessageBox.Show("The person Has taken this exam and it is locked . ", "Not Allowed!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                return;
            }
        }
    }
}
