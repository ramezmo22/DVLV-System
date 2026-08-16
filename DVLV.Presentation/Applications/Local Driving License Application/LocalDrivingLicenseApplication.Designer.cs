namespace DVLV.UI
{
    partial class LocalDrivingLicenseApplications
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            dgv_Local_Driving_License_Applications = new DataGridView();
            contextMenuStrip1 = new ContextMenuStrip(components);
            showApplicationDetailsToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            editApplicationToolStripMenuItem = new ToolStripMenuItem();
            deleteApplicationToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator3 = new ToolStripSeparator();
            cancelApplicationToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator4 = new ToolStripSeparator();
            sechduleTestsToolStripMenuItem = new ToolStripMenuItem();
            schedualVisionTestToolStripMenuItem = new ToolStripMenuItem();
            SchedualWritenTestToolStripMenuItem = new ToolStripMenuItem();
            schedualStreetTestToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator6 = new ToolStripSeparator();
            issueDrivingLicenseFirstTimeToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator5 = new ToolStripSeparator();
            showLicenseToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator7 = new ToolStripSeparator();
            showPersonalLicenseHistoryToolStripMenuItem = new ToolStripMenuItem();
            label2 = new Label();
            label3 = new Label();
            lbl_Number_Of_Records = new Label();
            cbx_Filter = new ComboBox();
            txt_Filter = new TextBox();
            btn_AddNewApplication = new Button();
            btn_Close = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgv_Local_Driving_License_Applications).BeginInit();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Applications;
            pictureBox1.Location = new Point(524, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(235, 189);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Local_32;
            pictureBox2.Location = new Point(586, 149);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(34, 26);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(192, 0, 0);
            label1.Location = new Point(428, 200);
            label1.Name = "label1";
            label1.Size = new Size(431, 37);
            label1.TabIndex = 2;
            label1.Text = "Local Driving License Applications";
            // 
            // dgv_Local_Driving_License_Applications
            // 
            dgv_Local_Driving_License_Applications.AllowUserToAddRows = false;
            dgv_Local_Driving_License_Applications.AllowUserToDeleteRows = false;
            dgv_Local_Driving_License_Applications.BackgroundColor = SystemColors.Control;
            dgv_Local_Driving_License_Applications.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Local_Driving_License_Applications.ContextMenuStrip = contextMenuStrip1;
            dgv_Local_Driving_License_Applications.Location = new Point(12, 310);
            dgv_Local_Driving_License_Applications.Name = "dgv_Local_Driving_License_Applications";
            dgv_Local_Driving_License_Applications.ReadOnly = true;
            dgv_Local_Driving_License_Applications.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_Local_Driving_License_Applications.Size = new Size(1244, 352);
            dgv_Local_Driving_License_Applications.TabIndex = 3;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { showApplicationDetailsToolStripMenuItem, toolStripSeparator1, editApplicationToolStripMenuItem, deleteApplicationToolStripMenuItem, toolStripSeparator3, cancelApplicationToolStripMenuItem, toolStripSeparator4, sechduleTestsToolStripMenuItem, toolStripSeparator6, issueDrivingLicenseFirstTimeToolStripMenuItem, toolStripSeparator5, showLicenseToolStripMenuItem, toolStripSeparator7, showPersonalLicenseHistoryToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(263, 366);
            contextMenuStrip1.Opening += contextMenuStrip1_Opening;
            // 
            // showApplicationDetailsToolStripMenuItem
            // 
            showApplicationDetailsToolStripMenuItem.Image = Properties.Resources.PersonDetails_32;
            showApplicationDetailsToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            showApplicationDetailsToolStripMenuItem.Name = "showApplicationDetailsToolStripMenuItem";
            showApplicationDetailsToolStripMenuItem.Size = new Size(262, 38);
            showApplicationDetailsToolStripMenuItem.Text = "Show Application Details";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(259, 6);
            // 
            // editApplicationToolStripMenuItem
            // 
            editApplicationToolStripMenuItem.Image = Properties.Resources.edit_32;
            editApplicationToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            editApplicationToolStripMenuItem.Name = "editApplicationToolStripMenuItem";
            editApplicationToolStripMenuItem.Size = new Size(262, 38);
            editApplicationToolStripMenuItem.Text = "Edit Application";
            editApplicationToolStripMenuItem.Click += editApplicationToolStripMenuItem_Click;
            // 
            // deleteApplicationToolStripMenuItem
            // 
            deleteApplicationToolStripMenuItem.Image = Properties.Resources.Delete_32_2;
            deleteApplicationToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            deleteApplicationToolStripMenuItem.Name = "deleteApplicationToolStripMenuItem";
            deleteApplicationToolStripMenuItem.Size = new Size(262, 38);
            deleteApplicationToolStripMenuItem.Text = "Delete Application";
            deleteApplicationToolStripMenuItem.Click += deleteApplicationToolStripMenuItem_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(259, 6);
            // 
            // cancelApplicationToolStripMenuItem
            // 
            cancelApplicationToolStripMenuItem.Image = Properties.Resources.Delete_32;
            cancelApplicationToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            cancelApplicationToolStripMenuItem.Name = "cancelApplicationToolStripMenuItem";
            cancelApplicationToolStripMenuItem.Size = new Size(262, 38);
            cancelApplicationToolStripMenuItem.Text = "Cancel Application";
            cancelApplicationToolStripMenuItem.Click += cancelApplicationToolStripMenuItem_Click;
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new Size(259, 6);
            // 
            // sechduleTestsToolStripMenuItem
            // 
            sechduleTestsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { schedualVisionTestToolStripMenuItem, SchedualWritenTestToolStripMenuItem, schedualStreetTestToolStripMenuItem });
            sechduleTestsToolStripMenuItem.Image = Properties.Resources.Schedule_Test_32;
            sechduleTestsToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            sechduleTestsToolStripMenuItem.Name = "sechduleTestsToolStripMenuItem";
            sechduleTestsToolStripMenuItem.Size = new Size(262, 38);
            sechduleTestsToolStripMenuItem.Text = "Sechdule Tests";
            // 
            // schedualVisionTestToolStripMenuItem
            // 
            schedualVisionTestToolStripMenuItem.Image = Properties.Resources.Vision_Test_32;
            schedualVisionTestToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            schedualVisionTestToolStripMenuItem.Name = "schedualVisionTestToolStripMenuItem";
            schedualVisionTestToolStripMenuItem.Size = new Size(200, 38);
            schedualVisionTestToolStripMenuItem.Text = "Schedual Vision Test";
            schedualVisionTestToolStripMenuItem.Click += schedualVisionTestToolStripMenuItem_Click;
            // 
            // SchedualWritenTestToolStripMenuItem
            // 
            SchedualWritenTestToolStripMenuItem.Image = Properties.Resources.Written_Test_32_Sechdule;
            SchedualWritenTestToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            SchedualWritenTestToolStripMenuItem.Name = "SchedualWritenTestToolStripMenuItem";
            SchedualWritenTestToolStripMenuItem.Size = new Size(200, 38);
            SchedualWritenTestToolStripMenuItem.Text = "Schedual Writen Test";
            SchedualWritenTestToolStripMenuItem.Click += SchedualWritenTestToolStripMenuItem_Click;
            // 
            // schedualStreetTestToolStripMenuItem
            // 
            schedualStreetTestToolStripMenuItem.Image = Properties.Resources.Street_Test_32;
            schedualStreetTestToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            schedualStreetTestToolStripMenuItem.Name = "schedualStreetTestToolStripMenuItem";
            schedualStreetTestToolStripMenuItem.Size = new Size(200, 38);
            schedualStreetTestToolStripMenuItem.Text = "Schedual Street Test";
            schedualStreetTestToolStripMenuItem.Click += schedualStreetTestToolStripMenuItem_Click;
            // 
            // toolStripSeparator6
            // 
            toolStripSeparator6.Name = "toolStripSeparator6";
            toolStripSeparator6.Size = new Size(259, 6);
            // 
            // issueDrivingLicenseFirstTimeToolStripMenuItem
            // 
            issueDrivingLicenseFirstTimeToolStripMenuItem.Image = Properties.Resources.IssueDrivingLicense_32;
            issueDrivingLicenseFirstTimeToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            issueDrivingLicenseFirstTimeToolStripMenuItem.Name = "issueDrivingLicenseFirstTimeToolStripMenuItem";
            issueDrivingLicenseFirstTimeToolStripMenuItem.Size = new Size(262, 38);
            issueDrivingLicenseFirstTimeToolStripMenuItem.Text = "Issue Driving License (First Time)";
            issueDrivingLicenseFirstTimeToolStripMenuItem.Click += issueDrivingLicenseFirstTimeToolStripMenuItem_Click;
            // 
            // toolStripSeparator5
            // 
            toolStripSeparator5.Name = "toolStripSeparator5";
            toolStripSeparator5.Size = new Size(259, 6);
            // 
            // showLicenseToolStripMenuItem
            // 
            showLicenseToolStripMenuItem.Image = Properties.Resources.License_View_32;
            showLicenseToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            showLicenseToolStripMenuItem.Name = "showLicenseToolStripMenuItem";
            showLicenseToolStripMenuItem.Size = new Size(262, 38);
            showLicenseToolStripMenuItem.Text = " Show license";
            showLicenseToolStripMenuItem.Click += showLicenseToolStripMenuItem_Click;
            // 
            // toolStripSeparator7
            // 
            toolStripSeparator7.Name = "toolStripSeparator7";
            toolStripSeparator7.Size = new Size(259, 6);
            // 
            // showPersonalLicenseHistoryToolStripMenuItem
            // 
            showPersonalLicenseHistoryToolStripMenuItem.Image = Properties.Resources.PersonLicenseHistory_32;
            showPersonalLicenseHistoryToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            showPersonalLicenseHistoryToolStripMenuItem.Name = "showPersonalLicenseHistoryToolStripMenuItem";
            showPersonalLicenseHistoryToolStripMenuItem.Size = new Size(262, 38);
            showPersonalLicenseHistoryToolStripMenuItem.Text = "Show personal license History";
            showPersonalLicenseHistoryToolStripMenuItem.Click += showPersonalLicenseHistoryToolStripMenuItem_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 277);
            label2.Name = "label2";
            label2.Size = new Size(69, 20);
            label2.TabIndex = 4;
            label2.Text = "Filter By:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 665);
            label3.Name = "label3";
            label3.Size = new Size(80, 20);
            label3.TabIndex = 5;
            label3.Text = "# Records:";
            // 
            // lbl_Number_Of_Records
            // 
            lbl_Number_Of_Records.AutoSize = true;
            lbl_Number_Of_Records.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_Number_Of_Records.Location = new Point(98, 665);
            lbl_Number_Of_Records.Name = "lbl_Number_Of_Records";
            lbl_Number_Of_Records.Size = new Size(30, 20);
            lbl_Number_Of_Records.TabIndex = 6;
            lbl_Number_Of_Records.Text = "???";
            // 
            // cbx_Filter
            // 
            cbx_Filter.DropDownStyle = ComboBoxStyle.DropDownList;
            cbx_Filter.FormattingEnabled = true;
            cbx_Filter.Items.AddRange(new object[] { "None", "L.D.L.AppID", "National No", "Full Name", "Status" });
            cbx_Filter.Location = new Point(87, 277);
            cbx_Filter.Name = "cbx_Filter";
            cbx_Filter.Size = new Size(184, 23);
            cbx_Filter.TabIndex = 7;
            cbx_Filter.SelectedIndexChanged += cbx_Filter_SelectedIndexChanged;
            // 
            // txt_Filter
            // 
            txt_Filter.Location = new Point(277, 277);
            txt_Filter.Name = "txt_Filter";
            txt_Filter.Size = new Size(171, 23);
            txt_Filter.TabIndex = 8;
            txt_Filter.TextChanged += txt_Filter_TextChanged;
            // 
            // btn_AddNewApplication
            // 
            btn_AddNewApplication.Image = Properties.Resources.New_Application_64;
            btn_AddNewApplication.Location = new Point(1180, 224);
            btn_AddNewApplication.Name = "btn_AddNewApplication";
            btn_AddNewApplication.Size = new Size(76, 80);
            btn_AddNewApplication.TabIndex = 9;
            btn_AddNewApplication.UseVisualStyleBackColor = true;
            btn_AddNewApplication.Click += btn_AddNewApplication_Click;
            // 
            // btn_Close
            // 
            btn_Close.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_Close.Image = Properties.Resources.Close_32;
            btn_Close.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Close.Location = new Point(1137, 665);
            btn_Close.Name = "btn_Close";
            btn_Close.Size = new Size(119, 40);
            btn_Close.TabIndex = 10;
            btn_Close.Text = "Close";
            btn_Close.UseVisualStyleBackColor = true;
            btn_Close.Click += button1_Click;
            // 
            // LocalDrivingLicenseApplications
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1268, 712);
            Controls.Add(btn_Close);
            Controls.Add(btn_AddNewApplication);
            Controls.Add(txt_Filter);
            Controls.Add(cbx_Filter);
            Controls.Add(lbl_Number_Of_Records);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dgv_Local_Driving_License_Applications);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "LocalDrivingLicenseApplications";
            ShowIcon = false;
            Text = "Local Driving License Applications";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgv_Local_Driving_License_Applications).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label1;
        private DataGridView dgv_Local_Driving_License_Applications;
        private Label label2;
        private Label label3;
        private Label lbl_Number_Of_Records;
        private ComboBox cbx_Filter;
        private TextBox txt_Filter;
        private Button btn_AddNewApplication;
        private Button btn_Close;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem showApplicationDetailsToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem editApplicationToolStripMenuItem;
        private ToolStripMenuItem deleteApplicationToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripMenuItem cancelApplicationToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripMenuItem sechduleTestsToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator6;
        private ToolStripMenuItem issueDrivingLicenseFirstTimeToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator5;
        private ToolStripMenuItem showLicenseToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator7;
        private ToolStripMenuItem showPersonalLicenseHistoryToolStripMenuItem;
        private ToolStripMenuItem schedualVisionTestToolStripMenuItem;
        private ToolStripMenuItem SchedualWritenTestToolStripMenuItem;
        private ToolStripMenuItem schedualStreetTestToolStripMenuItem;
    }
}