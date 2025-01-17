namespace DapperExample.Infrastructure.Repositories.Product
{
    public interface IProductRepository
    {
        Task<DapperExample.Domain.Entities.Product> GetByIdAsync(int id);
        Task<IEnumerable<DapperExample.Domain.Entities.Product>> GetAllAsync();
        Task<int> AddAsync(DapperExample.Domain.Entities.Product product);
        Task<int> UpdateAsync(DapperExample.Domain.Entities.Product product);
        Task<int> DeleteAsync(int id);
    }
}
