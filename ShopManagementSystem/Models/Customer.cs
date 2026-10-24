namespace ShopManagementSystem.Models
{
    public class Customer : Person, IContactable
    {
        private string _phone = string.Empty;
        private string _email = string.Empty;
        private string _address = string.Empty;

        public Customer()
        {
        }

        public Customer(string name, string phone, string email, string address)
        {
            Name = name;
            Phone = phone;
            Email = email;
            Address = address;
        }

        public string Phone
        {
            get => _phone;
            set => _phone = ValidationRules.Phone(value);
        }

        public string Email
        {
            get => _email;
            set => _email = ValidationRules.Email(value);
        }

        public string Address
        {
            get => _address;
            set => _address = ValidationRules.Optional(value);
        }

        public override string GetRole()
        {
            return "Customer";
        }
    }
}
