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
    internal class OrderService: IOrderService
    {
        private IOrderSchedules orderSchedulesRepo;
        public OrderService(IOrderSchedules _orderSchedulesRepo)
        {
            orderSchedulesRepo = _orderSchedulesRepo;
        }
        public void DisplayOrderSchedules(List<Flight> flights)
        {
            foreach (var order in IsScheduledOrder(orderSchedulesRepo.GetOrderSchedules(),  flights))
            {
                if (order.Value.IsScheduled)
                {
                    var flight= flights.Where(x=>x.FlightNumber== order.Value.FlightNumber).FirstOrDefault();
                    Console.WriteLine($"order: {order.Key}, flightNumber:{order.Value.FlightNumber}, departure:{order.Value.Destination}, arrival: {flight.Arrival}, day: {flight.Day}");
                }
                else
                {
                    Console.WriteLine($"order: {order.Key}, departure:{order.Value.Destination},flightNumber: not scheduled");
                }
            }
            Console.ReadKey();
        }
        /***
         Method finds the flightNumber and day based on the destination match and 
         Capacity of flight since Each plane has a capacity of 20 boxes each.  
         ***/
        private Dictionary<string, Order> IsScheduledOrder(Dictionary<string, Order> ordersDict,List<Flight> flights)
        {
            foreach (var order in ordersDict)
            {
                var flight = flights
                    .Where(f => f.Arrival.ToString() == order.Value.Destination && f.Capacity > 0)
                    .OrderBy(f => f.Day)
                    .FirstOrDefault();

                if (flight != null)
                {
                    order.Value.IsScheduled = true;
                    order.Value.FlightNumber = flight.FlightNumber;
                    flight.Capacity--;
                }
            }
            return ordersDict;
        }

        
    }
}
