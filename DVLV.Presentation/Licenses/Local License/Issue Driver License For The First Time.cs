using DVLV.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace DVLV.UI.Licenses
{
    public partial class Issue_Driver_License_For_The_First_Time : Form
    {
        private int ApplcaitionID = -1;
        private int LocalDrivingLicenseApplcaitionID = -1;

        public Issue_Driver_License_For_The_First_Time(int LocalDrivingLicenseApplcaitionID)
        {
            this.LocalDrivingLicenseApplcaitionID = LocalDrivingLicenseApplcaitionID;
            //ApplciationID
            this.ApplcaitionID = BLL.LocalDrivingLicenseApplicationBLL.GetApplicationID(LocalDrivingLicenseApplcaitionID);
            //Form Louding 
            InitializeComponent();
            //control louding
            driving_License_Application_Info1.LoudControlData(LocalDrivingLicenseApplcaitionID,controlls.Driving_License_Application_Info.enLicenseType.enLocal);
            ctr_Application_basic_Info1.loudData(ApplcaitionID);
        }

        private void btn_License_Issue_Click(object sender, EventArgs e)
        {
            BLL.FirstTimeDriverLicenseBLL FirstTimeLicense = new FirstTimeDriverLicenseBLL(LocalDrivingLicenseApplcaitionID);
           int NewLicenseID= FirstTimeLicense.AddNewLicense(txt_Notes.Text.ToString());
            if(NewLicenseID!=-1)
            {
                MessageBox.Show(" Successfully adding a new license with ID = " + NewLicenseID.ToString() + ".", "Successful ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error occurred while issuing new license .", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.Close();
        }
        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
