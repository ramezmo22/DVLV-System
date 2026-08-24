using DVLV.UI.Properties;

namespace DVLV.UI
{
    partial class frmAddNewPerson
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
            label1 = new Label();
            lbl_PersonID = new Label();
            pictureBox1 = new PictureBox();
            ctr_Person_Card1 = new ctr_Person_Card();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lbl_Header
            // 
            lbl_Header.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lbl_Header.AutoSize = true;
            lbl_Header.Font = new Font("Yu Gothic UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_Header.ForeColor = Color.Firebrick;
            lbl_Header.Location = new Point(326, 9);
            lbl_Header.Name = "lbl_Header";
            lbl_Header.Size = new Size(196, 45);
            lbl_Header.TabIndex = 1;
            lbl_Header.Text = "Add Person ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(22, 64);
            label1.Name = "label1";
            label1.Size = new Size(87, 21);
            label1.TabIndex = 2;
            label1.Text = "Person ID :";
            // 
            // lbl_PersonID
            // 
            lbl_PersonID.AutoSize = true;
            lbl_PersonID.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_PersonID.Location = new Point(162, 64);
            lbl_PersonID.Name = "lbl_PersonID";
            lbl_PersonID.Size = new Size(31, 21);
            lbl_PersonID.TabIndex = 3;
            lbl_PersonID.Text = "???";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Resources.Number_32;
            pictureBox1.Location = new Point(121, 63);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(29, 25);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // ctr_Person_Card1
            // 
            ctr_Person_Card1.Location = new Point(12, 88);
            ctr_Person_Card1.Name = "ctr_Person_Card1";
            ctr_Person_Card1.Size = new Size(820, 375);
            ctr_Person_Card1.TabIndex = 5;
            ctr_Person_Card1.OnPersonSelected += ctr_Person_Card1_OnPersonSelected;
            // 
            // frmAddNewPerson
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(847, 471);
            Controls.Add(ctr_Person_Card1);
            Controls.Add(pictureBox1);
            Controls.Add(lbl_PersonID);
            Controls.Add(label1);
            Controls.Add(lbl_Header);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmAddNewPerson";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add/Edit Person Info";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ctr_Person_Card ctr_Person_Card1;
        private Label lbl_Header;
        private Label label1;
        private Label lbl_PersonID;
        private PictureBox pictureBox1;
    }
}