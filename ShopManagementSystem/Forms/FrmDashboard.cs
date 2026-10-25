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

namespace warehouse.NewFolder.Forms
{
    public partial class FrmDashboard : Form
    {
        private readonly DashboardDAL dashboardDAL = new DashboardDAL();
        private readonly ProductDAL productDAL = new ProductDAL();
        private readonly UserDAL userDAL = new UserDAL();
        private readonly ToolTip toolTip = new ToolTip();

        public FrmDashboard()
        {
            InitializeComponent();
            UiTheme.Apply(this);
            SetUpProfileLink();
        }

        private void FrmDashboard_Load(object sender, EventArgs e)
        {
            User? user = Session.CurrentUser;
            lblWelcome.Text = user == null ? "Welcome" : $"Welcome, {user.Name} ({user.Role})  ▾";
            LoadStats();
        }

        // The welcome text acts as a link that opens the profile window.
        private void SetUpProfileLink()
        {
            Font normal = lblWelcome.Font;
            Font underlined = new Font(normal, normal.Style | FontStyle.Underline);

            lblWelcome.Cursor = Cursors.Hand;
            toolTip.SetToolTip(lblWelcome, "View profile");
            lblWelcome.MouseEnter += (sender, e) => lblWelcome.Font = underlined;
            lblWelcome.MouseLeave += (sender, e) => lblWelcome.Font = normal;
            lblWelcome.Click += (sender, e) => ShowProfile();
        }

        private void ShowProfile()
        {
            if (Session.CurrentUser == null)
                return;

            try
            {
                Cursor = Cursors.WaitCursor;
                User? profile = userDAL.GetProfile(Session.CurrentUser.Id);
                Cursor = Cursors.Default;

                if (profile == null)
                {
                    Dialogs.Warning("Your account could not be found. It may have been removed.", "Profile");
                    return;
                }

                using (FrmProfile profileForm = new FrmProfile(profile))
                {
                    profileForm.ShowDialog(this);
                }
            }
            catch (SqlException ex)
            {
                ErrorHandler.ShowDatabase(ex, "load your profile");
            }
            catch (Exception ex)
            {
                ErrorHandler.ShowUnexpected(ex, "load your profile");
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        private void LoadStats()
        {
            try
            {
                Cursor = Cursors.WaitCursor;

                DashboardStats stats = dashboardDAL.GetStats();
                lblTotalProducts.Text = $"Products: {stats.TotalProducts}";
                lblLowStock.Text = $"Low stock: {stats.LowStockProducts}";
                lblLowStock.ForeColor = stats.LowStockProducts > 0 ? Color.Red : SystemColors.ControlText;
                lblStockValue.Text = $"Stock value: {stats.StockValue:N2}";
                lblCustomers.Text = $"Customers: {stats.TotalCustomers}";
                lblActiveEmployees.Text = $"Employees: {stats.ActiveEmployees} active / {stats.TotalEmployees}";

                lstLowStock.Items.Clear();
                foreach (Product product in productDAL.GetLowStock())
                {
                    lstLowStock.Items.Add($"{product.Name} ({product.QuantityInStock} left)");
                }
                if (lstLowStock.Items.Count == 0)
                    lstLowStock.Items.Add("All products are well stocked.");
            }
            catch (SqlException ex)
            {
                ErrorHandler.ShowDatabase(ex, "load the dashboard figures");
            }
            catch (Exception ex)
            {
                ErrorHandler.ShowUnexpected(ex, "load the dashboard figures");
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        // Hides the dashboard while a management screen is open, then refreshes the figures.
        private void OpenScreen(Form screen)
        {
            Hide();
            using (screen)
            {
                screen.ShowDialog();
            }
            Show();
            LoadStats();
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            OpenScreen(new FrmProducts());
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            OpenScreen(new FrmCustomers());
        }

        private void btnEmployees_Click(object sender, EventArgs e)
        {
            if (!Session.CanManageEmployees)
            {
                Dialogs.Warning("Only Admin or Manager users can manage employees.", "Access denied");
                return;
            }
            OpenScreen(new FrmEmployees());
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadStats();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            // OK tells the login screen to show itself again.
            DialogResult = DialogResult.OK;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // Any result other than OK closes the whole application.
            DialogResult = DialogResult.Abort;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
