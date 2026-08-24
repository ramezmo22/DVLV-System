using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace DVLV.UI.Drivers
{
    public partial class List_Drivers : Form
    {
        public List_Drivers()
        {
            InitializeComponent();
            txt_Filter_Input.Visible = false;
            Grid_Initialize();

        }

        private void Grid_Initialize(int SelectedIndex = 0, string FilteringQurey = "")
        {

            DataTable table = BLL.DriverBLL.GetFilteredData(SelectedIndex, FilteringQurey);

            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.Columns.Clear();

            //DriverID	PersonID	NationalNo	FullName	CreatedDate	NumberOfActiveLicenses

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "DriverID",
                DataPropertyName = "DriverID",
                HeaderText = "Lic.DriverID",
                ReadOnly = true
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "NationalNo",
                DataPropertyName = "NationalNo",
                HeaderText = "NationalNo.",
                ReadOnly = true
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "FullName",
                DataPropertyName = "FullName",
                HeaderText = "Full Name",
                ReadOnly = true
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "CreatedDate",
                DataPropertyName = "CreatedDate",
                HeaderText = "Created Date",
                ReadOnly = true,
                DefaultCellStyle = { Format = "g" }
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "NumberOfActiveLicenses",
                DataPropertyName = "NumberOfActiveLicenses",
                HeaderText = "Active Licenses",
                ReadOnly = true,

            });


            dataGridView1.DataSource = table;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            lbl_Records.Text = "#Records: " + table.Rows.Count.ToString();



        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbx_Filter_By_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbx_Filter_By.SelectedIndex == 0)
            {
                txt_Filter_Input.Visible = false;
            }
            else
            {
                txt_Filter_Input.Visible = true;
            }
        }

        private void txt_Filter_Input_TextChanged(object sender, EventArgs e)
        {
            string query = txt_Filter_Input.Text.Trim();

            if ((cbx_Filter_By.SelectedIndex == 1 || cbx_Filter_By.SelectedIndex == 2) &&
                !string.IsNullOrWhiteSpace(query) &&
                !int.TryParse(query, out _))
            {
                txt_Filter_Input.Text = string.Empty;
                return;
            }

            Grid_Initialize(cbx_Filter_By.SelectedIndex, query);
        }
    }
}
