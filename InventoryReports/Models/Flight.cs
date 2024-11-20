using InventoryReports.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryReports.Models
{
    internal class Flight
    {
        //Flight Number
        public int FlightNumber { get; set; }
        //Departure airport 
        public Airport Departure { get; set; }
        //Arrival airport 
        public Airport Arrival { get; set; }
        // Travel day
        public int Day { get; set; }
        //Available flight capacity to load the box. Default capacity -20
        public int Capacity { get; set; } = 20; 
    }
}
