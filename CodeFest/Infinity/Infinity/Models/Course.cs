using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Infinity.Models
{
    public class Course
    {
        public int CourseIdNum { get; set; }
        public string CourseName { get; set; }
        public string CourseDescription { get; set; }
        // public Mentor CourseMentor { get; set; }
        // public Quiz CourseQuiz { get; set; }

        public Course()
        {
            CourseIdNum = 0;
            CourseName = "";
            CourseDescription = "";
        }

        public Course(int courseId, string name, string description)
        {
            CourseIdNum = courseId;
            CourseName = name;
            CourseDescription = description;
        }

    }
}