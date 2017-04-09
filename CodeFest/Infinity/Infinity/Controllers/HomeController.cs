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
            var Correct = 0;
            var Ans1 = Request.Form["q1"];
            var Ans2 = Request.Form["q2"];
            var Ans3 = Request.Form["q3"];
            var Ans4 = Request.Form["q4"];
            var Ans5 = Request.Form["q5"];

            if (Ans1 != null) {
                if (Ans1.Equals("Close to 500"))
                {
                    Correct++;
                }
                if (Ans2.Equals("Business Administration and Management"))
                {
                    Correct++;
                }
                if (Ans3.Equals("23%"))
                {
                    Correct++;
                }
                if (Ans4.Equals("$37,000"))
                {
                    Correct++;
                }
                if (Ans5.Equals("1,575,000"))
                {
                    Correct++;
                }

                ViewBag.Message = "You got " + Correct + " questions right!";
            } else
            {
                ViewBag.Message = "";
            }

            return View();

            /*
            How many colleges in the United States accept more than 75 % of applicants?
    a.Fewer than 200
    b. 334
    c.Close to 500 * **
   d.More than 600

    What is the most common college major?
    a.Business Administration and Management***
   b.Nursing
    c.Accounting
    d.Computer Science

    What percentage of undergraduates work 20 or more hours a week?
    a. 10 %
    b. 23 % ***
    c. 36 %
    d. 48 %

    How much debt does the average college graduate accumulate?
    a. 17,500
    b. 25,000
    c. 37,000 * **
    d. 50,000

    775,000 male students enroll in college each year.How many female students enroll?
    a. 500,000
    b. 750,000
    c. 1,250,000
    d. 1,575,000 * **
    */
        }
        
    }
}