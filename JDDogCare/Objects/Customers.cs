using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace JDDogCare.Objects
{
    public class Customers
    {
        private int customerID;
        private string customerForename;
        private string customerSurname;
        private string customerAddress;
        private string customerTown;
        private string customerTelNo;

        public Customers()
        {

        }

        public Customers(int customerID, string customerForename, string customerSurname, string customerAddress, string customerTown, string customerTelNo)
        {
            CustomerID = customerID;
            CustomerForename = customerForename;
            CustomerSurname = customerSurname;
            CustomerAddress = customerAddress;
            CustomerTown = customerTown;
            CustomerTelNo = customerTelNo;
        }

        public int CustomerID
        {
            get { return customerID; }
            set { customerID = value; }
        }

        public string CustomerForename
        {
            get { return customerForename; }
            set { customerForename = value; }
        }

        public string CustomerSurname
        {
            get { return customerSurname; }
            set { customerSurname = value; }
        }

        public string CustomerAddress
        {
            get { return customerAddress; }
            set { customerAddress = value; }
        }

        public string CustomerTown
        {
            get { return customerTown; }
            set { customerTown = value; }
        }

        public string CustomerTelNo
        {
            get { return customerTelNo; }
            set { customerTelNo = value; }
        }
    }
}
