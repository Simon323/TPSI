using REST.Nancy.Models;
using REST.Nancy.Reporitories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace REST.Nancy.Routes
{
    public class DateRepository : IDateRepository
    {
        public void Add(Dates item)
        {
            StaticModel.DoctorsList.Where(x => x.id == item.idDoctor).FirstOrDefault().Dates.Add(item);
        }
    }
}