using DVLV.BLL;
using DVLV.DAL;
using DVLV.UI.Properties;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.IO;
using System.Numerics;
using System.Text;
using System.Windows.Forms;
namespace DVLV.UI
{
    public partial class ctr_Person_Card : UserControl
    {
        private int _PersonID = -1;
        //Define Custom Event Handeller with Parameter
        public event Action<int> OnPersonSelected;
        //Create Method to Raise the Event
        protected virtual void PersonSelected(int PersonID)
        {
            OnPersonSelected?.Invoke(PersonID);
        }//Event
        public ctr_Person_Card()
        {
            InitializeComponent();
            //today - 18 years
            DateTime MaxDate = DateTime.Now.AddYears(-18);
            dtb_Data_Of_Bridth.MaxDate = MaxDate;
            dtb_Data_Of_Bridth.Value = MaxDate;


        }
        public void LoudData(int PersonID)
        {
            _PersonID = PersonID;

            if (PersonID != -1)
            {
                LoadPersonData(PersonID);
            }
            ///////////////////
        }
        private void ctr_Person_Card_Load(object sender, EventArgs e)
        {
            cbx_Countries.DataSource = clsCountriesBLL.GetAllCountries();
            cbx_Countries.DisplayMember = "CountryName";
            cbx_Countries.ValueMember = "CountryID";
            cbx_Countries.SelectedIndex = 89;
        }
        private void rdb_Female_CheckedChanged(object sender, EventArgs e)
        {
            pt_PersonImage.Image = null;
            pt_PersonImage.Image = Resources.Female_512;
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pt_PersonImage.Image = rdb_Female.Checked ? Resources.Female_512 : Resources.Male_512;
            lnk_Remove.Visible = false;
        }
        private void TextboxValidation(object sender, CancelEventArgs e)
        {
            ValidationHelper.ValidateWhiteSpace((TextBox)sender, ep_EmptyError);
        }
        private void TextChangedValidation(object sender, EventArgs e)
        {
            ValidationHelper.ValidateLettersOnly((TextBox)sender, ep_EmptyError);
        }
        private void TextChangedValidationWithNumbers(object sender, EventArgs e)
        {
            ValidationHelper.ValidateNoSpecialCharacters((TextBox)sender, ep_EmptyError);
        }
        private void textBox1_Validating(object sender, CancelEventArgs e)
        {


            string email1 = textBox1.Text.Trim();
            if (!(email1.Contains('@') && email1.Contains('.') && email1.IndexOf('@') < email1.LastIndexOf('.')))
            {
                e.Cancel = true;
                textBox1.Focus();
                ep_EmptyError.SetError(textBox1, "You must enter a valid email.");
            }
            else
            {
                e.Cancel = false;
                ep_EmptyError.SetError(textBox1, "");
            }

        }
        private void rdb_Male_CheckedChanged(object sender, EventArgs e)
        {
            pt_PersonImage.Image = null;
            pt_PersonImage.Image = Resources.Male_512;
        }
        private void JustNumberValidation(object sender, CancelEventArgs e)
        {
            ValidationHelper.PhoneNumberValidation((TextBox)sender, ep_EmptyError);
        }
        private string _ImageUrl = "";
        private void lnk_Set_Image_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            openFileDialog1.InitialDirectory = @"C:\";
            openFileDialog1.Title = "Select Image";
            openFileDialog1.DefaultExt = "png";
            openFileDialog1.Filter = "All Images|*.png;*.jpg;*.jpeg;*.bmp;*.gif;*.tiff;*.ico;*.webp|PNG files (*.png)|*.png|JPG files (*.jpg)|*.jpg|JPEG files (*.jpeg)|*.jpeg|BMP files (*.bmp)|*.bmp|GIF files (*.gif)|*.gif|TIFF files (*.tiff)|*.tiff|ICO files (*.ico)|*.ico|WebP files (*.webp)|*.webp";
            openFileDialog1.FilterIndex = 1;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pt_PersonImage.Load(openFileDialog1.FileName);

            }
            lnk_Remove.Visible = true;
        }
        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.FindForm().Close();//to close the Father Form 
        }
        public bool CheckIfAllComplete()
        {
            var requiredFields = new Dictionary<string, TextBox>
            {
                { "First Name", txt_FirstName },
                { "Second Name", txt_SecondName },
                { "Last Name", txt_LastName },
                { "National Number", txt_National_Number },
                { "Address", textBox2 },
                { "Phone", txt_Phone }
            };

            var missingFields = new List<string>();

            foreach (var field in requiredFields)
            {
                if (string.IsNullOrWhiteSpace(field.Value.Text.Trim()))
                {
                    missingFields.Add(field.Key);
                }
            }

            if (missingFields.Count > 0)
            {
                MessageBox.Show(
                    "Please fill in the following fields:\n- " + string.Join("\n- ", missingFields),
                    "Missing Data",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return false;
            }
            return true;
        }
        public bool GetPersonData(ref PeopleBLL PersonData)
        {

            // First Name
            PersonData.FirstName = string.IsNullOrWhiteSpace(txt_FirstName.Text.Trim()) ? "" : txt_FirstName.Text.Trim();

            // Second Name
            PersonData.SecondName = string.IsNullOrWhiteSpace(txt_SecondName.Text.Trim()) ? "" : txt_SecondName.Text.Trim();

            // Third Name
            PersonData.ThirdName = string.IsNullOrWhiteSpace(txt_ThirdName.Text.Trim()) ? "" : txt_ThirdName.Text.Trim();

            // Last Name
            PersonData.LastName = string.IsNullOrWhiteSpace(txt_LastName.Text.Trim()) ? "" : txt_LastName.Text.Trim();

            // National Number
            PersonData.NationalNo = string.IsNullOrWhiteSpace(txt_National_Number.Text.Trim()) ? "" : txt_National_Number.Text.Trim();

            // Address
            PersonData.Address = string.IsNullOrWhiteSpace(textBox2.Text.Trim()) ? "" : textBox2.Text.Trim();

            // Phone
            PersonData.Phone = string.IsNullOrWhiteSpace(txt_Phone.Text.Trim()) ? "" : txt_Phone.Text.Trim();

            // Email
            PersonData.Email = string.IsNullOrWhiteSpace(textBox1.Text.Trim()) ? "" : textBox1.Text.Trim();



            PersonData.DateOfBirth = dtb_Data_Of_Bridth.Value;


            if (!rdb_Female.Checked && !rdb_Male.Checked)
            {
                MessageBox.Show("You Must Enter Gender !", "Allert", MessageBoxButtons.OK);
                return false;
            }
            PersonData.Gendor = (short)(rdb_Male.Checked ? 0 : 1);
            // Country ID - (you will do this)
            PersonData.CountryID = Convert.ToInt32(cbx_Countries.SelectedValue);





            string destinationFolder = @"C:\DVLV - PeopleImages\";
            // التحقق من وجود المجلد وإنشاؤه إذا لم يكن موجودًا
            if (!Directory.Exists(destinationFolder))
            {
                Directory.CreateDirectory(destinationFolder);
            }
            // التحقق من وجود صورة جديدة في ImageLocation
            if (!string.IsNullOrWhiteSpace(pt_PersonImage.ImageLocation))
            {
                // إنشاء اسم ملف جديد باستخدام Guid
                string fileName = Guid.NewGuid().ToString() + Path.GetExtension(pt_PersonImage.ImageLocation);
                string destinationPath = Path.Combine(destinationFolder, fileName);

                try
                {
                    // التحقق من وجود ملف الصورة المصدر قبل النسخ
                    if (!File.Exists(pt_PersonImage.ImageLocation))
                    {
                        MessageBox.Show("The selected image file does not exist or has been moved.", "Image Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        _ImageUrl = "";
                    }
                    else
                    {
                        // نسخ الصورة الجديدة إلى المسار الجديد
                        File.Copy(pt_PersonImage.ImageLocation, destinationPath, true);

                        // التحقق من وجود صورة قديمة في المجلد وحذفها إذا كانت موجودة
                        if (!string.IsNullOrWhiteSpace(_ImageUrl) && _ImageUrl.StartsWith(destinationFolder) && File.Exists(_ImageUrl))
                        {
                            try
                            {
                                File.Delete(_ImageUrl); // حذف الصورة القديمة
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show($"Error deleting previous image: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return false;
                            }
                        }

                        // تحديث مسار الصورة النهائي بعد نجاح النقل
                        _ImageUrl = destinationPath;
                    }
                }
                catch (Exception ex)
                {
                    // عرض رسالة خطأ إذا فشل النسخ
                    MessageBox.Show($"Error copying image: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            else
            {
                _ImageUrl = ""; // إذا لم تكن هناك صورة جديدة، تعيين المسار كفارغ
            }


            // تعيين مسار الصورة في الكائن
            PersonData.ImagePath = _ImageUrl;
            return true;
        }
        private void cbx_Countries_Validating(object sender, CancelEventArgs e)
        {
            DataTable CountriesTable = clsCountriesBLL.GetAllCountries();
            // تحقق من وجود الدولة في الجدول
            if (CountriesTable.Select($"CountryName = '{cbx_Countries.Text.Replace("'", "''")}'").Length == 0)//If the length of the rows that or extracted the selection equal zero so there's an error
            {
                e.Cancel = true;
                cbx_Countries.Focus();
                ep_EmptyError.SetError(cbx_Countries, "Please select a valid country from the list.");
            }
            else
            {
                ep_EmptyError.SetError(cbx_Countries, "");
            }
        }
        public void LoadPersonData(int PersonID)
        {
            PeopleBLL PersonData = PeopleBLL.FindPerson(PersonID);
            if (PersonData != null)
            {
                txt_FirstName.Text = PersonData.FirstName;
                txt_SecondName.Text = PersonData.SecondName;
                txt_ThirdName.Text = PersonData.ThirdName;
                txt_LastName.Text = PersonData.LastName;
                txt_National_Number.Text = PersonData.NationalNo;
                textBox2.Text = PersonData.Address;
                txt_Phone.Text = PersonData.Phone;
                textBox1.Text = PersonData.Email;
                dtb_Data_Of_Bridth.Value = PersonData.DateOfBirth;
                cbx_Countries.SelectedValue = PersonData.CountryID;
                if (PersonData.Gendor == 0)
                {
                    rdb_Male.Checked = true;
                }
                else rdb_Female.Checked = true;
                pt_PersonImage.ImageLocation = PersonData.ImagePath;


            }
        }
        private void btn_Save_Click(object sender, EventArgs e)
        {
            // التحقق من الحقول المطلوبة
            if (!CheckIfAllComplete())
                return;
            // إنشاء كائن لتخزين بيانات الشخص
            PeopleBLL personData = new PeopleBLL();
            // إذا كان الشخص موجودًا مسبقًا، قم بتحميل بياناته
            try
            {
                if (_PersonID > 0)
                {

                    personData.PersonID = _PersonID;
                    personData.Mode = PeopleBLL.enMode.Update;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error retrieving person ID: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!GetPersonData(ref personData))
                return;

            // حفظ البيانات
            if (personData.Save())
            {
                if (personData.Mode == PeopleBLL.enMode.Update)
                {
                    _PersonID = PeopleBLL.GetPersonIDByNationalNumber(personData.NationalNo);
                    MessageBox.Show("Person saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    PersonSelected(_PersonID);
                }


            }
            else
            {
                MessageBox.Show("Failed to save person data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}