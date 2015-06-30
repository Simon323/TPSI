using Nancy;
using Nancy.Json;
using REST.Nancy.Helpers;
using REST.Nancy.Models;
using REST.Nancy.Models.DisplayModels;
using REST.Nancy.Reporitories;
using REST.Nancy.Reporitories.Interfaces;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Web;
using System.Xml.Linq;
using Nancy.ModelBinding;

namespace REST.Nancy.Routes
{
    public class DoctorsModule :NancyModule
    {
        public DoctorsModule() : base("/doctors")
        {

            //Get["/"] = parameters =>
            //{
            //    Rest.ModelORM.Repository.IRepository.IDoctorsRepository doctorsRepository = new Rest.ModelORM.Repository.DoctorsRepository();
            //    var doctorsList = doctorsRepository.GetAll().ToList();
            //    JavaScriptSerializer js = new JavaScriptSerializer();

            //    string json = js.Serialize(doctorsList);
            //    var response = (Response)json;

            //    response.ContentType = "application/json";
            //    response.StatusCode = HttpStatusCode.OK;

            //    return response;
            //};

            Get["/specialization/{specialization}/{city}"] = parameters =>
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
                response.StatusCode = HttpStatusCode.OK;

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
                response.StatusCode = HttpStatusCode.OK;

                return response;

            };

            Post["/{id}/opinion"] = parameters =>
            {
                var bind = this.Bind<Patient>();

                string content = "";
                IReviewRepository reviewRepository = new ReviewRepository();

                using (StreamReader reader = new StreamReader(Request.Body))
                {
                    content = reader.ReadToEnd();
                }

                int id = ReviewHelper.GetNewReviewId();

                Reviews reviews = new Reviews
                {
                    id = id,
                    idDoctor = parameters.id,
                    Description = content
                };

                reviewRepository.Add(reviews);

                return Negotiate.WithStatusCode(HttpStatusCode.Created);
            };

            Get["/{id}/visit"] = parameters =>
            {
                IDoctorRepository doctorRepository = new DoctorRepository();
                JavaScriptSerializer js = new JavaScriptSerializer();
                var statusQuery = Request.Query["status"];
                var dateQuesy = Request.Query["date"];

                bool status = true;
                DateTime date;

                if (statusQuery.Value != null)
                    status = Boolean.Parse(statusQuery.Value);

                if (dateQuesy.Value != null)
                    date = DateTime.ParseExact(dateQuesy.Value, "yyyyMMdd", CultureInfo.InvariantCulture);
                else
                    date = DateTime.Now;

                List<Visits> visitsList = doctorRepository.GetVisitsList(status, date, parameters.id);

                string json = js.Serialize(visitsList);

                //return Negotiate.WithStatusCode(HttpStatusCode.OK).WithModel(json).WithContentType("application/json");

                var response = (Response)json;

                response.ContentType = "application/json";
                response.StatusCode = HttpStatusCode.OK;

                return response;

            };

            Post["/{id}/visit/book/{date}/{name}/{surname}"] = parameters =>
            {
                IDoctorRepository doctorRepository = new DoctorRepository();

                DateTime date = DateTime.ParseExact(parameters.date, "yyyyMMdd", CultureInfo.InvariantCulture);


                bool isBook = doctorRepository.BookVisit(parameters.id, date, parameters.name, parameters.surname);

                if(isBook)
                    return Negotiate.WithStatusCode(HttpStatusCode.Created);
                else
                    return Negotiate.WithStatusCode(HttpStatusCode.BadRequest);

            };

            Delete["/{id}/visit/cancel/{date}"] = parameters =>
            {
                IDoctorRepository doctorRepository = new DoctorRepository();

                DateTime date = DateTime.ParseExact(parameters.date, "yyyyMMdd", CultureInfo.InvariantCulture);

                bool isCancel = doctorRepository.CancelVisit(parameters.id, date);

                if (isCancel)
                    return Negotiate.WithStatusCode(HttpStatusCode.OK);
                else
                    return Negotiate.WithStatusCode(HttpStatusCode.BadRequest);
            };

        }
    }
}