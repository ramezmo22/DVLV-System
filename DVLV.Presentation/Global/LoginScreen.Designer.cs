using DVLV.UI.Properties;

namespace DVLV.UI
{
    partial class LoginScreen
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
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            txt_UserName = new TextBox();
            txt_Password = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            btn_Close = new Button();
            cb_RememberMe = new CheckBox();
            btn_Login = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Lavender;
            pictureBox1.Location = new Point(-3, -6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(462, 587);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Lavender;
            pictureBox2.Image = Resources.correct_the_small_ty;
            pictureBox2.Location = new Point(111, 38);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(225, 197);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Lavender;
            label1.Font = new Font("Mongolian Baiti", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkSlateGray;
            label1.Location = new Point(26, 257);
            label1.Name = "label1";
            label1.Size = new Size(384, 116);
            label1.TabIndex = 2;
            label1.Text = "             WELCOME TO\r\n        DRIVING & VEHICLE\r\n     LICENSE DEPARTMENT \r\n            (DVLV) SYSTEM ";
            // 
            // txt_UserName
            // 
            txt_UserName.Location = new Point(670, 194);
            txt_UserName.Name = "txt_UserName";
            txt_UserName.Size = new Size(201, 23);
            txt_UserName.TabIndex = 1;
            // 
            // txt_Password
            // 
            txt_Password.Location = new Point(670, 234);
            txt_Password.Name = "txt_Password";
            txt_Password.PasswordChar = '*';
            txt_Password.Size = new Size(201, 23);
            txt_Password.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Lavender;
            label2.Location = new Point(564, 76);
            label2.Name = "label2";
            label2.Size = new Size(271, 32);
            label2.TabIndex = 5;
            label2.Text = "Login to your Account";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Lavender;
            label3.Location = new Point(515, 190);
            label3.Name = "label3";
            label3.Size = new Size(103, 25);
            label3.TabIndex = 6;
            label3.Text = "Username:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Lavender;
            label4.Location = new Point(515, 230);
            label4.Name = "label4";
            label4.Size = new Size(96, 25);
            label4.TabIndex = 7;
            label4.Text = "Password:";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Resources.Person_32;
            pictureBox3.Location = new Point(624, 192);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(29, 27);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 8;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Resources.Number_32;
            pictureBox4.Location = new Point(624, 233);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(29, 27);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 9;
            pictureBox4.TabStop = false;
            // 
            // btn_Close
            // 
            btn_Close.BackColor = Color.DarkSlateGray;
            btn_Close.FlatAppearance.BorderSize = 0;
            btn_Close.FlatStyle = FlatStyle.Flat;
            btn_Close.Image = Resources.closeBlack32;
            btn_Close.Location = new Point(877, 3);
            btn_Close.Name = "btn_Close";
            btn_Close.Size = new Size(35, 32);
            btn_Close.TabIndex = 4;
            btn_Close.UseVisualStyleBackColor = false;
            btn_Close.Click += btn_Close_Click;
            // 
            // cb_RememberMe
            // 
            cb_RememberMe.AutoSize = true;
            cb_RememberMe.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cb_RememberMe.ForeColor = Color.Lavender;
            cb_RememberMe.Location = new Point(670, 267);
            cb_RememberMe.Name = "cb_RememberMe";
            cb_RememberMe.Size = new Size(117, 21);
            cb_RememberMe.TabIndex = 3;
            cb_RememberMe.Text = "Remember Me.";
            cb_RememberMe.UseVisualStyleBackColor = true;
            cb_RememberMe.CheckedChanged += cb_RememberMe_CheckedChanged;
            // 
            // btn_Login
            // 
            btn_Login.BackColor = Color.DarkSlateGray;
            btn_Login.FlatAppearance.BorderColor = Color.Lavender;
            btn_Login.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_Login.ForeColor = Color.Lavender;
            btn_Login.Image = Resources.sign_in_32;
            btn_Login.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Login.Location = new Point(759, 298);
            btn_Login.Name = "btn_Login";
            btn_Login.Size = new Size(112, 36);
            btn_Login.TabIndex = 4;
            btn_Login.Text = "     Login";
            btn_Login.UseVisualStyleBackColor = false;
            btn_Login.Click += btn_Login_Click;
            // 
            // LoginScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(915, 582);
            Controls.Add(btn_Login);
            Controls.Add(cb_RememberMe);
            Controls.Add(btn_Close);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txt_Password);
            Controls.Add(txt_UserName);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "LoginScreen";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginScreen";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label1;
        private TextBox txt_UserName;
        private TextBox txt_Password;
        private Label label2;
        private Label label3;
        private Label label4;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private Button btn_Close;
        private CheckBox cb_RememberMe;
        private Button btn_Login;
    }
}