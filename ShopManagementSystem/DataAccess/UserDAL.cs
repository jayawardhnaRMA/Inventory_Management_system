using System;
using System.Data;
using System.Data.SqlClient;

namespace ShopManagementSystem.DataAccess
{
    public class UserDAL
    {
        DbConnectionHelper db = new DbConnectionHelper();

        public bool RegisterUser(string fullName, string username, string password, string role)
        {
            try
            {
                using (SqlConnection con = db.GetConnection())
                {
                    using (SqlCommand cmd = new SqlCommand("sp_RegisterUser", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@FullName", fullName);
                        cmd.Parameters.AddWithValue("@Username", username);
                        cmd.Parameters.AddWithValue("@PasswordHash", password);
                        cmd.Parameters.AddWithValue("@UserRole", role);

                        con.Open();
                        int rows = cmd.ExecuteNonQuery();
                        return rows > 0;
                    }
                }
            }
            catch
            {
                throw;
            }
        }

        public bool LoginUser(string username, string password)
        {
            try
            {
                using (SqlConnection con = db.GetConnection())
                {
                    using (SqlCommand cmd = new SqlCommand("sp_LoginUser", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Username", username);
                        cmd.Parameters.AddWithValue("@PasswordHash", password);

                        con.Open();
                        SqlDataReader reader = cmd.ExecuteReader();
                        return reader.HasRows;
                    }
                }
            }
            catch
            {
                throw;
            }
        }
    }
}