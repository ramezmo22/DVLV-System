using DVLV.BLL;
using DVLV.UI.Tests_Manage.Street_Test;
using DVLV.UI.Tests_Manage.Written_Test;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DVLV.UI.Tests_Manage
{
    public partial class Take_Test : Form
    {
        private int TestAppointmentID = -1;
        private int LocalDrivingApplicationID = -1;
        public enum enTestType { enVisionTest = 1, enWrittenTest = 2, enStreetTest = 3 };
        enTestType Type;
        public Take_Test(int AppointmentID, int LocalDrivingApplicationID, enTestType Type)
        {
            this.LocalDrivingApplicationID = LocalDrivingApplicationID;
            this.TestAppointmentID = AppointmentID;
            this.Type = Type;
            InitializeComponent();
            LoadData();
        }
        public void LoadData()
        {
            rdb_Pass.Checked = true;
            rdb_Fail.Checked = false;

            ctr_Written_Test1.Visible = false;
            ctr_Street_Test1.Visible = false;
            ctr_Vision_Test1.Visible = false; 
            switch (Type)
            {
                case enTestType.enVisionTest:
                    {
                        ctr_Vision_Test1.LoadData(LocalDrivingApplicationID, ctr_Vision_Test.enMood.enTestCardShow, TestAppointmentID);
                        ctr_Vision_Test1.Visible = true;  

                        break;
                    }
                case enTestType.enWrittenTest:
                    {
                        ctr_Written_Test1.LoadData(LocalDrivingApplicationID, ctr_Written_Test.enMood.enTestCardShow, TestAppointmentID);
                        ctr_Written_Test1.Visible = true;
                        break;
                    }
                case enTestType.enStreetTest:
                    {
                        ctr_Street_Test1.LoadData(LocalDrivingApplicationID, ctr_Street_Test.enMood.enTestCardShow, TestAppointmentID);
                        ctr_Street_Test1.Visible = true;
                        break;
                    }
            }
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            bool result = rdb_Pass.Checked;
            string Notes = txt_Notes.Text;

            if(MessageBox.Show("Are you sure you want to save ? After this you cannot change the  Pass/Fail results After You Save?.","Conform",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning)==DialogResult.OK)
            {
                int TestID = TestsBLL.AddTest(TestAppointmentID, result, Notes);
                if (BLL.TestAppointmentsBLL.UpdateLockStutus(TestAppointmentID, true))
                {
                    MessageBox.Show("Data saved successfully .", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error occurred while saving !", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                return;
            }

            






        }
    }
}
