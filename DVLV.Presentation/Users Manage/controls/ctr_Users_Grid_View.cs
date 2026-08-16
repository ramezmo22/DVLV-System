using DVLV.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
namespace DVLV.UI
{
    public partial class ctr_Users_Grid_View : UserControl
    {
        public ctr_Users_Grid_View()
        {
            InitializeComponent();
            Grid_Initialize();
        }
        public int UserID = -1;
        public int PersonID = -1;
        public void Grid_Initialize(int FilterationNumber = 0, string filterValue = "")
        {
            DataTable GridData = UserBLL.LoadDataToGridView(FilterationNumber, filterValue);

            // Clear existing columns
            dgv_Users_Data.Columns.Clear();

            // Define columns with custom names
            dgv_Users_Data.Columns.Add(new DataGridViewTextBoxColumn() { Name = "UserID", HeaderText = "User ID", DataPropertyName = "User ID" });
            dgv_Users_Data.Columns.Add(new DataGridViewTextBoxColumn() { Name = "PersonID", HeaderText = "Person ID", DataPropertyName = "Person ID" });
            dgv_Users_Data.Columns.Add(new DataGridViewTextBoxColumn() { Name = "FullName", HeaderText = "Full Name", DataPropertyName = "Full Name", Width = 200 }); // Increased width for Full Name
            dgv_Users_Data.Columns.Add(new DataGridViewTextBoxColumn() { Name = "UserName", HeaderText = "Username", DataPropertyName = "UserName" });
            dgv_Users_Data.Columns.Add(new DataGridViewCheckBoxColumn() { Name = "IsActive", HeaderText = "Active", DataPropertyName = "IsActive" });

            // Bind the data to the DataGridView
            dgv_Users_Data.AutoGenerateColumns = false;
            dgv_Users_Data.DataSource = GridData;

        }
        private void dgv_Users_Data_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void UpdateGridData(int FilterationNumber = 0, string filterValue = "")
        {
            Grid_Initialize(FilterationNumber, filterValue);

        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserID = GetUserIdFromSelectedColumn();
            PersonID = GetPersonIdFromSelectedColumn();
            if (UserID != -1 && PersonID != -1)
            {
                Form frmchangepassword = new Change_Password(UserID, PersonID);
                frmchangepassword.ShowDialog();
            }
            this.Grid_Initialize();

        }







        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //delete User 
            int UserIDToDelete = GetUserIdFromSelectedColumn();
            if (UserIDToDelete == -1)
            {
                MessageBox.Show("Error by Selecting User", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (MessageBox.Show("Do you want to delete this user ", "Alert !", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                if (!UserBLL.DeleteUser(UserIDToDelete))
                {
                    MessageBox.Show("You can delete this user because he/she has data linked to it ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                this.Grid_Initialize();

            }
        }
        private void addNewUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmAddUser = new Add_New_User();
            frmAddUser.ShowDialog();
            this.Grid_Initialize();
        }
        private int GetUserIdFromSelectedColumn()
        {
            int SelectedRows = dgv_Users_Data.SelectedRows.Count;
            if (SelectedRows > 0)
            {
                if (SelectedRows > 1)
                {
                    MessageBox.Show("You must select just one user not " + SelectedRows + " users ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return -1;
                }
                DataGridViewRow selectedRow = dgv_Users_Data.SelectedRows[0];
                // Assuming the UserID is stored in the "clnUserID" column
                if (dgv_Users_Data.Columns.Contains("UserID"))
                {
                    if (selectedRow.Cells["UserID"].Value != null)
                    {
                        return Convert.ToInt32(selectedRow.Cells["UserID"].Value);
                    }
                }
                else
                {
                    MessageBox.Show("The User ID column is missing.", "Error", MessageBoxButtons.OK);
                    return -1;
                }
            }
            else
            {
                MessageBox.Show("You must select a User in the grid ", "Error", MessageBoxButtons.OK);
                return -1;
            }
            return -1;
        }
        private int GetPersonIdFromSelectedColumn()
        {
            if (dgv_Users_Data.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgv_Users_Data.SelectedRows[0];
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

        public int NumberOfRecords()
        {

            return dgv_Users_Data.RowCount;
        }

        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int personid = GetPersonIdFromSelectedColumn();
            if (personid == -1) { return; }
            int userid = GetUserIdFromSelectedColumn();
            if (userid == -1) { return; }
            Form frmUserInfo = new UserInfo(userid, personid);
            frmUserInfo.ShowDialog();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int person = GetPersonIdFromSelectedColumn();
            if (person != -1)
            {
                Form frmUpdateUser = new Add_New_User(person);
                frmUpdateUser.ShowDialog();
                this.Grid_Initialize();

            }
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            if(dgv_Users_Data.SelectedRows.Count<1)
            {
                e.Cancel=true;
                return;
            }
        }
    }
}
