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
        public static Object makeScalarQuery(string command)
        {
            string connectionString = string.Concat("Data Source=", System.AppDomain.CurrentDomain.BaseDirectory, "Database.db;Version=3;");
            SQLiteConnection conn = new SQLiteConnection(connectionString);
            conn.Open();
            SQLiteCommand comm = new SQLiteCommand(command, conn);

            Object something = comm.ExecuteScalar();
            conn.Close();

            return something;
        }
        public static void makeNonQuery(string command)
        {
            string connectionString = string.Concat("Data Source=", System.AppDomain.CurrentDomain.BaseDirectory, "Database.db;Version=3;");
            SQLiteConnection conn = new SQLiteConnection(connectionString);
            conn.Open();
            SQLiteCommand comm = new SQLiteCommand(command, conn);
            comm.ExecuteNonQuery();
            conn.Close();
        }
        public static SQLiteDataReader makeReaderQuery(string command)
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