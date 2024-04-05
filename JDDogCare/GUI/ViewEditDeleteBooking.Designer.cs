namespace JDDogCare.GUI
{
    partial class ViewEditDeleteBooking
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataBookings = new System.Windows.Forms.DataGridView();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblEditDeleteBooking = new System.Windows.Forms.Label();
            this.lblBookInfo = new System.Windows.Forms.Label();
            this.lblBookID = new System.Windows.Forms.Label();
            this.lblDog = new System.Windows.Forms.Label();
            this.lblCustomer = new System.Windows.Forms.Label();
            this.cmbDog = new System.Windows.Forms.ComboBox();
            this.lblTraining = new System.Windows.Forms.Label();
            this.cmbTraining = new System.Windows.Forms.ComboBox();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.txtStartDate = new System.Windows.Forms.MaskedTextBox();
            this.txtEndDate = new System.Windows.Forms.MaskedTextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblSortBookings = new System.Windows.Forms.Label();
            this.cmbSearchBook = new System.Windows.Forms.ComboBox();
            this.txtSearchBook = new System.Windows.Forms.MaskedTextBox();
            this.cmbSearchDate = new System.Windows.Forms.ComboBox();
            this.txtBookingID = new System.Windows.Forms.Label();
            this.txtCustomer = new System.Windows.Forms.Label();
            this.btnSaveChanges = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataBookings)).BeginInit();
            this.SuspendLayout();
            // 
            // dataBookings
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataBookings.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataBookings.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataBookings.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dataBookings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataBookings.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dataBookings.Location = new System.Drawing.Point(40, 221);
            this.dataBookings.Name = "dataBookings";
            this.dataBookings.ReadOnly = true;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            this.dataBookings.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataBookings.Size = new System.Drawing.Size(1208, 310);
            this.dataBookings.TabIndex = 10;
            this.dataBookings.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataBookings_CellClick);
            this.dataBookings.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataBookings_CellContentClick);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(40, 634);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(189, 64);
            this.btnBack.TabIndex = 9;
            this.btnBack.Text = "Back to Menu";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblEditDeleteBooking
            // 
            this.lblEditDeleteBooking.AutoSize = true;
            this.lblEditDeleteBooking.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblEditDeleteBooking.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditDeleteBooking.Location = new System.Drawing.Point(34, 172);
            this.lblEditDeleteBooking.Name = "lblEditDeleteBooking";
            this.lblEditDeleteBooking.Size = new System.Drawing.Size(217, 31);
            this.lblEditDeleteBooking.TabIndex = 37;
            this.lblEditDeleteBooking.Text = "Select a Booking";
            // 
            // lblBookInfo
            // 
            this.lblBookInfo.AutoSize = true;
            this.lblBookInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblBookInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookInfo.Location = new System.Drawing.Point(35, 549);
            this.lblBookInfo.Name = "lblBookInfo";
            this.lblBookInfo.Size = new System.Drawing.Size(329, 29);
            this.lblBookInfo.TabIndex = 40;
            this.lblBookInfo.Text = "Selected Booking Information";
            // 
            // lblBookID
            // 
            this.lblBookID.AutoSize = true;
            this.lblBookID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblBookID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookID.Location = new System.Drawing.Point(366, 594);
            this.lblBookID.Name = "lblBookID";
            this.lblBookID.Size = new System.Drawing.Size(101, 24);
            this.lblBookID.TabIndex = 41;
            this.lblBookID.Text = "Booking ID";
            // 
            // lblDog
            // 
            this.lblDog.AutoSize = true;
            this.lblDog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblDog.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDog.Location = new System.Drawing.Point(366, 664);
            this.lblDog.Name = "lblDog";
            this.lblDog.Size = new System.Drawing.Size(45, 24);
            this.lblDog.TabIndex = 42;
            this.lblDog.Text = "Dog";
            // 
            // lblCustomer
            // 
            this.lblCustomer.AutoSize = true;
            this.lblCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomer.Location = new System.Drawing.Point(366, 629);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(91, 24);
            this.lblCustomer.TabIndex = 45;
            this.lblCustomer.Text = "Customer";
            // 
            // cmbDog
            // 
            this.cmbDog.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbDog.Enabled = false;
            this.cmbDog.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDog.FormattingEnabled = true;
            this.cmbDog.Location = new System.Drawing.Point(483, 661);
            this.cmbDog.Name = "cmbDog";
            this.cmbDog.Size = new System.Drawing.Size(202, 32);
            this.cmbDog.TabIndex = 5;
            this.cmbDog.SelectedIndexChanged += new System.EventHandler(this.cmbDog_SelectedIndexChanged);
            this.cmbDog.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbDog_KeyDown);
            this.cmbDog.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cmbDog_MouseClick);
            // 
            // lblTraining
            // 
            this.lblTraining.AutoSize = true;
            this.lblTraining.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblTraining.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTraining.Location = new System.Drawing.Point(701, 591);
            this.lblTraining.Name = "lblTraining";
            this.lblTraining.Size = new System.Drawing.Size(55, 24);
            this.lblTraining.TabIndex = 49;
            this.lblTraining.Text = "Class";
            // 
            // cmbTraining
            // 
            this.cmbTraining.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbTraining.Enabled = false;
            this.cmbTraining.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTraining.FormattingEnabled = true;
            this.cmbTraining.Location = new System.Drawing.Point(796, 586);
            this.cmbTraining.Name = "cmbTraining";
            this.cmbTraining.Size = new System.Drawing.Size(353, 32);
            this.cmbTraining.TabIndex = 6;
            this.cmbTraining.SelectedIndexChanged += new System.EventHandler(this.cmbTraining_SelectedIndexChanged);
            this.cmbTraining.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbTraining_KeyDown);
            this.cmbTraining.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cmbTraining_MouseClick);
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartDate.Location = new System.Drawing.Point(701, 631);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(89, 24);
            this.lblStartDate.TabIndex = 51;
            this.lblStartDate.Text = "Start Date";
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndDate.Location = new System.Drawing.Point(701, 669);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(88, 24);
            this.lblEndDate.TabIndex = 52;
            this.lblEndDate.Text = "End Date";
            // 
            // txtStartDate
            // 
            this.txtStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStartDate.Location = new System.Drawing.Point(796, 628);
            this.txtStartDate.Mask = "00/00/0000";
            this.txtStartDate.Name = "txtStartDate";
            this.txtStartDate.ReadOnly = true;
            this.txtStartDate.Size = new System.Drawing.Size(108, 29);
            this.txtStartDate.TabIndex = 53;
            this.txtStartDate.ValidatingType = typeof(System.DateTime);
            // 
            // txtEndDate
            // 
            this.txtEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEndDate.Location = new System.Drawing.Point(795, 666);
            this.txtEndDate.Mask = "00/00/0000";
            this.txtEndDate.Name = "txtEndDate";
            this.txtEndDate.ReadOnly = true;
            this.txtEndDate.Size = new System.Drawing.Size(109, 29);
            this.txtEndDate.TabIndex = 54;
            this.txtEndDate.ValidatingType = typeof(System.DateTime);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(910, 666);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(239, 32);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Archive Booking";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblSortBookings
            // 
            this.lblSortBookings.AutoSize = true;
            this.lblSortBookings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblSortBookings.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSortBookings.Location = new System.Drawing.Point(328, 176);
            this.lblSortBookings.Name = "lblSortBookings";
            this.lblSortBookings.Size = new System.Drawing.Size(134, 24);
            this.lblSortBookings.TabIndex = 57;
            this.lblSortBookings.Text = "Filter Bookings";
            // 
            // cmbSearchBook
            // 
            this.cmbSearchBook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbSearchBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSearchBook.FormattingEnabled = true;
            this.cmbSearchBook.Items.AddRange(new object[] {
            "Booking ID",
            "Customer Surname",
            "Dog Name",
            "Training Type",
            "Training Age Class",
            "Start Date"});
            this.cmbSearchBook.Location = new System.Drawing.Point(468, 173);
            this.cmbSearchBook.Name = "cmbSearchBook";
            this.cmbSearchBook.Size = new System.Drawing.Size(199, 32);
            this.cmbSearchBook.TabIndex = 1;
            this.cmbSearchBook.Text = "Search Bookings By:";
            this.cmbSearchBook.SelectedIndexChanged += new System.EventHandler(this.cmbSearchBook_SelectedIndexChanged);
            this.cmbSearchBook.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbSearchBook_KeyDown);
            this.cmbSearchBook.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cmbSearchBook_MouseClick);
            // 
            // txtSearchBook
            // 
            this.txtSearchBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchBook.Location = new System.Drawing.Point(673, 176);
            this.txtSearchBook.Name = "txtSearchBook";
            this.txtSearchBook.Size = new System.Drawing.Size(139, 29);
            this.txtSearchBook.TabIndex = 59;
            this.txtSearchBook.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txtSearchBook_MaskInputRejected);
            this.txtSearchBook.TextChanged += new System.EventHandler(this.txtSearchBook_TextChanged);
            this.txtSearchBook.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearchBook_KeyPress);
            // 
            // cmbSearchDate
            // 
            this.cmbSearchDate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbSearchDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSearchDate.Location = new System.Drawing.Point(673, 172);
            this.cmbSearchDate.Name = "cmbSearchDate";
            this.cmbSearchDate.Size = new System.Drawing.Size(139, 32);
            this.cmbSearchDate.TabIndex = 2;
            this.cmbSearchDate.Visible = false;
            this.cmbSearchDate.SelectedIndexChanged += new System.EventHandler(this.cmbSearchDate_SelectedIndexChanged_1);
            this.cmbSearchDate.TextUpdate += new System.EventHandler(this.cmbSearchDate_TextUpdate);
            this.cmbSearchDate.TextChanged += new System.EventHandler(this.cmbSearchDate_TextChanged);
            this.cmbSearchDate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbSearchDate_KeyDown);
            this.cmbSearchDate.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cmbSearchDate_MouseClick);
            // 
            // txtBookingID
            // 
            this.txtBookingID.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtBookingID.BackColor = System.Drawing.Color.White;
            this.txtBookingID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBookingID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBookingID.ForeColor = System.Drawing.Color.Black;
            this.txtBookingID.Location = new System.Drawing.Point(483, 590);
            this.txtBookingID.Name = "txtBookingID";
            this.txtBookingID.Size = new System.Drawing.Size(202, 29);
            this.txtBookingID.TabIndex = 3;
            // 
            // txtCustomer
            // 
            this.txtCustomer.BackColor = System.Drawing.Color.White;
            this.txtCustomer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomer.ForeColor = System.Drawing.Color.Black;
            this.txtCustomer.Location = new System.Drawing.Point(483, 625);
            this.txtCustomer.Name = "txtCustomer";
            this.txtCustomer.Size = new System.Drawing.Size(202, 32);
            this.txtCustomer.TabIndex = 4;
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnSaveChanges.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveChanges.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveChanges.Location = new System.Drawing.Point(910, 627);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(239, 32);
            this.btnSaveChanges.TabIndex = 7;
            this.btnSaveChanges.Text = "Save Changes";
            this.btnSaveChanges.UseVisualStyleBackColor = false;
            this.btnSaveChanges.Click += new System.EventHandler(this.btnSaveChanges_Click);
            // 
            // ViewEditDeleteBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.txtCustomer);
            this.Controls.Add(this.txtBookingID);
            this.Controls.Add(this.cmbSearchDate);
            this.Controls.Add(this.txtSearchBook);
            this.Controls.Add(this.cmbSearchBook);
            this.Controls.Add(this.lblSortBookings);
            this.Controls.Add(this.btnSaveChanges);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.txtEndDate);
            this.Controls.Add(this.txtStartDate);
            this.Controls.Add(this.lblEndDate);
            this.Controls.Add(this.lblStartDate);
            this.Controls.Add(this.cmbTraining);
            this.Controls.Add(this.lblTraining);
            this.Controls.Add(this.cmbDog);
            this.Controls.Add(this.lblCustomer);
            this.Controls.Add(this.lblDog);
            this.Controls.Add(this.lblBookID);
            this.Controls.Add(this.lblBookInfo);
            this.Controls.Add(this.lblEditDeleteBooking);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.dataBookings);
            this.Name = "ViewEditDeleteBooking";
            this.Text = "ViewEditDeleteBooking";
            this.Load += new System.EventHandler(this.ViewEditDeleteBooking_Load);
            this.Controls.SetChildIndex(this.dataBookings, 0);
            this.Controls.SetChildIndex(this.btnBack, 0);
            this.Controls.SetChildIndex(this.lblEditDeleteBooking, 0);
            this.Controls.SetChildIndex(this.lblBookInfo, 0);
            this.Controls.SetChildIndex(this.lblBookID, 0);
            this.Controls.SetChildIndex(this.lblDog, 0);
            this.Controls.SetChildIndex(this.lblCustomer, 0);
            this.Controls.SetChildIndex(this.cmbDog, 0);
            this.Controls.SetChildIndex(this.lblTraining, 0);
            this.Controls.SetChildIndex(this.cmbTraining, 0);
            this.Controls.SetChildIndex(this.lblStartDate, 0);
            this.Controls.SetChildIndex(this.lblEndDate, 0);
            this.Controls.SetChildIndex(this.txtStartDate, 0);
            this.Controls.SetChildIndex(this.txtEndDate, 0);
            this.Controls.SetChildIndex(this.btnDelete, 0);
            this.Controls.SetChildIndex(this.btnSaveChanges, 0);
            this.Controls.SetChildIndex(this.lblSortBookings, 0);
            this.Controls.SetChildIndex(this.cmbSearchBook, 0);
            this.Controls.SetChildIndex(this.txtSearchBook, 0);
            this.Controls.SetChildIndex(this.cmbSearchDate, 0);
            this.Controls.SetChildIndex(this.txtBookingID, 0);
            this.Controls.SetChildIndex(this.txtCustomer, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dataBookings)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataBookings;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblEditDeleteBooking;
        private System.Windows.Forms.Label lblBookInfo;
        private System.Windows.Forms.Label lblBookID;
        private System.Windows.Forms.Label lblDog;
        private System.Windows.Forms.Label lblCustomer;
        private System.Windows.Forms.ComboBox cmbDog;
        private System.Windows.Forms.Label lblTraining;
        private System.Windows.Forms.ComboBox cmbTraining;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.MaskedTextBox txtStartDate;
        private System.Windows.Forms.MaskedTextBox txtEndDate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblSortBookings;
        private System.Windows.Forms.ComboBox cmbSearchBook;
        private System.Windows.Forms.MaskedTextBox txtSearchBook;
        private System.Windows.Forms.ComboBox cmbSearchDate;
        private System.Windows.Forms.Label txtBookingID;
        private System.Windows.Forms.Label txtCustomer;
        private System.Windows.Forms.Button btnSaveChanges;
    }
}