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

namespace JDDogCare.GUI
{
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();

            Database db;
            db = new Database();

            if (db.connect())   //the system will inform the user if the database connection has been successful or not. If it is unsuccessful the user is informed that the program needs to be restarted.
            {
                MessageBox.Show("Database Connection Successful.", "Success");
                Form Form1 = new HomePage(db);
                this.WindowState = FormWindowState.Minimized;
                this.ShowInTaskbar = false;
                Form1.Show();
            }
            else
            {
                MessageBox.Show("Database Connection Unsuccessful. Please Restart the Program.", "Error");
            }                   
        }

        private void SplashScreen_Load(object sender, EventArgs e)
        {

        }
    }
}

