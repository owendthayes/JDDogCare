using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JDDogCare.Objects;
using System.Data.SqlClient;

namespace JDDogCare.DBAccess
{
    class BookingDBAccess
    {
        private Database db;

        public BookingDBAccess(Database db)
        {
            this.db = db;
        }

        public List<Bookings> getAllBookings()
        {
            List<Bookings> resultBookings = new List<Bookings>();

            db.Cmd = db.Conn.CreateCommand();
            db.Cmd.CommandText = "SELECT * FROM Bookings";
            db.Rdr = db.Cmd.ExecuteReader();

            while (db.Rdr.Read())
            {
                resultBookings.Add(getBookingsFromReader(db.Rdr));
            }
            db.Rdr.Close();
            return resultBookings;
        }

        public Bookings getBookingsByID(int id)
        {
            Bookings resultBookings = new Bookings();

            db.Cmd = db.Conn.CreateCommand();
            db.Cmd.CommandText = "SELECT * FROM Bookings WHERE BookingID = " + id;
            db.Rdr = db.Cmd.ExecuteReader();

            while (db.Rdr.Read())
            {
                resultBookings.BookingID = db.Rdr.GetInt32(0);
                resultBookings.TrainingID = db.Rdr.GetInt32(1);
                resultBookings.DogID = db.Rdr.GetInt32(2);
                resultBookings.Archive = db.Rdr.GetBoolean(3);
                resultBookings.BookingCost = db.Rdr.GetDecimal(4);
            }
            db.Rdr.Close();
            return resultBookings;
        }

        public Bookings getBookingsFromReader(SqlDataReader reader)
        {
            Bookings resultBookings = new Bookings();

            resultBookings.BookingID = db.Rdr.GetInt32(0);
            resultBookings.TrainingID = db.Rdr.GetInt32(1);
            resultBookings.DogID = db.Rdr.GetInt32(2);
            resultBookings.Archive = db.Rdr.GetBoolean(3);
            resultBookings.BookingCost = db.Rdr.GetDecimal(4);

            return resultBookings;
        }
    }
}
