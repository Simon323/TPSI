using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver.Builders;
using MongoDB.Driver.Linq;
using REST.Model.Entity;
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

        //public List<Doctors> GetDoctorsByCityAndSpecialization(string city, string specialization)
        //{
        //    return  ctx.Collection.AsQueryable(Query<Doctors>.)
        //}
    }
}
