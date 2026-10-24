using ShopManagementSystem.Helpers;
using warehouse.NewFolder.Forms;
using warehouse.ShopManagementSystem.Forms;

namespace warehouse
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Global safety net: any exception not caught by a form is logged and shown
            // as a message instead of crashing the application.
            Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);
            Application.ThreadException += (sender, e) =>
                ErrorHandler.ShowUnexpected(e.Exception, "complete that action");
            AppDomain.CurrentDomain.UnhandledException += (sender, e) =>
            {
                if (e.ExceptionObject is Exception ex)
                    ErrorHandler.Log(ex);
                MessageBox.Show("A fatal error occurred and the application must close.\n\nDetails were saved to:\n" + ErrorHandler.LogFile,
                    "Fatal error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            };

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmLogin());
        }
    }
}
