using DVLV.UI.Properties;

namespace DVLV.UI
{
    partial class New_Local_Driving_License_Application
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
            lbl_Header = new Label();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            btn_Next = new Button();
            ctr_Person_Info1 = new ctr_Person_Info();
            person_Finder_Filter1 = new Person_Finder_Filter();
            tabPage2 = new TabPage();
            cbx_License_Classes = new ComboBox();
            lbl_Created_By = new Label();
            lbl_Application_Fees = new Label();
            lbl_Application_Date = new Label();
            lbl_Application_ID = new Label();
            pictureBox5 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            btn_Save = new Button();
            btn_Close = new Button();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lbl_Header
            // 
            lbl_Header.AutoSize = true;
            lbl_Header.Font = new Font("Segoe UI Semibold", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_Header.ForeColor = Color.DarkRed;
            lbl_Header.Location = new Point(167, 27);
            lbl_Header.Name = "lbl_Header";
            lbl_Header.Size = new Size(519, 40);
            lbl_Header.TabIndex = 0;
            lbl_Header.Text = "New Local Driving License Application";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(3, 89);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(865, 527);
            tabControl1.TabIndex = 1;
            tabControl1.SelectedIndexChanged += tabControl1_SelectedIndexChanged;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = SystemColors.Control;
            tabPage1.Controls.Add(btn_Next);
            tabPage1.Controls.Add(ctr_Person_Info1);
            tabPage1.Controls.Add(person_Finder_Filter1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(857, 499);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Personal Info";
            // 
            // btn_Next
            // 
            btn_Next.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_Next.Enabled = false;
            btn_Next.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_Next.Image = Resources.Next_32;
            btn_Next.ImageAlign = ContentAlignment.MiddleRight;
            btn_Next.Location = new Point(756, 452);
            btn_Next.Name = "btn_Next";
            btn_Next.Size = new Size(89, 39);
            btn_Next.TabIndex = 3;
            btn_Next.Text = "Next";
            btn_Next.TextAlign = ContentAlignment.MiddleLeft;
            btn_Next.UseVisualStyleBackColor = true;
            btn_Next.Click += btn_Next_Click;
            // 
            // ctr_Person_Info1
            // 
            ctr_Person_Info1.BackColor = Color.Transparent;
            ctr_Person_Info1.Location = new Point(8, 80);
            ctr_Person_Info1.Name = "ctr_Person_Info1";
            ctr_Person_Info1.Size = new Size(838, 366);
            ctr_Person_Info1.TabIndex = 1;
            // 
            // person_Finder_Filter1
            // 
            person_Finder_Filter1.BackColor = Color.Transparent;
            person_Finder_Filter1.Location = new Point(7, 6);
            person_Finder_Filter1.Name = "person_Finder_Filter1";
            person_Finder_Filter1.Size = new Size(839, 68);
            person_Finder_Filter1.TabIndex = 0;
            person_Finder_Filter1.PersonFound += person_Finder_Filter1_PersonFound;
            // 
            // tabPage2
            // 
            tabPage2.BackColor = SystemColors.Control;
            tabPage2.Controls.Add(cbx_License_Classes);
            tabPage2.Controls.Add(lbl_Created_By);
            tabPage2.Controls.Add(lbl_Application_Fees);
            tabPage2.Controls.Add(lbl_Application_Date);
            tabPage2.Controls.Add(lbl_Application_ID);
            tabPage2.Controls.Add(pictureBox5);
            tabPage2.Controls.Add(pictureBox4);
            tabPage2.Controls.Add(pictureBox3);
            tabPage2.Controls.Add(pictureBox2);
            tabPage2.Controls.Add(pictureBox1);
            tabPage2.Controls.Add(label6);
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(label3);
            tabPage2.Controls.Add(label2);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(857, 499);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Application Info.";
            tabPage2.MouseClick += tabPage2_MouseClick;
            // 
            // cbx_License_Classes
            // 
            cbx_License_Classes.FormattingEnabled = true;
            cbx_License_Classes.Items.AddRange(new object[] { "Class 1 - Small motorcycle", "Class 2 - Heavy motorcycle license", "Class 3 - Ordinary driving license", "Class 4 - Commercial", "Class 5 - Agricultural", "Class 6 - Small and medium bus", "Class 7 - Truck and heavy vehicle" });
            cbx_License_Classes.Location = new Point(313, 180);
            cbx_License_Classes.Name = "cbx_License_Classes";
            cbx_License_Classes.Size = new Size(272, 23);
            cbx_License_Classes.TabIndex = 14;
            // 
            // lbl_Created_By
            // 
            lbl_Created_By.AutoSize = true;
            lbl_Created_By.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_Created_By.Location = new Point(313, 292);
            lbl_Created_By.Name = "lbl_Created_By";
            lbl_Created_By.Size = new Size(41, 21);
            lbl_Created_By.TabIndex = 13;
            lbl_Created_By.Text = "user";
            // 
            // lbl_Application_Fees
            // 
            lbl_Application_Fees.AutoSize = true;
            lbl_Application_Fees.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_Application_Fees.Location = new Point(313, 237);
            lbl_Application_Fees.Name = "lbl_Application_Fees";
            lbl_Application_Fees.Size = new Size(37, 21);
            lbl_Application_Fees.TabIndex = 12;
            lbl_Application_Fees.Text = "000";
            // 
            // lbl_Application_Date
            // 
            lbl_Application_Date.AutoSize = true;
            lbl_Application_Date.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_Application_Date.Location = new Point(313, 127);
            lbl_Application_Date.Name = "lbl_Application_Date";
            lbl_Application_Date.Size = new Size(96, 21);
            lbl_Application_Date.TabIndex = 11;
            lbl_Application_Date.Text = "00/00/0000";
            // 
            // lbl_Application_ID
            // 
            lbl_Application_ID.AutoSize = true;
            lbl_Application_ID.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_Application_ID.Location = new Point(313, 72);
            lbl_Application_ID.Name = "lbl_Application_ID";
            lbl_Application_ID.Size = new Size(41, 21);
            lbl_Application_ID.TabIndex = 10;
            lbl_Application_ID.Text = "[???]";
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Resources.User_32__2;
            pictureBox5.Location = new Point(244, 290);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(32, 32);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 9;
            pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Resources.money_321;
            pictureBox4.Location = new Point(244, 233);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(32, 32);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 8;
            pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Resources.License_Type_32;
            pictureBox3.Location = new Point(244, 179);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(32, 32);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 7;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Resources.Calendar_32;
            pictureBox2.Location = new Point(244, 122);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(32, 32);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Resources.Number_32;
            pictureBox1.Location = new Point(244, 68);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(32, 32);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(72, 292);
            label6.Name = "label6";
            label6.Size = new Size(94, 21);
            label6.TabIndex = 4;
            label6.Text = "Created By:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(72, 237);
            label5.Name = "label5";
            label5.Size = new Size(135, 21);
            label5.TabIndex = 3;
            label5.Text = "Application Fees:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(72, 182);
            label4.Name = "label4";
            label4.Size = new Size(108, 21);
            label4.TabIndex = 2;
            label4.Text = "License Class:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(72, 127);
            label3.Name = "label3";
            label3.Size = new Size(146, 21);
            label3.TabIndex = 1;
            label3.Text = "Appplication Date:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(72, 72);
            label2.Name = "label2";
            label2.Size = new Size(134, 21);
            label2.TabIndex = 0;
            label2.Text = "D.L.Appplication:";
            // 
            // btn_Save
            // 
            btn_Save.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_Save.Enabled = false;
            btn_Save.Font = new Font("Segoe UI", 10F);
            btn_Save.Image = Resources.Save_32;
            btn_Save.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Save.Location = new Point(743, 639);
            btn_Save.Name = "btn_Save";
            btn_Save.Size = new Size(109, 39);
            btn_Save.TabIndex = 2;
            btn_Save.Text = "Save";
            btn_Save.UseVisualStyleBackColor = true;
            btn_Save.Click += btn_Save_Click;
            // 
            // btn_Close
            // 
            btn_Close.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_Close.Font = new Font("Segoe UI", 10F);
            btn_Close.Image = Resources.Close_32;
            btn_Close.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Close.Location = new Point(628, 639);
            btn_Close.Name = "btn_Close";
            btn_Close.Size = new Size(109, 39);
            btn_Close.TabIndex = 3;
            btn_Close.Text = "Close";
            btn_Close.UseVisualStyleBackColor = true;
            btn_Close.Click += btn_Close_Click;
            // 
            // New_Local_Driving_License_Application
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(865, 690);
            Controls.Add(btn_Close);
            Controls.Add(btn_Save);
            Controls.Add(tabControl1);
            Controls.Add(lbl_Header);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "New_Local_Driving_License_Application";
            ShowIcon = false;
            Text = "New Local Driving License Application";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_Header;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private ctr_Person_Info ctr_Person_Info1;
        private Person_Finder_Filter person_Finder_Filter1;
        private Button btn_Save;
        private Button btn_Close;
        private Button btn_Next;
        private Label label2;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private PictureBox pictureBox5;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private ComboBox cbx_License_Classes;
        private Label lbl_Created_By;
        private Label lbl_Application_Fees;
        private Label lbl_Application_Date;
        private Label lbl_Application_ID;
    }
}