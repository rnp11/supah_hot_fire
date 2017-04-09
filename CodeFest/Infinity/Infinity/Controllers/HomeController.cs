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

            ViewBag.Header = "Applying For College";
            ViewBag.Video = "https://www.youtube.com/embed/jPrEKz1rAno";
            ViewBag.Transcripts = "";

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
            var YourRadioButton = Request.Form["Gender"];
            ViewBag.Message = YourRadioButton;

            return View();
        }
        
    }
}