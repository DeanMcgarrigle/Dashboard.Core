using Nancy;
using Nancy.Security;

namespace Dashboard.Core.Nancy.Modules
{
    public class HomeModule : NancyModule   
    {
        public HomeModule()
        {            
            Get["/"] = Home;
            Get["/(.*)"] = Home;
        }

        private dynamic Home(dynamic o)
        {
            return View["index"];
        }
    }
}
