using System;

namespace ShopManagementSystem.Exceptions
{
    // Custom exception thrown when a model is given invalid data (e.g. empty name, negative price).
    public class ValidationException : Exception
    {
        public string? PropertyName { get; }

        public ValidationException(string message) : base(message)
        {
        }

        public ValidationException(string propertyName, string message) : base(message)
        {
            PropertyName = propertyName;
        }
    }
}
