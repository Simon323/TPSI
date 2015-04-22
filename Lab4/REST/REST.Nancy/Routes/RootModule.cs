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
                DoctorHelper.FillDoctorsList();
                ReviewHelper.FillReviewsList();

                var xxx = StaticModel.DoctorsList;
                var zzz = StaticModel.ReviewsList;

                return "Hello World ? działa";
            };
        }
    }
}