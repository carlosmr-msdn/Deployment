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
            string[] s = new string[3];
            s[0] = CloudConfigurationManager.GetSetting("Setting01");
            s[1] = CloudConfigurationManager.GetSetting("Setting02");
            s[2] = CloudConfigurationManager.GetSetting("Setting03");
            ViewBag.Parametros = s;
            
           
                
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