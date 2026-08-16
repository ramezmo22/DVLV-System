using DVLV.BLL;
using System;
using System.Windows.Forms;

namespace DVLV.UI.Applications_Manage.International_Driving_License_Applicaion
{
    public partial class New_International_License_Application : Form
    {
        private int LocalLicenseID = -1;
        private int DriverID = -1;
        private int LocalApplcaitionID = -1;
        private int ApplicationFees = -1;
        private int InternationalLicenseID = -1;

        enum enMood { enShow = 1, enAddNew = 2 }
        enMood Mood = enMood.enAddNew;

        public New_International_License_Application()
        {
            InitializeComponent();
            LoadApplicationFees();
        }

        private void LoadApplicationFees()
        {
            int TypeID = 6, Fees = -1;
            string title = "";
            ApplicationTypesBLL.GetType(ref TypeID, ref title, ref Fees);
            ApplicationFees = Fees;
        }

        private void ctr_License_Filter1_OnLicenseSelected(int obj)
        {
            if (obj == -1) return;

            LocalLicenseID = obj;
            DriverID = DriverBLL.GetDriverIDByLicenseID(LocalLicenseID);
            LocalApplcaitionID = ApplicationsBLL.GetApplicationIDByLicenseID(LocalLicenseID);

            ctr_Driver_License_Info1.Enabled = true;
            ctr_Driver_License_Info1.LoudControlData(LocalApplcaitionID);

            if (InternationalLicenseApplicationBLL.HasInternationalLicense(LocalLicenseID))
            {
                this.InternationalLicenseID = BLL.LicenseBLL.GetInternationalLicenseIDByLicenseID(this.LocalLicenseID);
                ctr_Application_info1.LoudData(LocalLicenseID, ctr_Application_info.enMood.enShowmood);
                Mood = enMood.enShow;
                lnk_Show_Licenses_Info.Enabled = true;
                btn_Issue_License.Enabled = false;
            }
            else
            {
                ctr_Application_info1.LoudData(LocalLicenseID, ctr_Application_info.enMood.enAddNewMood);
                Mood = enMood.enAddNew;
                btn_Issue_License.Enabled = true;
                lnk_Show_Licenses_Info.Enabled = false;
            }
        }

        private void btn_Close_Click(object sender, EventArgs e) => Close();

        private void lnk_Show_Licenses_History_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (DriverID == -1) return;

            int PersonID = PeopleBLL.GetPersonIDByDriverID(DriverID);
            using Form frmLicensesHistory = new Licenses.License_History(DriverID, PersonID);
            frmLicensesHistory.ShowDialog();
        }

        private void btn_Issue_License_Click(object sender, EventArgs e)
        {
            // 1) If already in show mode - nothing to do
            if (Mood == enMood.enShow) return;

            int LicenseClassID = BLL.LicenseBLL.GetLicenseClassID(LocalLicenseID);
            if (LicenseClassID == 3)
            {
                // check license active & not expired, and not detained
                if (BLL.LicenseBLL.IsLicenseActiveAndNonExpiared(LocalLicenseID))
                {
                    if (!BLL.LicenseBLL.IsLicenseDetaind(LocalLicenseID))
                    {
                        ApplicationsBLL application = new ApplicationsBLL(
                            PeopleBLL.GetPersonIDByDriverID(DriverID),
                            DateTime.Now,
                            6,
                            1,
                            ApplicationFees,
                            DateTime.Now,
                            CurrentUserBLL.UserID);

                        if (application.Save())
                        {
                            int NewInternationalLicenseID = InternationalLicenseApplicationBLL.AddNewInrternationalLicense(
                                application.ApplicationID,
                                DriverID,
                                LocalLicenseID,
                                DateTime.Now,
                                DateTime.Now.AddYears(1),
                                true,
                                CurrentUserBLL.UserID);

                            if (NewInternationalLicenseID > -1)
                            {
                                MessageBox.Show("International Lisense Issued Successfully with ID: " + NewInternationalLicenseID, "Successfull",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                                ApplicationsBLL.ChangeApplicationStatus(application.ApplicationID, 3, DateTime.Now);
                                this.InternationalLicenseID = NewInternationalLicenseID;
                                Mood = enMood.enShow;
                                ctr_License_Filter1.LoadLicenseID(this.LocalLicenseID);

                            }
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("You cant Issue International License to License with class " + LicenseClassID, "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lnk_Show_Licenses_Info_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form frmInternationalLicenseDriverData = new Licenses.International_License.Driver_Information_License_Info(this.InternationalLicenseID);//ضايل التست
            frmInternationalLicenseDriverData.ShowDialog();
        }
    }
}
