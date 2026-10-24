using System.Collections.Generic;
using System.Windows.Forms;
using ShopManagementSystem.Models;

namespace ShopManagementSystem.Helpers
{
    public static class GridHelper
    {
        // Binds a list of models to a grid and puts the ID column first
        // (inherited properties would otherwise appear at the end).
        public static void Bind<T>(DataGridView grid, List<T> items) where T : Entity
        {
            grid.DataSource = items;

            if (grid.Columns.Contains(nameof(Entity.Id)))
                grid.Columns[nameof(Entity.Id)]!.DisplayIndex = 0;
            if (grid.Columns.Contains("Name"))
                grid.Columns["Name"]!.DisplayIndex = 1;
        }
    }
}
