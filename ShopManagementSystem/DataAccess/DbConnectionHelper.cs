using System.Data.SqlClient;

namespace ShopManagementSystem.DataAccess
{
    public class DbConnectionHelper
    {
        private readonly string connectionString =
            @"Data Source=YESHINI\SQLEXPRESS;Initial Catalog=ShopManagementDB;Integrated Security=True;Encrypt=False";

        public SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}