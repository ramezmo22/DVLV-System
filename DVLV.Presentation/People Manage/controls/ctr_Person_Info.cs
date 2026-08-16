using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DVLV.BLL;
using DVLV.UI.Properties;
using Microsoft.IdentityModel.Tokens;
namespace DVLV.UI
{
    public partial class ctr_Person_Info : UserControl
    {
        private int _PersonID = -1;
        public ctr_Person_Info()
        {
            InitializeComponent();

            // Skip loading data if in design mode
            if (DesignMode)
                return;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmAddNewPerson EditPerson = new frmAddNewPerson( _PersonID);
            EditPerson.ShowDialog();
            LoadData();
        }

        public void UpdatePersonInfo(int personID)
        {
            _PersonID = personID;
            if (PeopleBLL.IsPersonExists(_PersonID))
            {
                LoadData();
            }
            else
            {
                MessageBox.Show("Person not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
               // this.FindForm()?.Close();
            }
        }
        private void LoadData()
        {
            {
                PeopleBLL Person = PeopleBLL.FindPerson(_PersonID);
                if (Person != null)
                {
                    lbl_PersonID.Text = Person.PersonID.ToString();

                    if (Person.SecondName.IsNullOrEmpty() || Person.ThirdName.IsNullOrEmpty())
                    {
                        Person.SecondName = "";
                        Person.ThirdName = "";
                    }
                    lbl_Name.Text = Person.FirstName + " " + Person.SecondName + " " + Person.ThirdName + " " + Person.LastName;

                    label8.Text = Person.NationalNo;

                    if (Person.Gendor == 1)
                    {
                        label9.Text = "Female";
                    }
                    else
                    {
                        label9.Text = "Male";
                    }

                    label10.Text = Person.Email;

                    label11.Text = Person.Address;

                    label15.Text = Person.DateOfBirth.ToShortDateString();

                    label16.Text = Person.Phone;

                    label17.Text = clsCountriesBLL.GetCountryById(Person.CountryID);


                    if (Person.ImagePath != null)
                        pt_Person_Image.ImageLocation = Person.ImagePath;
                    else
                        pt_Person_Image.Image = Resources.Male_512;
                }
            }
        }

        
    }
}
