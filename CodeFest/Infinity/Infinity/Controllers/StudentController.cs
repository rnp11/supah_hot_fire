using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Infinity.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult StudentsCourses()
        {
            ViewBag.Message = "Classes Available to Students";

            return View();
        }
        public ActionResult StudentBeforePoints()
        {
            ViewBag.Message = "Classes Available to Students";

            return View();
        }
        public ActionResult StudentAfterPoints()
        {
            ViewBag.Message = "Classes Available to Students";

            return View();
        }
    }
}