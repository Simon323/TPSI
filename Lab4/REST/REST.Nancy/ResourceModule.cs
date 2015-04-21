using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Nancy;

namespace REST.Nancy
{
    public class ResourceModule : NancyModule
    {
        public ResourceModule()
            : base("/products")
        {
            // would capture routes to /products/list sent as a GET request
            Get["/list"] = parameters =>
            {
                int liczba = DataModel.a += 10;

                string napis = liczba.ToString();
                return napis;
            };
        }
    }
}