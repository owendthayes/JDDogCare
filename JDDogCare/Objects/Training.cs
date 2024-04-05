using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace JDDogCare.Objects
{
    public class Training
    {
        private int trainingID;
        private int staffID;
        private string trainingType;
        private string ageClass;
        private DateTime startDate;
        private DateTime endDate;

        public Training()
        {

        }

        public Training (int trainingID, int staffID, string trainingType, string ageClass, DateTime startDate, DateTime endDate)
        {
            TrainingID = trainingID;
            StaffID = staffID;
            TrainingType = trainingType;
            AgeClass = ageClass;
            StartDate = startDate;
            EndDate = endDate;
        }

        public int TrainingID
        {
            get { return trainingID; }
            set { trainingID = value; }
        }

        public int StaffID
        {
            get { return staffID; }
            set { staffID = value; }
        }

        public string TrainingType
        {
            get { return trainingType; }
            set { trainingType = value; }
        }

        public string AgeClass
        {
            get { return ageClass; }
            set { ageClass = value; }
        }

        public DateTime StartDate
        {
            get { return startDate; }
            set { startDate = value; }
        }

        public DateTime EndDate
        {
            get { return endDate; }
            set { endDate = value; }
        }
    }
}
