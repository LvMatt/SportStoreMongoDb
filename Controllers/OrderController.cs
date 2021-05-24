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
    [Route("api/orders")]
    public class OrderController : Controller
    {
        private readonly IOrderRepository _orderRepository;

        public OrderController(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Orders>> GetAllOrders()
        {
            var products = _orderRepository.GetAllOrders();
            return Ok(products);
        }
         
        [HttpPost]
        public ActionResult<IEnumerable<Orders>> AddProduct(Orders order)
        {
            var newProduct = _orderRepository.AddOrder(order);
            return Ok(newProduct);
        }

    }
}
