using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace csFinalProject
{
    public partial class frmPersonalDetails : Form
    {
        public frmPersonalDetails()
        {
            InitializeComponent();
        }

        //Change Password
        private void lblChangePassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (Validator.isValidPassword(txtOldPassword.Text))
            {
                //TODO Authenticate Old Password
                if (Validator.isValidPassword(txtNewPassword.Text))
                {
                    //TODO Set new password
                }
                else
                {
                    MessageBox.Show("New password not valid", "Invalid Password");
                    txtOldPassword.Text = "";
                    txtNewPassword.Text = "";
                    txtConfirmNewPassword.Text = "";
                    txtOldPassword.Focus();
                }
            }
            else
            {
                MessageBox.Show("Current password not valid", "Invalid Password");
                txtOldPassword.Text = "";
                txtNewPassword.Text = "";
                txtConfirmNewPassword.Text = "";
                txtOldPassword.Focus();
            }
        }

        //Edit Personal Details
        private void lblEditPersonalDetails_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            EnableAllControls(grpPersonalDetails);
        }

        //Cancel Personal Details
        private void lblCancelPersonalDetails_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DisableAllControls(grpPersonalDetails);
        }

        //Edit Contact Details
        private void lblEditContactDetails_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            EnableAllControls(grpContactDetails);
        }

        //Cancel Contact Details
        private void lblCancelContactDetails_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DisableAllControls(grpContactDetails);
        }

        //Edit Emergency Contact Details
        private void lblEmergencyContactDetailsEdit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            EnableAllControls(grpEmergencyContactDetails);
        }

        //Cancel Emergency Contact Details
        private void lblEmergencyContactDetailsCancel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DisableAllControls(grpEmergencyContactDetails);
        }

        //Edit Primary Provider Details
        private void lblPrimaryEdit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            EnableAllControls(grpPrimaryCare);
        }

        //Cancel Primary Provider Details
        private void lblPrimaryCancel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DisableAllControls(grpPrimaryCare);
        }

        //Enable and Disable Controls in a given Group Box:
        private void EnableAllControls(GroupBox inGroup)
        {
            foreach (Control control in inGroup.Controls)
            {
                control.Enabled = true;
            }
        }
        private void DisableAllControls(GroupBox inGroup)
        {
            foreach (Control control in inGroup.Controls)
            {
                if (control.Text != "Edit")
                    control.Enabled = false;
            }
        }
    }
}
