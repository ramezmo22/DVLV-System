using DVLV.UI.Properties;

namespace DVLV.UI.controlls
{
    partial class Driving_License_Application_Info
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
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            lbl_License_Class_Info = new Label();
            lbl_License_Info = new Label();
            lbl_Number_Of_Passed_Tests = new Label();
            label3 = new Label();
            lbl_Driving_License_Application_ID = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(pictureBox4);
            groupBox1.Controls.Add(pictureBox3);
            groupBox1.Controls.Add(pictureBox2);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(lbl_License_Class_Info);
            groupBox1.Controls.Add(lbl_License_Info);
            groupBox1.Controls.Add(lbl_Number_Of_Passed_Tests);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(lbl_Driving_License_Application_ID);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(799, 141);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Driving license application info";
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Resources.PassedTests_32;
            pictureBox4.Location = new Point(523, 84);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(32, 32);
            pictureBox4.TabIndex = 10;
            pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Resources.License_Type_321;
            pictureBox3.Location = new Point(523, 32);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(32, 32);
            pictureBox3.TabIndex = 9;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Resources.License_View_321;
            pictureBox2.Location = new Point(118, 84);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(32, 32);
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Resources.Number_32;
            pictureBox1.Location = new Point(118, 32);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(32, 32);
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // lbl_License_Class_Info
            // 
            lbl_License_Class_Info.AutoSize = true;
            lbl_License_Class_Info.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_License_Class_Info.Location = new Point(566, 37);
            lbl_License_Class_Info.Name = "lbl_License_Class_Info";
            lbl_License_Class_Info.Size = new Size(31, 21);
            lbl_License_Class_Info.TabIndex = 6;
            lbl_License_Class_Info.Text = "???";
            // 
            // lbl_License_Info
            // 
            lbl_License_Info.AutoSize = true;
            lbl_License_Info.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_License_Info.ForeColor = SystemColors.ControlDarkDark;
            lbl_License_Info.Location = new Point(176, 93);
            lbl_License_Info.Name = "lbl_License_Info";
            lbl_License_Info.Size = new Size(133, 21);
            lbl_License_Info.TabIndex = 5;
            lbl_License_Info.Text = "show License Info";
            // 
            // lbl_Number_Of_Passed_Tests
            // 
            lbl_Number_Of_Passed_Tests.AutoSize = true;
            lbl_Number_Of_Passed_Tests.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_Number_Of_Passed_Tests.Location = new Point(566, 88);
            lbl_Number_Of_Passed_Tests.Name = "lbl_Number_Of_Passed_Tests";
            lbl_Number_Of_Passed_Tests.Size = new Size(35, 21);
            lbl_Number_Of_Passed_Tests.TabIndex = 4;
            lbl_Number_Of_Passed_Tests.Text = "0/0";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(396, 88);
            label3.Name = "label3";
            label3.Size = new Size(104, 21);
            label3.TabIndex = 3;
            label3.Text = "Passed Tests:";
            // 
            // lbl_Driving_License_Application_ID
            // 
            lbl_Driving_License_Application_ID.AutoSize = true;
            lbl_Driving_License_Application_ID.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_Driving_License_Application_ID.Location = new Point(172, 37);
            lbl_Driving_License_Application_ID.Name = "lbl_Driving_License_Application_ID";
            lbl_Driving_License_Application_ID.Size = new Size(31, 21);
            lbl_Driving_License_Application_ID.TabIndex = 2;
            lbl_Driving_License_Application_ID.Text = "???";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(333, 37);
            label2.Name = "label2";
            label2.Size = new Size(184, 21);
            label2.TabIndex = 1;
            label2.Text = "Application For License:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(18, 37);
            label1.Name = "label1";
            label1.Size = new Size(91, 21);
            label1.TabIndex = 0;
            label1.Text = "D.L.App ID:";
            // 
            // Driving_License_Application_Info
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBox1);
            Name = "Driving_License_Application_Info";
            Size = new Size(799, 141);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label3;
        private Label lbl_Driving_License_Application_ID;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Label lbl_License_Class_Info;
        private Label lbl_License_Info;
        private Label lbl_Number_Of_Passed_Tests;
    }
}
