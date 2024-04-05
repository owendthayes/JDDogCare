namespace JDDogCare.GUI
{
    partial class TrainingMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrainingMenu));
            this.btnAddEditDeleteDogs = new System.Windows.Forms.Button();
            this.btnEditBookings = new System.Windows.Forms.Button();
            this.btnNewBooking = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnReport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddEditDeleteDogs
            // 
            this.btnAddEditDeleteDogs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnAddEditDeleteDogs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddEditDeleteDogs.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddEditDeleteDogs.Location = new System.Drawing.Point(23, 318);
            this.btnAddEditDeleteDogs.Name = "btnAddEditDeleteDogs";
            this.btnAddEditDeleteDogs.Size = new System.Drawing.Size(458, 126);
            this.btnAddEditDeleteDogs.TabIndex = 2;
            this.btnAddEditDeleteDogs.Text = "Add/Edit/Delete Dogs";
            this.btnAddEditDeleteDogs.UseVisualStyleBackColor = false;
            this.btnAddEditDeleteDogs.Click += new System.EventHandler(this.btnAddEditDeleteDogs_Click);
            // 
            // btnEditBookings
            // 
            this.btnEditBookings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnEditBookings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditBookings.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditBookings.Location = new System.Drawing.Point(23, 450);
            this.btnEditBookings.Name = "btnEditBookings";
            this.btnEditBookings.Size = new System.Drawing.Size(458, 126);
            this.btnEditBookings.TabIndex = 3;
            this.btnEditBookings.Text = "View/Edit/Delete Bookings";
            this.btnEditBookings.UseVisualStyleBackColor = false;
            this.btnEditBookings.Click += new System.EventHandler(this.btnEditBookings_Click);
            // 
            // btnNewBooking
            // 
            this.btnNewBooking.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnNewBooking.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNewBooking.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewBooking.Location = new System.Drawing.Point(23, 186);
            this.btnNewBooking.Name = "btnNewBooking";
            this.btnNewBooking.Size = new System.Drawing.Size(458, 126);
            this.btnNewBooking.TabIndex = 1;
            this.btnNewBooking.Text = "Create New Booking";
            this.btnNewBooking.UseVisualStyleBackColor = false;
            this.btnNewBooking.Click += new System.EventHandler(this.btnNewBooking_Click);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.Location = new System.Drawing.Point(23, 632);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(189, 64);
            this.btnHome.TabIndex = 4;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(497, 196);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(740, 441);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            // 
            // btnReport
            // 
            this.btnReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReport.Location = new System.Drawing.Point(1026, 644);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(211, 64);
            this.btnReport.TabIndex = 16;
            this.btnReport.Text = "View Monthly Earnings Report";
            this.btnReport.UseVisualStyleBackColor = false;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // TrainingMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.btnNewBooking);
            this.Controls.Add(this.btnEditBookings);
            this.Controls.Add(this.btnAddEditDeleteDogs);
            this.Name = "TrainingMenu";
            this.Text = "Home";
            this.Controls.SetChildIndex(this.btnAddEditDeleteDogs, 0);
            this.Controls.SetChildIndex(this.btnEditBookings, 0);
            this.Controls.SetChildIndex(this.btnNewBooking, 0);
            this.Controls.SetChildIndex(this.btnHome, 0);
            this.Controls.SetChildIndex(this.pictureBox2, 0);
            this.Controls.SetChildIndex(this.btnReport, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddEditDeleteDogs;
        private System.Windows.Forms.Button btnEditBookings;
        private System.Windows.Forms.Button btnNewBooking;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnReport;
    }
}