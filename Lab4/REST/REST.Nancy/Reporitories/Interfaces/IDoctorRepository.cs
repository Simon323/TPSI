using REST.Nancy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace REST.Nancy.Reporitories.Interfaces
{
    public interface IDoctorRepository
    {
        void Add(Doctors item);
        List<Doctors> GetDoctorsBySpecAndCity(string specialization, string city);
        Doctors GetDoctorById(int id);
    }
}