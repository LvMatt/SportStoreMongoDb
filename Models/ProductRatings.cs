using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportStoreMongoAsp.Models
{
    public class ProductRatings
    {
        [BsonId]
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string Id { get; set; }
        public string Comment { get; set; }
        public DateTime CreatedAt { get; set; }
        public int Rating { get; set; }
        public MongoDBRef Customer { get; set; }

    }
}
