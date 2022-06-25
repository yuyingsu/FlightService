using FlightService.Models;

namespace FlightService.Data
{
    public class FlightRepo : IFlightRepo
    {
        private readonly AppDbContext _context;
        public FlightRepo(AppDbContext context)
        {
            _context = context;

        }
        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }
        public IEnumerable<Flight> GetAllFlights()
        {
            return _context.Flights.ToList();
        }
        public Flight GetFlightById(int id)
        {
            return _context.Flights.FirstOrDefault( p => p.Id == id );
        }
        public void CreateFlight(Flight flight)
        {
            if(flight==null){
                throw new ArgumentNullException(nameof(flight));
            }     
            _context.Flights.Add(flight);
        }
    }
}