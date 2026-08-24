using DVLV.BLL;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Windows.Forms;

namespace DVLV.UI
{
    public partial class New_Local_Driving_License_Application : Form
    {


        private int PersonID { set; get; } = -1;
        private int ApplicationID { set; get; } = -1;

        private ApplicationsBLL CurrentApplication;

        private int localDrivingLicenseApplicationID = -1;
        public enum enMood { New = 0, Update = 1 };
        enMood Mood = enMood.New;
        public New_Local_Driving_License_Application()
        {
            InitializeComponent();
            Mood = enMood.New;
            LoadData();
        }

        // Constructor for Update Application
        public New_Local_Driving_License_Application(int LocalDrivingLicenseAppID)
        {
            InitializeComponent();
            this.localDrivingLicenseApplicationID = LocalDrivingLicenseAppID;
            this.ApplicationID = BLL.LocalDrivingLicenseApplicationBLL.GetApplicationID(LocalDrivingLicenseAppID);
            this.PersonID = PeopleBLL.GetPersonIDByApplicationID(ApplicationID);
            this.Mood = enMood.Update;
            LoadData();
        }




        private void person_Finder_Filter1_PersonFound(object sender, int e)
        {
            PersonID = e;
            ctr_Person_Info1.UpdatePersonInfo(PersonID);
            btn_Next.Enabled = true;
            btn_Save.Enabled = true;
        }
        private void tabPage2_MouseClick(object sender, MouseEventArgs e)
        {
            if (PersonID == -1)
            {
                tabControl1.SelectedIndex = 0;
                MessageBox.Show("You Cant Enter This tap before Select A Person ");
            }
            else
            {
                //nothing ...
            }
        }
        private void btn_Next_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
        }
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (PersonID == -1 && tabControl1.SelectedIndex != 0)
            {
                MessageBox.Show("You cannot enter this tab before selecting a person.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tabControl1.SelectedIndex = 0; // إعادة المستخدم إلى التبويب الأول
            }
            else
            {
                //nothing ...
            }
        }

        // Constructor for New Application


        private void LoadData()
        {
            switch (Mood)
            {
                case enMood.New:
                    {
                        cbx_License_Classes.DropDownStyle = ComboBoxStyle.DropDownList;
                        cbx_License_Classes.SelectedIndex = 2;

                        int ApplicationTypeId = 1; // 1  For New local driving license service 
                        int fees = 0;
                        string Title = "";
                        ApplicationTypesBLL.GetType(ref ApplicationTypeId, ref Title, ref fees);
                        lbl_Application_Fees.Text = fees.ToString();
                        lbl_Application_Date.Text = DateTime.Now.ToString("dd/MM/yyyy");
                        lbl_Created_By.Text = CurrentUserBLL.UserName.ToString();

                        break;
                    }
                case enMood.Update:
                    {
                        //LoudUpdateForm();

                        cbx_License_Classes.DropDownStyle = ComboBoxStyle.DropDownList;
                        cbx_License_Classes.SelectedIndex = BLL.LocalDrivingLicenseApplicationBLL.GetLicanseClassIDByApplicationID(ApplicationID) - 1;

                        int ApplicationTypeId = 1; // 1  For New local driving license service 
                        string Title = "";
                        int fees = 0;
                        ApplicationTypesBLL.GetType(ref ApplicationTypeId, ref Title, ref fees);
                        lbl_Application_Fees.Text = fees.ToString();
                        lbl_Application_Date.Text = DateTime.Now.ToString("dd/MM/yyyy");
                        lbl_Created_By.Text = CurrentUserBLL.UserName.ToString();
                        lbl_Header.Text = "Update Local Driving License Application";
                        lbl_Application_ID.Text = ApplicationID.ToString();
                        ctr_Person_Info1.UpdatePersonInfo(PersonID);
                        person_Finder_Filter1.Enabled = false;
                        btn_Save.Enabled = true;
                        btn_Next.Enabled = true;
                        break;
                    }
            }
        }

        public ApplicationsBLL AddNewDrivingLicenseApplicationDataFillar()
        {
            ApplicationsBLL application = new ApplicationsBLL(PersonID);
            application.TypeID = 1;
            application.setPaydFees(1);
            application.Date = DateTime.Now;
            application.StutusID = 1;
            application.LastStutusDate = DateTime.Now;
            application.CreatedByUser = CurrentUserBLL.UserID;
            return application;

        }

        private bool Add()
        {
            try
            {
                // Validate input (example validation, adjust as needed)
                if (PersonID == -1)
                {
                    MessageBox.Show("Please select a person before adding a new application.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                if (cbx_License_Classes.SelectedIndex == -1)
                {
                    MessageBox.Show("Please select a license class.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                if (!LocalDrivingLicenseApplicationBLL.IsPersonUnderAllowedAge(PersonID, cbx_License_Classes.SelectedIndex + 1))
                {
                    MessageBox.Show("  The person is under the age limit for this License Class.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                if (!LocalDrivingLicenseApplicationBLL.IsPersonCanApplicateNewLicense(PersonID, cbx_License_Classes.SelectedIndex + 1))
                {
                    MessageBox.Show("The person have the same application of the same license class .", "Error ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                //here the adding step if all ifs are true 
                CurrentApplication = AddNewDrivingLicenseApplicationDataFillar();

                var result = LocalDrivingLicenseApplicationBLL.AddNewDrivingLicenseApplication(CurrentApplication, cbx_License_Classes.SelectedIndex + 1);
                CurrentApplication.ApplicationID = result.ApplicationID;
                localDrivingLicenseApplicationID = result.LocalDrivingLicenseApplicationID;
                ApplicationID = result.ApplicationID;
                if (localDrivingLicenseApplicationID != -1 && CurrentApplication.ApplicationID != -1)
                {
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while adding the application: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private bool Update()
        {
            if (ApplicationID == -1)
            {
                MessageBox.Show("Error While Updatting. ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (localDrivingLicenseApplicationID == -1)
            {
                localDrivingLicenseApplicationID = LocalDrivingLicenseApplicationBLL.FindLocalDrivingLicenseID(ApplicationID);
            }
            if (!LocalDrivingLicenseApplicationBLL.IsPersonUnderAllowedAge(PersonID, cbx_License_Classes.SelectedIndex + 1))
            {
                MessageBox.Show("  The person is under the age limit for this License Class.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return LocalDrivingLicenseApplicationBLL.Update(localDrivingLicenseApplicationID, cbx_License_Classes.SelectedIndex + 1);
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            try
            {
                bool result = Mood == enMood.New ? Add() : Update();

                if (result)
                {
                    MessageBox.Show("Operation successful.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //Mood = enMood.Update;
                    //LoadData();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error occur while Saveing", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
