using DVLV.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DVLV.UI
{
    public partial class Manage_Application_Types : Form
    {
        public Manage_Application_Types()
        {
            InitializeComponent();
            LoudDataToGridView();
        }
        private void DataGridViewConfiger()
        {
            dgv_Apllications_Types.AutoGenerateColumns = false;
            dgv_Apllications_Types.Columns.Clear();

            var clnID = new DataGridViewTextBoxColumn();
            clnID.DataPropertyName = "ApplicationTypeID"; // اسم العمود الفعلي في قاعدة البيانات
            clnID.Name = "ID";
            clnID.HeaderText = "ID";
            clnID.ValueType = typeof(int);
            clnID.Width = 60;
            clnID.ReadOnly = true;

            var clnTitle = new DataGridViewTextBoxColumn();
            clnTitle.DataPropertyName = "ApplicationTypeTitle"; // اسم العمود الفعلي في قاعدة البيانات
            clnTitle.Name = "Title";
            clnTitle.HeaderText = "Title";
            clnTitle.ValueType = typeof(string);
            clnTitle.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            var clnFees = new DataGridViewTextBoxColumn();
            clnFees.DataPropertyName = "ApplicationFees"; // اسم العمود الفعلي في قاعدة البيانات
            clnFees.Name = "Fees";
            clnFees.HeaderText = "Fees";
            clnFees.ValueType = typeof(decimal);
            clnFees.DefaultCellStyle.Format = "N2";
            clnFees.Width = 100;

            dgv_Apllications_Types.Columns.AddRange(clnID, clnTitle, clnFees);
        }
        private void LoudDataToGridView()
        {
            DataGridViewConfiger();
            DataTable dataTable = ApplicationTypesBLL.GetTypes();
            dgv_Apllications_Types.DataSource = dataTable;
            lbl_Records.Text = $"# Records: {dataTable.Rows.Count}";
        }

        private int GetIDFromSelectedRow()
        {
            if (dgv_Apllications_Types.SelectedRows.Count == 0)
            {
                MessageBox.Show("You must select a row!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1; // Return -1 immediately if no row is selected
            }

            try
            {
                DataGridViewRow row = dgv_Apllications_Types.SelectedRows[0];
                object cellValue = row.Cells["ID"].Value;

                if (cellValue == null || cellValue == DBNull.Value)
                {
                    MessageBox.Show("The selected row does not have a valid ID!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return -1;
                }

                return Convert.ToInt32(cellValue);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while retrieving the ID: {ex.Message}", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }
        }


        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int id = GetIDFromSelectedRow();
            if (id > -1)
            {
                Form frmEditType = new Update_Application_Type(id);
                frmEditType.ShowDialog();
                LoudDataToGridView();

            }
        }
    }
}
