using Microsoft.Extensions.Options;
using MongoDB.Driver;
using SportStoreMongoAsp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportStoreMongoAsp
{
    public class DbClient : IDbClient
    {
        private readonly IMongoCollection<Customers> _customers;
        private readonly IMongoCollection<Products> _products;
        private readonly IMongoCollection<Orders> _orders;

        public DbClient(IOptions<SportStoreDbConfig> sportStoreDbConfig)
        {
            var client = new MongoClient(sportStoreDbConfig.Value.Connection_String);
            var database = client.GetDatabase(sportStoreDbConfig.Value.Database_Name);
    
            _customers = database.GetCollection<Customers>(sportStoreDbConfig.Value.CustomersCollection);
            _products = database.GetCollection<Products>(sportStoreDbConfig.Value.ProductsCollection);
            _orders = database.GetCollection<Orders>(sportStoreDbConfig.Value.OrdersCollection);
        }

        public IMongoCollection<Customers> GetCustomersCollection()
        {
            return _customers;
        }
        public IMongoCollection<Products> GetProductsCollection()
        {
            return _products;
        }
        public IMongoCollection<Orders> GetOrdersCollection()
        {
            return _orders;
        }
    }
}
