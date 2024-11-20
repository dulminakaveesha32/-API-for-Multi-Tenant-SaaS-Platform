using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eCommerceAPI.Models;

namespace eCommerceAPI.Repositories
{
    public interface ICustomerRepository:IGenericRepository<UserModel>
    {
        Task<UserModel> GetCustomerByEmailAsync(string email); 
    }
}