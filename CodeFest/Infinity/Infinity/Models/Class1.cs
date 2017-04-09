using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SQLite;

namespace Infinity.Models
{
    public class DatabaseManager
    {
        public makeQuery()
        {
            SQLiteConnection conn = new SQLiteConnection("Data Source=C:/Users/nacht_000/Documents/GitHub/supah_hot_fire/CodeFest/Infinity/Infinity/Database.db;");

            conn.Open();
        }
        
    }
}