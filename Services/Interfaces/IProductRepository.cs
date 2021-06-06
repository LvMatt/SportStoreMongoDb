using SportStoreMongoAsp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportStoreMongoAsp.Services.Interfaces
{
    public interface IProductRepository
    {
        List<Products> GetAllProducts();
        Products GetProductById(string id);
        Products AddProduct(Products product);
    }
}
