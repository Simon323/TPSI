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
                if (!StaticModel.isInit)
                {
                    DoctorHelper.FillDoctorsList();
                    ReviewHelper.FillReviewsList();
                    DateHelper.FillDateList();
                    StaticModel.isInit = true;
                }
                

                var xxx = StaticModel.DoctorsList;
                //var zzz = StaticModel.ReviewsList;

                return "Hello World ? działa";
            };
        }
    }
}