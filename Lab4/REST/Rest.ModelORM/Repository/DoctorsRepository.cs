using Rest.ModelORM.EntityModel;
using Rest.ModelORM.Model;
using Rest.ModelORM.Repository.IRepository;
using REST.DBContext.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rest.ModelORM.Repository
{
    public class DoctorsRepository : BaseDbContextRepository<Doctor, RESTEntities>, IDoctorsRepository
    {
        public List<Doctor> GetDoctorsByCityAndSpecialization(string city, string specialization)
        {
            return Items.Where(x => x.City == city && x.Specialization == specialization).ToList();
        }

        public DoctorModel GetDoctorInformationById(int id)
        {
            DoctorModel doctorModel = new DoctorModel();

            var doctor = Items.Where(x => x.id == id).FirstOrDefault();

            #region Fill

            doctorModel.Name = doctor.Name;
            doctorModel.Surname = doctor.Surname;

            foreach (var element in doctor.Comments)
            {
                doctorModel.Opinion.Add(element.Description);
            }

            return doctorModel;

            #endregion
        }
    }
}
