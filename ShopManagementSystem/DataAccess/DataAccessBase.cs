using System;
using System.Data;
using Microsoft.Data.SqlClient;

namespace ShopManagementSystem.DataAccess
{
    // Shared plumbing for every data-access class: opening connections and running stored procedures.
    public abstract class DataAccessBase
    {
        private readonly DbConnectionHelper db = new DbConnectionHelper();

        protected DataTable ExecuteQuery(string procedure)
        {
            return ExecuteQuery(procedure, cmd => { });
        }

        protected DataTable ExecuteQuery(string procedure, Action<SqlCommand> addParameters)
        {
            using (SqlConnection con = db.GetConnection())
            using (SqlCommand cmd = CreateCommand(procedure, con, addParameters))
            using (SqlDataAdapter da = new SqlDataAdapter(cmd))
            {
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        protected int ExecuteNonQuery(string procedure, Action<SqlCommand> addParameters)
        {
            using (SqlConnection con = db.GetConnection())
            using (SqlCommand cmd = CreateCommand(procedure, con, addParameters))
            {
                con.Open();
                return cmd.ExecuteNonQuery();
            }
        }

        // Reads a column as text, treating database NULL as an empty string.
        protected static string ReadString(DataRow row, string column)
        {
            return Convert.ToString(row[column]) ?? string.Empty;
        }

        private static SqlCommand CreateCommand(string procedure, SqlConnection con, Action<SqlCommand> addParameters)
        {
            SqlCommand cmd = new SqlCommand(procedure, con);
            cmd.CommandType = CommandType.StoredProcedure;
            addParameters(cmd);
            return cmd;
        }
    }
}
