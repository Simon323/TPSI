using Nancy;
using Nancy.Json;
using REST.Nancy.Models;
using REST.Nancy.Models.DisplayModels;
using REST.Nancy.Reporitories;
using REST.Nancy.Reporitories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Linq;

namespace REST.Nancy.Routes
{
    public class DoctorsModule :NancyModule
    {
        public DoctorsModule() : base("/doctors")
        {

            Get["/{specialization}/{city}"] = parameters =>
            {
                IDoctorRepository doctorRepository = new DoctorRepository();
                JavaScriptSerializer js = new JavaScriptSerializer();
                List<DoctorsBasic> basicDoctors = new List<DoctorsBasic>();

                var doctorsList = doctorRepository.GetDoctorsBySpecAndCity(parameters.specialization, parameters.city);

                foreach (var item in doctorsList)
                {
                    basicDoctors.Add(new DoctorsBasic
                    {
                        id = item.id,
                        Name = item.Name,
                        Surname = item.Surname,
                        City = item.City,
                        Specialization = item.Specialization
                    });
                }

                string json = js.Serialize(basicDoctors);
                var response = (Response)json;

                response.ContentType = "application/json";

                return response;

            };

            Get["/{id}"] = parameters =>
            {
                IDoctorRepository doctorRepository = new DoctorRepository();
                JavaScriptSerializer js = new JavaScriptSerializer();

                var doctor = doctorRepository.GetDoctorById(parameters.id);

                DoctorsInfo doctorInfo = new DoctorsInfo
                {
                    Name = doctor.Name,
                    Surname = doctor.Surname,
                    Reviews = doctor.Reviews
                };

                string json = js.Serialize(doctorInfo);
                var response = (Response)json;

                response.ContentType = "application/json";

                return response;

            };

        }
    }
}