using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DVLV.UI
{
    public partial class PersonDetails : Form
    {
        public int _PersonID = -1;
        public PersonDetails(int PersonID)
        {
            _PersonID = PersonID;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
