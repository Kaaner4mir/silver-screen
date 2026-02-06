using SilverScreen.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SilverScreen.DataAccess.Services
{
    public class CustomerService
    {
        private readonly SilverScreenContext _context;

        public CustomerService(SilverScreenContext context)
        {
            _context = context;
        }

        public void Add(Customer customer)
        {
            _context.Customers.Add(customer);
            _context.SaveChanges();
        }

        public List<Customer> GetAll()
        {
            return _context.Customers.ToList();
        }

        public Customer GetById(int id)
        {
            return _context.Customers.FirstOrDefault(c => c.Id == id);
        }

        public void Update(Customer customer)
        {
            var existingCustomer = _context.Customers.FirstOrDefault(c => c.Id == customer.Id);

            if (existingCustomer != null)
            {
                existingCustomer.Name = customer.Name;
                existingCustomer.Surname = customer.Surname;
                existingCustomer.PhoneNumber = customer.PhoneNumber;
                existingCustomer.Email = customer.Email;
                _context.SaveChanges();
            }
            
        }

        public void Delete(int id)
        {
            var customer = _context.Customers.FirstOrDefault(c => c.Id == id);

            if (customer != null)
            {
                _context.Customers.Remove(customer);
                _context.SaveChanges();
            }
        }
    }
}
