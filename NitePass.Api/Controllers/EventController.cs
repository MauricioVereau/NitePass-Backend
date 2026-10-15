using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NitePass.Application.DTOs.Event;
using NitePass.Application.IService;

namespace NitePass.Api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class EventController : ControllerBase
    {
        private readonly IEventService _service;

        public EventController(IEventService service)
        {
            _service = service;
        }

        [HttpPost("ListarCategorias")]
        public async Task<ActionResult<IEnumerable<EventCategoryDto>>> GetAll(CancellationToken cancellationToken) 
        { 
            var categories = await _service.GetAllAsync(cancellationToken);
            return Ok(categories);
        }
    }
}
