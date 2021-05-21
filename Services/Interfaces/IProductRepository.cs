﻿using SportStoreMongoAsp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportStoreMongoAsp.Services
{
    public interface IProductRepository
    {
        List<Products> GetAllProducts();
        Products AddProduct(Products product);
    }
}
