using System;
using System.Drawing;
using System.Windows.Forms;

namespace ShopManagementSystem.Helpers
{
    // Gives every button and grid in a form the same modern look.
    // Applied in code so the designer files stay untouched.
    public static class UiTheme
    {
        private static readonly Color HeaderBack = Color.FromArgb(30, 41, 59);
        private static readonly Color AlternateRow = Color.FromArgb(241, 245, 249);
        private static readonly Color Selection = Color.FromArgb(191, 219, 254);
        private static readonly Color Primary = Color.FromArgb(30, 64, 175);
        private static readonly Color PrimaryHover = Color.FromArgb(37, 99, 235);
        private static readonly Color Danger = Color.FromArgb(185, 28, 28);
        private static readonly Color DangerHover = Color.FromArgb(220, 38, 38);
        private static readonly Color Neutral = Color.FromArgb(71, 85, 105);
        private static readonly Color NeutralHover = Color.FromArgb(100, 116, 139);

        public static void Apply(Control root)
        {
            foreach (Control control in root.Controls)
            {
                if (control is Button button)
                    Style(button);
                else if (control is DataGridView grid)
                    Style(grid);

                if (control.HasChildren)
                    Apply(control);
            }
        }

        private static void Style(DataGridView grid)
        {
            // Columns share the full width, so there is no empty grey area.
            grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid.BackgroundColor = Color.White;
            grid.BorderStyle = BorderStyle.None;
            grid.RowHeadersVisible = false;

            // Rows are selected as a whole and edited through the form, not in the grid.
            grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grid.MultiSelect = false;
            grid.ReadOnly = true;
            grid.AllowUserToAddRows = false;
            grid.AllowUserToResizeRows = false;

            grid.EnableHeadersVisualStyles = false;
            grid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            grid.ColumnHeadersDefaultCellStyle.BackColor = HeaderBack;
            grid.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            grid.ColumnHeadersDefaultCellStyle.SelectionBackColor = HeaderBack;
            grid.ColumnHeadersHeight = 36;
            grid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;

            grid.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            grid.GridColor = Color.Gainsboro;
            grid.RowTemplate.Height = 30;
            grid.DefaultCellStyle.SelectionBackColor = Selection;
            grid.DefaultCellStyle.SelectionForeColor = Color.Black;
            grid.AlternatingRowsDefaultCellStyle.BackColor = AlternateRow;
        }

        private static void Style(Button button)
        {
            string text = button.Text.Trim().ToUpperInvariant();
            (Color normal, Color hover) = text switch
            {
                "DELETE" => (Danger, DangerHover),
                "CLEAR" => (Neutral, NeutralHover),
                _ => (Primary, PrimaryHover)
            };

            button.UseVisualStyleBackColor = false;
            button.FlatStyle = FlatStyle.Flat;
            button.FlatAppearance.BorderSize = 0;
            button.FlatAppearance.MouseOverBackColor = hover;
            button.FlatAppearance.MouseDownBackColor = normal;
            button.BackColor = normal;
            button.ForeColor = Color.White;
            button.Cursor = Cursors.Hand;
        }
    }
}
