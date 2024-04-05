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
    public partial class CreateBooking : MasterForm
    {
        Database db;
        DataTable table;

        List<Dogs> DogsList = new List<Dogs>();
        List<Customers> CustomersList = new List<Customers>();
        List<Staff> StaffList = new List<Staff>();
        List<Training> TrainingList = new List<Training>();
        List<Bookings> BookingList = new List<Bookings>();

        List<int> numberBooked = new List<int>();
        List<string> CustForListBox = new List<string>();        

        string checkString;
        string selectedDogID;
        string DogIDForTraining;
        string TrainingIDForBooking;
        string totalCost;

        int noBookIDs;
        int digitCounter = 0;
        int bookingCounter = 0;
        int numberBookedInt = 0;

        bool validBooking;
        bool validBooking2;
        bool validFlag;
        bool breakTrue = false;
        bool CustBookedBefore = false;

        public CreateBooking(Database db)
        {
            InitializeComponent();

            clkValidBooking.Start();

            this.db = db;

            DogsDBAccess DogsDBA = new DogsDBAccess(db);
            CustomersDBAccess CustDBA = new CustomersDBAccess(db);
            StaffDBAccess StaffDBA = new StaffDBAccess(db);
            TrainingDBAccess TrainDBA = new TrainingDBAccess(db);
            BookingDBAccess BookDBA = new BookingDBAccess(db);

            DogsList = DogsDBA.getAllDogs();
            CustomersList = CustDBA.getAllCustomers();
            StaffList = StaffDBA.getAllStaff();
            TrainingList = TrainDBA.getAllTraining();
            BookingList = BookDBA.getAllBookings();

            addTableColumn();
            populateTable();

            foreach (Dogs Dog in DogsList)
            {
                if (Dog.Archive == false)
                {
                    cmbSelectDog.Items.Add(Dog.DogID + " - " + Dog.DogName);
                }        
            }

            foreach (Customers Cust in CustomersList) //fills the list box with the names of every customer.
            {
                CustForListBox.Add(Cust.CustomerID + " - " + Cust.CustomerForename + " " + Cust.CustomerSurname);
            }
            listBoxCustomers.DataSource = CustForListBox;

            listBoxCustomers.SelectedIndex = 1;
            listBoxCustomers.SelectedIndex = 0;
        }

        private void addTableColumn() //adds columns to the data grid.
        {
            table = new DataTable();

            table.Columns.Add("Training ID");
            table.Columns.Add("Training Type");
            table.Columns.Add("Age Class");
            table.Columns.Add("Start Date");
            table.Columns.Add("End Date");
            table.Columns.Add("Staff Member");
            table.Columns.Add("Places Available");     
        }

        private void populateTable() //fills the data grid with information about each training class including the amount of places remaining
        {
            foreach (Training Class in TrainingList)
            {
                numberBookedInt = 0;
                foreach (Bookings Book in BookingList) //calculates how many bookings have been made for this class.
                {
                    if (Book.TrainingID == Class.TrainingID && Book.Archive == false)
                    {
                        numberBookedInt++;
                    }
                }
                numberBooked.Add(numberBookedInt);
                numberBooked[Class.TrainingID - 1] = numberBookedInt;         
            }

            try
            {
                foreach (Training Class in TrainingList)
                {
                    breakTrue = false;
                    foreach (Staff Staff in StaffList) //populates the datagrid with information about available training classes.
                    {
                        if (Class.StaffID == Staff.StaffID && Class.StartDate > DateTime.Now)
                        {
                            table.Rows.Add(Class.TrainingID, Class.TrainingType, Class.AgeClass, Class.StartDate.ToShortDateString(), Class.EndDate.ToShortDateString(), Staff.StaffForename + " " + Staff.StaffSurname, 10 - numberBooked[Class.TrainingID - 1]);
                        }      
                        else if (Class.StaffID == Staff.StaffID && numberBooked[Class.TrainingID -1 ] == 0 && Class.StartDate > DateTime.Now)
                        {
                            table.Rows.Add(Class.TrainingID, Class.TrainingType, Class.AgeClass, Class.StartDate.ToShortDateString(), Class.EndDate.ToShortDateString(), Staff.StaffForename + " " + Staff.StaffSurname, 10 - numberBooked[Class.TrainingID - 1]);
                        }                      
                    }
                }
            }
            catch
            {

            }
            dataViewTraining.DataSource = table;
            dataViewTraining.Refresh();                   
        }

        private void btnTraining_Click(object sender, EventArgs e)
        {
            Form Form1 = new TrainingMenu(db);
            this.Close();
            Form1.Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form Form1 = new TrainingMenu(db);
            this.Close();
            Form1.Show();
        }

        private void btnLoadDog_Click(object sender, EventArgs e)
        {
            
        }


        private void cmbSelectDog_SelectedIndexChanged(object sender, EventArgs e) //populates the form with information about dog along with displaying its eligibility for an advanced training class.
        {
            validBooking = false;
            cmbTrainType.Enabled = true;
            selectedDogID = cmbSelectDog.Text;
            cmbTrainType.SelectedIndex = -1;
            cmbSelectTraining.SelectedIndex = -1;
            cmbTrainType.ResetText();
            cmbSelectTraining.ResetText();
            txtStaffName.Text = "";
            txtStartDate.Text = "";
            txtEndDate.Text = "";

            foreach (Dogs Dog in DogsList)
            {
                checkString = Dog.DogID + " - " + Dog.DogName;
                if (checkString == selectedDogID)
                {
                    txtDOB.Text = Convert.ToString(Dog.DateOfBirth);
                    switch (Dog.BasicTrainingComplete)
                    {
                        case true:
                            lblAdvancedEligible.Visible = true;
                            lblAdvancedEligible.ForeColor = Color.Green;
                            lblAdvancedEligible.Text = "This Dog is eligible for advanced training"; //the user is told if the selected dog is eligible for advanced training.

                            cmbTrainType.Items.Clear();
                            cmbTrainType.Items.Add("Basic");
                            cmbTrainType.Items.Add("Advanced");
                            cmbTrainType.Refresh();
                            break;

                        case false:
                            lblAdvancedEligible.Visible = true;
                            lblAdvancedEligible.ForeColor = Color.Red;
                            lblAdvancedEligible.Text = "This dog is not eligible for advanced training";

                            cmbTrainType.Items.Clear();
                            cmbTrainType.Items.Add("Basic");
                            cmbTrainType.Refresh();
                            break;
                    }
                    foreach (Customers customer in CustomersList)
                    {
                        if (customer.CustomerID == Dog.CustomerID)
                        {
                            txtOwner.Text = customer.CustomerID + " - " + customer.CustomerForename + " " + customer.CustomerSurname;
                        }
                    }

                    int age = 0; //displays the age of the dog on the form, so the user knows if the dog will be eligible for classes suitable for over or under 5 years old.
                    age = DateTime.Now.Year - Dog.DateOfBirth.Year;
                    if (DateTime.Now.DayOfYear < Dog.DateOfBirth.DayOfYear - 1)
                    {
                        age = age - 1;
                    }

                    if (DateTime.Now == Dog.DateOfBirth.AddYears(-1))
                    {
                        age = 1;
                    }
                    txtAge.Text = Convert.ToString(age);
                }
            }
        }

        private void cmbSelectTraining_SelectedIndexChanged(object sender, EventArgs e) //checks if the selected dog is eligible for the selected class.
        {
            TrainingIDForBooking = null;
            digitCounter = 0;
            foreach (char Character in cmbSelectTraining.Text)
            {
                if (digitCounter <=3)
                {
                    if (Char.IsNumber(Character))
                    {
                        TrainingIDForBooking += Character;                        
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
                string comparisonText = cmbSelectTraining.Text.Substring(2, cmbSelectTraining.Text.Length - 13);
                switch (comparisonText.Trim())
                {
                    case "- Basic - Under 5 Years -":       //if the dog is over 5 years, the user is informed that the dog cannot be booked for this class.
                    case "Basic = Under 5 Years -":
                        if (Convert.ToInt32(txtAge.Text) >= 5)
                        {
                            MessageBox.Show("This Dog is too old for this Class. Please select another Class.");
                            cmbSelectTraining.Text = "Select Training Class.";
                            validBooking = false;
                        }
                        else
                        {
                            validBooking = true;        //if the dog is eligible for the selected class, the cost is caluclated and displayed on the form
                            lblClassCost.Text = ("Cost of Chosen Class: £25");
                            lblEstimatedCostLabel.Text = "Estimated Total Cost: £45";
                            lblClassBeforeDiscount.Text = "Cost Before Discount: £45";
                            if (CustBookedBefore == true)
                            {
                                lblEstimatedCostLabel.Text = "Estimated Total Cost: £40";
                            }
                            
                        }
                        break;

                    case "- Basic - 5 Years+ -":        //if the dog is under 5 years, the user is informed that the dog is not eligible for this class.
                    case "Basic - 5 Years+ -":
                        if (Convert.ToInt32(txtAge.Text) < 5)
                        {
                            MessageBox.Show("This Dog is too young for this Class. Please select another Class.");
                            cmbSelectTraining.Text = "Select Training Class.";
                            validBooking = false;
                        }
                        else
                        {
                            validBooking = true;        //if the dog is eligible for the selected class, the cost is caluclated and displayed on the form
                            lblClassCost.Text = ("Cost of Chosen Class: £25");
                            lblEstimatedCostLabel.Text = "Estimated Total Cost: £45";
                            lblClassBeforeDiscount.Text = "Cost Before Discount: £45";
                            if (CustBookedBefore == true)
                            {
                                lblEstimatedCostLabel.Text = "Estimated Total Cost: £40";
                            }
                        }
                        break;

                    case "- Advanced - 1 Year+ -":      
                    case "Advanced - 1 Year+ -":
                        DogIDForTraining = null;
                        digitCounter = 0;
                        foreach (char Character in selectedDogID)
                        {
                            if (Char.IsNumber(Character) && digitCounter <= 3)
                            {
                                DogIDForTraining += Character;                                
                            }
                            digitCounter++;
                        }
                        foreach (Dogs Dog in DogsList)
                        {
                            if (Convert.ToString(Dog.DogID) == DogIDForTraining)
                            {
                                if (Dog.BasicTrainingComplete == false)     //if the dog is not eligible for advanced training, the user is informed that the dog cannot be booked for this class.
                                {
                                    MessageBox.Show("This dog must complete basic training before it is eligible for advanced training. Please choose another Class.");
                                    cmbSelectTraining.Text = "Select Class.";
                                    validBooking = false;
                                }
                                else
                                {
                                    validBooking = true;        //if the dog is eligible for the selected class, the cost is caluclated and displayed on the form.
                                    lblClassCost.Text = ("Cost of Chosen Class: £30");
                                    lblEstimatedCostLabel.Text = "Estimated Total Cost: £60";
                                    lblClassBeforeDiscount.Text = "Cost Before Discount: £60";
                                    if (CustBookedBefore == true)
                                    {
                                        lblEstimatedCostLabel.Text = "Estimated Total Cost: £55";
                                    }

                                }
                            }
                        }
                        break;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Please select a dog first.");
            }       
                 foreach (Staff Staff in StaffList)
                 {
                    foreach (Training Class in TrainingList)
                    {
                        if (Staff.StaffID == Class.StaffID && Class.TrainingID == Convert.ToInt16(TrainingIDForBooking))    //the staff member linked to the selected class is shown on the form.
                        {
                            txtStaffName.Text = Staff.StaffID + " - " + Staff.StaffForename + " " + Staff.StaffSurname;
                            txtStartDate.Text = Convert.ToString(Class.StartDate);
                            txtEndDate.Text = Convert.ToString(Class.EndDate);
                        }
                    } 
                }

            numberBooked.Clear();
            foreach (Training Class in TrainingList)    //checks how many bookings are made for the selected class.
            {
                numberBookedInt = 0;
                foreach (Bookings Book in BookingList)
                {
                    if (Book.TrainingID == Class.TrainingID && Book.Archive == false)
                    {
                        numberBookedInt++;
                    }
                }
                numberBooked.Add(numberBookedInt);
            }
            int numberBookedIndex = Convert.ToInt32(TrainingIDForBooking) - 1;
            if (numberBooked[numberBookedIndex] == 10) //if 10 bookings have been made for selected class it is full and can no longer be booked onto.
            {
                MessageBox.Show("This class is fully booked.\nPlease select a differnet class.");
                validBooking2 = false;
            }
            else
            {
                validBooking2 = true;
            }
        }

        private void calendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            
        }

        private void clkTrainingEnabled_Tick(object sender, EventArgs e)
        {

        }

        private void clkValidBooking_Tick(object sender, EventArgs e)
        {
            if (validBooking == true && validBooking2 == true)
            {
                btnCreateBooking.Enabled = true;
            }
            else
            {
                btnCreateBooking.Enabled = false;
            }
        }

        private void btnCreateBooking_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to create this booking?", "Create new Booking.", MessageBoxButtons.YesNo) == DialogResult.Yes)
            { //the user must confirm that they want to create the booking
                bookingCounter = 0;

                foreach (Bookings Booking in BookingList) //another check is made to see if the chosen class is already fully booked.
                {
                    if (Booking.TrainingID == Convert.ToInt32(TrainingIDForBooking) && DogsList[Booking.DogID - 1].Archive == false) 
                    {
                        bookingCounter++;
                    }

                    if (bookingCounter == 10)
                    {
                        MessageBox.Show("This class is fully booked");
                        return;
                    }
                }

                noBookIDs = 0;

                foreach (Bookings Booking in BookingList)
                {
                    if (Booking.BookingID > noBookIDs)
                    {
                        noBookIDs = Booking.BookingID;
                    }
                }
                noBookIDs += 1;

                digitCounter = 0;
                DogIDForTraining = null;
                foreach (char Character in selectedDogID)
                    if (digitCounter <= 3)
                    {
                        {
                            if (Char.IsNumber(Character))
                            {
                                DogIDForTraining += Character;
                            }
                        }
                        digitCounter++;
                    }

                try
                {
                    validFlag = true;

                    foreach (Bookings Booking in BookingList)
                    {
                        if (Booking.TrainingID == Convert.ToInt32(TrainingIDForBooking) && Booking.DogID == Convert.ToInt32(DogIDForTraining))
                        {
                            MessageBox.Show("This booking already exists."); //if a booking is found that uses the same training and dog id, the user is informed that the booking already exists.
                            validFlag = false;
                            break;
                        }
                    }
                    if (validFlag == true)  //the data entered by the user is added to the database as a new record in the booking table given all other validations have passed.
                    {
                        db.Cmd = db.Conn.CreateCommand();
                        db.Cmd.CommandText = "INSERT INTO Bookings (BookingID, TrainingID, DogID, Archive, BookingCost) VALUES (" + noBookIDs + ", " + TrainingIDForBooking + ", " + DogIDForTraining + ", " + 0 + ", " + lblEstimatedCostLabel.Text.Substring(lblEstimatedCostLabel.Text.Length - 2) + ")";
                        db.Cmd.ExecuteNonQuery();

                        MessageBox.Show("Booking Created.");
                        Form Form1 = new CreateBooking(db);
                        Form1.Show();
                        this.Close();
                    }
                }
                catch 
                {
                    MessageBox.Show("Error when creating booking.");
                }
            }            
        }

        private void lblTrainType_Click(object sender, EventArgs e)
        {

        }

        private void cmbTrainType_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbSelectTraining.Items.Clear();
            cmbSelectTraining.Enabled = true;
            cmbSelectTraining.Text = "Select Class";
            txtStartDate.Text = " ";
            txtEndDate.Text = " ";
            validBooking = false;        

            switch (cmbTrainType.Text)
            {
                case "Basic":
                    foreach (Training Class in TrainingList)
                    {
                        if (DateTime.Now.CompareTo(Class.StartDate) > 0)    //the classes shown in the "training class" text box are filtered based on the dogs age and if the user has chosen basic or advanced.
                        {

                        }
                        else if (Class.TrainingType == "Basic" && Class.AgeClass == "5 Years+" && Convert.ToInt16(txtAge.Text) >= 5)
                        {
                            cmbSelectTraining.Items.Add(Class.TrainingID + " - " + Class.TrainingType + " - " + Class.AgeClass + " - " + Class.StartDate.ToString("dd/MM/yyyy"));
                        }
                        else if (Class.TrainingType == "Basic" && Class.AgeClass == "Under 5 Years" && Convert.ToInt16(txtAge.Text) < 5)
                        {
                            cmbSelectTraining.Items.Add(Class.TrainingID + " - " + Class.TrainingType + " - " + Class.AgeClass + " - " + Class.StartDate.ToString("dd/MM/yyyy"));
                        }
                        lblDepositAmount.Text = ("Deposit Amount: £20"); //the deposit amount is set based on if the class is basic or advanced.
                    }
                    break;

                case "Advanced":                   
                    foreach (Training Class in TrainingList)
                    {
                        if (DateTime.Now.CompareTo(Class.StartDate) > 0)
                        {

                        }
                        else if (Class.TrainingType == "Advanced")
                        {
                            cmbSelectTraining.Items.Add(Class.TrainingID + " - " + Class.TrainingType + " - " + Class.AgeClass + " - " + Class.StartDate.ToString("dd/MM/yyyy"));
                        }
                        lblDepositAmount.Text = ("Deposit Amount: £30"); //the deposit amount is set based on if the class is basic or advanced.
                    }
                    break;
            }
        }

        private void CreateBooking_Load(object sender, EventArgs e)
        {
            int i2 = 0; //the user is not able to click on the data grid to sort the classes, this caused issues with the colour code system.
            do
            {
                dataViewTraining.Columns[i2].SortMode = DataGridViewColumnSortMode.NotSortable;
                i2++;
            }
            while (i2 < 7);

            int i = 0;
            foreach (Training Class in TrainingList) //the 'places avaialble' cells are colour coded based on how many spaces are left in each class.
            {
                if (Class.StartDate > DateTime.Now)
                {
                    switch (numberBooked[Class.TrainingID - 1])
                    {
                        case 0:
                        case 1:
                        case 2:
                        case 3:
                            dataViewTraining.Rows[i].Cells[6].Style.BackColor = Color.LimeGreen;
                            break;

                        case 4:
                        case 5:
                        case 6:
                            dataViewTraining.Rows[i].Cells[6].Style.BackColor = Color.Yellow;
                            break;

                        case 7:
                        case 8:
                        case 9:
                            dataViewTraining.Rows[i].Cells[6].Style.BackColor = Color.Red;
                            break;

                        case 10:
                            dataViewTraining.Rows[i].Cells[6].Style.BackColor = Color.DodgerBlue;
                            break;
                    }
                    i++;
                }
            }
        }

        private void listBoxCustomers_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbSelectDog.Enabled = true;

            lblClassCost.Text = "Cost of Chosen Class:";            //all of the cost information is reset as choosing the customer is the first stage in creating a booking.
            lblCustLoyalty.Text = "Customer Loyalty Discount:";
            lblClassBeforeDiscount.Text = "Cost Before Discount:";
            lblEstimatedCostLabel.Text = "Estimated Total Cost: ";
            cmbSelectDog.Text = "";

            try
            {
                string input = listBoxCustomers.SelectedItem.ToString();
                input = input.Substring(0, input.IndexOf("-")).Replace(" ", "");
                input = Convert.ToString(Convert.ToInt32(input) - 1);

                lblDepositAmount.Text = "Deposit Amount:";
                lblClassCost.Text = "Cost of Chosen Class:";
                lblEstimatedCostLabel.Text = "Estimated Total Cost:";

                lblAdvancedEligible.Visible = false;

                cmbSelectDog.Items.Clear();
                foreach (Dogs Dog in DogsList)
                {   //dogs are filtered into the dog drop-down list based on which customer has been selected.
                    if (Dog.CustomerID == CustomersList[Convert.ToInt32(input)].CustomerID && Dog.Archive == false)
                    {
                        cmbSelectDog.Items.Add(Dog.DogID + " - " + Dog.DogName);
                    }
                }

                CustomerLoyaltyCheck(CustomersList[Convert.ToInt32(input)].CustomerID); //if the customer has a previous booking in the system they are able to recieve a discount of £5.

                if (CustBookedBefore == true)
                {
                    lblCustLoyalty.Text = "Customer Loyalty Discount: -£5";
                }
                else
                {
                    lblCustLoyalty.Text = "Customer Loyalty Discount: £0";
                }

                cmbSelectDog.Refresh();

                txtAge.Text = "";       //all information about the booking that may have been previously stored is cleared as a new booking is going to be created.
                txtDOB.Text = "";
                txtOwner.Text = "";
                cmbTrainType.Text = "";
                cmbTrainType.Refresh();
                cmbTrainType.Enabled = false;
                cmbSelectTraining.Text = "";
                cmbSelectTraining.Refresh();
                cmbSelectTraining.Enabled = false;
                txtStaffName.Text = "";
                txtEndDate.Text = "";
                txtStartDate.Text = "";
                validBooking = false;
                validBooking2 = false;

            }
            catch
            {

            }
        }

        private void CustomerLoyaltyCheck(int CustID)   //checks if the customer has previously made a booking.
        {
            CustBookedBefore = false;

            foreach(Dogs Dog in DogsList)
            {
                if (Dog.CustomerID == CustID)
                {
                    foreach (Bookings Book in BookingList)
                    {
                        if (Book.DogID == Dog.DogID)
                        {
                            CustBookedBefore = true;
                            break;
                        }
                        else
                        {
                            CustBookedBefore = false;
                        }
                    }
                }
            }
            
        }

        private void txtFilterCustomers_TextChanged(object sender, EventArgs e) //the user is able to search through the customers list box using the customer's last name.
        {
            int checkLength = txtFilterCustomers.Text.Length;

            CustForListBox.Clear();

            foreach (Customers Cust in CustomersList)
            {
                if (Cust.CustomerSurname.Length >= txtFilterCustomers.Text.Length)
                {
                    if (Cust.CustomerSurname.Substring(0, checkLength).ToLower() == txtFilterCustomers.Text.ToLower())
                    {
                        CustForListBox.Add(Cust.CustomerID + " - " + Cust.CustomerForename + " " + Cust.CustomerSurname);
                    }
                }
            }
            listBoxCustomers.DataSource = null;
            listBoxCustomers.DataSource = CustForListBox;   //the customers shown on the list box depend on what has been entered in the text box above.

            if (txtFilterCustomers.Text == "")  //if the text box is empty then all customers are shown in the list box again.
            {
                foreach (Customers Cust in CustomersList)
                {
                    CustForListBox.Add(Cust.CustomerID + " - " + Cust.CustomerForename + " " + Cust.CustomerSurname);
                }
                listBoxCustomers.DataSource = CustForListBox;
                listBoxCustomers.Refresh();
            }
        }

        private void dataViewTraining_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtAge_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbSelectDog_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }

        private void cmbSelectDog_MouseClick(object sender, MouseEventArgs e)
        {
            cmbSelectDog.DroppedDown = true;
        }

        private void cmbTrainType_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }

        private void cmbSelectTraining_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }

        private void cmbTrainType_MouseClick(object sender, MouseEventArgs e)
        {
            cmbTrainType.DroppedDown = true;
        }

        private void cmbSelectTraining_MouseClick(object sender, MouseEventArgs e)
        {
            cmbSelectTraining.DroppedDown = true;
        }
    }
}

