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
        private readonly IMongoCollection<Products> _products;
        public DbClient(IOptions<SportStoreDbConfig> sportStoreDbConfig)
        {
            var client = new MongoClient(sportStoreDbConfig.Value.Connection_String);
            var database = client.GetDatabase(sportStoreDbConfig.Value.Database_Name);
            _products = database.GetCollection<Products>(sportStoreDbConfig.Value.Collection);
        }

        public IMongoCollection<Products> GetProductsCollection()
        {
            return _products;
        }
    }
}
