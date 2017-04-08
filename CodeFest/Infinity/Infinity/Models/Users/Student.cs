using System;
using System.Collections;
using System.Linq;
using System.Web;

namespace Infinity.Models.Users
{
    public class Student
    {
        public string StudentName { get; set; }
        // available classes are based on the schoolID
        public int SchoolIdNum { get; set; }
        public int Infinipoints { get; set; }
        public string Password { get; set; }
        // grade in school - 9, 10, 11, 12
        public int Grade { get; set; }

        // list of classIDs the student is enrolled in
        private ArrayList enrolledClasses = new ArrayList();

        public Student()
        {
            this.StudentName = "";
            this.SchoolIdNum = 0;
            this.Grade = 0;
        }

        public Student(string name, int schoolId, int year)
        {
            this.StudentName = name;
            this.SchoolIdNum = schoolId;
            this.Grade = year;
        }

        public void enrollInClass(int classId)
        {
            enrolledClasses.Add(classId);
        }

        public void listEnrolledClasses()
        {
            foreach(int id in enrolledClasses)
            {
                Console.WriteLine(id);
            }
        }

        public void listAvailableClasses()
        {
            // list classes available based on the schoolID of the student
            // Course.listClasses(schoolId); or something
        }
    }
}