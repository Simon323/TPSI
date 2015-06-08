using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using REST.Model.Entity;
using REST.Model.Model;

namespace REST.Model.Repository.IRepository
{
    public interface IDoctorsRepository
    {
        void Add(Doctors doctor);
        List<Doctors> GetDoctorsByCityAndSpecialization(string city, string specialization);
        DoctorModel GetDoctorInformationById(string id);
    }
}
