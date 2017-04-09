using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Infinity.Models;

namespace Infinity.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            
            return View();
        }

        [HttpPost]
        public ActionResult Index(LoginViewModel lvm)
        {
            var command = String.Format("SELECT UserType FROM User WHERE UserName = \"{0}\" AND Password = \"{1}\"", lvm.Email, lvm.Password);
            string result = DatabaseManager.makeScalarQuery(command).ToString();
            if(result.Equals("S", StringComparison.InvariantCultureIgnoreCase))
            {
                return RedirectToAction("Index","Student");
            }
            else if(result.Equals("M", StringComparison.InvariantCultureIgnoreCase))
            {
                return RedirectToAction("Index", "Mentor");
            }
            else
            {
                return null;
            }
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
        public ActionResult Course()
        {

            ViewBag.Message = "Applying For College";

            return View();
        }

        public ActionResult CreateCourse()
        {
            ViewBag.Message = "Create a course";

            return View();
        }

        public ActionResult CreateQuiz()
        {
            ViewBag.Message = "Create a quiz";

            return View();
        }

        public ActionResult Quiz()
        {
            ViewBag.Message = "Take a quiz";

            return View();
        }
    }
}