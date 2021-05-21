using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SportStoreMongoAsp.Models;
using SportStoreMongoAsp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportStoreMongoAsp.Controllers
{
    [ApiController]
    [Route("api/products")]
    public class ProductsController : ControllerBase
    {
        private readonly IProductRepository _productRepository;

        public ProductsController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Products>> GetAllProducts()
        {
            var productItems = _productRepository.GetAllProducts();
            return Ok(productItems);
        }

        [HttpPost]
        public ActionResult<IEnumerable<Products>> AddProduct(Products product)
        {
            var productItems = _productRepository.AddProduct(product);
            return Ok(productItems);
        }
    }
}
