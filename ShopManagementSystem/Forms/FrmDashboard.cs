using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using warehouse.ShopManagementSystem.Forms;

namespace warehouse.NewFolder.Forms
{
    public partial class FrmDashboard : Form
    {
        public FrmDashboard()
        {
            InitializeComponent();
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            FrmProducts form = new FrmProducts();
            form.ShowDialog();
            Hide();

        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            FrmCustomers form = new FrmCustomers();
            form.ShowDialog();
            Hide();

        }

        private void btnEmployees_Click(object sender, EventArgs e)
        {
            FrmEmployees form = new FrmEmployees();
            form.ShowDialog();
            this.Hide();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {

            FrmLogin login = new FrmLogin();
            login.Show();
            this.Hide();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
