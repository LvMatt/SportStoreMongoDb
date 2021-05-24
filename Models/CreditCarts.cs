using MongoDB.Driver;
using System;

namespace SportStoreMongoAsp.Models
{
    public class CreditCarts
    {
        public int Id { get; set; }
        public DateTime Expiration { get; set; }
        public string Extradetails { get; set; }
        public string Validation { get; set; }
        public MongoDBRef Customer { get; set; }
    }
}