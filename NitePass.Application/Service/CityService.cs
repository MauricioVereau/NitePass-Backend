using AutoMapper;
using NitePass.Application.DTOs.City;
using NitePass.Application.IService;
using NitePass.Domain.IRepository;

namespace NitePass.Application.Service
{
    public class CityService : ICityService
    {
        public readonly ICityRepository _repository;
        public readonly IMapper _mapper;

        public CityService(ICityRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<CityDto>> GetAllCitiesAsync(CancellationToken cancellationToken = default)
        {
            var data = await _repository.GetAllCitiesAsync(cancellationToken);
            return _mapper.Map<IEnumerable<CityDto>>(data);
        }
    }
}
