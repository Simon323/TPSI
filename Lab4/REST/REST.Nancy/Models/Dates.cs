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
            this.Patient = new Patient();
        }
        public int id { get; set; }
        public int idDoctor { get; set; }
        public DateTime Date { get; set; }
        public bool isFree { get; set; }
        public Patient Patient { get; set; }

    }
}