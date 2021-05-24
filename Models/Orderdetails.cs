using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportStoreMongoAsp.Models
{
    public class Orderdetails
    {
        public int Id { get; set; }
        public float Discount { get; set; }
        public float Price { get; set; }
        public int Quantity { get; set; }
        public MongoDBRef ProductId { get; set; }
       
    }
}
