using MongoDB.Bson;

namespace REST.Model.Entity
{
    public class Reviews
    {
        public ObjectId Id { get; set; }
        public ObjectId IdDoctor { get; set; }
        public string Description { get; set; }

    }
}