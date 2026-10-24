using Microsoft.Data.SqlClient;

namespace ShopManagementSystem.DataAccess
{
    public class DbConnectionHelper
    {
        private readonly string connectionString =
            @"Data Source=DESKTOP-9EB0L75\SQLEXPRESS;Initial Catalog=ShopManagementDB;Integrated Security=True;Encrypt=False";

        public SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}
