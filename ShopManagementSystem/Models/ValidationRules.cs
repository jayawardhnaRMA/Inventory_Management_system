using ShopManagementSystem.Exceptions;

namespace ShopManagementSystem.Models
{
    // Reusable checks used by the model property setters.
    internal static class ValidationRules
    {
        public static string Required(string? value, string fieldName)
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ValidationException(fieldName, $"{fieldName} is required.");
            return value.Trim();
        }

        public static string Optional(string? value)
        {
            return value?.Trim() ?? string.Empty;
        }

        public static decimal NotNegative(decimal value, string fieldName)
        {
            if (value < 0)
                throw new ValidationException(fieldName, $"{fieldName} cannot be negative.");
            return value;
        }

        public static int NotNegative(int value, string fieldName)
        {
            if (value < 0)
                throw new ValidationException(fieldName, $"{fieldName} cannot be negative.");
            return value;
        }

        public static string Email(string? value)
        {
            string email = Optional(value);
            if (email != "" && (!email.Contains('@') || !email.Contains('.')))
                throw new ValidationException("Email", "Please enter a valid email address.");
            return email;
        }

        public static string Phone(string? value)
        {
            string phone = Optional(value);
            foreach (char c in phone)
            {
                if (!char.IsDigit(c) && c != '+' && c != '-' && c != ' ')
                    throw new ValidationException("Phone", "Phone number can only contain digits, spaces, '+' and '-'.");
            }
            return phone;
        }
    }
}
