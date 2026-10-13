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
        private DataTable _dtAllDrivers;

        public List_Drivers()
        {
            InitializeComponent();
            cbx_Filter_By.SelectedIndex = 0;
            txt_Filter_Input.Visible = false;
            Grid_Initialize();
        }

        private void Grid_Initialize()
        {
            _dtAllDrivers = BLL.DriverBLL.GetFilteredData(0, "");

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

            dataGridView1.DataSource = _dtAllDrivers;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            if (_dtAllDrivers != null)
                lbl_Records.Text = "#Records: " + _dtAllDrivers.Rows.Count.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbx_Filter_By_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_Filter_Input.Text = "";

            if (cbx_Filter_By.SelectedIndex == 0)
            {
                txt_Filter_Input.Visible = false;
            }
            else
            {
                txt_Filter_Input.Visible = true;
                txt_Filter_Input.Focus();
            }

            if (_dtAllDrivers != null)
            {
                _dtAllDrivers.DefaultView.RowFilter = "";
                lbl_Records.Text = "#Records: " + dataGridView1.Rows.Count.ToString();
            }
        }

        private void txt_Filter_Input_TextChanged(object sender, EventArgs e)
        {
            if (_dtAllDrivers == null)
                return;

            string filterColumn = "";

            switch (cbx_Filter_By.Text)
            {
                case "Lic.DriverID":
                case "Driver ID":
                    filterColumn = "DriverID";
                    break;
                case "Person ID":
                    filterColumn = "PersonID";
                    break;
                case "NationalNo.":
                case "National No":
                case "National No.":
                    filterColumn = "NationalNo";
                    break;
                case "Full Name":
                    filterColumn = "FullName";
                    break;
                default:
                    filterColumn = "None";
                    break;
            }

            if (filterColumn == "None" || string.IsNullOrWhiteSpace(txt_Filter_Input.Text))
            {
                _dtAllDrivers.DefaultView.RowFilter = "";
                lbl_Records.Text = "#Records: " + dataGridView1.Rows.Count.ToString();
                return;
            }

            if (filterColumn == "DriverID" || filterColumn == "PersonID")
            {
                if (int.TryParse(txt_Filter_Input.Text.Trim(), out _))
                {
                    _dtAllDrivers.DefaultView.RowFilter = string.Format("[{0}] = {1}", filterColumn, txt_Filter_Input.Text.Trim());
                }
                else
                {
                    _dtAllDrivers.DefaultView.RowFilter = "1 = 0";
                }
            }
            else
            {
                _dtAllDrivers.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", filterColumn, txt_Filter_Input.Text.Trim());
            }

            lbl_Records.Text = "#Records: " + dataGridView1.Rows.Count.ToString();
        }
    }
}