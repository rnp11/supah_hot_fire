﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Infinity.Controllers
{
    public class MentorController : Controller
    {
        // GET: Mentor
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult MentorWithCourse()
        {
            return View();
        }
        public ActionResult MentorWithNoCourse()
        {
            return View();
        }
    }
}