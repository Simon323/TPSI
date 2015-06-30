using Rest.ModelORM.EntityModel;
using Rest.ModelORM.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rest.ModelORM.Repository.IRepository
{
    public interface IDoctorsRepository
    {
        List<Doctor> GetDoctorsByCityAndSpecialization(string city, string specialization);
        DoctorModel GetDoctorInformationById(int id);
    }
}
