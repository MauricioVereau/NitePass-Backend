using Dapper;
using NitePass.Domain.IRepository;
using NitePass.Domain.Models;
using NitePass.Infrastructure.Persistence;
using System.Data;

namespace NitePass.Infrastructure.Repository
{
    public class CityRepository : ICityRepository
    {
        private readonly DapperContext _context;

        public CityRepository(DapperContext context) 
        {
            _context = context;
        }

        public async Task<IEnumerable<City>> GetAllCitiesAsync(CancellationToken cancellationToken = default)
        {
            using var connection = _context.CreateConnection();

            var command = new CommandDefinition(StoredProcedures.City.GetAllCities, commandType: CommandType.StoredProcedure, cancellationToken: cancellationToken);

            return await connection.QueryAsync<City>(command);
        }
    }
}
