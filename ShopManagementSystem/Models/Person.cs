using System.ComponentModel;

namespace ShopManagementSystem.Models
{
    // Abstract base for people in the system (customers, employees, users).
    public abstract class Person : Entity
    {
        private string _name = string.Empty;

        [DisplayName("Name")]
        public string Name
        {
            get => _name;
            set => _name = ValidationRules.Required(value, "Name");
        }

        // Each kind of person describes its own role.
        public abstract string GetRole();

        public override void Validate()
        {
            ValidationRules.Required(_name, "Name");
        }

        public override string ToString()
        {
            return $"{Name} ({GetRole()})";
        }
    }
}
