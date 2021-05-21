using MongoDB.Driver;
using SportStoreMongoAsp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportStoreMongoAsp
{
    public interface IDbClient
    {
        IMongoCollection<Products> GetProductsCollection();
    }
}
