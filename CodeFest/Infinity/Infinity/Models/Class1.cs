﻿using System;
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
            SQLiteConnection conn = new SQLiteConnection("Data Source=C:/Users/nacht_000/Documents/GitHub/supah_hot_fire/CodeFest/Infinity/Infinity/Database.db;");
            conn.Open();
            SQLiteCommand comm = new SQLiteCommand(command, conn);
            SQLiteDataReader reader = comm.ExecuteReader();
            conn.Close();
            return reader;
        }
        
    }
}