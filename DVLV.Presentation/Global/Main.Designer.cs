namespace DVLV.Presentation
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            menuStrip1 = new MenuStrip();
            applicationToolStripMenuItem = new ToolStripMenuItem();
            drivingLicensesServicesToolStripMenuItem = new ToolStripMenuItem();
            newDrivingLicenseToolStripMenuItem = new ToolStripMenuItem();
            localLicenseToolStripMenuItem = new ToolStripMenuItem();
            intaToolStripMenuItem = new ToolStripMenuItem();
            renewDrivingLicenseToolStripMenuItem = new ToolStripMenuItem();
            replaccementForLostOrDamToolStripMenuItem = new ToolStripMenuItem();
            releaseDetainedDrivingLicenseToolStripMenuItem = new ToolStripMenuItem();
            retakeTestToolStripMenuItem = new ToolStripMenuItem();
            manageToolStripMenuItem = new ToolStripMenuItem();
            localDrivingLicenseApplicationsToolStripMenuItem = new ToolStripMenuItem();
            internationalLicenseApplicationsToolStripMenuItem = new ToolStripMenuItem();
            detainLicensesToolStripMenuItem = new ToolStripMenuItem();
            manageDetaindLicensesToolStripMenuItem = new ToolStripMenuItem();
            detainLicenseToolStripMenuItem = new ToolStripMenuItem();
            releaseDetainedLicenseToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            manageApplicationTypesToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            manageToolStripMenuItem1 = new ToolStripMenuItem();
            peopleToolStripMenuItem = new ToolStripMenuItem();
            driversToolStripMenuItem = new ToolStripMenuItem();
            usersToolStripMenuItem = new ToolStripMenuItem();
            accountSettingsToolStripMenuItem = new ToolStripMenuItem();
            currentUserInfoToolStripMenuItem = new ToolStripMenuItem();
            changePasswordToolStripMenuItem = new ToolStripMenuItem();
            signOutToolStripMenuItem = new ToolStripMenuItem();
            pictureBox1 = new PictureBox();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.White;
            menuStrip1.ImageScalingSize = new Size(32, 32);
            menuStrip1.Items.AddRange(new ToolStripItem[] { applicationToolStripMenuItem, peopleToolStripMenuItem, driversToolStripMenuItem, usersToolStripMenuItem, accountSettingsToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 2, 0, 2);
            menuStrip1.Size = new Size(1813, 72);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // applicationToolStripMenuItem
            // 
            applicationToolStripMenuItem.BackColor = Color.White;
            applicationToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { drivingLicensesServicesToolStripMenuItem, manageToolStripMenuItem, detainLicensesToolStripMenuItem, toolStripSeparator1, manageApplicationTypesToolStripMenuItem, toolStripSeparator2, manageToolStripMenuItem1 });
            applicationToolStripMenuItem.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            applicationToolStripMenuItem.ForeColor = Color.DimGray;
            applicationToolStripMenuItem.Image = (Image)resources.GetObject("applicationToolStripMenuItem.Image");
            applicationToolStripMenuItem.ImageAlign = ContentAlignment.MiddleLeft;
            applicationToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            applicationToolStripMenuItem.ImageTransparentColor = Color.FromArgb(192, 255, 192);
            applicationToolStripMenuItem.Name = "applicationToolStripMenuItem";
            applicationToolStripMenuItem.Size = new Size(194, 68);
            applicationToolStripMenuItem.Text = "Applications";
            applicationToolStripMenuItem.Click += applicationToolStripMenuItem_Click;
            applicationToolStripMenuItem.MouseDown += accountSettingsToolStripMenuItem_MouseDown;
            // 
            // drivingLicensesServicesToolStripMenuItem
            // 
            drivingLicensesServicesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newDrivingLicenseToolStripMenuItem, renewDrivingLicenseToolStripMenuItem, replaccementForLostOrDamToolStripMenuItem, releaseDetainedDrivingLicenseToolStripMenuItem, retakeTestToolStripMenuItem });
            drivingLicensesServicesToolStripMenuItem.Image = UI.Properties.Resources.Driver_License_48;
            drivingLicensesServicesToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            drivingLicensesServicesToolStripMenuItem.Name = "drivingLicensesServicesToolStripMenuItem";
            drivingLicensesServicesToolStripMenuItem.Size = new Size(359, 70);
            drivingLicensesServicesToolStripMenuItem.Text = "Driving Licenses Services";
            // 
            // newDrivingLicenseToolStripMenuItem
            // 
            newDrivingLicenseToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { localLicenseToolStripMenuItem, intaToolStripMenuItem });
            newDrivingLicenseToolStripMenuItem.Image = UI.Properties.Resources.New_Driving_License_32;
            newDrivingLicenseToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            newDrivingLicenseToolStripMenuItem.Name = "newDrivingLicenseToolStripMenuItem";
            newDrivingLicenseToolStripMenuItem.Size = new Size(459, 38);
            newDrivingLicenseToolStripMenuItem.Text = "New Driving License";
            // 
            // localLicenseToolStripMenuItem
            // 
            localLicenseToolStripMenuItem.Image = UI.Properties.Resources.Local_32;
            localLicenseToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            localLicenseToolStripMenuItem.Name = "localLicenseToolStripMenuItem";
            localLicenseToolStripMenuItem.Size = new Size(278, 38);
            localLicenseToolStripMenuItem.Text = "Local License";
            localLicenseToolStripMenuItem.Click += localLicenseToolStripMenuItem_Click;
            // 
            // intaToolStripMenuItem
            // 
            intaToolStripMenuItem.Image = UI.Properties.Resources.International_32;
            intaToolStripMenuItem.Name = "intaToolStripMenuItem";
            intaToolStripMenuItem.Size = new Size(278, 38);
            intaToolStripMenuItem.Text = "International License";
            intaToolStripMenuItem.Click += intaToolStripMenuItem_Click;
            // 
            // renewDrivingLicenseToolStripMenuItem
            // 
            renewDrivingLicenseToolStripMenuItem.Image = UI.Properties.Resources.Renew_Driving_License_32;
            renewDrivingLicenseToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            renewDrivingLicenseToolStripMenuItem.Name = "renewDrivingLicenseToolStripMenuItem";
            renewDrivingLicenseToolStripMenuItem.Size = new Size(459, 38);
            renewDrivingLicenseToolStripMenuItem.Text = "Renew Driving License";
            renewDrivingLicenseToolStripMenuItem.Click += renewDrivingLicenseToolStripMenuItem_Click;
            // 
            // replaccementForLostOrDamToolStripMenuItem
            // 
            replaccementForLostOrDamToolStripMenuItem.Image = UI.Properties.Resources.Damaged_Driving_License_32;
            replaccementForLostOrDamToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            replaccementForLostOrDamToolStripMenuItem.Name = "replaccementForLostOrDamToolStripMenuItem";
            replaccementForLostOrDamToolStripMenuItem.Size = new Size(459, 38);
            replaccementForLostOrDamToolStripMenuItem.Text = "Replacement for Lost or Damaged License";
            replaccementForLostOrDamToolStripMenuItem.Click += replaccementForLostOrDamToolStripMenuItem_Click;
            // 
            // releaseDetainedDrivingLicenseToolStripMenuItem
            // 
            releaseDetainedDrivingLicenseToolStripMenuItem.Image = UI.Properties.Resources.Detained_Driving_License_32;
            releaseDetainedDrivingLicenseToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            releaseDetainedDrivingLicenseToolStripMenuItem.Name = "releaseDetainedDrivingLicenseToolStripMenuItem";
            releaseDetainedDrivingLicenseToolStripMenuItem.Size = new Size(459, 38);
            releaseDetainedDrivingLicenseToolStripMenuItem.Text = "Release Detained Driving License";
            releaseDetainedDrivingLicenseToolStripMenuItem.Click += releaseDetainedDrivingLicenseToolStripMenuItem_Click;
            // 
            // retakeTestToolStripMenuItem
            // 
            retakeTestToolStripMenuItem.Image = UI.Properties.Resources.Retake_Test_32;
            retakeTestToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            retakeTestToolStripMenuItem.Name = "retakeTestToolStripMenuItem";
            retakeTestToolStripMenuItem.Size = new Size(459, 38);
            retakeTestToolStripMenuItem.Text = "Retake Test";
            retakeTestToolStripMenuItem.Click += retakeTestToolStripMenuItem_Click;
            // 
            // manageToolStripMenuItem
            // 
            manageToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { localDrivingLicenseApplicationsToolStripMenuItem, internationalLicenseApplicationsToolStripMenuItem });
            manageToolStripMenuItem.Image = UI.Properties.Resources.Manage_Applications_64;
            manageToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            manageToolStripMenuItem.Name = "manageToolStripMenuItem";
            manageToolStripMenuItem.Size = new Size(359, 70);
            manageToolStripMenuItem.Text = "Manage Applications";
            // 
            // localDrivingLicenseApplicationsToolStripMenuItem
            // 
            localDrivingLicenseApplicationsToolStripMenuItem.Image = UI.Properties.Resources.LocalDriving_License;
            localDrivingLicenseApplicationsToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            localDrivingLicenseApplicationsToolStripMenuItem.Name = "localDrivingLicenseApplicationsToolStripMenuItem";
            localDrivingLicenseApplicationsToolStripMenuItem.Size = new Size(390, 38);
            localDrivingLicenseApplicationsToolStripMenuItem.Text = "Local Driving License Applications";
            localDrivingLicenseApplicationsToolStripMenuItem.Click += localDrivingLicenseApplicationsToolStripMenuItem_Click;
            // 
            // internationalLicenseApplicationsToolStripMenuItem
            // 
            internationalLicenseApplicationsToolStripMenuItem.Image = UI.Properties.Resources.International_321;
            internationalLicenseApplicationsToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            internationalLicenseApplicationsToolStripMenuItem.Name = "internationalLicenseApplicationsToolStripMenuItem";
            internationalLicenseApplicationsToolStripMenuItem.Size = new Size(390, 38);
            internationalLicenseApplicationsToolStripMenuItem.Text = "International License Applications";
            internationalLicenseApplicationsToolStripMenuItem.Click += internationalLicenseApplicationsToolStripMenuItem_Click;
            // 
            // detainLicensesToolStripMenuItem
            // 
            detainLicensesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { manageDetaindLicensesToolStripMenuItem, detainLicenseToolStripMenuItem, releaseDetainedLicenseToolStripMenuItem });
            detainLicensesToolStripMenuItem.Image = UI.Properties.Resources.Detain_64;
            detainLicensesToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            detainLicensesToolStripMenuItem.Name = "detainLicensesToolStripMenuItem";
            detainLicensesToolStripMenuItem.Size = new Size(359, 70);
            detainLicensesToolStripMenuItem.Text = "Detain Licenses";
            // 
            // manageDetaindLicensesToolStripMenuItem
            // 
            manageDetaindLicensesToolStripMenuItem.Image = UI.Properties.Resources.Detain_64;
            manageDetaindLicensesToolStripMenuItem.Name = "manageDetaindLicensesToolStripMenuItem";
            manageDetaindLicensesToolStripMenuItem.Size = new Size(302, 30);
            manageDetaindLicensesToolStripMenuItem.Text = "Manage Detaind Licenses";
            manageDetaindLicensesToolStripMenuItem.Click += manageDetaindLicensesToolStripMenuItem_Click;
            // 
            // detainLicenseToolStripMenuItem
            // 
            detainLicenseToolStripMenuItem.Image = UI.Properties.Resources.Detain_64;
            detainLicenseToolStripMenuItem.Name = "detainLicenseToolStripMenuItem";
            detainLicenseToolStripMenuItem.Size = new Size(302, 30);
            detainLicenseToolStripMenuItem.Text = "Detain License";
            detainLicenseToolStripMenuItem.Click += detainLicenseToolStripMenuItem_Click;
            // 
            // releaseDetainedLicenseToolStripMenuItem
            // 
            releaseDetainedLicenseToolStripMenuItem.Image = UI.Properties.Resources.Release_Detained_License_64;
            releaseDetainedLicenseToolStripMenuItem.Name = "releaseDetainedLicenseToolStripMenuItem";
            releaseDetainedLicenseToolStripMenuItem.Size = new Size(302, 30);
            releaseDetainedLicenseToolStripMenuItem.Text = "Release Detained License";
            releaseDetainedLicenseToolStripMenuItem.Click += releaseDetainedLicenseToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(356, 6);
            // 
            // manageApplicationTypesToolStripMenuItem
            // 
            manageApplicationTypesToolStripMenuItem.Image = UI.Properties.Resources.Application_Types_64;
            manageApplicationTypesToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            manageApplicationTypesToolStripMenuItem.Name = "manageApplicationTypesToolStripMenuItem";
            manageApplicationTypesToolStripMenuItem.Size = new Size(359, 70);
            manageApplicationTypesToolStripMenuItem.Text = "Manage Application Types";
            manageApplicationTypesToolStripMenuItem.Click += manageApplicationTypesToolStripMenuItem_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(356, 6);
            // 
            // manageToolStripMenuItem1
            // 
            manageToolStripMenuItem1.Image = UI.Properties.Resources.Test_Type_64;
            manageToolStripMenuItem1.ImageScaling = ToolStripItemImageScaling.None;
            manageToolStripMenuItem1.Name = "manageToolStripMenuItem1";
            manageToolStripMenuItem1.Size = new Size(359, 70);
            manageToolStripMenuItem1.Text = "Manage Test Types";
            manageToolStripMenuItem1.Click += manageToolStripMenuItem1_Click;
            // 
            // peopleToolStripMenuItem
            // 
            peopleToolStripMenuItem.BackColor = Color.White;
            peopleToolStripMenuItem.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            peopleToolStripMenuItem.ForeColor = Color.DimGray;
            peopleToolStripMenuItem.Image = (Image)resources.GetObject("peopleToolStripMenuItem.Image");
            peopleToolStripMenuItem.ImageAlign = ContentAlignment.MiddleLeft;
            peopleToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            peopleToolStripMenuItem.ImageTransparentColor = Color.Transparent;
            peopleToolStripMenuItem.Name = "peopleToolStripMenuItem";
            peopleToolStripMenuItem.Size = new Size(145, 68);
            peopleToolStripMenuItem.Text = "People";
            peopleToolStripMenuItem.Click += peopleToolStripMenuItem_Click;
            peopleToolStripMenuItem.MouseDown += accountSettingsToolStripMenuItem_MouseDown;
            // 
            // driversToolStripMenuItem
            // 
            driversToolStripMenuItem.BackColor = Color.White;
            driversToolStripMenuItem.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            driversToolStripMenuItem.ForeColor = Color.DimGray;
            driversToolStripMenuItem.Image = (Image)resources.GetObject("driversToolStripMenuItem.Image");
            driversToolStripMenuItem.ImageAlign = ContentAlignment.MiddleLeft;
            driversToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            driversToolStripMenuItem.ImageTransparentColor = Color.Transparent;
            driversToolStripMenuItem.Name = "driversToolStripMenuItem";
            driversToolStripMenuItem.Size = new Size(149, 68);
            driversToolStripMenuItem.Text = "Drivers";
            driversToolStripMenuItem.Click += driversToolStripMenuItem_Click;
            driversToolStripMenuItem.MouseDown += accountSettingsToolStripMenuItem_MouseDown;
            // 
            // usersToolStripMenuItem
            // 
            usersToolStripMenuItem.BackColor = Color.White;
            usersToolStripMenuItem.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            usersToolStripMenuItem.ForeColor = Color.DimGray;
            usersToolStripMenuItem.Image = (Image)resources.GetObject("usersToolStripMenuItem.Image");
            usersToolStripMenuItem.ImageAlign = ContentAlignment.MiddleLeft;
            usersToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            usersToolStripMenuItem.ImageTransparentColor = Color.Transparent;
            usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            usersToolStripMenuItem.Size = new Size(134, 68);
            usersToolStripMenuItem.Text = "Users";
            usersToolStripMenuItem.Click += usersToolStripMenuItem_Click;
            usersToolStripMenuItem.MouseDown += accountSettingsToolStripMenuItem_MouseDown;
            // 
            // accountSettingsToolStripMenuItem
            // 
            accountSettingsToolStripMenuItem.BackColor = Color.White;
            accountSettingsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { currentUserInfoToolStripMenuItem, changePasswordToolStripMenuItem, signOutToolStripMenuItem });
            accountSettingsToolStripMenuItem.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            accountSettingsToolStripMenuItem.ForeColor = Color.DimGray;
            accountSettingsToolStripMenuItem.Image = (Image)resources.GetObject("accountSettingsToolStripMenuItem.Image");
            accountSettingsToolStripMenuItem.ImageAlign = ContentAlignment.MiddleLeft;
            accountSettingsToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            accountSettingsToolStripMenuItem.ImageTransparentColor = Color.White;
            accountSettingsToolStripMenuItem.Name = "accountSettingsToolStripMenuItem";
            accountSettingsToolStripMenuItem.Size = new Size(228, 68);
            accountSettingsToolStripMenuItem.Text = "AccountSettings";
            accountSettingsToolStripMenuItem.MouseDown += accountSettingsToolStripMenuItem_MouseDown;
            // 
            // currentUserInfoToolStripMenuItem
            // 
            currentUserInfoToolStripMenuItem.Image = UI.Properties.Resources.PersonDetails_32;
            currentUserInfoToolStripMenuItem.Name = "currentUserInfoToolStripMenuItem";
            currentUserInfoToolStripMenuItem.Size = new Size(233, 30);
            currentUserInfoToolStripMenuItem.Text = "Current User Info";
            currentUserInfoToolStripMenuItem.Click += currentUserInfoToolStripMenuItem_Click;
            // 
            // changePasswordToolStripMenuItem
            // 
            changePasswordToolStripMenuItem.Image = UI.Properties.Resources.Password_32;
            changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
            changePasswordToolStripMenuItem.Size = new Size(233, 30);
            changePasswordToolStripMenuItem.Text = "Change Password";
            changePasswordToolStripMenuItem.Click += changePasswordToolStripMenuItem_Click;
            // 
            // signOutToolStripMenuItem
            // 
            signOutToolStripMenuItem.Image = UI.Properties.Resources.sign_out_32__2;
            signOutToolStripMenuItem.Name = "signOutToolStripMenuItem";
            signOutToolStripMenuItem.Size = new Size(233, 30);
            signOutToolStripMenuItem.Text = "Sign Out";
            signOutToolStripMenuItem.Click += signOutToolStripMenuItem_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(576, 299);
            pictureBox1.Margin = new Padding(4, 3, 4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(613, 364);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(1813, 903);
            Controls.Add(pictureBox1);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4, 3, 4, 3);
            Name = "Main";
            Text = "Driver License Manegment System";
            WindowState = FormWindowState.Maximized;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem applicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem peopleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem driversToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accountSettingsToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private ToolStripMenuItem currentUserInfoToolStripMenuItem;
        private ToolStripMenuItem changePasswordToolStripMenuItem;
        private ToolStripMenuItem signOutToolStripMenuItem;
        private ToolStripMenuItem drivingLicensesServicesToolStripMenuItem;
        private ToolStripMenuItem manageToolStripMenuItem;
        private ToolStripMenuItem detainLicensesToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem manageApplicationTypesToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem manageToolStripMenuItem1;
        private ToolStripMenuItem newDrivingLicenseToolStripMenuItem;
        private ToolStripMenuItem localLicenseToolStripMenuItem;
        private ToolStripMenuItem intaToolStripMenuItem;
        private ToolStripMenuItem renewDrivingLicenseToolStripMenuItem;
        private ToolStripMenuItem replaccementForLostOrDamToolStripMenuItem;
        private ToolStripMenuItem releaseDetainedDrivingLicenseToolStripMenuItem;
        private ToolStripMenuItem retakeTestToolStripMenuItem;
        private ToolStripMenuItem localDrivingLicenseApplicationsToolStripMenuItem;
        private ToolStripMenuItem internationalLicenseApplicationsToolStripMenuItem;
        private ToolStripMenuItem manageDetaindLicensesToolStripMenuItem;
        private ToolStripMenuItem detainLicenseToolStripMenuItem;
        private ToolStripMenuItem releaseDetainedLicenseToolStripMenuItem;
    }
}

