using REST.Nancy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace REST.Nancy.Models
{
    public static class StaticModel
    {
        public static List<Doctors> DoctorsList = new List<Doctors>();
        public static List<Dates> DatesList = new List<Dates>();
        public static List<Visits> VisitsList = new List<Visits>();
        public static List<Reviews> ReviewsList = new List<Reviews>();
    }
}