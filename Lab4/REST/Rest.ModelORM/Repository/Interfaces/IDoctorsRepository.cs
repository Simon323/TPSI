using REST.ModelORM.EntityModel;
using REST.ModelORM.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REST.ModelORM.Repository.IRepository
{
    public interface IDoctorsRepository
    {
        List<Doctor> GetDoctorsByCityAndSpecialization(string city, string specialization);
        DoctorModel GetDoctorInformationById(int id);
        List<DoctorModel> GetDoctors();
    }
}
