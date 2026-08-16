namespace DVLV.UI
{
    partial class UserInfo
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
            login_Information1 = new Login_Information();
            ctr_Person_Info1 = new ctr_Person_Info();
            btn_Close = new Button();
            SuspendLayout();
            // 
            // login_Information1
            // 
            login_Information1.Location = new Point(12, 384);
            login_Information1.Name = "login_Information1";
            login_Information1.Size = new Size(819, 76);
            login_Information1.TabIndex = 0;
            // 
            // ctr_Person_Info1
            // 
            ctr_Person_Info1.Location = new Point(12, 12);
            ctr_Person_Info1.Name = "ctr_Person_Info1";
            ctr_Person_Info1.Size = new Size(819, 366);
            ctr_Person_Info1.TabIndex = 1;
            // 
            // btn_Close
            // 
            btn_Close.Image = Properties.Resources.Close_32;
            btn_Close.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Close.ImeMode = ImeMode.NoControl;
            btn_Close.Location = new Point(724, 466);
            btn_Close.Name = "btn_Close";
            btn_Close.Size = new Size(107, 33);
            btn_Close.TabIndex = 4;
            btn_Close.Text = "Close";
            btn_Close.UseVisualStyleBackColor = true;
            btn_Close.Click += btn_Close_Click;
            // 
            // UserInfo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(845, 507);
            Controls.Add(btn_Close);
            Controls.Add(ctr_Person_Info1);
            Controls.Add(login_Information1);
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "UserInfo";
            ShowIcon = false;
            Text = "UserInfo";
            ResumeLayout(false);
        }

        #endregion

        private Login_Information login_Information1;
        private ctr_Person_Info ctr_Person_Info1;
        private Button btn_Close;
    }
}