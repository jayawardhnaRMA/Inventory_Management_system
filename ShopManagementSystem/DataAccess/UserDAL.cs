using System;
using System.Data;
using ShopManagementSystem.Models;

namespace ShopManagementSystem.DataAccess
{
    // Users are not managed through CRUD screens, so this class only needs the shared
    // database plumbing from DataAccessBase, not the full repository.
    public class UserDAL : DataAccessBase
    {
        public bool Register(User user)
        {
            user.Validate();
            return ExecuteNonQuery("sp_RegisterUser", cmd =>
            {
                cmd.Parameters.AddWithValue("@FullName", user.Name);
                cmd.Parameters.AddWithValue("@Username", user.Username);
                cmd.Parameters.AddWithValue("@PasswordHash", user.Password);
                cmd.Parameters.AddWithValue("@UserRole", user.Role);
            }) > 0;
        }

        // Returns the matching user, or null when the username/password is wrong.
        public User? Login(string username, string password)
        {
            DataTable result = ExecuteQuery("sp_LoginUser", cmd =>
            {
                cmd.Parameters.AddWithValue("@Username", username);
                cmd.Parameters.AddWithValue("@PasswordHash", password);
            });

            if (result.Rows.Count == 0)
                return null;

            DataRow row = result.Rows[0];
            return new User
            {
                Id = Convert.ToInt32(row["UserID"]),
                Name = ReadString(row, "FullName"),
                Username = ReadString(row, "Username"),
                Role = ReadString(row, "UserRole")
            };
        }
    }
}
