using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eCommerceAPI.Models;

namespace eCommerceAPI.Repositories
{
    public interface IProductRepository:IGenericRepository<ProductModel>
    {
        Task<IEnumerable<ProductModel>>GetProductsByCategoryAsync(ICollection<CategoryModel>category);
    }
}