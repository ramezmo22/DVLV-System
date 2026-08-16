using System;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Text.RegularExpressions;
using DVLV.UI;

namespace DVLV.Presentation
{
    public partial class ManagePeople : Form
    {

        public ManagePeople()
        {
            InitializeComponent();
        }
        private void ManagePeople_Load(object sender, EventArgs e)
        {
            crt_People_Grid_View1.GridViewDataLoad();
            txt_NumOfRecords.Text = "Number Of Records " + crt_People_Grid_View1.GetNumberOfRecords();
            comboBox1.SelectedIndex = 0;//Defult
        }

        public void GridFiltering()
        {
            switch (comboBox1.SelectedIndex)
            {
                case 1: // PersonID = int mask (only numbers)
                    MKTB_FillterationInput.Visible = true;
                    MKTB_FillterationInput.Mask = "0000000000"; // Adjust length as needed
                    MKTB_FillterationInput.ResetText();
                    break;
                case 2: // NationalNo = accept int and char
                    MKTB_FillterationInput.Visible = true;
                    MKTB_FillterationInput.Mask = ""; // No mask, use Regex in validation
                    MKTB_FillterationInput.ResetText();
                    break;
                case 3: // FirstName = chars only
                case 4: // SecondName = chars only
                case 5: // ThirdName = chars only
                case 6: // LastName = chars only
                case 7: // Nationality = chars only
                case 8: // Gendor = chars only
                    MKTB_FillterationInput.Visible = true;
                    MKTB_FillterationInput.Mask = ""; // No mask, use Regex in validation
                    MKTB_FillterationInput.ResetText();
                    break;
                case 9: // Phone = string (you can use a phone mask)
                    MKTB_FillterationInput.Visible = true;
                    MKTB_FillterationInput.Mask = "000000000000"; // Example phone mask
                    MKTB_FillterationInput.ResetText();
                    break;
                case 10: // Email = string (no mask, use Regex in validation)
                    MKTB_FillterationInput.Visible = true;
                    MKTB_FillterationInput.Mask = "";
                    MKTB_FillterationInput.ResetText();
                    break;
                default: // None = no mask
                    MKTB_FillterationInput.Visible = false;
                    MKTB_FillterationInput.Mask = "";
                    MKTB_FillterationInput.ResetText();
                    break;
            }
        }
        public void FilterOnTextChange()
        {

            int FilterMood = comboBox1.SelectedIndex;
            //vaildation 

            crt_People_Grid_View1.GridViewDataLoad(FilterMood, MKTB_FillterationInput.Text);
            txt_NumOfRecords.Text = "Number Of Records " + crt_People_Grid_View1.GetNumberOfRecords();
        }




        private void crt_People_Grid_View1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridFiltering();
        }

        private void MKTB_FillterationInput_TextChanged(object sender, EventArgs e)
        {
            FilterOnTextChange();
        }

        private void txt_NumOfRecords_Click(object sender, EventArgs e)
        {

        }

        private void btn_CloseForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_AddPerson_Click(object sender, EventArgs e)
        {
            Form AddPersonF = new frmAddNewPerson();
            AddPersonF.ShowDialog();
            RefreshData();
        }

        public void RefreshData()
        {
            // أعد تحميل البيانات أو قم بتحديث العناصر
            crt_People_Grid_View1.GridViewDataLoad();
        }
    }
}