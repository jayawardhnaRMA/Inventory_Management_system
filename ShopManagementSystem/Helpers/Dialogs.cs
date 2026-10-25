using System.Windows.Forms;

namespace ShopManagementSystem.Helpers
{
    // Consistent message boxes: every message has a title and a matching icon.
    public static class Dialogs
    {
        public static void Success(string message)
        {
            MessageBox.Show(message, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void Warning(string message, string title)
        {
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        // "No" is the default button so pressing Enter never deletes by accident.
        public static bool ConfirmDelete(string item)
        {
            DialogResult result = MessageBox.Show(
                $"Are you sure you want to delete {item}?\n\nThis cannot be undone.",
                "Confirm delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning,
                MessageBoxDefaultButton.Button2);
            return result == DialogResult.Yes;
        }
    }
}
