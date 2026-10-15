using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NitePass.Application.DTOs.City;
using NitePass.Application.DTOs.Event;
using NitePass.Application.IService;

namespace NitePass.Api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CityController : ControllerBase
    {
        public readonly ICityService _service;

        public CityController(ICityService service) 
        {
            _service = service;
        }

        [HttpPost("ListarCiudades")]
        public async Task<ActionResult<IEnumerable<CityDto>>> GetAllCities(CancellationToken cancellationToken)
        {
            var data = await _service.GetAllCitiesAsync(cancellationToken);
            return Ok(data);
        }
    }
}
