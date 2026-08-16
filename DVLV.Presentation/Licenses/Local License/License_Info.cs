using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DVLV.UI.Licenses
{
    public partial class License_Info : Form
    {
        int ApplicationID = -1;
        public License_Info(int ApplicationID)
        {
            this.ApplicationID = ApplicationID;
            InitializeComponent();
            ctr_Driver_License_Info1.LoudControlData(this.ApplicationID);
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }



    }
}
