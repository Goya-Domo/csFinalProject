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
            if (Validator.IsValidPassword(txtOldPassword.Text))
            {
                //TODO Authenticate Old Password
                if (Validator.IsValidPassword(txtNewPassword.Text))
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
        //
        //Tab 1:
        //
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
        //
        //Tab 2:
        //
        //Edit Personal Medical Details
        private void lblPersonalMedicalDetailsEdit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            EnableAllControls(grpPersonalMedicalDetails);
        }

        //Cancel Personal Medical Details
        private void lblPersonalMedicalDetailsCancel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DisableAllControls(grpPersonalMedicalDetails);
        }

        //Edit Allergy Details
        private void lblAllergyDetailsEdit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            EnableAllControls(grpAllergyDetails);
        }

        //Cancel Allergy Details
        private void lblAllergyDetailsCancel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DisableAllControls(grpAllergyDetails);
        }

        //Edit Immunisation Details
        private void lblImmunisationEdit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            EnableAllControls(grpImmunisationDetails);
        }

        //Cancel Immunisation Details
        private void lblImmunisationCancel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DisableAllControls(grpImmunisationDetails);
        }

        //Edit Perscribed Medication Details
        private void lblPerscribedEdit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            EnableAllControls(grpPerscribedMedicationDetails);
        }

        //Cancel Perscribed Medication Details
        private void lblPerscribedCancel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DisableAllControls(grpPerscribedMedicationDetails);
        }

        //Edit Test Result Details
        private void lblTestResultEdit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            EnableAllControls(grpTestResultDetails);
        }

        //Cancel Test Result Details
        private void lblTestResultCancel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DisableAllControls(grpTestResultDetails);
        }

        //Edit Medical Condition Details
        private void lblMedicalConditionEdit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            EnableAllControls(grpMedicalConditionDetails);
        }

        //Cancel Medical Condition Details
        private void lblMedicalConditionCancel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DisableAllControls(grpMedicalConditionDetails);
        }

        //Edit Medical Procedure Details
        private void lblMedicalProceduresEdit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            EnableAllControls(grpMedicalProcedureDetails);
        }

        //Cancel Medical Procedure Details
        private void lblMedicalProceduresCancel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DisableAllControls(grpMedicalProcedureDetails);
        }
        //
        //End Tab 2

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
