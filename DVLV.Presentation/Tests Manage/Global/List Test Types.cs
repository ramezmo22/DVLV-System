using DVLV.BLL;
using DVLV.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
namespace DVLV.UI
{
    public partial class List_Test_Types : Form
    {
        public List_Test_Types()
        {
            InitializeComponent();
            LoudDataToGridview();
        }
        private void DataGridViewConfiger()
        {
            dgv_Test_Types.AutoGenerateColumns = false;
            dgv_Test_Types.Columns.Clear();

            var clnID = new DataGridViewTextBoxColumn();
            clnID.DataPropertyName = "TestTypeID";
            clnID.Name = "ID";
            clnID.HeaderText = "ID";
            clnID.ValueType = typeof(int);
            clnID.Width = 60;
            clnID.ReadOnly = true;

            var clnTitle = new DataGridViewTextBoxColumn();
            clnTitle.DataPropertyName = "TestTypeTitle";
            clnTitle.Name = "Title";
            clnTitle.HeaderText = "Title";
            clnTitle.ValueType = typeof(string);
            clnTitle.Width = 150;

            var clnDescription = new DataGridViewTextBoxColumn();
            clnDescription.DataPropertyName = "TestTypeDescription";
            clnDescription.Name = "Description";
            clnDescription.HeaderText = "Description";
            clnDescription.ValueType = typeof(string);
            clnDescription.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            var clnFees = new DataGridViewTextBoxColumn();
            clnFees.DataPropertyName = "TestTypeFees";
            clnFees.Name = "Fees";
            clnFees.HeaderText = "Fees";
            clnFees.ValueType = typeof(decimal);
            clnFees.DefaultCellStyle.Format = "N2";
            clnFees.Width = 100;

            dgv_Test_Types.Columns.AddRange(clnID, clnTitle, clnDescription, clnFees);
        }

        private void LoudDataToGridview()
        {
            DataGridViewConfiger();
            DataTable dataTable = TestTypesBLL.GetTypes(); // أو GetTestTypes() حسب الاسم المعتمد عندك في الـ BLL
            dgv_Test_Types.DataSource = dataTable;
            lbl_Records.Text = $"# Records: {dataTable.Rows.Count}";
        }



        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private int GetIDFromSelectedRow()
        {
            if (dgv_Test_Types.SelectedRows.Count == 0)
            {
                MessageBox.Show("You must select at least one row.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }

            if (dgv_Test_Types.SelectedRows.Count > 1)
            {
                MessageBox.Show($"You must select 1 row, not {dgv_Test_Types.SelectedRows.Count} rows.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }

            DataGridViewRow row = dgv_Test_Types.SelectedRows[0];
            return Convert.ToInt32(row.Cells["ID"].Value);
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int ID = GetIDFromSelectedRow();
            if (ID != -1)
            {
                Form frmUpdateTest = new Update_Test_Type(ID);
                frmUpdateTest.ShowDialog();
                LoudDataToGridview();
            }
        }
    }
}
