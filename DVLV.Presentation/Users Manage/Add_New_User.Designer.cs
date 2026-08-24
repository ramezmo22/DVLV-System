namespace DVLV.UI
{
    partial class Add_New_User
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
            System.ComponentModel.ComponentResourceManager Resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_New_User));
            lbl_heder = new Label();
            tab_New_User = new TabControl();
            tab_Personal = new TabPage();
            ctr_Person_Info1 = new ctr_Person_Info();
            person_Finder_Filter1 = new Person_Finder_Filter();
            btn_Next = new Button();
            tab_Login_Info = new TabPage();
            ckb_IsActive = new CheckBox();
            txt_Password_Conformation = new TextBox();
            txt_Password = new TextBox();
            txt_UserName = new TextBox();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            lbl_UserID = new Label();
            btn_Save = new Button();
            btn_Close = new Button();
            tab_New_User.SuspendLayout();
            tab_Personal.SuspendLayout();
            tab_Login_Info.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lbl_heder
            // 
            Resources.ApplyResources(lbl_heder, "lbl_heder");
            lbl_heder.ForeColor = Color.Firebrick;
            lbl_heder.Name = "lbl_heder";
            // 
            // tab_New_User
            // 
            tab_New_User.Controls.Add(tab_Personal);
            tab_New_User.Controls.Add(tab_Login_Info);
            Resources.ApplyResources(tab_New_User, "tab_New_User");
            tab_New_User.Name = "tab_New_User";
            tab_New_User.SelectedIndex = 0;
            tab_New_User.SelectedIndexChanged += btn_Next_Click;
            // 
            // tab_Personal
            // 
            tab_Personal.BackColor = SystemColors.Control;
            tab_Personal.Controls.Add(ctr_Person_Info1);
            tab_Personal.Controls.Add(person_Finder_Filter1);
            tab_Personal.Controls.Add(btn_Next);
            Resources.ApplyResources(tab_Personal, "tab_Personal");
            tab_Personal.Name = "tab_Personal";
            // 
            // ctr_Person_Info1
            // 
            Resources.ApplyResources(ctr_Person_Info1, "ctr_Person_Info1");
            ctr_Person_Info1.Name = "ctr_Person_Info1";
            // 
            // person_Finder_Filter1
            // 
            Resources.ApplyResources(person_Finder_Filter1, "person_Finder_Filter1");
            person_Finder_Filter1.Name = "person_Finder_Filter1";
            person_Finder_Filter1.PersonFound += person_Finder_Filter1_PersonFound;
            // 
            // btn_Next
            // 
            btn_Next.Image = UI.Properties.Resources.Next_32;
            Resources.ApplyResources(btn_Next, "btn_Next");
            btn_Next.Name = "btn_Next";
            btn_Next.UseVisualStyleBackColor = true;
            btn_Next.Click += btn_Next_Click;
            // 
            // tab_Login_Info
            // 
            tab_Login_Info.BackColor = SystemColors.Control;
            tab_Login_Info.Controls.Add(ckb_IsActive);
            tab_Login_Info.Controls.Add(txt_Password_Conformation);
            tab_Login_Info.Controls.Add(txt_Password);
            tab_Login_Info.Controls.Add(txt_UserName);
            tab_Login_Info.Controls.Add(pictureBox4);
            tab_Login_Info.Controls.Add(pictureBox3);
            tab_Login_Info.Controls.Add(pictureBox2);
            tab_Login_Info.Controls.Add(pictureBox1);
            tab_Login_Info.Controls.Add(label5);
            tab_Login_Info.Controls.Add(label4);
            tab_Login_Info.Controls.Add(label3);
            tab_Login_Info.Controls.Add(label2);
            tab_Login_Info.Controls.Add(lbl_UserID);
            Resources.ApplyResources(tab_Login_Info, "tab_Login_Info");
            tab_Login_Info.Name = "tab_Login_Info";
            // 
            // ckb_IsActive
            // 
            Resources.ApplyResources(ckb_IsActive, "ckb_IsActive");
            ckb_IsActive.Name = "ckb_IsActive";
            ckb_IsActive.UseVisualStyleBackColor = true;
            // 
            // txt_Password_Conformation
            // 
            Resources.ApplyResources(txt_Password_Conformation, "txt_Password_Conformation");
            txt_Password_Conformation.Name = "txt_Password_Conformation";
            // 
            // txt_Password
            // 
            Resources.ApplyResources(txt_Password, "txt_Password");
            txt_Password.Name = "txt_Password";
            // 
            // txt_UserName
            // 
            Resources.ApplyResources(txt_UserName, "txt_UserName");
            txt_UserName.Name = "txt_UserName";
            // 
            // pictureBox4
            // 
            pictureBox4.Image = UI.Properties.Resources.Number_32;
            Resources.ApplyResources(pictureBox4, "pictureBox4");
            pictureBox4.Name = "pictureBox4";
            pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = UI.Properties.Resources.Number_32;
            Resources.ApplyResources(pictureBox3, "pictureBox3");
            pictureBox3.Name = "pictureBox3";
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = UI.Properties.Resources.Person_32;
            Resources.ApplyResources(pictureBox2, "pictureBox2");
            pictureBox2.Name = "pictureBox2";
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = UI.Properties.Resources.Number_32;
            Resources.ApplyResources(pictureBox1, "pictureBox1");
            pictureBox1.Name = "pictureBox1";
            pictureBox1.TabStop = false;
            // 
            // label5
            // 
            Resources.ApplyResources(label5, "label5");
            label5.Name = "label5";
            // 
            // label4
            // 
            Resources.ApplyResources(label4, "label4");
            label4.Name = "label4";
            // 
            // label3
            // 
            Resources.ApplyResources(label3, "label3");
            label3.Name = "label3";
            // 
            // label2
            // 
            Resources.ApplyResources(label2, "label2");
            label2.Name = "label2";
            // 
            // lbl_UserID
            // 
            Resources.ApplyResources(lbl_UserID, "lbl_UserID");
            lbl_UserID.Name = "lbl_UserID";
            // 
            // btn_Save
            // 
            btn_Save.Image = UI.Properties.Resources.Save_32;
            Resources.ApplyResources(btn_Save, "btn_Save");
            btn_Save.Name = "btn_Save";
            btn_Save.UseVisualStyleBackColor = true;
            btn_Save.Click += btn_Save_Click;
            // 
            // btn_Close
            // 
            btn_Close.Image = UI.Properties.Resources.Close_322;
            Resources.ApplyResources(btn_Close, "btn_Close");
            btn_Close.Name = "btn_Close";
            btn_Close.UseVisualStyleBackColor = true;
            btn_Close.Click += btn_Close_Click;
            // 
            // Add_New_User
            // 
            Resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btn_Close);
            Controls.Add(tab_New_User);
            Controls.Add(lbl_heder);
            Controls.Add(btn_Save);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Add_New_User";
            ShowIcon = false;
            ShowInTaskbar = false;
            tab_New_User.ResumeLayout(false);
            tab_Personal.ResumeLayout(false);
            tab_Login_Info.ResumeLayout(false);
            tab_Login_Info.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_heder;
        private TabControl tab_New_User;
        private TabPage tab_Personal;
        private TabPage tab_Login_Info;

        private Button btn_Save;
        private Button btn_Next;
        private Button btn_Close;

        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label lbl_UserID;
        private CheckBox ckb_IsActive;
        private TextBox txt_Password_Conformation;
        private TextBox txt_Password;
        private TextBox txt_UserName;

        private ctr_Person_Info ctr_Person_Info1;
        private Person_Finder_Filter person_Finder_Filter1;
    }
}