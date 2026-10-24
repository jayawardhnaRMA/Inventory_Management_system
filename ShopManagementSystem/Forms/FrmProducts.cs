using Microsoft.Data.SqlClient;
using ShopManagementSystem.DataAccess;
using ShopManagementSystem.Exceptions;
using ShopManagementSystem.Helpers;
using ShopManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace warehouse.NewFolder.Forms
{
    public partial class FrmProducts : Form
    {
        private readonly IRepository<Product> productRepository = new ProductDAL();
        private int selectedProductId = 0;

        public FrmProducts()
        {
            InitializeComponent();
        }

        private void LoadProducts()
        {
            ShowProducts(() => productRepository.GetAll(), "load products");
        }

        // Runs a query and shows the result in the grid, handling any database errors.
        private void ShowProducts(Func<List<Product>> query, string action)
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                GridHelper.Bind(dgvProducts, query());
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

        // Builds a Product object from the textboxes; the model validates the values.
        private Product ReadProductFromForm()
        {
            return new Product(
                txtProductName.Text,
                txtCategory.Text,
                decimal.Parse(txtPrice.Text.Trim()),
                int.Parse(txtQuantity.Text.Trim()),
                int.Parse(txtReorderLevel.Text.Trim()),
                txtSupplier.Text
            );
        }

        private void FrmProducts_Load(object sender, EventArgs e)
        {
            LoadProducts();
        }

        private void txtProductName_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtCategory_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtReorderLevel_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtSupplier_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            ShowProducts(() => productRepository.Search(txtSearch.Text.Trim()), "search products");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                bool result = productRepository.Add(ReadProductFromForm());

                if (result)
                {
                    MessageBox.Show("Product added successfully.");
                    LoadProducts();
                    ClearFields();
                }
            }
            catch (ValidationException ex)
            {
                ErrorHandler.ShowValidation(ex);
            }
            catch (Exception ex) when (ex is FormatException || ex is OverflowException)
            {
                ErrorHandler.ShowFormat("Price, quantity and reorder level must be valid numbers.");
            }
            catch (SqlException ex)
            {
                ErrorHandler.ShowDatabase(ex, "add the product");
            }
            catch (Exception ex)
            {
                ErrorHandler.ShowUnexpected(ex, "add the product");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedProductId == 0)
                {
                    MessageBox.Show("Please select a product.");
                    return;
                }

                Product product = ReadProductFromForm();
                product.Id = selectedProductId;
                bool result = productRepository.Update(product);

                if (result)
                {
                    MessageBox.Show("Product updated successfully.");
                    LoadProducts();
                    ClearFields();
                }
            }
            catch (ValidationException ex)
            {
                ErrorHandler.ShowValidation(ex);
            }
            catch (Exception ex) when (ex is FormatException || ex is OverflowException)
            {
                ErrorHandler.ShowFormat("Price, quantity and reorder level must be valid numbers.");
            }
            catch (SqlException ex)
            {
                ErrorHandler.ShowDatabase(ex, "update the product");
            }
            catch (Exception ex)
            {
                ErrorHandler.ShowUnexpected(ex, "update the product");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedProductId == 0)
                {
                    MessageBox.Show("Please select a product.");
                    return;
                }

                DialogResult dr = MessageBox.Show("Are you sure?", "Confirm", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    bool result = productRepository.Delete(selectedProductId);
                    if (result)
                    {
                        MessageBox.Show("Product deleted.");
                        LoadProducts();
                        ClearFields();
                    }
                }
            }
            catch (SqlException ex)
            {
                ErrorHandler.ShowDatabase(ex, "delete the product");
            }
            catch (Exception ex)
            {
                ErrorHandler.ShowUnexpected(ex, "delete the product");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadProducts();
        }

        private void dgvProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvProducts.Rows[e.RowIndex].DataBoundItem is Product product)
            {
                selectedProductId = product.Id;
                txtProductName.Text = product.Name;
                txtCategory.Text = product.Category;
                txtPrice.Text = product.UnitPrice.ToString();
                txtQuantity.Text = product.QuantityInStock.ToString();
                txtReorderLevel.Text = product.ReorderLevel.ToString();
                txtSupplier.Text = product.SupplierName;
            }
        }

        private void ClearFields()
        {
            selectedProductId = 0;
            txtProductName.Clear();
            txtCategory.Clear();
            txtPrice.Clear();
            txtQuantity.Clear();
            txtReorderLevel.Clear();
            txtSupplier.Clear();
            txtSearch.Clear();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FrmDashboard dashboard = new FrmDashboard();
            dashboard.Show();
            this.Hide();
        }
    }
}