using DVLV.UI.Properties;

namespace DVLV.UI
{
    partial class List_Test_Types
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
            dgv_Test_Types = new DataGridView();
            contextMenuStrip1 = new ContextMenuStrip(components);
            editToolStripMenuItem = new ToolStripMenuItem();
            lbl_Records = new Label();
            btn_Close = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgv_Test_Types).BeginInit();
            contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dgv_Test_Types
            // 
            dgv_Test_Types.AllowUserToAddRows = false;
            dgv_Test_Types.AllowUserToDeleteRows = false;
            dgv_Test_Types.BackgroundColor = SystemColors.ButtonFace;
            dgv_Test_Types.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Test_Types.ContextMenuStrip = contextMenuStrip1;
            dgv_Test_Types.Location = new Point(13, 296);
            dgv_Test_Types.Name = "dgv_Test_Types";
            dgv_Test_Types.ReadOnly = true;
            dgv_Test_Types.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_Test_Types.Size = new Size(776, 305);
            dgv_Test_Types.TabIndex = 10;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { editToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(114, 42);
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.Image = Resources.edit_32;
            editToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(113, 38);
            editToolStripMenuItem.Text = "Edit ";
            editToolStripMenuItem.Click += editToolStripMenuItem_Click;
            // 
            // lbl_Records
            // 
            lbl_Records.AutoSize = true;
            lbl_Records.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_Records.Location = new Point(13, 616);
            lbl_Records.Name = "lbl_Records";
            lbl_Records.Size = new Size(80, 20);
            lbl_Records.TabIndex = 9;
            lbl_Records.Text = "# Records:";
            // 
            // btn_Close
            // 
            btn_Close.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_Close.Image = Resources.Close_32;
            btn_Close.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Close.Location = new Point(672, 607);
            btn_Close.Name = "btn_Close";
            btn_Close.Size = new Size(117, 38);
            btn_Close.TabIndex = 8;
            btn_Close.Text = "Close";
            btn_Close.UseVisualStyleBackColor = true;
            btn_Close.Click += btn_Close_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Firebrick;
            label1.Location = new Point(267, 225);
            label1.Name = "label1";
            label1.Size = new Size(278, 40);
            label1.TabIndex = 7;
            label1.Text = "Manage Test Types";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Resources.TestType_512;
            pictureBox1.Location = new Point(286, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(222, 210);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // List_Test_Types
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(815, 652);
            Controls.Add(dgv_Test_Types);
            Controls.Add(lbl_Records);
            Controls.Add(btn_Close);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "List_Test_Types";
            ShowIcon = false;
            Text = "List Test Types";
            ((System.ComponentModel.ISupportInitialize)dgv_Test_Types).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgv_Test_Types;
        private Label lbl_Records;
        private Button btn_Close;
        private Label label1;
        private PictureBox pictureBox1;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem editToolStripMenuItem;
    }
}