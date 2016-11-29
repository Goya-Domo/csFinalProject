namespace csFinalProject
{
    partial class frmPersonalDetails
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
            this.components = new System.ComponentModel.Container();
            this.tabTabControl = new System.Windows.Forms.TabControl();
            this.tabPersonalDetails = new System.Windows.Forms.TabPage();
            this.grpLogin = new System.Windows.Forms.GroupBox();
            this.lblCancel = new System.Windows.Forms.LinkLabel();
            this.lblChangePassword = new System.Windows.Forms.LinkLabel();
            this.txtConfirmNewPassword = new System.Windows.Forms.TextBox();
            this.lblConfirmNewPassword = new System.Windows.Forms.Label();
            this.txtNewPassword = new System.Windows.Forms.TextBox();
            this.txtOldPassword = new System.Windows.Forms.TextBox();
            this.lblNewPassword = new System.Windows.Forms.Label();
            this.lblOldPassword = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblProfilePic = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabMedicalDetails = new System.Windows.Forms.TabPage();
            this.tabCPHR = new System.Windows.Forms.TabPage();
            this.tabEPHR = new System.Windows.Forms.TabPage();
            this.ttpToolTips = new System.Windows.Forms.ToolTip(this.components);
            this.grpChangePassword = new System.Windows.Forms.GroupBox();
            this.grpPersonalDetails = new System.Windows.Forms.GroupBox();
            this.grpContactDetails = new System.Windows.Forms.GroupBox();
            this.lblIdentityNumber = new System.Windows.Forms.Label();
            this.txtIdentityNumber = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblInitials = new System.Windows.Forms.Label();
            this.txtInitials = new System.Windows.Forms.TextBox();
            this.lblGender = new System.Windows.Forms.Label();
            this.rdoMale = new System.Windows.Forms.RadioButton();
            this.rdoFemale = new System.Windows.Forms.RadioButton();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblDob = new System.Windows.Forms.Label();
            this.dtpDob = new System.Windows.Forms.DateTimePicker();
            this.lblEditPersonalDetails = new System.Windows.Forms.LinkLabel();
            this.lblSavePersonalDetails = new System.Windows.Forms.LinkLabel();
            this.lblCancelPersonalDetails = new System.Windows.Forms.LinkLabel();
            this.tabTabControl.SuspendLayout();
            this.tabPersonalDetails.SuspendLayout();
            this.grpLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.grpChangePassword.SuspendLayout();
            this.grpPersonalDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabTabControl
            // 
            this.tabTabControl.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabTabControl.Controls.Add(this.tabPersonalDetails);
            this.tabTabControl.Controls.Add(this.tabMedicalDetails);
            this.tabTabControl.Controls.Add(this.tabCPHR);
            this.tabTabControl.Controls.Add(this.tabEPHR);
            this.tabTabControl.HotTrack = true;
            this.tabTabControl.Location = new System.Drawing.Point(1, 2);
            this.tabTabControl.Name = "tabTabControl";
            this.tabTabControl.SelectedIndex = 0;
            this.tabTabControl.Size = new System.Drawing.Size(1096, 635);
            this.tabTabControl.TabIndex = 0;
            // 
            // tabPersonalDetails
            // 
            this.tabPersonalDetails.Controls.Add(this.grpContactDetails);
            this.tabPersonalDetails.Controls.Add(this.grpPersonalDetails);
            this.tabPersonalDetails.Controls.Add(this.grpLogin);
            this.tabPersonalDetails.Controls.Add(this.lblProfilePic);
            this.tabPersonalDetails.Controls.Add(this.pictureBox1);
            this.tabPersonalDetails.Location = new System.Drawing.Point(4, 25);
            this.tabPersonalDetails.Name = "tabPersonalDetails";
            this.tabPersonalDetails.Padding = new System.Windows.Forms.Padding(3);
            this.tabPersonalDetails.Size = new System.Drawing.Size(1088, 606);
            this.tabPersonalDetails.TabIndex = 0;
            this.tabPersonalDetails.Text = "Personal Details";
            this.tabPersonalDetails.UseVisualStyleBackColor = true;
            // 
            // grpLogin
            // 
            this.grpLogin.BackColor = System.Drawing.SystemColors.Control;
            this.grpLogin.Controls.Add(this.grpChangePassword);
            this.grpLogin.Controls.Add(this.txtUserName);
            this.grpLogin.Controls.Add(this.lblUsername);
            this.grpLogin.Location = new System.Drawing.Point(184, 7);
            this.grpLogin.Name = "grpLogin";
            this.grpLogin.Size = new System.Drawing.Size(298, 179);
            this.grpLogin.TabIndex = 2;
            this.grpLogin.TabStop = false;
            this.grpLogin.Text = "Login Details";
            // 
            // lblCancel
            // 
            this.lblCancel.AutoSize = true;
            this.lblCancel.Location = new System.Drawing.Point(237, 108);
            this.lblCancel.Name = "lblCancel";
            this.lblCancel.Size = new System.Drawing.Size(40, 13);
            this.lblCancel.TabIndex = 11;
            this.lblCancel.TabStop = true;
            this.lblCancel.Text = "Cancel";
            // 
            // lblChangePassword
            // 
            this.lblChangePassword.AutoSize = true;
            this.lblChangePassword.Location = new System.Drawing.Point(138, 108);
            this.lblChangePassword.Name = "lblChangePassword";
            this.lblChangePassword.Size = new System.Drawing.Size(93, 13);
            this.lblChangePassword.TabIndex = 10;
            this.lblChangePassword.TabStop = true;
            this.lblChangePassword.Text = "Change Password";
            // 
            // txtConfirmNewPassword
            // 
            this.txtConfirmNewPassword.Location = new System.Drawing.Point(131, 78);
            this.txtConfirmNewPassword.Name = "txtConfirmNewPassword";
            this.txtConfirmNewPassword.Size = new System.Drawing.Size(146, 20);
            this.txtConfirmNewPassword.TabIndex = 9;
            this.ttpToolTips.SetToolTip(this.txtConfirmNewPassword, "Confirm your new password");
            // 
            // lblConfirmNewPassword
            // 
            this.lblConfirmNewPassword.AutoSize = true;
            this.lblConfirmNewPassword.Location = new System.Drawing.Point(6, 81);
            this.lblConfirmNewPassword.Name = "lblConfirmNewPassword";
            this.lblConfirmNewPassword.Size = new System.Drawing.Size(119, 13);
            this.lblConfirmNewPassword.TabIndex = 8;
            this.lblConfirmNewPassword.Text = "Confirm New Password:";
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.Location = new System.Drawing.Point(131, 52);
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.Size = new System.Drawing.Size(146, 20);
            this.txtNewPassword.TabIndex = 7;
            this.ttpToolTips.SetToolTip(this.txtNewPassword, "Enter your new password");
            // 
            // txtOldPassword
            // 
            this.txtOldPassword.Location = new System.Drawing.Point(131, 26);
            this.txtOldPassword.Name = "txtOldPassword";
            this.txtOldPassword.Size = new System.Drawing.Size(146, 20);
            this.txtOldPassword.TabIndex = 6;
            this.ttpToolTips.SetToolTip(this.txtOldPassword, "Enter your old password");
            // 
            // lblNewPassword
            // 
            this.lblNewPassword.AutoSize = true;
            this.lblNewPassword.Location = new System.Drawing.Point(6, 55);
            this.lblNewPassword.Name = "lblNewPassword";
            this.lblNewPassword.Size = new System.Drawing.Size(81, 13);
            this.lblNewPassword.TabIndex = 5;
            this.lblNewPassword.Text = "New Password:";
            // 
            // lblOldPassword
            // 
            this.lblOldPassword.AutoSize = true;
            this.lblOldPassword.Location = new System.Drawing.Point(6, 29);
            this.lblOldPassword.Name = "lblOldPassword";
            this.lblOldPassword.Size = new System.Drawing.Size(75, 13);
            this.lblOldPassword.TabIndex = 3;
            this.lblOldPassword.Text = "Old Password:";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(71, 17);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(221, 20);
            this.txtUserName.TabIndex = 1;
            this.ttpToolTips.SetToolTip(this.txtUserName, "This is your user name");
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(6, 20);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(58, 13);
            this.lblUsername.TabIndex = 0;
            this.lblUsername.Text = "Username:";
            // 
            // lblProfilePic
            // 
            this.lblProfilePic.AutoSize = true;
            this.lblProfilePic.Location = new System.Drawing.Point(34, 173);
            this.lblProfilePic.Name = "lblProfilePic";
            this.lblProfilePic.Size = new System.Drawing.Size(112, 13);
            this.lblProfilePic.TabIndex = 1;
            this.lblProfilePic.TabStop = true;
            this.lblProfilePic.Text = "Change Profile Picture";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(8, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(170, 163);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.ttpToolTips.SetToolTip(this.pictureBox1, "This is your profile picture");
            // 
            // tabMedicalDetails
            // 
            this.tabMedicalDetails.Location = new System.Drawing.Point(4, 25);
            this.tabMedicalDetails.Name = "tabMedicalDetails";
            this.tabMedicalDetails.Padding = new System.Windows.Forms.Padding(3);
            this.tabMedicalDetails.Size = new System.Drawing.Size(1088, 459);
            this.tabMedicalDetails.TabIndex = 1;
            this.tabMedicalDetails.Text = "Medical Details";
            this.tabMedicalDetails.UseVisualStyleBackColor = true;
            // 
            // tabCPHR
            // 
            this.tabCPHR.Location = new System.Drawing.Point(4, 25);
            this.tabCPHR.Name = "tabCPHR";
            this.tabCPHR.Size = new System.Drawing.Size(1088, 459);
            this.tabCPHR.TabIndex = 2;
            this.tabCPHR.Text = "Comprehensive Personal Health Record";
            this.tabCPHR.UseVisualStyleBackColor = true;
            // 
            // tabEPHR
            // 
            this.tabEPHR.Location = new System.Drawing.Point(4, 25);
            this.tabEPHR.Name = "tabEPHR";
            this.tabEPHR.Size = new System.Drawing.Size(1088, 459);
            this.tabEPHR.TabIndex = 3;
            this.tabEPHR.Text = "Emergency Personal Health Record";
            this.tabEPHR.UseVisualStyleBackColor = true;
            // 
            // grpChangePassword
            // 
            this.grpChangePassword.Controls.Add(this.lblConfirmNewPassword);
            this.grpChangePassword.Controls.Add(this.lblCancel);
            this.grpChangePassword.Controls.Add(this.lblNewPassword);
            this.grpChangePassword.Controls.Add(this.lblOldPassword);
            this.grpChangePassword.Controls.Add(this.lblChangePassword);
            this.grpChangePassword.Controls.Add(this.txtOldPassword);
            this.grpChangePassword.Controls.Add(this.txtConfirmNewPassword);
            this.grpChangePassword.Controls.Add(this.txtNewPassword);
            this.grpChangePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpChangePassword.ImeMode = System.Windows.Forms.ImeMode.On;
            this.grpChangePassword.Location = new System.Drawing.Point(6, 43);
            this.grpChangePassword.Name = "grpChangePassword";
            this.grpChangePassword.Size = new System.Drawing.Size(286, 130);
            this.grpChangePassword.TabIndex = 12;
            this.grpChangePassword.TabStop = false;
            this.grpChangePassword.Text = "ChangePassword";
            // 
            // grpPersonalDetails
            // 
            this.grpPersonalDetails.Controls.Add(this.lblCancelPersonalDetails);
            this.grpPersonalDetails.Controls.Add(this.lblSavePersonalDetails);
            this.grpPersonalDetails.Controls.Add(this.lblEditPersonalDetails);
            this.grpPersonalDetails.Controls.Add(this.dtpDob);
            this.grpPersonalDetails.Controls.Add(this.lblDob);
            this.grpPersonalDetails.Controls.Add(this.txtFirstName);
            this.grpPersonalDetails.Controls.Add(this.txtLastName);
            this.grpPersonalDetails.Controls.Add(this.lblFirstName);
            this.grpPersonalDetails.Controls.Add(this.lblLastName);
            this.grpPersonalDetails.Controls.Add(this.rdoFemale);
            this.grpPersonalDetails.Controls.Add(this.rdoMale);
            this.grpPersonalDetails.Controls.Add(this.lblGender);
            this.grpPersonalDetails.Controls.Add(this.txtInitials);
            this.grpPersonalDetails.Controls.Add(this.lblInitials);
            this.grpPersonalDetails.Controls.Add(this.comboBox1);
            this.grpPersonalDetails.Controls.Add(this.lblTitle);
            this.grpPersonalDetails.Controls.Add(this.txtIdentityNumber);
            this.grpPersonalDetails.Controls.Add(this.lblIdentityNumber);
            this.grpPersonalDetails.Location = new System.Drawing.Point(8, 192);
            this.grpPersonalDetails.Name = "grpPersonalDetails";
            this.grpPersonalDetails.Size = new System.Drawing.Size(474, 152);
            this.grpPersonalDetails.TabIndex = 3;
            this.grpPersonalDetails.TabStop = false;
            this.grpPersonalDetails.Text = "Personal Details";
            // 
            // grpContactDetails
            // 
            this.grpContactDetails.Location = new System.Drawing.Point(8, 350);
            this.grpContactDetails.Name = "grpContactDetails";
            this.grpContactDetails.Size = new System.Drawing.Size(474, 250);
            this.grpContactDetails.TabIndex = 4;
            this.grpContactDetails.TabStop = false;
            this.grpContactDetails.Text = "Contact Details";
            // 
            // lblIdentityNumber
            // 
            this.lblIdentityNumber.AutoSize = true;
            this.lblIdentityNumber.Location = new System.Drawing.Point(10, 20);
            this.lblIdentityNumber.Name = "lblIdentityNumber";
            this.lblIdentityNumber.Size = new System.Drawing.Size(84, 13);
            this.lblIdentityNumber.TabIndex = 0;
            this.lblIdentityNumber.Text = "Identity Number:";
            // 
            // txtIdentityNumber
            // 
            this.txtIdentityNumber.Location = new System.Drawing.Point(97, 17);
            this.txtIdentityNumber.Name = "txtIdentityNumber";
            this.txtIdentityNumber.Size = new System.Drawing.Size(210, 20);
            this.txtIdentityNumber.TabIndex = 1;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(10, 46);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(30, 13);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Title:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(97, 43);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(73, 21);
            this.comboBox1.TabIndex = 3;
            // 
            // lblInitials
            // 
            this.lblInitials.AutoSize = true;
            this.lblInitials.Location = new System.Drawing.Point(197, 46);
            this.lblInitials.Name = "lblInitials";
            this.lblInitials.Size = new System.Drawing.Size(42, 13);
            this.lblInitials.TabIndex = 4;
            this.lblInitials.Text = "Initials: ";
            // 
            // txtInitials
            // 
            this.txtInitials.Location = new System.Drawing.Point(245, 43);
            this.txtInitials.Name = "txtInitials";
            this.txtInitials.Size = new System.Drawing.Size(62, 20);
            this.txtInitials.TabIndex = 5;
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(339, 22);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(45, 13);
            this.lblGender.TabIndex = 6;
            this.lblGender.Text = "Gender:";
            // 
            // rdoMale
            // 
            this.rdoMale.AutoSize = true;
            this.rdoMale.Location = new System.Drawing.Point(390, 20);
            this.rdoMale.Name = "rdoMale";
            this.rdoMale.Size = new System.Drawing.Size(48, 17);
            this.rdoMale.TabIndex = 7;
            this.rdoMale.TabStop = true;
            this.rdoMale.Text = "Male";
            this.rdoMale.UseVisualStyleBackColor = true;
            // 
            // rdoFemale
            // 
            this.rdoFemale.AutoSize = true;
            this.rdoFemale.Location = new System.Drawing.Point(390, 43);
            this.rdoFemale.Name = "rdoFemale";
            this.rdoFemale.Size = new System.Drawing.Size(59, 17);
            this.rdoFemale.TabIndex = 8;
            this.rdoFemale.TabStop = true;
            this.rdoFemale.Text = "Female";
            this.rdoFemale.UseVisualStyleBackColor = true;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(10, 73);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(61, 13);
            this.lblLastName.TabIndex = 9;
            this.lblLastName.Text = "Last Name:";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(10, 99);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(60, 13);
            this.lblFirstName.TabIndex = 10;
            this.lblFirstName.Text = "First Name:";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(97, 70);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(362, 20);
            this.txtLastName.TabIndex = 11;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(97, 96);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(362, 20);
            this.txtFirstName.TabIndex = 12;
            // 
            // lblDob
            // 
            this.lblDob.AutoSize = true;
            this.lblDob.Location = new System.Drawing.Point(10, 126);
            this.lblDob.Name = "lblDob";
            this.lblDob.Size = new System.Drawing.Size(69, 13);
            this.lblDob.TabIndex = 13;
            this.lblDob.Text = "Date of Birth:";
            // 
            // dtpDob
            // 
            this.dtpDob.Location = new System.Drawing.Point(97, 122);
            this.dtpDob.Name = "dtpDob";
            this.dtpDob.Size = new System.Drawing.Size(200, 20);
            this.dtpDob.TabIndex = 14;
            // 
            // lblEditPersonalDetails
            // 
            this.lblEditPersonalDetails.AutoSize = true;
            this.lblEditPersonalDetails.Location = new System.Drawing.Point(350, 126);
            this.lblEditPersonalDetails.Name = "lblEditPersonalDetails";
            this.lblEditPersonalDetails.Size = new System.Drawing.Size(25, 13);
            this.lblEditPersonalDetails.TabIndex = 15;
            this.lblEditPersonalDetails.TabStop = true;
            this.lblEditPersonalDetails.Text = "Edit";
            // 
            // lblSavePersonalDetails
            // 
            this.lblSavePersonalDetails.AutoSize = true;
            this.lblSavePersonalDetails.Location = new System.Drawing.Point(381, 126);
            this.lblSavePersonalDetails.Name = "lblSavePersonalDetails";
            this.lblSavePersonalDetails.Size = new System.Drawing.Size(32, 13);
            this.lblSavePersonalDetails.TabIndex = 16;
            this.lblSavePersonalDetails.TabStop = true;
            this.lblSavePersonalDetails.Text = "Save";
            // 
            // lblCancelPersonalDetails
            // 
            this.lblCancelPersonalDetails.AutoSize = true;
            this.lblCancelPersonalDetails.Location = new System.Drawing.Point(419, 126);
            this.lblCancelPersonalDetails.Name = "lblCancelPersonalDetails";
            this.lblCancelPersonalDetails.Size = new System.Drawing.Size(40, 13);
            this.lblCancelPersonalDetails.TabIndex = 17;
            this.lblCancelPersonalDetails.TabStop = true;
            this.lblCancelPersonalDetails.Text = "Cancel";
            // 
            // frmPersonalDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1109, 639);
            this.Controls.Add(this.tabTabControl);
            this.Name = "frmPersonalDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "My Personal Health Record";
            this.tabTabControl.ResumeLayout(false);
            this.tabPersonalDetails.ResumeLayout(false);
            this.tabPersonalDetails.PerformLayout();
            this.grpLogin.ResumeLayout(false);
            this.grpLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.grpChangePassword.ResumeLayout(false);
            this.grpChangePassword.PerformLayout();
            this.grpPersonalDetails.ResumeLayout(false);
            this.grpPersonalDetails.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabTabControl;
        private System.Windows.Forms.TabPage tabPersonalDetails;
        private System.Windows.Forms.GroupBox grpLogin;
        private System.Windows.Forms.LinkLabel lblCancel;
        private System.Windows.Forms.LinkLabel lblChangePassword;
        private System.Windows.Forms.TextBox txtConfirmNewPassword;
        private System.Windows.Forms.Label lblConfirmNewPassword;
        private System.Windows.Forms.TextBox txtNewPassword;
        private System.Windows.Forms.TextBox txtOldPassword;
        private System.Windows.Forms.Label lblNewPassword;
        private System.Windows.Forms.Label lblOldPassword;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.LinkLabel lblProfilePic;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolTip ttpToolTips;
        private System.Windows.Forms.TabPage tabMedicalDetails;
        private System.Windows.Forms.TabPage tabCPHR;
        private System.Windows.Forms.TabPage tabEPHR;
        private System.Windows.Forms.GroupBox grpChangePassword;
        private System.Windows.Forms.GroupBox grpContactDetails;
        private System.Windows.Forms.GroupBox grpPersonalDetails;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtIdentityNumber;
        private System.Windows.Forms.Label lblIdentityNumber;
        private System.Windows.Forms.LinkLabel lblEditPersonalDetails;
        private System.Windows.Forms.DateTimePicker dtpDob;
        private System.Windows.Forms.Label lblDob;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.RadioButton rdoFemale;
        private System.Windows.Forms.RadioButton rdoMale;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.TextBox txtInitials;
        private System.Windows.Forms.Label lblInitials;
        private System.Windows.Forms.LinkLabel lblCancelPersonalDetails;
        private System.Windows.Forms.LinkLabel lblSavePersonalDetails;
    }
}