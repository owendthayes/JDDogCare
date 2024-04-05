using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace JDDogCare.Objects
{
    public class Dogs
    {
        private int dogID;
        private string dogName;
        private string breed;
        private DateTime dateOfBirth;
        private bool basicTrainingComplete;
        private bool archive;
        private int customerID;

        public Dogs()
        {

        }

        public Dogs(int dogID, string dogName, string breed, DateTime dateOfBirth, bool basicTrainingComlete, bool archive, int customerID)
        {
            DogID = dogID;
            DogName = dogName;
            Breed = breed;
            DateOfBirth = dateOfBirth;
            BasicTrainingComplete = basicTrainingComlete;
            Archive = archive;
            CustomerID = customerID;
        }
     
        public int DogID
        {
            get { return dogID; }
            set { dogID = value; }                      
        }

        public string DogName
        {
            get { return dogName; }
            set { dogName = value; }
        }

        public string Breed
        {
            get { return breed; }
            set { breed = value; }
        }

        public DateTime DateOfBirth
        {
            get { return dateOfBirth; }
            set { dateOfBirth = value; }
        }

        public bool BasicTrainingComplete
        {
            get { return basicTrainingComplete; }
            set { basicTrainingComplete = value; }
        }

        public bool Archive
        {
            get { return archive; }
            set { archive = value; }
        }

        public int CustomerID
        {
            get { return customerID; }
            set { customerID = value; }
        }
      
    }
}
