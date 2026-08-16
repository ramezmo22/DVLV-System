namespace DVLV.Presentation
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(crt_People_Grid_View));
            cln_Email = new DataGridViewTextBoxColumn();
            cln_Phone = new DataGridViewTextBoxColumn();
            cln_Nationality = new DataGridViewTextBoxColumn();
            cln_Date_Of_Birth = new DataGridViewTextBoxColumn();
            clnGendor = new DataGridViewTextBoxColumn();
            clnLastName = new DataGridViewTextBoxColumn();
            clnThirdName = new DataGridViewTextBoxColumn();
            clnSecondName = new DataGridViewTextBoxColumn();
            clnFirstName = new DataGridViewTextBoxColumn();
            clnNationalNum = new DataGridViewTextBoxColumn();
            clnPersonID = new DataGridViewTextBoxColumn();
            dgv_PeopleGrid = new DataGridView();
            cm_Person_Settings = new ContextMenuStrip(components);
            tsm_Show_Details = new ToolStripMenuItem();
            addNewPrToolStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            deleteToolStripMenuItem = new ToolStripMenuItem();
            sendEmailToolStripMenuItem = new ToolStripMenuItem();
            phoneCallToolStripMenuItem = new ToolStripMenuItem();
            imageList1 = new ImageList(components);
            toolStripSeparator1 = new ToolStripSeparator();
            ((System.ComponentModel.ISupportInitialize)dgv_PeopleGrid).BeginInit();
            cm_Person_Settings.SuspendLayout();
            SuspendLayout();
            // 
            // cln_Email
            // 
            cln_Email.HeaderText = "Email";
            cln_Email.Name = "cln_Email";
            cln_Email.ReadOnly = true;
            // 
            // cln_Phone
            // 
            cln_Phone.HeaderText = "Phone";
            cln_Phone.Name = "cln_Phone";
            cln_Phone.ReadOnly = true;
            // 
            // cln_Nationality
            // 
            cln_Nationality.HeaderText = "Nationality";
            cln_Nationality.Name = "cln_Nationality";
            cln_Nationality.ReadOnly = true;
            // 
            // cln_Date_Of_Birth
            // 
            cln_Date_Of_Birth.HeaderText = "Date Of Birth";
            cln_Date_Of_Birth.Name = "cln_Date_Of_Birth";
            cln_Date_Of_Birth.ReadOnly = true;
            // 
            // clnGendor
            // 
            clnGendor.HeaderText = "Gendor";
            clnGendor.Name = "clnGendor";
            clnGendor.ReadOnly = true;
            // 
            // clnLastName
            // 
            clnLastName.HeaderText = "Last Name";
            clnLastName.Name = "clnLastName";
            clnLastName.ReadOnly = true;
            // 
            // clnThirdName
            // 
            clnThirdName.HeaderText = "Third Name";
            clnThirdName.Name = "clnThirdName";
            clnThirdName.ReadOnly = true;
            // 
            // clnSecondName
            // 
            clnSecondName.HeaderText = "Second Name";
            clnSecondName.Name = "clnSecondName";
            clnSecondName.ReadOnly = true;
            // 
            // clnFirstName
            // 
            clnFirstName.HeaderText = "First Name";
            clnFirstName.Name = "clnFirstName";
            clnFirstName.ReadOnly = true;
            // 
            // clnNationalNum
            // 
            clnNationalNum.HeaderText = "National No.";
            clnNationalNum.Name = "clnNationalNum";
            clnNationalNum.ReadOnly = true;
            // 
            // clnPersonID
            // 
            clnPersonID.HeaderText = "PersonID";
            clnPersonID.Name = "clnPersonID";
            clnPersonID.ReadOnly = true;
            // 
            // dgv_PeopleGrid
            // 
            dgv_PeopleGrid.AllowUserToAddRows = false;
            dgv_PeopleGrid.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dgv_PeopleGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgv_PeopleGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_PeopleGrid.BackgroundColor = Color.White;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.Format = "d";
            dataGridViewCellStyle2.NullValue = null;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgv_PeopleGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgv_PeopleGrid.Columns.AddRange(new DataGridViewColumn[] { clnPersonID, clnNationalNum, clnFirstName, clnSecondName, clnThirdName, clnLastName, clnGendor, cln_Date_Of_Birth, cln_Nationality, cln_Phone, cln_Email });
            dgv_PeopleGrid.ContextMenuStrip = cm_Person_Settings;
            dgv_PeopleGrid.Dock = DockStyle.Fill;
            dgv_PeopleGrid.GridColor = SystemColors.ButtonShadow;
            dgv_PeopleGrid.Location = new Point(0, 0);
            dgv_PeopleGrid.Margin = new Padding(4, 3, 4, 3);
            dgv_PeopleGrid.Name = "dgv_PeopleGrid";
            dgv_PeopleGrid.ReadOnly = true;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.Format = "d";
            dataGridViewCellStyle3.NullValue = null;
            dgv_PeopleGrid.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dgv_PeopleGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_PeopleGrid.Size = new Size(1168, 347);
            dgv_PeopleGrid.TabIndex = 2;
            dgv_PeopleGrid.CellContentClick += dataGridView1_CellContentClick;
            // 
            // cm_Person_Settings
            // 
            cm_Person_Settings.Items.AddRange(new ToolStripItem[] { tsm_Show_Details, addNewPrToolStripMenuItem, editToolStripMenuItem, deleteToolStripMenuItem, toolStripSeparator1, sendEmailToolStripMenuItem, phoneCallToolStripMenuItem });
            cm_Person_Settings.Name = "contextMenuStrip1";
            cm_Person_Settings.Size = new Size(197, 260);
            cm_Person_Settings.Opening += cm_Person_Settings_Opening;
            // 
            // tsm_Show_Details
            // 
            tsm_Show_Details.Image = UI.Properties.Resources.PersonDetails_32;
            tsm_Show_Details.ImageAlign = ContentAlignment.MiddleLeft;
            tsm_Show_Details.ImageScaling = ToolStripItemImageScaling.None;
            tsm_Show_Details.Name = "tsm_Show_Details";
            tsm_Show_Details.Size = new Size(196, 38);
            tsm_Show_Details.Text = "Show Details";
            tsm_Show_Details.Click += tsm_Show_Details_Click;
            // 
            // addNewPrToolStripMenuItem
            // 
            addNewPrToolStripMenuItem.Image = UI.Properties.Resources.AddPerson_32;
            addNewPrToolStripMenuItem.ImageAlign = ContentAlignment.MiddleLeft;
            addNewPrToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            addNewPrToolStripMenuItem.Name = "addNewPrToolStripMenuItem";
            addNewPrToolStripMenuItem.Size = new Size(196, 38);
            addNewPrToolStripMenuItem.Text = "Add New Person";
            addNewPrToolStripMenuItem.Click += addNewPrToolStripMenuItem_Click;
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.Image = UI.Properties.Resources.edit_32;
            editToolStripMenuItem.ImageAlign = ContentAlignment.MiddleLeft;
            editToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(196, 38);
            editToolStripMenuItem.Text = "Edit";
            editToolStripMenuItem.Click += editToolStripMenuItem_Click;
            // 
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.Image = UI.Properties.Resources.Delete_32;
            deleteToolStripMenuItem.ImageAlign = ContentAlignment.MiddleLeft;
            deleteToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            deleteToolStripMenuItem.Size = new Size(196, 38);
            deleteToolStripMenuItem.Text = "Delete";
            deleteToolStripMenuItem.Click += deleteToolStripMenuItem_Click;
            // 
            // sendEmailToolStripMenuItem
            // 
            sendEmailToolStripMenuItem.Image = UI.Properties.Resources.send_email_32;
            sendEmailToolStripMenuItem.ImageAlign = ContentAlignment.MiddleLeft;
            sendEmailToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            sendEmailToolStripMenuItem.Name = "sendEmailToolStripMenuItem";
            sendEmailToolStripMenuItem.Size = new Size(196, 38);
            sendEmailToolStripMenuItem.Text = "Send Email";
            // 
            // phoneCallToolStripMenuItem
            // 
            phoneCallToolStripMenuItem.Image = UI.Properties.Resources.call_32;
            phoneCallToolStripMenuItem.ImageAlign = ContentAlignment.MiddleLeft;
            phoneCallToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            phoneCallToolStripMenuItem.Name = "phoneCallToolStripMenuItem";
            phoneCallToolStripMenuItem.Size = new Size(196, 38);
            phoneCallToolStripMenuItem.Text = "Phone Call";
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "PersonDetails 32.png");
            imageList1.Images.SetKeyName(1, "AddPerson 32.png");
            imageList1.Images.SetKeyName(2, "edit 32.png");
            imageList1.Images.SetKeyName(3, "Delete 32.png");
            imageList1.Images.SetKeyName(4, "send email 32.png");
            imageList1.Images.SetKeyName(5, "call 32.png");
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(193, 6);
            // 
            // crt_People_Grid_View
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(dgv_PeopleGrid);
            Margin = new Padding(4, 3, 4, 3);
            Name = "crt_People_Grid_View";
            Size = new Size(1168, 347);
            ((System.ComponentModel.ISupportInitialize)dgv_PeopleGrid).EndInit();
            cm_Person_Settings.ResumeLayout(false);
            ResumeLayout(false);

        }

        #endregion

        private DataGridViewTextBoxColumn cln_Email;
        private DataGridViewTextBoxColumn cln_Phone;
        private DataGridViewTextBoxColumn cln_Nationality;
        private DataGridViewTextBoxColumn cln_Date_Of_Birth;
        private DataGridViewTextBoxColumn clnGendor;
        private DataGridViewTextBoxColumn clnLastName;
        private DataGridViewTextBoxColumn clnThirdName;
        private DataGridViewTextBoxColumn clnSecondName;
        private DataGridViewTextBoxColumn clnFirstName;
        private DataGridViewTextBoxColumn clnNationalNum;
        private DataGridViewTextBoxColumn clnPersonID;
        private DataGridView dgv_PeopleGrid;
        private ImageList imageList1;
        private ContextMenuStrip cm_Person_Settings;
        private ToolStripMenuItem addNewPrToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem deleteToolStripMenuItem;
        private ToolStripMenuItem sendEmailToolStripMenuItem;
        private ToolStripMenuItem phoneCallToolStripMenuItem;
        private ToolStripMenuItem tsm_Show_Details;
        private ToolStripSeparator toolStripSeparator1;
    }
}
