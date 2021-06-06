using MongoDB.Bson;
using MongoDB.Driver;
using SportStoreMongoAsp.Models;
using SportStoreMongoAsp.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportStoreMongoAsp.Services.Repositories
{
    public class OrdersRepository : IOrderRepository
    {
        private readonly IMongoCollection<Orders> _orders;
        private readonly Products products;

        public string productId;


        public OrdersRepository(IDbClient dbClient)
        {
            _orders = dbClient.GetOrdersCollection();
        }
        public Orders AddOrder(Orders order)
        {
            _orders.InsertOne(order);
            return order;
        }

        public ICollection<Orders> GetAllOrders()
        {
            //var orders = _orders.Find(order => order.Orderdetails.ProductId == products.Id);
            //var productIdConverted = ObjectId.Parse(productId);
            //var dbRef = new MongoDBRef("Products", productIdConverted).ToString();
            //var orders = _orders.Find(order => order.Orderdetails.ProductId.Id == dbRef);
            return _orders.Find(i => i.Show == true).ToList();
        }

        public Orders GetOrderById(string id)
        {
            return (Orders)_orders.Find(i => i.Id == id);

        }
    }
}
