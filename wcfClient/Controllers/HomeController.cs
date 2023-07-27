using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI;
using wcfClient.ServiceReference1;



namespace wcfClient.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            Service1Client service1Client = new Service1Client();


            List<wcfClient.ServiceReference1.Country> list =  service1Client.GetCountries().ToList();
            
             

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}