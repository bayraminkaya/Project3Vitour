using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Project3Vitour.Entities
{
    public class Category
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string CategoryId { get; set; }
        public string Categoryname { get; set; }
        public bool CategoryStatus { get; set; }
    }
}
