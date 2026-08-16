namespace DVLV.UI.Licenses
{
    partial class Issue_Driver_License_For_The_First_Time
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
            ctr_Application_basic_Info1 = new DVLV.UI.controlls.ctr_Application_basic_Info();
            driving_License_Application_Info1 = new DVLV.UI.controlls.Driving_License_Application_Info();
            txt_Notes = new TextBox();
            lbl_Notes = new Label();
            pictureBox1 = new PictureBox();
            btn_Close = new Button();
            btn_License_Issue = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // ctr_Application_basic_Info1
            // 
            ctr_Application_basic_Info1.Location = new Point(12, 159);
            ctr_Application_basic_Info1.Name = "ctr_Application_basic_Info1";
            ctr_Application_basic_Info1.Size = new Size(799, 203);
            ctr_Application_basic_Info1.TabIndex = 0;
            // 
            // driving_License_Application_Info1
            // 
            driving_License_Application_Info1.Location = new Point(12, 12);
            driving_License_Application_Info1.Name = "driving_License_Application_Info1";
            driving_License_Application_Info1.Size = new Size(799, 141);
            driving_License_Application_Info1.TabIndex = 1;
            // 
            // txt_Notes
            // 
            txt_Notes.Location = new Point(113, 382);
            txt_Notes.Multiline = true;
            txt_Notes.Name = "txt_Notes";
            txt_Notes.Size = new Size(698, 124);
            txt_Notes.TabIndex = 2;
            // 
            // lbl_Notes
            // 
            lbl_Notes.AutoSize = true;
            lbl_Notes.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_Notes.Location = new Point(12, 385);
            lbl_Notes.Name = "lbl_Notes";
            lbl_Notes.Size = new Size(58, 21);
            lbl_Notes.TabIndex = 3;
            lbl_Notes.Text = "Notes:";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Notes_32;
            pictureBox1.Location = new Point(72, 381);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(32, 32);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // btn_Close
            // 
            btn_Close.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_Close.Image = Properties.Resources.Close_32;
            btn_Close.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Close.Location = new Point(566, 512);
            btn_Close.Name = "btn_Close";
            btn_Close.Size = new Size(119, 40);
            btn_Close.TabIndex = 11;
            btn_Close.Text = "Close";
            btn_Close.UseVisualStyleBackColor = true;
            btn_Close.Click += btn_Close_Click;
            // 
            // btn_License_Issue
            // 
            btn_License_Issue.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_License_Issue.Image = Properties.Resources.License_Type_32;
            btn_License_Issue.ImageAlign = ContentAlignment.MiddleLeft;
            btn_License_Issue.Location = new Point(692, 512);
            btn_License_Issue.Name = "btn_License_Issue";
            btn_License_Issue.Size = new Size(119, 40);
            btn_License_Issue.TabIndex = 12;
            btn_License_Issue.Text = "Issue";
            btn_License_Issue.UseVisualStyleBackColor = true;
            btn_License_Issue.Click += btn_License_Issue_Click;
            // 
            // Issue_Driver_License_For_The_First_Time
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(826, 566);
            Controls.Add(btn_License_Issue);
            Controls.Add(btn_Close);
            Controls.Add(pictureBox1);
            Controls.Add(lbl_Notes);
            Controls.Add(txt_Notes);
            Controls.Add(driving_License_Application_Info1);
            Controls.Add(ctr_Application_basic_Info1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "Issue_Driver_License_For_The_First_Time";
            ShowIcon = false;
            ShowInTaskbar = false;
            Text = "Issue Driver License For The First Time";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private controlls.ctr_Application_basic_Info ctr_Application_basic_Info1;
        private controlls.Driving_License_Application_Info driving_License_Application_Info1;
        private TextBox txt_Notes;
        private Label lbl_Notes;
        private PictureBox pictureBox1;
        private Button btn_Close;
        private Button btn_License_Issue;
    }
}