using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JDDogCare.GUI;
using System.Data.SqlClient;
using JDDogCare.Objects;
using System.Diagnostics;


namespace JDDogCare
{
    public partial class MasterForm : Form
    {

        private bool mouseDown;
        private Point lastLocation;

        public MasterForm()
        {
            InitializeComponent();
            tmrDateTime.Start();          
        }

        private void MasterForm_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)  //the user is asked to confirm that they want to exit the system before they can exit.
        {
            if (MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
                SplashScreen obj = (SplashScreen)Application.OpenForms["SplashScreen"];
                obj.Close();
            }
        }

        private void tmrDateTime_Tick(object sender, EventArgs e)   //there is a date and time displayed on every form that updates each second to show the real date and time.
        {
            DateTime dateTime = DateTime.Now;
            lblTime.Text = dateTime.ToString();
        }

        private void toolStripButton7_Click(object sender, EventArgs e)     //subsystems displayed on the menu bar cannot be accessed as these systems have not been created.
        {
            MessageBox.Show("This subsystem has not yet been implemented.");
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This subsystem has not yet been implemented.");
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This subsystem has not yet been implemented.");
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This subsystem has not yet been implemented.");
        }

        private void toolStripButton2_Click(object sender, EventArgs e) //the user is asked to confirm that they want to exit the system before they can actually edit.
        {
            if (MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
                SplashScreen obj = (SplashScreen)Application.OpenForms["SplashScreen"];
                obj.Close();
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)  //if the "User guide" button on the menu bar is clicked, microsoft word will open the user guide.
        {            
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.FileName = "WINWORD.EXE";
            startInfo.Arguments = "UserGuide.docx";
            Process.Start(startInfo);
        }

        private void toolStripButton8_Click(object sender, EventArgs e) //if the "complexities" button on the menu bar is clicked, microsoft word will open the complexities document.
        {
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.FileName = "WINWORD.EXE";
            startInfo.Arguments = "CodeComplexities.docx";
            Process.Start(startInfo);
        }

        private void toolStrip1_MouseDown(object sender, MouseEventArgs e)  //the user can drag the form to a new location by holding the mouse down on the menu bar.
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void toolStrip1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void toolStrip1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }
    }
}
