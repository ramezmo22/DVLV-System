namespace DVLV.UI
{
    partial class ManageUsers
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
            pictureBox1 = new PictureBox();
            btn_Add_User = new Button();
            ctr_Users_Grid_View1 = new ctr_Users_Grid_View();
            btn_Refesh = new Button();
            label1 = new Label();
            comboBox1 = new ComboBox();
            label2 = new Label();
            textBox1 = new TextBox();
            comboBox2 = new ComboBox();
            lbl_Records = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Users_2_400;
            pictureBox1.Location = new Point(411, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(204, 191);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // btn_Add_User
            // 
            btn_Add_User.Anchor = AnchorStyles.Right;
            btn_Add_User.Image = Properties.Resources.Add_New_User_72;
            btn_Add_User.Location = new Point(950, 282);
            btn_Add_User.Name = "btn_Add_User";
            btn_Add_User.Size = new Size(66, 71);
            btn_Add_User.TabIndex = 10;
            btn_Add_User.UseVisualStyleBackColor = true;
            btn_Add_User.Click += btn_Add_User_Click;
            // 
            // ctr_Users_Grid_View1
            // 
            ctr_Users_Grid_View1.BackColor = SystemColors.Control;
            ctr_Users_Grid_View1.Location = new Point(32, 359);
            ctr_Users_Grid_View1.Name = "ctr_Users_Grid_View1";
            ctr_Users_Grid_View1.Size = new Size(984, 264);
            ctr_Users_Grid_View1.TabIndex = 11;
            ctr_Users_Grid_View1.Click += ctr_Users_Grid_View1_Click;
            // 
            // btn_Refesh
            // 
            btn_Refesh.FlatAppearance.BorderColor = SystemColors.Control;
            btn_Refesh.Image = Properties.Resources.refresh;
            btn_Refesh.Location = new Point(993, 0);
            btn_Refesh.Name = "btn_Refesh";
            btn_Refesh.Size = new Size(49, 47);
            btn_Refesh.TabIndex = 12;
            btn_Refesh.UseVisualStyleBackColor = true;
            btn_Refesh.Click += btn_Refesh_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(32, 321);
            label1.Name = "label1";
            label1.Size = new Size(76, 23);
            label1.TabIndex = 13;
            label1.Text = "Filter By:";
            label1.Click += label1_Click;
            // 
            // comboBox1
            // 
            comboBox1.BackColor = SystemColors.ScrollBar;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "None", "User ID", "Person ID", "Full Name", "UserName", "Is Active" });
            comboBox1.Location = new Point(113, 323);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(184, 23);
            comboBox1.TabIndex = 14;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Brown;
            label2.Location = new Point(400, 206);
            label2.Name = "label2";
            label2.Size = new Size(228, 45);
            label2.TabIndex = 15;
            label2.Text = "Manage Users";
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.ScrollBar;
            textBox1.Location = new Point(303, 323);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(175, 23);
            textBox1.TabIndex = 16;
            textBox1.Visible = false;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // comboBox2
            // 
            comboBox2.BackColor = SystemColors.ScrollBar;
            comboBox2.FormattingEnabled = true;
            comboBox2.ItemHeight = 15;
            comboBox2.Items.AddRange(new object[] { "All", "Yes", "No" });
            comboBox2.Location = new Point(303, 323);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(79, 23);
            comboBox2.TabIndex = 17;
            comboBox2.Visible = false;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // lbl_Records
            // 
            lbl_Records.AutoSize = true;
            lbl_Records.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_Records.Location = new Point(32, 636);
            lbl_Records.Name = "lbl_Records";
            lbl_Records.Size = new Size(87, 21);
            lbl_Records.TabIndex = 19;
            lbl_Records.Text = "# Records:";
            // 
            // ManageUsers
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1042, 690);
            Controls.Add(lbl_Records);
            Controls.Add(comboBox2);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(comboBox1);
            Controls.Add(label1);
            Controls.Add(btn_Refesh);
            Controls.Add(ctr_Users_Grid_View1);
            Controls.Add(btn_Add_User);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "ManageUsers";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Manage Users";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button btn_Add_User;
        private ctr_Users_Grid_View ctr_Users_Grid_View1;
        private Button btn_Refesh;
        private Label label1;
        private ComboBox comboBox1;
        private Label label2;
        private TextBox textBox1;
        private ComboBox comboBox2;
        private Label lbl_Records;
    }
}