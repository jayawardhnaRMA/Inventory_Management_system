using Microsoft.Data.SqlClient;
using ShopManagementSystem.DataAccess;
using ShopManagementSystem.Exceptions;
using ShopManagementSystem.Helpers;
using ShopManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace warehouse.ShopManagementSystem.Forms
{
    public partial class FrmSignup : Form
    {
        UserDAL userDAL = new UserDAL();
        public FrmSignup()
        {
            InitializeComponent();
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtFullName_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbRole_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {

            try
            {
                if (txtFullName.Text.Trim() == "" || txtUsername.Text.Trim() == "" || txtPassword.Text.Trim() == "")
                {
                    MessageBox.Show("Please fill all required fields.");
                    return;
                }

                User user = new User(txtFullName.Text, txtUsername.Text, txtPassword.Text, cmbRole.Text);
                bool result = userDAL.Register(user);

                if (result)
                {
                    MessageBox.Show("User registered successfully.");
                    btnClear.PerformClick();
                }
            }
            catch (ValidationException ex)
            {
                ErrorHandler.ShowValidation(ex);
            }
            catch (SqlException ex) when (ex.Number == 2627 || ex.Number == 2601)
            {
                // Unique constraint on Users.Username
                MessageBox.Show("That username is already taken. Please choose another.",
                    "Username taken", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (SqlException ex)
            {
                ErrorHandler.ShowDatabase(ex, "register the user");
            }
            catch (Exception ex)
            {
                ErrorHandler.ShowUnexpected(ex, "register the user");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtFullName.Clear();
            txtUsername.Clear();
            txtPassword.Clear();
            cmbRole.SelectedIndex = 2;

        }

        private void btnBackLogin_Click(object sender, EventArgs e)
        {
            FrmLogin login = new FrmLogin();
            login.Show();
            this.Hide();

        }

        private void FrmSignup_Load(object sender, EventArgs e)
        {
            cmbRole.Items.Add("Admin");
            cmbRole.Items.Add("Manager");
            cmbRole.Items.Add("Staff");
            cmbRole.SelectedIndex = 2;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Close();

        }
    }
}
