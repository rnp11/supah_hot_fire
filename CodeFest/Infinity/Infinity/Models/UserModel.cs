using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Infinity.Models
{
    public class UserModel
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
        public int Lesson { get; set; }
        private int CourseId { get; set; }

        public UserModel(string Name, string Organization, int points,
            string Password, string username, int userId, string userType,
            string picture, int lesson, int CourseId)
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

        public void listAvailableClasses()
        {
            // list classes available based on the schoolID of the student
            // Course.listClasses(schoolId); or something
        }
    }
}