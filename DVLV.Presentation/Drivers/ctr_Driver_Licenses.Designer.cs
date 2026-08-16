namespace DVLV.UI.Drivers
{
    partial class ctr_Driver_Licenses
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            lbl_Rercords = new Label();
            label1 = new Label();
            dgv_Local_Licenses_History = new DataGridView();
            tabPage2 = new TabPage();
            lbl_Inter_Records = new Label();
            label3 = new Label();
            dataGridView1 = new DataGridView();
            groupBox1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_Local_Licenses_History).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tabControl1);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1029, 282);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Driver Licenses";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(3, 21);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1023, 258);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(lbl_Rercords);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(dgv_Local_Licenses_History);
            tabPage1.Location = new Point(4, 26);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1015, 228);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Local";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // lbl_Rercords
            // 
            lbl_Rercords.AutoSize = true;
            lbl_Rercords.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_Rercords.Location = new Point(6, 205);
            lbl_Rercords.Name = "lbl_Rercords";
            lbl_Rercords.Size = new Size(76, 20);
            lbl_Rercords.TabIndex = 2;
            lbl_Rercords.Text = "#Records:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(6, 3);
            label1.Name = "label1";
            label1.Size = new Size(161, 20);
            label1.TabIndex = 1;
            label1.Text = "Local Licenses History:";
            // 
            // dgv_Local_Licenses_History
            // 
            dgv_Local_Licenses_History.AllowUserToAddRows = false;
            dgv_Local_Licenses_History.AllowUserToDeleteRows = false;
            dgv_Local_Licenses_History.BackgroundColor = SystemColors.Control;
            dgv_Local_Licenses_History.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Local_Licenses_History.GridColor = SystemColors.Control;
            dgv_Local_Licenses_History.Location = new Point(6, 26);
            dgv_Local_Licenses_History.Name = "dgv_Local_Licenses_History";
            dgv_Local_Licenses_History.ReadOnly = true;
            dgv_Local_Licenses_History.Size = new Size(1006, 176);
            dgv_Local_Licenses_History.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(lbl_Inter_Records);
            tabPage2.Controls.Add(label3);
            tabPage2.Controls.Add(dataGridView1);
            tabPage2.Location = new Point(4, 26);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1015, 228);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "International";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // lbl_Inter_Records
            // 
            lbl_Inter_Records.AutoSize = true;
            lbl_Inter_Records.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_Inter_Records.Location = new Point(4, 205);
            lbl_Inter_Records.Name = "lbl_Inter_Records";
            lbl_Inter_Records.Size = new Size(76, 20);
            lbl_Inter_Records.TabIndex = 5;
            lbl_Inter_Records.Text = "#Records:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(4, 3);
            label3.Name = "label3";
            label3.Size = new Size(214, 20);
            label3.TabIndex = 4;
            label3.Text = "International Licenses History:";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.GridColor = SystemColors.Control;
            dataGridView1.Location = new Point(4, 26);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(1006, 176);
            dataGridView1.TabIndex = 3;
            // 
            // ctr_Driver_Licenses
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBox1);
            Name = "ctr_Driver_Licenses";
            Size = new Size(1029, 282);
            groupBox1.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_Local_Licenses_History).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private DataGridView dgv_Local_Licenses_History;
        private Label lbl_Rercords;
        private Label label1;
        private Label lbl_Inter_Records;
        private Label label3;
        private DataGridView dataGridView1;
    }
}
