using DVLV.UI.Properties;

namespace DVLV.UI.Licenses
{
    partial class License_Info
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
            btn_Close = new Button();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            ctr_Driver_License_Info1 = new ctr_Driver_License_Info();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btn_Close
            // 
            btn_Close.Font = new Font("Segoe UI", 10F);
            btn_Close.Image = Resources.Close_32;
            btn_Close.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Close.Location = new Point(679, 516);
            btn_Close.Name = "btn_Close";
            btn_Close.Size = new Size(110, 36);
            btn_Close.TabIndex = 0;
            btn_Close.Text = "Close";
            btn_Close.UseVisualStyleBackColor = true;
            btn_Close.Click += btn_Close_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Resources.LicenseView_400;
            pictureBox1.Location = new Point(300, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(170, 110);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            //pictureBox1.Click += pictureBox1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Firebrick;
            label1.Location = new Point(268, 116);
            label1.Name = "label1";
            label1.Size = new Size(243, 37);
            label1.TabIndex = 2;
            label1.Text = "Driver License Info";
            // 
            // ctr_Driver_License_Info1
            // 
            ctr_Driver_License_Info1.Location = new Point(12, 165);
            ctr_Driver_License_Info1.Name = "ctr_Driver_License_Info1";
            ctr_Driver_License_Info1.Size = new Size(777, 335);
            ctr_Driver_License_Info1.TabIndex = 3;
            // 
            // License_Info
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(805, 563);
            Controls.Add(ctr_Driver_License_Info1);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(btn_Close);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "License_Info";
            ShowIcon = false;
            ShowInTaskbar = false;
            Text = "License Info";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_Close;
        private PictureBox pictureBox1;
        private Label label1;
        private ctr_Driver_License_Info ctr_Driver_License_Info1;
    }
}