using System;
using System.Data;
using System.Windows.Forms;

namespace DVLV.UI.Drivers
{
    public partial class ctr_Driver_Licenses : UserControl
    {
        private int DriverID = -1;

        public ctr_Driver_Licenses()
        {
            InitializeComponent();
        }

        public void LoudData(int DriverID)
        {
            this.DriverID = DriverID;
            Local_Grid_Initialization();
            International_Grid_Initialization();
        }

        public void Local_Grid_Initialization()
        {
            DataTable table = BLL.LicenseBLL.GetLocalLicensesHistoryTable(this.DriverID);

            dgv_Local_Licenses_History.AutoGenerateColumns = false;
            dgv_Local_Licenses_History.Columns.Clear();

            dgv_Local_Licenses_History.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "LicenseID",
                DataPropertyName = "LicenseID",
                HeaderText = "Lic.ID",
                ReadOnly = true
            });

            dgv_Local_Licenses_History.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "ApplicationID",
                DataPropertyName = "ApplicationID",
                HeaderText = "App.ID",
                ReadOnly = true
            });

            dgv_Local_Licenses_History.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "ClassName",
                DataPropertyName = "ClassName",
                HeaderText = "Class Name",
                ReadOnly = true
            });

            dgv_Local_Licenses_History.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "IssueDate",
                DataPropertyName = "IssueDate",
                HeaderText = "Issue Date",
                ReadOnly = true,
                DefaultCellStyle = { Format = "g" }
            });

            dgv_Local_Licenses_History.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "ExpirationDate",
                DataPropertyName = "ExpirationDate",
                HeaderText = "Expiration Date",
                ReadOnly = true,
                DefaultCellStyle = { Format = "g" }
            });

            dgv_Local_Licenses_History.Columns.Add(new DataGridViewCheckBoxColumn
            {
                Name = "IsActive",
                DataPropertyName = "IsActive",
                HeaderText = "Is Active",
                ReadOnly = true
            });

            dgv_Local_Licenses_History.DataSource = table;
            dgv_Local_Licenses_History.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            lbl_Rercords.Text = "#Records: " + table.Rows.Count.ToString();
        }

        public void International_Grid_Initialization()
        {
            DataTable table = BLL.LicenseBLL.GetInternationalLicensesHistoryTable(this.DriverID);

            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.Columns.Clear();

            //InternationalLicenseID	ApplicationID	ClassName	IssueDate	ExpirationDate	IsActive

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "LicenseID",
                DataPropertyName = "InternationalLicenseID",
                HeaderText = "Lic.ID",
                ReadOnly = true
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "ApplicationID",
                DataPropertyName = "ApplicationID",
                HeaderText = "App.ID",
                ReadOnly = true
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "ClassName",
                DataPropertyName = "ClassName",
                HeaderText = "Class Name",
                ReadOnly = true
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "IssueDate",
                DataPropertyName = "IssueDate",
                HeaderText = "Issue Date",
                ReadOnly = true,
                DefaultCellStyle = { Format = "g" }
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "ExpirationDate",
                DataPropertyName = "ExpirationDate",
                HeaderText = "Expiration Date",
                ReadOnly = true,
                DefaultCellStyle = { Format = "g" }
            });

            dataGridView1.Columns.Add(new DataGridViewCheckBoxColumn
            {
                Name = "IsActive",
                DataPropertyName = "IsActive",
                HeaderText = "Is Active",
                ReadOnly = true
            });

            dataGridView1.DataSource = table;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            lbl_Inter_Records.Text = "#Records: " + table.Rows.Count.ToString();
        }
    }
}
