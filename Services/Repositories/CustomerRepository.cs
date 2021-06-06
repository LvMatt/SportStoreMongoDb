using MongoDB.Driver;
using SportStoreMongoAsp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportStoreMongoAsp.Services.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly IMongoCollection<Customers> _customers;
        public CustomerRepository(IDbClient dbClient)
        {
            _customers = dbClient.GetCustomersCollection();
        }

        public Customers AddCustomer(Customers customer)
        {
            _customers.InsertOne(customer);
            return customer;
        }
        public List<Customers> GetAllCustomers()
        {
            return _customers.Find(i => i.Show == true).ToList();
        }

        public Customers GetCustomerById(string id)
        {
            return (Customers)_customers.Find(i => i.Id == id);
        }

        public Customers GetCustomerBySurname(string name)
        {
            return (Customers)_customers.Find(i => i.Surname == name);
        }
    }
}
