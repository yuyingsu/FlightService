using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using FlightService.Models;

namespace FlightService.Data
{
    public static class PrepDb
    {
        public static void PrepPopulation(IApplicationBuilder app)
        {
            using ( var serviceScope = app.ApplicationServices.CreateScope()) 
            {
                SeedData(serviceScope.ServiceProvider.GetService<AppDbContext>());
            }
        }

        private static void SeedData(AppDbContext context)
        {
            if(!context.Flights.Any())
            {
                Console.WriteLine("---> Sending data.");

                context.Flights.AddRange(
                    new Flight() {
                        From = "Madison, WI",
                        To = "New York, NY",
                        Time = new DateTime(2022,12,30,10,0,0),
                        Capacity = 40 
                    }
                );

                context.SaveChanges();
            }
            else
            {
                Console.WriteLine("---> We already had data.");
            }
        }
    }
}