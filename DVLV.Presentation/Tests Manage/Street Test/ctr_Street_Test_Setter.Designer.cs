using DVLV.UI.Properties;

namespace DVLV.UI.Tests_Manage.Street_Test
{
    partial class ctr_Street_Test_Setter
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
            lbl_HeaderLoackedTest = new Label();
            lbl_LastAppointmentDate = new Label();
            dtp_LastAppointmentDate = new DateTimePicker();
            ctr_Retake_Test1 = new ctr_Retake_Test();
            btn_Save = new Button();
            dtp_Date = new DateTimePicker();
            lbl_Fees = new Label();
            lbl_Trail = new Label();
            lbl_Name = new Label();
            lbl_LicenseClass = new Label();
            pictureBox7 = new PictureBox();
            pictureBox6 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            lbl_DrivingLicenseApplicationID = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            lbl_header = new Label();
            pictureBox1 = new PictureBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lbl_HeaderLoackedTest);
            groupBox1.Controls.Add(lbl_LastAppointmentDate);
            groupBox1.Controls.Add(dtp_LastAppointmentDate);
            groupBox1.Controls.Add(ctr_Retake_Test1);
            groupBox1.Controls.Add(btn_Save);
            groupBox1.Controls.Add(dtp_Date);
            groupBox1.Controls.Add(lbl_Fees);
            groupBox1.Controls.Add(lbl_Trail);
            groupBox1.Controls.Add(lbl_Name);
            groupBox1.Controls.Add(lbl_LicenseClass);
            groupBox1.Controls.Add(pictureBox7);
            groupBox1.Controls.Add(pictureBox6);
            groupBox1.Controls.Add(pictureBox5);
            groupBox1.Controls.Add(pictureBox4);
            groupBox1.Controls.Add(pictureBox3);
            groupBox1.Controls.Add(pictureBox2);
            groupBox1.Controls.Add(lbl_DrivingLicenseApplicationID);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(lbl_header);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(443, 581);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Street Test";
            // 
            // lbl_HeaderLoackedTest
            // 
            lbl_HeaderLoackedTest.AutoSize = true;
            lbl_HeaderLoackedTest.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_HeaderLoackedTest.ForeColor = Color.Red;
            lbl_HeaderLoackedTest.Location = new Point(37, 176);
            lbl_HeaderLoackedTest.Name = "lbl_HeaderLoackedTest";
            lbl_HeaderLoackedTest.Size = new Size(354, 20);
            lbl_HeaderLoackedTest.TabIndex = 51;
            lbl_HeaderLoackedTest.Text = "Person already sat for the test,  Appointment locked.";
            lbl_HeaderLoackedTest.Visible = false;
            // 
            // lbl_LastAppointmentDate
            // 
            lbl_LastAppointmentDate.AutoSize = true;
            lbl_LastAppointmentDate.Location = new Point(289, 332);
            lbl_LastAppointmentDate.Name = "lbl_LastAppointmentDate";
            lbl_LastAppointmentDate.Size = new Size(129, 15);
            lbl_LastAppointmentDate.TabIndex = 73;
            lbl_LastAppointmentDate.Text = "Last Appointment Date";
            lbl_LastAppointmentDate.Visible = false;
            // 
            // dtp_LastAppointmentDate
            // 
            dtp_LastAppointmentDate.Enabled = false;
            dtp_LastAppointmentDate.Format = DateTimePickerFormat.Short;
            dtp_LastAppointmentDate.Location = new Point(289, 350);
            dtp_LastAppointmentDate.Name = "dtp_LastAppointmentDate";
            dtp_LastAppointmentDate.Size = new Size(130, 23);
            dtp_LastAppointmentDate.TabIndex = 72;
            dtp_LastAppointmentDate.Visible = false;
            // 
            // ctr_Retake_Test1
            // 
            ctr_Retake_Test1.Enabled = false;
            ctr_Retake_Test1.Location = new Point(6, 413);
            ctr_Retake_Test1.Name = "ctr_Retake_Test1";
            ctr_Retake_Test1.Size = new Size(431, 105);
            ctr_Retake_Test1.TabIndex = 71;
            // 
            // btn_Save
            // 
            btn_Save.Font = new Font("Segoe UI", 10F);
            btn_Save.Image = Resources.Save_32;
            btn_Save.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Save.Location = new Point(325, 526);
            btn_Save.Name = "btn_Save";
            btn_Save.Size = new Size(112, 37);
            btn_Save.TabIndex = 70;
            btn_Save.Text = "Save";
            btn_Save.UseVisualStyleBackColor = true;
            btn_Save.Click += btn_Save_Click;
            // 
            // dtp_Date
            // 
            dtp_Date.Format = DateTimePickerFormat.Short;
            dtp_Date.Location = new Point(146, 350);
            dtp_Date.Name = "dtp_Date";
            dtp_Date.Size = new Size(137, 23);
            dtp_Date.TabIndex = 69;
            // 
            // lbl_Fees
            // 
            lbl_Fees.AutoSize = true;
            lbl_Fees.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_Fees.Location = new Point(146, 378);
            lbl_Fees.Name = "lbl_Fees";
            lbl_Fees.Size = new Size(30, 20);
            lbl_Fees.TabIndex = 68;
            lbl_Fees.Text = "???";
            // 
            // lbl_Trail
            // 
            lbl_Trail.AutoSize = true;
            lbl_Trail.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_Trail.Location = new Point(146, 313);
            lbl_Trail.Name = "lbl_Trail";
            lbl_Trail.Size = new Size(17, 20);
            lbl_Trail.TabIndex = 67;
            lbl_Trail.Text = "0";
            // 
            // lbl_Name
            // 
            lbl_Name.AutoSize = true;
            lbl_Name.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_Name.Location = new Point(146, 281);
            lbl_Name.Name = "lbl_Name";
            lbl_Name.Size = new Size(30, 20);
            lbl_Name.TabIndex = 66;
            lbl_Name.Text = "???";
            // 
            // lbl_LicenseClass
            // 
            lbl_LicenseClass.AutoSize = true;
            lbl_LicenseClass.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_LicenseClass.Location = new Point(146, 250);
            lbl_LicenseClass.Name = "lbl_LicenseClass";
            lbl_LicenseClass.Size = new Size(30, 20);
            lbl_LicenseClass.TabIndex = 65;
            lbl_LicenseClass.Text = "???";
            // 
            // pictureBox7
            // 
            pictureBox7.Image = Resources.money_32;
            pictureBox7.Location = new Point(97, 376);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(32, 32);
            pictureBox7.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox7.TabIndex = 64;
            pictureBox7.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = Resources.Calendar_32;
            pictureBox6.Location = new Point(97, 343);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(32, 32);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 63;
            pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Resources.Count_32;
            pictureBox5.Location = new Point(97, 310);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(32, 32);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 62;
            pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Resources.Person_32;
            pictureBox4.Location = new Point(97, 277);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(32, 32);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 61;
            pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Resources.License_Type_32;
            pictureBox3.Location = new Point(97, 244);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(32, 32);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 60;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Resources.Number_32;
            pictureBox2.Location = new Point(97, 211);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(32, 32);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 59;
            pictureBox2.TabStop = false;
            // 
            // lbl_DrivingLicenseApplicationID
            // 
            lbl_DrivingLicenseApplicationID.AutoSize = true;
            lbl_DrivingLicenseApplicationID.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_DrivingLicenseApplicationID.Location = new Point(146, 219);
            lbl_DrivingLicenseApplicationID.Name = "lbl_DrivingLicenseApplicationID";
            lbl_DrivingLicenseApplicationID.Size = new Size(30, 20);
            lbl_DrivingLicenseApplicationID.TabIndex = 58;
            lbl_DrivingLicenseApplicationID.Text = "???";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(48, 379);
            label6.Name = "label6";
            label6.Size = new Size(43, 20);
            label6.TabIndex = 57;
            label6.Text = "Fees:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(46, 346);
            label5.Name = "label5";
            label5.Size = new Size(45, 20);
            label5.TabIndex = 56;
            label5.Text = "Date:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(49, 313);
            label4.Name = "label4";
            label4.Size = new Size(42, 20);
            label4.TabIndex = 55;
            label4.Text = "Trial:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(37, 281);
            label3.Name = "label3";
            label3.Size = new Size(54, 20);
            label3.TabIndex = 54;
            label3.Text = "Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(27, 250);
            label2.Name = "label2";
            label2.Size = new Size(64, 20);
            label2.TabIndex = 53;
            label2.Text = "D. Class:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(6, 219);
            label1.Name = "label1";
            label1.Size = new Size(85, 20);
            label1.TabIndex = 52;
            label1.Text = "D.L.App.ID:";
            // 
            // lbl_header
            // 
            lbl_header.AutoSize = true;
            lbl_header.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_header.ForeColor = Color.IndianRed;
            lbl_header.Location = new Point(122, 139);
            lbl_header.Name = "lbl_header";
            lbl_header.Size = new Size(183, 37);
            lbl_header.TabIndex = 50;
            lbl_header.Text = "Schedule Test";
            lbl_header.TextAlign = ContentAlignment.TopCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Resources.driving_test_512;
            pictureBox1.Location = new Point(108, 17);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(216, 110);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 49;
            pictureBox1.TabStop = false;
            // 
            // ctr_Street_Test_Setter
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBox1);
            Name = "ctr_Street_Test_Setter";
            Size = new Size(443, 581);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label lbl_HeaderLoackedTest;
        private Label lbl_LastAppointmentDate;
        private DateTimePicker dtp_LastAppointmentDate;
        private ctr_Retake_Test ctr_Retake_Test1;
        private Button btn_Save;
        private DateTimePicker dtp_Date;
        private Label lbl_Fees;
        private Label lbl_Trail;
        private Label lbl_Name;
        private Label lbl_LicenseClass;
        private PictureBox pictureBox7;
        private PictureBox pictureBox6;
        private PictureBox pictureBox5;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private Label lbl_DrivingLicenseApplicationID;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label lbl_header;
        private PictureBox pictureBox1;
    }
}
