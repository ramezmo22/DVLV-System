using DVLV.BLL;
using DVLV.Presentation;
using DVLV.UI;
using DVLV.UI.Applications_Manage;
using DVLV.UI.Applications_Manage.International_Driving_License_Applicaion;
using DVLV.UI.Detains;
using DVLV.UI.Drivers;
using DVLV.UI.Licenses.Local_License;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace DVLV.Presentation
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void accountSettingsToolStripMenuItem_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void peopleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManagePeople frm_managePeople = new ManagePeople();
            frm_managePeople.ShowDialog();
        }

        private void signOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BLL.CurrentUserBLL.Clear();
            this.Close();
            //DVLV.Presentation.Program.Main();
            Application.Restart();
        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmUsers = new ManageUsers();
            frmUsers.ShowDialog();
        }

        private void currentUserInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int userid = BLL.CurrentUserBLL.UserID;
            if (userid == -1) { return; }
            UserBLL User = BLL.UserBLL.FindUser(userid);
            Form frmUserInfo = new UserInfo(userid, User.PersonID);
            frmUserInfo.ShowDialog();
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int userid = BLL.CurrentUserBLL.UserID;
            UserBLL User = BLL.UserBLL.FindUser(userid);


            Change_Password frmPassChange = new Change_Password(userid, User.PersonID);
            frmPassChange.ShowDialog();
        }

        private void manageApplicationTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmManageApplicationTypes = new Manage_Application_Types();
            frmManageApplicationTypes.ShowDialog();
        }

        private void manageToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form frmListTestTypes = new List_Test_Types();
            frmListTestTypes.ShowDialog();
        }

        private void localLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmNewLocalDrivingLicense = new New_Local_Driving_License_Application();
            frmNewLocalDrivingLicense.ShowDialog();
        }

        private void localDrivingLicenseApplicationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmDGVLDLApplications = new LocalDrivingLicenseApplications();
            frmDGVLDLApplications.ShowDialog();
        }

        private void driversToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmDriversList = new List_Drivers();
            frmDriversList.ShowDialog();
        }

        private void intaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmNewInternationallicense = new New_International_License_Application();
            frmNewInternationallicense.ShowDialog();
        }

        private void internationalLicenseApplicationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frminternationalLicenses = new List_International_License_Applications();
            frminternationalLicenses.ShowDialog();
        }

        private void renewDrivingLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmRenewLicense = new Renew_Local_Driving_License();
            frmRenewLicense.ShowDialog();
        }

        private void replaccementForLostOrDamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmReplaceForLoseOrDamaged = new Replacement_For_Damaged_or_Lost_License();
            frmReplaceForLoseOrDamaged.ShowDialog();
        }
        private void detainLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmDetainLicense = new Detain_License();
            frmDetainLicense.ShowDialog();
        }

        private void releaseDetainedLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmReleseLicense = new Release_Detained_License();
            frmReleseLicense.ShowDialog();
        }

        private void manageDetaindLicensesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmManageDetainedLicenses = new List_Detained_Licenses();
            frmManageDetainedLicenses.ShowDialog();
        }

        private void retakeTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmRetaketest = new LocalDrivingLicenseApplications();
            frmRetaketest.ShowDialog();
        }

        private void releaseDetainedDrivingLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmReleseLicense = new Release_Detained_License();
            frmReleseLicense.ShowDialog();
        }
    }
}
