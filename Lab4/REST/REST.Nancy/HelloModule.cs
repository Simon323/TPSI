//using Nancy;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Web;

//namespace REST.Nancy
//{
//    public class HelloModule : NancyModule
//    {
//        public HelloModule()
//        {
//            //Get["/"] = parameters => "Hello World";
//            Get["/"] = parameters =>
//            {
//                return "Hello World";
//            };

//            Get["/{cos}"] = paterns =>
//            {
//                return "Cos jeszcze innego " + paterns.cos;
//            };
//        }
//    }
//}