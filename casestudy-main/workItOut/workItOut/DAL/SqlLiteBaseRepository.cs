using Dapper;
using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace workItOut.DAL
{
    class SqlLiteBaseRepository
    {
        public SqlLiteBaseRepository()
        {
        }

        public static SqliteConnection Dbconnection()
        {
            return new SqliteConnection(@"DataSource=WorkoutDB.sqlite");
        }

        protected static bool DatabaseExists()
        {
            return File.Exists(@"WorkoutDB.sqlite");
        }

        protected static void CreateDatabase()
        {
            using (var connection = Dbconnection())
            {
                connection.Open();
                connection.Execute(
                    @"CREATE TABLE Workouts
                    (
                    Id                                  INTEGER PRIMARY KEY AUTOINCREMENT,
                    Name                                VARCHAR(20)
                    )");
            }
        }
    }
}
