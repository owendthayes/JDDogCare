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
    public partial class HomePage : MasterForm
    {
        Database db;

        public HomePage(Database db)
        {
            InitializeComponent();
            this.db = db;
        }

        private void btnTraining2_Click(object sender, EventArgs e)
        {
            Form Form1 = new TrainingMenu(db);
            this.Hide();
            Form1.Show();
        }

        private void btnTraining_Click(object sender, EventArgs e)
        {
            Form Form1 = new TrainingMenu(db);
            this.Close();
            Form1.Show();
        }

        private void imgTraining_Click(object sender, EventArgs e)
        {
            Form Form1 = new TrainingMenu(db);
            this.Close();
            Form1.Show();
        }

        private void imgTrainingBG_Click(object sender, EventArgs e)
        {
            Form Form1 = new TrainingMenu(db);
            this.Close();
            Form1.Show();
        }

        private void subSystemNotImplemented()
        {
            MessageBox.Show("This subsystem has not yet been implemented.\nOnly Training is avaialble.");
        }

        private void btnGrooming2_Click(object sender, EventArgs e)
        {
            subSystemNotImplemented();
        }

        private void imgGrooming_Click(object sender, EventArgs e)
        {
            subSystemNotImplemented();
        }

        private void btnMobileGrooming2_Click(object sender, EventArgs e)
        {
            subSystemNotImplemented();
        }

        private void imgMobile_Click(object sender, EventArgs e)
        {
            subSystemNotImplemented();
        }

        private void btnDayCare2_Click(object sender, EventArgs e)
        {
            subSystemNotImplemented();
        }

        private void imgDayCare_Click(object sender, EventArgs e)
        {
            subSystemNotImplemented();
        }

        private void btnWalking2_Click(object sender, EventArgs e)
        {
            subSystemNotImplemented();
        }

        private void imgWalking_Click(object sender, EventArgs e)
        {
            subSystemNotImplemented();
        }
    }
}

