using DVLV.BLL;
using DVLV.Presentation;
using Microsoft.Win32;
using System;
using System.Windows.Forms;

namespace DVLV.UI
{
    public partial class LoginScreen : Form
    {
        private const string RegistryPath = @"HKEY_CURRENT_USER\Software\DVLD";

        public LoginScreen()
        {
            InitializeComponent();
            LoadUsernamePassword();
        }

        private void LoadUsernamePassword()
        {
            try
            {
                string isChecked = Registry.GetValue(RegistryPath, "Checked", "false") as string;

                if (isChecked == "true")
                {
                    cb_RememberMe.Checked = true;
                    txt_UserName.Text = Registry.GetValue(RegistryPath, "Username", "") as string;
                    txt_Password.Text = Registry.GetValue(RegistryPath, "Password", "") as string;
                }
                else
                {
                    cb_RememberMe.Checked = false;
                }
            }
            catch (Exception ex)
            { 
            }
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            string userName = txt_UserName.Text.Trim();
            string password = txt_Password.Text.Trim();

            UserBLL user = new UserBLL
            {
                UserName = userName,
                Password = password
            };

            if (user.CheckUserNamePassword())
            {
                if (user.IsUserActive())
                {
                    int userID = UserBLL.GetUserID(userName, password);

                    SaveUserNamePasswordInWinRegistry(userName, password);
                    CurrentUserBLL.SetUser(userID, user.UserName);

                    this.Hide();
                    using (Form mainScreen = new Main())
                    {
                        mainScreen.ShowDialog();
                    }
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Your account is not active. Please contact administrator.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Invalid username or password. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SaveUserNamePasswordInWinRegistry(string userName, string password)
        {
            try
            {
                if (cb_RememberMe.Checked)
                {
                    Registry.SetValue(RegistryPath, "Username", userName, RegistryValueKind.String);
                    Registry.SetValue(RegistryPath, "Password", password, RegistryValueKind.String);
                    Registry.SetValue(RegistryPath, "Checked", "true", RegistryValueKind.String);
                }
                else
                {
                    using (RegistryKey baseKey = Registry.CurrentUser.OpenSubKey(@"Software\DVLD", true))
                    {
                        if (baseKey != null)
                        {
                            baseKey.DeleteValue("Username", false);
                            baseKey.DeleteValue("Password", false);
                            baseKey.SetValue("Checked", "false", RegistryValueKind.String);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not save login preferences: " + ex.Message, "Registry Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}