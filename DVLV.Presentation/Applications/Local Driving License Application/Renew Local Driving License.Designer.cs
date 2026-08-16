namespace DVLV.UI.Licenses.Local_License
{
    partial class Renew_Local_Driving_License
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
            label1 = new Label();
            ctr_Driver_License_Info1 = new ctr_Driver_License_Info();
            ctr_Application_New_License_info1 = new ctr_Application_New_License_info();
            btn_Renew_License = new Button();
            btn_Close = new Button();
            lnk_Show_License_history = new LinkLabel();
            btn_Show_New_License_Info = new LinkLabel();
            ctr_License_Filter1 = new ctr_License_Filter();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(192, 0, 0);
            label1.Location = new Point(214, 9);
            label1.Name = "label1";
            label1.Size = new Size(388, 40);
            label1.TabIndex = 0;
            label1.Text = "Renew Local Driving License";
            // 
            // ctr_Driver_License_Info1
            // 
            ctr_Driver_License_Info1.Enabled = false;
            ctr_Driver_License_Info1.Location = new Point(9, 135);
            ctr_Driver_License_Info1.Name = "ctr_Driver_License_Info1";
            ctr_Driver_License_Info1.Size = new Size(801, 335);
            ctr_Driver_License_Info1.TabIndex = 1;
            ctr_Driver_License_Info1.Load += ctr_Driver_License_Info1_Load;
            // 
            // ctr_Application_New_License_info1
            // 
            ctr_Application_New_License_info1.Enabled = false;
            ctr_Application_New_License_info1.Location = new Point(9, 476);
            ctr_Application_New_License_info1.Name = "ctr_Application_New_License_info1";
            ctr_Application_New_License_info1.Size = new Size(801, 327);
            ctr_Application_New_License_info1.TabIndex = 3;
            // 
            // btn_Renew_License
            // 
            btn_Renew_License.Enabled = false;
            btn_Renew_License.Image = Properties.Resources.Renew_Driving_License_322;
            btn_Renew_License.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Renew_License.Location = new Point(692, 809);
            btn_Renew_License.Name = "btn_Renew_License";
            btn_Renew_License.Size = new Size(118, 39);
            btn_Renew_License.TabIndex = 4;
            btn_Renew_License.Text = "Renew";
            btn_Renew_License.UseVisualStyleBackColor = true;
            // 
            // btn_Close
            // 
            btn_Close.Image = Properties.Resources.Close_32;
            btn_Close.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Close.Location = new Point(568, 809);
            btn_Close.Name = "btn_Close";
            btn_Close.Size = new Size(118, 39);
            btn_Close.TabIndex = 5;
            btn_Close.Text = "Close";
            btn_Close.UseVisualStyleBackColor = true;
            btn_Close.Click += btn_Close_Click_1;
            // 
            // lnk_Show_License_history
            // 
            lnk_Show_License_history.AutoSize = true;
            lnk_Show_License_history.Enabled = false;
            lnk_Show_License_history.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lnk_Show_License_history.Location = new Point(12, 809);
            lnk_Show_License_history.Name = "lnk_Show_License_history";
            lnk_Show_License_history.Size = new Size(148, 20);
            lnk_Show_License_history.TabIndex = 6;
            lnk_Show_License_history.TabStop = true;
            lnk_Show_License_history.Text = "Show License History";
            // 
            // btn_Show_New_License_Info
            // 
            btn_Show_New_License_Info.AutoSize = true;
            btn_Show_New_License_Info.Enabled = false;
            btn_Show_New_License_Info.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_Show_New_License_Info.Location = new Point(166, 809);
            btn_Show_New_License_Info.Name = "btn_Show_New_License_Info";
            btn_Show_New_License_Info.Size = new Size(161, 20);
            btn_Show_New_License_Info.TabIndex = 7;
            btn_Show_New_License_Info.TabStop = true;
            btn_Show_New_License_Info.Text = "Show New License Info";
            btn_Show_New_License_Info.LinkClicked += btn_Show_New_License_Info_LinkClicked;
            // 
            // ctr_License_Filter1
            // 
            ctr_License_Filter1.Location = new Point(12, 52);
            ctr_License_Filter1.Name = "ctr_License_Filter1";
            ctr_License_Filter1.Size = new Size(545, 77);
            ctr_License_Filter1.TabIndex = 8;
            ctr_License_Filter1.OnLicenseSelected += ctr_License_Filter1_OnLicenseSelected;
            // 
            // Renew_Local_Driving_License
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(822, 860);
            Controls.Add(ctr_License_Filter1);
            Controls.Add(btn_Show_New_License_Info);
            Controls.Add(lnk_Show_License_history);
            Controls.Add(btn_Close);
            Controls.Add(btn_Renew_License);
            Controls.Add(ctr_Application_New_License_info1);
            Controls.Add(ctr_Driver_License_Info1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "Renew_Local_Driving_License";
            ShowIcon = false;
            ShowInTaskbar = false;
            Text = "Renew Local Driving License";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ctr_Driver_License_Info ctr_Driver_License_Info1;
        private ctr_Application_New_License_info ctr_Application_New_License_info1;
        private Button btn_Renew_License;
        private Button btn_Close;
        private LinkLabel lnk_Show_License_history;
        private LinkLabel btn_Show_New_License_Info;
        private ctr_License_Filter ctr_License_Filter1;
    }
}