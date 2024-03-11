using ClassLibraryModel;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryDAL
{
    public class BlogDAL
    {
        public static List<Blog> GetProperties(string uname) //GetUserBlogDAL
        {
            SqlConnection con = DBHelper.GetConnection();
            con.Open();
            SqlCommand cmd = new SqlCommand("sp_BlogByName ", con);
            cmd.Parameters.AddWithValue("@Username", uname);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            SqlDataReader sdr = cmd.ExecuteReader();
            List<Blog> BlogList = new List<Blog>();
            while (sdr.Read())
            {
                Blog Info = new Blog();
                Info.Title = sdr["Title"].ToString();
                Info.Content = sdr["Content"].ToString();
                Info.ImageURL = sdr["ImageURL"].ToString();
                BlogList.Add(Info);

                BlogList.Add(Info);
            }
            con.Close();
            return BlogList;
        }
        public static List<Blog> GetBlog() //GetBlogDAL
        {
            SqlConnection con = DBHelper.GetConnection();
            con.Open();
            SqlCommand cmd = new SqlCommand("sp_ShowBlog", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            SqlDataReader sdr = cmd.ExecuteReader();
            List<Blog> BlogList = new List<Blog>();
            while (sdr.Read())
            {
                Blog Info = new Blog();
                Info.Title = sdr["Title"].ToString();
                Info.Content = sdr["Content"].ToString();
                Info.ImageURL = sdr["ImageURL"].ToString();
                BlogList.Add(Info);
            }
            con.Close();
            return BlogList;
        }
        public static int SaveBlog(Blog cm, string name) //SaveBlog
        {
            SqlConnection conn = DBHelper.GetConnection();
            conn.Open();

            SqlCommand cmd = new SqlCommand("sp_SaveBlog ", conn);

            cmd.Parameters.AddWithValue("@Title", cm.Title);
            cmd.Parameters.AddWithValue("@Content", cm.Content);
            cmd.Parameters.AddWithValue("@ImageURL", cm.ImageURL);
            cmd.Parameters.AddWithValue("@RegUserName", name);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            int i = cmd.ExecuteNonQuery();

            conn.Close();
            return i;
        }
        public static int DeleteBlog(int BlogID) //DeleteBlogDAL
        {
            SqlConnection con = DBHelper.GetConnection();
            con.Open();

            SqlCommand cmd = new SqlCommand("sp_DeleteBlog", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@BlogId", BlogID);

            int i = cmd.ExecuteNonQuery();

            con.Close();
            return i;

        }
    }
}
