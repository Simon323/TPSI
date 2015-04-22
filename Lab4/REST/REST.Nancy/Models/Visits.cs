using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace REST.Nancy.Models
{
    public class Visits
    {
        public Visits()
        {

        }
        public int id { get; set; }
        public int idDoctor { get; set; }
        public int idDate { get; set; }
    }
}