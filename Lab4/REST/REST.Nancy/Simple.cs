using Nancy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace REST.Nancy
{
    public class Simple : NancyModule
    {
        public Simple()
        {
            Get["/test"] = parameters =>
            {
                string napis = DataModel.a.ToString();
                return napis;
            };
        }
    }
}