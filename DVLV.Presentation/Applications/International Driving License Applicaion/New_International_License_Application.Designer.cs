namespace DVLV.UI.Applications_Manage.International_Driving_License_Applicaion
{
    partial class New_International_License_Application
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
            label1 = new Label();
            ctr_License_Filter1 = new DVLV.UI.Licenses.ctr_License_Filter();
            ctr_Driver_License_Info1 = new DVLV.UI.Licenses.ctr_Driver_License_Info();
            ctr_Application_info1 = new ctr_Application_info();
            lnk_Show_Licenses_History = new LinkLabel();
            lnk_Show_Licenses_Info = new LinkLabel();
            btn_Close = new Button();
            btn_Issue_License = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(192, 0, 0);
            label1.Location = new Point(187, 25);
            label1.Name = "label1";
            label1.Size = new Size(418, 37);
            label1.TabIndex = 0;
            label1.Text = "International License Application";
            // 
            // ctr_License_Filter1
            // 
            ctr_License_Filter1.Location = new Point(12, 76);
            ctr_License_Filter1.Name = "ctr_License_Filter1";
            ctr_License_Filter1.Size = new Size(545, 77);
            ctr_License_Filter1.TabIndex = 1;
            ctr_License_Filter1.OnLicenseSelected += ctr_License_Filter1_OnLicenseSelected;
            // 
            // ctr_Driver_License_Info1
            // 
            ctr_Driver_License_Info1.Enabled = false;
            ctr_Driver_License_Info1.Location = new Point(12, 159);
            ctr_Driver_License_Info1.Name = "ctr_Driver_License_Info1";
            ctr_Driver_License_Info1.Size = new Size(801, 335);
            ctr_Driver_License_Info1.TabIndex = 2;
            // 
            // ctr_Application_info1
            // 
            ctr_Application_info1.Location = new Point(12, 500);
            ctr_Application_info1.Name = "ctr_Application_info1";
            ctr_Application_info1.Size = new Size(801, 205);
            ctr_Application_info1.TabIndex = 3;
            // 
            // lnk_Show_Licenses_History
            // 
            lnk_Show_Licenses_History.AutoSize = true;
            lnk_Show_Licenses_History.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lnk_Show_Licenses_History.Location = new Point(12, 708);
            lnk_Show_Licenses_History.Name = "lnk_Show_Licenses_History";
            lnk_Show_Licenses_History.Size = new Size(150, 19);
            lnk_Show_Licenses_History.TabIndex = 4;
            lnk_Show_Licenses_History.TabStop = true;
            lnk_Show_Licenses_History.Text = "Show Licenses History";
            lnk_Show_Licenses_History.LinkClicked += lnk_Show_Licenses_History_LinkClicked;
            // 
            // lnk_Show_Licenses_Info
            // 
            lnk_Show_Licenses_Info.AutoSize = true;
            lnk_Show_Licenses_Info.Enabled = false;
            lnk_Show_Licenses_Info.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lnk_Show_Licenses_Info.Location = new Point(168, 708);
            lnk_Show_Licenses_Info.Name = "lnk_Show_Licenses_Info";
            lnk_Show_Licenses_Info.Size = new Size(123, 19);
            lnk_Show_Licenses_Info.TabIndex = 5;
            lnk_Show_Licenses_Info.TabStop = true;
            lnk_Show_Licenses_Info.Text = "Show License Info";
            lnk_Show_Licenses_Info.LinkClicked += lnk_Show_Licenses_Info_LinkClicked;
            // 
            // btn_Close
            // 
            btn_Close.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            btn_Close.Image = UI.Properties.Resources.Close_32;
            btn_Close.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Close.Location = new Point(581, 708);
            btn_Close.Name = "btn_Close";
            btn_Close.Size = new Size(113, 37);
            btn_Close.TabIndex = 10;
            btn_Close.Text = "Close";
            btn_Close.UseVisualStyleBackColor = true;
            btn_Close.Click += btn_Close_Click;
            // 
            // btn_Issue_License
            // 
            btn_Issue_License.Enabled = false;
            btn_Issue_License.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            btn_Issue_License.Image = UI.Properties.Resources.International_32;
            btn_Issue_License.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Issue_License.Location = new Point(700, 708);
            btn_Issue_License.Name = "btn_Issue_License";
            btn_Issue_License.Size = new Size(113, 37);
            btn_Issue_License.TabIndex = 11;
            btn_Issue_License.Text = "Issue";
            btn_Issue_License.UseVisualStyleBackColor = true;
            btn_Issue_License.Click += btn_Issue_License_Click;
            // 
            // New_International_License_Application
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(826, 755);
            Controls.Add(btn_Issue_License);
            Controls.Add(btn_Close);
            Controls.Add(lnk_Show_Licenses_Info);
            Controls.Add(lnk_Show_Licenses_History);
            Controls.Add(ctr_Application_info1);
            Controls.Add(ctr_Driver_License_Info1);
            Controls.Add(ctr_License_Filter1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "New_International_License_Application";
            ShowIcon = false;
            Text = "New International License Application";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Licenses.ctr_License_Filter ctr_License_Filter1;
        private Licenses.ctr_Driver_License_Info ctr_Driver_License_Info1;
        private ctr_Application_info ctr_Application_info1;
        private LinkLabel lnk_Show_Licenses_History;
        private LinkLabel lnk_Show_Licenses_Info;
        private Button btn_Close;
        private Button btn_Issue_License;
    }
}