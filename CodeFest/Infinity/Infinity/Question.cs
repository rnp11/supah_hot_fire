using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Infinity
{
    public class Question
    {
        public int ID { get; set; }
        public string _Question { get; set; }
        public string CorrectAnswer { get; set; }
        public string Answer1 { get; set; }
        public string Answer2 { get; set; }
        public string Answer3 { get; set; }
        // public Mentor CourseMentor { get; set; }
        // public Quiz CourseQuiz { get; set; }

        public Question(string question, string correctAnswer, string answer1,
            string answer2, string answer3)
        {
            this._Question = question;
            this.CorrectAnswer = correctAnswer;
            this.Answer1 = answer1;
            this.Answer2 = answer2;
            this.Answer3 = answer3;
        }
    }
}