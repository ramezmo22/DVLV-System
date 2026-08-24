using DVLV.UI.Properties;

namespace DVLV.UI
{
    partial class Update_Application_Type
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
            components = new System.ComponentModel.Container();
            lbl_Header = new Label();
            lbl_ID_Title = new Label();
            lbl_Title_Title = new Label();
            lbl_Fees_Title = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            txt_Application_Title = new TextBox();
            txt_Application_Fees = new TextBox();
            errorProvider1 = new ErrorProvider(components);
            btn_Save = new Button();
            btn_Close = new Button();
            lbl_ID = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // lbl_Header
            // 
            lbl_Header.AutoSize = true;
            lbl_Header.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_Header.ForeColor = Color.DarkRed;
            lbl_Header.Location = new Point(55, 27);
            lbl_Header.Name = "lbl_Header";
            lbl_Header.Size = new Size(337, 37);
            lbl_Header.TabIndex = 0;
            lbl_Header.Text = "Update Application Type";
            // 
            // lbl_ID_Title
            // 
            lbl_ID_Title.AutoSize = true;
            lbl_ID_Title.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            lbl_ID_Title.Location = new Point(55, 89);
            lbl_ID_Title.Name = "lbl_ID_Title";
            lbl_ID_Title.Size = new Size(37, 25);
            lbl_ID_Title.TabIndex = 1;
            lbl_ID_Title.Text = "ID:";
            // 
            // lbl_Title_Title
            // 
            lbl_Title_Title.AutoSize = true;
            lbl_Title_Title.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            lbl_Title_Title.Location = new Point(37, 136);
            lbl_Title_Title.Name = "lbl_Title_Title";
            lbl_Title_Title.Size = new Size(55, 25);
            lbl_Title_Title.TabIndex = 2;
            lbl_Title_Title.Text = "Title:";
            // 
            // lbl_Fees_Title
            // 
            lbl_Fees_Title.AutoSize = true;
            lbl_Fees_Title.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            lbl_Fees_Title.Location = new Point(37, 183);
            lbl_Fees_Title.Name = "lbl_Fees_Title";
            lbl_Fees_Title.Size = new Size(55, 25);
            lbl_Fees_Title.TabIndex = 3;
            lbl_Fees_Title.Text = "Fees:";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Resources.ApplicationTitle;
            pictureBox1.Location = new Point(108, 133);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(32, 32);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Resources.money_32;
            pictureBox2.Location = new Point(108, 180);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(32, 32);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // txt_Application_Title
            // 
            txt_Application_Title.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_Application_Title.Location = new Point(146, 137);
            txt_Application_Title.Name = "txt_Application_Title";
            txt_Application_Title.Size = new Size(291, 25);
            txt_Application_Title.TabIndex = 6;
            // 
            // txt_Application_Fees
            // 
            txt_Application_Fees.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_Application_Fees.Location = new Point(146, 183);
            txt_Application_Fees.Name = "txt_Application_Fees";
            txt_Application_Fees.Size = new Size(291, 25);
            txt_Application_Fees.TabIndex = 7;
            txt_Application_Fees.TextChanged += txt_Application_Fees_TextChanged;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // btn_Save
            // 
            btn_Save.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            btn_Save.Image = Resources.Save_32;
            btn_Save.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Save.Location = new Point(324, 226);
            btn_Save.Name = "btn_Save";
            btn_Save.Size = new Size(113, 37);
            btn_Save.TabIndex = 8;
            btn_Save.Text = "Save";
            btn_Save.UseVisualStyleBackColor = true;
            btn_Save.Click += btn_Save_Click;
            // 
            // btn_Close
            // 
            btn_Close.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            btn_Close.Image = Resources.Close_32;
            btn_Close.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Close.Location = new Point(205, 226);
            btn_Close.Name = "btn_Close";
            btn_Close.Size = new Size(113, 37);
            btn_Close.TabIndex = 9;
            btn_Close.Text = "Close";
            btn_Close.UseVisualStyleBackColor = true;
            btn_Close.Click += btn_Close_Click;
            // 
            // lbl_ID
            // 
            lbl_ID.AutoSize = true;
            lbl_ID.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            lbl_ID.Location = new Point(146, 89);
            lbl_ID.Name = "lbl_ID";
            lbl_ID.Size = new Size(36, 25);
            lbl_ID.TabIndex = 10;
            lbl_ID.Text = "???";
            // 
            // Update_Application_Type
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(467, 280);
            Controls.Add(lbl_ID);
            Controls.Add(btn_Close);
            Controls.Add(btn_Save);
            Controls.Add(txt_Application_Fees);
            Controls.Add(txt_Application_Title);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(lbl_Fees_Title);
            Controls.Add(lbl_Title_Title);
            Controls.Add(lbl_ID_Title);
            Controls.Add(lbl_Header);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "Update_Application_Type";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Update Application Type";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_Header;
        private Label lbl_ID_Title;
        private Label lbl_Title_Title;
        private Label lbl_Fees_Title;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private TextBox txt_Application_Title;
        private TextBox txt_Application_Fees;
        private ErrorProvider errorProvider1;
        private Button btn_Close;
        private Button btn_Save;
        private Label lbl_ID;
    }
}