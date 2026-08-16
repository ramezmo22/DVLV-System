namespace DVLV.UI
{
    partial class Change_Password
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
            components = new System.ComponentModel.Container();
            txt_Password_Conformation = new TextBox();
            txt_Password = new TextBox();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            label5 = new Label();
            label4 = new Label();
            txt_CurrentPassword = new TextBox();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            btn_Save = new Button();
            btn_Close = new Button();
            errorProvider1 = new ErrorProvider(components);
            ctr_Person_Info4 = new ctr_Person_Info();
            login_Information1 = new Login_Information();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // txt_Password_Conformation
            // 
            txt_Password_Conformation.BackColor = SystemColors.Window;
            txt_Password_Conformation.Location = new Point(244, 574);
            txt_Password_Conformation.Name = "txt_Password_Conformation";
            txt_Password_Conformation.PasswordChar = '*';
            txt_Password_Conformation.Size = new Size(154, 23);
            txt_Password_Conformation.TabIndex = 3;
            txt_Password_Conformation.Validating += txt_Password_Conformation_Validating;
            // 
            // txt_Password
            // 
            txt_Password.BackColor = SystemColors.Window;
            txt_Password.Location = new Point(244, 524);
            txt_Password.Name = "txt_Password";
            txt_Password.PasswordChar = '*';
            txt_Password.Size = new Size(154, 23);
            txt_Password.TabIndex = 1;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.Number_32;
            pictureBox4.ImeMode = ImeMode.NoControl;
            pictureBox4.Location = new Point(183, 567);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(32, 32);
            pictureBox4.TabIndex = 15;
            pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.Number_32;
            pictureBox3.ImeMode = ImeMode.NoControl;
            pictureBox3.Location = new Point(183, 517);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(32, 32);
            pictureBox3.TabIndex = 14;
            pictureBox3.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label5.ImeMode = ImeMode.NoControl;
            label5.Location = new Point(13, 572);
            label5.Name = "label5";
            label5.Size = new Size(152, 21);
            label5.TabIndex = 13;
            label5.Text = "Conform Password:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label4.ImeMode = ImeMode.NoControl;
            label4.Location = new Point(45, 522);
            label4.Name = "label4";
            label4.Size = new Size(120, 21);
            label4.TabIndex = 12;
            label4.Text = "New Password:";
            // 
            // txt_CurrentPassword
            // 
            txt_CurrentPassword.BackColor = SystemColors.Window;
            txt_CurrentPassword.Location = new Point(244, 474);
            txt_CurrentPassword.Name = "txt_CurrentPassword";
            txt_CurrentPassword.Size = new Size(154, 23);
            txt_CurrentPassword.TabIndex = 0;
            txt_CurrentPassword.Validating += txt_CurrentPassword_Validating;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Number_32;
            pictureBox1.ImeMode = ImeMode.NoControl;
            pictureBox1.Location = new Point(183, 467);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(32, 32);
            pictureBox1.TabIndex = 19;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label1.ImeMode = ImeMode.NoControl;
            label1.Location = new Point(23, 472);
            label1.Name = "label1";
            label1.Size = new Size(142, 21);
            label1.TabIndex = 18;
            label1.Text = "Current Password:";
            // 
            // btn_Save
            // 
            btn_Save.Font = new Font("Segoe UI", 9.75F);
            btn_Save.Image = Properties.Resources.Save_32;
            btn_Save.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Save.Location = new Point(722, 680);
            btn_Save.Name = "btn_Save";
            btn_Save.Size = new Size(110, 35);
            btn_Save.TabIndex = 4;
            btn_Save.Text = "Save";
            btn_Save.UseVisualStyleBackColor = true;
            btn_Save.Click += btn_Save_Click;
            // 
            // btn_Close
            // 
            btn_Close.Font = new Font("Segoe UI", 9.75F);
            btn_Close.Image = Properties.Resources.Close_32;
            btn_Close.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Close.Location = new Point(606, 680);
            btn_Close.Name = "btn_Close";
            btn_Close.Size = new Size(110, 35);
            btn_Close.TabIndex = 3;
            btn_Close.Text = "Close";
            btn_Close.UseVisualStyleBackColor = true;
            btn_Close.Click += btn_Close_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // ctr_Person_Info4
            // 
            ctr_Person_Info4.Location = new Point(13, 12);
            ctr_Person_Info4.Name = "ctr_Person_Info4";
            ctr_Person_Info4.Size = new Size(819, 366);
            ctr_Person_Info4.TabIndex = 20;
            // 
            // login_Information1
            // 
            login_Information1.Location = new Point(12, 384);
            login_Information1.Name = "login_Information1";
            login_Information1.Size = new Size(820, 67);
            login_Information1.TabIndex = 21;
            // 
            // Change_Password
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(847, 732);
            Controls.Add(login_Information1);
            Controls.Add(ctr_Person_Info4);
            Controls.Add(btn_Close);
            Controls.Add(btn_Save);
            Controls.Add(txt_CurrentPassword);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(txt_Password_Conformation);
            Controls.Add(txt_Password);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(label5);
            Controls.Add(label4);
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "Change_Password";
            ShowIcon = false;
            Text = "Change Password";
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txt_Password_Conformation;
        private TextBox txt_Password;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private Label label5;
        private Label label4;
        private TextBox txt_CurrentPassword;
        private PictureBox pictureBox1;
        private Label label1;
        private Button btn_Save;
        private Button btn_Close;
        private ErrorProvider errorProvider1;
        private ctr_Person_Info ctr_Person_Info4;
        private Login_Information login_Information1;
    }
}