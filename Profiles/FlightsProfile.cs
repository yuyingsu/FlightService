using AutoMapper;
using FlightService.Models;
using FlightService.Dtos;

namespace FlightService.Profiles
{
    public class FlightsProfile : Profile
    {
        public FlightsProfile()
        {
            CreateMap<Flight, FlightReadDto>()
            .ForMember(d => d.Time, expression => expression.MapFrom(s=>s.Time.ToString("g")));

            CreateMap<FlightCreateDto, Flight>()
            .ForMember(d => d.Time,expression => expression.MapFrom(s=>DateTime.Parse(s.Time)));
        }
    }
}