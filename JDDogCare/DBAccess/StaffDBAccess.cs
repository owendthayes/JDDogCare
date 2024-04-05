using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JDDogCare.Objects;
using System.Data.SqlClient;

namespace JDDogCare.DBAccess
{
    class StaffDBAccess
    {
        private Database db;

        public StaffDBAccess(Database db)
        {
            this.db = db;
        }

        public List<Staff> getAllStaff()
        {
            List<Staff> resultStaff = new List<Staff>();

            db.Cmd = db.Conn.CreateCommand();
            db.Cmd.CommandText = "SELECT * FROM Staff";
            db.Rdr = db.Cmd.ExecuteReader();

            while (db.Rdr.Read())
            {
                resultStaff.Add(getStaffFromReader(db.Rdr));
            }
            db.Rdr.Close();
            return resultStaff;
        }

        public Staff getStaffByID(int id)
        {
            Staff resultStaff = new Staff();

            db.Cmd = db.Conn.CreateCommand();
            db.Cmd.CommandText = "SELECT * FROM Staff WHERE StaffID = " + id;
            db.Rdr = db.Cmd.ExecuteReader();

            while (db.Rdr.Read())
            {
                resultStaff.StaffID = db.Rdr.GetInt32(0);
                resultStaff.StaffForename = db.Rdr.GetString(1);
                resultStaff.StaffSurname = db.Rdr.GetString(2);
                resultStaff.TelNo = db.Rdr.GetString(3);
                resultStaff.AdvancedQualified = db.Rdr.GetBoolean(4);
            }
            db.Rdr.Close();
            return resultStaff;
        }

        public Staff getStaffFromReader(SqlDataReader reader)
        {
            Staff resultStaff = new Staff();

            resultStaff.StaffID = db.Rdr.GetInt32(0);
            resultStaff.StaffForename = db.Rdr.GetString(1);
            resultStaff.StaffSurname = db.Rdr.GetString(2);
            resultStaff.TelNo = db.Rdr.GetString(3);
            resultStaff.AdvancedQualified = db.Rdr.GetBoolean(4);

            return resultStaff;
        }
    }
}
