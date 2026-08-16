namespace DVLV.UI
{
    partial class Manage_Application_Types
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
            label1 = new Label();
            btn_Close = new Button();
            lbl_Records = new Label();
            dgv_Apllications_Types = new DataGridView();
            contextMenuStrip1 = new ContextMenuStrip(components);
            editToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgv_Apllications_Types).BeginInit();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Application_Types_512;
            pictureBox1.Location = new Point(285, 26);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(222, 210);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Firebrick;
            label1.Location = new Point(209, 239);
            label1.Name = "label1";
            label1.Size = new Size(381, 40);
            label1.TabIndex = 1;
            label1.Text = "Manage Application Types";
            // 
            // btn_Close
            // 
            btn_Close.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_Close.Image = Properties.Resources.Close_32;
            btn_Close.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Close.Location = new Point(671, 621);
            btn_Close.Name = "btn_Close";
            btn_Close.Size = new Size(117, 38);
            btn_Close.TabIndex = 3;
            btn_Close.Text = "Close";
            btn_Close.UseVisualStyleBackColor = true;
            btn_Close.Click += btn_Close_Click;
            // 
            // lbl_Records
            // 
            lbl_Records.AutoSize = true;
            lbl_Records.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_Records.Location = new Point(12, 630);
            lbl_Records.Name = "lbl_Records";
            lbl_Records.Size = new Size(80, 20);
            lbl_Records.TabIndex = 4;
            lbl_Records.Text = "# Records:";
            // 
            // dgv_Apllications_Types
            // 
            dgv_Apllications_Types.AllowUserToAddRows = false;
            dgv_Apllications_Types.AllowUserToDeleteRows = false;
            dgv_Apllications_Types.BackgroundColor = SystemColors.ButtonFace;
            dgv_Apllications_Types.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Apllications_Types.ContextMenuStrip = contextMenuStrip1;
            dgv_Apllications_Types.Location = new Point(12, 310);
            dgv_Apllications_Types.Name = "dgv_Apllications_Types";
            dgv_Apllications_Types.ReadOnly = true;
            dgv_Apllications_Types.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_Apllications_Types.Size = new Size(776, 305);
            dgv_Apllications_Types.TabIndex = 5;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { editToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(203, 42);
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.Image = Properties.Resources.edit_321;
            editToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(202, 38);
            editToolStripMenuItem.Text = "Edit Application Type";
            editToolStripMenuItem.Click += editToolStripMenuItem_Click;
            // 
            // Manage_Application_Types
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 665);
            Controls.Add(dgv_Apllications_Types);
            Controls.Add(lbl_Records);
            Controls.Add(btn_Close);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "Manage_Application_Types";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Manage Application Types";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgv_Apllications_Types).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Button btn_Close;
        private Label lbl_Records;
        private DataGridView dgv_Apllications_Types;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem editToolStripMenuItem;
    }
}