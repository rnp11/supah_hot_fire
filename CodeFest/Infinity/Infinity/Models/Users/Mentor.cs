using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Infinity.Models.Users
{
    public class Mentor
    {
        public string MentorName { get; set; }
        public int MentorIdNum { get; set; }
        public string Password { get; set; }

        // list of courseIDs the mentor teaches
        private ArrayList coursesTaught = new ArrayList();

        public Mentor()
        {
            MentorName = "";
            MentorIdNum = 0;
        }

        public Mentor(string name, int id)
        {
            MentorName = name;
            MentorIdNum = id;
        }

        public void createCourse()
        {
            coursesTaught.Add(new Course());
        }

        public void listCoursesTaught()
        {
            foreach (int id in coursesTaught)
            {
                Console.WriteLine(id);
            }
        }
    }
}