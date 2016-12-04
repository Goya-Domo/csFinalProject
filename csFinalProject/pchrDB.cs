using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Security.Cryptography;

namespace csFinalProject
{
    class pchrDB
    {
        public static SqlConnection getConnection()
        {
            SqlConnection conn = new SqlConnection(Properties.Settings.Default.pchrdbConnectionString);
            return conn;
        }

        public static string getHashString(string input)
        {
             SHA512 hash = SHA512.Create();

            //This was taken direction from msdn.microsoft.com:
            
            // Convert the input string to a byte array and compute the hash.
            byte[] data = hash.ComputeHash(Encoding.UTF8.GetBytes(input));

            // Create a new Stringbuilder to collect the bytes
            // and create a string.
            StringBuilder sBuilder = new StringBuilder();

            // Loop through each byte of the hashed data 
            // and format each one as a hexadecimal string.
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }

            // Return the hexadecimal string.
            return sBuilder.ToString();
        }
    }
}
