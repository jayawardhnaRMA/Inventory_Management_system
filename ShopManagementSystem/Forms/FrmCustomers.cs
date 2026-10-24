using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using ShopManagementSystem.DataAccess;
using ShopManagementSystem.Exceptions;
using ShopManagementSystem.Helpers;
using ShopManagementSystem.Models;


namespace warehouse.NewFolder.Forms
{
    public partial class FrmCustomers : Form
    {
        private readonly IRepository<Customer> customerRepository = new CustomerDAL();
        private int selectedCustomerId = 0;
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
            ShowCustomers(() => customerRepository.GetAll(), "load customers");
        }

        // Runs a query and shows the result in the grid, handling any database errors.
        private void ShowCustomers(Func<List<Customer>> query, string action)
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                GridHelper.Bind(dgvCustomers, query());
            }
            catch (SqlException ex)
            {
                ErrorHandler.ShowDatabase(ex, action);
            }
            catch (Exception ex)
            {
                ErrorHandler.ShowUnexpected(ex, action);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        private Customer ReadCustomerFromForm()
        {
            return new Customer(txtCustomerName.Text, txtPhone.Text, txtEmail.Text, txtAddress.Text);
        }

        private void dgvCustomers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvCustomers.Rows[e.RowIndex].DataBoundItem is Customer customer)
            {
                selectedCustomerId = customer.Id;
                txtCustomerName.Text = customer.Name;
                txtPhone.Text = customer.Phone;
                txtEmail.Text = customer.Email;
                txtAddress.Text = customer.Address;
            }
        }

        private void txtCustomerName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            ShowCustomers(() => customerRepository.Search(txtSearch.Text.Trim()), "search customers");

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                bool result = customerRepository.Add(ReadCustomerFromForm());

                if (result)
                {
                    MessageBox.Show("Customer added successfully.");
                    LoadCustomers();
                    ClearFields();
                }
            }
            catch (ValidationException ex)
            {
                ErrorHandler.ShowValidation(ex);
            }
            catch (SqlException ex)
            {
                ErrorHandler.ShowDatabase(ex, "add the customer");
            }
            catch (Exception ex)
            {
                ErrorHandler.ShowUnexpected(ex, "add the customer");
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

                Customer customer = ReadCustomerFromForm();
                customer.Id = selectedCustomerId;
                bool result = customerRepository.Update(customer);

                if (result)
                {
                    MessageBox.Show("Customer updated.");
                    LoadCustomers();
                    ClearFields();
                }
            }
            catch (ValidationException ex)
            {
                ErrorHandler.ShowValidation(ex);
            }
            catch (SqlException ex)
            {
                ErrorHandler.ShowDatabase(ex, "update the customer");
            }
            catch (Exception ex)
            {
                ErrorHandler.ShowUnexpected(ex, "update the customer");
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
                    bool result = customerRepository.Delete(selectedCustomerId);
                    if (result)
                    {
                        MessageBox.Show("Customer deleted.");
                        LoadCustomers();
                        ClearFields();
                    }
                }
            }
            catch (SqlException ex)
            {
                ErrorHandler.ShowDatabase(ex, "delete the customer");
            }
            catch (Exception ex)
            {
                ErrorHandler.ShowUnexpected(ex, "delete the customer");
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
