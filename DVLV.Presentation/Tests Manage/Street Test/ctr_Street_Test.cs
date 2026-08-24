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
    public partial class ctr_Street_Test : UserControl
    {
        public ctr_Street_Test()
        {
            InitializeComponent();
        }
        public enum enMood { enTestCardShow = 1, enLockedTest = 2 };
        enMood Mood;
        int DrivingLicenseApplicationID = -1;
        int AppointmentID = -1;
        public void LoadData(int DrivingLicenseApplicationID, enMood Mood, int AppointmentID = -1)
        {
            this.AppointmentID = AppointmentID;
            this.Mood = Mood;
            this.DrivingLicenseApplicationID = DrivingLicenseApplicationID;
            //Gitting Data From BLL->DAL
            (string DclassName, string Name, int Trials, int Fees) = LocalDrivingLicenseApplicationBLL.GetApplicationDataForScheduleTest(DrivingLicenseApplicationID, 3);
            lbl_DrivingLicenseApplicationID.Text = this.DrivingLicenseApplicationID.ToString();
            lbl_LicenseClass.Text = DclassName;
            lbl_Name.Text = Name;
            lbl_Trail.Text = Trials.ToString();
            DateTime Date = BLL.TestAppointmentsBLL.GetAppointmentDate(AppointmentID);
            lbl_Date.Text = Date.ToString("dd/MM/yyyy");
            lbl_Fees.Text = Fees.ToString();
        }
    }
}
