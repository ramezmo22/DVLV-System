using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DVLV.BLL;
using DVLV.DAL;
using Microsoft.IdentityModel.Tokens;
namespace DVLV.UI
{
    public partial class Add_New_User : Form
    {
        public int PersonID = -1;
        public bool Is_Stage_One_Done = false;
        public bool Is_Perrson_Selected = false;
        public  enum enMood { enAddNewUser=0,enUpdateUser=1 };
        enMood mood;
        public Add_New_User(int Personid=-1)
        {
            this.PersonID = Personid;
            InitializeComponent();
            ckb_IsActive.Checked = true;
            chackMood();
        }

        public void chackMood()
        {
            if(PersonID!=-1)
            {
                if (!CheckIfPersonIsNotAUser())
                {
                    mood = enMood.enUpdateUser;
                    person_Finder_Filter1.Enabled = false;
                    ctr_Person_Info1.UpdatePersonInfo(this.PersonID);
                    Is_Perrson_Selected = true;
                    Is_Stage_One_Done = true;
                    btn_Next.Enabled = true;
                    UserBLL User = UserBLL.FindUserByPersonID(this.PersonID);
                    lbl_UserID.Text = User.UserID.ToString();
                    txt_UserName.Text = User.UserName;
                    txt_Password.Text = User.Password;
                    txt_Password_Conformation.Text = User.Password;
                    ckb_IsActive.Checked = User.IsActive;
                    lbl_heder.Text = "Update User";
                }
                else
                {
                    mood = enMood.enAddNewUser;
                }
            }
        }










        private void person_Finder_Filter1_PersonFound(object sender, int e)
        {
            Is_Perrson_Selected = true;
            // Ensure ctr_Person_Info1 is properly initialized or updated
        
            ctr_Person_Info1.UpdatePersonInfo(e); // Update the existing control
            PersonID = e;
            

            if (CheckIfPersonIsNotAUser())
            {
                Is_Stage_One_Done = true;
                btn_Next.Enabled = true;
            }
          
        }
        private bool CheckIfPersonIsNotAUser()
        {
            if (UserBLL.ISPersonAUser(PersonID))
                return false;
            else return true;
        }
        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btn_Next_Click(object sender, EventArgs e)
        {
            if (mood == enMood.enUpdateUser)
            {
                // Proceed to the login info tab
                //tab_New_User.SelectTab(1);
                return;
            }
            if (Is_Stage_One_Done)
            {
                tab_New_User.SelectTab(1);
            }
            else if (Is_Perrson_Selected && !Is_Stage_One_Done)
            {
                MessageBox.Show("Selected person already is a User, choose another one.", "Select Another Person", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tab_New_User.SelectTab(0);
            }
            else if (!Is_Perrson_Selected)
            {
                MessageBox.Show("You must select a person to continue.", "Select a Person", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tab_New_User.SelectTab(0);
            }
        }
        private bool CheckStageTow()
        {
            if (string.IsNullOrEmpty(txt_UserName.Text) || string.IsNullOrEmpty(txt_Password.Text) || string.IsNullOrEmpty(txt_Password_Conformation.Text))
            {
                MessageBox.Show("You must enter all records.", "Incomplete Form", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (txt_Password.Text != txt_Password_Conformation.Text)
            {
                MessageBox.Show("The password and password confirmation do not match.", "Password Mismatch", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void AddNewUser()
        {

            if (!Is_Stage_One_Done)
            {
                MessageBox.Show("You must complete stage one and the login page.", "Incomplete Setup", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!CheckStageTow())
            {
                return;
            }

            if (MessageBox.Show("Are you sure you want to save this new user?", "Confirm Save", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                try
                {
                    // Call the BLL (Business Logic Layer) to save the user

                    UserBLL UserData = new UserBLL();
                    UserData.PersonID = PersonID;
                    UserData.UserName = txt_UserName.Text;
                    UserData.Password = txt_Password.Text;
                    UserData.IsActive = ckb_IsActive.Checked;
                    if (UserData.Save() == true)
                    {

                        // Notify the user of success
                        MessageBox.Show("User saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Optionally, reset the form or close it
                        this.Close();
                    }
                }
                catch (Exception ex)
                {
                    // Handle any errors during the save operation
                    MessageBox.Show($"An error occurred while saving the user: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void UpdateUser()
        {

            if (!CheckStageTow())
            {
                return;
            }

            if (MessageBox.Show("Are you sure you want to Update this user?", "Confirm Update", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                try
                {
                    // Call the BLL (Business Logic Layer) to save the user

                    UserBLL UserData = UserBLL.FindUserByPersonID(this.PersonID);
                    UserData.Mode = UserBLL.enMode.Update;
                    UserData.UserName = txt_UserName.Text;
                    UserData.Password = txt_Password.Text;
                    UserData.IsActive = ckb_IsActive.Checked;
                    if (UserData.Save() == true)
                    {

                        // Notify the user of success
                        MessageBox.Show("User Updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Optionally, reset the form or close it
                        this.Close();
                    }
                }
                catch (Exception ex)
                {
                    // Handle any errors during the save operation
                    MessageBox.Show($"An error occurred while saving the user: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void btn_Save_Click(object sender, EventArgs e)
         {
           if(mood==enMood.enAddNewUser)
            {
                AddNewUser();
            }
           if(mood==enMood.enUpdateUser)
            {
                UpdateUser();
            }
        }
       
     

    }
}
