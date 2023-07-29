using System;
using Acme_Corp.Models;
using Acme_Corp.Models.Database;
using Microsoft.EntityFrameworkCore;

namespace Acme_Corp.Services
{
    public interface ICustomerRepository
    {
        Task<Customer> GetByIdAsync(int id);
        Task AddAsync(Customer customer);
        Task UpdateAsync(Customer customer);
        Task DeleteAsync(int id);
        // Other methods as needed
    }

    
    public class CustomerRepository : ICustomerRepository
    {
        private readonly DataContext _context;

        public CustomerRepository(DataContext context)
        {
            _context = context;
        }

        public async Task<Customer> GetByIdAsync(int id)
        {
            return await _context.Customers.FindAsync(id);
        }

        public async Task AddAsync(Customer customer)
        {
            await _context.Customers.AddAsync(customer);
             _context.SaveChanges();
        }

        public async Task UpdateAsync(Customer customer)
        {
            _context.Entry(customer).State = EntityState.Modified;
             _context.SaveChanges();
        }

        public async Task DeleteAsync(int id)
        {
            var customerToDelete = await _context.Customers.FindAsync(id);
            if (customerToDelete != null)
            {
                _context.Customers.Remove(customerToDelete);
                await _context.SaveChangesAsync();
            }
        }
    }

}

