using Microsoft.Data.SqlClient;
using ShopManagementSystem.DataAccess;
using ShopManagementSystem.Helpers;
using ShopManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using warehouse.NewFolder.Forms;

namespace warehouse.ShopManagementSystem.Forms
{
    public partial class FrmLogin : Form

    {
        UserDAL userDAL = new UserDAL();
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            User? user = null;
            try
            {
                if (txtUsername.Text.Trim() == "" || txtPassword.Text.Trim() == "")
                {
                    MessageBox.Show("Please enter username and password.");
                    return;
                }

                btnLogin.Enabled = false;
                Cursor = Cursors.WaitCursor;
                user = userDAL.Login(txtUsername.Text.Trim(), txtPassword.Text.Trim());

                if (user == null)
                {
                    MessageBox.Show("Invalid username or password.");
                }
            }
            catch (SqlException ex)
            {
                ErrorHandler.ShowDatabase(ex, "log in");
            }
            catch (Exception ex)
            {
                ErrorHandler.ShowUnexpected(ex, "log in");
            }
            finally
            {
                // Always restore the button, even if the database call failed.
                btnLogin.Enabled = true;
                Cursor = Cursors.Default;
            }

            if (user != null)
                OpenDashboard(user);
        }

        // The login form stays hidden while the dashboard is open. Logging out returns here;
        // closing the dashboard any other way exits the application.
        private void OpenDashboard(User user)
        {
            Session.Start(user);
            txtPassword.Clear();
            Hide();

            DialogResult result;
            using (FrmDashboard dashboard = new FrmDashboard())
            {
                result = dashboard.ShowDialog();
            }

            Session.End();
            if (result == DialogResult.OK)
                Show();
            else
                Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtUsername.Clear();
            txtPassword.Clear();
            chkShowPassword.Checked = false;
            txtUsername.Focus();

        }

        private void btnGoSignup_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Hide();
            using (FrmSignup signup = new FrmSignup())
            {
                signup.ShowDialog();
            }
            Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            // Hidden (dots) unless the box is ticked.
            txtPassword.UseSystemPasswordChar = !chkShowPassword.Checked;
        }
    }
}
