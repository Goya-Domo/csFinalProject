using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace csFinalProject
{
    static class Program
    {
        static Form personalDetailsForm;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            frmLogin fLogin = new frmLogin();
            if (fLogin.ShowDialog() == DialogResult.OK)
            {
                Application.Run(new frmPersonalDetails());
            }
            else
            {
                Application.Exit();
            }
        }

        public static void showPersonalDetailsForm()
        {
            personalDetailsForm = new frmPersonalDetails();
            personalDetailsForm.Show();
        }
    }
}