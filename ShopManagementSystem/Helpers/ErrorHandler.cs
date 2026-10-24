using System;
using System.IO;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using ShopManagementSystem.Exceptions;

namespace ShopManagementSystem.Helpers
{
    // Central place for showing friendly error messages and logging failures.
    public static class ErrorHandler
    {
        public static readonly string LogFile = Path.Combine(AppContext.BaseDirectory, "error.log");

        public static void ShowValidation(ValidationException ex)
        {
            MessageBox.Show(ex.Message, "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public static void ShowFormat(string message)
        {
            MessageBox.Show(message, "Invalid number", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public static void ShowDatabase(SqlException ex, string action)
        {
            Log(ex);
            MessageBox.Show($"Could not {action}.\n\n{DescribeSqlError(ex)}",
                "Database error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void ShowUnexpected(Exception ex, string action)
        {
            Log(ex);
            MessageBox.Show($"Something went wrong while trying to {action}.\n\n{ex.Message}\n\nDetails were saved to:\n{LogFile}",
                "Unexpected error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        // Translates common SQL Server error numbers into messages a user can act on.
        public static string DescribeSqlError(SqlException ex)
        {
            return ex.Number switch
            {
                2627 or 2601 => "A record with the same value already exists.",
                547 => "This record is linked to other data and cannot be changed or deleted.",
                -2 => "The database took too long to respond. Please try again.",
                4060 => "The ShopManagementDB database was not found. Run Database/ShopManagementDB.sql first.",
                18456 => "The database rejected the login. Check the connection settings.",
                -1 or 2 or 26 or 40 or 53 => "Cannot connect to the database server. Make sure SQL Server is running.",
                _ => ex.Message
            };
        }

        public static void Log(Exception ex)
        {
            try
            {
                File.AppendAllText(LogFile,
                    $"[{DateTime.Now:yyyy-MM-dd HH:mm:ss}] {ex}{Environment.NewLine}{Environment.NewLine}");
            }
            catch (IOException)
            {
                // Logging must never crash the application.
            }
            catch (UnauthorizedAccessException)
            {
            }
        }
    }
}
