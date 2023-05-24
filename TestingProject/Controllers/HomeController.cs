using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TestingProject.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private static string ApiKey = "AIzaSyDhAAx7lxhP7fLRaVouLJSsxvMOzu8Ai1U";
        
   
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
           

            return View();
        }

        public ActionResult Contact()
        {
         

            return View();
        }

    }
}