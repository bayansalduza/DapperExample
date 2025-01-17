using DapperExample.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DapperExample.Application.Services
{
    public interface IProductService
    {
        Task<Product> GetByIdAsync(int id);
        Task<IEnumerable<Product>> GetAllAsync();
        Task<int> AddAsync(Product product);
        Task<int> UpdateAsync(Product product);
        Task<int> DeleteAsync(int id);
    }
}
