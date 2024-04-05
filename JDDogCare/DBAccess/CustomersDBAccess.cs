using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JDDogCare.Objects;
using System.Data.SqlClient;

namespace JDDogCare.DBAccess
{
    class CustomersDBAccess
    {
        private Database db;

        public CustomersDBAccess(Database db)
        {
            this.db = db;
        }

        public List<Customers> getAllCustomers()
        {
            List<Customers> resultCustomers = new List<Customers>();

            db.Cmd = db.Conn.CreateCommand();
            db.Cmd.CommandText = "SELECT * FROM Customers";
            db.Rdr = db.Cmd.ExecuteReader();

            while (db.Rdr.Read())
            {
                resultCustomers.Add(getCustomersFromReader(db.Rdr));
            }
            db.Rdr.Close();
            return resultCustomers;
        }

        public Customers getCustomersByID(int id)
        {
            Customers resultCustomers = new Customers();

            db.Cmd = db.Conn.CreateCommand();
            db.Cmd.CommandText = "SELECT * FROM Customers WHERE CustomerID = " + id;
            db.Rdr = db.Cmd.ExecuteReader();

            while (db.Rdr.Read())
            {
                resultCustomers.CustomerID = db.Rdr.GetInt32(0);
                resultCustomers.CustomerForename = db.Rdr.GetString(1);
                resultCustomers.CustomerSurname = db.Rdr.GetString(2);
                resultCustomers.CustomerAddress = db.Rdr.GetString(3);
                resultCustomers.CustomerTown = db.Rdr.GetString(4);
                resultCustomers.CustomerTelNo = db.Rdr.GetString(5);
            }
            db.Rdr.Close();
            return resultCustomers;
        }

        public Customers getCustomersFromReader(SqlDataReader reader)
        {
            Customers resultCustomers = new Customers();

            resultCustomers.CustomerID = db.Rdr.GetInt32(0);
            resultCustomers.CustomerForename = db.Rdr.GetString(1);
            resultCustomers.CustomerSurname = db.Rdr.GetString(2);
            resultCustomers.CustomerAddress = db.Rdr.GetString(3);
            resultCustomers.CustomerTown = db.Rdr.GetString(4);
            resultCustomers.CustomerTelNo = db.Rdr.GetString(5);

            return resultCustomers;
        }
    }
}
