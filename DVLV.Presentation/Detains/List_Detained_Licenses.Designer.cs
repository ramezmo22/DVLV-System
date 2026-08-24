using DVLV.UI.Properties;

namespace DVLV.UI.Detains
{
    partial class List_Detained_Licenses
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any Resources being used.
        /// </summary>
        /// <param name="disposing">true if managed Resources should be disposed; otherwise, false.</param>
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
            dgv_List_Detained = new DataGridView();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            btn_Detained = new Button();
            btn_Release = new Button();
            label2 = new Label();
            cmb_filter = new ComboBox();
            txt_To_Find = new TextBox();
            btn_Close = new Button();
            label3 = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            showPersonDetailsToolStripMenuItem = new ToolStripMenuItem();
            showLicenseDetailsToolStripMenuItem = new ToolStripMenuItem();
            shoePersonLicenseHistoryToolStripMenuItem = new ToolStripMenuItem();
            releaseDetainedLicenseToolStripMenuItem = new ToolStripMenuItem();
            cmb_Is_Release = new ComboBox();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)dgv_List_Detained).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // dgv_List_Detained
            // 
            dgv_List_Detained.AllowUserToAddRows = false;
            dgv_List_Detained.AllowUserToDeleteRows = false;
            dgv_List_Detained.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_List_Detained.BackgroundColor = SystemColors.Control;
            dgv_List_Detained.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_List_Detained.Location = new Point(12, 310);
            dgv_List_Detained.Name = "dgv_List_Detained";
            dgv_List_Detained.ReadOnly = true;
            dgv_List_Detained.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_List_Detained.Size = new Size(1300, 344);
            dgv_List_Detained.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Resources.Detain_512;
            pictureBox1.Location = new Point(528, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(307, 182);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(192, 0, 0);
            label1.Location = new Point(539, 206);
            label1.Name = "label1";
            label1.Size = new Size(284, 37);
            label1.TabIndex = 2;
            label1.Text = "List Detained Licenses";
            // 
            // btn_Detained
            // 
            btn_Detained.Image = Resources.Detain_64;
            btn_Detained.Location = new Point(1239, 233);
            btn_Detained.Name = "btn_Detained";
            btn_Detained.Size = new Size(73, 71);
            btn_Detained.TabIndex = 3;
            btn_Detained.UseVisualStyleBackColor = true;
            btn_Detained.Click += btn_Detained_Click;
            // 
            // btn_Release
            // 
            btn_Release.Image = Resources.Release_Detained_License_64;
            btn_Release.Location = new Point(1160, 233);
            btn_Release.Name = "btn_Release";
            btn_Release.Size = new Size(73, 71);
            btn_Release.TabIndex = 4;
            btn_Release.UseVisualStyleBackColor = true;
            btn_Release.Click += btn_Release_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 279);
            label2.Name = "label2";
            label2.Size = new Size(69, 20);
            label2.TabIndex = 5;
            label2.Text = "Filter By:";
            // 
            // cmb_filter
            // 
            cmb_filter.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_filter.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmb_filter.FormattingEnabled = true;
            cmb_filter.Items.AddRange(new object[] { "None", "Detain ID", "Is Released", "National No.", "Full Name", "Release Application ID" });
            cmb_filter.Location = new Point(87, 279);
            cmb_filter.Name = "cmb_filter";
            cmb_filter.Size = new Size(152, 25);
            cmb_filter.TabIndex = 6;
            cmb_filter.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // txt_To_Find
            // 
            txt_To_Find.Location = new Point(245, 279);
            txt_To_Find.Name = "txt_To_Find";
            txt_To_Find.Size = new Size(152, 23);
            txt_To_Find.TabIndex = 7;
            txt_To_Find.Visible = false;
            txt_To_Find.TextChanged += textBox1_TextChanged;
            // 
            // btn_Close
            // 
            btn_Close.Image = Resources.Close_32;
            btn_Close.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Close.Location = new Point(1194, 660);
            btn_Close.Name = "btn_Close";
            btn_Close.Size = new Size(118, 39);
            btn_Close.TabIndex = 20;
            btn_Close.Text = "Close";
            btn_Close.UseVisualStyleBackColor = true;
            btn_Close.Click += btn_Close_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 668);
            label3.Name = "label3";
            label3.Size = new Size(88, 20);
            label3.TabIndex = 21;
            label3.Text = "# Records : ";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { showPersonDetailsToolStripMenuItem, showLicenseDetailsToolStripMenuItem, shoePersonLicenseHistoryToolStripMenuItem, releaseDetainedLicenseToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(242, 156);
            // 
            // showPersonDetailsToolStripMenuItem
            // 
            showPersonDetailsToolStripMenuItem.Image = Resources.PersonDetails_32;
            showPersonDetailsToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            showPersonDetailsToolStripMenuItem.Name = "showPersonDetailsToolStripMenuItem";
            showPersonDetailsToolStripMenuItem.Size = new Size(241, 38);
            showPersonDetailsToolStripMenuItem.Text = "Show Person Details";
            showPersonDetailsToolStripMenuItem.Click += showPersonDetailsToolStripMenuItem_Click;
            // 
            // showLicenseDetailsToolStripMenuItem
            // 
            showLicenseDetailsToolStripMenuItem.Image = Resources.License_View_32;
            showLicenseDetailsToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            showLicenseDetailsToolStripMenuItem.Name = "showLicenseDetailsToolStripMenuItem";
            showLicenseDetailsToolStripMenuItem.Size = new Size(241, 38);
            showLicenseDetailsToolStripMenuItem.Text = "Show License Details";
            showLicenseDetailsToolStripMenuItem.Click += showLicenseDetailsToolStripMenuItem_Click;
            // 
            // shoePersonLicenseHistoryToolStripMenuItem
            // 
            shoePersonLicenseHistoryToolStripMenuItem.Image = Resources.PersonLicenseHistory_32;
            shoePersonLicenseHistoryToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            shoePersonLicenseHistoryToolStripMenuItem.Name = "shoePersonLicenseHistoryToolStripMenuItem";
            shoePersonLicenseHistoryToolStripMenuItem.Size = new Size(241, 38);
            shoePersonLicenseHistoryToolStripMenuItem.Text = "Show Person License History";
            shoePersonLicenseHistoryToolStripMenuItem.Click += showPersonLicenseHistoryToolStripMenuItem_Click;
            // 
            // releaseDetainedLicenseToolStripMenuItem
            // 
            releaseDetainedLicenseToolStripMenuItem.Image = Resources.Release_Detained_License_32;
            releaseDetainedLicenseToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            releaseDetainedLicenseToolStripMenuItem.Name = "releaseDetainedLicenseToolStripMenuItem";
            releaseDetainedLicenseToolStripMenuItem.Size = new Size(241, 38);
            releaseDetainedLicenseToolStripMenuItem.Text = "Release Detained License";
            releaseDetainedLicenseToolStripMenuItem.Click += releaseDetainedLicenseToolStripMenuItem_Click;
            // 
            // cmb_Is_Release
            // 
            cmb_Is_Release.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_Is_Release.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmb_Is_Release.FormattingEnabled = true;
            cmb_Is_Release.Items.AddRange(new object[] { "Yes", "No" });
            cmb_Is_Release.Location = new Point(245, 278);
            cmb_Is_Release.Name = "cmb_Is_Release";
            cmb_Is_Release.Size = new Size(67, 25);
            cmb_Is_Release.TabIndex = 22;
            cmb_Is_Release.Visible = false;
            cmb_Is_Release.SelectedIndexChanged += cmb_Is_Release_SelectedIndexChanged;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // List_Detained_Licenses
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1326, 705);
            Controls.Add(cmb_Is_Release);
            Controls.Add(label3);
            Controls.Add(btn_Close);
            Controls.Add(txt_To_Find);
            Controls.Add(cmb_filter);
            Controls.Add(label2);
            Controls.Add(btn_Release);
            Controls.Add(btn_Detained);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(dgv_List_Detained);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "List_Detained_Licenses";
            ShowIcon = false;
            ShowInTaskbar = false;
            SizeGripStyle = SizeGripStyle.Show;
            Text = "List Detained Licenses";
            ((System.ComponentModel.ISupportInitialize)dgv_List_Detained).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgv_List_Detained;
        private PictureBox pictureBox1;
        private Label label1;
        private Button btn_Detained;
        private Button btn_Release;
        private Label label2;
        private ComboBox cmb_filter;
        private TextBox txt_To_Find;
        private Button btn_Close;
        private Label label3;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem showPersonDetailsToolStripMenuItem;
        private ToolStripMenuItem showLicenseDetailsToolStripMenuItem;
        private ToolStripMenuItem shoePersonLicenseHistoryToolStripMenuItem;
        private ToolStripMenuItem releaseDetainedLicenseToolStripMenuItem;
        private ComboBox cmb_Is_Release;
        private ErrorProvider errorProvider1;
    }
}