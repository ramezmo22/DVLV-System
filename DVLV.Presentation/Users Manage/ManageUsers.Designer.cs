using DVLV.UI.Properties;

namespace DVLV.UI
{
    partial class ManageUsers
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
            pictureBox1 = new PictureBox();
            btn_Add_User = new Button();
            label1 = new Label();
            cbx_Filter_Selection = new ComboBox();
            label2 = new Label();
            txt_Filter_Value = new TextBox();
            cbx_Is_Active = new ComboBox();
            lbl_Records_Header = new Label();
            dgv_Users_Data = new DataGridView();
            contextMenuStrip1 = new ContextMenuStrip(components);
            showDetailesToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            addNewUserToolStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            deleteToolStripMenuItem = new ToolStripMenuItem();
            changePasswordToolStripMenuItem = new ToolStripMenuItem();
            lbl_Records_Value = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgv_Users_Data).BeginInit();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Resources.Users_2_400;
            pictureBox1.Location = new Point(411, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(204, 191);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // btn_Add_User
            // 
            btn_Add_User.Anchor = AnchorStyles.Right;
            btn_Add_User.Image = Resources.Add_New_User_72;
            btn_Add_User.Location = new Point(950, 282);
            btn_Add_User.Name = "btn_Add_User";
            btn_Add_User.Size = new Size(66, 71);
            btn_Add_User.TabIndex = 10;
            btn_Add_User.UseVisualStyleBackColor = true;
            btn_Add_User.Click += btn_Add_User_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(32, 321);
            label1.Name = "label1";
            label1.Size = new Size(76, 23);
            label1.TabIndex = 13;
            label1.Text = "Filter By:";
            // 
            // cbx_Filter_Selection
            // 
            cbx_Filter_Selection.BackColor = SystemColors.Control;
            cbx_Filter_Selection.DropDownStyle = ComboBoxStyle.DropDownList;
            cbx_Filter_Selection.FormattingEnabled = true;
            cbx_Filter_Selection.Items.AddRange(new object[] { "None", "User ID", "Person ID", "Full Name", "UserName", "Is Active" });
            cbx_Filter_Selection.Location = new Point(113, 323);
            cbx_Filter_Selection.Name = "cbx_Filter_Selection";
            cbx_Filter_Selection.Size = new Size(184, 23);
            cbx_Filter_Selection.TabIndex = 14;
            cbx_Filter_Selection.SelectedIndexChanged += cbx_Filter_Selection_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Brown;
            label2.Location = new Point(400, 206);
            label2.Name = "label2";
            label2.Size = new Size(228, 45);
            label2.TabIndex = 15;
            label2.Text = "Manage Users";
            // 
            // txt_Filter_Value
            // 
            txt_Filter_Value.BackColor = SystemColors.Control;
            txt_Filter_Value.Location = new Point(303, 323);
            txt_Filter_Value.Name = "txt_Filter_Value";
            txt_Filter_Value.Size = new Size(175, 23);
            txt_Filter_Value.TabIndex = 16;
            txt_Filter_Value.Visible = false;
            txt_Filter_Value.TextChanged += txt_Filter_Value_TextChanged;
            // 
            // cbx_Is_Active
            // 
            cbx_Is_Active.BackColor = SystemColors.Control;
            cbx_Is_Active.DropDownStyle = ComboBoxStyle.DropDownList;
            cbx_Is_Active.FormattingEnabled = true;
            cbx_Is_Active.ItemHeight = 15;
            cbx_Is_Active.Items.AddRange(new object[] { "All", "Yes", "No" });
            cbx_Is_Active.Location = new Point(303, 323);
            cbx_Is_Active.Name = "cbx_Is_Active";
            cbx_Is_Active.Size = new Size(79, 23);
            cbx_Is_Active.TabIndex = 17;
            cbx_Is_Active.Visible = false;
            cbx_Is_Active.SelectedIndexChanged += cbx_Is_Active_SelectedIndexChanged;
            // 
            // lbl_Records_Header
            // 
            lbl_Records_Header.AutoSize = true;
            lbl_Records_Header.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_Records_Header.Location = new Point(32, 636);
            lbl_Records_Header.Name = "lbl_Records_Header";
            lbl_Records_Header.Size = new Size(87, 21);
            lbl_Records_Header.TabIndex = 19;
            lbl_Records_Header.Text = "# Records:";
            // 
            // dgv_Users_Data
            // 
            dgv_Users_Data.AllowUserToAddRows = false;
            dgv_Users_Data.AllowUserToDeleteRows = false;
            dgv_Users_Data.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_Users_Data.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dgv_Users_Data.BackgroundColor = SystemColors.Control;
            dgv_Users_Data.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Users_Data.ContextMenuStrip = contextMenuStrip1;
            dgv_Users_Data.Location = new Point(32, 359);
            dgv_Users_Data.Name = "dgv_Users_Data";
            dgv_Users_Data.ReadOnly = true;
            dgv_Users_Data.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_Users_Data.Size = new Size(984, 267);
            dgv_Users_Data.TabIndex = 20;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { showDetailesToolStripMenuItem, toolStripSeparator1, addNewUserToolStripMenuItem, editToolStripMenuItem, deleteToolStripMenuItem, changePasswordToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(185, 200);
            contextMenuStrip1.Opening += contextMenuStrip1_Opening;
            // 
            // showDetailesToolStripMenuItem
            // 
            showDetailesToolStripMenuItem.Image = Resources.PersonDetails_32;
            showDetailesToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            showDetailesToolStripMenuItem.Name = "showDetailesToolStripMenuItem";
            showDetailesToolStripMenuItem.Size = new Size(184, 38);
            showDetailesToolStripMenuItem.Text = "Show Detailes";
            showDetailesToolStripMenuItem.Click += showDetailsToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(181, 6);
            // 
            // addNewUserToolStripMenuItem
            // 
            addNewUserToolStripMenuItem.Image = Resources.Add_New_User_32;
            addNewUserToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            addNewUserToolStripMenuItem.Name = "addNewUserToolStripMenuItem";
            addNewUserToolStripMenuItem.Size = new Size(184, 38);
            addNewUserToolStripMenuItem.Text = "Add New User";
            addNewUserToolStripMenuItem.Click += addNewUserToolStripMenuItem_Click;
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.Image = Resources.edit_32;
            editToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(184, 38);
            editToolStripMenuItem.Text = "Edit";
            editToolStripMenuItem.Click += editToolStripMenuItem_Click;
            // 
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.Image = Resources.Delete_32;
            deleteToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            deleteToolStripMenuItem.Size = new Size(184, 38);
            deleteToolStripMenuItem.Text = "Delete";
            deleteToolStripMenuItem.Click += deleteToolStripMenuItem_Click;
            // 
            // changePasswordToolStripMenuItem
            // 
            changePasswordToolStripMenuItem.Image = Resources.Password_32;
            changePasswordToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
            changePasswordToolStripMenuItem.Size = new Size(184, 38);
            changePasswordToolStripMenuItem.Text = "Change Password";
            changePasswordToolStripMenuItem.Click += changePasswordToolStripMenuItem_Click;
            // 
            // lbl_Records_Value
            // 
            lbl_Records_Value.AutoSize = true;
            lbl_Records_Value.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_Records_Value.Location = new Point(125, 636);
            lbl_Records_Value.Name = "lbl_Records_Value";
            lbl_Records_Value.Size = new Size(28, 21);
            lbl_Records_Value.TabIndex = 21;
            lbl_Records_Value.Text = "00";
            // 
            // ManageUsers
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1042, 690);
            Controls.Add(lbl_Records_Value);
            Controls.Add(dgv_Users_Data);
            Controls.Add(lbl_Records_Header);
            Controls.Add(cbx_Is_Active);
            Controls.Add(txt_Filter_Value);
            Controls.Add(label2);
            Controls.Add(cbx_Filter_Selection);
            Controls.Add(label1);
            Controls.Add(btn_Add_User);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "ManageUsers";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Manage Users";
            Load += ManageUsers_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgv_Users_Data).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button btn_Add_User;
        private Label label1;
        private ComboBox cbx_Filter_Selection;
        private Label label2;
        private TextBox txt_Filter_Value;
        private ComboBox cbx_Is_Active;
        private Label lbl_Records_Header;
        private DataGridView dgv_Users_Data;
        private Label lbl_Records_Value;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem showDetailesToolStripMenuItem;
        private ToolStripMenuItem addNewUserToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem deleteToolStripMenuItem;
        private ToolStripMenuItem changePasswordToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
    }
}