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
            this.Reviews = new HashSet<Reviews>();
            this.Dates = new HashSet<Dates>();
            this.Visits = new HashSet<Visits>();
        }
        public int id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string City { get; set; }

        public virtual ICollection<Reviews> Reviews { get; set; }
        public virtual ICollection<Dates> Dates { get; set; }
        public virtual ICollection<Visits> Visits { get; set; }
    }
}