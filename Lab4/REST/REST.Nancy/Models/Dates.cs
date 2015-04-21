using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace REST.Nancy.Models
{
    public class Dates
    {
        public Dates()
        {
            this.Visits = new HashSet<Visits>();
        }
        public int id { get; set; }
        public int idDoctor { get; set; }
        public DateTime Date { get; set; }

        public virtual Doctors Doctors { get; set; }
        public virtual ICollection<Visits> Visits { get; set; }
    }
}