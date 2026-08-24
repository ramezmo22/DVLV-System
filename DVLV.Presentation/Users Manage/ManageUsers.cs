using DVLV.BLL;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Security.Policy;
using System.Text;
using System.Windows.Forms;

namespace DVLV.UI
{
    public partial class ManageUsers : Form
    {
        private int _PersonID = -1;
        private int _UserID = -1;

        private static DataTable _dtAllUsers = BLL.UserBLL.LoadDataToGridView();

        private DataTable _dtUsers = _dtAllUsers.DefaultView.ToTable(false, "User ID", "Person ID", "Full Name", "UserName", "IsActive");
        public ManageUsers()
        {
            InitializeComponent();
        }

        private void ManageUsers_Load(object sender, EventArgs e)
        {
            dgv_Users_Data.DataSource = _dtUsers;

            if(dgv_Users_Data.Rows.Count > 0)
            {
                dgv_Users_Data.Columns[0].HeaderText = "User ID";
                dgv_Users_Data.Columns[0].Width = 120;
                
                dgv_Users_Data.Columns[1].HeaderText = "Person ID";
                dgv_Users_Data.Columns[1].Width = 120;

                dgv_Users_Data.Columns[2].HeaderText = "Full Name";
                dgv_Users_Data.Columns[2].Width = 320;

                dgv_Users_Data.Columns[3].HeaderText = "User Name";
                dgv_Users_Data.Columns[3].Width = 150;

                dgv_Users_Data.Columns[4].HeaderText = "Is Active";
                dgv_Users_Data.Columns[4].Width = 100;

            }

            cbx_Filter_Selection.SelectedIndex = 0;
            cbx_Is_Active.SelectedIndex = 0;
            ResetNumberOfRecords();
        }


        private void btn_Add_User_Click(object sender, EventArgs e)
        {
            Form AddUser = new Add_New_User();
            AddUser.ShowDialog();

        }

        private void AllowNumbersOnly(object sender, KeyPressEventArgs e)
        {
            // السماح فقط بالأرقام
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void cbx_Filter_Selection_SelectedIndexChanged(object sender, EventArgs e)
        {
            // إلغاء الفلترة القديمة وتفريغ الخانات
            _dtUsers.DefaultView.RowFilter = "";
            txt_Filter_Value.Text = "";
            ResetNumberOfRecords();

            // 0 = None, 5 = Is Active
            if (cbx_Filter_Selection.SelectedIndex == 5) // Is Active
            {
                txt_Filter_Value.Visible = false;
                cbx_Is_Active.Visible = true;
                cbx_Is_Active.SelectedIndex = 0;
            }
            else if (cbx_Filter_Selection.SelectedIndex == 0) // None
            {
                txt_Filter_Value.Visible = false;
                cbx_Is_Active.Visible = false;
            }
            else 
            {
                txt_Filter_Value.Visible = true;
                cbx_Is_Active.Visible = false;
                txt_Filter_Value.Focus();
            }

            txt_Filter_Value.KeyPress -= AllowNumbersOnly;

            if (cbx_Filter_Selection.SelectedIndex == 1 || cbx_Filter_Selection.SelectedIndex == 2)
            {
                txt_Filter_Value.KeyPress += AllowNumbersOnly;
            }
        }

        private void Refresh_Grid()
        {
            _dtAllUsers = BLL.UserBLL.LoadDataToGridView();
            _dtUsers = _dtAllUsers.DefaultView.ToTable(false, "User ID", "Person ID", "Full Name", "UserName", "IsActive");

            dgv_Users_Data.DataSource = _dtUsers;

            txt_Filter_Value_TextChanged(null, null);
            ResetNumberOfRecords();
        }

        private void txt_Filter_Value_TextChanged(object sender, EventArgs e)
        {
            //None
            //User ID
            //Person ID
            //Full Name
            //UserName
            //Is Active
            string Filter_column = "";

            switch (cbx_Filter_Selection.Text)
            {
                case "User ID"://userID
                    {
                        Filter_column = "User ID";
                        break;
                    }
                case "Person ID"://PersonID
                    {
                        Filter_column = "Person ID";
                        break;
                    }
                case "Full Name"://FullName
                    {
                        Filter_column = "Full Name";
                        break;
                    }
                case "UserName"://UserName
                    {
                        Filter_column = "UserName";
                        break;
                    }
                case "None"://none
                default:
                    {
                        Filter_column = "None";
                        return;
                    }
            }
            if (Filter_column == "None" || string.IsNullOrWhiteSpace(Filter_column) || string.IsNullOrWhiteSpace(txt_Filter_Value.Text.Trim()))
            {
                _dtUsers.DefaultView.RowFilter = "";
                ResetNumberOfRecords();
                return;
            }
            if (cbx_Filter_Selection.Text == "Person ID" || cbx_Filter_Selection.Text == "User ID") 
            {
                _dtUsers.DefaultView.RowFilter = string.Format(" [{0}] = {1}", Filter_column, txt_Filter_Value.Text.Trim());
                ResetNumberOfRecords();
            }
            else
            {
                _dtUsers.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'",Filter_column,txt_Filter_Value.Text.Trim());
                ResetNumberOfRecords();
            }

        }

        private void cbx_Is_Active_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbx_Is_Active.Text)
            {
                case "Yes":
                    _dtUsers.DefaultView.RowFilter = "[IsActive] = 1 OR [IsActive] = true";
                    break;

                case "No":
                    _dtUsers.DefaultView.RowFilter = "[IsActive] = 0 OR [IsActive] = false";
                    break;

                case "All":
                default:
                    _dtUsers.DefaultView.RowFilter = "";
                    break;
            }

            ResetNumberOfRecords();
        }

        public void ResetNumberOfRecords()
        {
            lbl_Records_Value.Text = dgv_Users_Data.RowCount.ToString();
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _UserID = GetUserIdFromSelectedColumn();
            _PersonID = GetPersonIdFromSelectedColumn();
            if (_UserID != -1 && _PersonID != -1)
            {
                Form frmchangepassword = new Change_Password(_UserID, _PersonID);
                frmchangepassword.ShowDialog();
            }
            this.Refresh_Grid();

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
                this.Refresh_Grid();

            }
        }

        private void addNewUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmAddUser = new Add_New_User();
            frmAddUser.ShowDialog();
            this.Refresh_Grid();
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
                if (dgv_Users_Data.Columns.Contains("User ID"))
                {
                    if (selectedRow.Cells["User ID"].Value != null)
                    {
                        return Convert.ToInt32(selectedRow.Cells["User ID"].Value);
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
                if (selectedRow.Cells["Person ID"].Value != null)
                {
                    return Convert.ToInt32(selectedRow.Cells["Person ID"].Value);
                }
            }
            else
            {
                MessageBox.Show("You must select a person in the grid ", "Error", MessageBoxButtons.OK);
                return -1;
            }
            return -1;
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
                this.Refresh_Grid();

            }
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            if (dgv_Users_Data.SelectedRows.Count < 1)
            {
                e.Cancel = true;
                return;
            }
        }

    }

}




