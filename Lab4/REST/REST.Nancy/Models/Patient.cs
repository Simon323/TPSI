using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace REST.Nancy.Models
{
    public class Patient
    {
        public Patient()
        {
            this.Name = "";
            this.Surname = "";
        }
        public string Name { get; set; }
        public string Surname { get; set; }
    }
}