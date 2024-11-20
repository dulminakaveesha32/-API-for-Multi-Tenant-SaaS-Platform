using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eCommerceAPI.Data;
using eCommerceAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace eCommerceAPI.Repositories
{
    public class CustomerRepository : GenericRepository<UserModel>, ICustomerRepository
    {
        public CustomerRepository(ApplicationDbContext context) : base(context)
        {
        }

        public async Task<UserModel> GetCustomerByEmailAsync(string email)
        {
            return await _dbSet.SingleOrDefaultAsync(c=>c.Email == email);
        }
    }
}