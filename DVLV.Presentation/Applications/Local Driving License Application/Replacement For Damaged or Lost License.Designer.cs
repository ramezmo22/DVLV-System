namespace DVLV.UI.Applications_Manage
{
    partial class Replacement_For_Damaged_or_Lost_License
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
            ctr_License_Filter1 = new DVLV.UI.Licenses.ctr_License_Filter();
            ctr_Driver_License_Info1 = new DVLV.UI.Licenses.ctr_Driver_License_Info();
            label1 = new Label();
            groupBox1 = new GroupBox();
            rdb_Lost_License = new RadioButton();
            rdb_Damaged_License = new RadioButton();
            lnk_Show_New_License_Info = new LinkLabel();
            lnk_Show_License_history = new LinkLabel();
            btn_Close = new Button();
            btn_Replace_License = new Button();
            ctr_Application_Info_For_License_Replacement1 = new ctr_Application_Info_For_License_Replacement();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // ctr_License_Filter1
            // 
            ctr_License_Filter1.Location = new Point(7, 52);
            ctr_License_Filter1.Name = "ctr_License_Filter1";
            ctr_License_Filter1.Size = new Size(545, 77);
            ctr_License_Filter1.TabIndex = 5;
            ctr_License_Filter1.OnLicenseSelected += ctr_License_Filter1_OnLicenseSelected;
            // 
            // ctr_Driver_License_Info1
            // 
            ctr_Driver_License_Info1.Enabled = false;
            ctr_Driver_License_Info1.Location = new Point(4, 134);
            ctr_Driver_License_Info1.Name = "ctr_Driver_License_Info1";
            ctr_Driver_License_Info1.Size = new Size(801, 335);
            ctr_Driver_License_Info1.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(192, 0, 0);
            label1.Location = new Point(162, 9);
            label1.Name = "label1";
            label1.Size = new Size(470, 40);
            label1.TabIndex = 3;
            label1.Text = "Replacement for Damaged License";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rdb_Lost_License);
            groupBox1.Controls.Add(rdb_Damaged_License);
            groupBox1.Location = new Point(558, 52);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(245, 77);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Replacement For:";
            // 
            // rdb_Lost_License
            // 
            rdb_Lost_License.AutoSize = true;
            rdb_Lost_License.Font = new Font("Segoe UI", 10F);
            rdb_Lost_License.Location = new Point(6, 47);
            rdb_Lost_License.Name = "rdb_Lost_License";
            rdb_Lost_License.Size = new Size(101, 23);
            rdb_Lost_License.TabIndex = 1;
            rdb_Lost_License.TabStop = true;
            rdb_Lost_License.Text = "Lost License";
            rdb_Lost_License.UseVisualStyleBackColor = true;
            rdb_Lost_License.CheckedChanged += rdb_Lost_License_CheckedChanged;
            // 
            // rdb_Damaged_License
            // 
            rdb_Damaged_License.AutoSize = true;
            rdb_Damaged_License.Font = new Font("Segoe UI", 10F);
            rdb_Damaged_License.Location = new Point(6, 18);
            rdb_Damaged_License.Name = "rdb_Damaged_License";
            rdb_Damaged_License.Size = new Size(134, 23);
            rdb_Damaged_License.TabIndex = 0;
            rdb_Damaged_License.TabStop = true;
            rdb_Damaged_License.Text = "Damaged License";
            rdb_Damaged_License.UseVisualStyleBackColor = true;
            rdb_Damaged_License.CheckedChanged += rdb_Damaged_License_CheckedChanged;
            // 
            // lnk_Show_New_License_Info
            // 
            lnk_Show_New_License_Info.AutoSize = true;
            lnk_Show_New_License_Info.Enabled = false;
            lnk_Show_New_License_Info.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lnk_Show_New_License_Info.Location = new Point(162, 626);
            lnk_Show_New_License_Info.Name = "lnk_Show_New_License_Info";
            lnk_Show_New_License_Info.Size = new Size(161, 20);
            lnk_Show_New_License_Info.TabIndex = 11;
            lnk_Show_New_License_Info.TabStop = true;
            lnk_Show_New_License_Info.Text = "Show New License Info";
            lnk_Show_New_License_Info.LinkClicked += lnk_Show_New_License_Info_LinkClicked;
            // 
            // lnk_Show_License_history
            // 
            lnk_Show_License_history.AutoSize = true;
            lnk_Show_License_history.Enabled = false;
            lnk_Show_License_history.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lnk_Show_License_history.Location = new Point(8, 626);
            lnk_Show_License_history.Name = "lnk_Show_License_history";
            lnk_Show_License_history.Size = new Size(148, 20);
            lnk_Show_License_history.TabIndex = 10;
            lnk_Show_License_history.TabStop = true;
            lnk_Show_License_history.Text = "Show License History";
            lnk_Show_License_history.LinkClicked += lnk_Show_License_history_LinkClicked;
            // 
            // btn_Close
            // 
            btn_Close.Image = Properties.Resources.Close_32;
            btn_Close.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Close.Location = new Point(491, 626);
            btn_Close.Name = "btn_Close";
            btn_Close.Size = new Size(118, 39);
            btn_Close.TabIndex = 9;
            btn_Close.Text = "Close";
            btn_Close.UseVisualStyleBackColor = true;
            btn_Close.Click += btn_Close_Click;
            // 
            // btn_Replace_License
            // 
            btn_Replace_License.Enabled = false;
            btn_Replace_License.Image = Properties.Resources.Renew_Driving_License_322;
            btn_Replace_License.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Replace_License.Location = new Point(615, 626);
            btn_Replace_License.Name = "btn_Replace_License";
            btn_Replace_License.Size = new Size(195, 39);
            btn_Replace_License.TabIndex = 8;
            btn_Replace_License.Text = "Issue Replacement";
            btn_Replace_License.UseVisualStyleBackColor = true;
            btn_Replace_License.Click += btn_Replace_License_Click;
            // 
            // ctr_Application_Info_For_License_Replacement1
            // 
            ctr_Application_Info_For_License_Replacement1.Location = new Point(4, 475);
            ctr_Application_Info_For_License_Replacement1.Name = "ctr_Application_Info_For_License_Replacement1";
            ctr_Application_Info_For_License_Replacement1.Size = new Size(801, 145);
            ctr_Application_Info_For_License_Replacement1.TabIndex = 12;
            // 
            // Replacement_For_Damaged_or_Lost_License
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(819, 680);
            Controls.Add(ctr_Application_Info_For_License_Replacement1);
            Controls.Add(lnk_Show_New_License_Info);
            Controls.Add(lnk_Show_License_history);
            Controls.Add(btn_Close);
            Controls.Add(btn_Replace_License);
            Controls.Add(groupBox1);
            Controls.Add(ctr_License_Filter1);
            Controls.Add(ctr_Driver_License_Info1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "Replacement_For_Damaged_or_Lost_License";
            ShowIcon = false;
            ShowInTaskbar = false;
            Text = "Replacement For Damaged or Lost License";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Licenses.ctr_License_Filter ctr_License_Filter1;
        private Licenses.ctr_Driver_License_Info ctr_Driver_License_Info1;
        private Label label1;
        private GroupBox groupBox1;
        private RadioButton rdb_Lost_License;
        private RadioButton rdb_Damaged_License;
        private LinkLabel lnk_Show_New_License_Info;
        private LinkLabel lnk_Show_License_history;
        private Button btn_Close;
        private Button btn_Replace_License;
        private ctr_Application_Info_For_License_Replacement ctr_Application_Info_For_License_Replacement1;
    }
}