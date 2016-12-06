namespace csFinalProject
{
    partial class frmRegistration
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
            this.grpLoginDetails = new System.Windows.Forms.GroupBox();
            this.lblConfirmStatus = new System.Windows.Forms.Label();
            this.lblPasswordStatus = new System.Windows.Forms.Label();
            this.lblUsernameStatus = new System.Windows.Forms.Label();
            this.txtConfirm = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grpPersonalDetails = new System.Windows.Forms.GroupBox();
            this.rdoFemale = new System.Windows.Forms.RadioButton();
            this.rdoMale = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.dtpDoB = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtInitials = new System.Windows.Forms.TextBox();
            this.lblInitial = new System.Windows.Forms.Label();
            this.cboTitle = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIdNumber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.grpLoginDetails.SuspendLayout();
            this.grpPersonalDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpLoginDetails
            // 
            this.grpLoginDetails.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpLoginDetails.Controls.Add(this.lblConfirmStatus);
            this.grpLoginDetails.Controls.Add(this.lblPasswordStatus);
            this.grpLoginDetails.Controls.Add(this.lblUsernameStatus);
            this.grpLoginDetails.Controls.Add(this.txtConfirm);
            this.grpLoginDetails.Controls.Add(this.label4);
            this.grpLoginDetails.Controls.Add(this.txtPassword);
            this.grpLoginDetails.Controls.Add(this.lblPassword);
            this.grpLoginDetails.Controls.Add(this.txtUsername);
            this.grpLoginDetails.Controls.Add(this.lblUsername);
            this.grpLoginDetails.Location = new System.Drawing.Point(13, 35);
            this.grpLoginDetails.Margin = new System.Windows.Forms.Padding(4);
            this.grpLoginDetails.Name = "grpLoginDetails";
            this.grpLoginDetails.Padding = new System.Windows.Forms.Padding(4);
            this.grpLoginDetails.Size = new System.Drawing.Size(452, 150);
            this.grpLoginDetails.TabIndex = 0;
            this.grpLoginDetails.TabStop = false;
            this.grpLoginDetails.Text = "Login Details";
            // 
            // lblConfirmStatus
            // 
            this.lblConfirmStatus.AutoSize = true;
            this.lblConfirmStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmStatus.Location = new System.Drawing.Point(129, 111);
            this.lblConfirmStatus.Name = "lblConfirmStatus";
            this.lblConfirmStatus.Size = new System.Drawing.Size(51, 16);
            this.lblConfirmStatus.TabIndex = 8;
            this.lblConfirmStatus.Text = "Status";
            this.lblConfirmStatus.Visible = false;
            // 
            // lblPasswordStatus
            // 
            this.lblPasswordStatus.AutoSize = true;
            this.lblPasswordStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPasswordStatus.Location = new System.Drawing.Point(294, 58);
            this.lblPasswordStatus.Name = "lblPasswordStatus";
            this.lblPasswordStatus.Size = new System.Drawing.Size(51, 16);
            this.lblPasswordStatus.TabIndex = 7;
            this.lblPasswordStatus.Text = "Status";
            this.lblPasswordStatus.Visible = false;
            // 
            // lblUsernameStatus
            // 
            this.lblUsernameStatus.AutoSize = true;
            this.lblUsernameStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsernameStatus.Location = new System.Drawing.Point(294, 28);
            this.lblUsernameStatus.Name = "lblUsernameStatus";
            this.lblUsernameStatus.Size = new System.Drawing.Size(51, 16);
            this.lblUsernameStatus.TabIndex = 6;
            this.lblUsernameStatus.Text = "Status";
            this.lblUsernameStatus.Visible = false;
            // 
            // txtConfirm
            // 
            this.txtConfirm.Location = new System.Drawing.Point(132, 85);
            this.txtConfirm.Margin = new System.Windows.Forms.Padding(4);
            this.txtConfirm.Name = "txtConfirm";
            this.txtConfirm.PasswordChar = '●';
            this.txtConfirm.Size = new System.Drawing.Size(154, 22);
            this.txtConfirm.TabIndex = 5;
            this.txtConfirm.Enter += new System.EventHandler(this.txtConfirm_Enter);
            this.txtConfirm.Leave += new System.EventHandler(this.txtConfirm_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 88);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Confirm Password";
            // 
            // txtPassword
            // 
            this.helpProvider1.SetHelpString(this.txtPassword, "Passwords: \n - Must be at least 6 characters long\n - Can contain any combination " +
        "of letters, numbers, or special characters\n - Specials allowed: ! @ # $ % ^ & * " +
        "( )");
            this.txtPassword.Location = new System.Drawing.Point(132, 55);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '●';
            this.helpProvider1.SetShowHelp(this.txtPassword, true);
            this.txtPassword.Size = new System.Drawing.Size(154, 22);
            this.txtPassword.TabIndex = 3;
            this.toolTip1.SetToolTip(this.txtPassword, "Enter a password (F1 for details)");
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            this.txtPassword.Enter += new System.EventHandler(this.txtPassword_Enter);
            this.txtPassword.Leave += new System.EventHandler(this.txtPassword_Leave);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.helpProvider1.SetHelpString(this.lblPassword, "Passwords: \n - Must be at least 6 characters long\n - Can contain any combination " +
        "of letters, numbers, or special characters\n - Specials allowed: ! @ # $ % ^ & * " +
        "( )");
            this.lblPassword.Location = new System.Drawing.Point(51, 58);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPassword.Name = "lblPassword";
            this.helpProvider1.SetShowHelp(this.lblPassword, true);
            this.lblPassword.Size = new System.Drawing.Size(68, 16);
            this.lblPassword.TabIndex = 2;
            this.lblPassword.Text = "Password";
            this.toolTip1.SetToolTip(this.lblPassword, "Enter a password (F1 for details)");
            // 
            // txtUsername
            // 
            this.helpProvider1.SetHelpString(this.txtUsername, "Usernames can contain numbers, letters, and underscores\nand must not start with a" +
        "n underscore");
            this.txtUsername.Location = new System.Drawing.Point(132, 25);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(4);
            this.txtUsername.Name = "txtUsername";
            this.helpProvider1.SetShowHelp(this.txtUsername, true);
            this.txtUsername.Size = new System.Drawing.Size(154, 22);
            this.txtUsername.TabIndex = 1;
            this.toolTip1.SetToolTip(this.txtUsername, "Enter a user name(F1 for details) ");
            this.txtUsername.Enter += new System.EventHandler(this.txtUsername_Enter);
            this.txtUsername.Leave += new System.EventHandler(this.txtUsername_Leave);
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.helpProvider1.SetHelpString(this.lblUsername, "Usernames can contain numbers, letters, and underscores\nand must not start with a" +
        "n underscore");
            this.lblUsername.Location = new System.Drawing.Point(48, 28);
            this.lblUsername.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUsername.Name = "lblUsername";
            this.helpProvider1.SetShowHelp(this.lblUsername, true);
            this.lblUsername.Size = new System.Drawing.Size(71, 16);
            this.lblUsername.TabIndex = 0;
            this.lblUsername.Text = "Username";
            this.toolTip1.SetToolTip(this.lblUsername, "Enter a user name(F1 for details) ");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(356, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Please enter all of the following details to register:";
            // 
            // grpPersonalDetails
            // 
            this.grpPersonalDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpPersonalDetails.Controls.Add(this.rdoFemale);
            this.grpPersonalDetails.Controls.Add(this.rdoMale);
            this.grpPersonalDetails.Controls.Add(this.label8);
            this.grpPersonalDetails.Controls.Add(this.dtpDoB);
            this.grpPersonalDetails.Controls.Add(this.label7);
            this.grpPersonalDetails.Controls.Add(this.txtFirstName);
            this.grpPersonalDetails.Controls.Add(this.label6);
            this.grpPersonalDetails.Controls.Add(this.txtLastName);
            this.grpPersonalDetails.Controls.Add(this.label5);
            this.grpPersonalDetails.Controls.Add(this.txtInitials);
            this.grpPersonalDetails.Controls.Add(this.lblInitial);
            this.grpPersonalDetails.Controls.Add(this.cboTitle);
            this.grpPersonalDetails.Controls.Add(this.label3);
            this.grpPersonalDetails.Controls.Add(this.txtIdNumber);
            this.grpPersonalDetails.Controls.Add(this.label2);
            this.grpPersonalDetails.Location = new System.Drawing.Point(13, 192);
            this.grpPersonalDetails.Name = "grpPersonalDetails";
            this.grpPersonalDetails.Size = new System.Drawing.Size(452, 201);
            this.grpPersonalDetails.TabIndex = 2;
            this.grpPersonalDetails.TabStop = false;
            this.grpPersonalDetails.Text = "Personal Details";
            // 
            // rdoFemale
            // 
            this.rdoFemale.AutoSize = true;
            this.rdoFemale.Location = new System.Drawing.Point(184, 167);
            this.rdoFemale.Name = "rdoFemale";
            this.rdoFemale.Size = new System.Drawing.Size(72, 20);
            this.rdoFemale.TabIndex = 14;
            this.rdoFemale.TabStop = true;
            this.rdoFemale.Text = "Female";
            this.rdoFemale.UseVisualStyleBackColor = true;
            // 
            // rdoMale
            // 
            this.rdoMale.AutoSize = true;
            this.rdoMale.Location = new System.Drawing.Point(122, 167);
            this.rdoMale.Name = "rdoMale";
            this.rdoMale.Size = new System.Drawing.Size(56, 20);
            this.rdoMale.TabIndex = 13;
            this.rdoMale.TabStop = true;
            this.rdoMale.Text = "Male";
            this.rdoMale.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(54, 169);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 16);
            this.label8.TabIndex = 12;
            this.label8.Text = "Gender";
            // 
            // dtpDoB
            // 
            this.dtpDoB.CustomFormat = "MM/DD/YYYY";
            this.dtpDoB.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDoB.Location = new System.Drawing.Point(122, 139);
            this.dtpDoB.Name = "dtpDoB";
            this.dtpDoB.Size = new System.Drawing.Size(156, 22);
            this.dtpDoB.TabIndex = 11;
            this.dtpDoB.Value = new System.DateTime(1970, 1, 1, 0, 0, 0, 0);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 144);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 16);
            this.label7.TabIndex = 10;
            this.label7.Text = "Date of Birth";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(122, 111);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(324, 22);
            this.txtFirstName.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(34, 114);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 16);
            this.label6.TabIndex = 8;
            this.label6.Text = "First Name";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(122, 83);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(324, 22);
            this.txtLastName.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Last Name";
            // 
            // txtInitials
            // 
            this.txtInitials.Location = new System.Drawing.Point(364, 55);
            this.txtInitials.Name = "txtInitials";
            this.txtInitials.Size = new System.Drawing.Size(82, 22);
            this.txtInitials.TabIndex = 5;
            // 
            // lblInitial
            // 
            this.lblInitial.AutoSize = true;
            this.lblInitial.Location = new System.Drawing.Point(276, 58);
            this.lblInitial.Name = "lblInitial";
            this.lblInitial.Size = new System.Drawing.Size(82, 16);
            this.lblInitial.TabIndex = 4;
            this.lblInitial.Text = "Middle Initial";
            // 
            // cboTitle
            // 
            this.cboTitle.FormattingEnabled = true;
            this.cboTitle.Items.AddRange(new object[] {
            "Mr.",
            "Mrs.",
            "Ms.",
            "Miss",
            "Dr.",
            "Good ol\'"});
            this.cboTitle.Location = new System.Drawing.Point(122, 53);
            this.cboTitle.Name = "cboTitle";
            this.cboTitle.Size = new System.Drawing.Size(105, 24);
            this.cboTitle.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(73, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Title";
            // 
            // txtIdNumber
            // 
            this.txtIdNumber.Location = new System.Drawing.Point(122, 25);
            this.txtIdNumber.Name = "txtIdNumber";
            this.txtIdNumber.ReadOnly = true;
            this.txtIdNumber.Size = new System.Drawing.Size(324, 22);
            this.txtIdNumber.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Identity Number";
            // 
            // btnRegister
            // 
            this.btnRegister.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRegister.Location = new System.Drawing.Point(306, 399);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(159, 29);
            this.btnRegister.TabIndex = 3;
            this.btnRegister.Text = "Register";
            this.toolTip1.SetToolTip(this.btnRegister, "Click here to complete your registration");
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(225, 399);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 29);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmRegistration
            // 
            this.AcceptButton = this.btnRegister;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(477, 440);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.grpPersonalDetails);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grpLoginDetails);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmRegistration";
            this.Text = "New User Registration";
            this.Load += new System.EventHandler(this.frmRegistration_Load);
            this.grpLoginDetails.ResumeLayout(false);
            this.grpLoginDetails.PerformLayout();
            this.grpPersonalDetails.ResumeLayout(false);
            this.grpPersonalDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpLoginDetails;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtConfirm;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.GroupBox grpPersonalDetails;
        private System.Windows.Forms.DateTimePicker dtpDoB;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtInitials;
        private System.Windows.Forms.Label lblInitial;
        private System.Windows.Forms.ComboBox cboTitle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIdNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.RadioButton rdoFemale;
        private System.Windows.Forms.RadioButton rdoMale;
        private System.Windows.Forms.Label lblConfirmStatus;
        private System.Windows.Forms.Label lblPasswordStatus;
        private System.Windows.Forms.Label lblUsernameStatus;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.HelpProvider helpProvider1;
    }
}