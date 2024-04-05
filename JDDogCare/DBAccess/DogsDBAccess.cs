using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JDDogCare.Objects;
using System.Data.SqlClient;

namespace JDDogCare.DBAccess
{
    class DogsDBAccess
    {
        private Database db;

        public DogsDBAccess(Database db)
        {
            this.db = db;
        }

        public List<Dogs> getAllDogs()
        {
            List<Dogs> resultDogs = new List<Dogs>();

            db.Cmd = db.Conn.CreateCommand();
            db.Cmd.CommandText = "SELECT * FROM Dogs";
            db.Rdr = db.Cmd.ExecuteReader();

            while(db.Rdr.Read())
            {
                resultDogs.Add(getDogsFromReader(db.Rdr));
            }
            db.Rdr.Close();
            return resultDogs;
        }

        public Dogs getDogsByID(int id)
        {
            Dogs resultDogs = new Dogs();

            db.Cmd = db.Conn.CreateCommand();
            db.Cmd.CommandText = "SELECT * FROM Dogs WHERE DogID = " + id;
            db.Rdr = db.Cmd.ExecuteReader();

            while (db.Rdr.Read())
            {
                resultDogs.CustomerID = db.Rdr.GetInt32(0);
                resultDogs.DogName = db.Rdr.GetString(1);
                resultDogs.Breed = db.Rdr.GetString(2);
                resultDogs.DateOfBirth = db.Rdr.GetDateTime(3);
                resultDogs.BasicTrainingComplete = db.Rdr.GetBoolean(4);
                resultDogs.Archive = db.Rdr.GetBoolean(5);
                resultDogs.CustomerID = db.Rdr.GetInt32(6);
            }
            db.Rdr.Close();
            return resultDogs;
        }

        public Dogs getDogsFromReader(SqlDataReader reader)
        {
            Dogs resultDogs = new Dogs();

            resultDogs.DogID = db.Rdr.GetInt32(0);
            resultDogs.DogName = db.Rdr.GetString(1);
            resultDogs.Breed = db.Rdr.GetString(2);
            resultDogs.DateOfBirth = db.Rdr.GetDateTime(3);
            resultDogs.BasicTrainingComplete = db.Rdr.GetBoolean(4);
            resultDogs.Archive = db.Rdr.GetBoolean(5);
            resultDogs.CustomerID = db.Rdr.GetInt32(6);

            return resultDogs;
        }
    }
}
