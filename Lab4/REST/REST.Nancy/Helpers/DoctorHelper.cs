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

            doctorRepository.Add(new Doctors
            {
                id = 1,
                Name = "Harrison",
                Surname = "Wells",
                City = "Poznan",
                Specialization = "Dentysta"

            });

            doctorRepository.Add(new Doctors
            {
                id = 2,
                Name = "Oliver",
                Surname = "Queen",
                City = "Warszawa",
                Specialization = "Chirurg"

            });

            doctorRepository.Add(new Doctors
            {
                id = 3,
                Name = "Barry",
                Surname = "Allen",
                City = "Poznan",
                Specialization = "Chirurg"

            });

            doctorRepository.Add(new Doctors
            {
                id = 4,
                Name = "Adam",
                Surname = "Monroe",
                City = "Krakow",
                Specialization = "Okulista"

            });

            doctorRepository.Add(new Doctors
            {
                id = 5,
                Name = "Caitlin",
                Surname = "Snow",
                City = "Poznan",
                Specialization = "Dentysta"

            });
        }
    }
}