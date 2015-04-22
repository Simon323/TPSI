using REST.Nancy.Models;
using REST.Nancy.Reporitories;
using REST.Nancy.Reporitories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace REST.Nancy.Helpers
{
    public class DoctorHelper
    {
        public static void FillDoctorsList()
        {
            IDoctorRepository doctorRepository = new DoctorRepository();

            Doctors doctor = new Doctors
            {
                id = 1,
                Name = "Harrison",
                Surname = "Wells",
                City = "Central City"

            };

            doctorRepository.Add(doctor);
        }
    }
}