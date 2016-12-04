using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace csFinalProject
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            this.DialogResult = DialogResult.None;
            txtUsername.Text = "smithjohn";
            txtPassword.Text = "password";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Form regForm = new frmRegistration();
            regForm.ShowDialog();
            this.DialogResult = DialogResult.None;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (Validator.IsValidUsername(txtUsername.Text))
            {
                SqlConnection connection = pchrDB.getConnection();
                SqlCommand retCommand = new SqlCommand();
                SqlCommand authCommand = new SqlCommand();
                string command = "SELECT PassHash, PATIENT_ID "
                    + "FROM UserList "
                    + "WHERE UserName = @uName";
                authCommand.Parameters.AddWithValue("@uName", txtUsername.Text);
                authCommand.CommandText = command;
                authCommand.Connection = connection;

                connection.Open();
                SqlDataReader reader =
                    authCommand.ExecuteReader(CommandBehavior.CloseConnection);
                if (reader.Read())
                {
                    string passIn = pchrDB.getHashString(txtPassword.Text);
                    string savedPass = reader["PassHash"].ToString();
                    
                    if (passIn.Equals(savedPass))
                    {
                        User.PATIENT_ID = reader["PATIENT_ID"].ToString();
                        reader.Close();
                        connection.Close();

                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Password incorrect! Try again");
                        this.DialogResult = DialogResult.None;
                        txtPassword.Text = "";
                        txtPassword.Focus();
                    }

                }
                else
                {
                    MessageBox.Show("Username not found. Check your username or click Register if you don't have one");
                    this.DialogResult = DialogResult.None;
                    reader.Close();
                    connection.Close();
                }

                authCommand.Connection = connection;
                if (connection.State == ConnectionState.Open)  
                    connection.Close();
            }
            else
            {
                MessageBox.Show("Username invalid. Re-enter your username, \nor click \"Register\" if you do not have one.\nPress F1 for more information.", "Invalid", MessageBoxButtons.OK);
                this.DialogResult = DialogResult.None;
                txtUsername.Text = "";
                txtUsername.Focus();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form form = new frmPersonalDetails();
            form.Show();
        }
    
    }
}