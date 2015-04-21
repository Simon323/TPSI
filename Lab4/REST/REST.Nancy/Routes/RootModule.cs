using Nancy;
using REST.Nancy.Helpers;
using REST.Nancy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace REST.Nancy.Routes
{
    public class RootModule : NancyModule
    {
        public RootModule()
        {
            Get["/"] = parameters =>
            {
                DoctorHelper.FillDoctorList();

                var xxx = StaticModel.DoctorsList;

                return "Hello World ? działa";
            };
        }
    }
}