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
    public partial class FrmEmployees : Form
    {
        private readonly IRepository<Employee> employeeRepository = new EmployeeDAL();
        private int selectedEmployeeId = 0;

        public FrmEmployees()
        {
            InitializeComponent();
            UiTheme.Apply(this);
        }
        private void LoadEmployees()
        {
            ShowEmployees(() => employeeRepository.GetAll(), "load employees");
        }

        // Runs a query and shows the result in the grid, handling any database errors.
        private void ShowEmployees(Func<List<Employee>> query, string action)
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                GridHelper.Bind(dgvEmployees, query());
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

        private Employee ReadEmployeeFromForm()
        {
            return new Employee(
                txtEmployeeName.Text,
                cmbGender.Text,
                txtPhone.Text,
                txtEmail.Text,
                txtJobTitle.Text,
                decimal.Parse(txtSalary.Text.Trim()),
                dtpHireDate.Value.Date,
                chkIsActive.Checked
            );
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0 && dgvEmployees.Rows[e.RowIndex].DataBoundItem is Employee employee)
            {
                selectedEmployeeId = employee.Id;
                txtEmployeeName.Text = employee.Name;
                cmbGender.Text = employee.Gender;
                txtPhone.Text = employee.Phone;
                txtEmail.Text = employee.Email;
                txtJobTitle.Text = employee.JobTitle;
                txtSalary.Text = employee.Salary.ToString();
                dtpHireDate.Value = employee.HireDate;
                chkIsActive.Checked = employee.IsActive;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ShowEmployees(() => employeeRepository.Search(txtSearch.Text.Trim()), "search employees");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                bool result = employeeRepository.Add(ReadEmployeeFromForm());

                if (result)
                {
                    MessageBox.Show("Employee added successfully.");
                    LoadEmployees();
                    ClearFields();
                }
            }
            catch (ValidationException ex)
            {
                ErrorHandler.ShowValidation(ex);
            }
            catch (Exception ex) when (ex is FormatException || ex is OverflowException)
            {
                ErrorHandler.ShowFormat("Salary must be a valid number.");
            }
            catch (SqlException ex)
            {
                ErrorHandler.ShowDatabase(ex, "add the employee");
            }
            catch (Exception ex)
            {
                ErrorHandler.ShowUnexpected(ex, "add the employee");
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

                Employee employee = ReadEmployeeFromForm();
                employee.Id = selectedEmployeeId;
                bool result = employeeRepository.Update(employee);

                if (result)
                {
                    MessageBox.Show("Employee updated.");
                    LoadEmployees();
                    ClearFields();
                }
            }
            catch (ValidationException ex)
            {
                ErrorHandler.ShowValidation(ex);
            }
            catch (Exception ex) when (ex is FormatException || ex is OverflowException)
            {
                ErrorHandler.ShowFormat("Salary must be a valid number.");
            }
            catch (SqlException ex)
            {
                ErrorHandler.ShowDatabase(ex, "update the employee");
            }
            catch (Exception ex)
            {
                ErrorHandler.ShowUnexpected(ex, "update the employee");
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
                    bool result = employeeRepository.Delete(selectedEmployeeId);
                    if (result)
                    {
                        MessageBox.Show("Employee deleted.");
                        LoadEmployees();
                        ClearFields();
                    }
                }
            }
            catch (SqlException ex)
            {
                ErrorHandler.ShowDatabase(ex, "delete the employee");
            }
            catch (Exception ex)
            {
                ErrorHandler.ShowUnexpected(ex, "delete the employee");
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
            // Back to the dashboard, which reappears when this screen closes.
            Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Close();        }
    }
}
