using DVLV.UI.Properties;

namespace DVLV.UI.Detains
{
    partial class Release_Detained_License
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
            lnk_Show_License_Info = new LinkLabel();
            label1 = new Label();
            ctr_License_Filter1 = new DVLV.UI.Licenses.ctr_License_Filter();
            lnk_Show_License_history = new LinkLabel();
            btn_Close = new Button();
            btn_Release_License = new Button();
            ctr_Detain_License_Info1 = new ctr_Detain_License_Info();
            ctr_detained_view1 = new ctr_detained_view();
            SuspendLayout();
            // 
            // lnk_Show_License_Info
            // 
            lnk_Show_License_Info.AutoSize = true;
            lnk_Show_License_Info.Enabled = false;
            lnk_Show_License_Info.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lnk_Show_License_Info.Location = new Point(163, 676);
            lnk_Show_License_Info.Name = "lnk_Show_License_Info";
            lnk_Show_License_Info.Size = new Size(127, 20);
            lnk_Show_License_Info.TabIndex = 23;
            lnk_Show_License_Info.TabStop = true;
            lnk_Show_License_Info.Text = "Show License Info";
            lnk_Show_License_Info.LinkClicked += lnk_Show_License_Info_LinkClicked;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(192, 0, 0);
            label1.Location = new Point(237, 9);
            label1.Name = "label1";
            label1.Size = new Size(345, 40);
            label1.TabIndex = 22;
            label1.Text = "Release Detainde License";
            // 
            // ctr_License_Filter1
            // 
            ctr_License_Filter1.Location = new Point(9, 50);
            ctr_License_Filter1.Name = "ctr_License_Filter1";
            ctr_License_Filter1.Size = new Size(545, 77);
            ctr_License_Filter1.TabIndex = 21;
            ctr_License_Filter1.OnLicenseSelected += ctr_License_Filter1_OnLicenseSelected;
            // 
            // lnk_Show_License_history
            // 
            lnk_Show_License_history.AutoSize = true;
            lnk_Show_License_history.Enabled = false;
            lnk_Show_License_history.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lnk_Show_License_history.Location = new Point(9, 676);
            lnk_Show_License_history.Name = "lnk_Show_License_history";
            lnk_Show_License_history.Size = new Size(148, 20);
            lnk_Show_License_history.TabIndex = 20;
            lnk_Show_License_history.TabStop = true;
            lnk_Show_License_history.Text = "Show License History";
            lnk_Show_License_history.LinkClicked += lnk_Show_License_history_LinkClicked;
            // 
            // btn_Close
            // 
            btn_Close.Image = Resources.Close_32;
            btn_Close.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Close.Location = new Point(579, 676);
            btn_Close.Name = "btn_Close";
            btn_Close.Size = new Size(118, 39);
            btn_Close.TabIndex = 19;
            btn_Close.Text = "Close";
            btn_Close.UseVisualStyleBackColor = true;
            // 
            // btn_Release_License
            // 
            btn_Release_License.Enabled = false;
            btn_Release_License.Image = Resources.Release_Detained_License_32;
            btn_Release_License.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Release_License.Location = new Point(703, 676);
            btn_Release_License.Name = "btn_Release_License";
            btn_Release_License.Size = new Size(118, 39);
            btn_Release_License.TabIndex = 18;
            btn_Release_License.Text = "Release";
            btn_Release_License.UseVisualStyleBackColor = true;
            btn_Release_License.Click += btn_Release_License_Click;
            // 
            // ctr_Detain_License_Info1
            // 
            ctr_Detain_License_Info1.Location = new Point(7, 133);
            ctr_Detain_License_Info1.Name = "ctr_Detain_License_Info1";
            ctr_Detain_License_Info1.Size = new Size(812, 331);
            ctr_Detain_License_Info1.TabIndex = 24;
            // 
            // ctr_detained_view1
            // 
            ctr_detained_view1.Location = new Point(7, 470);
            ctr_detained_view1.Name = "ctr_detained_view1";
            ctr_detained_view1.Size = new Size(814, 198);
            ctr_detained_view1.TabIndex = 25;
            // 
            // Release_Detained_License
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(831, 724);
            Controls.Add(ctr_detained_view1);
            Controls.Add(ctr_Detain_License_Info1);
            Controls.Add(lnk_Show_License_Info);
            Controls.Add(label1);
            Controls.Add(ctr_License_Filter1);
            Controls.Add(lnk_Show_License_history);
            Controls.Add(btn_Close);
            Controls.Add(btn_Release_License);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "Release_Detained_License";
            ShowIcon = false;
            ShowInTaskbar = false;
            Text = "Release Detained License";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private LinkLabel lnk_Show_License_Info;
        private Label label1;
        private Licenses.ctr_License_Filter ctr_License_Filter1;
        private LinkLabel lnk_Show_License_history;
        private Button btn_Close;
        private Button btn_Release_License;
        private ctr_Detain_License_Info ctr_Detain_License_Info1;
        private ctr_detained_view ctr_detained_view1;
    }
}