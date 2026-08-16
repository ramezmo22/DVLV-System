using DVLV.Presentation;
using System;
using System.Windows.Forms;

namespace DVLV.UI
{
    public partial class frmAddNewPerson : Form
    {
        private Form _parentForm;
        private int _personId = -1;

        public frmAddNewPerson(int personId = -1)
        {

            _personId = personId;
            InitializeComponent();
            SetIDMood(_personId);
            if (personId != -1)
                ctr_Person_Card1.LoudData(personId);
            this.FormClosed += frmAddNewPerson_FormClosed;
        }
        private void frmAddNewPerson_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (_parentForm is ManagePeople parent)
            {
                parent.RefreshData();
            }
        }
        private void SetIDMood(int PersonID)
        {
            lbl_Header.Text = PersonID == -1 ? "Add New Person" : "Update Person";
            lbl_PersonID.Text = PersonID == -1 ? "???" : PersonID.ToString();
        }

        private void ctr_Person_Card1_OnPersonSelected(int obj)
        {
            lbl_PersonID.Text = obj.ToString();
            SetIDMood(obj);
            ctr_Person_Card1.LoudData(obj);
        }
    }
}
