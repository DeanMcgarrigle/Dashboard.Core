using System;
using System.Configuration;
using Dashboard.Core.Properties;
using Nancy;
using Nancy.Responses;
using Nancy.Security;

namespace Dashboard.Core.Nancy.Modules
{
    public class HomeModule : NancyModule   
    {
        public HomeModule()
        {
            Get["/"] = Home;
        }

        private dynamic Home(dynamic o)
        {
           
            return View["index"];
        }
    }
}
