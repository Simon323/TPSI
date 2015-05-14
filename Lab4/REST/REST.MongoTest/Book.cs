using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace REST.MongoTest
{
    public class Book
    {
        //[BsonId]
        public ObjectId Id { get; set; }
        public ObjectId Klucz { get; set; }
        public string ISBN { get; set; }
        public string Title { get; set; }
        public string Publisher { get; set; }
        
    }
}
