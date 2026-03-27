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
    public partial class FrmEmployees : Form
    {
        EmployeeDAL employeeDAL = new EmployeeDAL();
        int selectedEmployeeId = 0;

        public FrmEmployees()
        {
            InitializeComponent();
        }
        private void LoadEmployees()
        {
            dgvEmployees.DataSource = employeeDAL.GetAllEmployees();
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvEmployees.Rows[e.RowIndex];
                selectedEmployeeId = Convert.ToInt32(row.Cells["EmployeeID"].Value);
                txtEmployeeName.Text = row.Cells["EmployeeName"].Value.ToString();
                cmbGender.Text = row.Cells["Gender"].Value.ToString();
                txtPhone.Text = row.Cells["Phone"].Value.ToString();
                txtEmail.Text = row.Cells["Email"].Value.ToString();
                txtJobTitle.Text = row.Cells["JobTitle"].Value.ToString();
                txtSalary.Text = row.Cells["Salary"].Value.ToString();
                dtpHireDate.Value = Convert.ToDateTime(row.Cells["HireDate"].Value);
                chkIsActive.Checked = Convert.ToBoolean(row.Cells["IsActive"].Value);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            dgvEmployees.DataSource = employeeDAL.SearchEmployees(txtSearch.Text.Trim());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                bool result = employeeDAL.AddEmployee(
                    txtEmployeeName.Text.Trim(),
                    cmbGender.Text,
                    txtPhone.Text.Trim(),
                    txtEmail.Text.Trim(),
                    txtJobTitle.Text.Trim(),
                    decimal.Parse(txtSalary.Text.Trim()),
                    dtpHireDate.Value.Date
                );

                if (result)
                {
                    MessageBox.Show("Employee added successfully.");
                    LoadEmployees();
                    ClearFields();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Add failed: " + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedEmployeeId == 0)
                {
                    MessageBox.Show("Please select an employee.");
                    return;
                }

                bool result = employeeDAL.UpdateEmployee(
                    selectedEmployeeId,
                    txtEmployeeName.Text.Trim(),
                    cmbGender.Text,
                    txtPhone.Text.Trim(),
                    txtEmail.Text.Trim(),
                    txtJobTitle.Text.Trim(),
                    decimal.Parse(txtSalary.Text.Trim()),
                    dtpHireDate.Value.Date,
                    chkIsActive.Checked
                );

                if (result)
                {
                    MessageBox.Show("Employee updated.");
                    LoadEmployees();
                    ClearFields();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Update failed: " + ex.Message);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedEmployeeId == 0)
                {
                    MessageBox.Show("Please select an employee.");
                    return;
                }

                DialogResult dr = MessageBox.Show("Are you sure?", "Confirm", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    bool result = employeeDAL.DeleteEmployee(selectedEmployeeId);
                    if (result)
                    {
                        MessageBox.Show("Employee deleted.");
                        LoadEmployees();
                        ClearFields();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Delete failed: " + ex.Message);
            }
        }


        private void button4_Click(object sender, EventArgs e)
        {
            ClearFields();
        }
        private void ClearFields()
        {
            selectedEmployeeId = 0;
            txtEmployeeName.Clear();
            cmbGender.SelectedIndex = 0;
            txtPhone.Clear();
            txtEmail.Clear();
            txtJobTitle.Clear();
            txtSalary.Clear();
            txtSearch.Clear();
            chkIsActive.Checked = true;
            dtpHireDate.Value = DateTime.Now;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            LoadEmployees();
        }

        private void FrmEmployees_Load(object sender, EventArgs e)
        {
            cmbGender.Items.Add("Male");
            cmbGender.Items.Add("Female");
            cmbGender.Items.Add("Other");
            cmbGender.SelectedIndex = 0;

            LoadEmployees();
        }

        private void txtEmployeeName_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            FrmDashboard dashboard = new FrmDashboard();
            dashboard.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Close();        }
    }
}
