using Microsoft.AspNetCore.Mvc;
using SportStoreMongoAsp.Models;
using SportStoreMongoAsp.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportStoreMongoAsp.Controllers
{
    [ApiController]
    [Route("api/products")]
    public class ProductController : Controller
    {
        private readonly IProductRepository _productRepository;

        public ProductController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Products>> GetAllProducts()
        {
            var products = _productRepository.GetAllProducts();
            return Ok(products);
        }

        [HttpGet]
        [Route("{id}")]
        public ActionResult<Products> GetOrderById(string id)
        {
            Products product = _productRepository.GetProductById(id);
            return Ok(product);
        }

        [HttpPost]
        public ActionResult<IEnumerable<Products>> AddProduct(Products product)
        {
            var newProduct = _productRepository.AddProduct(product);
            return Ok(newProduct);
        }
    }
}
