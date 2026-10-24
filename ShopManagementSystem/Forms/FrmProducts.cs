using ShopManagementSystem.DataAccess;
using ShopManagementSystem.Helpers;
using ShopManagementSystem.Models;
using System;
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
            GridHelper.Bind(dgvProducts, productRepository.GetAll());
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
            GridHelper.Bind(dgvProducts, productRepository.Search(txtSearch.Text.Trim()));
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
            catch (Exception ex)
            {
                MessageBox.Show("Add failed: " + ex.Message);
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
            catch (Exception ex)
            {
                MessageBox.Show("Update failed: " + ex.Message);
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
            catch (Exception ex)
            {
                MessageBox.Show("Delete failed: " + ex.Message);
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