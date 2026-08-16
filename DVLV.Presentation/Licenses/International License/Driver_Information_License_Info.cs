using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DVLV.UI.Licenses.International_License
{
    public partial class Driver_Information_License_Info : Form
    {
        public Driver_Information_License_Info(int InternationalLicenseID)
        {
            InitializeComponent();
            ctr_Driver_International_License_Info1.LoudData(InternationalLicenseID);
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
