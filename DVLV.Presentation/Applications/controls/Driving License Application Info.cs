using DVLV.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DVLV.UI.controlls
{
    public partial class Driving_License_Application_Info : UserControl
    {
        public Driving_License_Application_Info()
        {
            InitializeComponent();
        }
        public int DrivingLicenseApplicationID = -1;
        public enum enLicenseType { enLocal, enEnternational };
        //public enLicenseType type = enLicenseType.enLocal;
        public void LoudControlData(int DrivingLicenseApplicationID, enLicenseType type)
        {
            this.DrivingLicenseApplicationID = DrivingLicenseApplicationID;
            switch (type)
            {
                case enLicenseType.enLocal:
                    {
                        var LicenseClassDiscribtion = "";
                        var passedTestsCount = -1;
                        (LicenseClassDiscribtion, passedTestsCount) = BLL.LocalDrivingLicenseApplicationBLL.GetLocalDrivingLicenseApplicationInfo(DrivingLicenseApplicationID);

                        lbl_License_Class_Info.Text = LicenseClassDiscribtion.ToString();
                        lbl_Number_Of_Passed_Tests.Text = passedTestsCount.ToString();
                        lbl_Driving_License_Application_ID.Text = DrivingLicenseApplicationID.ToString();


                        break;
                    }

                // Not Already Implemanted--->
                case enLicenseType.enEnternational:
                    {





                        break;
                    }
            }


        }

    }
}
