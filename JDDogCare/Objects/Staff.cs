using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace JDDogCare.Objects
{
    public class Staff
    {
        private int staffID;
        private string staffForename;
        private string staffSurname;
        private string telNo;
        private bool advancedQualified;

        public Staff()
        {

        }

        public Staff(int staffID, string staffForename, string staffSurname, string telNo, bool advancedQualified)
        {
            StaffID = staffID;
            StaffForename = staffForename;
            StaffSurname = staffSurname;
            TelNo = telNo;
            AdvancedQualified = advancedQualified;
        }

        public int StaffID
        {
            get { return staffID; }
            set { staffID = value; }
        }

        public string StaffForename
        {
            get { return staffForename; }
            set { staffForename = value; }
        }

        public string StaffSurname
        {
            get { return staffSurname; }
            set { staffSurname = value; }
        }

        public string TelNo
        {
            get { return telNo; }
            set { telNo = value; }
        }

        public bool AdvancedQualified
        {
            get { return advancedQualified; }
            set { advancedQualified = value; }
        }
    }
}
