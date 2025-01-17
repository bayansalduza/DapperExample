using Microsoft.Extensions.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace DapperExample.Infrastructure
{
    public class DatabaseConnectionFactory
    {
        private readonly IConfiguration _configuration;
        private readonly string _connectionString;

        public DatabaseConnectionFactory(IConfiguration configuration)
        {
            _configuration = configuration;
            _connectionString = _configuration.GetConnectionString("DefaultConnection");
        }

        public IDbConnection CreateConnection()
        {
            return new SqlConnection(_connectionString);
        }
    }
}
