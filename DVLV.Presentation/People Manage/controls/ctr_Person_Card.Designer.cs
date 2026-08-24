using DVLV.UI.Properties;

namespace DVLV.UI
{
    partial class ctr_Person_Card
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
            components = new System.ComponentModel.Container();
            lbl_NationalNumber = new Label();
            lbl_Address = new Label();
            lbl_Email = new Label();
            lbl_Gender = new Label();
            lbl_Name = new Label();
            txt_FirstName = new TextBox();
            txt_SecondName = new TextBox();
            txt_ThirdName = new TextBox();
            txt_LastName = new TextBox();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            pictureBox2 = new PictureBox();
            txt_National_Number = new TextBox();
            dtb_Data_Of_Bridth = new DateTimePicker();
            label5 = new Label();
            rdb_Male = new RadioButton();
            rdb_Female = new RadioButton();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            label6 = new Label();
            txt_Phone = new TextBox();
            pictureBox5 = new PictureBox();
            pictureBox6 = new PictureBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            pictureBox7 = new PictureBox();
            pictureBox8 = new PictureBox();
            pictureBox9 = new PictureBox();
            cbx_Countries = new ComboBox();
            label7 = new Label();
            pt_PersonImage = new PictureBox();
            lnk_Set_Image = new LinkLabel();
            lnk_Remove = new LinkLabel();
            btn_Close = new Button();
            btn_Save = new Button();
            ep_EmptyError = new ErrorProvider(components);
            ep_SpecialCharacters = new ErrorProvider(components);
            openFileDialog1 = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pt_PersonImage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ep_EmptyError).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ep_SpecialCharacters).BeginInit();
            SuspendLayout();
            // 
            // lbl_NationalNumber
            // 
            lbl_NationalNumber.Anchor = AnchorStyles.Left;
            lbl_NationalNumber.AutoSize = true;
            lbl_NationalNumber.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lbl_NationalNumber.Location = new Point(22, 99);
            lbl_NationalNumber.Name = "lbl_NationalNumber";
            lbl_NationalNumber.Size = new Size(108, 21);
            lbl_NationalNumber.TabIndex = 14;
            lbl_NationalNumber.Text = "National No:";
            // 
            // lbl_Address
            // 
            lbl_Address.Anchor = AnchorStyles.Left;
            lbl_Address.AutoSize = true;
            lbl_Address.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lbl_Address.Location = new Point(22, 225);
            lbl_Address.Name = "lbl_Address";
            lbl_Address.Size = new Size(74, 21);
            lbl_Address.TabIndex = 13;
            lbl_Address.Text = "Address:";
            // 
            // lbl_Email
            // 
            lbl_Email.Anchor = AnchorStyles.Left;
            lbl_Email.AutoSize = true;
            lbl_Email.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lbl_Email.Location = new Point(22, 183);
            lbl_Email.Name = "lbl_Email";
            lbl_Email.Size = new Size(57, 21);
            lbl_Email.TabIndex = 12;
            lbl_Email.Text = "Email:";
            // 
            // lbl_Gender
            // 
            lbl_Gender.Anchor = AnchorStyles.Left;
            lbl_Gender.AutoSize = true;
            lbl_Gender.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lbl_Gender.Location = new Point(22, 141);
            lbl_Gender.Name = "lbl_Gender";
            lbl_Gender.Size = new Size(70, 21);
            lbl_Gender.TabIndex = 11;
            lbl_Gender.Text = "Gender:";
            // 
            // lbl_Name
            // 
            lbl_Name.Anchor = AnchorStyles.Left;
            lbl_Name.AutoSize = true;
            lbl_Name.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lbl_Name.Location = new Point(22, 57);
            lbl_Name.Name = "lbl_Name";
            lbl_Name.Size = new Size(60, 21);
            lbl_Name.TabIndex = 8;
            lbl_Name.Text = "Name:";
            lbl_Name.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txt_FirstName
            // 
            txt_FirstName.Location = new Point(185, 50);
            txt_FirstName.Name = "txt_FirstName";
            txt_FirstName.Size = new Size(141, 23);
            txt_FirstName.TabIndex = 1;
            txt_FirstName.TextChanged += TextChangedValidation;
            txt_FirstName.Validating += TextboxValidation;
            // 
            // txt_SecondName
            // 
            txt_SecondName.Location = new Point(342, 50);
            txt_SecondName.Name = "txt_SecondName";
            txt_SecondName.Size = new Size(141, 23);
            txt_SecondName.TabIndex = 2;
            txt_SecondName.TextChanged += TextChangedValidation;
            txt_SecondName.Validating += TextboxValidation;
            // 
            // txt_ThirdName
            // 
            txt_ThirdName.Location = new Point(499, 50);
            txt_ThirdName.Name = "txt_ThirdName";
            txt_ThirdName.Size = new Size(141, 23);
            txt_ThirdName.TabIndex = 3;
            txt_ThirdName.TextChanged += TextChangedValidation;
            // 
            // txt_LastName
            // 
            txt_LastName.Location = new Point(656, 50);
            txt_LastName.Name = "txt_LastName";
            txt_LastName.Size = new Size(141, 23);
            txt_LastName.TabIndex = 4;
            txt_LastName.TextChanged += TextChangedValidation;
            txt_LastName.Validating += TextboxValidation;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Resources.Person_32;
            pictureBox1.Location = new Point(132, 48);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(32, 30);
            pictureBox1.TabIndex = 19;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(238, 26);
            label1.Name = "label1";
            label1.Size = new Size(32, 17);
            label1.TabIndex = 20;
            label1.Text = "First";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(384, 26);
            label2.Name = "label2";
            label2.Size = new Size(51, 17);
            label2.TabIndex = 21;
            label2.Text = "Second";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(549, 26);
            label3.Name = "label3";
            label3.Size = new Size(38, 17);
            label3.TabIndex = 22;
            label3.Text = "Third";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(701, 26);
            label4.Name = "label4";
            label4.Size = new Size(31, 17);
            label4.TabIndex = 23;
            label4.Text = "Last";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Resources.Number_32;
            pictureBox2.Location = new Point(132, 90);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(32, 30);
            pictureBox2.TabIndex = 24;
            pictureBox2.TabStop = false;
            //pictureBox2.Click += pictureBox2_Click;
            // 
            // txt_National_Number
            // 
            txt_National_Number.Location = new Point(185, 92);
            txt_National_Number.Name = "txt_National_Number";
            txt_National_Number.Size = new Size(141, 23);
            txt_National_Number.TabIndex = 5;
            txt_National_Number.TextChanged += TextChangedValidationWithNumbers;
            txt_National_Number.Validating += TextboxValidation;
            // 
            // dtb_Data_Of_Bridth
            // 
            dtb_Data_Of_Bridth.Format = DateTimePickerFormat.Short;
            dtb_Data_Of_Bridth.Location = new Point(502, 90);
            dtb_Data_Of_Bridth.MaxDate = new DateTime(2008, 2, 22, 0, 0, 0, 0);
            dtb_Data_Of_Bridth.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            dtb_Data_Of_Bridth.Name = "dtb_Data_Of_Bridth";
            dtb_Data_Of_Bridth.Size = new Size(131, 23);
            dtb_Data_Of_Bridth.TabIndex = 9;
            dtb_Data_Of_Bridth.Value = new DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Left;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label5.Location = new Point(346, 94);
            label5.Name = "label5";
            label5.Size = new Size(113, 21);
            label5.TabIndex = 27;
            label5.Text = "Date Of Birth:";
            // 
            // rdb_Male
            // 
            rdb_Male.AutoSize = true;
            rdb_Male.Font = new Font("Segoe UI", 9.75F);
            rdb_Male.Location = new Point(185, 136);
            rdb_Male.Name = "rdb_Male";
            rdb_Male.Size = new Size(55, 21);
            rdb_Male.TabIndex = 6;
            rdb_Male.TabStop = true;
            rdb_Male.Text = "Male";
            rdb_Male.UseVisualStyleBackColor = true;
            rdb_Male.CheckedChanged += rdb_Male_CheckedChanged;
            // 
            // rdb_Female
            // 
            rdb_Female.AutoSize = true;
            rdb_Female.Font = new Font("Segoe UI", 9.75F);
            rdb_Female.Location = new Point(288, 136);
            rdb_Female.Name = "rdb_Female";
            rdb_Female.Size = new Size(67, 21);
            rdb_Female.TabIndex = 7;
            rdb_Female.TabStop = true;
            rdb_Female.Text = "Female";
            rdb_Female.UseVisualStyleBackColor = true;
            rdb_Female.CheckedChanged += rdb_Female_CheckedChanged;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Resources.Man_32;
            pictureBox3.Location = new Point(132, 131);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(32, 31);
            pictureBox3.TabIndex = 30;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Resources.Woman_32;
            pictureBox4.Location = new Point(250, 131);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(32, 30);
            pictureBox4.TabIndex = 31;
            pictureBox4.TabStop = false;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Left;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label6.Location = new Point(396, 134);
            label6.Name = "label6";
            label6.Size = new Size(63, 21);
            label6.TabIndex = 32;
            label6.Text = "Phone:";
            // 
            // txt_Phone
            // 
            txt_Phone.Location = new Point(502, 131);
            txt_Phone.Name = "txt_Phone";
            txt_Phone.Size = new Size(131, 23);
            txt_Phone.TabIndex = 10;
            txt_Phone.Validating += JustNumberValidation;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Resources.Email_32;
            pictureBox5.Location = new Point(132, 173);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(32, 31);
            pictureBox5.TabIndex = 34;
            pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = Resources.Address_32;
            pictureBox6.Location = new Point(132, 215);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(32, 31);
            pictureBox6.TabIndex = 35;
            pictureBox6.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(185, 175);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(141, 23);
            textBox1.TabIndex = 8;
            textBox1.Validating += textBox1_Validating;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(185, 215);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(448, 102);
            textBox2.TabIndex = 12;
            textBox2.Validating += TextboxValidation;
            // 
            // pictureBox7
            // 
            pictureBox7.Image = Resources.Calendar_32;
            pictureBox7.Location = new Point(460, 89);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(32, 31);
            pictureBox7.TabIndex = 38;
            pictureBox7.TabStop = false;
            // 
            // pictureBox8
            // 
            pictureBox8.Image = Resources.Phone_32;
            pictureBox8.Location = new Point(460, 128);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(32, 31);
            pictureBox8.TabIndex = 39;
            pictureBox8.TabStop = false;
            // 
            // pictureBox9
            // 
            pictureBox9.Image = Resources.Country_32;
            pictureBox9.Location = new Point(460, 167);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(32, 31);
            pictureBox9.TabIndex = 40;
            pictureBox9.TabStop = false;
            // 
            // cbx_Countries
            // 
            cbx_Countries.FormattingEnabled = true;
            cbx_Countries.Location = new Point(502, 172);
            cbx_Countries.Name = "cbx_Countries";
            cbx_Countries.Size = new Size(131, 23);
            cbx_Countries.TabIndex = 11;
            cbx_Countries.Text = "Jordan";
            //cbx_Countries.SelectedIndexChanged += cbx_Countries_SelectedIndexChanged;
            cbx_Countries.Validating += cbx_Countries_Validating;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Left;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label7.Location = new Point(383, 174);
            label7.Name = "label7";
            label7.Size = new Size(76, 21);
            label7.TabIndex = 42;
            label7.Text = "Country:";
            // 
            // pt_PersonImage
            // 
            pt_PersonImage.Image = Resources.Male_5121;
            pt_PersonImage.Location = new Point(656, 90);
            pt_PersonImage.Name = "pt_PersonImage";
            pt_PersonImage.Size = new Size(141, 156);
            pt_PersonImage.SizeMode = PictureBoxSizeMode.Zoom;
            pt_PersonImage.TabIndex = 43;
            pt_PersonImage.TabStop = false;
            // 
            // lnk_Set_Image
            // 
            lnk_Set_Image.AutoSize = true;
            lnk_Set_Image.Location = new Point(699, 254);
            lnk_Set_Image.Name = "lnk_Set_Image";
            lnk_Set_Image.Size = new Size(59, 15);
            lnk_Set_Image.TabIndex = 13;
            lnk_Set_Image.TabStop = true;
            lnk_Set_Image.Text = "Set Image";
            lnk_Set_Image.LinkClicked += lnk_Set_Image_LinkClicked;
            // 
            // lnk_Remove
            // 
            lnk_Remove.AutoSize = true;
            lnk_Remove.Location = new Point(701, 280);
            lnk_Remove.Name = "lnk_Remove";
            lnk_Remove.Size = new Size(50, 15);
            lnk_Remove.TabIndex = 14;
            lnk_Remove.TabStop = true;
            lnk_Remove.Text = "Remove";
            lnk_Remove.Visible = false;
            lnk_Remove.LinkClicked += linkLabel1_LinkClicked;
            // 
            // btn_Close
            // 
            btn_Close.Font = new Font("Segoe UI", 11.25F);
            btn_Close.Image = Resources.Close_32;
            btn_Close.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Close.Location = new Point(396, 327);
            btn_Close.Name = "btn_Close";
            btn_Close.Size = new Size(111, 34);
            btn_Close.TabIndex = 16;
            btn_Close.Text = "Close";
            btn_Close.UseVisualStyleBackColor = true;
            btn_Close.Click += btn_Close_Click;
            // 
            // btn_Save
            // 
            btn_Save.Font = new Font("Segoe UI", 11.25F);
            btn_Save.Image = Resources.Save_32;
            btn_Save.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Save.Location = new Point(522, 327);
            btn_Save.Name = "btn_Save";
            btn_Save.Size = new Size(111, 34);
            btn_Save.TabIndex = 15;
            btn_Save.Text = "Save";
            btn_Save.UseVisualStyleBackColor = true;
            btn_Save.Click += btn_Save_Click;
            // 
            // ep_EmptyError
            // 
            ep_EmptyError.ContainerControl = this;
            // 
            // ep_SpecialCharacters
            // 
            ep_SpecialCharacters.ContainerControl = this;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // ctr_Person_Card
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btn_Save);
            Controls.Add(btn_Close);
            Controls.Add(lnk_Remove);
            Controls.Add(lnk_Set_Image);
            Controls.Add(pt_PersonImage);
            Controls.Add(label7);
            Controls.Add(cbx_Countries);
            Controls.Add(pictureBox9);
            Controls.Add(pictureBox8);
            Controls.Add(pictureBox7);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(pictureBox6);
            Controls.Add(pictureBox5);
            Controls.Add(txt_Phone);
            Controls.Add(label6);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(rdb_Female);
            Controls.Add(rdb_Male);
            Controls.Add(label5);
            Controls.Add(dtb_Data_Of_Bridth);
            Controls.Add(txt_National_Number);
            Controls.Add(pictureBox2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(txt_LastName);
            Controls.Add(txt_ThirdName);
            Controls.Add(txt_SecondName);
            Controls.Add(txt_FirstName);
            Controls.Add(lbl_NationalNumber);
            Controls.Add(lbl_Address);
            Controls.Add(lbl_Email);
            Controls.Add(lbl_Gender);
            Controls.Add(lbl_Name);
            Name = "ctr_Person_Card";
            Size = new Size(820, 375);
            Load += ctr_Person_Card_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            ((System.ComponentModel.ISupportInitialize)pt_PersonImage).EndInit();
            ((System.ComponentModel.ISupportInitialize)ep_EmptyError).EndInit();
            ((System.ComponentModel.ISupportInitialize)ep_SpecialCharacters).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_NationalNumber;
        private Label lbl_Address;
        private Label lbl_Email;
        private Label lbl_Gender;
        private Label lbl_Name;
        private TextBox txt_FirstName;
        private TextBox txt_SecondName;
        private TextBox txt_ThirdName;
        private TextBox txt_LastName;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private PictureBox pictureBox2;
        private TextBox txt_National_Number;
        private DateTimePicker dtb_Data_Of_Bridth;
        private Label label5;
        private RadioButton rdb_Male;
        private RadioButton rdb_Female;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private Label label6;
        private TextBox txt_Phone;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
        private TextBox textBox1;
        private TextBox textBox2;
        private PictureBox pictureBox7;
        private PictureBox pictureBox8;
        private PictureBox pictureBox9;
        private ComboBox cbx_Countries;
        private Label label7;
        private PictureBox pt_PersonImage;
        private LinkLabel lnk_Set_Image;
        private LinkLabel lnk_Remove;
        private Button btn_Close;
        private Button btn_Save;
        private ErrorProvider ep_EmptyError;
        private ErrorProvider ep_SpecialCharacters;
        private OpenFileDialog openFileDialog1;
    }
}
