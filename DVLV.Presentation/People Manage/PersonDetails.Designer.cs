namespace DVLV.UI
{
    partial class PersonDetails
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
            button1 = new Button();
            label1 = new Label();
            ctr_Person_Info1 = new ctr_Person_Info();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Image = Properties.Resources.Close_321;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(726, 448);
            button1.Name = "button1";
            button1.Size = new Size(105, 36);
            button1.TabIndex = 1;
            button1.Text = "   Close";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Firebrick;
            label1.Location = new Point(310, 18);
            label1.Name = "label1";
            label1.Size = new Size(190, 37);
            label1.TabIndex = 2;
            label1.Text = "Person Details";
            // 
            // ctr_Person_Info1
            // 
            ctr_Person_Info1.Location = new Point(12, 76);
            ctr_Person_Info1.Name = "ctr_Person_Info1";
            ctr_Person_Info1.Size = new Size(819, 366);
            ctr_Person_Info1.TabIndex = 3;
            ctr_Person_Info1.UpdatePersonInfo(_PersonID);
            // 
            // PersonDetails
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(856, 496);
            Controls.Add(ctr_Person_Info1);
            Controls.Add(label1);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "PersonDetails";
            ShowIcon = false;
            Text = "Person Details";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion


        private Button button1;
        private Label label1;
        private ctr_Person_Info ctr_Person_Info1;
        // private ctr_Person_Info ctr_Person_Info1;
    }
}