using System;
using System.Data;
using ShopManagementSystem.Models;

namespace ShopManagementSystem.DataAccess
{
    public class DashboardDAL : DataAccessBase
    {
        public DashboardStats GetStats()
        {
            DataRow row = ExecuteQuery("sp_GetDashboardStats").Rows[0];
            return new DashboardStats
            {
                TotalProducts = Convert.ToInt32(row["TotalProducts"]),
                LowStockProducts = Convert.ToInt32(row["LowStockProducts"]),
                StockValue = Convert.ToDecimal(row["StockValue"]),
                TotalCustomers = Convert.ToInt32(row["TotalCustomers"]),
                ActiveEmployees = Convert.ToInt32(row["ActiveEmployees"]),
                TotalEmployees = Convert.ToInt32(row["TotalEmployees"])
            };
        }
    }
}
