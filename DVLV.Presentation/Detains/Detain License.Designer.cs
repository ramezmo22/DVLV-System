using DVLV.UI.Properties;

namespace DVLV.UI
{
    partial class Detain_License
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
            ctr_License_Filter1 = new DVLV.UI.Licenses.ctr_License_Filter();
            lnk_Show_License_history = new LinkLabel();
            btn_Close = new Button();
            btn_Detain_License = new Button();
            label1 = new Label();
            ctr_Detain_License_Info1 = new DVLV.UI.Detains.ctr_Detain_License_Info();
            ctr_detain_info1 = new DVLV.UI.Detains.ctr_detain_info();
            lnk_Show_License_Info = new LinkLabel();
            SuspendLayout();
            // 
            // ctr_License_Filter1
            // 
            ctr_License_Filter1.Location = new Point(12, 52);
            ctr_License_Filter1.Name = "ctr_License_Filter1";
            ctr_License_Filter1.Size = new Size(545, 77);
            ctr_License_Filter1.TabIndex = 13;
            ctr_License_Filter1.OnLicenseSelected += ctr_License_Filter1_OnLicenseSelected;
            // 
            // lnk_Show_License_history
            // 
            lnk_Show_License_history.AutoSize = true;
            lnk_Show_License_history.Enabled = false;
            lnk_Show_License_history.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lnk_Show_License_history.Location = new Point(12, 659);
            lnk_Show_License_history.Name = "lnk_Show_License_history";
            lnk_Show_License_history.Size = new Size(148, 20);
            lnk_Show_License_history.TabIndex = 11;
            lnk_Show_License_history.TabStop = true;
            lnk_Show_License_history.Text = "Show License History";
            lnk_Show_License_history.LinkClicked += lnk_Show_License_history_LinkClicked;
            // 
            // btn_Close
            // 
            btn_Close.Image = Resources.Close_32;
            btn_Close.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Close.Location = new Point(582, 659);
            btn_Close.Name = "btn_Close";
            btn_Close.Size = new Size(118, 39);
            btn_Close.TabIndex = 10;
            btn_Close.Text = "Close";
            btn_Close.UseVisualStyleBackColor = true;
            btn_Close.Click += btn_Close_Click;
            // 
            // btn_Detain_License
            // 
            btn_Detain_License.Enabled = false;
            btn_Detain_License.Image = Resources.International_32;
            btn_Detain_License.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Detain_License.Location = new Point(706, 659);
            btn_Detain_License.Name = "btn_Detain_License";
            btn_Detain_License.Size = new Size(118, 39);
            btn_Detain_License.TabIndex = 9;
            btn_Detain_License.Text = "Detain";
            btn_Detain_License.UseVisualStyleBackColor = true;
            btn_Detain_License.Click += btn_Detain_License_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(192, 0, 0);
            label1.Location = new Point(303, 9);
            label1.Name = "label1";
            label1.Size = new Size(207, 40);
            label1.TabIndex = 14;
            label1.Text = "Detain License";
            // 
            // ctr_Detain_License_Info1
            // 
            ctr_Detain_License_Info1.Location = new Point(12, 135);
            ctr_Detain_License_Info1.Name = "ctr_Detain_License_Info1";
            ctr_Detain_License_Info1.Size = new Size(812, 331);
            ctr_Detain_License_Info1.TabIndex = 15;
            // 
            // ctr_detain_info1
            // 
            ctr_detain_info1.Location = new Point(12, 482);
            ctr_detain_info1.Name = "ctr_detain_info1";
            ctr_detain_info1.Size = new Size(812, 176);
            ctr_detain_info1.TabIndex = 16;
            // 
            // lnk_Show_License_Info
            // 
            lnk_Show_License_Info.AutoSize = true;
            lnk_Show_License_Info.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lnk_Show_License_Info.Location = new Point(166, 659);
            lnk_Show_License_Info.Name = "lnk_Show_License_Info";
            lnk_Show_License_Info.Size = new Size(127, 20);
            lnk_Show_License_Info.TabIndex = 17;
            lnk_Show_License_Info.TabStop = true;
            lnk_Show_License_Info.Text = "Show License Info";
            lnk_Show_License_Info.LinkClicked += lnk_Show_License_Info_LinkClicked;
            // 
            // Detain_License
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(831, 703);
            Controls.Add(lnk_Show_License_Info);
            Controls.Add(ctr_detain_info1);
            Controls.Add(ctr_Detain_License_Info1);
            Controls.Add(label1);
            Controls.Add(ctr_License_Filter1);
            Controls.Add(lnk_Show_License_history);
            Controls.Add(btn_Close);
            Controls.Add(btn_Detain_License);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "Detain_License";
            ShowIcon = false;
            Text = "Detain License";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Licenses.ctr_License_Filter ctr_License_Filter1;
        private LinkLabel lnk_Show_License_history;
        private Button btn_Close;
        private Button btn_Detain_License;
        private Label label1;
        private Detains.ctr_Detain_License_Info ctr_Detain_License_Info1;
        private Detains.ctr_detain_info ctr_detain_info1;
        private LinkLabel lnk_Show_License_Info;
    }
}