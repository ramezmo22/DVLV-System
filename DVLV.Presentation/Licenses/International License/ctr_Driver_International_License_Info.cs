using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DVLV.UI.Licenses.International_License
{
    public partial class ctr_Driver_International_License_Info : UserControl
    {
        private int InternationaLicenseID = -1;
        public ctr_Driver_International_License_Info()
        {
            InitializeComponent();
        }
        public void LoudData(int InternationalLicenseID)
        {
            this.InternationaLicenseID = InternationalLicenseID;
            (string FullName,
            int LicenseID,
            string NationalNumber,
            int Gender,
            DateTime IssueDate,
            DateTime ExpirationDate,
            int DriverID,
            DateTime DateOfBirth,
            bool IsActive,
            int ApplicationID
            ) = BLL.DriverBLL.GetDriverInternationalLicenseInfo(InternationalLicenseID);

            lbl_International_License_ID.Text = InternationalLicenseID.ToString();
            lbl_Name.Text = FullName;
            lbl_Local_License_ID.Text = LicenseID.ToString();
            lbl_National_Number.Text = NationalNumber;
            lbl_Gender.Text = Gender == 1 ? "Female" : "Male";
            lbl_Issue_date.Text = IssueDate.ToString("dd/MM/yyyy");
            lbl_Expiration_Date.Text = ExpirationDate.ToString("dd/MM/yyyy");
            lbl_InterNational_License_Application_ID.Text = ApplicationID.ToString();
            lbl_IsActive.Text = IsActive ? "Yes" : "No";
            lbl_DriverID.Text = DriverID.ToString();
            lbl_Date_Of_Birth.Text = DateOfBirth.ToString("dd/MM/yyyy");
        }
     




    }
}
