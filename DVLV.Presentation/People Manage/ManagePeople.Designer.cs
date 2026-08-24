using DVLV.UI.Properties;

namespace DVLV.Presentation
{
    partial class ManagePeople
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            label1 = new Label();
            cbx_Filter_By = new ComboBox();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            lbl_NumOfRecords_header = new Label();
            errorProvider1 = new ErrorProvider(components);
            btn_CloseForm = new Button();
            btn_AddPerson = new Button();
            dgv_PeopleGrid = new DataGridView();
            cm_Person_Settings = new ContextMenuStrip(components);
            tsm_Show_Details = new ToolStripMenuItem();
            addNewPrToolStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            deleteToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            sendEmailToolStripMenuItem = new ToolStripMenuItem();
            phoneCallToolStripMenuItem = new ToolStripMenuItem();
            imageList1 = new ImageList(components);
            txt_Filter_Value = new TextBox();
            lbl_Number_Of_Records_Count = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgv_PeopleGrid).BeginInit();
            cm_Person_Settings.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(5, 297);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(73, 20);
            label1.TabIndex = 0;
            label1.Text = "Filter By :";
            // 
            // cbx_Filter_By
            // 
            cbx_Filter_By.BackColor = SystemColors.Control;
            cbx_Filter_By.DropDownStyle = ComboBoxStyle.DropDownList;
            cbx_Filter_By.Font = new Font("Segoe UI", 11.25F);
            cbx_Filter_By.ForeColor = SystemColors.WindowText;
            cbx_Filter_By.FormattingEnabled = true;
            cbx_Filter_By.Items.AddRange(new object[] { "None", "PersonID", "NationalNo", "FirstName", "SecondName", "ThirdName", "LastName", "Nationality", "Gendor", "Phone", "Email" });
            cbx_Filter_By.Location = new Point(97, 297);
            cbx_Filter_By.Margin = new Padding(4, 3, 4, 3);
            cbx_Filter_By.Name = "cbx_Filter_By";
            cbx_Filter_By.RightToLeft = RightToLeft.No;
            cbx_Filter_By.Size = new Size(184, 28);
            cbx_Filter_By.TabIndex = 1;
            cbx_Filter_By.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top;
            pictureBox1.Image = Resources.People_400;
            pictureBox1.Location = new Point(509, 30);
            pictureBox1.Margin = new Padding(4, 3, 4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(268, 190);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.FlatStyle = FlatStyle.System;
            label2.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Firebrick;
            label2.Location = new Point(522, 223);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(239, 37);
            label2.TabIndex = 3;
            label2.Text = "Manage People";
            // 
            // lbl_NumOfRecords_header
            // 
            lbl_NumOfRecords_header.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lbl_NumOfRecords_header.AutoSize = true;
            lbl_NumOfRecords_header.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_NumOfRecords_header.Location = new Point(13, 678);
            lbl_NumOfRecords_header.Name = "lbl_NumOfRecords_header";
            lbl_NumOfRecords_header.Size = new Size(161, 21);
            lbl_NumOfRecords_header.TabIndex = 5;
            lbl_NumOfRecords_header.Text = "Number of records :";
            //lbl_NumOfRecords_header.Click += txt_NumOfRecords_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // btn_CloseForm
            // 
            btn_CloseForm.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_CloseForm.Image = UI.Properties.Resources.Close_32;
            btn_CloseForm.ImageAlign = ContentAlignment.MiddleLeft;
            btn_CloseForm.Location = new Point(1120, 671);
            btn_CloseForm.Name = "btn_CloseForm";
            btn_CloseForm.Size = new Size(117, 38);
            btn_CloseForm.TabIndex = 8;
            btn_CloseForm.Text = "Close";
            btn_CloseForm.UseVisualStyleBackColor = true;
            btn_CloseForm.Click += btn_CloseForm_Click;
            // 
            // btn_AddPerson
            // 
            btn_AddPerson.Anchor = AnchorStyles.Right;
            btn_AddPerson.Image = UI.Properties.Resources.Add_Person_40;
            btn_AddPerson.Location = new Point(1182, 294);
            btn_AddPerson.Name = "btn_AddPerson";
            btn_AddPerson.Size = new Size(56, 44);
            btn_AddPerson.TabIndex = 9;
            btn_AddPerson.UseVisualStyleBackColor = true;
            btn_AddPerson.Click += btn_AddPerson_Click;
            // 
            // dgv_PeopleGrid
            // 
            dgv_PeopleGrid.AllowUserToAddRows = false;
            dgv_PeopleGrid.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dgv_PeopleGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgv_PeopleGrid.Anchor = AnchorStyles.None;
            dgv_PeopleGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_PeopleGrid.BackgroundColor = SystemColors.Control;
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
            dgv_PeopleGrid.ContextMenuStrip = cm_Person_Settings;
            dgv_PeopleGrid.GridColor = SystemColors.ButtonShadow;
            dgv_PeopleGrid.Location = new Point(23, 343);
            dgv_PeopleGrid.Margin = new Padding(4, 3, 4, 3);
            dgv_PeopleGrid.Name = "dgv_PeopleGrid";
            dgv_PeopleGrid.ReadOnly = true;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.Format = "d";
            dataGridViewCellStyle3.NullValue = null;
            dgv_PeopleGrid.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dgv_PeopleGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_PeopleGrid.Size = new Size(1214, 318);
            dgv_PeopleGrid.TabIndex = 4;
            // 
            // cm_Person_Settings
            // 
            cm_Person_Settings.Items.AddRange(new ToolStripItem[] { tsm_Show_Details, addNewPrToolStripMenuItem, editToolStripMenuItem, deleteToolStripMenuItem, toolStripSeparator1, sendEmailToolStripMenuItem, phoneCallToolStripMenuItem });
            cm_Person_Settings.Name = "contextMenuStrip1";
            cm_Person_Settings.Size = new Size(179, 238);
            cm_Person_Settings.Opening += cm_Person_Settings_Opening;
            // 
            // tsm_Show_Details
            // 
            tsm_Show_Details.Image = UI.Properties.Resources.PersonDetails_32;
            tsm_Show_Details.ImageAlign = ContentAlignment.MiddleLeft;
            tsm_Show_Details.ImageScaling = ToolStripItemImageScaling.None;
            tsm_Show_Details.Name = "tsm_Show_Details";
            tsm_Show_Details.Size = new Size(178, 38);
            tsm_Show_Details.Text = "Show Details";
            tsm_Show_Details.Click += tsm_Show_Details_Click;
            // 
            // addNewPrToolStripMenuItem
            // 
            addNewPrToolStripMenuItem.Image = UI.Properties.Resources.AddPerson_32;
            addNewPrToolStripMenuItem.ImageAlign = ContentAlignment.MiddleLeft;
            addNewPrToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            addNewPrToolStripMenuItem.Name = "addNewPrToolStripMenuItem";
            addNewPrToolStripMenuItem.Size = new Size(178, 38);
            addNewPrToolStripMenuItem.Text = "Add New Person";
            addNewPrToolStripMenuItem.Click += addNewPrToolStripMenuItem_Click;
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.Image = UI.Properties.Resources.edit_32;
            editToolStripMenuItem.ImageAlign = ContentAlignment.MiddleLeft;
            editToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(178, 38);
            editToolStripMenuItem.Text = "Edit";
            editToolStripMenuItem.Click += editToolStripMenuItem_Click;
            // 
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.Image = UI.Properties.Resources.Delete_32;
            deleteToolStripMenuItem.ImageAlign = ContentAlignment.MiddleLeft;
            deleteToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            deleteToolStripMenuItem.Size = new Size(178, 38);
            deleteToolStripMenuItem.Text = "Delete";
            deleteToolStripMenuItem.Click += deleteToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(175, 6);
            // 
            // sendEmailToolStripMenuItem
            // 
            sendEmailToolStripMenuItem.Image = UI.Properties.Resources.send_email_32;
            sendEmailToolStripMenuItem.ImageAlign = ContentAlignment.MiddleLeft;
            sendEmailToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            sendEmailToolStripMenuItem.Name = "sendEmailToolStripMenuItem";
            sendEmailToolStripMenuItem.Size = new Size(178, 38);
            sendEmailToolStripMenuItem.Text = "Send Email";
            // 
            // phoneCallToolStripMenuItem
            // 
            phoneCallToolStripMenuItem.Image = UI.Properties.Resources.call_32;
            phoneCallToolStripMenuItem.ImageAlign = ContentAlignment.MiddleLeft;
            phoneCallToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            phoneCallToolStripMenuItem.Name = "phoneCallToolStripMenuItem";
            phoneCallToolStripMenuItem.Size = new Size(178, 38);
            phoneCallToolStripMenuItem.Text = "Phone Call";
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // txt_Filter_Value
            // 
            txt_Filter_Value.Font = new Font("Segoe UI", 11.25F);
            txt_Filter_Value.Location = new Point(288, 297);
            txt_Filter_Value.Name = "txt_Filter_Value";
            txt_Filter_Value.Size = new Size(214, 27);
            txt_Filter_Value.TabIndex = 10;
            txt_Filter_Value.TextChanged += txt_Filter_Value_TextChanged;
            txt_Filter_Value.KeyPress += txt_Filter_Value_KeyPress;
            // 
            // lbl_Number_Of_Records_Count
            // 
            lbl_Number_Of_Records_Count.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lbl_Number_Of_Records_Count.AutoSize = true;
            lbl_Number_Of_Records_Count.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_Number_Of_Records_Count.Location = new Point(180, 678);
            lbl_Number_Of_Records_Count.Name = "lbl_Number_Of_Records_Count";
            lbl_Number_Of_Records_Count.Size = new Size(28, 21);
            lbl_Number_Of_Records_Count.TabIndex = 11;
            lbl_Number_Of_Records_Count.Text = "00";
            // 
            // ManagePeople
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1250, 742);
            Controls.Add(lbl_Number_Of_Records_Count);
            Controls.Add(txt_Filter_Value);
            Controls.Add(btn_AddPerson);
            Controls.Add(btn_CloseForm);
            Controls.Add(lbl_NumOfRecords_header);
            Controls.Add(dgv_PeopleGrid);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(cbx_Filter_By);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 3, 4, 3);
            Name = "ManagePeople";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Manage People";
            Load += ManagePeople_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgv_PeopleGrid).EndInit();
            cm_Person_Settings.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbx_Filter_By;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private DataGridView dgv_PeopleGrid;
        private Label lbl_NumOfRecords_header;
        private ErrorProvider errorProvider1;
        private Button btn_AddPerson;
        private Button btn_CloseForm;
        private ContextMenuStrip cm_Person_Settings;
        private ToolStripMenuItem tsm_Show_Details;
        private ToolStripMenuItem addNewPrToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem deleteToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem sendEmailToolStripMenuItem;
        private ToolStripMenuItem phoneCallToolStripMenuItem;
        private ImageList imageList1;
        private TextBox txt_Filter_Value;
        private Label lbl_Number_Of_Records_Count;
    }
}