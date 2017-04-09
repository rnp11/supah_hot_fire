using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Infinity.Models
{
    public class CourseModels
    {
        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public string URL { get; set; }
        public int QuizId { get; set; }
        public string Teacher { get;  set; }
        // public Mentor CourseMentor { get; set; }
        // public Quiz CourseQuiz { get; set; }

        public CourseModels(int courseId, string courseName, string description)
        {
            //CourseIdNum = courseId;
            //CourseName = name;
            //CourseDescription = description;
        }

    }
}