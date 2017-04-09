using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Infinity.Models
{
    public class CourseModels
    {
        public int CourseIdNum { get; set; }
        public string CourseName { get; set; }
        public string CourseDescription { get; set; }
        // public Mentor CourseMentor { get; set; }
        // public Quiz CourseQuiz { get; set; }

        public CourseModels()
        {
            CourseIdNum = 0;
            CourseName = "";
            CourseDescription = "";
        }

        public CourseModels(int courseId, string name, string description)
        {
            CourseIdNum = courseId;
            CourseName = name;
            CourseDescription = description;
        }

    }
}