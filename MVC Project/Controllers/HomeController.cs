using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Project.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult BSIS()
        {
            ViewBag.Message = "Information about the BS Information Systems.";

            return View();
        }

        public ActionResult MISM()
        {
            ViewBag.Message = "Information about the MISM.";

            return View();
        }

        public ActionResult Faculty()
        {
            ViewBag.Message = "Information about the Faculty.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}