using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using REST.Nancy.Reporitories.Interfaces;
using REST.Nancy.Models;

namespace REST.Nancy.Reporitories
{
    public class DoctorRepository : IDoctorRepository
    {
        public void Add(Doctors item)
        {
            StaticModel.DoctorsList.Add(item);
        }
    }
}