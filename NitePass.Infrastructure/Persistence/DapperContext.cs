using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Data;

namespace NitePass.Infrastructure.Persistence
{
    public class DapperContext
    {
        private readonly string _connectionString;

        public DapperContext(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DefaultConnection") 
                ?? throw new InvalidOperationException("Falta la conecion 'DefaultConnection'.");
        }

        public IDbConnection CreateConnection() => new SqlConnection(_connectionString);
    }
}
