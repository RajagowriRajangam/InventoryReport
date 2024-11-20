using InventoryReports.Interfaces.Repository;
using InventoryReports.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using InventoryReports.Constants;
using Microsoft.Extensions.Configuration;

namespace InventoryReports.Repository
{
    internal class OrderSchedules: IOrderSchedules
    {
        private string jsonFilePath;
        public OrderSchedules(string _jsonFilePath)
        {
            jsonFilePath = _jsonFilePath;
        }
        public Dictionary<string, Order> GetOrderSchedules()
        {
            string jsonContent = System.IO.File.ReadAllText(jsonFilePath); 
            return System.Text.Json.JsonSerializer.Deserialize<Dictionary<string, Order>>(jsonContent);
        }
    }
}
