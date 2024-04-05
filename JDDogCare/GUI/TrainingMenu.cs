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
    public partial class TrainingMenu : MasterForm
    {
        Database db;
        bool booksUpdated = false;              //the user is able to choose any of the different buttons to be taken to the appropriate form.

        public TrainingMenu(Database db)
        {
            InitializeComponent();
            this.db = db;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Form Form1 = new HomePage(db);
            this.Close();
            Form1.Show();
        }

        private void btnAddEditDeleteDogs_Click(object sender, EventArgs e)
        {
            Form FOrm1 = new AddEditDeleteDogs(db);
            this.Close();
            FOrm1.Show();
        }

        private void btnTraining_Click(object sender, EventArgs e)
        {
            Form Form1 = new TrainingMenu(db);
            this.Close();
            Form1.Show();
        }

        private void btnNewBooking_Click(object sender, EventArgs e)
        {
            Form Form1 = new CreateBooking(db);
            this.Close();
            Form1.Show();
        }

        private void btnEditBookings_Click(object sender, EventArgs e)
        {
            Form Form1 = new ViewEditDeleteBooking(db);
            this.Close();
            Form1.Show();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            Form Form1 = new ReportForm(db);
            this.Close();
            Form1.Show();
        }
    }
}
