using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DVLV.BLL;
using DVLV.UI;

namespace DVLV.Presentation
{
    public partial class crt_People_Grid_View : UserControl
    {
        //enum enDataFilteringOrder
        //{
        //    None = 0,
        //    PersonID = 1,
        //    NationalNo = 2,
        //    FirstName = 3,
        //    SecondName = 4,
        //    ThirdName = 5,
        //    LastName = 6,
        //    Nationality = 7,
        //    Gendor = 8,
        //    Phone = 9,
        //    Email = 10
        //}
       
        public crt_People_Grid_View()
        {
            InitializeComponent();
            dgv_PeopleGrid.CellFormatting += dgv_PeopleGrid_CellFormatting;
            
        }

        private void dgv_PeopleGrid_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgv_PeopleGrid.Columns[e.ColumnIndex].Name == "clnGendor")
            {
                if (e.Value != null)
                {
                    if (e.Value.ToString() == "1")
                    {
                        e.Value = "Female";
                        e.FormattingApplied = true;
                    }
                    else if (e.Value.ToString() == "0")
                    {
                        e.Value = "Male";
                        e.FormattingApplied = true;
                    }
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public int GetNumberOfRecords()
        {
            return dgv_PeopleGrid.Rows.Count;
        }


        public void GridViewDataLoad(int FilterMood = 0, string ForSearching = "")
        {
            DataTable peopleData = PeopleBLL.PeopleDataSelection(FilterMood, ForSearching);
            //Initialize that a table and adding the data to it from the business logic 
            dgv_PeopleGrid.AutoGenerateColumns = false; // This to avoid error duplicate the columns  
            dgv_PeopleGrid.DataSource = peopleData;//puting that data  From data table to data source of the GRid view

            // ربط الأعمدة مع أسماء الأعمدة في قاعدة البيانات
            //In this step we connect Column in data Grid view with a column and data table 

            dgv_PeopleGrid.Columns["clnPersonID"].DataPropertyName = "PersonID";
            dgv_PeopleGrid.Columns["clnNationalNum"].DataPropertyName = "NationalNo";
            dgv_PeopleGrid.Columns["clnFirstName"].DataPropertyName = "FirstName";
            dgv_PeopleGrid.Columns["clnSecondName"].DataPropertyName = "SecondName";
            dgv_PeopleGrid.Columns["clnThirdName"].DataPropertyName = "ThirdName";
            dgv_PeopleGrid.Columns["clnLastName"].DataPropertyName = "LastName";
            dgv_PeopleGrid.Columns["clnGendor"].DataPropertyName = "Gendor";
            dgv_PeopleGrid.Columns["cln_Date_Of_Birth"].DataPropertyName = "DateOfBirth";
            dgv_PeopleGrid.Columns["cln_Nationality"].DataPropertyName = "CountryName";
            dgv_PeopleGrid.Columns["cln_Phone"].DataPropertyName = "Phone";
            dgv_PeopleGrid.Columns["cln_Email"].DataPropertyName = "Email";

        }
        private void crt_People_Grid_View_Load(object sender, EventArgs e)
        {
            // dgv_PeopleGrid.Columns["NationalNoColumn"].DataPropertyName = "NationalNo";
            dgv_PeopleGrid.AutoGenerateColumns = false;
        }

        private void cm_Person_Settings_Opening(object sender, CancelEventArgs e)
        {
            if(dgv_PeopleGrid.SelectedRows.Count<1)
            {
                e.Cancel = true;
            }
        }
        private int GetIdFromSelectedColumn()
        {
            if (dgv_PeopleGrid.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgv_PeopleGrid.SelectedRows[0];
                // Assuming the PersonID is stored in the "clnPersonID" column
                if (selectedRow.Cells["clnPersonID"].Value != null)
                {
                    return Convert.ToInt32(selectedRow.Cells["clnPersonID"].Value);
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
        }

        private void tsm_Show_Details_Click(object sender, EventArgs e)
        {
            int ID = GetIdFromSelectedColumn();
            if (ID > 0)
            {
                Form frmPerson = new PersonDetails(ID);
                frmPerson.Show();
                dgv_PeopleGrid.DataSource = null; // Clear the existing data source
                GridViewDataLoad(); // Reload the data into the grid view
            }
            else return;
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int ID = GetIdFromSelectedColumn();
            if (ID > 0)
            {
                frmAddNewPerson EditPerson = new frmAddNewPerson( ID);
                EditPerson.ShowDialog();
                dgv_PeopleGrid.DataSource = null; // Clear the existing data source
                GridViewDataLoad(); // Reload the data into the grid view
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
                        dgv_PeopleGrid.DataSource= null; // Clear the existing data source
                        GridViewDataLoad(); // Reload the data into the grid view
                    }

                }
                else
                {
                    MessageBox.Show("Person was not deleted because it was data linked to it.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
        }
    }
}
