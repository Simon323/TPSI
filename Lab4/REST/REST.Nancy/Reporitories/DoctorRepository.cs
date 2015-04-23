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

        public List<Doctors> GetDoctorsBySpecAndCity(string specialization, string city)
        {
            return StaticModel.DoctorsList.Where(x => x.Specialization == specialization && x.City == city).ToList();
        }

        public Doctors GetDoctorById(int id)
        {
            return StaticModel.DoctorsList.FirstOrDefault(x => x.id == id);
        }

        public List<Visits> GetVisitsList(bool isFree, DateTime date, int id)
        {
            return StaticModel.DoctorsList.Where(x => x.id == id).FirstOrDefault().Visits.Where(y => y.isFree == isFree && y.Date >= date).ToList();
        }

    }
}