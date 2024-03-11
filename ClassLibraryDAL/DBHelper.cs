using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryDAL
{
    public class DBHelper
    {
        public static SqlConnection GetConnection()
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-REC0NDU\\SAMEERSQL;Initial Catalog=BlogifyDB;Integrated Security=True");
            return conn;
        }
    }
}
