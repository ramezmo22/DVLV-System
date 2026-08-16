using DVLV.BLL;
using DVLV.DAL;
using DVLV.UI.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DVLV.UI.Detains
{
    public partial class ctr_Detain_License_Info : UserControl
    {
        private int LicenseID = -1;
        public ctr_Detain_License_Info()
        {
            InitializeComponent();
        }

        public void LoadData(int LicenseID)
        {
            this.LicenseID = LicenseID;

            DTO_DetainedLicenseInfo licenseData = DetainedLicensesBLL.GetDetainedLicenseFullInfo(LicenseID);

            if (licenseData != null)
            {
                lbl_Class.Text = licenseData.ClassName;             
                lbl_Name.Text = licenseData.FullName;               
                lbl_LicenseID.Text = licenseData.LicenseID.ToString();
                lbl_National_Number.Text = licenseData.NationalNumber;
                lbl_Gendar.Text = licenseData.Gender;               
                lbl_Issue_Date.Text = licenseData.IssueDate;       
                lbl_Issue_Reason.Text = licenseData.IssueReason;      
                lbl_Notes.Text = licenseData.Notes;                  
                lbl_IsActive.Text = licenseData.IsActive;           
                lbl_Date_Of_Birth.Text = licenseData.DateOfBirth;   
                lbl_Driver_ID.Text = licenseData.DriverID.ToString();
                lbl_Expitration_Date.Text = licenseData.ExpirationDate;
                lbl_Is_Detained.Text = licenseData.IsDetained;
                if (licenseData.ImageURL != null)
                    pcb_Person_Picture.ImageLocation = licenseData.ImageURL;
                else
                    pcb_Person_Picture.Image = Resources.Male_512;
            }
        }

    }
}
