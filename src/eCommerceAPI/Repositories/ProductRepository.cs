using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eCommerceAPI.Data;
using eCommerceAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace eCommerceAPI.Repositories
{
    public class ProductRepository: GenericRepository<ProductModel>, IProductRepository
    {
        public ProductRepository(ApplicationDbContext context):base(context){}

        public async Task<IEnumerable<ProductModel>> GetProductsByCategoryAsync(ICollection<CategoryModel>category)
        {
            return await _dbSet.Where(p=>p.Category == category).ToListAsync();
        }
    }
}