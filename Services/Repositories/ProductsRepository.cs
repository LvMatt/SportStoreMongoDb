using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Driver;
using SportStoreMongoAsp.Models;
using SportStoreMongoAsp.Services.Interfaces;

namespace SportStoreMongoAsp.Services.Repositories
{
    public class ProductsRepository : IProductRepository
    {
        private readonly IMongoCollection<Products> _products;
        public ProductsRepository(IDbClient dbClient)
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

        public Products GetProductById(string id)
        {
            return (Products)_products.Find(i => i.Id == id);
        }
    }
}
