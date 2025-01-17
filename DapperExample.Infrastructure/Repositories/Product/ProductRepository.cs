using System.Data;
using Dapper;
using DapperExample.Domain.Entities;

namespace DapperExample.Infrastructure.Repositories.Product
{
    public class ProductRepository : IProductRepository
    {
        private readonly IDbConnection _connection;

        public ProductRepository(IDbConnection connection)
        {
            _connection = connection;
        }

        public async Task<DapperExample.Domain.Entities.Product> GetByIdAsync(int id)
        {
            var sql = @"
                SELECT [Id], [Name], [Price], [CreatedDate]
                FROM [dbo].[Product]
                WHERE [Id] = @Id;
            ";
            var product = await _connection.QueryFirstOrDefaultAsync<DapperExample.Domain.Entities.Product>(sql, new { Id = id });
            return product;
        }

        public async Task<IEnumerable<DapperExample.Domain.Entities.Product>> GetAllAsync()
        {
            var sql = @"
                SELECT [Id], [Name], [Price], [CreatedDate]
                FROM [dbo].[Product];
            ";
            var products = await _connection.QueryAsync<DapperExample.Domain.Entities.Product>(sql);
            return products;
        }

        public async Task<int> AddAsync(DapperExample.Domain.Entities.Product product)
        {
            var sql = @"
                INSERT INTO [dbo].[Product] ([Name], [Price], [CreatedDate])
                OUTPUT INSERTED.[Id]
                VALUES (@Name, @Price, @CreatedDate);
            ";

            var newId = await _connection.ExecuteScalarAsync<int>(sql, product);
            return newId;
        }

        public async Task<int> UpdateAsync(DapperExample.Domain.Entities.Product product)
        {
            var sql = @"
                UPDATE [dbo].[Product]
                SET [Name] = @Name,
                    [Price] = @Price,
                    [CreatedDate] = @CreatedDate
                WHERE [Id] = @Id;
            ";

            var affectedRows = await _connection.ExecuteAsync(sql, product);
            return affectedRows;
        }

        public async Task<int> DeleteAsync(int id)
        {
            var sql = @"
                DELETE FROM [dbo].[Product]
                WHERE [Id] = @Id;
            ";
            var affectedRows = await _connection.ExecuteAsync(sql, new { Id = id });
            return affectedRows;
        }
    }
}
