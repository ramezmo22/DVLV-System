using DVLV.UI.Properties;

namespace DVLV.UI.Tests_Manage
{
    partial class Take_Test
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
            ctr_Vision_Test1 = new ctr_Vision_Test();
            panel1 = new Panel();
            pictureBox8 = new PictureBox();
            label4 = new Label();
            rdb_Fail = new RadioButton();
            rdb_Pass = new RadioButton();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            txt_Notes = new TextBox();
            btn_Save = new Button();
            btn_Close = new Button();
            ctr_Written_Test1 = new DVLV.UI.Tests_Manage.Written_Test.ctr_Written_Test();
            ctr_Street_Test1 = new DVLV.UI.Tests_Manage.Street_Test.ctr_Street_Test();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // ctr_Vision_Test1
            // 
            ctr_Vision_Test1.Location = new Point(12, 12);
            ctr_Vision_Test1.Name = "ctr_Vision_Test1";
            ctr_Vision_Test1.Size = new Size(474, 487);
            ctr_Vision_Test1.TabIndex = 0;
            ctr_Vision_Test1.Visible = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox8);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(rdb_Fail);
            panel1.Controls.Add(rdb_Pass);
            panel1.Location = new Point(12, 505);
            panel1.Name = "panel1";
            panel1.Size = new Size(474, 34);
            panel1.TabIndex = 1;
            // 
            // pictureBox8
            // 
            pictureBox8.Image = Resources.Number_32;
            pictureBox8.Location = new Point(92, 0);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(33, 32);
            pictureBox8.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox8.TabIndex = 21;
            pictureBox8.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(27, 7);
            label4.Name = "label4";
            label4.Size = new Size(54, 20);
            label4.TabIndex = 6;
            label4.Text = "Result:";
            // 
            // rdb_Fail
            // 
            rdb_Fail.AutoSize = true;
            rdb_Fail.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rdb_Fail.Location = new Point(204, 5);
            rdb_Fail.Name = "rdb_Fail";
            rdb_Fail.Size = new Size(49, 24);
            rdb_Fail.TabIndex = 1;
            rdb_Fail.TabStop = true;
            rdb_Fail.Text = "Fail";
            rdb_Fail.UseVisualStyleBackColor = true;
            // 
            // rdb_Pass
            // 
            rdb_Pass.AutoSize = true;
            rdb_Pass.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rdb_Pass.Location = new Point(140, 5);
            rdb_Pass.Name = "rdb_Pass";
            rdb_Pass.Size = new Size(54, 24);
            rdb_Pass.TabIndex = 0;
            rdb_Pass.TabStop = true;
            rdb_Pass.Text = "Pass";
            rdb_Pass.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Resources.Notes_32;
            pictureBox1.Location = new Point(104, 543);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(33, 32);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 22;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(39, 550);
            label1.Name = "label1";
            label1.Size = new Size(53, 20);
            label1.TabIndex = 23;
            label1.Text = "Notes:";
            // 
            // txt_Notes
            // 
            txt_Notes.Location = new Point(152, 545);
            txt_Notes.Multiline = true;
            txt_Notes.Name = "txt_Notes";
            txt_Notes.Size = new Size(334, 91);
            txt_Notes.TabIndex = 24;
            // 
            // btn_Save
            // 
            btn_Save.Font = new Font("Segoe UI", 10F);
            btn_Save.Image = Resources.Save_32;
            btn_Save.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Save.Location = new Point(374, 642);
            btn_Save.Name = "btn_Save";
            btn_Save.Size = new Size(112, 37);
            btn_Save.TabIndex = 25;
            btn_Save.Text = "Save";
            btn_Save.UseVisualStyleBackColor = true;
            btn_Save.Click += btn_Save_Click;
            // 
            // btn_Close
            // 
            btn_Close.Font = new Font("Segoe UI", 10F);
            btn_Close.Image = Resources.Close_32;
            btn_Close.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Close.Location = new Point(256, 642);
            btn_Close.Name = "btn_Close";
            btn_Close.Size = new Size(112, 37);
            btn_Close.TabIndex = 26;
            btn_Close.Text = "Close";
            btn_Close.UseVisualStyleBackColor = true;
            btn_Close.Click += btn_Close_Click;
            // 
            // ctr_Written_Test1
            // 
            ctr_Written_Test1.Location = new Point(12, 12);
            ctr_Written_Test1.Name = "ctr_Written_Test1";
            ctr_Written_Test1.Size = new Size(474, 487);
            ctr_Written_Test1.TabIndex = 27;
            ctr_Written_Test1.Visible = false;
            // 
            // ctr_Street_Test1
            // 
            ctr_Street_Test1.Location = new Point(12, 12);
            ctr_Street_Test1.Name = "ctr_Street_Test1";
            ctr_Street_Test1.Size = new Size(474, 487);
            ctr_Street_Test1.TabIndex = 28;
            ctr_Street_Test1.Visible = false;
            // 
            // Take_Test
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(498, 694);
            Controls.Add(ctr_Street_Test1);
            Controls.Add(ctr_Written_Test1);
            Controls.Add(btn_Close);
            Controls.Add(btn_Save);
            Controls.Add(txt_Notes);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Controls.Add(ctr_Vision_Test1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "Take_Test";
            ShowIcon = false;
            Text = "Take Test";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ctr_Vision_Test ctr_Vision_Test1;
        private Panel panel1;
        private RadioButton rdb_Fail;
        private RadioButton rdb_Pass;
        private Label label4;
        private PictureBox pictureBox8;
        private PictureBox pictureBox1;
        private Label label1;
        private TextBox txt_Notes;
        private Button btn_Save;
        private Button btn_Close;
        private Written_Test.ctr_Written_Test ctr_Written_Test1;
        private Street_Test.ctr_Street_Test ctr_Street_Test1;
    }
}