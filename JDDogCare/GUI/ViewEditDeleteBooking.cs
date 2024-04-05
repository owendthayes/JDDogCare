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
    public partial class ViewEditDeleteBooking : MasterForm
    {
        Database db;
        DataTable table; 

        bool bookingExistsFlag = false;
        bool ClassFull = false;

        string dogIDForDelete;
        string trainIDForDelete;
        string searchBookingCriteria;
        string CustIDFromTextBox;

        int dogIDIndex;
        int trainIDIndex;
        int digitCounter;

        List<string> searchStartDateList = new List<string>();
        List<int> ClassBookFrequency = new List<int>();

        List<Dogs> DogsList = new List<Dogs>();
        List<Customers> CustomersList = new List<Customers>();
        List<Staff> StaffList = new List<Staff>();
        List<Training> TrainingList = new List<Training>();
        List<Bookings> BookingList = new List<Bookings>();
     

        public ViewEditDeleteBooking(Database db)
        {
            InitializeComponent();

            this.db = db;

            BookingDBAccess BookDBA = new BookingDBAccess(db);
            DogsDBAccess DogsDBA = new DogsDBAccess(db);
            StaffDBAccess StaffDBA = new StaffDBAccess(db);
            TrainingDBAccess TrainDBA = new TrainingDBAccess(db);
            CustomersDBAccess CustDBA = new CustomersDBAccess(db);

            DogsList = DogsDBA.getAllDogs();
            CustomersList = CustDBA.getAllCustomers();
            StaffList = StaffDBA.getAllStaff();
            TrainingList = TrainDBA.getAllTraining();
            BookingList = BookDBA.getAllBookings();

            updateBookings();
            addTableColumn();
            populateTable();
            dataBookings.DataSource = table;
        }

        private void addTableColumn()   //columns are added to the datagrid.
        {
            table = new DataTable();

            table.Columns.Add("Booking ID");
            table.Columns.Add("Dog ID");
            table.Columns.Add("Dog Name");
            table.Columns.Add("Customer ID");
            table.Columns.Add("Customer Forename");
            table.Columns.Add("Customer Surname");
            table.Columns.Add("Training ID");
            table.Columns.Add("Training Type");
            table.Columns.Add("Age Class");
            table.Columns.Add("Start Date");
            table.Columns.Add("End Date");
            table.Columns.Add("Staff ID");
            table.Columns.Add("Staff Forename");
            table.Columns.Add("Staff Surname");
        }

        private void populateTable() //the data grid is populated with information about each booking using the fields shown above.
        {
            foreach (Bookings Book in BookingList)
            {
                foreach (Dogs Dog in DogsList)
                {
                    foreach (Training Class in TrainingList)
                    {
                        foreach (Customers Customer in CustomersList)
                        {
                            foreach (Staff Staff in StaffList)
                            {
                                if (Dog.DogID == Book.DogID && Dog.Archive == false && Book.Archive == false && Dog.CustomerID == Customer.CustomerID && Book.TrainingID == Class.TrainingID && Class.StaffID == Staff.StaffID)
                                {
                                    table.Rows.Add(Book.BookingID, Dog.DogID, Dog.DogName, Customer.CustomerID, Customer.CustomerForename, Customer.CustomerSurname, Class.TrainingID, Class.TrainingType, Class.AgeClass, Class.StartDate.ToShortDateString(), Class.EndDate.ToShortDateString(), Staff.StaffID, Staff.StaffForename, Staff.StaffSurname);
                                }
                            }
                        }
                    }
                }
            }
        }

        private void dataBookings_CellClick(object sender, DataGridViewCellEventArgs e) //if the user clicks on the cell of one of the booking records, the information about the booking is displayed on the form in the text boxes.
        {
            try
            {
                cmbTraining.Enabled = true;
                cmbDog.Enabled = true;

                cmbTraining.Items.Clear();
                cmbDog.Items.Clear();

                if (e.RowIndex >= 0)
                {
                    string BookingID = Convert.ToString(dataBookings.Rows[e.RowIndex].Cells["Booking ID"].FormattedValue);
                    txtBookingID.Text = BookingID;

                    string DogID = Convert.ToString(dataBookings.Rows[e.RowIndex].Cells["Dog ID"].FormattedValue);
                    string DogName = Convert.ToString(dataBookings.Rows[e.RowIndex].Cells["Dog Name"].FormattedValue);
                    cmbDog.Text = DogID + " - " + DogName;

                    string CustID = Convert.ToString(dataBookings.Rows[e.RowIndex].Cells["Customer ID"].FormattedValue);
                    string CustFName = Convert.ToString(dataBookings.Rows[e.RowIndex].Cells["Customer Forename"].FormattedValue);
                    string CustSName = Convert.ToString(dataBookings.Rows[e.RowIndex].Cells["Customer Surname"].FormattedValue);
                    txtCustomer.Text = CustID + " - " + CustFName + " " + CustSName;

                    string TrainingID = Convert.ToString(dataBookings.Rows[e.RowIndex].Cells["Training ID"].FormattedValue);
                    string TrainingType = Convert.ToString(dataBookings.Rows[e.RowIndex].Cells["Training Type"].FormattedValue);
                    string TrainingAge = Convert.ToString(dataBookings.Rows[e.RowIndex].Cells["Age Class"].FormattedValue);
                    string TrainingStartDate = Convert.ToString(dataBookings.Rows[e.RowIndex].Cells["Start Date"].FormattedValue);
                    string TrainingEndDate = Convert.ToString(dataBookings.Rows[e.RowIndex].Cells["End Date"].FormattedValue);
                    cmbTraining.Text = TrainingID + " - " + TrainingType + " - " + TrainingAge + " - " + TrainingStartDate;


                    txtStartDate.Text = TrainingStartDate;
                    txtEndDate.Text = TrainingEndDate;

                    digitCounter = 0;
                    dogIDForDelete = null;
                    trainIDForDelete = null;
                    CustIDFromTextBox = null;

                    foreach (char Character in cmbDog.Text)
                    {
                        if (digitCounter <= 3)
                        {
                            if (Char.IsNumber(Character))
                            {
                                dogIDForDelete += Character;
                            }
                            digitCounter++;
                        }
                        else
                        {
                            break;
                        }
                    }

                    digitCounter = 0;
                    foreach (char Character in cmbTraining.Text)
                    {
                        if (digitCounter <= 3)
                        {
                            if (Char.IsNumber(Character))
                            {
                                trainIDForDelete += Character;
                            }
                            digitCounter++;
                        }
                        else
                        {
                            break;
                        }
                    }
                }

                digitCounter = 0;
                foreach (char Character in txtCustomer.Text)
                {
                    if (digitCounter <= 3)
                    {
                        if (Char.IsNumber(Character))
                        {
                            CustIDFromTextBox += Character;
                        }
                        digitCounter++;
                    }
                    else
                    {
                        break;
                    }
                }

                foreach (Dogs Dog in DogsList)  //all dogs belonging to the customer associated with the booking are displayed in the dogs drop down list.
                {
                    if (Dog.Archive == false && Convert.ToInt32(CustIDFromTextBox) == Dog.CustomerID)
                    {
                        cmbDog.Items.Add(Dog.DogID + " - " + Dog.DogName);
                    }
                    cmbDog.Refresh();
                }

                if (DogsList[Convert.ToInt16(dogIDForDelete) - 1].BasicTrainingComplete == true)    //training classes are shown in the training class drop-down list based on the currnetly selected class.
                {

                    foreach (Training Class in TrainingList)
                    {
                        if (Class.TrainingType == "Advanced")
                        {
                            cmbTraining.Items.Add(Class.TrainingID + " - " + Class.TrainingType + " - " + Class.AgeClass + " - " + Class.StartDate.ToShortDateString());
                        }
                    }
                }

                if (DogsList[Convert.ToInt16(dogIDForDelete) - 1].DateOfBirth <= DateTime.Now.AddYears(-5))
                {
                    foreach (Training Class in TrainingList)
                    {
                        if (Class.AgeClass == "5 Years+")
                        {
                            cmbTraining.Items.Add(Class.TrainingID + " - " + Class.TrainingType + " - " + Class.AgeClass + " - " + Class.StartDate.ToShortDateString());
                        }
                    }
                }

                if (DogsList[Convert.ToInt16(dogIDForDelete) - 1].DateOfBirth >= DateTime.Now.AddYears(-5))
                {
                    foreach (Training Class in TrainingList)
                    {
                        if (Class.AgeClass == "Under 5 Years")
                        {
                            cmbTraining.Items.Add(Class.TrainingID + " - " + Class.TrainingType + " - " + Class.AgeClass + " - " + Class.StartDate.ToShortDateString());
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("A booking must be selected.");
            }           
        }

        private void updateBookings()   //if the start date of a class has passed, all associated bookings are archived.
        {
            foreach (Training Class in TrainingList)
            {
                foreach (Bookings Book in BookingList)
                {
                    if (Class.TrainingID == Book.TrainingID && Class.StartDate <= DateTime.Now)
                    {
                        db.Conn.CreateCommand();
                        db.Cmd.CommandText = "UPDATE Bookings SET Archive = 1 WHERE BookingID = " + Book.BookingID;
                        db.Cmd.ExecuteNonQuery();
                    }
                }
            }
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

        private void ViewEditDeleteBooking_Load(object sender, EventArgs e)
        {
            updateBookings();
        }

        private void btnDelete_Click(object sender, EventArgs e) //if the booking is set to happen in the future, the booking is deleted whereas if it is in the past the booking is archived instead.
        {
            try
            {
                dogIDForDelete = null;
                trainIDForDelete = null;

                digitCounter = 0;

                if (MessageBox.Show("Are you sure you want to archive this booking?", "Archive Booking", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (Convert.ToDateTime(txtStartDate.Text) > DateTime.Now)
                    {
                        MessageBox.Show("As this booking is in the future, it will be deleted and not archived.");
                        foreach (char Character in cmbDog.Text)
                        {
                            if (digitCounter <= 3)
                            {
                                if (Char.IsNumber(Character))
                                {
                                    dogIDForDelete += Character;
                                }
                                digitCounter++;
                            }
                            else
                            {
                                break;
                            }
                        }

                        digitCounter = 0;
                        foreach (char Character in cmbTraining.Text)
                        {
                            if (digitCounter <= 3)
                            {
                                if (Char.IsNumber(Character))
                                {
                                    trainIDForDelete += Character;
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
                            foreach (Bookings Book in BookingList)  //BOOKING DELETED
                            {
                                if (Convert.ToString(Book.DogID) == dogIDForDelete && Convert.ToString(Book.TrainingID) == trainIDForDelete)
                                {
                                    db.Conn.CreateCommand();
                                    db.Cmd.CommandText = "DELETE FROM Bookings WHERE DogID = " + dogIDForDelete + "AND TrainingID = " + trainIDForDelete;
                                    db.Cmd.ExecuteNonQuery();

                                    MessageBox.Show("Booking Deleted.");

                                    Form Form1 = new ViewEditDeleteBooking(db);
                                    Form1.Show();
                                    this.Close();
                                }
                            }
                        }
                        catch
                        {
                            MessageBox.Show("You must select a booking to archive first.");
                        }
                    }
                    else
                    {
                        foreach (char Character in cmbDog.Text)
                        {
                            if (digitCounter <= 3)
                            {
                                if (Char.IsNumber(Character))
                                {
                                    dogIDForDelete += Character;
                                }
                                digitCounter++;
                            }
                            else
                            {
                                break;
                            }
                        }

                        digitCounter = 0;
                        foreach (char Character in cmbTraining.Text)
                        {
                            if (digitCounter <= 3)
                            {
                                if (Char.IsNumber(Character))
                                {
                                    trainIDForDelete += Character;
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
                            foreach (Bookings Book in BookingList) //BOOKING ARCHIVED
                            {
                                if (Convert.ToString(Book.DogID) == dogIDForDelete && Convert.ToString(Book.TrainingID) == trainIDForDelete)
                                {
                                    db.Conn.CreateCommand();
                                    db.Cmd.CommandText = "UPDATE Bookings SET Archive = @Archive WHERE DogID = " + dogIDForDelete + "AND TrainingID = " + trainIDForDelete;
                                    db.Cmd.Parameters.AddWithValue("@Archive", 1);
                                    db.Cmd.ExecuteNonQuery();

                                    MessageBox.Show("Booking Archived.");

                                    Form Form1 = new ViewEditDeleteBooking(db);
                                    Form1.Show();
                                    this.Close();
                                }
                            }
                        }
                        catch
                        {
                            MessageBox.Show("You must select a booking to archive first.");
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("A booking must be selected.");
            }
        }           
        
        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            try
            {
                dogIDForDelete = null;
                trainIDForDelete = null;
                digitCounter = 0;
                if (MessageBox.Show("Are you sure you want to save the changes made on this booking?", "Save Changes", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    foreach (char Character in cmbDog.Text)
                    {
                        if (digitCounter <= 3)
                        {
                            if (Char.IsNumber(Character))
                            {
                                dogIDForDelete += Character;
                            }
                            digitCounter++;
                        }
                        else
                        {
                            break;
                        }
                    }

                    digitCounter = 0;
                    foreach (char Character in cmbTraining.Text)
                    {
                        if (digitCounter <= 3)
                        {
                            if (Char.IsNumber(Character))
                            {
                                trainIDForDelete += Character;
                            }
                            digitCounter++;
                        }
                        else
                        {
                            break;
                        }
                    }

                    dogIDIndex = Convert.ToInt32(dogIDForDelete) - 1;
                    trainIDIndex = Convert.ToInt32(trainIDForDelete) - 1;

                    int age = 0;
                    age = DateTime.Now.Year - DogsList[dogIDIndex].DateOfBirth.Year;
                    if (DateTime.Now.DayOfYear < DogsList[dogIDIndex].DateOfBirth.DayOfYear)
                    {
                        age = age - 1;
                    }

                    if (ClassFull == false)
                    {
                        foreach (Bookings Book in BookingList)  //checks to see if the new information entered would result in a duplication.
                        {
                            bookingExistsFlag = false;
                            try
                            {
                                if (Book.BookingID == Convert.ToInt32(txtBookingID.Text))
                                {
                                    if (TrainingList[trainIDIndex].AgeClass == "Under 5 Years")
                                    {
                                        if (age < 5)    //checks that the dog is the correct age for this class.
                                        {
                                            foreach (Bookings Booking in BookingList)
                                            {
                                                if (trainIDForDelete == Convert.ToString(Booking.TrainingID) && dogIDForDelete == Convert.ToString(Booking.DogID))
                                                {
                                                    bookingExistsFlag = true;
                                                    MessageBox.Show("This booking already exists.\nChanges have not been saved.");
                                                    break;
                                                }
                                            }

                                            if (bookingExistsFlag == false) //booking is updated to reflect the changes the user has made.
                                            {
                                                db.Conn.CreateCommand();
                                                db.Cmd.CommandText = "UPDATE Bookings SET TrainingID = " + trainIDForDelete + " , DogID = " + dogIDForDelete + " WHERE BookingID = " + Book.BookingID;
                                                db.Cmd.ExecuteNonQuery();

                                                MessageBox.Show("Changes saved.");

                                                Form Form1 = new ViewEditDeleteBooking(db);
                                                Form1.Show();
                                                this.Close();
                                            }
                                        }
                                        else
                                        {
                                            MessageBox.Show("This dog is too old for this class.\nChanges have not been saved.");
                                        }
                                    }

                                    else if (TrainingList[trainIDIndex].AgeClass == "5 Years+") //checks to see if the new information entered would result in a duplication.
                                    {
                                        if (age >= 5) //checks that the dog is the correct age for this class.
                                        {
                                            foreach (Bookings Booking in BookingList)
                                            {
                                                if (trainIDForDelete == Convert.ToString(Booking.TrainingID) && dogIDForDelete == Convert.ToString(Booking.DogID))
                                                {
                                                    bookingExistsFlag = true;
                                                    MessageBox.Show("This booking already exists.\nChanges have not been saved.");
                                                    break;
                                                }
                                            }

                                            if (bookingExistsFlag == false) //booking is updated to reflect the changes the user has made.
                                            {
                                                db.Conn.CreateCommand();
                                                db.Cmd.CommandText = "UPDATE Bookings SET TrainingID = " + trainIDForDelete + " , DogID = " + dogIDForDelete + " WHERE BookingID = " + Book.BookingID;
                                                db.Cmd.ExecuteNonQuery();

                                                MessageBox.Show("Changes saved.");

                                                Form Form1 = new ViewEditDeleteBooking(db);
                                                Form1.Show();
                                                this.Close();
                                            }
                                        }
                                        else
                                        {
                                            MessageBox.Show("This dog is too young for this class.\nChanges have not been saved.");
                                        }
                                    }

                                    else if (TrainingList[trainIDIndex].AgeClass == "1 Year+") 
                                    {
                                        if (DogsList[Convert.ToInt32(dogIDForDelete) - 1].BasicTrainingComplete == true && age >= 1)
                                        {
                                            foreach (Bookings Booking in BookingList)
                                            {
                                                if (trainIDForDelete == Convert.ToString(Booking.TrainingID) && dogIDForDelete == Convert.ToString(Booking.DogID)) //checks to see if the new information entered would result in a duplication.
                                                {
                                                    bookingExistsFlag = true;
                                                    MessageBox.Show("This booking already exists.\nChanges have not been saved.");
                                                    break;
                                                }
                                            }

                                            if (bookingExistsFlag == false) //booking is updated to reflect the changes the user has made.
                                            {
                                                db.Conn.CreateCommand();
                                                db.Cmd.CommandText = "UPDATE Bookings SET TrainingID = " + trainIDForDelete + " , DogID = " + dogIDForDelete + " WHERE BookingID = " + Book.BookingID;
                                                db.Cmd.ExecuteNonQuery();

                                                MessageBox.Show("Changes saved.");

                                                Form Form1 = new ViewEditDeleteBooking(db);
                                                Form1.Show();
                                                this.Close();
                                            }
                                        }
                                        else
                                        {
                                            MessageBox.Show("This dog is not eligible for this training class.\nChanges have not been saved.");
                                        }
                                    }
                                }
                            }
                            catch
                            {
                                
                            }
                        }
                    } 
                    else
                    {
                        MessageBox.Show("The Selected class is full.\nChanges have not been saved.");
                    }                
                }
            }
            catch
            {

            }         
        }

        private void cmbSearchBook_SelectedIndexChanged(object sender, EventArgs e) //decides what field the criteria in the text box will search through.
        {
            txtSearchBook.Text = "";
            cmbSearchDate.Text = "";
            cmbSearchDate.Items.Clear();

            if (cmbSearchBook.Text == "Start Date")
            {
                txtSearchBook.Visible = false;
                cmbSearchDate.Visible = true;

                foreach (Training Class in TrainingList)
                {
                    if (Class.StartDate > DateTime.Now)
                    {
                        searchStartDateList.Add(Class.StartDate.ToShortDateString());
                    }
                }

                for (int i = 0; i < searchStartDateList.Count; i++)
                {
                    if (!cmbSearchDate.Items.Contains(searchStartDateList[i]))
                    {
                        cmbSearchDate.Items.Add(searchStartDateList[i]);
                    }
                }
            }

            else if (cmbSearchBook.Text == "Training Type")
            {
                txtSearchBook.Visible = false;
                cmbSearchDate.Visible = true;

                cmbSearchDate.Items.Add("Basic");
                cmbSearchDate.Items.Add("Advanced");
            }

            else if (cmbSearchBook.Text == "Training Age Class")
            {
                txtSearchBook.Visible = false;
                cmbSearchDate.Visible = true;

                cmbSearchDate.Items.Add("Under 5 Years");
                cmbSearchDate.Items.Add("5 Years+");
                cmbSearchDate.Items.Add("1 Year+");
            }

            else
            {
                txtSearchBook.Visible = true;
                cmbSearchDate.Visible = false;

                table.Rows.Clear();
                populateTable();
            }


        }

        private void txtSearchBook_TextChanged(object sender, EventArgs e) //depending on what field the user is searching by, the table is updated using the criteria the user has entered.
        {
            try
            {
                txtSearchBook.Visible = true;
                cmbSearchDate.Visible = false;

                string checkText = txtSearchBook.Text;
                int checkLength = txtSearchBook.Text.Length;

                searchBookingCriteria = txtSearchBook.Text;

                switch (cmbSearchBook.Text)
                {
                    case "Booking ID":
                        table.Rows.Clear();

                        foreach (Bookings Book in BookingList)
                        {
                            foreach (Dogs Dog in DogsList)
                            {
                                foreach (Training Class in TrainingList)
                                {
                                    foreach (Customers Customer in CustomersList)
                                    {
                                        foreach (Staff Staff in StaffList)
                                        {
                                            if (Convert.ToString(Book.BookingID) == txtSearchBook.Text)
                                            {
                                                if (Dog.DogID == Book.DogID && Book.Archive == false && Dog.CustomerID == Customer.CustomerID && Book.TrainingID == Class.TrainingID && Class.StaffID == Staff.StaffID)
                                                {
                                                    table.Rows.Add(Book.BookingID, Dog.DogID, Dog.DogName, Customer.CustomerID, Customer.CustomerForename, Customer.CustomerSurname, Class.TrainingID, Class.TrainingType, Class.AgeClass, Class.StartDate.ToShortDateString(), Class.EndDate.ToShortDateString(), Staff.StaffID, Staff.StaffForename, Staff.StaffSurname);
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                        if (txtSearchBook.Text == "")
                        {
                            table.Rows.Clear();
                            populateTable();
                        }
                        dataBookings.Refresh();
                        break;

                    case "Customer Surname":
                        table.Rows.Clear();

                        foreach (Bookings Book in BookingList)
                        {
                            foreach (Dogs Dog in DogsList)                          
                            {
                                foreach (Training Class in TrainingList)
                                {                                                   
                                    foreach (Customers Customer in CustomersList)   
                                    {
                                        if (Customer.CustomerSurname.Length >= checkLength)
                                        {
                                            foreach (Staff Staff in StaffList)
                                            {
                                                if (Customer.CustomerSurname.Substring(0, checkLength).ToLower() == txtSearchBook.Text.ToLower() || Customer.CustomerSurname.ToLower() == txtSearchBook.Text.ToLower())
                                                {
                                                    if (Dog.DogID == Book.DogID && Book.Archive == false && Dog.CustomerID == Customer.CustomerID && Book.TrainingID == Class.TrainingID && Class.StaffID == Staff.StaffID)
                                                    {
                                                        table.Rows.Add(Book.BookingID, Dog.DogID, Dog.DogName, Customer.CustomerID, Customer.CustomerForename, Customer.CustomerSurname, Class.TrainingID, Class.TrainingType, Class.AgeClass, Class.StartDate.ToShortDateString(), Class.EndDate.ToShortDateString(), Staff.StaffID, Staff.StaffForename, Staff.StaffSurname);
                                                    }
                                                }
                                            }
                                        }                                       
                                    }
                                }
                            }
                        }
                        if (txtSearchBook.Text == "")
                        {
                            table.Rows.Clear();
                            populateTable();
                        }
                        dataBookings.Refresh();
                        break;

                    case "Dog Name":
                        table.Rows.Clear();
                        foreach (Bookings Book in BookingList)
                        {
                            foreach (Dogs Dog in DogsList)
                            {
                                if (Dog.DogName.Length >= checkLength)
                                {
                                    foreach (Training Class in TrainingList)
                                    {
                                        foreach (Customers Customer in CustomersList)
                                        {
                                            foreach (Staff Staff in StaffList)
                                            {
                                                if (Dog.DogName.Substring(0, checkLength).ToLower() == txtSearchBook.Text.ToLower() || Dog.DogName.ToLower() == txtSearchBook.Text.ToLower())
                                                {
                                                    if (Dog.DogID == Book.DogID && Book.Archive == false && Dog.CustomerID == Customer.CustomerID && Book.TrainingID == Class.TrainingID && Class.StaffID == Staff.StaffID)
                                                    {
                                                        table.Rows.Add(Book.BookingID, Dog.DogID, Dog.DogName, Customer.CustomerID, Customer.CustomerForename, Customer.CustomerSurname, Class.TrainingID, Class.TrainingType, Class.AgeClass, Class.StartDate.ToShortDateString(), Class.EndDate.ToShortDateString(), Staff.StaffID, Staff.StaffForename, Staff.StaffSurname);
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }                                
                            }
                        }
                        if (txtSearchBook.Text == "")
                        {
                            table.Rows.Clear();
                            populateTable();
                        }
                        dataBookings.Refresh();
                        break;

                    case "Start Date":
                        cmbSearchDate.Visible = true;
                        txtSearchBook.Visible = false;
                        break;
                }
            }
            catch(Exception E)
            {
                MessageBox.Show(Convert.ToString(E));
            }
            
        }

        private void txtSearchBook_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void cmbSearchDate_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbSearchDate_TextUpdate(object sender, EventArgs e)
        {

        }

        private void cmbSearchDate_SelectedIndexChanged_1(object sender, EventArgs e)   //a combo boxes is used instead of a text box for fields such as Start Date and Training Type.
        {
            if (cmbSearchBook.Text == "Start Date")
            {
                string matchDate = cmbSearchDate.Text;
                table.Rows.Clear();
                foreach (Bookings Book in BookingList)
                {
                    if (Book.Archive == false)
                    {
                        if (TrainingList[Book.TrainingID - 1].StartDate.ToShortDateString() == matchDate)
                        {
                            foreach (Dogs Dog in DogsList)
                            {
                                if (Book.DogID == Dog.DogID)
                                {
                                    foreach (Training Class in TrainingList)
                                    {
                                        if (Book.TrainingID == Class.TrainingID)
                                        {
                                            foreach (Staff staff in StaffList)
                                            {
                                                if (staff.StaffID == Class.StaffID)
                                                {
                                                    foreach (Customers Cust in CustomersList)
                                                    {
                                                        if (Cust.CustomerID == Dog.CustomerID)
                                                        {
                                                            table.Rows.Add(Book.BookingID, Dog.DogID, Dog.DogName, Cust.CustomerID, Cust.CustomerForename, Cust.CustomerSurname, Class.TrainingID, Class.TrainingType, Class.AgeClass, Class.StartDate.ToShortDateString(), Class.EndDate.ToShortDateString(), staff.StaffID, staff.StaffForename, staff.StaffSurname);
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }

            else if (cmbSearchBook.Text == "Training Type")
            {
                string matchType = cmbSearchDate.Text;
                table.Rows.Clear();
                foreach (Bookings Book in BookingList)
                {
                    if (Book.Archive == false)
                    {
                        if (TrainingList[Book.TrainingID - 1].TrainingType == matchType)
                        {
                            foreach (Dogs Dog in DogsList)
                            {
                                if (Book.DogID == Dog.DogID)
                                {
                                    foreach (Training Class in TrainingList)
                                    {
                                        if (Book.TrainingID == Class.TrainingID)
                                        {
                                            foreach (Staff staff in StaffList)
                                            {
                                                if (staff.StaffID == Class.StaffID)
                                                {
                                                    foreach (Customers Cust in CustomersList)
                                                    {
                                                        if (Cust.CustomerID == Dog.CustomerID)
                                                        {
                                                            table.Rows.Add(Book.BookingID, Dog.DogID, Dog.DogName, Cust.CustomerID, Cust.CustomerForename, Cust.CustomerSurname, Class.TrainingID, Class.TrainingType, Class.AgeClass, Class.StartDate.ToShortDateString(), Class.EndDate.ToShortDateString(), staff.StaffID, staff.StaffForename, staff.StaffSurname);
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }

            else if (cmbSearchBook.Text == "Training Age Class")
            {
                string matchAge = cmbSearchDate.Text;
                table.Rows.Clear();
                foreach (Bookings Book in BookingList)
                {
                    if (Book.Archive == false)
                    {
                        if (TrainingList[Book.TrainingID - 1].AgeClass == matchAge)
                        {
                            foreach (Dogs Dog in DogsList)
                            {
                                if (Book.DogID == Dog.DogID)
                                {
                                    foreach (Training Class in TrainingList)
                                    {
                                        if (Book.TrainingID == Class.TrainingID)
                                        {
                                            foreach (Staff staff in StaffList)
                                            {
                                                if (staff.StaffID == Class.StaffID)
                                                {
                                                    foreach (Customers Cust in CustomersList)
                                                    {
                                                        if (Cust.CustomerID == Dog.CustomerID)
                                                        {
                                                            table.Rows.Add(Book.BookingID, Dog.DogID, Dog.DogName, Cust.CustomerID, Cust.CustomerForename, Cust.CustomerSurname, Class.TrainingID, Class.TrainingType, Class.AgeClass, Class.StartDate.ToShortDateString(), Class.EndDate.ToShortDateString(), staff.StaffID, staff.StaffForename, staff.StaffSurname);
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            dataBookings.Refresh();
        }

        private void txtSearchBook_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void dataBookings_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cmbDog_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }

        private void cmbDog_MouseClick(object sender, MouseEventArgs e)
        {
            cmbDog.DroppedDown = true;
        }

        private void cmbTraining_MouseClick(object sender, MouseEventArgs e)
        {
            cmbTraining.DroppedDown = true;
        }

        private void cmbTraining_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }

        private void cmbDog_SelectedIndexChanged(object sender, EventArgs e)
        {
            dogIDForDelete = null;
            digitCounter = 0;

            foreach (char Character in cmbDog.Text)
            {
                if (digitCounter <= 3)
                {
                    if (Char.IsNumber(Character))
                    {
                        dogIDForDelete += Character;
                    }
                    digitCounter++;
                }
                else
                {
                    break;
                }
            }

                cmbTraining.Items.Clear();

            if (DogsList[Convert.ToInt16(dogIDForDelete) - 1].BasicTrainingComplete == true)
            {
                foreach (Training Class in TrainingList)    //the training class combo box will show all classes that the selected dog is eligible for.
                {
                    if (Class.TrainingType == "Advanced")
                    {
                        cmbTraining.Items.Add(Class.TrainingID + " - " + Class.TrainingType + " - " + Class.AgeClass + " - " + Class.StartDate.ToShortDateString());
                    }
                }
            }

            if (DogsList[Convert.ToInt16(dogIDForDelete) - 1].DateOfBirth <= DateTime.Now.AddYears(-5))
            {
                foreach (Training Class in TrainingList)
                {
                    if (Class.AgeClass == "5 Years+")
                    {
                        cmbTraining.Items.Add(Class.TrainingID + " - " + Class.TrainingType + " - " + Class.AgeClass + " - " + Class.StartDate.ToShortDateString());
                    }
                }
            }

            if (DogsList[Convert.ToInt16(dogIDForDelete) - 1].DateOfBirth >= DateTime.Now.AddYears(-5))
            {
                foreach (Training Class in TrainingList)
                {
                    if (Class.AgeClass == "Under 5 Years")
                    {
                        cmbTraining.Items.Add(Class.TrainingID + " - " + Class.TrainingType + " - " + Class.AgeClass + " - " + Class.StartDate.ToShortDateString());
                    }
                }
            }
        }

        private void cmbSearchBook_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }

        private void cmbSearchBook_MouseClick(object sender, MouseEventArgs e)
        {
            cmbSearchBook.DroppedDown = true;
        }

        private void cmbSearchDate_MouseClick(object sender, MouseEventArgs e)
        {
            cmbSearchDate.DroppedDown = true;
        }

        private void cmbSearchDate_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }

        private void cmbTraining_SelectedIndexChanged(object sender, EventArgs e)
        {
            trainIDForDelete = null;
            digitCounter = 0;
            int TimesClassBooked = 0;
            ClassFull = false;

            foreach (char Character in cmbTraining.Text)
            {
                if (digitCounter <= 3)
                {
                    if (Char.IsNumber(Character))
                    {
                        trainIDForDelete += Character;
                    }
                    digitCounter++;
                }
                else
                {
                    break;
                }
            }

            foreach (Bookings Book in BookingList) //checks if the selected class is fully booked.
            {
                if (Convert.ToString(Book.TrainingID) == trainIDForDelete)
                {
                    TimesClassBooked++;
                }
            }
            
            if (TimesClassBooked == 10)
            {
                ClassFull = true;
            }
        }
    }
}

