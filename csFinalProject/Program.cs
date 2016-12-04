using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

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
            
            SqlConnection connection = pchrDB.getConnection();
            SqlCommand addCommand = new SqlCommand();
            string command = "INSERT UserList "
                + "(PATIENT_ID, UserName, PassHash) "
                + "VALUES (@P_ID, @UserName, @PassHash)" 
                + "INSERT UserList "
                + "(PATIENT_ID, UserName, PassHash) "
                + "VALUES (@P_ID2, @UserName2, @PassHash2)";

            addCommand.Parameters.AddWithValue("@P_ID", "000001");
            addCommand.Parameters.AddWithValue("@UserName", "smithjohn");
            addCommand.Parameters.AddWithValue("@PassHash", pchrDB.getHashString("password"));
            addCommand.Parameters.AddWithValue("@P_ID2", "000002");
            addCommand.Parameters.AddWithValue("@UserName2", "doejane");
            addCommand.Parameters.AddWithValue("@PassHash2", pchrDB.getHashString("password"));
            addCommand.CommandText = command;
            addCommand.Connection = connection;

            connection.Open();
            try
            {
                addCommand.ExecuteNonQuery().ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }

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