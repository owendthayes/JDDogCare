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
    public partial class ReportForm : MasterForm
    {
        Database db;

        string year = "";
        string month = "";


        public ReportForm(Database db)
        {
            InitializeComponent();
            this.db = db;
        }

        private void ReportForm_Load(object sender, EventArgs e)    //the current month and year are selected by default, the report will show data from the current month and year.
        {
            month = DateTime.Now.ToString("MM");
            year = DateTime.Now.ToString("yyyy");

            this.bookingsTableAdapter.Fill(this.databaseDataSet.Bookings);
            this.trainingTableAdapter.Fill(this.databaseDataSet.Training, year, month);

            this.reportViewer1.RefreshReport();

            lblDate.Text = DateTime.Now.ToString("MMMM yyyy");
        }

        private void updateReport(string Month, string Year)    //the report will change which data is displayed based on which month and year the user has selected.
        {
            this.bookingsTableAdapter.Fill(this.databaseDataSet.Bookings);
            this.trainingTableAdapter.Fill(this.databaseDataSet.Training, year, month);
            this.databaseDataSet.AcceptChanges();
            this.reportViewer1.RefreshReport();
        }

        private void btnForward_Click(object sender, EventArgs e)   //the report will update to show data from month after the one that was previously selected.
        {
            lblDate.Text = Convert.ToDateTime(lblDate.Text).AddMonths(1).ToString("MMMM yyyy");
            month = Convert.ToDateTime(lblDate.Text).Month.ToString();
            year = lblDate.Text.Substring(lblDate.Text.IndexOf(" ") + 1);

            updateReport(month, year);
        }

        private void btnBackward_Click(object sender, EventArgs e) //the report will update to show data from month before the one that was previously selected.
        {
            lblDate.Text = Convert.ToDateTime(lblDate.Text).AddMonths(-1).ToString("MMMM yyyy");
            month = Convert.ToDateTime(lblDate.Text).Month.ToString();
            year = lblDate.Text.Substring(lblDate.Text.IndexOf(" ") + 1);

            updateReport(month, year);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form Form1 = new TrainingMenu(db);
            Form1.Show();
            this.Close();
        }
    }
}
