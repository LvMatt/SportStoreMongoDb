using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportStoreMongoAsp.Models
{
    public class Products
    {
        private bool show;
        [BsonId]
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string Id { get; set; }
        public string Description { get; set; }
        public string Name { get; set; }

        public bool Show { get { return show = true; }  set => show = value; }
        public string OverallRating { get; set; }
        public int Price { get; set; }
        public int Weight { get; set; }
        public string ProductCategoriesType { get; set; }
        public string ProductCategoriesDescription { get; set; }

        

    }
}
