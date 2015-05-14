using MongoDB.Bson;

namespace REST.Model.Entity
{
    public class Doctors
    {
        public ObjectId Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string City { get; set; }
        public string Specialization { get; set; }
    }
}