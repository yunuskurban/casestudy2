using Dapper;
using System;
using System.Collections.Generic;
using System.Text;
using workItOut.Models;

namespace workItOut.DAL
{
    class WorkoutsRepository : SqlLiteBaseRepository
    {
        public WorkoutsRepository()
        {
            if (!DatabaseExists())
            {
                CreateDatabase();
            }
        }
        public int InsertWorkout(Workout workout)
        {
            string sql = "INSERT INTO Workouts (name) Values (@Name);";
            using (var connection = Dbconnection())
            {
                connection.Open();
                return connection.Execute(sql, workout);
            }
        }

        public int DeleteWorkouts(string nameWorkout)
        {
            string sql = "DELETE FROM Workouts WHERE name = @Name;";

            using (var connection = Dbconnection())
            {
                connection.Open();
                return connection.Execute(sql, new { Name = nameWorkout });
            }
        }

        public IEnumerable<Workout> GetWorkouts()
        {
            string sql = "SELECT * FROM Workouts;";

            using (var connection = Dbconnection())
            {
                return connection.Query<Workout>(sql);
            }
        }
    }
}
