using Microsoft.EntityFrameworkCore;
using FlightService.Models;

namespace FlightService.Data
{
    public class AppDbContext: DbContext{
        public AppDbContext(DbContextOptions<AppDbContext> opt) : base(opt) {

        }

        public DbSet<Flight> Flights { get; set; }
    }
}