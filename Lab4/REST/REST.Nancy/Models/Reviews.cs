using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace REST.Nancy.Models
{
    public class Reviews
    {
        public Reviews()
        {

        }
        public int id { get; set; }
        public int idDoctor { get; set; }
        public string Description { get; set; }

    }
}