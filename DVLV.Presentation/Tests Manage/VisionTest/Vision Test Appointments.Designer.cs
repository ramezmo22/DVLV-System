namespace DVLV.UI.Tests_Manage
{
    partial class Vision_Test_Appointments
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
            driving_License_Application_Info1 = new DVLV.UI.controlls.Driving_License_Application_Info();
            lbl_header = new Label();
            pictureBox1 = new PictureBox();
            ctr_Application_basic_Info1 = new DVLV.UI.controlls.ctr_Application_basic_Info();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            contextMenuStrip1 = new ContextMenuStrip(components);
            editToolStripMenuItem = new ToolStripMenuItem();
            takeTestToolStripMenuItem = new ToolStripMenuItem();
            button1 = new Button();
            btn_Add_Appointment = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // driving_License_Application_Info1
            // 
            driving_License_Application_Info1.Location = new Point(5, 124);
            driving_License_Application_Info1.Name = "driving_License_Application_Info1";
            driving_License_Application_Info1.Size = new Size(812, 135);
            driving_License_Application_Info1.TabIndex = 0;
            // 
            // lbl_header
            // 
            lbl_header.AutoSize = true;
            lbl_header.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_header.ForeColor = Color.Firebrick;
            lbl_header.Location = new Point(266, 79);
            lbl_header.Name = "lbl_header";
            lbl_header.Size = new Size(290, 32);
            lbl_header.TabIndex = 1;
            lbl_header.Text = "Vision Test Appointments";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Vision_512;
            pictureBox1.Location = new Point(346, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(130, 76);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // ctr_Application_basic_Info1
            // 
            ctr_Application_basic_Info1.Location = new Point(5, 264);
            ctr_Application_basic_Info1.Name = "ctr_Application_basic_Info1";
            ctr_Application_basic_Info1.Size = new Size(812, 203);
            ctr_Application_basic_Info1.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(5, 479);
            label1.Name = "label1";
            label1.Size = new Size(109, 20);
            label1.TabIndex = 4;
            label1.Text = "Appointments:";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.ContextMenuStrip = contextMenuStrip1;
            dataGridView1.Location = new Point(5, 514);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(812, 192);
            dataGridView1.TabIndex = 5;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { editToolStripMenuItem, takeTestToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(197, 102);
            contextMenuStrip1.Opening += contextMenuStrip1_Opening;
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
            // takeTestToolStripMenuItem
            // 
            takeTestToolStripMenuItem.Image = Properties.Resources.Test_32;
            takeTestToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            takeTestToolStripMenuItem.Name = "takeTestToolStripMenuItem";
            takeTestToolStripMenuItem.Size = new Size(196, 38);
            takeTestToolStripMenuItem.Text = "Take Test";
            takeTestToolStripMenuItem.Click += takeTestToolStripMenuItem_Click;
            // 
            // button1
            // 
            button1.Image = Properties.Resources.Close_32;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(699, 712);
            button1.Name = "button1";
            button1.Size = new Size(118, 37);
            button1.TabIndex = 6;
            button1.Text = "Close";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btn_Add_Appointment
            // 
            btn_Add_Appointment.Image = Properties.Resources.AddAppointment_32;
            btn_Add_Appointment.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Add_Appointment.Location = new Point(775, 471);
            btn_Add_Appointment.Name = "btn_Add_Appointment";
            btn_Add_Appointment.Size = new Size(42, 37);
            btn_Add_Appointment.TabIndex = 7;
            btn_Add_Appointment.UseVisualStyleBackColor = true;
            btn_Add_Appointment.Click += btn_Add_Appointment_Click;
            // 
            // Vision_Test_Appointments
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(824, 761);
            Controls.Add(btn_Add_Appointment);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Controls.Add(ctr_Application_basic_Info1);
            Controls.Add(pictureBox1);
            Controls.Add(lbl_header);
            Controls.Add(driving_License_Application_Info1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "Vision_Test_Appointments";
            ShowIcon = false;
            Text = "Vision Test Appointments";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private controlls.Driving_License_Application_Info driving_License_Application_Info1;
        private Label lbl_header;
        private PictureBox pictureBox1;
        private controlls.ctr_Application_basic_Info ctr_Application_basic_Info1;
        private Label label1;
        private DataGridView dataGridView1;
        private Button button1;
        private Button btn_Add_Appointment;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem takeTestToolStripMenuItem;
    }
}