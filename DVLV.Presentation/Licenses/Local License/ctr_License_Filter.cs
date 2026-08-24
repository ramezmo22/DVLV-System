using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DVLV.UI.Licenses
{
    public partial class ctr_License_Filter : UserControl
    {
        //Difine Custom Event
        public event Action<int> OnLicenseSelected;
        //Create a Protected method to raise the event with parameter
        protected virtual void LicenseSelected(int LicenseID)
        {
            Action<int> handeller = OnLicenseSelected;
            if (handeller != null)
            {
                handeller(LicenseID);
            }
        }




        int DriverID = -1;
        int LicenseID = -1;
        public ctr_License_Filter()
        {
            InitializeComponent();
        }
        public void LoadLicenseID(int LicenseID)
        {
            this.LicenseID = LicenseID;
            txt_License_Filter.Text = LicenseID.ToString();
            Searche();
        }
        private void txt_License_Filter_TextChanged(object sender, EventArgs e)
        {
            ValidationHelper.PhoneNumberValidation(txt_License_Filter, errorProvider);
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            Searche();
        }
        public void Searche()
        {
            if (!string.IsNullOrEmpty(txt_License_Filter.Text))
            {
                int LicenseID_To_Search = Convert.ToInt32(txt_License_Filter.Text.Trim());
                DriverID = BLL.DriverBLL.GetDriverIDByLicenseID(LicenseID_To_Search);
                if (DriverID != -1)
                {
                    this.LicenseID = LicenseID_To_Search;
                    if (OnLicenseSelected != null)
                    {
                        OnLicenseSelected(this.LicenseID);
                    }
                }
                else
                {
                    MessageBox.Show("The License Didn`t found .", "Didn`t Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }


        }
    }
}
