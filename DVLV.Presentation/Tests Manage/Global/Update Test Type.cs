using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DVLV.BLL;
namespace DVLV.UI
{
    public partial class Update_Test_Type : Form
    {
        private int ID { get; set; } = -1;
        public Update_Test_Type(int id)
        {
            InitializeComponent();
            this.ID = id;
            LoudData();
        }
        private void LoudData()
        {
            DataTable TestInfo = BLL.TestTypesBLL.GetType(ID);
            if (TestInfo.Rows.Count > 0)
            {
                DataRow Testrow = TestInfo.Rows[0];
                lbl_ID.Text = Testrow["TestTypeID"].ToString();
                txt_Test_Title.Text = Testrow["TestTypeTitle"].ToString();
                txt_Describtion.Text = Testrow["TestTypeDescription"].ToString();
                txt_Test_Fees.Text = Convert.ToInt16(Testrow["TestTypeFees"]).ToString();
            }
        }
        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txt_Test_Title.Text) || String.IsNullOrEmpty(txt_Describtion.Text) || String.IsNullOrEmpty(txt_Test_Fees.Text))
            {
                MessageBox.Show("You must fill all  record to save .", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int maxFees = 1000; // يمكنك تعديل هذا الرقم ليناسب الحد الأقصى الذي تريده
            if (int.TryParse(txt_Test_Fees.Text, out int fees) && fees > maxFees)
            {
                MessageBox.Show($"The maximum allowed value for Fees is {maxFees}.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (BLL.TestTypesBLL.UpdateType(ID, txt_Test_Title.Text, txt_Describtion.Text, Convert.ToInt32(txt_Test_Fees.Text)))
            {
                if (MessageBox.Show(" Test type updated successfully .", "success", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                    this.Close();
            }
            else
            {
                MessageBox.Show("Error Happened while saving ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void txt_Test_Fees_TextChanged(object sender, EventArgs e)
        {
            ValidationHelper.PhoneNumberValidation(txt_Test_Fees, errorProvider1);

            int maxFees = 1000; // نفس الحد الأقصى
            if (int.TryParse(txt_Test_Fees.Text, out int fees) && fees > maxFees)
            {
                errorProvider1.SetError(txt_Test_Fees, $"Fees cannot exceed {maxFees}");
            }
        }
    }
}
