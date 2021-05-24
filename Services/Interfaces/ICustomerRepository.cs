using SportStoreMongoAsp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportStoreMongoAsp.Services
{
    public interface ICustomerRepository
    {
        List<Customers> GetAllCustomers();
        Customers AddCustomer(Customers customer);
    }
}
