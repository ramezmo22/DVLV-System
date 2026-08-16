using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DVLV.UI.Licenses
{
    public partial class License_History : Form
    {
        private int DriverID = -1;
        private int PersonID = -1;
        public License_History(int DriverID, int PersonID)
        {
            this.DriverID = DriverID;
            this.PersonID = PersonID;
            InitializeComponent();
            ctr_Person_Info1.UpdatePersonInfo(PersonID);
            ctr_Driver_Licenses1.LoudData(DriverID);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
