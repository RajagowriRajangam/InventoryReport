using InventoryReports.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InventoryReports.Interfaces.Services;
using System.Configuration;
using Microsoft.Extensions.DependencyInjection;
using InventoryReports.Interfaces.Repository;
using InventoryReports.Repository;
using InventoryReports.Constants;
namespace InventoryReports
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string jsonFilePath = ConfigurationManager.AppSettings[Constants.Constants.jsonFilePath];
            

            
            var serviceProvider = new ServiceCollection()
                .AddSingleton<IFlightService, FlightService>() 
                .AddSingleton<IOrderService, OrderService>()
                .AddSingleton<IFlightSchedules, FlightSchedules>()
                .AddSingleton<IOrderSchedules>(new OrderSchedules(jsonFilePath))
                .BuildServiceProvider();

            var flightService = serviceProvider.GetService<IFlightService>();
            var flightList = flightService.GetFlights();
            flightService.DisplayFlightSchedules(flightList);

            var orderService = serviceProvider.GetService<IOrderService>();
            orderService.DisplayOrderSchedules(flightList);

        }
    }
}
