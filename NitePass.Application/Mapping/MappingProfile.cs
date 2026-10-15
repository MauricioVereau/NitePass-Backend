using AutoMapper;
using NitePass.Application.DTOs.City;
using NitePass.Application.DTOs.Event;
using NitePass.Domain.Models;

namespace NitePass.Application.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile() 
        {
            //Evento
            CreateMap<EventCategory, EventCategoryDto>();

            //Ciudad
            CreateMap<City, CityDto>();

        }
    }
}
