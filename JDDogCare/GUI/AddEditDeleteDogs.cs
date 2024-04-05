using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JDDogCare.Objects;
using JDDogCare.DBAccess;

namespace JDDogCare.GUI
{
    public partial class AddEditDeleteDogs : MasterForm
    {
        Database db;
        List<Dogs> DogsList = new List<Dogs>();
        List<Customers> CustomersList = new List<Customers>();
        List<Bookings> BookingList = new List<Bookings>();
        List<Training> TrainingList = new List<Training>();

        List<string> CustForListBox = new List<string>();
        List<string> DogForListBox = new List<string>();

        string selectedDogID;
        string checkString;
        string checkStringArchived;
        string checkStringHyphen;
        string checkStringArchivedHyphen;
        string CustomerID;

        int digitCounter;
        int highestID = 0;

        public AddEditDeleteDogs(Database db)
        {
            InitializeComponent();

            this.db = db;
            DogsDBAccess DogsDBA = new DogsDBAccess(db);
            CustomersDBAccess CustDBA = new CustomersDBAccess(db);
            BookingDBAccess BookDBA = new BookingDBAccess(db);
            TrainingDBAccess TrainDBA = new TrainingDBAccess(db);

            clkDOB.Start();

            DogsList = DogsDBA.getAllDogs();
            CustomersList = CustDBA.getAllCustomers();
            BookingList = BookDBA.getAllBookings();
            TrainingList = TrainDBA.getAllTraining();

            foreach (Customers Cust in CustomersList)
            {
                CustForListBox.Add(Cust.CustomerID + " - " + Cust.CustomerForename + " " + Cust.CustomerSurname);
            }
            listBoxCustomers.DataSource = CustForListBox;

            foreach (Dogs Dog in DogsList)
            {
                if (Dog.DogID >= highestID)
                {
                    highestID = Dog.DogID;
                }
            }

            listBoxCustomers.SelectedIndex = 1;
            listBoxCustomers.SelectedIndex = 0;

            txtNewDogID.Text = Convert.ToString(highestID + 1);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form Form1 = new TrainingMenu(db);
            this.Close();
            Form1.Show();
        }

        private void btnTraining_Click(object sender, EventArgs e)
        {
            Form Form1 = new TrainingMenu(db);
            this.Close();
            Form1.Show();
        }

        private void btnLoadDog_Click(object sender, EventArgs e)
        {

        }

        private void cmbSelectDog_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSaveChanges_Click(object sender, EventArgs e) //saves changes made to the selected dog, only the name and training eligibility can be changed.
        {
            string FixedCustomerID = Convert.ToString(Convert.ToInt16(CustomerID) + 1);
            if (MessageBox.Show("Are you sure you want to save", "Save Changes", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (txtDogID.Text.Trim() != "" && txtDogName.Text.Trim() != "" && txtDogBreed.Text.Trim() != "" && cmbEditDOBDay.Text.Trim() != "" && cmbEditDOBMonth.Text.Trim() != "" && cmbEditDOBYear.Text.Trim() != "" && cmbOwner.Text.Trim() != "")
                {
                    try
                    {
                        CustomerID = null;
                        digitCounter = 0;
                        foreach (char Character in listBoxCustomers.SelectedItem.ToString())
                        {
                            if (digitCounter <= 3) //this is used to take the customer's id from the text box which is formatted like "01 - Customer Name". This code will only take numbers in the first 3 spaces.
                            {
                                if (Char.IsNumber(Character))
                                {
                                    CustomerID += Character;
                                }
                                digitCounter++;
                            }
                            else
                            {
                                break;
                            }
                        }
                        foreach (Dogs Dog in DogsList)
                        {
                            if (Dog.DogID == Convert.ToInt32(txtDogID.Text)) //The actual reccord in the Dogs table is updated to reflect the changes the user has made.
                            {
                                db.Conn.CreateCommand();
                                db.Cmd.CommandText = "UPDATE Dogs SET DogName = @NewDogName, BasicTrainingComplete = @NewBasicTraining, CustomerID = @NewCustID, Breed = @NewBreed WHERE DogID = " + Dog.DogID;

                                db.Cmd.Parameters.AddWithValue("@NewDogName", txtDogName.Text);
                                db.Cmd.Parameters.AddWithValue("@NewBasicTraining", chkBasicTraining.Checked);
                                db.Cmd.Parameters.AddWithValue("@NewCustID", FixedCustomerID);
                                db.Cmd.Parameters.AddWithValue("@NewBreed", txtDogBreed.Text);

                                db.Cmd.ExecuteNonQuery();
                                MessageBox.Show("Saved Changes.");

                                Form Form1 = new AddEditDeleteDogs(db);
                                Form1.Show();
                                this.Close();
                            }
                        }
                    }

                    catch (Exception)
                    {

                    }
                }
                else
                {
                    MessageBox.Show("Please ensure that all text boxes contain a value. Changes have not been saved.");
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e) 
        {
            if (MessageBox.Show("Are you sure you want to archive this dog? \nAll bookings including this dog will also be archived or deleted if they have not yet happened.", "Archive Dog", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    foreach (Dogs Dog in DogsList)
                    {
                        if (Dog.DogID == Convert.ToInt32(txtDogID.Text)) //Changes the archived value of the selected dog to true, so the dog can't be edited or access during runtime anymore.
                        {
                            db.Conn.CreateCommand();
                            db.Cmd.CommandText = "UPDATE Dogs SET Archive = @Archive WHERE DogID = " + Dog.DogID;
                            db.Cmd.Parameters.AddWithValue("@Archive", 1);
                            db.Cmd.ExecuteNonQuery();

                            foreach (Bookings Book in BookingList)
                            {
                                if (Book.DogID == Dog.DogID && TrainingList[Book.TrainingID - 1].StartDate <= DateTime.Now) //Any bookings associated with the selected dog are archived or deleted depending on their start date
                                {
                                    try //BOOKINGS ARE ARCHIVED AS THEY STARTED IN THE PAST.
                                    {
                                        db.Conn.CreateCommand();
                                        db.Cmd.CommandText = "UPDATE Bookings SET Archive = " + 1 + " WHERE BookingID = " + Book.BookingID;
                                        db.Cmd.ExecuteNonQuery();
                                    }
                                    catch (Exception)
                                    {
                                        MessageBox.Show("Error when updating Bookings");
                                    }
                                }
                                else if (Book.DogID == Dog.DogID && TrainingList[Book.TrainingID - 1].StartDate > DateTime.Now)
                                {
                                    try //BOOKINGS ARE DELETED AS THEY HAPPEN IN THE FUTURE.
                                    {
                                        db.Conn.CreateCommand();
                                        db.Cmd.CommandText = "DELETE FROM Bookings WHERE DogID = " + Book.DogID + "AND TrainingID = " + TrainingList[Book.TrainingID - 1].TrainingID;
                                        db.Cmd.ExecuteNonQuery();
                                    }
                                    catch (Exception)
                                    {
                                        MessageBox.Show("Error when updating Bookings");
                                    }
                                }
                            }
                            MessageBox.Show("Dog Archived.");

                            Form Form1 = new AddEditDeleteDogs(db);
                            Form1.Show();
                            this.Close();
                        }
                    }
                }

                catch
                {
                    
                }
            }
        }

        private void btnSaveNewDog_Click(object sender, EventArgs e) //A new dog record is added to the dogs table using the information the user has entered.
        {
            try
            {
                string FixedCustomerID = Convert.ToString(Convert.ToInt16(CustomerID) + 1);
                bool dogRegisteredToCust = false;
                bool DogOver1Year = false;
                if (MessageBox.Show("Are you sure you want to save this Dog?", "Save new Dog.", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    foreach (Dogs Dog in DogsList)
                    {
                        if (Dog.DogName == txtNewDogName.Text && Convert.ToString(Dog.CustomerID) == FixedCustomerID) //checks if there is a dog already registered to the selected customer with the same name.
                        {
                            dogRegisteredToCust = true;
                            break;
                        }
                        else
                        {
                            dogRegisteredToCust = false;
                        }
                    }

                    if (DateTime.Parse(cmbAddDOBYear.Text + "-" + cmbAddDOBMonth.Text + "-" + cmbAddDOBDay.Text) > DateTime.Now)
                    {
                        MessageBox.Show("Please enter a valid date of birth.\nThis date is in the future."); //Checks that the date of birth is valid.
                        DogOver1Year = false;
                    }
                    else if (DateTime.Parse(cmbAddDOBYear.Text + "-" + cmbAddDOBMonth.Text + "-" + cmbAddDOBDay.Text) > DateTime.Now.AddYears(-1))
                    {
                        MessageBox.Show("This Dog is too young for training.\nDogs must be over 1 year old."); //Checks that the dog is over 1 year old.
                        DogOver1Year = false;
                    }
                    else
                    {
                        DogOver1Year = true;
                    }

                    if (DogOver1Year == true)
                    {
                        if (dogRegisteredToCust == false)
                        {
                            if (txtNewDogID.Text.Trim() != "" && txtNewDogName.Text.Trim() != "" && txtNewDogBreed.Text.Trim() != "" && cmbAddDOBDay.Text.Trim() != "" && cmbAddDOBMonth.Text.Trim() != "" && cmbAddDOBYear.Text.Trim() != "" && cmbNewOwner.Text.Trim() != "")
                            {
                                FixedCustomerID = Convert.ToString(Convert.ToInt16(CustomerID) + 1);
                                try
                                {
                                    db.Cmd = db.Conn.CreateCommand();
                                    db.Cmd.CommandText = "INSERT INTO Dogs (DogID, DogName, Breed, DateOfBirth, BasicTrainingComplete, Archive, CustomerID) VALUES (@DogID, @DogName, @DogBreed, @DOB, @BasicTraining, @Archive, @CustID)";

                                    db.Cmd.Parameters.AddWithValue("@DogID", txtNewDogID.Text.Trim());
                                    db.Cmd.Parameters.AddWithValue("@DogName", txtNewDogName.Text.Trim());
                                    db.Cmd.Parameters.AddWithValue("@DogBreed", txtNewDogBreed.Text.Trim());
                                    db.Cmd.Parameters.AddWithValue("@DOB", DateTime.Parse(cmbAddDOBYear.Text + "-" + cmbAddDOBMonth.Text + "-" + cmbAddDOBDay.Text));
                                    db.Cmd.Parameters.AddWithValue("@BasicTraining", chkNewBasic.Checked);
                                    db.Cmd.Parameters.AddWithValue("@Archive", 0);
                                    db.Cmd.Parameters.AddWithValue("@CustID", FixedCustomerID);

                                    db.Cmd.ExecuteNonQuery();

                                    MessageBox.Show("New Dog Saved.");
                                    Form Form1 = new AddEditDeleteDogs(db);
                                    Form1.Show();
                                    this.Close();
                                }

                                catch (Exception E)
                                {
                                    MessageBox.Show(Convert.ToString(E));
                                    MessageBox.Show("Please ensure that all text boxes contain a value. Changes have not been saved.");
                                }

                            }
                            else
                            {
                                MessageBox.Show("Please ensure that all text boxes contain a value. Changes have not been saved.");
                            }
                        }
                        else
                        {
                            FixedCustomerID = Convert.ToString(Convert.ToInt16(CustomerID) + 1); //if a dog is already registered to the selected customer the system asks if the user wants to save the dog anyway.
                            if (MessageBox.Show("A dog with this name has already been added to this customer,\nDo you still want to save?", "Save new Dog.", MessageBoxButtons.YesNo) == DialogResult.Yes)
                            {
                                if (txtNewDogID.Text.Trim() != "" && txtNewDogName.Text.Trim() != "" && txtNewDogBreed.Text.Trim() != "" && cmbAddDOBDay.Text.Trim() != "" && cmbAddDOBMonth.Text.Trim() != "" && cmbAddDOBYear.Text.Trim() != "" && cmbNewOwner.Text.Trim() != "")
                                {
                                    try
                                    {
                                        db.Cmd = db.Conn.CreateCommand();
                                        db.Cmd.CommandText = "INSERT INTO Dogs (DogID, DogName, Breed, DateOfBirth, BasicTrainingComplete, Archive, CustomerID) VALUES (@DogID, @DogName, @DogBreed, @DOB, @BasicTraining, @Archive, @CustID)";

                                        db.Cmd.Parameters.AddWithValue("@DogID", txtNewDogID.Text.Trim());
                                        db.Cmd.Parameters.AddWithValue("@DogName", txtNewDogName.Text.Trim());
                                        db.Cmd.Parameters.AddWithValue("@DogBreed", txtNewDogBreed.Text.Trim());
                                        db.Cmd.Parameters.AddWithValue("@DOB", DateTime.Parse(cmbAddDOBYear.Text + "-" + cmbAddDOBMonth.Text + "-" + cmbAddDOBDay.Text));
                                        db.Cmd.Parameters.AddWithValue("@BasicTraining", chkNewBasic.Checked);
                                        db.Cmd.Parameters.AddWithValue("@Archive", 0);
                                        db.Cmd.Parameters.AddWithValue("@CustID", FixedCustomerID);

                                        db.Cmd.ExecuteNonQuery();

                                        MessageBox.Show("New Dog Saved.");
                                        Form Form1 = new AddEditDeleteDogs(db);
                                        Form1.Show();
                                        this.Close();
                                    }

                                    catch (Exception E)
                                    {
                                        MessageBox.Show(Convert.ToString(E));
                                        MessageBox.Show("Please ensure that all text boxes contain a value. Changes have not been saved.");
                                    }

                                }
                                else
                                {
                                    MessageBox.Show("Please ensure that all text boxes contain a value. Changes have not been saved.");
                                }
                            }
                        }
                    }
                    else
                    {

                    }

                }
                else
                {
                    MessageBox.Show("Save cancelled.");
                }
            }         
            catch
            {
                MessageBox.Show("Please ensure that every box is filled before trying to save a new dog.");
            }   
        }

        private void cmbEditDOBDay_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbEditDOBMonth_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbEditDOBYear_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtDogBreed_Load(object sender, EventArgs e)
        {

        }

        private void listBoxDogs_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtDogName.Text = "";
            txtDogBreed.Text = "";
            cmbEditDOBDay.Text = "";
            cmbEditDOBMonth.Text = "";
            cmbEditDOBYear.Text = "";
            chkBasicTraining.Checked = false;
            cmbOwner.Text = "";

            try
            {
                selectedDogID = listBoxDogs.SelectedItem.ToString();
            }
            catch
            {

            }

            int[] CustomerDogNumber = new int[CustomersList.Count];
            foreach (Customers Owner in CustomersList)
            {
                foreach (Dogs Dog in DogsList)
                {
                    if (Dog.CustomerID == Owner.CustomerID)
                    {
                        CustomerDogNumber[Owner.CustomerID - 1]++;
                    }
                }
            }

            foreach (Dogs Dog in DogsList)
            {
                checkString = Dog.DogID + " - " + Dog.DogName;
                checkStringArchived = Dog.DogID + " - " + Dog.DogName + " - ARCHIVED";

                if (checkString == selectedDogID || checkStringArchived == selectedDogID)
                {
                    txtDogID.Text = Convert.ToString(Dog.DogID);
                    txtDogName.Text = Dog.DogName;
                    txtDogBreed.Text = Dog.Breed;

                    cmbEditDOBDay.Text = Dog.DateOfBirth.ToString("dd");
                    cmbEditDOBMonth.Text = Dog.DateOfBirth.ToString("MM");
                    cmbEditDOBYear.Text = Dog.DateOfBirth.ToString("yyyy");

                    chkBasicTraining.Checked = Dog.BasicTrainingComplete;

                    foreach (Customers Owner in CustomersList)
                    {
                        if (Dog.CustomerID == Owner.CustomerID & CustomerDogNumber[Owner.CustomerID - 1] != 0)
                        {
                            cmbOwner.Text = Owner.CustomerID + " - " + Owner.CustomerForename + " " + Owner.CustomerSurname;
                        }
                    }

                    if (checkStringArchived == selectedDogID)
                    {
                        btnSaveChanges.Enabled = false;
                        btnDelete.Enabled = false;
                    }
                    else
                    {
                        btnSaveChanges.Enabled = true;
                        btnDelete.Enabled = true;
                    }
                }
            }
        }

        private void listBoxCustomers_SelectedIndexChanged(object sender, EventArgs e) //populates the list box of dogs with dogs that belong to the selected customer.
        {
            listBoxDogs.SelectedIndex = -1;

            txtDogBreed.Text = "";
            txtDogName.Text = "";
            chkBasicTraining.Checked = false;
            cmbEditDOBDay.SelectedIndex = -1;
            cmbEditDOBMonth.SelectedIndex = -1;
            cmbEditDOBYear.SelectedIndex = -1;

            CustomerID = null;
            digitCounter = 0;
            foreach (char Character in listBoxCustomers.SelectedItem.ToString())
            { //gets the customer ID from the text box which is formatted like "01 - Customer Name".
                if (digitCounter <= 3)
                {
                    if (Char.IsNumber(Character))
                    {
                        CustomerID += Character;
                    }
                    digitCounter++;
                }
                else
                {
                    break;
                }
            }
            try
            {
                foreach (Customers Cust in CustomersList)
                {
                    if (Convert.ToString(Cust.CustomerID) == CustomerID) //populates the customer text box with the selected customer.
                    {
                        cmbOwner.Text = Cust.CustomerID + " - " + Cust.CustomerForename + " " + Cust.CustomerSurname;
                        cmbNewOwner.Text = Cust.CustomerID + " - " + Cust.CustomerForename + " " + Cust.CustomerSurname;
                    }
                }

                CustomerID = Convert.ToString(Convert.ToInt16(CustomerID) - 1);

                DogForListBox.Clear();

                foreach (Dogs Dog in DogsList)
                {
                    if (Dog.CustomerID == CustomersList[Convert.ToInt32(CustomerID)].CustomerID && Dog.Archive == false) //adds dogs to listBoxDogs only if they are linked to the selected customer.
                    {
                        DogForListBox.Add(Dog.DogID + " - " + Dog.DogName);
                    }
                }
                listBoxDogs.DataSource = null;
                listBoxDogs.DataSource = DogForListBox;
                listBoxDogs.Refresh();
                listBoxDogs.SelectedIndex = 0;
            }
            catch
            {

            }
        }

        private void btnEditDog_Click(object sender, EventArgs e)
        { //hides all objects associated with adding dogs, and shows everything associated with editing.
            txtNewDogName.Text = "";
            txtNewDogBreed.Text = "";
            cmbAddDOBDay.Text = "";
            cmbAddDOBMonth.Text = "";
            cmbAddDOBYear.Text = "";
            chkNewBasic.Checked = false;

            btnEditDog.Visible = false;
            btnAddNewDog.Visible = false;
            btnClearFilter.Visible = true;
            cmbNewOwner.Visible = false;


            listBoxCustomers.Visible = true;
            listBoxDogs.Visible = true;

            btnSaveChanges.Visible = true;
            btnDelete.Visible = true;

            lblEditDelete.Visible = true;
            lblDogID.Visible = true;
            label2.Visible = true;
            label1.Visible = true;
            lblDOB.Visible = true;
            lblBasicTraining.Visible = true;
            llbCustName.Visible = true;
            lblSelectCustomer.Visible = true;
            lblSelectWhatYouWant.Visible = false;
            lblFilterCustomers.Visible = true;
            txtNewDogID.Visible = false;

            txtDogID.Visible = true;
            txtDogName.Visible = true;
            txtDogBreed.Visible = true;
            cmbEditDOBDay.Visible = true;
            cmbEditDOBMonth.Visible = true;
            cmbEditDOBYear.Visible = true;
            chkBasicTraining.Visible = true;
            cmbOwner.Visible = true;
            txtFilterCustomers.Visible = true;

            btnBackToSelection.Visible = true;


        }

        private void btnBackToSelection_Click(object sender, EventArgs e)
        {
            //hides all objects associated with adding and editing dogs.
            btnEditDog.Visible = true;
            btnAddNewDog.Visible = true;
            btnSaveNewDog.Visible = false;
            btnClearFilter.Visible = false;

            listBoxCustomers.Visible = false;
            listBoxDogs.Visible = false;

            btnSaveChanges.Visible = false;
            btnDelete.Visible = false;
            btnBackToSelection.Visible = false;

            lblEditDelete.Visible = false;
            lblDogID.Visible = false;
            label2.Visible = false;
            label1.Visible = false;
            lblDOB.Visible = false;
            lblBasicTraining.Visible = false;
            llbCustName.Visible = false;
            lblSelectCustomer.Visible = false;
            lblAdd.Visible = false;
            lblAddNewDog.Visible = false;
            lblSelectWhatYouWant.Visible = true;
            lblFilterCustomers.Visible = false;
            lblDOBValid.Visible = false;

            txtDogID.Visible = false;
            txtDogName.Visible = false;
            txtDogBreed.Visible = false;
            cmbEditDOBDay.Visible = false;
            cmbEditDOBMonth.Visible = false;
            cmbEditDOBYear.Visible = false;
            chkBasicTraining.Visible = false;
            cmbOwner.Visible = false;
            txtFilterCustomers.Visible = false;

            txtNewDogID.Visible = false;
            txtNewDogName.Visible = false;
            txtNewDogBreed.Visible = false;
            cmbAddDOBDay.Visible = false;
            cmbAddDOBMonth.Visible = false;
            cmbAddDOBYear.Visible = false;
            chkNewBasic.Visible = false;
            cmbNewOwner.Visible = false;

            foreach (Customers Cust in CustomersList)
            {
                CustForListBox.Add(Cust.CustomerID + " - " + Cust.CustomerForename + " " + Cust.CustomerSurname);
            }
            listBoxCustomers.DataSource = CustForListBox;
            listBoxCustomers.Refresh();

            txtFilterCustomers.Text = "";
        }

        private void btnAddNewDog_Click(object sender, EventArgs e)
        {
            //shows all objects associated with adding dogs, and hides everything associated with editing.
            txtDogName.Text = "";
            txtDogBreed.Text = "";
            cmbEditDOBDay.Text = "";
            cmbEditDOBMonth.Text = "";
            cmbEditDOBYear.Text = "";
            chkBasicTraining.Checked = false;

            txtNewDogName.Text = "";
            txtNewDogBreed.Text = "";
            cmbAddDOBDay.Text = "";
            cmbAddDOBMonth.Text = "";
            cmbAddDOBYear.Text = "";
            chkNewBasic.Checked = false;
            txtNewDogID.Visible = true;

            btnEditDog.Visible = false;
            btnAddNewDog.Visible = false;
            btnSaveNewDog.Visible = true;
            btnBack.Visible = true;
            btnBackToSelection.Visible = true;
            btnClearFilter.Visible = true;

            lblDogID.Visible = true;
            label2.Visible = true;
            label1.Visible = true;
            lblDOB.Visible = true;
            lblBasicTraining.Visible = true;
            llbCustName.Visible = true;
            lblAdd.Visible = true;
            lblAddNewDog.Visible = true;
            lblSelectWhatYouWant.Visible = false;
            lblDOBValid.Visible = true;

            listBoxCustomers.Visible = true;
            lblFilterCustomers.Visible = true;
            txtFilterCustomers.Visible = true;


            txtNewDogID.Visible = true;
            txtNewDogName.Visible = true;
            txtNewDogBreed.Visible = true;
            txtNewDogBreed.Enabled = true;
            cmbAddDOBDay.Visible = true;
            cmbAddDOBMonth.Visible = true;
            cmbAddDOBYear.Visible = true;
            chkNewBasic.Visible = true;
            cmbNewOwner.Visible = true;
        }

        private void txtFilterCustomers_TextChanged(object sender, EventArgs e) //filters the customers shown in the list box using the text entered in the search box by the user.
        {
            int checkLength = txtFilterCustomers.Text.Length;
          
            CustForListBox.Clear();

            foreach(Customers Cust in CustomersList)
            {
                if(Cust.CustomerSurname.Length >= txtFilterCustomers.Text.Length)
                {
                    if (Cust.CustomerSurname.Substring(0, checkLength).ToLower() == txtFilterCustomers.Text.ToLower()) //checks that the user's entered criteria matches a customer's surname.
                    {
                        CustForListBox.Add(Cust.CustomerID + " - " + Cust.CustomerForename + " " + Cust.CustomerSurname);
                    }
                }
            }
            listBoxCustomers.DataSource = null;
            listBoxCustomers.DataSource = CustForListBox;

            if (txtFilterCustomers.Text == "") //if the user clears the text box then all the customers are shown again.
            {
                foreach (Customers Cust in CustomersList)
                {
                    CustForListBox.Add(Cust.CustomerID + " - " + Cust.CustomerForename + " " + Cust.CustomerSurname);
                }
                listBoxCustomers.DataSource = CustForListBox;
                listBoxCustomers.Refresh();
            }
        }

        private void lblFilterCustomers_Click(object sender, EventArgs e)
        {

        }

        private void btnClearFilter_Click(object sender, EventArgs e)
        {
            txtFilterCustomers.Text = "";
        }

        private void cmbAddDOBDay_SelectedIndexChanged(object sender, EventArgs e)
        {
            adjustInvalidDOB();
            checkDOBOver1Year();
        }

        private void cmbAddDOBMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            adjustInvalidDOB();
            checkDOBOver1Year();
        }

        private void cmbAddDOBYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkDOBOver1Year();
        }

        private void adjustInvalidDOB() //checks if the dob is invalid e.g. 31/02 and will update it to something valid.
        {
            switch (cmbAddDOBMonth.SelectedIndex)
            {
                case 3:
                case 5:
                case 8:
                case 10:
                    if (cmbAddDOBDay.SelectedIndex == 30)
                    {
                        cmbAddDOBDay.SelectedIndex = 29;
                    }
                    break;

                case 1:
                    if (cmbAddDOBDay.SelectedIndex == 30 || cmbAddDOBDay.SelectedIndex == 29)
                    {
                        cmbAddDOBDay.SelectedIndex = 27;
                    }
                    break;
            }
        }

        private void checkDOBOver1Year() //checks to see if the entered date of birth means that the dog is over 1 year old.
        {
            DateTime potentialDOB;
            try
            {
                potentialDOB = potentialDOB = DateTime.Parse(cmbAddDOBYear.Text + "-" + cmbAddDOBMonth.Text + "-" + cmbAddDOBDay.Text);
                if (potentialDOB > DateTime.Now.AddYears(-1))
                {                   
                    lblDOBValid.ForeColor = Color.Red; //a label is shown on the form that changes if the dog is over 1 year old or not.
                }
                else
                {
                    lblDOBValid.ForeColor = Color.Green;
                }
            }
            catch
            {

            }
        }

        private void clkDOB_Tick(object sender, EventArgs e)
        { //allows the user to edit or delete dogs depending on if a dog has been selected or not.
            if (lblDOBValid.ForeColor == Color.Red && txtDogName.Text == "")
            {
                btnSaveNewDog.Enabled = false;
            }
            else
            {
                btnSaveNewDog.Enabled = true;
            }

            if (listBoxDogs.SelectedIndex == -1)
            {
                btnDelete.Enabled = false;
                btnSaveChanges.Enabled = false;
            }
            else
            {
                btnDelete.Enabled = true;
                btnSaveChanges.Enabled = true;
            }
        }

        private void chkNewBasic_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void listBoxCustomers_SelectedValueChanged(object sender, EventArgs e)
        {
            
        }

        private void txtNewDogBreed_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true; //the dog breed has to be selected from a list so the user should not be able to enter their own text.
        }

        private void txtNewDogBreed_MouseClick(object sender, MouseEventArgs e)
        {
            txtNewDogBreed.DroppedDown = true; //the style of drop down list I have used means that this is a necessary line of code.
        }

        private void txtDogBreed_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtDogBreed_MouseClick(object sender, MouseEventArgs e)
        {
            txtNewDogBreed.DroppedDown = true; 
        }

        private void txtDogBreed_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }
    }
}

