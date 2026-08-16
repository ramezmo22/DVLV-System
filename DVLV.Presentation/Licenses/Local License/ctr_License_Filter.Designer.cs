namespace DVLV.UI.Licenses
{
    partial class ctr_License_Filter
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
            components = new System.ComponentModel.Container();
            groupBox1 = new GroupBox();
            btn_Search = new Button();
            txt_License_Filter = new TextBox();
            label1 = new Label();
            errorProvider = new ErrorProvider(components);
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btn_Search);
            groupBox1.Controls.Add(txt_License_Filter);
            groupBox1.Controls.Add(label1);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(545, 77);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Filter";
            // 
            // btn_Search
            // 
            btn_Search.Image = Properties.Resources.License_View_32;
            btn_Search.Location = new Point(433, 16);
            btn_Search.Name = "btn_Search";
            btn_Search.Size = new Size(75, 55);
            btn_Search.TabIndex = 2;
            btn_Search.UseVisualStyleBackColor = true;
            btn_Search.Click += btn_Search_Click;
            // 
            // txt_License_Filter
            // 
            txt_License_Filter.Location = new Point(113, 33);
            txt_License_Filter.Name = "txt_License_Filter";
            txt_License_Filter.Size = new Size(284, 23);
            txt_License_Filter.TabIndex = 1;
            txt_License_Filter.TextChanged += txt_License_Filter_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(23, 33);
            label1.Name = "label1";
            label1.Size = new Size(84, 21);
            label1.TabIndex = 0;
            label1.Text = "LicenseID:";
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // ctr_License_Filter
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBox1);
            Name = "ctr_License_Filter";
            Size = new Size(545, 77);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btn_Search;
        private TextBox txt_License_Filter;
        private Label label1;
        private ErrorProvider errorProvider;
    }
}
