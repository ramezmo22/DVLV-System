namespace DVLV.UI.Drivers
{
    partial class List_Drivers
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
            dataGridView1 = new DataGridView();
            cbx_Filter_By = new ComboBox();
            txt_Filter_Input = new TextBox();
            label1 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            lbl_Records = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.Location = new Point(12, 321);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1013, 332);
            dataGridView1.TabIndex = 0;
            // 
            // cbx_Filter_By
            // 
            cbx_Filter_By.DropDownStyle = ComboBoxStyle.DropDownList;
            cbx_Filter_By.FormattingEnabled = true;
            cbx_Filter_By.Items.AddRange(new object[] { "None", "Driver ID", "Person ID", "National No.", "Full Name" });
            cbx_Filter_By.Location = new Point(100, 292);
            cbx_Filter_By.Name = "cbx_Filter_By";
            cbx_Filter_By.Size = new Size(169, 23);
            cbx_Filter_By.TabIndex = 1;
            cbx_Filter_By.SelectedIndexChanged += cbx_Filter_By_SelectedIndexChanged;
            // 
            // txt_Filter_Input
            // 
            txt_Filter_Input.Location = new Point(275, 292);
            txt_Filter_Input.Name = "txt_Filter_Input";
            txt_Filter_Input.Size = new Size(162, 23);
            txt_Filter_Input.TabIndex = 2;
            txt_Filter_Input.TextChanged += txt_Filter_Input_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 290);
            label1.Name = "label1";
            label1.Size = new Size(87, 25);
            label1.TabIndex = 3;
            label1.Text = "Filter By:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(192, 0, 0);
            label2.Location = new Point(414, 217);
            label2.Name = "label2";
            label2.Size = new Size(209, 37);
            label2.TabIndex = 4;
            label2.Text = "Manage Drivers";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Driver_Main;
            pictureBox1.Location = new Point(370, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(293, 215);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.Image = Properties.Resources.Close_32;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(914, 668);
            button1.Name = "button1";
            button1.Size = new Size(111, 35);
            button1.TabIndex = 6;
            button1.Text = "Close";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // lbl_Records
            // 
            lbl_Records.AutoSize = true;
            lbl_Records.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_Records.Location = new Point(12, 668);
            lbl_Records.Name = "lbl_Records";
            lbl_Records.Size = new Size(100, 25);
            lbl_Records.TabIndex = 7;
            lbl_Records.Text = "# Records:";
            // 
            // List_Drivers
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1037, 715);
            Controls.Add(lbl_Records);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(txt_Filter_Input);
            Controls.Add(cbx_Filter_By);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "List_Drivers";
            ShowIcon = false;
            ShowInTaskbar = false;
            Text = "List Drivers";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private ComboBox cbx_Filter_By;
        private TextBox txt_Filter_Input;
        private Label label1;
        private Label label2;
        private PictureBox pictureBox1;
        private Button button1;
        private Label lbl_Records;
    }
}