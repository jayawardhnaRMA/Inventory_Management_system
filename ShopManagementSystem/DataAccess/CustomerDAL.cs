using System;
using System.Data;
using Microsoft.Data.SqlClient;
using ShopManagementSystem.Models;

namespace ShopManagementSystem.DataAccess
{
    public class CustomerDAL : BaseDAL<Customer>
    {
        protected override string GetAllProcedure => "sp_GetAllCustomers";
        protected override string SearchProcedure => "sp_SearchCustomers";
        protected override string AddProcedure => "sp_AddCustomer";
        protected override string UpdateProcedure => "sp_UpdateCustomer";
        protected override string DeleteProcedure => "sp_DeleteCustomer";
        protected override string IdParameter => "@CustomerID";

        protected override Customer MapRow(DataRow row)
        {
            return new Customer
            {
                Id = Convert.ToInt32(row["CustomerID"]),
                Name = ReadString(row, "CustomerName"),
                Phone = ReadString(row, "Phone"),
                Email = ReadString(row, "Email"),
                Address = ReadString(row, "Address")
            };
        }

        protected override void AddParameters(SqlCommand cmd, Customer customer)
        {
            cmd.Parameters.AddWithValue("@CustomerName", customer.Name);
            cmd.Parameters.AddWithValue("@Phone", customer.Phone);
            cmd.Parameters.AddWithValue("@Email", customer.Email);
            cmd.Parameters.AddWithValue("@Address", customer.Address);
        }
    }
}
