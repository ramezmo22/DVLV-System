namespace DVLV.UI
{
    partial class Add_New_User
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lbl_heder = new System.Windows.Forms.Label();
            this.tab_New_User = new System.Windows.Forms.TabControl();
            this.tab_Personal = new System.Windows.Forms.TabPage();
            this.btn_Next = new System.Windows.Forms.Button();
            this.ctr_Person_Info1 = new DVLV.UI.ctr_Person_Info();
            this.person_Finder_Filter1 = new DVLV.UI.Person_Finder_Filter();
            this.tab_Login_Info = new System.Windows.Forms.TabPage();
            this.ckb_IsActive = new System.Windows.Forms.CheckBox();
            this.txt_Password_Conformation = new System.Windows.Forms.TextBox();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.txt_UserName = new System.Windows.Forms.TextBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_UserID = new System.Windows.Forms.Label();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Close = new System.Windows.Forms.Button();
            this.tab_New_User.SuspendLayout();
            this.tab_Personal.SuspendLayout();
            this.tab_Login_Info.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_heder
            // 
            this.lbl_heder.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_heder.ForeColor = System.Drawing.Color.Firebrick;
            this.lbl_heder.Location = new System.Drawing.Point(12, 9);
            this.lbl_heder.Name = "lbl_heder";
            this.lbl_heder.Size = new System.Drawing.Size(860, 40);
            this.lbl_heder.TabIndex = 0;
            this.lbl_heder.Text = "Add New User";
            this.lbl_heder.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tab_New_User
            // 
            this.tab_New_User.Controls.Add(this.tab_Personal);
            this.tab_New_User.Controls.Add(this.tab_Login_Info);
            this.tab_New_User.Location = new System.Drawing.Point(12, 60);
            this.tab_New_User.Name = "tab_New_User";
            this.tab_New_User.SelectedIndex = 0;
            this.tab_New_User.Size = new System.Drawing.Size(864, 460);
            this.tab_New_User.TabIndex = 1;
            // 
            // tab_Personal
            // 
            this.tab_Personal.BackColor = System.Drawing.SystemColors.Control;
            this.tab_Personal.Controls.Add(this.person_Finder_Filter1);
            this.tab_Personal.Controls.Add(this.ctr_Person_Info1);
            this.tab_Personal.Controls.Add(this.btn_Next);
            this.tab_Personal.Location = new System.Drawing.Point(4, 24);
            this.tab_Personal.Name = "tab_Personal";
            this.tab_Personal.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Personal.Size = new System.Drawing.Size(856, 432);
            this.tab_Personal.TabIndex = 0;
            this.tab_Personal.Text = "Personal Info";
            // 
            // person_Finder_Filter1
            // 
            this.person_Finder_Filter1.BackColor = System.Drawing.Color.White;
            this.person_Finder_Filter1.Location = new System.Drawing.Point(6, 6);
            this.person_Finder_Filter1.Name = "person_Finder_Filter1";
            this.person_Finder_Filter1.Size = new System.Drawing.Size(840, 115);
            this.person_Finder_Filter1.TabIndex = 0;
            this.person_Finder_Filter1.PersonFound += new System.EventHandler<int>(this.person_Finder_Filter1_PersonFound);
            // 
            // ctr_Person_Info1
            // 
            this.ctr_Person_Info1.Location = new System.Drawing.Point(6, 125);
            this.ctr_Person_Info1.Name = "ctr_Person_Info1";
            this.ctr_Person_Info1.Size = new System.Drawing.Size(840, 250);
            this.ctr_Person_Info1.TabIndex = 1;
            // 
            // btn_Next
            // 
            this.btn_Next.Image = Properties.Resources.Next_32;
            this.btn_Next.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Next.Location = new System.Drawing.Point(740, 382);
            this.btn_Next.Name = "btn_Next";
            this.btn_Next.Size = new System.Drawing.Size(105, 40);
            this.btn_Next.TabIndex = 2;
            this.btn_Next.Text = "Next";
            this.btn_Next.UseVisualStyleBackColor = true;
            this.btn_Next.Click += new System.EventHandler(this.btn_Next_Click);
            // 
            // tab_Login_Info
            // 
            this.tab_Login_Info.BackColor = System.Drawing.SystemColors.Control;
            this.tab_Login_Info.Controls.Add(this.ckb_IsActive);
            this.tab_Login_Info.Controls.Add(this.txt_Password_Conformation);
            this.tab_Login_Info.Controls.Add(this.txt_Password);
            this.tab_Login_Info.Controls.Add(this.txt_UserName);
            this.tab_Login_Info.Controls.Add(this.pictureBox4);
            this.tab_Login_Info.Controls.Add(this.pictureBox3);
            this.tab_Login_Info.Controls.Add(this.pictureBox2);
            this.tab_Login_Info.Controls.Add(this.pictureBox1);
            this.tab_Login_Info.Controls.Add(this.label5);
            this.tab_Login_Info.Controls.Add(this.label4);
            this.tab_Login_Info.Controls.Add(this.label3);
            this.tab_Login_Info.Controls.Add(this.label2);
            this.tab_Login_Info.Controls.Add(this.lbl_UserID);
            this.tab_Login_Info.Location = new System.Drawing.Point(4, 24);
            this.tab_Login_Info.Name = "tab_Login_Info";
            this.tab_Login_Info.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Login_Info.Size = new System.Drawing.Size(856, 432);
            this.tab_Login_Info.TabIndex = 1;
            this.tab_Login_Info.Text = "Login Info";
            // 
            // lbl_UserID
            // 
            this.lbl_UserID.AutoSize = true;
            this.lbl_UserID.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_UserID.Location = new System.Drawing.Point(230, 48);
            this.lbl_UserID.Name = "lbl_UserID";
            this.lbl_UserID.Size = new System.Drawing.Size(31, 15);
            this.lbl_UserID.TabIndex = 0;
            this.lbl_UserID.Text = "???";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(70, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "User ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(70, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "User Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(70, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Password:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(70, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Confirm Password:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = Properties.Resources.Number_32;
            this.pictureBox1.Location = new System.Drawing.Point(190, 42);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(26, 26);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = Properties.Resources.Person_32;
            this.pictureBox2.Location = new System.Drawing.Point(190, 86);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(26, 26);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = Properties.Resources.Number_32;
            this.pictureBox3.Location = new System.Drawing.Point(190, 130);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(26, 26);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = Properties.Resources.Number_32;
            this.pictureBox4.Location = new System.Drawing.Point(190, 174);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(26, 26);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 8;
            this.pictureBox4.TabStop = false;
            // 
            // txt_UserName
            // 
            this.txt_UserName.Location = new System.Drawing.Point(230, 88);
            this.txt_UserName.Name = "txt_UserName";
            this.txt_UserName.Size = new System.Drawing.Size(170, 23);
            this.txt_UserName.TabIndex = 9;
            // 
            // txt_Password
            // 
            this.txt_Password.Location = new System.Drawing.Point(230, 132);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.PasswordChar = '*';
            this.txt_Password.Size = new System.Drawing.Size(170, 23);
            this.txt_Password.TabIndex = 10;
            // 
            // txt_Password_Conformation
            // 
            this.txt_Password_Conformation.Location = new System.Drawing.Point(230, 176);
            this.txt_Password_Conformation.Name = "txt_Password_Conformation";
            this.txt_Password_Conformation.PasswordChar = '*';
            this.txt_Password_Conformation.Size = new System.Drawing.Size(170, 23);
            this.txt_Password_Conformation.TabIndex = 11;
            // 
            // ckb_IsActive
            // 
            this.ckb_IsActive.AutoSize = true;
            this.ckb_IsActive.Checked = true;
            this.ckb_IsActive.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckb_IsActive.Location = new System.Drawing.Point(230, 220);
            this.ckb_IsActive.Name = "ckb_IsActive";
            this.ckb_IsActive.Size = new System.Drawing.Size(70, 19);
            this.ckb_IsActive.TabIndex = 12;
            this.ckb_IsActive.Text = "Is Active";
            this.ckb_IsActive.UseVisualStyleBackColor = true;
            // 
            // btn_Save
            // 
            this.btn_Save.Image = Properties.Resources.Save_32;
            this.btn_Save.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Save.Location = new System.Drawing.Point(766, 530);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(105, 38);
            this.btn_Save.TabIndex = 2;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Close
            // 
            this.btn_Close.Image = Properties.Resources.Close_322;
            this.btn_Close.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Close.Location = new System.Drawing.Point(650, 530);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(105, 38);
            this.btn_Close.TabIndex = 3;
            this.btn_Close.Text = "Close";
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // Add_New_User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 580);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.tab_New_User);
            this.Controls.Add(this.lbl_heder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Add_New_User";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add New User";
            this.tab_New_User.ResumeLayout(false);
            this.tab_Personal.ResumeLayout(false);
            this.tab_Login_Info.ResumeLayout(false);
            this.tab_Login_Info.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        public System.Windows.Forms.Label lbl_heder;
        public System.Windows.Forms.TabControl tab_New_User;
        public System.Windows.Forms.TabPage tab_Personal;
        public System.Windows.Forms.TabPage tab_Login_Info;

        public System.Windows.Forms.Button btn_Save;
        public System.Windows.Forms.Button btn_Next;
        public System.Windows.Forms.Button btn_Close;

        public System.Windows.Forms.PictureBox pictureBox4;
        public System.Windows.Forms.PictureBox pictureBox3;
        public System.Windows.Forms.PictureBox pictureBox2;
        public System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label lbl_UserID;
        public System.Windows.Forms.CheckBox ckb_IsActive;
        public System.Windows.Forms.TextBox txt_Password_Conformation;
        public System.Windows.Forms.TextBox txt_Password;
        public System.Windows.Forms.TextBox txt_UserName;

        public ctr_Person_Info ctr_Person_Info1;
        public Person_Finder_Filter person_Finder_Filter1;
    }
}