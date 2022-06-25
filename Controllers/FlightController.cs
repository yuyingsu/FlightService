using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using FlightService.Data;
using FlightService.Dtos;
using FlightService.Models;

namespace FlightService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FlightController : ControllerBase
    {
        private readonly IFlightRepo _repository;
        private readonly IMapper _mapper;
        public FlightController(IFlightRepo repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult<IEnumerable<FlightReadDto>> GetFlights()
        {
            Console.WriteLine("--> Getting Flights...");

            var flightItem = _repository.GetAllFlights();

            return Ok(_mapper.Map<IEnumerable<FlightReadDto>>(flightItem));
        }

        [HttpGet("{id}", Name="GetFlightById")]
        public ActionResult<FlightReadDto> GetFlightById(int id)
        {
            var flightItem = _repository.GetFlightById(id);
            if(flightItem!=null){
                return Ok(_mapper.Map<FlightReadDto>(flightItem));
            }
            return NotFound();
        }

        [HttpPost]
        public ActionResult<FlightReadDto> CreateFlight(FlightCreateDto flightCreateDto)
        {
            var flightModel = _mapper.Map<Flight>(flightCreateDto);
            _repository.CreateFlight(flightModel);
            _repository.SaveChanges();

            var flightReadDto = _mapper.Map<FlightReadDto>(flightModel);

            return CreatedAtRoute(nameof(GetFlightById), new { Id = flightReadDto.Id }, flightReadDto);
        }
    }
}