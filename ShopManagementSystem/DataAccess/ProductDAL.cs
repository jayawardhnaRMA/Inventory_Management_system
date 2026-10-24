using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;
using ShopManagementSystem.Models;

namespace ShopManagementSystem.DataAccess
{
    public class ProductDAL : BaseDAL<Product>
    {
        protected override string GetAllProcedure => "sp_GetAllProducts";
        protected override string SearchProcedure => "sp_SearchProducts";
        protected override string AddProcedure => "sp_AddProduct";
        protected override string UpdateProcedure => "sp_UpdateProduct";
        protected override string DeleteProcedure => "sp_DeleteProduct";
        protected override string IdParameter => "@ProductID";

        public List<Product> GetLowStock()
        {
            return MapRows(ExecuteQuery("sp_GetLowStockProducts"));
        }

        protected override Product MapRow(DataRow row)
        {
            return new Product
            {
                Id = Convert.ToInt32(row["ProductID"]),
                Name = ReadString(row, "ProductName"),
                Category = ReadString(row, "Category"),
                UnitPrice = Convert.ToDecimal(row["UnitPrice"]),
                QuantityInStock = Convert.ToInt32(row["QuantityInStock"]),
                ReorderLevel = Convert.ToInt32(row["ReorderLevel"]),
                SupplierName = ReadString(row, "SupplierName")
            };
        }

        protected override void AddParameters(SqlCommand cmd, Product product)
        {
            cmd.Parameters.AddWithValue("@ProductName", product.Name);
            cmd.Parameters.AddWithValue("@Category", product.Category);
            cmd.Parameters.AddWithValue("@UnitPrice", product.UnitPrice);
            cmd.Parameters.AddWithValue("@QuantityInStock", product.QuantityInStock);
            cmd.Parameters.AddWithValue("@ReorderLevel", product.ReorderLevel);
            cmd.Parameters.AddWithValue("@SupplierName", product.SupplierName);
        }
    }
}
