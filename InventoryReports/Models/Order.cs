using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json.Serialization;

namespace InventoryReports.Models
{
    internal class Order
    {
        //Order number 
        //format used: "Order-XXX". Here XXX in the range from 001 t0 099
        public string OrderNumber { get; set; }


        //Order Destination
        [JsonPropertyName("destination")]
        public string Destination { get; set; }


        //Boolean to identify the flight is scheduled or not
        public bool IsScheduled { get; set; }


        //Flight Number Range from 1 to 6 or null - if no flights scheduled
        public int? FlightNumber { get; set; }
    }
}
