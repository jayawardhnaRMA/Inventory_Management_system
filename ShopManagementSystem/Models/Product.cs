using System;
using System.Collections.Generic;
using System.Text;

namespace warehouse.NewFolder.Models
{
    public class Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public string Category { get; set; }
        public decimal UnitPrice { get; set; }
        public int QuantityInStock { get; set; }
        public int ReorderLevel { get; set; }
        public string SupplierName { get; set; }
    }
}
