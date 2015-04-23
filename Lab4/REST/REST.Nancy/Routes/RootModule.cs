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

                //string senderName = Request.Form.name.Value.Trim();
                //string senderAddress = Request.Form.email.Value.Trim();

                var xxx = StaticModel.DoctorsList;

                return "Nancy Run !";

            };
        }
    }
}