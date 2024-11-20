using InventoryReports.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryReports.Interfaces.Repository
{
    internal interface IFlightSchedules
    {
         List<Flight> GetScheduledFlights();
    }
}
