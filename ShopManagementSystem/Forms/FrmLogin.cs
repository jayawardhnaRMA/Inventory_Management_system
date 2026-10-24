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
            try
            {
                if (txtUsername.Text.Trim() == "" || txtPassword.Text.Trim() == "")
                {
                    MessageBox.Show("Please enter username and password.");
                    return;
                }

                btnLogin.Enabled = false;
                Cursor = Cursors.WaitCursor;
                User? user = userDAL.Login(txtUsername.Text.Trim(), txtPassword.Text.Trim());

                if (user != null)
                {
                    MessageBox.Show($"Login successful. Welcome, {user.Name}!");
                    FrmDashboard dashboard = new FrmDashboard();
                    dashboard.Show();
                    this.Hide();
                }
                else
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


        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtUsername.Clear();
            txtPassword.Clear();
            txtUsername.Focus();

        }

        private void btnGoSignup_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmSignup signup = new FrmSignup();
            signup.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
