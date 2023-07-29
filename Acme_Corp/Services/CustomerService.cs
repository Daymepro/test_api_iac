using System;
using Acme_Corp.Models;

namespace Acme_Corp.Services
{
    // CustomerService.cs
    public class CustomerService
    {
        private readonly ICustomerRepository _customerRepository;

        public CustomerService(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public async Task<Customer> GetCustomerById(int customerId)
        {
            return await _customerRepository.GetByIdAsync(customerId);
        }

        
    }

}

