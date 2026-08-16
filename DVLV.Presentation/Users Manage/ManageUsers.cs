using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DVLV.UI
{
    public partial class ManageUsers : Form
    {
        public ManageUsers()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
            lbl_Records.Text = "# Records: " + ctr_Users_Grid_View1.NumberOfRecords();
        }

        private void btn_Add_User_Click(object sender, EventArgs e)
        {
            Form AddUser = new Add_New_User();
            AddUser.ShowDialog();
            UpdateData();
        }

        private void btn_Refesh_Click(object sender, EventArgs e)
        {
            UpdateData();
        }
        public void UpdateData()
        {
            ctr_Users_Grid_View1.Grid_Initialize();
            textBox1.Visible = false;
            textBox1.Text = "";
            comboBox2.SelectedIndex = 0;
            comboBox2.Visible = false;
            comboBox1.SelectedIndex = 0;
            lbl_Records.Text = "# Records: " + ctr_Users_Grid_View1.NumberOfRecords();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            switch (comboBox1.SelectedIndex)
            {
                case 0://none
                    {
                        ctr_Users_Grid_View1.Grid_Initialize();
                        textBox1.Visible = false;
                        textBox1.Text = "";
                        comboBox2.SelectedIndex = 0;
                        comboBox2.Visible = false;
                        return;

                    }
                case 1://userID
                    {
                        textBox1.Visible = true;
                        textBox1.Text = string.Empty;
                        textBox1.KeyPress += AllowNumbersOnly; // السماح بالأرقام فقط
                        comboBox2.Visible = false;
                        break;
                    }
                case 2://PersonID
                    {
                        textBox1.Visible = true;
                        textBox1.Text = string.Empty;
                        textBox1.KeyPress += AllowNumbersOnly; // السماح بالأرقام فقط
                        comboBox2.Visible = false;
                        break;

                    }
                case 3://FullName
                    {
                        textBox1.Visible = true;
                        textBox1.Text = string.Empty;
                        textBox1.KeyPress -= AllowNumbersOnly; // السماح بالنصوص فقط
                        comboBox2.Visible = false;
                        break;
                    }
                case 4://UserName
                    {
                        textBox1.Visible = true;
                        textBox1.Text = string.Empty;
                        textBox1.KeyPress -= AllowNumbersOnly; // السماح بالنصوص فقط
                        comboBox2.Visible = false;
                        break;

                    }

                case 5://Is Active
                    {
                        textBox1.Visible = false;
                        comboBox2.Visible = true;
                        comboBox2.Sorted = false; // تعطيل الترتيب الأبجدي
                        comboBox2.Items.Clear();
                        comboBox2.Items.AddRange(new string[] { "All", "Yes", "No" });
                        comboBox2.SelectedIndex = 0;
                        break;
                    }
                default: return;
            }
        }
        private void AllowNumbersOnly(object sender, KeyPressEventArgs e)
        {
            // السماح فقط بالأرقام
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            UpdateGridData(comboBox1.SelectedIndex);
        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateGridData(5);
        }
        private void UpdateGridData(int selection = 0)
        {
            switch (selection)
            {

                case 1://userID
                    {
                        ctr_Users_Grid_View1.UpdateGridData(1, textBox1.Text.Trim());

                        break;
                    }
                case 2://PersonID
                    {
                        ctr_Users_Grid_View1.UpdateGridData(2, textBox1.Text.Trim());

                        break;

                    }
                case 3://FullName
                    {
                        ctr_Users_Grid_View1.UpdateGridData(3, textBox1.Text.Trim());

                        break;
                    }
                case 4://UserName
                    {
                        ctr_Users_Grid_View1.UpdateGridData(4, textBox1.Text.Trim());

                        break;

                    }
                case 5:
                    {
                        if (comboBox2.SelectedIndex == 0)
                            ctr_Users_Grid_View1.UpdateGridData(5, "All");
                        if (comboBox2.SelectedIndex == 1)
                            ctr_Users_Grid_View1.UpdateGridData(5, "Yes");
                        if (comboBox2.SelectedIndex == 2)
                            ctr_Users_Grid_View1.UpdateGridData(5, "No");
                        break;
                    }


                default: return;
            }
        }

        private void ctr_Users_Grid_View1_Click(object sender, EventArgs e)
        {
            lbl_Records.Text = "# Records: " + ctr_Users_Grid_View1.NumberOfRecords();
        }
    }

}




