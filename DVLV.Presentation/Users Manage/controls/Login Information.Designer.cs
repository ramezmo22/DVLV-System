namespace DVLV.UI
{
    partial class Login_Information
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            label6 = new Label();
            lbl_IsActive = new Label();
            lbl_Username = new Label();
            label3 = new Label();
            lbl_UserID = new Label();
            label1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(lbl_IsActive);
            groupBox1.Controls.Add(lbl_Username);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(lbl_UserID);
            groupBox1.Controls.Add(label1);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(703, 67);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Login Info";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            label6.Location = new Point(540, 25);
            label6.Name = "label6";
            label6.Size = new Size(69, 20);
            label6.TabIndex = 5;
            label6.Text = "Is Active:";
            // 
            // lbl_IsActive
            // 
            lbl_IsActive.AutoSize = true;
            lbl_IsActive.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            lbl_IsActive.Location = new Point(607, 26);
            lbl_IsActive.Name = "lbl_IsActive";
            lbl_IsActive.Size = new Size(30, 20);
            lbl_IsActive.TabIndex = 4;
            lbl_IsActive.Text = "???";
            lbl_IsActive.Click += label5_Click;
            // 
            // lbl_Username
            // 
            lbl_Username.AutoSize = true;
            lbl_Username.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            lbl_Username.Location = new Point(369, 25);
            lbl_Username.Name = "lbl_Username";
            lbl_Username.Size = new Size(30, 20);
            lbl_Username.TabIndex = 3;
            lbl_Username.Text = "???";
            lbl_Username.Click += label4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            label3.Location = new Point(291, 25);
            label3.Name = "label3";
            label3.Size = new Size(82, 20);
            label3.TabIndex = 2;
            label3.Text = "Username:";
            // 
            // lbl_UserID
            // 
            lbl_UserID.AutoSize = true;
            lbl_UserID.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            lbl_UserID.Location = new Point(132, 25);
            lbl_UserID.Name = "lbl_UserID";
            lbl_UserID.Size = new Size(30, 20);
            lbl_UserID.TabIndex = 1;
            lbl_UserID.Text = "???";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            label1.Location = new Point(73, 25);
            label1.Name = "label1";
            label1.Size = new Size(63, 20);
            label1.TabIndex = 0;
            label1.Text = "User ID:";
            // 
            // Login_Information
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBox1);
            Name = "Login_Information";
            Size = new Size(703, 67);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label6;
        private Label lbl_IsActive;
        private Label lbl_Username;
        private Label label3;
        private Label lbl_UserID;
        private Label label1;
    }
}
