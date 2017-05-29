using Microsoft.Azure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SimpleWebApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var s01 = CloudConfigurationManager.GetSetting("Setting01");
            var s02 = CloudConfigurationManager.GetSetting("Setting02");
            var s03 = CloudConfigurationManager.GetSetting("Setting03");
            ViewBag.Message = $"Parámetros: {s01} , {s02}, {s03} "; 
           
                
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