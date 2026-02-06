using SilverScreen.Entities.Models;
using SilverScreen.DataAccess;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SilverScreen.Business.Services
{
    public class AuthService
    {
        private readonly SilverScreenContext _context;
        public static User CurrentUser { get; private set; }

        public AuthService(SilverScreenContext context)
        {
            _context = context;
        }

        public async Task<bool> LoginAsync(string username, string password)
        {
            var user = await _context.Users.FirstOrDefaultAsync(u => u.Username == username && u.Password == password);
            if (user != null)
            {
                CurrentUser = user;
                return true;
            }
            return false;
        }

        public void Logout()
        {
            CurrentUser = null;
        }

        public bool IsAdmin()
        {
            return CurrentUser?.Role == "Admin";
        }
    }
}
