using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eCommerceAPI.Models;
using eCommerceAPI.Repositories;

namespace eCommerceAPI.Services
{
    public class CustomerService:ICustomerService
    {
        private readonly ICustomerRepository _customerRepository;
        public CustomerService(ICustomerRepository customerRepository)
        {
            _customerRepository =customerRepository;
        }

        public async Task AddCustomerAsync(UserModel customer)
        {
            await _customerRepository.AddAsync(customer);
            await _customerRepository.SaveChangesAsync();
        }

        public async Task DeleteCustomerAsync(int id)
        {
            var entity = await _customerRepository.GetByIdAsync(id);
            if(entity != null)
            {
                await _customerRepository.DeleteAsync(entity);
                await _customerRepository.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<UserModel>> GetAllCustomersAsync()
        {
            return await _customerRepository.GetAllAsync();
        }

        public async Task<UserModel> GetCustomerByEmailAsync(string email)
        {
            return await _customerRepository.GetCustomerByEmailAsync(email);
        }

        public async Task<UserModel> GetCustomerByIdAsync(int id)
        {
            return await _customerRepository.GetByIdAsync(id);
        }

        public async Task UpdateCustomerAsync(UserModel customer)
        {
            await _customerRepository.UpdateAsync(customer);
            await _customerRepository.SaveChangesAsync();
        }
    }
}