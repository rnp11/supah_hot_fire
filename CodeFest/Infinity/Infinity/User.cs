using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Infinity
{
    public class User
    {
        public string Name { get; set; }
        // available classes are based on the schoolID
        public string Organization { get; set; }
        public int Infinipoints { get; set; }
        public string Password { get; set; }
        // grade in school - 9, 10, 11, 12
        public string Username { get; set; }
        public int UserID { get; set; }
        public string UserType { get; set; }
        public string Picture { get; set; }
        public Lesson Lesson { get; set; }
        private int CourseId { get; set; }

        public User(string Name, string Organization, int points,
            string picture, Lesson lesson, int CourseId)
        {
            this.Name = Name;
            this.Organization = Organization;
            this.Infinipoints = points;
            this.Password = Password;
            this.Username = Username;
            this.UserID = userId;
            this.UserType = UserType;
            this.Picture = picture;
            this.Lesson = lesson;
            this.CourseId = CourseId;

        }
    }
}