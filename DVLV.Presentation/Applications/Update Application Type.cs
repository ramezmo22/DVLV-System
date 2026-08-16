using DVLV.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;

namespace DVLV.UI
{
    public partial class Update_Application_Type : Form
    {
        private int _ApplicationType { set; get; }
        public Update_Application_Type(int ApplicationType)
        {
            this._ApplicationType= ApplicationType;
            InitializeComponent();
            LoudApplicationData();
        }
        private void LoudApplicationData()
        {
            int id = _ApplicationType;
            int fees = -1;
            string Title = "";
            ApplicationTypesBLL.GetType(ref id, ref Title, ref fees);
            if (id!=-1||fees!=-1||Title!="")
            {

                lbl_ID.Text = id.ToString();
                txt_Application_Title.Text = Title;
                txt_Application_Fees.Text = fees.ToString();
            }
            else
            {
                if (MessageBox.Show("No data found for the selected application type.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error) == DialogResult.OK)
                {
                    this.Close();
                }
            }
        }

        private void txt_Application_Fees_TextChanged(object sender, EventArgs e)
        {
            ValidationHelper.PhoneNumberValidation(txt_Application_Fees, errorProvider1);

        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txt_Application_Title.Text))
            {
                MessageBox.Show("The application type title is required!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (String.IsNullOrEmpty(txt_Application_Fees.Text))
            {
                MessageBox.Show("The application fees are required!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (int.TryParse(txt_Application_Fees.Text, out int fees))
            {
                if (ApplicationTypesBLL.UpdateApplicationType(_ApplicationType, txt_Application_Title.Text, fees))
                {
                    if(MessageBox.Show("Updated Sucsussfuly","info",MessageBoxButtons.OK)==DialogResult.OK)
                    {
                        this.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Invalid application fees. Please enter a valid number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

     
    }
}
