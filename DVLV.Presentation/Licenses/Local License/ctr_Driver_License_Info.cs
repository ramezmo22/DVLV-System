using DVLV.UI.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Security.Policy;
using System.Text;
using System.Windows.Forms;

namespace DVLV.UI.Licenses
{
    public partial class ctr_Driver_License_Info : UserControl
    {

        private int ApplicationID = -1;
        private int LicenseID = -1;
        public ctr_Driver_License_Info()
        {
            InitializeComponent();
        }
        public void LoudControlData(int ApplicationID)
        {
            this.ApplicationID = ApplicationID;
            if (ApplicationID != -1)
            {
                this.LicenseID = BLL.LicenseBLL.GetLicenseIDByApplicationID(ApplicationID);
                if (LicenseID != -1)
                {
                    string ClassName = string.Empty;
                    string Fullname = string.Empty;
                    int LicenseID = this.LicenseID;
                    string NationalNumber = string.Empty;
                    int Gendor = -1;
                    DateTime IssueDate = DateTime.Now;
                    int IssueReason = -1;
                    string Notes = string.Empty;
                    bool isActive = false;
                    DateTime DateOfBirth = DateTime.Now;
                    int DriverID = -1;
                    DateTime ExpirationDate = DateTime.Now;
                    string ImagePath = string.Empty;

                    BLL.DriverBLL.GetDriverinfo(
                        ref ClassName,
                        ref Fullname,
                        ref LicenseID,
                        ref NationalNumber,
                        ref Gendor,
                        ref IssueDate,
                        ref IssueReason,
                        ref Notes,
                        ref isActive,
                        ref DateOfBirth,
                        ref DriverID,
                        ref ExpirationDate,
                        ref ImagePath);

                    // connect Data With Labels
                    lbl_License_Class.Text = ClassName;
                    lbl_Full_Name.Text = Fullname;
                    lbl_LicenseID.Text = LicenseID.ToString();
                    lbl_National_Number.Text = NationalNumber;
                    lbl_Gender.Text = Gendor == 0 ? "Male" : "Female";
                    lbl_Issue_Date.Text = IssueDate.ToString("dd/MM/yyyy");
                    switch (IssueReason)
                    {
                        case 1:
                            {
                                lbl_Issue_Reason.Text = "First Time";
                                break;
                            }
                        case 2:
                            {
                                lbl_Issue_Reason.Text = "Renew";
                                break;
                            }
                        case 3:
                            {
                                lbl_Issue_Reason.Text = "Repalcement for Damaged";
                                break;
                            }
                        case 4:
                            {
                                lbl_Issue_Reason.Text = "Replacement for Lost";
                                break;
                            }

                    }
                    lbl_IsActive.Text = isActive ? "Yes" : "No";
                    lbl_Date_Of_Birth.Text = DateOfBirth.ToString("dd/MM/yyyy");
                    lbl_DriverID.Text = DriverID.ToString();
                    lbl_Expiration_Date.Text = ExpirationDate.ToString("dd/MM/yyyy");
                    //handel ImagePath
                    if (!string.IsNullOrWhiteSpace(ImagePath) && File.Exists(ImagePath))
                    {
                        ptb_Person_Image.Load(ImagePath);
                    }
                    else
                    {
                        ptb_Person_Image.Image = Resources.Male_512;
                    }
                    lbl_Is_Detained.Text = BLL.LicenseBLL.IsLicenseDetaind(this.LicenseID) ? "Yes" : "NO";
                    //handel Notes
                    if (string.IsNullOrEmpty(Notes))
                        lbl_Notes.Text = "No Notes";
                    else
                        lbl_Notes.Text = Notes;
                }
            }
        }


    }
}
