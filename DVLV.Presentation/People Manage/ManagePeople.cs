using DVLV.BLL;
using DVLV.UI;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DVLV.Presentation
{
    public partial class ManagePeople : Form
    {

        private static DataTable _dtAllPeople = PeopleBLL.GetAllPeopleTable();

        //only select the columns that you want to show in the grid
        private DataTable _dtPeople = _dtAllPeople.DefaultView.ToTable(false, "PersonID", "NationalNo",
                                                         "FirstName", "SecondName", "ThirdName", "LastName",
                                                         "GendorCaption", "DateOfBirth", "CountryName",
                                                         "Phone", "Email");
        public ManagePeople()
        {
            InitializeComponent();
        }
        private void ManagePeople_Load(object sender, EventArgs e)
        {
            dgv_PeopleGrid.DataSource = _dtPeople;
            if (dgv_PeopleGrid.Rows.Count > 0)
            {

                dgv_PeopleGrid.Columns[0].HeaderText = "Person ID";
                dgv_PeopleGrid.Columns[0].Width = 110;

                dgv_PeopleGrid.Columns[1].HeaderText = "National No.";
                dgv_PeopleGrid.Columns[1].Width = 120;


                dgv_PeopleGrid.Columns[2].HeaderText = "First Name";
                dgv_PeopleGrid.Columns[2].Width = 120;

                dgv_PeopleGrid.Columns[3].HeaderText = "Second Name";
                dgv_PeopleGrid.Columns[3].Width = 140;


                dgv_PeopleGrid.Columns[4].HeaderText = "Third Name";
                dgv_PeopleGrid.Columns[4].Width = 120;

                dgv_PeopleGrid.Columns[5].HeaderText = "Last Name";
                dgv_PeopleGrid.Columns[5].Width = 120;

                dgv_PeopleGrid.Columns[6].HeaderText = "Gendor";
                dgv_PeopleGrid.Columns[6].Width = 120;

                dgv_PeopleGrid.Columns[7].HeaderText = "Date Of Birth";
                dgv_PeopleGrid.Columns[7].Width = 140;

                dgv_PeopleGrid.Columns[8].HeaderText = "Nationality";
                dgv_PeopleGrid.Columns[8].Width = 120;


                dgv_PeopleGrid.Columns[9].HeaderText = "Phone";
                dgv_PeopleGrid.Columns[9].Width = 120;


                dgv_PeopleGrid.Columns[10].HeaderText = "Email";
                dgv_PeopleGrid.Columns[10].Width = 170;
            }
            lbl_Number_Of_Records_Count.Text = dgv_PeopleGrid.Rows.Count.ToString();
            cbx_Filter_By.SelectedIndex = 0;//Default
        }

        public void RefreshGridData()
        {
            _dtAllPeople = BLL.PeopleBLL.GetAllPeopleTable();
            _dtPeople = _dtAllPeople.DefaultView.ToTable(false, "PersonID", "NationalNo",
                                                       "FirstName", "SecondName", "ThirdName", "LastName",
                                                       "GendorCaption", "DateOfBirth", "CountryName",
                                                       "Phone", "Email");//DataTableNames

            dgv_PeopleGrid.DataSource = _dtPeople;
            lbl_Number_Of_Records_Count.Text = dgv_PeopleGrid.Rows.Count.ToString();

        }
        //Filtering Operation:
        private void txt_Filter_Value_TextChanged(object sender, EventArgs e)
        {
            string FilteringColumn = "";
            switch (cbx_Filter_By.Text)
            {
                case "PersonID":
                    FilteringColumn = "PersonID";
                    break;
                case "NationalNo":
                    FilteringColumn = "NationalNo";
                    break;
                case "FirstName":
                    FilteringColumn = "FirstName";
                    break;
                case "SecondName":
                    FilteringColumn = "SecondName";
                    break;
                case "ThirdName":
                    FilteringColumn = "ThirdName";
                    break;
                case "LastName":
                    FilteringColumn = "LastName";
                    break;
                case "Nationality":
                    FilteringColumn = "CountryName";
                    break;
                case "Gendor":
                    FilteringColumn = "GendorCaption";
                    break;
                case "Phone":
                    FilteringColumn = "Phone";
                    break;
                case "Email":
                    FilteringColumn = "Email";
                    break;
                case "None":
                default:
                    FilteringColumn = "None";
                    break;
            }

            // Apply filtering
            if (string.IsNullOrEmpty(FilteringColumn) || FilteringColumn == "None" || txt_Filter_Value.Text.Trim() == "")
            {
                _dtPeople.DefaultView.RowFilter = "";
            }
            else if (FilteringColumn == "PersonID")
            {
                _dtPeople.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilteringColumn, txt_Filter_Value.Text.Trim());
            }
            else
            {
                _dtPeople.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", FilteringColumn, txt_Filter_Value.Text.Trim());
            }

            lbl_Number_Of_Records_Count.Text = dgv_PeopleGrid.Rows.Count.ToString();
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_Filter_Value.Visible = !(cbx_Filter_By.SelectedIndex == 0);

            if (txt_Filter_Value.Visible)
            {
                txt_Filter_Value.Text = "";
                txt_Filter_Value.Focus();
            }
        }
        private int GetIdFromSelectedColumn()
        {
            if (dgv_PeopleGrid.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgv_PeopleGrid.SelectedRows[0];
                // Assuming the PersonID is stored in the "clnPersonID" column
                if (selectedRow.Cells["PersonID"].Value != null)
                {
                    return Convert.ToInt32(selectedRow.Cells["PersonID"].Value);
                }
            }
            else
            {
                MessageBox.Show("You must select a person in the grid ", "Error", MessageBoxButtons.OK);
                return -1;
            }
            return -1;
        }
        private void addNewPrToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form NewPerson = new frmAddNewPerson();
            NewPerson.ShowDialog();
            RefreshGridData();
        }
        private void tsm_Show_Details_Click(object sender, EventArgs e)
        {
            int ID = GetIdFromSelectedColumn();
            if (ID > 0)
            {
                Form frmPerson = new PersonDetails(ID);
                frmPerson.Show();
                RefreshGridData(); // Reload the data into the grid view
            }
            else return;
        }
        private void cm_Person_Settings_Opening(object sender, CancelEventArgs e)
        {
            if (dgv_PeopleGrid.SelectedRows.Count < 1)
            {
                e.Cancel = true;
            }
        }
        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int ID = GetIdFromSelectedColumn();
            if (ID > 0)
            {
                frmAddNewPerson EditPerson = new frmAddNewPerson(ID);
                EditPerson.ShowDialog();
                dgv_PeopleGrid.DataSource = null; // Clear the existing data source
                RefreshGridData(); // Reload the data into the grid view
            }
            else return;
        }
        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this person?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int ID = GetIdFromSelectedColumn();
                if (PeopleBLL.DeletePerson(ID))
                {
                    if (MessageBox.Show("Person deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                    {
                        // Refresh the grid or perform any other necessary actions
                        dgv_PeopleGrid.DataSource = null; // Clear the existing data source
                        RefreshGridData(); // Reload the data into the grid view
                    }

                }
                else
                {
                    MessageBox.Show("Person was not deleted because it was data linked to it.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void btn_CloseForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btn_AddPerson_Click(object sender, EventArgs e)
        {
            Form AddPersonF = new frmAddNewPerson();
            AddPersonF.ShowDialog();
            RefreshGridData();
        }

        private void txt_Filter_Value_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbx_Filter_By.Text == "PersonID")
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}