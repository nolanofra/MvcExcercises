using System.Collections.Generic;
using System.Web.Mvc;

namespace MvcApplicationFirstSample.Controllers
{
    public class HomeController : Controller
    {        
        public ActionResult Index()
        {
            ViewBag.Message = "Index";
                        
            return this.View();
        }

        public ActionResult Search()
        {
            return this.View();
        }

        public string Details()
        {
            return "Hello form Home, details action ...";
        }

        public class Test
        {
            public string message { get; set; }        
        }
    }
}
