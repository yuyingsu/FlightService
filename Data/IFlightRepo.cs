using FlightService.Models;

namespace FlightService.Data
{
    public interface IFlightRepo
    {
        bool SaveChanges();
        IEnumerable<Flight> GetAllFlights();
        Flight GetFlightById(int id);
        void CreateFlight(Flight flight);

    }
}