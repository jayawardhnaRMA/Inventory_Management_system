using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ShopManagementSystem.DataAccess;


namespace warehouse.NewFolder.Forms
{
    public partial class FrmCustomers : Form
    {
        CustomerDAL customerDAL = new CustomerDAL();
        int selectedCustomerId = 0;
        public FrmCustomers()
        {
            InitializeComponent();
        }

        private void FrmCustomers_Load(object sender, EventArgs e)
        {
            LoadCustomers();
        }
        private void LoadCustomers()
        {
            dgvCustomers.DataSource = customerDAL.GetAllCustomers();
        }

        private void txtCustomerName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dgvCustomers.DataSource = customerDAL.SearchCustomers(txtSearch.Text.Trim());

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                bool result = customerDAL.AddCustomer(
                    txtCustomerName.Text.Trim(),
                    txtPhone.Text.Trim(),
                    txtEmail.Text.Trim(),
                    txtAddress.Text.Trim()
                );

                if (result)
                {
                    MessageBox.Show("Customer added successfully.");
                    LoadCustomers();
                    ClearFields();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Add failed: " + ex.Message);
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedCustomerId == 0)
                {
                    MessageBox.Show("Please select a customer.");
                    return;
                }

                bool result = customerDAL.UpdateCustomer(
                    selectedCustomerId,
                    txtCustomerName.Text.Trim(),
                    txtPhone.Text.Trim(),
                    txtEmail.Text.Trim(),
                    txtAddress.Text.Trim()
                );

                if (result)
                {
                    MessageBox.Show("Customer updated.");
                    LoadCustomers();
                    ClearFields();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Update failed: " + ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedCustomerId == 0)
                {
                    MessageBox.Show("Please select a customer.");
                    return;
                }

                DialogResult dr = MessageBox.Show("Are you sure?", "Confirm", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    bool result = customerDAL.DeleteCustomer(selectedCustomerId);
                    if (result)
                    {
                        MessageBox.Show("Customer deleted.");
                        LoadCustomers();
                        ClearFields();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Delete failed: " + ex.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }
        private void ClearFields()
        {
            selectedCustomerId = 0;
            txtCustomerName.Clear();
            txtPhone.Clear();
            txtEmail.Clear();
            txtAddress.Clear();
            txtSearch.Clear();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadCustomers();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            FrmDashboard dashboard = new FrmDashboard();
            dashboard.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
