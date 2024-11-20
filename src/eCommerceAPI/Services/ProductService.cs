using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eCommerceAPI.Models;
using eCommerceAPI.Repositories;

namespace eCommerceAPI.Services
{
    public class ProductService:IProductService
    {
        private readonly IProductRepository _productRepository;
        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task AddProductAsync(ProductModel product)
        {
            await _productRepository.AddAsync(product);
            await _productRepository.SaveChangesAsync();
        }

        public async Task DeleteProductAsync(int id)
        {
            var entity = await _productRepository.GetByIdAsync(id);
            if(entity != null)
            {
                await _productRepository.DeleteAsync(entity);
                await _productRepository.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<ProductModel>> GetAllProductsAsync()
        {
            return await _productRepository.GetAllAsync();
        }

        public async Task<ProductModel> GetProductByIdAsync(int id)
        {
            var entity = await _productRepository.GetByIdAsync(id);

            return (ProductModel)await _productRepository.GetProductsByCategoryAsync(entity.Category);
        }



        public async Task UpdateProductAsync(ProductModel product)
        {
            await _productRepository.UpdateAsync(product);
            await _productRepository.SaveChangesAsync();        }
    }
}