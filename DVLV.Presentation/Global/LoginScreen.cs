using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DVLV.BLL;
using DVLV.Presentation;
using System.IO;
namespace DVLV.UI
{
    public partial class LoginScreen : Form
    {
        public LoginScreen()
        {
            InitializeComponent();
            
            LoudUsernamePassword();
        }
        private void LoudUsernamePassword()
        {
            if (File.Exists("rememberme.txt"))
            {
                string[] Lines = File.ReadAllLines("rememberme.txt");
                txt_UserName.Text = Lines[0].Trim();
                txt_Password.Text = Lines[1].Trim();
            }
        }
        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btn_Login_Click(object sender, EventArgs e)
        {
            string UserName = txt_UserName.Text.Trim();
            string Password = txt_Password.Text.Trim();
            UserBLL user = new UserBLL();
            user.UserName = UserName;
            user.Password = Password;
            if (user.CheckUserNamePassword())
            {
                if (user.IsUserActive())
                {
                    int UserID = UserBLL.GetUserID(UserName, Password);
                    CurrentUserBLL.SetUser(UserID, user.UserName);
                    this.Hide();
                    Form mainScreen = new Main();
                    mainScreen.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Your account is not active. Please contact administrator.");
                }
            }
            else
            {
                MessageBox.Show("Invalid username or password. Please try again.");
            }
        }

        private void cb_RememberMe_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_RememberMe.Checked)
            {
                if(string.IsNullOrWhiteSpace(txt_UserName.Text) || string.IsNullOrWhiteSpace(txt_Password.Text))//To check if credentials are not provided
                {
                    MessageBox.Show("Please enter both username and password to remember.");
                    cb_RememberMe.Checked = false; // Uncheck the box if credentials are not provided
                    return;
                }
                else
                File.WriteAllText("rememberme.txt", $"{txt_UserName.Text.Trim()}\n{txt_Password.Text.Trim()}");
            }
            if(!cb_RememberMe.Checked)
            {
                if(File.Exists("rememberme.txt"))
                {
                    File.Delete("rememberme.txt");
                }
            }
        }
    }
}
