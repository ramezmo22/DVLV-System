using DVLV.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
namespace DVLV.UI.controlls
{
    public partial class ctr_Application_basic_Info : UserControl
    {
        public ctr_Application_basic_Info()
        {
            InitializeComponent();
        }

        public int ApplicationID = -1;

        public void loudData(int ApplicationID)
        {
            this.ApplicationID = ApplicationID;
            BLL.ApplicationsBLL Application = BLL.ApplicationsBLL.Find(ApplicationID);
            lbl_ID.Text = Application.ApplicationID.ToString();
            lbl_Applicant.Text = ApplicationID.ToString();
            lbl_Status.Text = Application.StutusID == 1 ? "New" : Application.StutusID == 2 ? "Cancelled" : "Completed";
            String Title = "";
            int Fees = 0;
            int ApplicationType = Application.TypeID;
            BLL.ApplicationTypesBLL.GetType(ref ApplicationType, ref Title, ref Fees);
            lbl_Fees.Text = Fees.ToString();
            lbl_Type.Text = Title;
            lbl_Applicant.Text = BLL.PeopleBLL.GetFullName(Application.PersonID);


            lbl_Date.Text = Application.Date.ToString("dd/MMM/yyyy");
            lbl_StatusDate.Text = Application.LastStutusDate.ToString("dd/MMM/yyyy");
            lbl_CreatedBy.Text = BLL.UserBLL.GetUsreName(Application.CreatedByUser);


        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            int personID = PeopleBLL.GetPersonIDByApplicationID(ApplicationID);
            if (personID != -1)
            {
                Form frmPersonInfo = new PersonDetails(personID);
                frmPersonInfo.ShowDialog();
            }
            else
            {
                MessageBox.Show("Person Not Found !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
