using MongoDB.Driver;
using SportStoreMongoAsp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportStoreMongoAsp.Services.Repositories
{
    public class SqlProductRepository : IProductRepository
    {
        private readonly IMongoCollection<Products> _products;
        public SqlProductRepository(IDbClient dbClient)
        {
            _products = dbClient.GetProductsCollection();
        }
        public Products AddProduct(Products product)
        {
            _products.InsertOne(product);
            return product;
        }
        public List<Products> GetAllProducts()
        {
            return _products.Find(i => i.Show == true).ToList();
        }
    }
}
