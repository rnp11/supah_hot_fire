using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Infinity.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page";

            return View();
        }
        public ActionResult Login()
        {
            ViewBag.Message = "Your Login page";

            return View();
        }

        public ActionResult StudentsCourses()
        {
            ViewBag.Message = "Classes Available to Students";

            return View("~/Views/Student/StudentsCourses.cshtml");
        }

        public ActionResult StudentBeforePoints()
        {
            ViewBag.Message = "Classes Available to Students";

            return View("~/Views/Student/StudentBeforeCourses.cshtml");
        }
    }
}