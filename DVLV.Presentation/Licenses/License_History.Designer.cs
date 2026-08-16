namespace DVLV.UI.Licenses
{
    partial class License_History
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
            pictureBox1 = new PictureBox();
            ctr_Person_Info1 = new ctr_Person_Info();
            label1 = new Label();
            button1 = new Button();
            ctr_Driver_Licenses1 = new DVLV.UI.Drivers.ctr_Driver_Licenses();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.PersonLicenseHistory_512;
            pictureBox1.Location = new Point(29, 78);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(190, 204);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // ctr_Person_Info1
            // 
            ctr_Person_Info1.Location = new Point(225, 78);
            ctr_Person_Info1.Name = "ctr_Person_Info1";
            ctr_Person_Info1.Size = new Size(819, 366);
            ctr_Person_Info1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(192, 0, 0);
            label1.Location = new Point(452, 28);
            label1.Name = "label1";
            label1.Size = new Size(203, 37);
            label1.TabIndex = 2;
            label1.Text = "License History";
            // 
            // button1
            // 
            button1.Image = Properties.Resources.Close_32;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(941, 743);
            button1.Name = "button1";
            button1.Size = new Size(103, 35);
            button1.TabIndex = 3;
            button1.Text = "Close";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // ctr_Driver_Licenses1
            // 
            ctr_Driver_Licenses1.Location = new Point(12, 450);
            ctr_Driver_Licenses1.Name = "ctr_Driver_Licenses1";
            ctr_Driver_Licenses1.Size = new Size(1032, 282);
            ctr_Driver_Licenses1.TabIndex = 4;
            // 
            // License_History
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1056, 790);
            Controls.Add(ctr_Driver_Licenses1);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(ctr_Person_Info1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "License_History";
            ShowIcon = false;
            ShowInTaskbar = false;
            Text = "License History";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private ctr_Person_Info ctr_Person_Info1;
        private Label label1;
        private Button button1;
        private Drivers.ctr_Driver_Licenses ctr_Driver_Licenses1;
    }
}