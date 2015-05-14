using System;
using MongoDB.Bson;

namespace REST.Model.Entity
{
    public class Visits
    {
        public Visits()
        {
            Patient = new Patient();
        }
        public ObjectId Id { get; set; }
        public ObjectId IdDoctor { get; set; }
        public DateTime Date { get; set; }
        public bool IsFree { get; set; }
        public Patient Patient { get; set; }

    }
}