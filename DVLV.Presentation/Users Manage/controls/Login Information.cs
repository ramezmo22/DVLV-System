using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DVLV.BLL;
using DVLV.DAL;
namespace DVLV.UI
{
    public partial class Login_Information : UserControl
    {
        private int UserID { set; get; } = -1;
        public Login_Information()
        {
            InitializeComponent();
            this.UserID = -1;
        }
        public Login_Information(int UserID)
        {
            this.UserID = UserID;
            InitializeComponent();
            CheckID();

        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }


        public void CheckID()
        {
            if (this.UserID != -1)
            {
                if (UserBLL.IsUserExists(this.UserID))//Check Existance <--
                {
                    //ID and USernaem and Activation
                     UserDataTransferObject data = UserBLL.GetUsersDataByUserID(this.UserID);
                     if(data!=null)
                    {
                        lbl_UserID.Text = data.UserID.ToString();
                        lbl_Username.Text = data.UserName.ToString();
                        lbl_IsActive.Text = data.IsActive == true ? "Yes" : "No";

                    }


                }
            }
            else
            {
                return;
            }
        }

        public void SetUserID(int userID)
        {
            this.UserID = userID;
            CheckID();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
