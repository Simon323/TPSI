using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using REST.Model.Entity;
using REST.Model.Model;
using REST.Model.Repository;
using REST.Model.Repository.IRepository;

namespace REST.Client
{
    public class Helpers
    {
        public IDoctorsRepository doctorsRepositroy;
        public IReviewsRepository reviewsRepository;
        public IVisitsRepositiry visitsRepositiry;

        public Helpers()
        {
            doctorsRepositroy = new DoctorsRepository();
            reviewsRepository = new ReviewsRepository();
            visitsRepositiry = new VisitsRepositiry();
        }

        public void AddDoctor(Doctors doctor)
        {
            doctorsRepositroy.Add(doctor);
        }

        public void AddVisit(Visits visit)
        {
            visitsRepositiry.Add(visit);
        }

        public List<Doctors> GetDoctorsByCityAndSpecialization(string city, string specialization)
        {
            return doctorsRepositroy.GetDoctorsByCityAndSpecialization(city, specialization);
        }

        public DoctorModel GetDoctorInformationById(string id)
        {
            return doctorsRepositroy.GetDoctorInformationById(id);
        }

        public void AddOpinion(Reviews review)
        {
            reviewsRepository.Add(review);
        }

        public List<Visits> GetVisitsByDateAndStatus(DateTime date, bool isFree)
        {
            return visitsRepositiry.GetVisitsByDateAndStatus(date, isFree);
        }

        public void BookVisit(string id, Patient patient)
        {
            
        }

        public void CancelVisit(string idVisit)
        {
            
        }

    }
}
