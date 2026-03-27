using ShopManagementSystem.DataAccess;
using System;
using System.Windows.Forms;

namespace warehouse.NewFolder.Forms
{
    public partial class FrmProducts : Form
    {
        ProductDAL productDAL = new ProductDAL();
        int selectedProductId = 0;

        public FrmProducts()
        {
            InitializeComponent();
        }

        private void LoadProducts()
        {
            dgvProducts.DataSource = productDAL.GetAllProducts();
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
            dgvProducts.DataSource = productDAL.SearchProducts(txtSearch.Text.Trim());
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                bool result = productDAL.AddProduct(
                    txtProductName.Text.Trim(),
                    txtCategory.Text.Trim(),
                    decimal.Parse(txtPrice.Text.Trim()),
                    int.Parse(txtQuantity.Text.Trim()),
                    int.Parse(txtReorderLevel.Text.Trim()),
                    txtSupplier.Text.Trim()
                );

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

                bool result = productDAL.UpdateProduct(
                    selectedProductId,
                    txtProductName.Text.Trim(),
                    txtCategory.Text.Trim(),
                    decimal.Parse(txtPrice.Text.Trim()),
                    int.Parse(txtQuantity.Text.Trim()),
                    int.Parse(txtReorderLevel.Text.Trim()),
                    txtSupplier.Text.Trim()
                );

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
                    bool result = productDAL.DeleteProduct(selectedProductId);
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
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvProducts.Rows[e.RowIndex];
                selectedProductId = Convert.ToInt32(row.Cells["ProductID"].Value);
                txtProductName.Text = row.Cells["ProductName"].Value.ToString();
                txtCategory.Text = row.Cells["Category"].Value.ToString();
                txtPrice.Text = row.Cells["UnitPrice"].Value.ToString();
                txtQuantity.Text = row.Cells["QuantityInStock"].Value.ToString();
                txtReorderLevel.Text = row.Cells["ReorderLevel"].Value.ToString();
                txtSupplier.Text = row.Cells["SupplierName"].Value.ToString();
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