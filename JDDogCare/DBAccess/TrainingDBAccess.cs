using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JDDogCare.Objects;
using System.Data.SqlClient;

namespace JDDogCare.DBAccess
{
    class TrainingDBAccess
    {
        private Database db;

        public TrainingDBAccess(Database db)
        {
            this.db = db;
        }

        public List<Training> getAllTraining()
        {
            List<Training> resultTraining = new List<Training>();

            db.Cmd = db.Conn.CreateCommand();
            db.Cmd.CommandText = "SELECT * FROM Training";
            db.Rdr = db.Cmd.ExecuteReader();

            while (db.Rdr.Read())
            {
                resultTraining.Add(getTrainingFromReader(db.Rdr));
            }
            db.Rdr.Close();
            return resultTraining;
        }

        public Training getTrainingByID(int id)
        {
            Training resultTraining = new Training();

            db.Cmd = db.Conn.CreateCommand();
            db.Cmd.CommandText = "SELECT * FROM Training WHERE TrainingID = " + id;
            db.Rdr = db.Cmd.ExecuteReader();

            while (db.Rdr.Read())
            {
                resultTraining.TrainingID = db.Rdr.GetInt32(0);
                resultTraining.StaffID = db.Rdr.GetInt32(1);
                resultTraining.TrainingType = db.Rdr.GetString(2);
                resultTraining.AgeClass = db.Rdr.GetString(3);
                resultTraining.StartDate = db.Rdr.GetDateTime(4);
                resultTraining.EndDate = db.Rdr.GetDateTime(5);
            }
            db.Rdr.Close();
            return resultTraining;
        }

        public Training getTrainingFromReader(SqlDataReader reader)
        {
            Training resultTraining = new Training();

            resultTraining.TrainingID = db.Rdr.GetInt32(0);
            resultTraining.StaffID = db.Rdr.GetInt32(1);
            resultTraining.TrainingType = db.Rdr.GetString(2);
            resultTraining.AgeClass = db.Rdr.GetString(3);
            resultTraining.StartDate = db.Rdr.GetDateTime(4);
            resultTraining.EndDate = db.Rdr.GetDateTime(5);

            return resultTraining;
        }
    }
}
