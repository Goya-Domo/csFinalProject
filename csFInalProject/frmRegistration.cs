using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
            bool regSuccess = true;
            bool autoID = false;

            if (txtIdNumber.Text.Equals("") 
                || !Validator.IsValidId(txtIdNumber.Text))
                {
                    switch (MessageBox.Show("Identity Number is invalid. Would you like a new one made for yoU?", "Invalid ID Number", MessageBoxButtons.YesNoCancel))
                    {
                        case DialogResult.Yes:
                            Random rand = new Random();
                            int num = rand.Next();
                            txtIdNumber.Text = num.ToString();
                            autoID = true;              
                            break;

                        case DialogResult.No:
                            txtIdNumber.Text = "";
                            autoID = false;
                            break;

                        case DialogResult.Cancel:
                            txtIdNumber.Focus();
                            autoID = false;
                            return;
                    }
                }
            

            if (txtLastName.Text.Equals("") || txtFirstName.Text.Equals(""))
            {
                txtLastName.Text = "";
                txtFirstName.Text = "";
                MessageBox.Show("Enter a valid first and last name");
                txtLastName.Focus();
                return;
            }

            if (rdoFemale.Checked == false && rdoMale.Checked == false)
            {
                MessageBox.Show("Please select your gender");
                return;
            }

            if (Validator.IsValidUsername(txtUsername.Text))
            {
                if (Validator.IsValidPassword(txtPassword.Text)
                    && txtConfirm.Text.Equals(txtPassword.Text))
                {
                    //More validation
                    string lastName = txtLastName.Text;
                    string firstName = txtFirstName.Text;
                    string idNumber = txtIdNumber.Text;
                    DateTime dob = dtpDoB.Value.Date;

                    SqlConnection connection = pchrDB.getConnection();

                    SqlCommand addPCommand = new SqlCommand();
                    string PCommand = "INSERT PATIENT_TBL "
                        + "(PATIENT_ID, LAST_NAME, FIRST_NAME, DATE_Of_BIRTH)"
                        + "VALUES (@PID, @LNAME, @FNAME, @DOB)";
                    addPCommand.Parameters.AddWithValue("@PID", txtIdNumber.Text);
                    addPCommand.Parameters.AddWithValue("@LNAME", txtLastName.Text);
                    addPCommand.Parameters.AddWithValue("@FNAME", txtFirstName.Text);
                    addPCommand.Parameters.AddWithValue("@DOB", dob);
                    addPCommand.Connection = connection;
                    addPCommand.CommandText = PCommand;

                    connection.Open();
                    try
                    {
                        addPCommand.ExecuteNonQuery().ToString();
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        regSuccess = false;
                    }
                    finally
                    {
                        connection.Close();
                    }

                    SqlCommand addCommand = new SqlCommand();
                    string command = "INSERT UserList "
                        + "(PATIENT_ID, UserName, PassHash) "
                        + "VALUES (@P_ID, @UserName, @PassHash)";
                    
                    addCommand.Parameters.AddWithValue("@P_ID", txtIdNumber.Text);
                    addCommand.Parameters.AddWithValue("@UserName", txtUsername.Text);
                    addCommand.Parameters.AddWithValue("@PassHash", pchrDB.getHashString(txtPassword.Text));
                    addCommand.CommandText = command;
                    addCommand.Connection = connection;
                    addCommand.CommandText = command;

                    connection.Open();
                    try
                    {
                        addCommand.ExecuteNonQuery().ToString();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        regSuccess = false;
                    }
                    finally
                    {
                        connection.Close();                        
                    }                    
                }
            }

            if (regSuccess)
            {
                MessageBox.Show("Registration Success!");

                if (autoID)
                    MessageBox.Show("Your Identity Number is: " + txtIdNumber.Text, "ID Number");

                Close();
            }
        }

        private void txtUsername_Leave(object sender, EventArgs e)
        {
            if (!Validator.IsValidUsername(txtUsername.Text))
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
            if (Validator.IsValidPassword(txtPassword.Text))
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
                if (Validator.IsValidPassword(txtPassword.Text)
                    && Validator.IsValidUsername(txtUsername.Text))
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
