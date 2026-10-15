using System.Data;
using Dapper;
using NitePass.Domain.IRepository;
using NitePass.Domain.Models;
using NitePass.Infrastructure.Persistence;

namespace NitePass.Infrastructure.Repository
{
    public class EventRepository : IEventRepository
    {
        private readonly DapperContext _context;

        public EventRepository(DapperContext context) 
        { 
            _context = context;
        }

        public async Task<IEnumerable<EventCategory>> GetAllAsync(CancellationToken cancellationToken = default)
        {
            using var connection = _context.CreateConnection();

            var command = new CommandDefinition(StoredProcedures.Events.GetAllEventCategory, commandType: CommandType.StoredProcedure, cancellationToken: cancellationToken);

            return await connection.QueryAsync<EventCategory>(command);
        }
    }
}
