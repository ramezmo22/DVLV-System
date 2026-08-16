namespace DVLV.UI.Applications_Manage.International_Driving_License_Applicaion
{
    partial class List_International_License_Applications
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
            btn_Close = new Button();
            btn_AddNewApplication = new Button();
            txt_Filter = new TextBox();
            cbx_Filter = new ComboBox();
            lbl_Number_Of_Records = new Label();
            label3 = new Label();
            label2 = new Label();
            dgv_International_Driving_License_Applications = new DataGridView();
            contextMenuStrip1 = new ContextMenuStrip(components);
            showPersonDetailsToolStripMenuItem = new ToolStripMenuItem();
            showLicenseDetailsToolStripMenuItem = new ToolStripMenuItem();
            showPersonLicenseHistoryToolStripMenuItem = new ToolStripMenuItem();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            errorProvider1 = new ErrorProvider(components);
            cbx_isActive = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgv_International_Driving_License_Applications).BeginInit();
            contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // btn_Close
            // 
            btn_Close.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_Close.Image = Properties.Resources.Close_32;
            btn_Close.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Close.Location = new Point(1137, 663);
            btn_Close.Name = "btn_Close";
            btn_Close.Size = new Size(119, 40);
            btn_Close.TabIndex = 21;
            btn_Close.Text = "Close";
            btn_Close.UseVisualStyleBackColor = true;
            btn_Close.Click += btn_Close_Click;
            // 
            // btn_AddNewApplication
            // 
            btn_AddNewApplication.Image = Properties.Resources.New_Application_64;
            btn_AddNewApplication.Location = new Point(1180, 222);
            btn_AddNewApplication.Name = "btn_AddNewApplication";
            btn_AddNewApplication.Size = new Size(76, 80);
            btn_AddNewApplication.TabIndex = 20;
            btn_AddNewApplication.UseVisualStyleBackColor = true;
            btn_AddNewApplication.Click += btn_AddNewApplication_Click_1;
            // 
            // txt_Filter
            // 
            txt_Filter.Location = new Point(277, 275);
            txt_Filter.Name = "txt_Filter";
            txt_Filter.Size = new Size(171, 23);
            txt_Filter.TabIndex = 19;
            txt_Filter.Visible = false;
            txt_Filter.TextChanged += txt_Filter_TextChanged;
            // 
            // cbx_Filter
            // 
            cbx_Filter.DropDownStyle = ComboBoxStyle.DropDownList;
            cbx_Filter.FormattingEnabled = true;
            cbx_Filter.Items.AddRange(new object[] { "None", "I.License ID", "Driver ID", "L.LicenseID", "Is Active" });
            cbx_Filter.Location = new Point(87, 275);
            cbx_Filter.Name = "cbx_Filter";
            cbx_Filter.Size = new Size(184, 23);
            cbx_Filter.TabIndex = 18;
            cbx_Filter.SelectedIndexChanged += cbx_Filter_SelectedIndexChanged;
            // 
            // lbl_Number_Of_Records
            // 
            lbl_Number_Of_Records.AutoSize = true;
            lbl_Number_Of_Records.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_Number_Of_Records.Location = new Point(98, 663);
            lbl_Number_Of_Records.Name = "lbl_Number_Of_Records";
            lbl_Number_Of_Records.Size = new Size(30, 20);
            lbl_Number_Of_Records.TabIndex = 17;
            lbl_Number_Of_Records.Text = "???";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 663);
            label3.Name = "label3";
            label3.Size = new Size(80, 20);
            label3.TabIndex = 16;
            label3.Text = "# Records:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 275);
            label2.Name = "label2";
            label2.Size = new Size(69, 20);
            label2.TabIndex = 15;
            label2.Text = "Filter By:";
            // 
            // dgv_International_Driving_License_Applications
            // 
            dgv_International_Driving_License_Applications.AllowUserToAddRows = false;
            dgv_International_Driving_License_Applications.AllowUserToDeleteRows = false;
            dgv_International_Driving_License_Applications.BackgroundColor = SystemColors.Control;
            dgv_International_Driving_License_Applications.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_International_Driving_License_Applications.ContextMenuStrip = contextMenuStrip1;
            dgv_International_Driving_License_Applications.Location = new Point(12, 308);
            dgv_International_Driving_License_Applications.MultiSelect = false;
            dgv_International_Driving_License_Applications.Name = "dgv_International_Driving_License_Applications";
            dgv_International_Driving_License_Applications.ReadOnly = true;
            dgv_International_Driving_License_Applications.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_International_Driving_License_Applications.Size = new Size(1244, 352);
            dgv_International_Driving_License_Applications.TabIndex = 14;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { showPersonDetailsToolStripMenuItem, showLicenseDetailsToolStripMenuItem, showPersonLicenseHistoryToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(242, 118);
            // 
            // showPersonDetailsToolStripMenuItem
            // 
            showPersonDetailsToolStripMenuItem.Image = Properties.Resources.PersonDetails_32;
            showPersonDetailsToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            showPersonDetailsToolStripMenuItem.Name = "showPersonDetailsToolStripMenuItem";
            showPersonDetailsToolStripMenuItem.Size = new Size(241, 38);
            showPersonDetailsToolStripMenuItem.Text = "Show Person Details";
            showPersonDetailsToolStripMenuItem.Click += showPersonDetailsToolStripMenuItem_Click;
            // 
            // showLicenseDetailsToolStripMenuItem
            // 
            showLicenseDetailsToolStripMenuItem.Image = Properties.Resources.License_View_32;
            showLicenseDetailsToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            showLicenseDetailsToolStripMenuItem.Name = "showLicenseDetailsToolStripMenuItem";
            showLicenseDetailsToolStripMenuItem.Size = new Size(241, 38);
            showLicenseDetailsToolStripMenuItem.Text = "Show License Details";
            showLicenseDetailsToolStripMenuItem.Click += showLicenseDetailsToolStripMenuItem_Click;
            // 
            // showPersonLicenseHistoryToolStripMenuItem
            // 
            showPersonLicenseHistoryToolStripMenuItem.Image = Properties.Resources.PersonLicenseHistory_321;
            showPersonLicenseHistoryToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            showPersonLicenseHistoryToolStripMenuItem.Name = "showPersonLicenseHistoryToolStripMenuItem";
            showPersonLicenseHistoryToolStripMenuItem.RightToLeftAutoMirrorImage = true;
            showPersonLicenseHistoryToolStripMenuItem.Size = new Size(241, 38);
            showPersonLicenseHistoryToolStripMenuItem.Text = "Show Person License History";
            showPersonLicenseHistoryToolStripMenuItem.Click += showPersonLicenseHistoryToolStripMenuItem_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.International_32;
            pictureBox2.Location = new Point(586, 147);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(34, 26);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 12;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Applications;
            pictureBox1.Location = new Point(524, 10);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(235, 189);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(192, 0, 0);
            label1.Location = new Point(355, 190);
            label1.Name = "label1";
            label1.Size = new Size(526, 37);
            label1.TabIndex = 13;
            label1.Text = "International Driving License Applications";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // cbx_isActive
            // 
            cbx_isActive.DropDownStyle = ComboBoxStyle.DropDownList;
            cbx_isActive.FormattingEnabled = true;
            cbx_isActive.Items.AddRange(new object[] { "Yes", "No" });
            cbx_isActive.Location = new Point(277, 275);
            cbx_isActive.Name = "cbx_isActive";
            cbx_isActive.Size = new Size(82, 23);
            cbx_isActive.TabIndex = 22;
            cbx_isActive.Visible = false;
            cbx_isActive.SelectedIndexChanged += cbx_isActive_SelectedIndexChanged;
            // 
            // List_International_License_Applications
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1268, 712);
            Controls.Add(cbx_isActive);
            Controls.Add(btn_Close);
            Controls.Add(btn_AddNewApplication);
            Controls.Add(txt_Filter);
            Controls.Add(cbx_Filter);
            Controls.Add(lbl_Number_Of_Records);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dgv_International_Driving_License_Applications);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "List_International_License_Applications";
            ShowIcon = false;
            Text = "List International License Applications";
            ((System.ComponentModel.ISupportInitialize)dgv_International_Driving_License_Applications).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_Close;
        private Button btn_AddNewApplication;
        private TextBox txt_Filter;
        private ComboBox cbx_Filter;
        private Label lbl_Number_Of_Records;
        private Label label3;
        private Label label2;
        private DataGridView dgv_International_Driving_License_Applications;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Label label1;
        private ErrorProvider errorProvider1;
        private ComboBox cbx_isActive;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem showPersonDetailsToolStripMenuItem;
        private ToolStripMenuItem showLicenseDetailsToolStripMenuItem;
        private ToolStripMenuItem showPersonLicenseHistoryToolStripMenuItem;
    }
}