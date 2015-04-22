using Nancy;
using REST.Nancy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace REST.Nancy.Routes
{
    public class DoctorsModule :NancyModule
    {
        public DoctorsModule() : base("/doctors")
        {
            Get["/list"] = parameters =>
            {

                var xxx = StaticModel.DoctorsList.FirstOrDefault();

                //string output = XElement xml = new XElement("contacts",
                //                cc.Select(i => new XElement("contact", 
                //                    new XAttribute("type", i.Type), 
                //                    i.ContactValue
                //                )));

                return xxx.Name + " " + xxx.Surname;
            };

            Get["/delete"] = parameters =>
            {

                StaticModel.DoctorsList.RemoveAt(0);

                return "poszło";
            };
        }
    }
}