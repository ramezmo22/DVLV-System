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
    public partial class Schedule_Test : Form
    {
        public int DrivingLicenseApplicationID = -1;
        public int AppointmentID = -1;
        public enum enTestType { enVisionTest = 1, enWrittenTest = 2, enStreetTest = 3 };
        public enum enTestTypeMood { enAddNew=1, enEdit=2, enReTake=3 ,enEditLocked=4}
        public Schedule_Test(int DrivingLicenseApplicationID, enTestType type,enTestTypeMood typeMood,int AppoinrmentID=-1)
        {
            this.AppointmentID = AppoinrmentID;
            this.DrivingLicenseApplicationID = DrivingLicenseApplicationID;
            InitializeComponent();
            LoudData(type,typeMood);
        }
        public void LoudData(enTestType type,enTestTypeMood TypeMood)
        {
            switch (type)
            {
                case enTestType.enVisionTest:
                    {
                        ctr_Vision_Test_Setter1.Visible = true;
                        ctr_Street_Test_Setter1.Visible = false;
                        written_Test_Setter1.Visible = false;

                        if (TypeMood == enTestTypeMood.enAddNew)
                        {
                            ctr_Vision_Test_Setter1.LoudData(DrivingLicenseApplicationID, ctr_Vision_Test_Setter.enMood.enAddNew);
                        }
                        else if(TypeMood==enTestTypeMood.enEdit)
                        {
                            ctr_Vision_Test_Setter1.LoudData(DrivingLicenseApplicationID, ctr_Vision_Test_Setter.enMood.enEdit,AppointmentID); 
                        }
                        else if(TypeMood==enTestTypeMood.enEditLocked)
                        {
                            ctr_Vision_Test_Setter1.LoudData(DrivingLicenseApplicationID, ctr_Vision_Test_Setter.enMood.enLockedEdit, AppointmentID);
                        }
                        break;
                    }

                case enTestType.enWrittenTest:
                    {
                        written_Test_Setter1.Visible = true;
                        ctr_Street_Test_Setter1.Visible = false;
                        ctr_Vision_Test_Setter1.Visible = false;
                        //Street Test False
                        if (TypeMood == enTestTypeMood.enAddNew)
                        {
                            written_Test_Setter1.LoudData(DrivingLicenseApplicationID, Written_Test_Setter.enMood.enAddNew);
                        }
                        else if (TypeMood == enTestTypeMood.enEdit)
                        {
                            written_Test_Setter1.LoudData(DrivingLicenseApplicationID, Written_Test_Setter.enMood.enEdit,AppointmentID);
                        }
                        else if (TypeMood == enTestTypeMood.enEditLocked)
                        {
                            written_Test_Setter1.LoudData(DrivingLicenseApplicationID, Written_Test_Setter.enMood.enLockedEdit,AppointmentID);
                        }
                        break;
                    }
                case enTestType.enStreetTest:
                    {

                        ctr_Street_Test_Setter1.Visible = true;
                        ctr_Vision_Test_Setter1.Visible = false;
                        written_Test_Setter1.Visible = false;

                        if (TypeMood == enTestTypeMood.enAddNew)
                        {
                            ctr_Street_Test_Setter1.LoudData(DrivingLicenseApplicationID, Street_Test.ctr_Street_Test_Setter.enMood.enAddNew);
                        }
                        else if (TypeMood == enTestTypeMood.enEdit)
                        {
                            ctr_Street_Test_Setter1.LoudData(DrivingLicenseApplicationID, Street_Test.ctr_Street_Test_Setter.enMood.enEdit, AppointmentID);
                        }
                        else if (TypeMood == enTestTypeMood.enEditLocked)
                        {
                            ctr_Street_Test_Setter1.LoudData(DrivingLicenseApplicationID, Street_Test.ctr_Street_Test_Setter.enMood.enLockedEdit, AppointmentID);

                        }
                        break;
                    }
            }

        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
