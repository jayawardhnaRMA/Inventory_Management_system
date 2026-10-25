using ShopManagementSystem.Helpers;
using ShopManagementSystem.Models;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace warehouse.NewFolder.Forms
{
    // Read-only profile card for the logged-in user. Built in code (no designer file).
    public class FrmProfile : Form
    {
        private static readonly Color HeaderColor = Color.FromArgb(30, 64, 175);
        private readonly User user;

        public FrmProfile(User user)
        {
            this.user = user;

            Text = "My Profile";
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            ClientSize = new Size(380, 340);
            BackColor = Color.White;
            Font = new Font("Segoe UI", 10F);

            // The Fill control must be added first so the header and footer dock around it.
            Controls.Add(BuildDetails());
            Controls.Add(BuildHeader());
            Controls.Add(BuildFooter());

            UiTheme.Apply(this);
        }

        private Panel BuildHeader()
        {
            Panel header = new Panel { Dock = DockStyle.Top, Height = 120, BackColor = HeaderColor };

            Panel avatar = new Panel { Size = new Size(64, 64), Location = new Point(24, 28), BackColor = HeaderColor };
            avatar.Paint += PaintAvatar;

            Label name = new Label
            {
                Text = user.Name,
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 14F, FontStyle.Bold),
                AutoSize = true,
                Location = new Point(104, 36)
            };
            Label role = new Label
            {
                Text = user.Role,
                ForeColor = Color.FromArgb(191, 219, 254),
                Font = new Font("Segoe UI", 10F),
                AutoSize = true,
                Location = new Point(106, 68)
            };

            header.Controls.Add(avatar);
            header.Controls.Add(name);
            header.Controls.Add(role);
            return header;
        }

        // White circle with the user's initials.
        private void PaintAvatar(object? sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            e.Graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            Rectangle circle = new Rectangle(0, 0, 63, 63);
            e.Graphics.FillEllipse(Brushes.White, circle);

            using Font font = new Font("Segoe UI", 20F, FontStyle.Bold);
            using Brush brush = new SolidBrush(HeaderColor);
            using StringFormat centre = new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center };
            e.Graphics.DrawString(GetInitials(user.Name), font, brush, circle, centre);
        }

        private static string GetInitials(string name)
        {
            string[] parts = name.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            if (parts.Length == 0)
                return "?";
            if (parts.Length == 1)
                return parts[0].Substring(0, 1).ToUpperInvariant();
            return (parts[0].Substring(0, 1) + parts[^1].Substring(0, 1)).ToUpperInvariant();
        }

        private TableLayoutPanel BuildDetails()
        {
            TableLayoutPanel table = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                ColumnCount = 2,
                Padding = new Padding(24, 16, 24, 0)
            };
            table.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 150));
            table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100));

            AddRow(table, "Username", user.Username);
            AddRow(table, "Role", user.Role);
            AddRow(table, "Member since", user.CreatedAt?.ToString("d MMMM yyyy") ?? "Unknown");
            AddRow(table, "Employee access", Session.CanManageEmployees ? "Yes" : "No (Admin or Manager only)");
            return table;
        }

        private static void AddRow(TableLayoutPanel table, string caption, string value)
        {
            table.Controls.Add(new Label
            {
                Text = caption,
                ForeColor = Color.DimGray,
                AutoSize = true,
                Margin = new Padding(0, 6, 0, 6)
            });
            table.Controls.Add(new Label
            {
                Text = value,
                Font = new Font("Segoe UI", 10F, FontStyle.Bold),
                AutoSize = true,
                Margin = new Padding(0, 6, 0, 6)
            });
        }

        private Panel BuildFooter()
        {
            // Width must be set before the right-anchored button is positioned inside it.
            Panel footer = new Panel { Dock = DockStyle.Bottom, Height = 64, Width = ClientSize.Width };
            Button close = new Button
            {
                Text = "CLOSE",
                Size = new Size(110, 36),
                Location = new Point(ClientSize.Width - 110 - 24, 12),
                Anchor = AnchorStyles.Top | AnchorStyles.Right,
                Font = new Font("Segoe UI", 10F, FontStyle.Bold)
            };
            close.Click += (sender, e) => Close();
            CancelButton = close;
            AcceptButton = close;
            footer.Controls.Add(close);
            return footer;
        }
    }
}
