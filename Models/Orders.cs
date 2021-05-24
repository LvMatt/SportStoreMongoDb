using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportStoreMongoAsp.Models
{
    public class Orders
    {
        private bool show;
        [BsonId]
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string Id { get; set; }
        public float Amount { get; set; }
        public bool Show { get { return show = true; } set => show = value; }
        public Orderdetails Orderdetails { get; set; }
        public Payments Payments { get; set; }
    }
}
