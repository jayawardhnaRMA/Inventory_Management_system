using ShopManagementSystem.DataAccess;
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

                bool isValid = userDAL.LoginUser(txtUsername.Text.Trim(), txtPassword.Text.Trim());

                if (isValid)
                {
                    MessageBox.Show("Login successful.");
                    FrmDashboard dashboard = new FrmDashboard();
                    dashboard.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid username or password.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
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
