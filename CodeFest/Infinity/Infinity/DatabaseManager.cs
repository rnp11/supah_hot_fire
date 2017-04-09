using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SQLite;
using System.Web.Services;

namespace Infinity
{
    public class DatabaseManager
    {
        
        public User getUserModel()
        {
            Lesson lesson = new Lesson("Applying for college.", "", )
            return new User("James Dude", "Saint Mary's High", 3, )
        }
        
        public Lesson getLesson()
        {
            
        }

        public Quiz getUser()
        {
            
        }

        public Question getQuestions()
        {
            string qu = "How early in advanced should you apply for college?";
            string ans1 = "2 Months";
            string ans2 = "1 Month";
            string ans3 = "5 months";
            string correctAns = "6 months - 2 yrs";
            Question question1 = new Question(qu, correctAns, ans1, ans2, ans3);

             qu = "How early in advanced should you apply for college?";
             ans1 = "2 Months";
             ans2 = "1 Month";
             ans3 = "5 months";
             correctAns = "6 months - 2 yrs";
            Question question1 = new Question(qu, correctAns, ans1, ans2, ans3);
        }
        
        //[WebMethod]
        //public static Object makeScalarQuery(string command)
        //{
        //    string connectionString = string.Concat("Data Source=", System.AppDomain.CurrentDomain.BaseDirectory, "Database.db;Version=3;");
        //    SQLiteConnection conn = new SQLiteConnection(connectionString);
        //    conn.Open();
        //    SQLiteCommand comm = new SQLiteCommand(command, conn);
            
        //    Object something = comm.ExecuteScalar();
        //    conn.Close();
        //    return something;
        //}
        //public static void makeNonQuery(string command)
        //{
        //    string connectionString = string.Concat("Data Source=", System.AppDomain.CurrentDomain.BaseDirectory, "Database.db;Version=3;");
        //    SQLiteConnection conn = new SQLiteConnection(connectionString);
        //    conn.Open();
        //    SQLiteCommand comm = new SQLiteCommand(command, conn);
        //    comm.ExecuteNonQuery();
        //    conn.Close();
        //}
        //public static SQLiteDataReader makeReaderQuery(string command)
        //{
        //    string connectionString = string.Concat("Data Source=", System.AppDomain.CurrentDomain.BaseDirectory, "Database.db;Version=3;");
        //    SQLiteConnection conn = new SQLiteConnection(connectionString);
        //    conn.Open();
        //    SQLiteCommand comm = new SQLiteCommand(command, conn);

        //    SQLiteDataReader reader = comm.ExecuteReader();
        //    conn.Close();
        //    return reader;
        //}

    }
}