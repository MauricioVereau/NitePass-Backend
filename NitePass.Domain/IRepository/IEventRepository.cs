using NitePass.Domain.Models;

namespace NitePass.Domain.IRepository
{
    public interface IEventRepository
    {
        Task<IEnumerable<EventCategory>> GetAllAsync(CancellationToken cancellationToken = default);
    }
}
