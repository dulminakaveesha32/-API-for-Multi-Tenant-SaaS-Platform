using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eCommerceAPI.Models;

namespace eCommerceAPI.Services
{
    public interface ICustomerService
    {
        Task<IEnumerable<UserModel>> GetAllCustomersAsync();
        Task<UserModel> GetCustomerByIdAsync(int id);
        Task<UserModel> GetCustomerByEmailAsync(string email);
        Task AddCustomerAsync(UserModel customer);
        Task UpdateCustomerAsync(UserModel customer);
        Task DeleteCustomerAsync(int id);
    }
}