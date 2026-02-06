using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SilverScreen.Entities.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; } // In a real app, this should be hashed
        public string FullName { get; set; }
        public string Role { get; set; } // e.g., Admin, Cashier
    }
}
