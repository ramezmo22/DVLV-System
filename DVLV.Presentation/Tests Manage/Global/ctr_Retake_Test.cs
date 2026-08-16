using DVLV.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DVLV.UI.Tests_Manage
{
    public partial class ctr_Retake_Test : UserControl
    {
        int RetakeTestFees = 0;
        public ctr_Retake_Test()
        {
            InitializeComponent();
        }
        private int AppointmentID = -1;
        private int LocalDrivingLicenseApplicationID = -1;
        public void LoudData(int AppointmentID,int LocalDrivingLicenseApplicationID,int TestFees)
        {
            this.AppointmentID = AppointmentID;
            this.LocalDrivingLicenseApplicationID = LocalDrivingLicenseApplicationID;
            

            int RetakeTestFees = 0;
            string Title = "";
            int RetakeTestID = 8;
            BLL.ApplicationTypesBLL.GetType(ref RetakeTestID, ref Title, ref RetakeTestFees);
            lbl_Retake_Test_Application_Fees.Text = RetakeTestFees.ToString();
            int TotalFees =RetakeTestFees + TestFees;
            this.RetakeTestFees = RetakeTestFees;
            lbl_Total_Fees.Text = TotalFees.ToString();
           
            
            
        



        }
        public bool CreateRetakeTestApplication()
        {
            int LicenseApplicationID= BLL.LocalDrivingLicenseApplicationBLL.GetApplicationID(LocalDrivingLicenseApplicationID);
            ApplicationsBLL LicenseApplication = BLL.ApplicationsBLL.Find(LicenseApplicationID);
            int PersonID = LicenseApplication.PersonID;//I Know that method is weared but its better for performance

            ApplicationsBLL RetaketestApplication = new ApplicationsBLL(PersonID);
            //Fill the Application Data Manually
                RetaketestApplication.Date = DateTime.Now;
                RetaketestApplication.TypeID = 8;
                RetaketestApplication.StutusID = 3;
                RetaketestApplication.PaidFees = this.RetakeTestFees;
                RetaketestApplication.LastStutusDate = DateTime.Now;
            
            if(RetaketestApplication.Save())
            {
                return true;
            }
            else
            {
                return false;
            }



        }

    }
}
