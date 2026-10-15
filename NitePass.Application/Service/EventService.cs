using AutoMapper;
using NitePass.Application.DTOs.Event;
using NitePass.Application.IService;
using NitePass.Domain.IRepository;

namespace NitePass.Application.Service
{
    public class EventService : IEventService
    {
        private readonly IEventRepository _repository;
        private readonly IMapper _mapper;

        public EventService(IEventRepository repository, IMapper mapper) 
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<EventCategoryDto>> GetAllAsync(CancellationToken cancellationToken = default)
        {
            var data = await _repository.GetAllAsync(cancellationToken);
            return _mapper.Map<IEnumerable<EventCategoryDto>>(data);
        }
    }
}
