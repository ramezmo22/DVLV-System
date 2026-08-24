using DVLV.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DVLV.UI.Detains
{
    public partial class ctr_detain_info : UserControl
    {
        private int _LicesnesID = -1;
        public ctr_detain_info()
        {
            InitializeComponent();
            this.lbl_Detain_Date.Text = DateTime.Now.ToString("dd/MM/yyyy");
            this.lbl_Created_By.Text = BLL.CurrentUserBLL.UserName;
        }
        public void Load_Data(int LicesneID)
        {
            this._LicesnesID = LicesneID;
            lbl_License_ID.Text = _LicesnesID.ToString();
        }
        public bool Detain_Save()
        {
            if (!string.IsNullOrEmpty(msk_Fine_Fees.Text) && Convert.ToInt16(msk_Fine_Fees.Text) > 0)
            {
                if (_LicesnesID != -1)
                {
                    //Save Detain and Load Data
                    int DetainID = (BLL.DetainedLicensesBLL.DetainLicense(_LicesnesID, DateTime.Now, Convert.ToInt16(msk_Fine_Fees.Text),
                    CurrentUserBLL.UserID, false));
                    if (DetainID > -1)
                    {
                        lbl_Detain_ID.Text = DetainID.ToString();
                        msk_Fine_Fees.Enabled = false;
                        return true;
                    }
                }
            }
            else
            {
                MessageBox.Show("Please Enter the Fees Amount .", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }
    }
}
