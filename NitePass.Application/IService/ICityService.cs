using NitePass.Application.DTOs.City;

namespace NitePass.Application.IService
{
    public interface ICityService
    {
        Task<IEnumerable<CityDto>> GetAllCitiesAsync(CancellationToken cancellationToken = default);
    }
}
