using Nancy;
using Nancy.Hosting.Self;
using Nancy.Testing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REST.Nancy.Routes
{
    class Test
    {
        static void Main(string[] args)
        {
            var browser = new Browser(with => with.Module(new RootModule()));

            System.Console.ReadLine();
        }


    }
}
