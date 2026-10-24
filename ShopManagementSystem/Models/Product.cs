using System.ComponentModel;

namespace ShopManagementSystem.Models
{
    public class Product : Entity
    {
        private string _name = string.Empty;
        private string _category = string.Empty;
        private decimal _unitPrice;
        private int _quantityInStock;
        private int _reorderLevel;
        private string _supplierName = string.Empty;

        public Product()
        {
        }

        public Product(string name, string category, decimal unitPrice,
                       int quantityInStock, int reorderLevel, string supplierName)
        {
            Name = name;
            Category = category;
            UnitPrice = unitPrice;
            QuantityInStock = quantityInStock;
            ReorderLevel = reorderLevel;
            SupplierName = supplierName;
        }

        [DisplayName("Product Name")]
        public string Name
        {
            get => _name;
            set => _name = ValidationRules.Required(value, "Product name");
        }

        public string Category
        {
            get => _category;
            set => _category = ValidationRules.Optional(value);
        }

        [DisplayName("Unit Price")]
        public decimal UnitPrice
        {
            get => _unitPrice;
            set => _unitPrice = ValidationRules.NotNegative(value, "Unit price");
        }

        [DisplayName("Qty In Stock")]
        public int QuantityInStock
        {
            get => _quantityInStock;
            set => _quantityInStock = ValidationRules.NotNegative(value, "Quantity");
        }

        [DisplayName("Reorder Level")]
        public int ReorderLevel
        {
            get => _reorderLevel;
            set => _reorderLevel = ValidationRules.NotNegative(value, "Reorder level");
        }

        [DisplayName("Supplier")]
        public string SupplierName
        {
            get => _supplierName;
            set => _supplierName = ValidationRules.Optional(value);
        }

        [DisplayName("Low Stock")]
        public bool IsLowStock => QuantityInStock <= ReorderLevel;

        public override void Validate()
        {
            ValidationRules.Required(_name, "Product name");
        }

        public override string ToString()
        {
            return $"{Name} - {QuantityInStock} in stock @ {UnitPrice:0.00}";
        }
    }
}
