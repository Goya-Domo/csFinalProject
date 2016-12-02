using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace csFinalProject
{
    class pchrDB
    {
        public static SqlConnection getConnection()
        {
            SqlConnection conn = new SqlConnection(Properties.Settings.Default.pchrdbConnectionString);
            return conn;
        }
    }
}
