using DapperExample.Domain.Entities;
using DapperExample.Infrastructure.Repositories.Product;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DapperExample.Application.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public Task<Product> GetByIdAsync(int id)
        {
            return _productRepository.GetByIdAsync(id);
        }

        public Task<IEnumerable<Product>> GetAllAsync()
        {
            return _productRepository.GetAllAsync();
        }

        public Task<int> AddAsync(Product product)
        {
            product.CreatedDate = DateTime.Now;
            return _productRepository.AddAsync(product);
        }

        public Task<int> UpdateAsync(Product product)
        {
            return _productRepository.UpdateAsync(product);
        }

        public Task<int> DeleteAsync(int id)
        {
            return _productRepository.DeleteAsync(id);
        }
    }
}
