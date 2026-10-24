using System;
using System.ComponentModel;
using ShopManagementSystem.Exceptions;

namespace ShopManagementSystem.Models
{
    public class Employee : Person, IContactable
    {
        private string _gender = string.Empty;
        private string _phone = string.Empty;
        private string _email = string.Empty;
        private string _jobTitle = string.Empty;
        private decimal _salary;
        private DateTime _hireDate = DateTime.Today;

        public Employee()
        {
        }

        public Employee(string name, string gender, string phone, string email,
                        string jobTitle, decimal salary, DateTime hireDate, bool isActive = true)
        {
            Name = name;
            Gender = gender;
            Phone = phone;
            Email = email;
            JobTitle = jobTitle;
            Salary = salary;
            HireDate = hireDate;
            IsActive = isActive;
        }

        public string Gender
        {
            get => _gender;
            set => _gender = ValidationRules.Optional(value);
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

        [DisplayName("Job Title")]
        public string JobTitle
        {
            get => _jobTitle;
            set => _jobTitle = ValidationRules.Optional(value);
        }

        public decimal Salary
        {
            get => _salary;
            set => _salary = ValidationRules.NotNegative(value, "Salary");
        }

        [DisplayName("Hire Date")]
        public DateTime HireDate
        {
            get => _hireDate;
            set
            {
                if (value.Date > DateTime.Today)
                    throw new ValidationException("HireDate", "Hire date cannot be in the future.");
                _hireDate = value.Date;
            }
        }

        [DisplayName("Active")]
        public bool IsActive { get; set; } = true;

        public override string GetRole()
        {
            return string.IsNullOrEmpty(JobTitle) ? "Employee" : JobTitle;
        }
    }
}
