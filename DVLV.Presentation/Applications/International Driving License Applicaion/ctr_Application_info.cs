using DVLV.BLL;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DVLV.UI.Applications_Manage.International_Driving_License_Applicaion
{
    public partial class ctr_Application_info : UserControl
    {
        private int LicenseID = -1;
        public enum enMood { enShowmood = 1, enAddNewMood = 2 }
        enMood Mood = enMood.enAddNewMood;
        public ctr_Application_info()
        {
            InitializeComponent();
        }


        public void LoudData(int LicenseID, enMood Mood)
        {
            this.LicenseID = LicenseID;
            this.Mood = Mood;
            switch (Mood)
            {
                case enMood.enShowmood:
                    {
                        this.LicenseID = LicenseID;
                        (int InternationalApplicationID,
                            DateTime ApplicationDate,
                            DateTime IssueDate,
                            int fees,
                            int InternationalLicenseID,
                            DateTime ExpiarartionDate,
                            String CreatedByUserName) = BLL.InternationalLicenseApplicationBLL.GetApplciationInfo(this.LicenseID);

                        lbl_InterNational_License_Application_ID.Text = InternationalApplicationID.ToString();
                        lbl_Application_Date.Text = ApplicationDate.ToString("dd/MM/yyyy");
                        lbl_Issue_date.Text = IssueDate.ToString("dd/MM/yyyy");
                        lbl_Fees.Text = fees.ToString();
                        lbl_International_License_ID.Text = InternationalLicenseID.ToString();
                        lbl_Local_License_ID.Text = this.LicenseID.ToString();
                        lbl_Expiration_Date.Text = ExpiarartionDate.ToString("dd/MM/yyyy");
                        lbl_Created_By_UserName.Text = CreatedByUserName;
                        break;
                    }
                case enMood.enAddNewMood:
                    {
                        int ApplicationType = 6;
                        int Fees = 0;
                        string Title = "";
                        BLL.ApplicationTypesBLL.GetType(ref ApplicationType, ref Title, ref Fees);


                        lbl_InterNational_License_Application_ID.Text = "[???]";
                        lbl_Application_Date.Text = DateTime.Now.ToString("dd/MM/yyyy");
                        lbl_Issue_date.Text = DateTime.Now.ToString("dd/MM/yyyy");
                        lbl_Fees.Text = Fees.ToString();
                        lbl_International_License_ID.Text = "[???]";
                        lbl_Local_License_ID.Text = this.LicenseID.ToString();
                        lbl_Expiration_Date.Text = DateTime.Now.AddYears(1).ToString("dd/MM/yyyy");
                        lbl_Created_By_UserName.Text = CurrentUserBLL.UserName;
                        break;
                    }
            }


        }
    }
}
