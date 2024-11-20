using InventoryReports.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InventoryReports.Repository;

namespace InventoryReports.Interfaces.Repository
{
    internal interface IOrderSchedules
    {
        Dictionary<string, Order> GetOrderSchedules();
    }
}
