using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Infinity
{
    public class Quiz
    {
        public int ID { get; set; }
        public string CourseName { get; set; }
        public List<Question> questions { get; set; }
        // public Mentor CourseMentor { get; set; }
        // public Quiz CourseQuiz { get; set; }

        public Quiz(List<Question> questions)
        {
            this.questions = questions;
        }
    }
}