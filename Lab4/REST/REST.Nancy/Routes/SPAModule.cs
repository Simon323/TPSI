using Nancy;
using Nancy.Json;
using REST.ModelORM.Repository;
using REST.ModelORM.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace REST.Nancy.Routes
{
    public class SPAModule : NancyModule
    {
        public SPAModule() : base("/doctors")
        {
            Get["/"] = parameters =>
            {
                IDoctorsRepository doctorRepository = new DoctorsRepository();
                JavaScriptSerializer js = new JavaScriptSerializer();

                var doctorsList = doctorRepository.GetDoctors();

                string json = js.Serialize(doctorsList);

                var response = (Response)json;

                response.ContentType = "application/json";
                response.StatusCode = HttpStatusCode.OK;

                return response;
            };
        }
    }
}