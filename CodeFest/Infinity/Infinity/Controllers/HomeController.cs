﻿using System;
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
        public ActionResult Course()
        {
            ViewBag.Message = "Take the course";

            return View();
        }

        public ActionResult CreateCourse()
        {
            ViewBag.Message = "Create a course";

            return View("~/Views/Student/StudentsCourses.cshtml");
        }

        public ActionResult CreateQuiz()
        {
            ViewBag.Message = "Create a quiz";

            return View("~/Views/Student/StudentBeforeCourses.cshtml");
        }

        public ActionResult Quiz()
        {
            ViewBag.Message = "Take a quiz";

            return View("~/Views/Student/StudentBeforeCourses.cshtml");
        }
    }
}