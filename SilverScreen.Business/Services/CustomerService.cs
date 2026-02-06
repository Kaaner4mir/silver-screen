using SilverScreen.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using SilverScreen.DataAccess;

namespace SilverScreen.Business.Services
{
    public class CustomerService
    {
        private readonly SilverScreenContext _context;

        public CustomerService(SilverScreenContext context)
        {
            _context = context;
        }

        public async Task<List<Customer>> GetAllCustomersAsync()
        {
            return await _context.Customers.ToListAsync();
        }

        public async Task<Customer> GetCustomerByIdAsync(int id)
        {
            return await _context.Customers.FindAsync(id);
        }

        public async Task AddCustomerAsync(Customer customer)
        {
            _context.Customers.Add(customer);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateCustomerAsync(Customer customer)
        {
            var existingCustomer = await _context.Customers.FindAsync(customer.Id);
            if (existingCustomer != null)
            {
                _context.Entry(existingCustomer).CurrentValues.SetValues(customer);
                await _context.SaveChangesAsync();
            }
        }

        public async Task DeleteCustomerAsync(int id)
        {
            var customer = await _context.Customers.FindAsync(id);
            if (customer != null)
            {
                // Remove associated reservations first to avoid referential integrity errors
                var dependentReservations = _context.Reservations.Where(r => r.CustomerId == id);
                _context.Reservations.RemoveRange(dependentReservations);

                _context.Customers.Remove(customer);
                await _context.SaveChangesAsync();
            }
        }
    }
}
