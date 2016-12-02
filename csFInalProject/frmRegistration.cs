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
    public partial class frmRegistration : Form
    {
        public frmRegistration()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
        }

        private void txtUsername_Leave(object sender, EventArgs e)
        {
            if (!Validator.isValidUsername(txtUsername.Text))
            {
                lblUsernameStatus.ForeColor = Color.Red;
                lblUsernameStatus.Text = "Invalid";
                lblUsernameStatus.Visible = true;
            }
            else
            {
                lblUsernameStatus.ForeColor = Color.Green;
                lblUsernameStatus.Text = "✓";
                lblUsernameStatus.Visible = true;
            }
        }

        private void txtUsername_Enter(object sender, EventArgs e)
        {
            lblUsernameStatus.Visible = false;
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            lblConfirmStatus.Visible = false;
            lblPasswordStatus.Visible = false;
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (Validator.isValidPassword(txtPassword.Text))
            {
                lblPasswordStatus.ForeColor = Color.Green;
                lblPasswordStatus.Text = "✓";
                lblPasswordStatus.Visible = true;
            }
            else
            {
                lblPasswordStatus.ForeColor = Color.Red;
                lblPasswordStatus.Text = "Invalid";
                lblPasswordStatus.Visible = true;
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            txtConfirm.Text = "";
        }

        private void txtConfirm_Leave(object sender, EventArgs e)
        {
            if (!txtPassword.Text.Equals(txtConfirm.Text))
            {
                lblConfirmStatus.ForeColor = Color.Red;
                lblConfirmStatus.Text = "Passwords don't match";
                lblConfirmStatus.Visible = true;
            }
            else
            {
                if (Validator.isValidPassword(txtPassword.Text)
                    && Validator.isValidUsername(txtUsername.Text))
                {
                    lblConfirmStatus.ForeColor = Color.Green;
                    lblConfirmStatus.Text = "✓";
                    lblConfirmStatus.Visible = true;
                }
                else
                {
                    lblConfirmStatus.ForeColor = Color.Red;
                    lblConfirmStatus.Text = "Invalid";
                    lblConfirmStatus.Visible = true;
                }
            }
        }

        private void txtConfirm_Enter(object sender, EventArgs e)
        {
            lblConfirmStatus.Visible = false;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
