using System.Linq;
using System.Windows.Forms;

namespace DVLV.UI
{
    public static class ValidationHelper
    {
        public static void ValidateWhiteSpace(TextBox textBox, ErrorProvider errorProvider)
        {
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                errorProvider.SetError(textBox, "This field is Required !");
                //textBox.Focus();
            }
            else
            {
                errorProvider.SetError(textBox, "");
            }
        }

        public static void ValidateLettersOnly(TextBox textBox, ErrorProvider errorProvider)
        {
            foreach (char c in textBox.Text)
            {
                if (!char.IsLetter(c))
                {
                    errorProvider.SetError(textBox, "Only letters are allowed!");
                    //textBox.Focus();
                    textBox.Text = RemoveSelectedChar(textBox.Text, c);
                    return;
                }
            }
            errorProvider.SetError(textBox, "");
        }

        public static void ValidateNoSpecialCharacters(TextBox textBox, ErrorProvider errorProvider)
        {//Just letters and Numbers 
            foreach (char c in textBox.Text)
            {
                if (!char.IsLetterOrDigit(c))
                {
                    errorProvider.SetError(textBox, "Only letters and numbers are allowed!");
                    //textBox.Focus();
                    textBox.Text = RemoveSelectedChar(textBox.Text, c);
                    return;
                }
            }
            errorProvider.SetError(textBox, "");
        }

        public static void PhoneNumberValidation(TextBox textBox,ErrorProvider errorProvider)
        {
            foreach(char c in textBox.Text)
            {
                if(!char.IsDigit(c))
                {
                 
                    errorProvider.SetError(textBox, "You can just enter numbers !");
                    textBox.Focus();
                    textBox.Text = RemoveSelectedChar(textBox.Text, c);
                    
                   // return;
                }
                else
                {
                    errorProvider.SetError(textBox, "");
                }
            }
        }

        private static string RemoveSelectedChar(string s1, char c1)
        {
            return new string(s1.Where(ch => ch != c1).ToArray());
        }


    }
}
