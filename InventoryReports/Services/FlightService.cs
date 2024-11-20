using InventoryReports.Interfaces;
using InventoryReports.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InventoryReports.Interfaces.Services;
using InventoryReports.Interfaces.Repository;
using InventoryReports.Repository;

namespace InventoryReports.Services
{
    internal class FlightService : IFlightService
    {
        private IFlightSchedules flightSchedulesRepo;
        public FlightService(IFlightSchedules _flightSchedulesRepo)
        {
            flightSchedulesRepo = _flightSchedulesRepo;
        }
        public void DisplayFlightSchedules(List<Flight> flights)
        {
            foreach (var flight in flights)
            {
                Console.WriteLine($"Flight: {flight.FlightNumber}, departure: {flight.Departure}, arrival: {flight.Arrival}, day: {flight.Day}");
            }
        }
        public List<Flight> GetFlights()
        {
            return flightSchedulesRepo.GetScheduledFlights();
        }
    }
}
