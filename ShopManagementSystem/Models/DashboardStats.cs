namespace ShopManagementSystem.Models
{
    // Summary figures shown on the dashboard (read-only once loaded).
    public class DashboardStats
    {
        public int TotalProducts { get; init; }
        public int LowStockProducts { get; init; }
        public decimal StockValue { get; init; }
        public int TotalCustomers { get; init; }
        public int ActiveEmployees { get; init; }
        public int TotalEmployees { get; init; }
    }
}
