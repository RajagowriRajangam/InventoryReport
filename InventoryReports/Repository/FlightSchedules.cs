using InventoryReports.Enums;
using InventoryReports.Interfaces.Repository;
using InventoryReports.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryReports.Repository
{
    internal class FlightSchedules: IFlightSchedules
    {
        public List<Flight> GetScheduledFlights()
        {
            return new List<Flight>
            {
                new Flight { FlightNumber = 1, Departure = Airport.YUL, Arrival = Airport.YYZ, Day = 1 },
                new Flight { FlightNumber = 2, Departure = Airport.YUL, Arrival = Airport.YYC, Day = 1 },
                new Flight { FlightNumber = 3, Departure = Airport.YUL, Arrival = Airport.YVR, Day = 1 },
                new Flight { FlightNumber = 4, Departure = Airport.YUL, Arrival = Airport.YYZ, Day = 2 },
                new Flight { FlightNumber = 5, Departure = Airport.YUL, Arrival = Airport.YYC, Day = 2 },
                new Flight { FlightNumber = 6, Departure = Airport.YUL, Arrival = Airport.YVR, Day = 2 }
            };
        }

    }
}
