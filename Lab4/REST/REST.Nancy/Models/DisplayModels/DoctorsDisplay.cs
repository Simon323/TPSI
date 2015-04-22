using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace REST.Nancy.Models.DisplayModels
{
    public class DoctorsBasic
    {
        public int id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string City { get; set; }
        public string Specialization { get; set; }
    }

    public class DoctorsInfo
    {
        public DoctorsInfo()
        {
            this.Reviews = new List<Reviews>();
        }
        public string Name { get; set; }
        public string Surname { get; set; }
        public List<Reviews> Reviews { get; set; }
    }
}