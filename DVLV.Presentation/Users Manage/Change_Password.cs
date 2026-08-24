using DVLV.BLL;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DVLV.UI
{
    public partial class Change_Password : Form
    {
        public int UserID = -1;
        public int PersonID = -1;
        private bool IsNewChecked = false;
        private bool IsOldChecked = false;

        public Change_Password()
        {
            InitializeComponent();
        }
        public Change_Password(int UserID, int PersonID)
        {
            this.UserID = UserID;
            this.PersonID = PersonID;
            InitializeComponent();
            // مرر القيم للـ Controls بعد InitializeComponent
            ctr_Person_Info4.UpdatePersonInfo(PersonID);
            login_Information1.SetUserID(UserID);
        }


        //StageOne : 
        private void txt_CurrentPassword_Validating(object sender, CancelEventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_CurrentPassword.Text))
            {
                if (CheckCurrent())
                {
                    IsOldChecked = true;
                    errorProvider1.SetError(txt_CurrentPassword, "");
                }
                else
                {
                    IsOldChecked = false;
                    errorProvider1.SetError(txt_CurrentPassword, "Password Invalid!");
                }
            }
            else
            {
                IsOldChecked = false;
                errorProvider1.SetError(txt_CurrentPassword, "Required field can't be empty");
            }
        }
        //Close

        //stage two :
        private void txt_Password_Conformation_Validating(object sender, CancelEventArgs e)
        {
            if (!(string.IsNullOrEmpty(txt_Password.Text) || string.IsNullOrEmpty(txt_Password_Conformation.Text)))
            {
                if (txt_Password.Text == txt_Password_Conformation.Text)
                {
                    IsNewChecked = true;
                    errorProvider1.SetError(txt_Password_Conformation, "");
                }
                else
                {
                    IsNewChecked = false;
                    errorProvider1.SetError(txt_Password_Conformation, "The confirmed password should match the above one");
                }
            }
            else
            {
                IsNewChecked = false;
                errorProvider1.SetError(txt_Password_Conformation, "This field cannot be empty");
            }
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (!IsOldChecked)
            {
                MessageBox.Show("Please verify your current password first.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!IsNewChecked)
            {
                MessageBox.Show("Please enter matching new passwords.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                UserBLL user = UserBLL.FindUser(UserID);
                user.UserID = this.UserID;
                user.Password = txt_Password_Conformation.Text;
                if (user.Save())
                {
                    if (MessageBox.Show("Password changed Successfully  ", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                    {
                        this.Close();
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("P.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }


                // TODO: Implement UpdateUserPassword in UserBLL or use existing update method
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




        public string GetCurrentPassword()
        {
            return UserBLL.GetUsersDataByUserID(UserID).Password;//finalone
        }
        public bool CheckCurrent()
        {
            string Current = GetCurrentPassword();
            return txt_CurrentPassword.Text == Current;

        }
        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
