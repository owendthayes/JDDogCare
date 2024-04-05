using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace JDDogCare.Objects
{
    public class Bookings
    {
        private int bookingID;
        private int trainingID;
        private int dogID;
        private bool archive;
        private decimal bookingCost;

        public Bookings()
        {

        }

        public Bookings(int bookingID, int trainingID, int dogID, bool archive, decimal bookingCost)
        {
            BookingID = bookingID;
            TrainingID = trainingID;
            DogID = dogID;
            Archive = archive;
            BookingCost = bookingCost;
        }

        public int BookingID
        {
            get { return bookingID; }
            set { bookingID = value; }
        }

        public int TrainingID
        {
            get { return trainingID; }
            set { trainingID = value; }
        }

        public int DogID
        {
            get { return dogID; }
            set { dogID = value; }
        }

        public bool Archive
        {
            get { return archive; }
            set { archive = value; }
        }

        public decimal BookingCost
        {
            get { return bookingCost; }
            set { bookingCost = value; }
        }
    }
}
