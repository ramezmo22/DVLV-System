using DVLV.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DVLV.UI.Tests_Manage.Street_Test
{
    public partial class ctr_Street_Test_Setter : UserControl
    {
        public ctr_Street_Test_Setter()
        {
            InitializeComponent();
        }


        public enum enMood { enAddNew = 1, enEdit = 2, enRetake = 3, enLockedEdit = 4 };
        enMood Mood = enMood.enAddNew;
        int DrivingLicenseApplicationID = -1;
        int AppointmentID = -1;
        int Fees = -1;

        public void LoudData(int DrivingLicenseApplicationID, enMood Mood = enMood.enAddNew, int AppointmentID = -1)
        {
            this.AppointmentID = AppointmentID;
            this.Mood = Mood;
            this.DrivingLicenseApplicationID = DrivingLicenseApplicationID;
            //Gitting Data From BLL->DAL
            (string DclassName, string Name, int Trials, int Fees) = LocalDrivingLicenseApplicationBLL.GetApplicationDataForScheduleTest(DrivingLicenseApplicationID, 3);

            if (Mood == enMood.enAddNew && Trials > 0)
            {
                this.Mood = enMood.enRetake;
                Mood = enMood.enRetake;
            }


            lbl_DrivingLicenseApplicationID.Text = this.DrivingLicenseApplicationID.ToString();
            lbl_LicenseClass.Text = DclassName;
            lbl_Name.Text = Name;
            lbl_Trail.Text = Trials.ToString();
            lbl_Fees.Text = Fees.ToString();
            this.Fees = Fees;

            dtp_Date.MinDate = DateTime.Now;
            dtp_Date.MaxDate = DateTime.Now.AddYears(5);



            switch (Mood)
            {
                case enMood.enAddNew:
                    {
                        dtp_Date.Value = DateTime.Now;
                        break;
                    }
                case enMood.enEdit:
                    {
                        DateTime Date = BLL.TestAppointmentsBLL.GetAppointmentDate(AppointmentID);
                        if (Date == DateTime.MinValue)
                        {
                            //Error handelling
                        }
                        lbl_header.Text = "Edit Test Date";
                        lbl_LastAppointmentDate.Visible = true;
                        // Set appropriate date range for LastAppointmentDate picker
                        dtp_LastAppointmentDate.MinDate = DateTime.Now.AddYears(-5);
                        dtp_LastAppointmentDate.MaxDate = DateTime.Now.AddYears(5);
                        dtp_LastAppointmentDate.Value = Date;
                        dtp_LastAppointmentDate.Visible = true;

                        break;
                    }
                case enMood.enRetake:
                    {
                        lbl_header.Text = "Scedual Retake Test";
                        ctr_Retake_Test1.Enabled = true;
                        ctr_Retake_Test1.LoudData(AppointmentID, DrivingLicenseApplicationID, Convert.ToInt16(lbl_Fees.Text));


                        break;
                    }
                case enMood.enLockedEdit:
                    {
                        lbl_header.Text = "Loacked Test.";
                        lbl_HeaderLoackedTest.Visible = true;
                        btn_Save.Enabled = false;
                        DateTime Date = BLL.TestAppointmentsBLL.GetAppointmentDate(AppointmentID);
                        dtp_Date.MinDate = Date;
                        dtp_Date.Value = Date;
                        dtp_Date.Enabled = false;


                        break;
                    }


            }





        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            switch (Mood)
            {
                case enMood.enAddNew:
                    {

                        if (BLL.TestAppointmentsBLL.AddNewTestAppointment(3, DrivingLicenseApplicationID, dtp_Date.Value, Convert.ToInt16(lbl_Fees.Text), CurrentUserBLL.UserID, false) > -1)
                        {
                            MessageBox.Show(" The appointment Added successfully .", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.FindForm().Close();
                        }
                        else
                        {
                            MessageBox.Show("Error occur while Saving. ", "Error  ", MessageBoxButtons.OK, MessageBoxIcon.Information);


                        }


                        break;
                    }
                case enMood.enEdit:
                    {
                        if (BLL.TestAppointmentsBLL.UpdateDate(AppointmentID, dtp_Date.Value))
                        {
                            MessageBox.Show("  Date Updated Successfully .", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.FindForm().Close();
                        }
                        else
                            MessageBox.Show("Error occur while Saving. ", "Error  ", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        break;
                    }
                case enMood.enRetake:
                    {
                        //Create Application 
                        if (!ctr_Retake_Test1.CreateRetakeTestApplication())
                            MessageBox.Show("Error occurred while creating an application ", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        //Create the New Appointment
                        if (BLL.TestAppointmentsBLL.AddNewTestAppointment(3, DrivingLicenseApplicationID, DateTime.Now, Fees, BLL.CurrentUserBLL.UserID, false) > -1)
                        {
                            MessageBox.Show(" The appointment Added successfully .", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.FindForm().Close();
                        }
                        else
                        {
                            MessageBox.Show("Error occur while Saving. ", "Error  ", MessageBoxButtons.OK, MessageBoxIcon.Information);


                        }




                        break;
                    }
            }
        }
    }
}
