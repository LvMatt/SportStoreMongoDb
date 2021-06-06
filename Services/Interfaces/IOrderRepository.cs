using MongoDB.Driver;
using SportStoreMongoAsp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportStoreMongoAsp.Services.Interfaces
{
    public interface IOrderRepository
    {
        ICollection<Orders> GetAllOrders();
        Orders GetOrderById(string id);
        Orders AddOrder(Orders order);

    }
}
