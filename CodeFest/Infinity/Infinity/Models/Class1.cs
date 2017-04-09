using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SQLite;

namespace Infinity.Models
{
    public class DatabaseManager
    {
        public SQLiteDataReader makeQuery(string command)
        {
            string connectionString = string.Concat("Data Source=", System.AppDomain.CurrentDomain.BaseDirectory, "Database.db;Version=3;");
            SQLiteConnection conn = new SQLiteConnection(connectionString);
            conn.Open();
            SQLiteCommand comm = new SQLiteCommand(command, conn);
            SQLiteDataReader reader = comm.ExecuteReader();
            conn.Close();
            return reader;
        }
        
    }
}