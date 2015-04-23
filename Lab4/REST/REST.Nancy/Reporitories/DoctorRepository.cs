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

        public bool BookVisit(int id, DateTime date, string name, string surname)
        {
            bool isBook = false;

            Visits visit = StaticModel.DoctorsList.FirstOrDefault(x => x.id == id).Visits.FirstOrDefault(y => y.Date == date && y.isFree == true);

            if (visit != null)
            {
                visit.Patient.Name = name;
                visit.Patient.Surname = surname;
                visit.isFree = false;
                isBook = true;
            }

            return isBook;
        }

        public bool CancelVisit(int id, DateTime date)
        {
            bool isCancel = false;

            Visits visit = StaticModel.DoctorsList.FirstOrDefault(x => x.id == id).Visits.FirstOrDefault(y => y.Date == date && y.isFree == false);

            if (visit != null)
            {
                visit.Patient.Name = "";
                visit.Patient.Surname = "";
                visit.isFree = true;
                isCancel = true;

            }

            return isCancel;
        }
    }
}