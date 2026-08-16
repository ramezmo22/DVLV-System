namespace DVLV.Presentation
{
    partial class ManagePeople
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            label1 = new Label();
            comboBox1 = new ComboBox();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            txt_NumOfRecords = new Label();
            errorProvider1 = new ErrorProvider(components);
            MKTB_FillterationInput = new MaskedTextBox();
            btn_CloseForm = new Button();
            btn_AddPerson = new Button();
            crt_People_Grid_View1 = new crt_People_Grid_View();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(5, 297);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(73, 20);
            label1.TabIndex = 0;
            label1.Text = "Filter By :";
            // 
            // comboBox1
            // 
            comboBox1.BackColor = SystemColors.ScrollBar;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.ForeColor = SystemColors.WindowText;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "None", "PersonID", "NationalNo", "FirstName", "SecondName", "ThirdName", "LastName", "Nationality", "Gendor", "Phone", "Email" });
            comboBox1.Location = new Point(97, 297);
            comboBox1.Margin = new Padding(4, 3, 4, 3);
            comboBox1.Name = "comboBox1";
            comboBox1.RightToLeft = RightToLeft.No;
            comboBox1.Size = new Size(184, 23);
            comboBox1.TabIndex = 1;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top;
            pictureBox1.Image = UI.Properties.Resources.People_400;
            pictureBox1.Location = new Point(499, 30);
            pictureBox1.Margin = new Padding(4, 3, 4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(268, 190);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.FlatStyle = FlatStyle.System;
            label2.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Firebrick;
            label2.Location = new Point(512, 223);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(239, 37);
            label2.TabIndex = 3;
            label2.Text = "Manage People";
            // 
            // txt_NumOfRecords
            // 
            txt_NumOfRecords.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            txt_NumOfRecords.AutoSize = true;
            txt_NumOfRecords.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_NumOfRecords.Location = new Point(13, 713);
            txt_NumOfRecords.Name = "txt_NumOfRecords";
            txt_NumOfRecords.Size = new Size(150, 20);
            txt_NumOfRecords.TabIndex = 5;
            txt_NumOfRecords.Text = "Number of records :";
            txt_NumOfRecords.Click += txt_NumOfRecords_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // MKTB_FillterationInput
            // 
            MKTB_FillterationInput.BeepOnError = true;
            MKTB_FillterationInput.Location = new Point(301, 298);
            MKTB_FillterationInput.Name = "MKTB_FillterationInput";
            MKTB_FillterationInput.Size = new Size(210, 23);
            MKTB_FillterationInput.TabIndex = 6;
            MKTB_FillterationInput.Visible = false;
            MKTB_FillterationInput.TextChanged += MKTB_FillterationInput_TextChanged;
            // 
            // btn_CloseForm
            // 
            btn_CloseForm.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_CloseForm.Image = UI.Properties.Resources.Close_32;
            btn_CloseForm.ImageAlign = ContentAlignment.MiddleLeft;
            btn_CloseForm.Location = new Point(1083, 695);
            btn_CloseForm.Name = "btn_CloseForm";
            btn_CloseForm.Size = new Size(117, 38);
            btn_CloseForm.TabIndex = 8;
            btn_CloseForm.Text = "Close";
            btn_CloseForm.UseVisualStyleBackColor = true;
            btn_CloseForm.Click += btn_CloseForm_Click;
            // 
            // btn_AddPerson
            // 
            btn_AddPerson.Anchor = AnchorStyles.Right;
            btn_AddPerson.Image = UI.Properties.Resources.Add_Person_40;
            btn_AddPerson.Location = new Point(1144, 297);
            btn_AddPerson.Name = "btn_AddPerson";
            btn_AddPerson.Size = new Size(56, 44);
            btn_AddPerson.TabIndex = 9;
            btn_AddPerson.UseVisualStyleBackColor = true;
            btn_AddPerson.Click += btn_AddPerson_Click;
            // 
            // crt_People_Grid_View1
            // 
            crt_People_Grid_View1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            crt_People_Grid_View1.AutoSize = true;
            crt_People_Grid_View1.BackColor = Color.White;
            crt_People_Grid_View1.Location = new Point(13, 348);
            crt_People_Grid_View1.Margin = new Padding(4, 3, 4, 3);
            crt_People_Grid_View1.Name = "crt_People_Grid_View1";
            crt_People_Grid_View1.Size = new Size(1187, 322);
            crt_People_Grid_View1.TabIndex = 4;
            crt_People_Grid_View1.Load += crt_People_Grid_View1_Load;
            // 
            // ManagePeople
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1230, 756);
            Controls.Add(btn_AddPerson);
            Controls.Add(btn_CloseForm);
            Controls.Add(MKTB_FillterationInput);
            Controls.Add(txt_NumOfRecords);
            Controls.Add(crt_People_Grid_View1);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(comboBox1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 3, 4, 3);
            Name = "ManagePeople";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Manage People";
            Load += ManagePeople_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private crt_People_Grid_View crt_People_Grid_View1;
        private Label txt_NumOfRecords;
        private ErrorProvider errorProvider1;
        private MaskedTextBox MKTB_FillterationInput;
        private Button btn_AddPerson;
        private Button btn_CloseForm;
    }
}