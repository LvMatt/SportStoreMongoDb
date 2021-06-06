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
    [Route("api/customers")]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerRepository _productRepository;

        public CustomerController(ICustomerRepository productRepository)
        {
            _productRepository = productRepository;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Customers>> GetAllCustomers()
        {
            var customers = _productRepository.GetAllCustomers();
            return Ok(customers);
        }

        [HttpGet]
        public ActionResult<IEnumerable<Customers>> GetCustomerById(string id)
        {
            Customers customer = _productRepository.GetCustomerById(id);
            return Ok(customer);
        }

        [HttpGet]
        public ActionResult<IEnumerable<Customers>> GetCustomerBySurname(string name)
        {
            Customers customer = _productRepository.GetCustomerBySurname(name);
            return Ok(customer);
        }

        [HttpPost]
        public ActionResult<IEnumerable<Customers>> AddCustomer(Customers customer)
        {
            var newCustomer = _productRepository.AddCustomer(customer);
            return Ok(newCustomer);
        }
    }
}
