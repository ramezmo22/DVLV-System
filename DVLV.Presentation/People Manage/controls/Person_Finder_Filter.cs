using DVLV.BLL;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
namespace DVLV.UI
{
    public partial class Person_Finder_Filter : UserControl
    {
        private int FilterMood { set; get; }
        public int SelectedPersonID { get; private set; } // Property to store the selected Person ID

        public event EventHandler<int> PersonFound; // Event to notify when a person is found

        public Person_Finder_Filter()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;//Defult
            FilterMood = comboBox1.SelectedIndex;
            textBox1.KeyDown += TextBox1_KeyDown;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.SelectedIndex = 1;
        }

        private void TextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // لمنع صوت الـ Ding المزعج
                button1_Click(sender, EventArgs.Empty); // استدعاء دالة البحث
            }
        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            //ValidationHelper.ValidateWhiteSpace(textBox1, error1);
            ValidationHelper.ValidateNoSpecialCharacters(textBox1, error1);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterMood = comboBox1.SelectedIndex;
            textBox1.Text = "";
        }

        private void pic_Find_Person_Click(object sender, EventArgs e)
        {

        }

        private void Add_New_Person_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrWhiteSpace(textBox1.Text))
            {
                error1.SetError(textBox1, "You must enter the required information before search.");
                textBox1.Focus();
                return;
            }
            // Get the Person ID based on the filter
            int personID = PeopleBLL.PersonSelection(FilterMood, textBox1.Text.Trim());

            if (personID != -1)
            {
                SelectedPersonID = personID; // Store the found Person ID

                // Raise the PersonFound event
                PersonFound?.Invoke(this, personID);
            }
            else
            {
                MessageBox.Show("Person not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmAddNewPerson frmNewPersonAdd = new frmAddNewPerson();
            frmNewPersonAdd.ShowDialog();
        }
    }
}
