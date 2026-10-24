using ShopManagementSystem.Exceptions;

namespace ShopManagementSystem.Models
{
    // A person who can log in to the system.
    public class User : Person
    {
        private string _username = string.Empty;
        private string _password = string.Empty;
        private string _role = "Staff";

        public User()
        {
        }

        public User(string fullName, string username, string password, string role)
        {
            Name = fullName;
            Username = username;
            Password = password;
            Role = role;
        }

        public string Username
        {
            get => _username;
            set => _username = ValidationRules.Required(value, "Username");
        }

        public string Password
        {
            get => _password;
            set
            {
                string password = ValidationRules.Required(value, "Password");
                if (password.Length < 4)
                    throw new ValidationException("Password", "Password must be at least 4 characters.");
                _password = password;
            }
        }

        public string Role
        {
            get => _role;
            set => _role = ValidationRules.Required(value, "Role");
        }

        public override string GetRole()
        {
            return Role;
        }

        public override void Validate()
        {
            base.Validate();
            ValidationRules.Required(_username, "Username");
            ValidationRules.Required(_password, "Password");
        }
    }
}
