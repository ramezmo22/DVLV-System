using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DVLV.UI
{
    public partial class UserInfo : Form
    {
        public UserInfo()
        {
            InitializeComponent();
        }
        int UserID = -1;
        int PersonID = -1;
        public UserInfo(int UserID, int PersonID)
        {
            InitializeComponent();
            this.UserID = UserID;
            this.PersonID = PersonID;
            ctr_Person_Info1.UpdatePersonInfo(PersonID);
            login_Information1.SetUserID(UserID);
        }


        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
