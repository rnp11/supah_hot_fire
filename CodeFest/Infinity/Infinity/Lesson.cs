using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Infinity
{
    public class Lesson
    {
        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public string URL { get; set; }
        public Quiz MyQuiz { get; set; }
        public User MyUser { get; set; }
        public string Content { get; set; }
        // public Mentor CourseMentor { get; set; }
        // public Quiz CourseQuiz { get; set; }

        public Lesson(string courseName, string URL, Quiz MyQuiz, User MyUser, string Content)
        {
            this.CourseName = courseName;
            this.URL = URL;
            this.MyQuiz = MyQuiz;
            this.MyUser = MyUser;
            this.Content = Content;
        }

    }
}