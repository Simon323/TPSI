using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver.Builders;
using MongoDB.Driver.Linq;
using REST.Model.Entity;
using REST.Model.Model;
using REST.Model.Repository.IRepository;

namespace REST.Model.Repository
{
    public class DoctorsRepository : IDoctorsRepository
    {
        private DbContext<Doctors> ctx;

        public DoctorsRepository()
        {
            ctx = new DbContext<Doctors>();
        }

        public void Add(Doctors doctor)
        {
            ctx.Collection.Save(doctor);
        }

        public List<Doctors> GetDoctorsByCityAndSpecialization(string city, string specialization)
        {
            return ctx.Collection.AsQueryable().ToList().Where(x => x.City == city && x.Specialization == specialization).ToList();
        }

        public DoctorModel GetDoctorInformationById(string id)
        {
            DbContext<Reviews> reviewsRepository = new DbContext<Reviews>();
            DoctorModel doctorModel = new DoctorModel();

            var idDoctor = new ObjectId(id);
            var doctor = ctx.Collection.AsQueryable().ToList().Where(x => x.Id == idDoctor).FirstOrDefault();

            var reviewe = reviewsRepository.Collection.AsQueryable().Where(x => x.IdDoctor == idDoctor).ToList();

            #region Fill

            doctorModel.Name = doctor.Name;
            doctorModel.Surname = doctor.Surname;

            foreach (var element in reviewe)
            {
                doctorModel.Opinion.Add(element.Description);
            }

            return doctorModel;

            #endregion
        }
    }
}
