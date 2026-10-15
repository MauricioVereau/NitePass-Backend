using NitePass.Domain.Models;

namespace NitePass.Domain.IRepository
{
    public interface ICityRepository
    {
        Task<IEnumerable<City>> GetAllCitiesAsync(CancellationToken cancellationToken = default);
    }
}
