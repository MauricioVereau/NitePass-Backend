using NitePass.Application.DTOs.Event;

namespace NitePass.Application.IService
{
    public interface IEventService
    {
        Task<IEnumerable<EventCategoryDto>> GetAllAsync(CancellationToken cancellationToken = default);
    }
}
