using System;
using System.Drawing;
using System.Windows.Forms;

namespace ShopManagementSystem.Helpers
{
    // Gives every button in a form the same modern, flat look.
    // Applied in code so the designer files stay untouched.
    public static class UiTheme
    {
        private static readonly Color Primary = Color.FromArgb(30, 64, 175);
        private static readonly Color PrimaryHover = Color.FromArgb(37, 99, 235);
        private static readonly Color Danger = Color.FromArgb(185, 28, 28);
        private static readonly Color DangerHover = Color.FromArgb(220, 38, 38);
        private static readonly Color Neutral = Color.FromArgb(71, 85, 105);
        private static readonly Color NeutralHover = Color.FromArgb(100, 116, 139);

        public static void StyleButtons(Control root)
        {
            foreach (Control control in root.Controls)
            {
                if (control is Button button)
                    Style(button);
                if (control.HasChildren)
                    StyleButtons(control);
            }
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
