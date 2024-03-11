using ClassLibraryModel;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryDAL
{
    public class UserDAL
    {
        public static int SaveRegisterUser(User cm) //RegisterUserDAL
        {
            SqlConnection conn = DBHelper.GetConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand("sp_SaveUser", conn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@UserName", cm.UserName);
            cmd.Parameters.AddWithValue("@Phone", cm.Phone);
            cmd.Parameters.AddWithValue("@EmailAddress", cm.EmailAddress);
            cmd.Parameters.AddWithValue("@Password", cm.Password);
            int i = cmd.ExecuteNonQuery();
            conn.Close();
            return i;
        }
        //Add Delete User and Update User Stored Procedures and DAL accordingly inside this...
    }
}
