using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace REST.Nancy.Models
{
    public class Doctors
    {
        public Doctors()
        {
            this.Reviews = new List<Reviews>();
            this.Visits = new List<Visits>();
        }

        public int id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string City { get; set; }
        public string Specialization { get; set; }

        public List<Reviews> Reviews { get; set; }
        public List<Visits> Visits { get; set; }
    }
}