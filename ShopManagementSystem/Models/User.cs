using System;
using System.Collections.Generic;
using System.Text;

namespace warehouse.NewFolder.Models
{
    public class User
    {
        public int UserID { get; set; }
        public string FullName { get; set; }
        public string Username { get; set; }
        public string PasswordHash { get; set; }
        public string UserRole { get; set; }
        public bool IsActive { get; set; }
    }
}
