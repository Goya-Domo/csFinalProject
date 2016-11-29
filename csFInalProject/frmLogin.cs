﻿using System;
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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Form regForm = new frmRegistration();
            regForm.ShowDialog();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (Validator.isValidUsername(txtUsername.Text))
            {

            }
            else
            {
                MessageBox.Show("Username invalid", "Invalid", MessageBoxButtons.OK);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form form = new frmPersonalDetails();
            form.Show();
        }
    }
}