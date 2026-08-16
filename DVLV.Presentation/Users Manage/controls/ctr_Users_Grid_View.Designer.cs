namespace DVLV.UI
{
    partial class ctr_Users_Grid_View
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
            dgv_Users_Data = new DataGridView();
            clnUserId = new DataGridViewTextBoxColumn();
            clnPersonID = new DataGridViewTextBoxColumn();
            clnFullName = new DataGridViewTextBoxColumn();
            clnUserName = new DataGridViewTextBoxColumn();
            clnIsActive = new DataGridViewCheckBoxColumn();
            contextMenuStrip1 = new ContextMenuStrip(components);
            showDetailsToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            addNewUserToolStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            deleteToolStripMenuItem = new ToolStripMenuItem();
            changePasswordToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            sendEmailToolStripMenuItem = new ToolStripMenuItem();
            phoneCallToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)dgv_Users_Data).BeginInit();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dgv_Users_Data
            // 
            dgv_Users_Data.AllowUserToAddRows = false;
            dgv_Users_Data.AllowUserToDeleteRows = false;
            dgv_Users_Data.AllowUserToOrderColumns = true;
            dgv_Users_Data.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_Users_Data.BackgroundColor = Color.White;
            dgv_Users_Data.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Users_Data.Columns.AddRange(new DataGridViewColumn[] { clnUserId, clnPersonID, clnFullName, clnUserName, clnIsActive });
            dgv_Users_Data.ContextMenuStrip = contextMenuStrip1;
            dgv_Users_Data.Dock = DockStyle.Fill;
            dgv_Users_Data.Location = new Point(0, 0);
            dgv_Users_Data.Name = "dgv_Users_Data";
            dgv_Users_Data.ReadOnly = true;
            dgv_Users_Data.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_Users_Data.Size = new Size(767, 349);
            dgv_Users_Data.TabIndex = 0;
            dgv_Users_Data.CellContentClick += dgv_Users_Data_CellContentClick;
            // 
            // clnUserId
            // 
            clnUserId.HeaderText = "User ID";
            clnUserId.Name = "clnUserId";
            clnUserId.ReadOnly = true;
            // 
            // clnPersonID
            // 
            clnPersonID.HeaderText = "Person ID";
            clnPersonID.Name = "clnPersonID";
            clnPersonID.ReadOnly = true;
            // 
            // clnFullName
            // 
            clnFullName.HeaderText = "Full Name";
            clnFullName.Name = "clnFullName";
            clnFullName.ReadOnly = true;
            // 
            // clnUserName
            // 
            clnUserName.HeaderText = "User Name";
            clnUserName.Name = "clnUserName";
            clnUserName.ReadOnly = true;
            // 
            // clnIsActive
            // 
            clnIsActive.HeaderText = "Is Active";
            clnIsActive.Name = "clnIsActive";
            clnIsActive.ReadOnly = true;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { showDetailsToolStripMenuItem, toolStripSeparator1, addNewUserToolStripMenuItem, editToolStripMenuItem, deleteToolStripMenuItem, changePasswordToolStripMenuItem, toolStripSeparator2, sendEmailToolStripMenuItem, phoneCallToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(197, 304);
            contextMenuStrip1.Opening += contextMenuStrip1_Opening;
            // 
            // showDetailsToolStripMenuItem
            // 
            showDetailsToolStripMenuItem.Image = Properties.Resources.PersonDetails_32;
            showDetailsToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            showDetailsToolStripMenuItem.Name = "showDetailsToolStripMenuItem";
            showDetailsToolStripMenuItem.Size = new Size(196, 38);
            showDetailsToolStripMenuItem.Text = "Show Details";
            showDetailsToolStripMenuItem.Click += showDetailsToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(193, 6);
            // 
            // addNewUserToolStripMenuItem
            // 
            addNewUserToolStripMenuItem.Image = Properties.Resources.Add_New_User_32;
            addNewUserToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            addNewUserToolStripMenuItem.Name = "addNewUserToolStripMenuItem";
            addNewUserToolStripMenuItem.Size = new Size(196, 38);
            addNewUserToolStripMenuItem.Text = "Add New User";
            addNewUserToolStripMenuItem.Click += addNewUserToolStripMenuItem_Click;
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.Image = Properties.Resources.edit_32;
            editToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(196, 38);
            editToolStripMenuItem.Text = "Edit";
            editToolStripMenuItem.Click += editToolStripMenuItem_Click;
            // 
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.Image = Properties.Resources.Delete_32;
            deleteToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            deleteToolStripMenuItem.Size = new Size(196, 38);
            deleteToolStripMenuItem.Text = "Delete";
            deleteToolStripMenuItem.Click += deleteToolStripMenuItem_Click;
            // 
            // changePasswordToolStripMenuItem
            // 
            changePasswordToolStripMenuItem.Image = Properties.Resources.Password_32;
            changePasswordToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
            changePasswordToolStripMenuItem.Size = new Size(196, 38);
            changePasswordToolStripMenuItem.Text = "Change Password";
            changePasswordToolStripMenuItem.Click += changePasswordToolStripMenuItem_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(193, 6);
            // 
            // sendEmailToolStripMenuItem
            // 
            sendEmailToolStripMenuItem.Image = Properties.Resources.send_email_32;
            sendEmailToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            sendEmailToolStripMenuItem.Name = "sendEmailToolStripMenuItem";
            sendEmailToolStripMenuItem.Size = new Size(196, 38);
            sendEmailToolStripMenuItem.Text = "Send Email";
            // 
            // phoneCallToolStripMenuItem
            // 
            phoneCallToolStripMenuItem.Image = Properties.Resources.call_32;
            phoneCallToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            phoneCallToolStripMenuItem.Name = "phoneCallToolStripMenuItem";
            phoneCallToolStripMenuItem.Size = new Size(196, 38);
            phoneCallToolStripMenuItem.Text = "Phone Call";
            // 
            // ctr_Users_Grid_View
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dgv_Users_Data);
            Name = "ctr_Users_Grid_View";
            Size = new Size(767, 349);
            ((System.ComponentModel.ISupportInitialize)dgv_Users_Data).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgv_Users_Data;
        private DataGridViewTextBoxColumn clnUserId;
        private DataGridViewTextBoxColumn clnPersonID;
        private DataGridViewTextBoxColumn clnFullName;
        private DataGridViewTextBoxColumn clnUserName;
        private DataGridViewCheckBoxColumn clnIsActive;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem showDetailsToolStripMenuItem;
        private ToolStripMenuItem addNewUserToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem deleteToolStripMenuItem;
        private ToolStripMenuItem changePasswordToolStripMenuItem;
        private ToolStripMenuItem sendEmailToolStripMenuItem;
        private ToolStripMenuItem phoneCallToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripSeparator toolStripSeparator2;
    }
}
