using DVLV.UI.Properties;

namespace DVLV.UI.Tests_Manage
{
    partial class Schedule_Test
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
            btn_Close = new Button();
            ctr_Vision_Test_Setter1 = new ctr_Vision_Test_Setter();
            written_Test_Setter1 = new DVLV.UI.Tests_Manage.Written_Test.Written_Test_Setter();
            ctr_Street_Test_Setter1 = new DVLV.UI.Tests_Manage.Street_Test.ctr_Street_Test_Setter();
            SuspendLayout();
            // 
            // btn_Close
            // 
            btn_Close.Image = Resources.Close_32;
            btn_Close.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Close.Location = new Point(167, 610);
            btn_Close.Name = "btn_Close";
            btn_Close.Size = new Size(117, 38);
            btn_Close.TabIndex = 1;
            btn_Close.Text = "Close";
            btn_Close.UseVisualStyleBackColor = true;
            btn_Close.Click += btn_Close_Click;
            // 
            // ctr_Vision_Test_Setter1
            // 
            ctr_Vision_Test_Setter1.Location = new Point(10, 12);
            ctr_Vision_Test_Setter1.Name = "ctr_Vision_Test_Setter1";
            ctr_Vision_Test_Setter1.Size = new Size(443, 581);
            ctr_Vision_Test_Setter1.TabIndex = 2;
            ctr_Vision_Test_Setter1.Visible = false;
            // 
            // written_Test_Setter1
            // 
            written_Test_Setter1.Location = new Point(10, 12);
            written_Test_Setter1.Name = "written_Test_Setter1";
            written_Test_Setter1.Size = new Size(443, 581);
            written_Test_Setter1.TabIndex = 3;
            written_Test_Setter1.Visible = false;
            // 
            // ctr_Street_Test_Setter1
            // 
            ctr_Street_Test_Setter1.Location = new Point(10, 12);
            ctr_Street_Test_Setter1.Name = "ctr_Street_Test_Setter1";
            ctr_Street_Test_Setter1.Size = new Size(443, 581);
            ctr_Street_Test_Setter1.TabIndex = 4;
            ctr_Street_Test_Setter1.Visible = false;
            // 
            // Schedule_Test
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(465, 657);
            Controls.Add(ctr_Street_Test_Setter1);
            Controls.Add(written_Test_Setter1);
            Controls.Add(ctr_Vision_Test_Setter1);
            Controls.Add(btn_Close);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "Schedule_Test";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Schedule Test";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button btn_Close;
        private ctr_Vision_Test_Setter ctr_Vision_Test_Setter1;
        private Written_Test.Written_Test_Setter written_Test_Setter1;
        private Street_Test.ctr_Street_Test_Setter ctr_Street_Test_Setter1;
    }
}