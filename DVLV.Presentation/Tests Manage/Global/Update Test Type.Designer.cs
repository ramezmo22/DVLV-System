using DVLV.UI.Properties;

namespace DVLV.UI
{
    partial class Update_Test_Type
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
            lbl_ID = new Label();
            btn_Close = new Button();
            btn_Save = new Button();
            txt_Test_Fees = new TextBox();
            txt_Test_Title = new TextBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            lbl_Fees_Title = new Label();
            lbl_Title_Title = new Label();
            lbl_ID_Title = new Label();
            lbl_Header = new Label();
            txt_Describtion = new TextBox();
            pictureBox3 = new PictureBox();
            label1 = new Label();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // lbl_ID
            // 
            lbl_ID.AutoSize = true;
            lbl_ID.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            lbl_ID.Location = new Point(175, 82);
            lbl_ID.Name = "lbl_ID";
            lbl_ID.Size = new Size(36, 25);
            lbl_ID.TabIndex = 21;
            lbl_ID.Text = "???";
            // 
            // btn_Close
            // 
            btn_Close.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            btn_Close.Image = Resources.Close_32;
            btn_Close.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Close.Location = new Point(234, 325);
            btn_Close.Name = "btn_Close";
            btn_Close.Size = new Size(113, 37);
            btn_Close.TabIndex = 3;
            btn_Close.Text = "Close";
            btn_Close.UseVisualStyleBackColor = true;
            btn_Close.Click += btn_Close_Click;
            // 
            // btn_Save
            // 
            btn_Save.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            btn_Save.Image = Resources.Save_32;
            btn_Save.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Save.Location = new Point(353, 325);
            btn_Save.Name = "btn_Save";
            btn_Save.Size = new Size(113, 37);
            btn_Save.TabIndex = 4;
            btn_Save.Text = "Save";
            btn_Save.UseVisualStyleBackColor = true;
            btn_Save.Click += btn_Save_Click;
            // 
            // txt_Test_Fees
            // 
            txt_Test_Fees.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_Test_Fees.Location = new Point(185, 281);
            txt_Test_Fees.Name = "txt_Test_Fees";
            txt_Test_Fees.Size = new Size(291, 25);
            txt_Test_Fees.TabIndex = 2;
            txt_Test_Fees.TextChanged += txt_Test_Fees_TextChanged;
            // 
            // txt_Test_Title
            // 
            txt_Test_Title.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_Test_Title.Location = new Point(185, 129);
            txt_Test_Title.Name = "txt_Test_Title";
            txt_Test_Title.Size = new Size(291, 25);
            txt_Test_Title.TabIndex = 0;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Resources.money_32;
            pictureBox2.Location = new Point(137, 279);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(32, 32);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 16;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Resources.ApplicationTitle;
            pictureBox1.Location = new Point(137, 126);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(32, 32);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // lbl_Fees_Title
            // 
            lbl_Fees_Title.AutoSize = true;
            lbl_Fees_Title.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            lbl_Fees_Title.Location = new Point(66, 282);
            lbl_Fees_Title.Name = "lbl_Fees_Title";
            lbl_Fees_Title.Size = new Size(55, 25);
            lbl_Fees_Title.TabIndex = 14;
            lbl_Fees_Title.Text = "Fees:";
            // 
            // lbl_Title_Title
            // 
            lbl_Title_Title.AutoSize = true;
            lbl_Title_Title.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            lbl_Title_Title.Location = new Point(66, 129);
            lbl_Title_Title.Name = "lbl_Title_Title";
            lbl_Title_Title.Size = new Size(55, 25);
            lbl_Title_Title.TabIndex = 13;
            lbl_Title_Title.Text = "Title:";
            // 
            // lbl_ID_Title
            // 
            lbl_ID_Title.AutoSize = true;
            lbl_ID_Title.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            lbl_ID_Title.Location = new Point(84, 82);
            lbl_ID_Title.Name = "lbl_ID_Title";
            lbl_ID_Title.Size = new Size(37, 25);
            lbl_ID_Title.TabIndex = 12;
            lbl_ID_Title.Text = "ID:";
            // 
            // lbl_Header
            // 
            lbl_Header.AutoSize = true;
            lbl_Header.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_Header.ForeColor = Color.DarkRed;
            lbl_Header.Location = new Point(130, 19);
            lbl_Header.Name = "lbl_Header";
            lbl_Header.Size = new Size(240, 37);
            lbl_Header.TabIndex = 11;
            lbl_Header.Text = "Update Test Type";
            // 
            // txt_Describtion
            // 
            txt_Describtion.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_Describtion.Location = new Point(185, 173);
            txt_Describtion.Multiline = true;
            txt_Describtion.Name = "txt_Describtion";
            txt_Describtion.Size = new Size(291, 89);
            txt_Describtion.TabIndex = 1;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Resources.ApplicationTitle;
            pictureBox3.Location = new Point(137, 170);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(32, 32);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 23;
            pictureBox3.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label1.Location = new Point(7, 173);
            label1.Name = "label1";
            label1.Size = new Size(114, 25);
            label1.TabIndex = 22;
            label1.Text = "Discribtion:";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // Update_Test_Type
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(505, 384);
            Controls.Add(txt_Describtion);
            Controls.Add(pictureBox3);
            Controls.Add(label1);
            Controls.Add(lbl_ID);
            Controls.Add(btn_Close);
            Controls.Add(btn_Save);
            Controls.Add(txt_Test_Fees);
            Controls.Add(txt_Test_Title);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(lbl_Fees_Title);
            Controls.Add(lbl_Title_Title);
            Controls.Add(lbl_ID_Title);
            Controls.Add(lbl_Header);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Update_Test_Type";
            ShowIcon = false;
            Text = "Update Test Type";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_ID;
        private Button btn_Close;
        private Button btn_Save;
        private TextBox txt_Test_Fees;
        private TextBox txt_Test_Title;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Label lbl_Fees_Title;
        private Label lbl_Title_Title;
        private Label lbl_ID_Title;
        private Label lbl_Header;
        private TextBox txt_Describtion;
        private PictureBox pictureBox3;
        private Label label1;
        private ErrorProvider errorProvider1;
    }
}