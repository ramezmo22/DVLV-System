using DVLV.UI.Properties;

namespace DVLV.UI.Licenses.International_License
{
    partial class Driver_Information_License_Info
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
            label1 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            ctr_Driver_International_License_Info1 = new ctr_Driver_International_License_Info();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // btn_Close
            // 
            btn_Close.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            btn_Close.Image = Resources.Close_32;
            btn_Close.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Close.Location = new Point(710, 442);
            btn_Close.Name = "btn_Close";
            btn_Close.Size = new Size(113, 37);
            btn_Close.TabIndex = 11;
            btn_Close.Text = "Close";
            btn_Close.UseVisualStyleBackColor = true;
            btn_Close.Click += btn_Close_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(192, 0, 0);
            label1.Location = new Point(186, 150);
            label1.Name = "label1";
            label1.Size = new Size(408, 37);
            label1.TabIndex = 12;
            label1.Text = "Driver International License Info";
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.Image = Resources.LicenseView_4001;
            pictureBox1.Location = new Point(320, 12);
            pictureBox1.Margin = new Padding(4, 3, 4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(182, 139);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox2.Image = Resources.International_32;
            pictureBox2.Location = new Point(393, 125);
            pictureBox2.Margin = new Padding(4, 3, 4, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(26, 22);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 14;
            pictureBox2.TabStop = false;
            // 
            // ctr_Driver_International_License_Info1
            // 
            ctr_Driver_International_License_Info1.Location = new Point(12, 190);
            ctr_Driver_International_License_Info1.Name = "ctr_Driver_International_License_Info1";
            ctr_Driver_International_License_Info1.Size = new Size(811, 246);
            ctr_Driver_International_License_Info1.TabIndex = 15;
            // 
            // Driver_Information_License_Info
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(833, 486);
            Controls.Add(ctr_Driver_International_License_Info1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(btn_Close);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "Driver_Information_License_Info";
            ShowIcon = false;
            ShowInTaskbar = false;
            Text = "Driver Information License Info";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_Close;
        private Label label1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private ctr_Driver_International_License_Info ctr_Driver_International_License_Info1;
    }
}