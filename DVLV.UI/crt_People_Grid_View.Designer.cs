namespace DVLV.UI
{
    partial class crt_People_Grid_View
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv_PeopleGrid = new System.Windows.Forms.DataGridView();
            this.clnPersonID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnNationalNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnFirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnSecondName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnThirdName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnGendor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cln_Date_Of_Birth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cln_Nationality = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cln_Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cln_Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_PeopleGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_PeopleGrid
            // 
            this.dgv_PeopleGrid.AllowUserToAddRows = false;
            this.dgv_PeopleGrid.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_PeopleGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_PeopleGrid.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.Format = "d";
            dataGridViewCellStyle2.NullValue = null;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_PeopleGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_PeopleGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_PeopleGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clnPersonID,
            this.clnNationalNum,
            this.clnFirstName,
            this.clnSecondName,
            this.clnThirdName,
            this.clnLastName,
            this.clnGendor,
            this.cln_Date_Of_Birth,
            this.cln_Nationality,
            this.cln_Phone,
            this.cln_Email});
            this.dgv_PeopleGrid.Location = new System.Drawing.Point(0, 0);
            this.dgv_PeopleGrid.Name = "dgv_PeopleGrid";
            this.dgv_PeopleGrid.ReadOnly = true;
            this.dgv_PeopleGrid.Size = new System.Drawing.Size(1155, 279);
            this.dgv_PeopleGrid.TabIndex = 2;
            this.dgv_PeopleGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // clnPersonID
            // 
            this.clnPersonID.HeaderText = "PersonID";
            this.clnPersonID.Name = "clnPersonID";
            this.clnPersonID.ReadOnly = true;
            // 
            // clnNationalNum
            // 
            this.clnNationalNum.HeaderText = "National No.";
            this.clnNationalNum.Name = "clnNationalNum";
            this.clnNationalNum.ReadOnly = true;
            // 
            // clnFirstName
            // 
            this.clnFirstName.HeaderText = "First Name";
            this.clnFirstName.Name = "clnFirstName";
            this.clnFirstName.ReadOnly = true;
            // 
            // clnSecondName
            // 
            this.clnSecondName.HeaderText = "Second Name";
            this.clnSecondName.Name = "clnSecondName";
            this.clnSecondName.ReadOnly = true;
            // 
            // clnThirdName
            // 
            this.clnThirdName.HeaderText = "Third Name";
            this.clnThirdName.Name = "clnThirdName";
            this.clnThirdName.ReadOnly = true;
            // 
            // clnLastName
            // 
            this.clnLastName.HeaderText = "Last Name";
            this.clnLastName.Name = "clnLastName";
            this.clnLastName.ReadOnly = true;
            // 
            // clnGendor
            // 
            this.clnGendor.HeaderText = "Gendor";
            this.clnGendor.Name = "clnGendor";
            this.clnGendor.ReadOnly = true;
            // 
            // cln_Date_Of_Birth
            // 
            this.cln_Date_Of_Birth.HeaderText = "Date Of Birth";
            this.cln_Date_Of_Birth.Name = "cln_Date_Of_Birth";
            this.cln_Date_Of_Birth.ReadOnly = true;
            // 
            // cln_Nationality
            // 
            this.cln_Nationality.HeaderText = "Nationality";
            this.cln_Nationality.Name = "cln_Nationality";
            this.cln_Nationality.ReadOnly = true;
            // 
            // cln_Phone
            // 
            this.cln_Phone.HeaderText = "Phone";
            this.cln_Phone.Name = "cln_Phone";
            this.cln_Phone.ReadOnly = true;
            // 
            // cln_Email
            // 
            this.cln_Email.HeaderText = "Email";
            this.cln_Email.Name = "cln_Email";
            this.cln_Email.ReadOnly = true;
            // 
            // crt_People_Grid_View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.dgv_PeopleGrid);
            this.Name = "crt_People_Grid_View";
            this.Size = new System.Drawing.Size(1155, 279);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_PeopleGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_PeopleGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnPersonID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnNationalNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnFirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnSecondName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnThirdName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnLastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnGendor;
        private System.Windows.Forms.DataGridViewTextBoxColumn cln_Date_Of_Birth;
        private System.Windows.Forms.DataGridViewTextBoxColumn cln_Nationality;
        private System.Windows.Forms.DataGridViewTextBoxColumn cln_Phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn cln_Email;
    }
}
