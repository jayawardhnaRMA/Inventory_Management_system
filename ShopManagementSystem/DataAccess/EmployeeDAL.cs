using System;
using System.Data;
using Microsoft.Data.SqlClient;
using ShopManagementSystem.Models;

namespace ShopManagementSystem.DataAccess
{
    public class EmployeeDAL : BaseDAL<Employee>
    {
        protected override string GetAllProcedure => "sp_GetAllEmployees";
        protected override string SearchProcedure => "sp_SearchEmployees";
        protected override string AddProcedure => "sp_AddEmployee";
        protected override string UpdateProcedure => "sp_UpdateEmployee";
        protected override string DeleteProcedure => "sp_DeleteEmployee";
        protected override string IdParameter => "@EmployeeID";

        protected override Employee MapRow(DataRow row)
        {
            return new Employee
            {
                Id = Convert.ToInt32(row["EmployeeID"]),
                Name = ReadString(row, "EmployeeName"),
                Gender = ReadString(row, "Gender"),
                Phone = ReadString(row, "Phone"),
                Email = ReadString(row, "Email"),
                JobTitle = ReadString(row, "JobTitle"),
                Salary = Convert.ToDecimal(row["Salary"]),
                HireDate = Convert.ToDateTime(row["HireDate"]),
                IsActive = Convert.ToBoolean(row["IsActive"])
            };
        }

        protected override void AddParameters(SqlCommand cmd, Employee employee)
        {
            cmd.Parameters.AddWithValue("@EmployeeName", employee.Name);
            cmd.Parameters.AddWithValue("@Gender", employee.Gender);
            cmd.Parameters.AddWithValue("@Phone", employee.Phone);
            cmd.Parameters.AddWithValue("@Email", employee.Email);
            cmd.Parameters.AddWithValue("@JobTitle", employee.JobTitle);
            cmd.Parameters.AddWithValue("@Salary", employee.Salary);
            cmd.Parameters.AddWithValue("@HireDate", employee.HireDate);
        }

        // sp_UpdateEmployee also takes the active flag, which sp_AddEmployee does not.
        protected override void AddUpdateParameters(SqlCommand cmd, Employee employee)
        {
            base.AddUpdateParameters(cmd, employee);
            cmd.Parameters.AddWithValue("@IsActive", employee.IsActive);
        }
    }
}
