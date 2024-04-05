namespace JDDogCare.GUI
{
    partial class CreateBooking
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblCreateNewBooking = new System.Windows.Forms.Label();
            this.cmbSelectDog = new System.Windows.Forms.ComboBox();
            this.txtOwner = new System.Windows.Forms.TextBox();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblAdvancedEligible = new System.Windows.Forms.Label();
            this.lblDOB = new System.Windows.Forms.Label();
            this.txtDOB = new System.Windows.Forms.MaskedTextBox();
            this.lblAge = new System.Windows.Forms.Label();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.cmbSelectTraining = new System.Windows.Forms.ComboBox();
            this.lblTraining = new System.Windows.Forms.Label();
            this.btnCreateBooking = new System.Windows.Forms.Button();
            this.clkValidBooking = new System.Windows.Forms.Timer(this.components);
            this.lblStaff = new System.Windows.Forms.Label();
            this.txtStaffName = new System.Windows.Forms.TextBox();
            this.txtStartDate = new System.Windows.Forms.MaskedTextBox();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.txtEndDate = new System.Windows.Forms.MaskedTextBox();
            this.lblTrainType = new System.Windows.Forms.Label();
            this.cmbTrainType = new System.Windows.Forms.ComboBox();
            this.dataViewTraining = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.listBoxCustomers = new System.Windows.Forms.ListBox();
            this.txtFilterCustomers = new System.Windows.Forms.TextBox();
            this.lblFilterCustomers = new System.Windows.Forms.Label();
            this.lblEstimatedCostLabel = new System.Windows.Forms.Label();
            this.lblDepositAmount = new System.Windows.Forms.Label();
            this.lblClassCost = new System.Windows.Forms.Label();
            this.lblCustLoyalty = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.lblClassBeforeDiscount = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataViewTraining)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(38, 641);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(189, 64);
            this.btnBack.TabIndex = 100;
            this.btnBack.Text = "Back to Menu";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblCreateNewBooking
            // 
            this.lblCreateNewBooking.AutoSize = true;
            this.lblCreateNewBooking.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblCreateNewBooking.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreateNewBooking.Location = new System.Drawing.Point(32, 159);
            this.lblCreateNewBooking.Name = "lblCreateNewBooking";
            this.lblCreateNewBooking.Size = new System.Drawing.Size(280, 31);
            this.lblCreateNewBooking.TabIndex = 37;
            this.lblCreateNewBooking.Text = "Create a new Booking";
            // 
            // cmbSelectDog
            // 
            this.cmbSelectDog.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbSelectDog.Enabled = false;
            this.cmbSelectDog.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSelectDog.FormattingEnabled = true;
            this.cmbSelectDog.Location = new System.Drawing.Point(425, 214);
            this.cmbSelectDog.Name = "cmbSelectDog";
            this.cmbSelectDog.Size = new System.Drawing.Size(168, 28);
            this.cmbSelectDog.TabIndex = 2;
            this.cmbSelectDog.SelectedIndexChanged += new System.EventHandler(this.cmbSelectDog_SelectedIndexChanged);
            this.cmbSelectDog.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbSelectDog_KeyDown);
            this.cmbSelectDog.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cmbSelectDog_MouseClick);
            // 
            // txtOwner
            // 
            this.txtOwner.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtOwner.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOwner.Location = new System.Drawing.Point(425, 363);
            this.txtOwner.Name = "txtOwner";
            this.txtOwner.ReadOnly = true;
            this.txtOwner.Size = new System.Drawing.Size(176, 26);
            this.txtOwner.TabIndex = 40;
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerName.Location = new System.Drawing.Point(314, 363);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(78, 20);
            this.lblCustomerName.TabIndex = 41;
            this.lblCustomerName.Text = "Customer";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(314, 217);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 20);
            this.label1.TabIndex = 42;
            this.label1.Text = "Dog";
            // 
            // lblAdvancedEligible
            // 
            this.lblAdvancedEligible.AutoSize = true;
            this.lblAdvancedEligible.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdvancedEligible.ForeColor = System.Drawing.Color.Red;
            this.lblAdvancedEligible.Location = new System.Drawing.Point(311, 254);
            this.lblAdvancedEligible.Name = "lblAdvancedEligible";
            this.lblAdvancedEligible.Size = new System.Drawing.Size(118, 16);
            this.lblAdvancedEligible.TabIndex = 44;
            this.lblAdvancedEligible.Text = "Advanced Eligible";
            this.lblAdvancedEligible.Visible = false;
            // 
            // lblDOB
            // 
            this.lblDOB.AutoSize = true;
            this.lblDOB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblDOB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDOB.Location = new System.Drawing.Point(314, 286);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(102, 20);
            this.lblDOB.TabIndex = 46;
            this.lblDOB.Text = "Date Of Birth";
            // 
            // txtDOB
            // 
            this.txtDOB.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtDOB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDOB.Location = new System.Drawing.Point(425, 283);
            this.txtDOB.Mask = "00/00/0000";
            this.txtDOB.Name = "txtDOB";
            this.txtDOB.ReadOnly = true;
            this.txtDOB.Size = new System.Drawing.Size(112, 26);
            this.txtDOB.TabIndex = 47;
            this.txtDOB.ValidatingType = typeof(System.DateTime);
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAge.Location = new System.Drawing.Point(316, 318);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(38, 20);
            this.lblAge.TabIndex = 48;
            this.lblAge.Text = "Age";
            // 
            // txtAge
            // 
            this.txtAge.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAge.Location = new System.Drawing.Point(425, 315);
            this.txtAge.Name = "txtAge";
            this.txtAge.ReadOnly = true;
            this.txtAge.Size = new System.Drawing.Size(112, 26);
            this.txtAge.TabIndex = 49;
            this.txtAge.TextChanged += new System.EventHandler(this.txtAge_TextChanged);
            // 
            // cmbSelectTraining
            // 
            this.cmbSelectTraining.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbSelectTraining.Enabled = false;
            this.cmbSelectTraining.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSelectTraining.FormattingEnabled = true;
            this.cmbSelectTraining.Location = new System.Drawing.Point(310, 461);
            this.cmbSelectTraining.Name = "cmbSelectTraining";
            this.cmbSelectTraining.Size = new System.Drawing.Size(293, 28);
            this.cmbSelectTraining.TabIndex = 4;
            this.cmbSelectTraining.SelectedIndexChanged += new System.EventHandler(this.cmbSelectTraining_SelectedIndexChanged);
            this.cmbSelectTraining.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbSelectTraining_KeyDown);
            this.cmbSelectTraining.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cmbSelectTraining_MouseClick);
            // 
            // lblTraining
            // 
            this.lblTraining.AutoSize = true;
            this.lblTraining.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblTraining.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTraining.Location = new System.Drawing.Point(314, 432);
            this.lblTraining.Name = "lblTraining";
            this.lblTraining.Size = new System.Drawing.Size(108, 20);
            this.lblTraining.TabIndex = 51;
            this.lblTraining.Text = "Training Class";
            // 
            // btnCreateBooking
            // 
            this.btnCreateBooking.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnCreateBooking.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreateBooking.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateBooking.Location = new System.Drawing.Point(376, 673);
            this.btnCreateBooking.Name = "btnCreateBooking";
            this.btnCreateBooking.Size = new System.Drawing.Size(211, 32);
            this.btnCreateBooking.TabIndex = 5;
            this.btnCreateBooking.Text = "Create Booking";
            this.btnCreateBooking.UseVisualStyleBackColor = false;
            this.btnCreateBooking.Click += new System.EventHandler(this.btnCreateBooking_Click);
            // 
            // clkValidBooking
            // 
            this.clkValidBooking.Tick += new System.EventHandler(this.clkValidBooking_Tick);
            // 
            // lblStaff
            // 
            this.lblStaff.AutoSize = true;
            this.lblStaff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStaff.Location = new System.Drawing.Point(314, 498);
            this.lblStaff.Name = "lblStaff";
            this.lblStaff.Size = new System.Drawing.Size(44, 20);
            this.lblStaff.TabIndex = 56;
            this.lblStaff.Text = "Staff";
            // 
            // txtStaffName
            // 
            this.txtStaffName.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtStaffName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStaffName.Location = new System.Drawing.Point(423, 495);
            this.txtStaffName.Name = "txtStaffName";
            this.txtStaffName.ReadOnly = true;
            this.txtStaffName.Size = new System.Drawing.Size(180, 26);
            this.txtStaffName.TabIndex = 57;
            // 
            // txtStartDate
            // 
            this.txtStartDate.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStartDate.Location = new System.Drawing.Point(423, 530);
            this.txtStartDate.Mask = "00/00/0000";
            this.txtStartDate.Name = "txtStartDate";
            this.txtStartDate.ReadOnly = true;
            this.txtStartDate.Size = new System.Drawing.Size(114, 26);
            this.txtStartDate.TabIndex = 58;
            this.txtStartDate.ValidatingType = typeof(System.DateTime);
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartDate.Location = new System.Drawing.Point(312, 533);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(83, 20);
            this.lblStartDate.TabIndex = 59;
            this.lblStartDate.Text = "Start Date";
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndDate.Location = new System.Drawing.Point(312, 568);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(77, 20);
            this.lblEndDate.TabIndex = 60;
            this.lblEndDate.Text = "End Date";
            // 
            // txtEndDate
            // 
            this.txtEndDate.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEndDate.Location = new System.Drawing.Point(423, 565);
            this.txtEndDate.Mask = "00/00/0000";
            this.txtEndDate.Name = "txtEndDate";
            this.txtEndDate.ReadOnly = true;
            this.txtEndDate.Size = new System.Drawing.Size(114, 26);
            this.txtEndDate.TabIndex = 61;
            this.txtEndDate.ValidatingType = typeof(System.DateTime);
            // 
            // lblTrainType
            // 
            this.lblTrainType.AutoSize = true;
            this.lblTrainType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblTrainType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrainType.Location = new System.Drawing.Point(314, 398);
            this.lblTrainType.Name = "lblTrainType";
            this.lblTrainType.Size = new System.Drawing.Size(103, 20);
            this.lblTrainType.TabIndex = 62;
            this.lblTrainType.Text = "Training Type";
            this.lblTrainType.Click += new System.EventHandler(this.lblTrainType_Click);
            // 
            // cmbTrainType
            // 
            this.cmbTrainType.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbTrainType.Enabled = false;
            this.cmbTrainType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTrainType.FormattingEnabled = true;
            this.cmbTrainType.Items.AddRange(new object[] {
            "Basic",
            "Advanced"});
            this.cmbTrainType.Location = new System.Drawing.Point(425, 395);
            this.cmbTrainType.Name = "cmbTrainType";
            this.cmbTrainType.Size = new System.Drawing.Size(176, 28);
            this.cmbTrainType.TabIndex = 3;
            this.cmbTrainType.SelectedIndexChanged += new System.EventHandler(this.cmbTrainType_SelectedIndexChanged);
            this.cmbTrainType.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbTrainType_KeyDown);
            this.cmbTrainType.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cmbTrainType_MouseClick);
            // 
            // dataViewTraining
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataViewTraining.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataViewTraining.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataViewTraining.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataViewTraining.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataViewTraining.Location = new System.Drawing.Point(609, 177);
            this.dataViewTraining.Name = "dataViewTraining";
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            this.dataViewTraining.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataViewTraining.Size = new System.Drawing.Size(659, 400);
            this.dataViewTraining.TabIndex = 64;
            this.dataViewTraining.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataViewTraining_CellContentClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.LimeGreen;
            this.pictureBox1.Location = new System.Drawing.Point(1036, 606);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(34, 25);
            this.pictureBox1.TabIndex = 65;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Silver;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(1076, 610);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 20);
            this.label2.TabIndex = 66;
            this.label2.Text = "10-7";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Silver;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(1079, 639);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 20);
            this.label3.TabIndex = 68;
            this.label3.Text = "6-4";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Yellow;
            this.pictureBox2.Location = new System.Drawing.Point(1036, 640);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(34, 25);
            this.pictureBox2.TabIndex = 67;
            this.pictureBox2.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Silver;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(1179, 645);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 20);
            this.label4.TabIndex = 70;
            this.label4.Text = "None";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.DodgerBlue;
            this.pictureBox3.Location = new System.Drawing.Point(1139, 640);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(34, 25);
            this.pictureBox3.TabIndex = 69;
            this.pictureBox3.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Silver;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(1179, 611);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 20);
            this.label5.TabIndex = 72;
            this.label5.Text = "1-3";
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Red;
            this.pictureBox4.Location = new System.Drawing.Point(1139, 609);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(34, 25);
            this.pictureBox4.TabIndex = 71;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Silver;
            this.pictureBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox5.Location = new System.Drawing.Point(1027, 568);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(241, 110);
            this.pictureBox5.TabIndex = 73;
            this.pictureBox5.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Silver;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(1033, 585);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 18);
            this.label6.TabIndex = 74;
            this.label6.Text = "Places Available";
            // 
            // listBoxCustomers
            // 
            this.listBoxCustomers.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxCustomers.FormattingEnabled = true;
            this.listBoxCustomers.ItemHeight = 25;
            this.listBoxCustomers.Location = new System.Drawing.Point(38, 276);
            this.listBoxCustomers.Name = "listBoxCustomers";
            this.listBoxCustomers.Size = new System.Drawing.Size(266, 354);
            this.listBoxCustomers.TabIndex = 75;
            this.listBoxCustomers.SelectedIndexChanged += new System.EventHandler(this.listBoxCustomers_SelectedIndexChanged);
            // 
            // txtFilterCustomers
            // 
            this.txtFilterCustomers.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFilterCustomers.Location = new System.Drawing.Point(38, 242);
            this.txtFilterCustomers.Name = "txtFilterCustomers";
            this.txtFilterCustomers.Size = new System.Drawing.Size(266, 29);
            this.txtFilterCustomers.TabIndex = 1;
            this.txtFilterCustomers.TextChanged += new System.EventHandler(this.txtFilterCustomers_TextChanged);
            // 
            // lblFilterCustomers
            // 
            this.lblFilterCustomers.AutoSize = true;
            this.lblFilterCustomers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblFilterCustomers.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilterCustomers.Location = new System.Drawing.Point(38, 213);
            this.lblFilterCustomers.Name = "lblFilterCustomers";
            this.lblFilterCustomers.Size = new System.Drawing.Size(253, 24);
            this.lblFilterCustomers.TabIndex = 76;
            this.lblFilterCustomers.Text = "Filter Customers by Surname";
            // 
            // lblEstimatedCostLabel
            // 
            this.lblEstimatedCostLabel.AutoSize = true;
            this.lblEstimatedCostLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstimatedCostLabel.ForeColor = System.Drawing.Color.Black;
            this.lblEstimatedCostLabel.Location = new System.Drawing.Point(307, 594);
            this.lblEstimatedCostLabel.Name = "lblEstimatedCostLabel";
            this.lblEstimatedCostLabel.Size = new System.Drawing.Size(238, 25);
            this.lblEstimatedCostLabel.TabIndex = 78;
            this.lblEstimatedCostLabel.Text = "Estimated Total Cost:";
            // 
            // lblDepositAmount
            // 
            this.lblDepositAmount.AutoSize = true;
            this.lblDepositAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepositAmount.ForeColor = System.Drawing.Color.Black;
            this.lblDepositAmount.Location = new System.Drawing.Point(661, 585);
            this.lblDepositAmount.Name = "lblDepositAmount";
            this.lblDepositAmount.Size = new System.Drawing.Size(185, 25);
            this.lblDepositAmount.TabIndex = 79;
            this.lblDepositAmount.Text = "Deposit Amount:";
            // 
            // lblClassCost
            // 
            this.lblClassCost.AutoSize = true;
            this.lblClassCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClassCost.ForeColor = System.Drawing.Color.Black;
            this.lblClassCost.Location = new System.Drawing.Point(661, 611);
            this.lblClassCost.Name = "lblClassCost";
            this.lblClassCost.Size = new System.Drawing.Size(247, 25);
            this.lblClassCost.TabIndex = 80;
            this.lblClassCost.Text = "Cost of Chosen Class:";
            // 
            // lblCustLoyalty
            // 
            this.lblCustLoyalty.AutoSize = true;
            this.lblCustLoyalty.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustLoyalty.ForeColor = System.Drawing.Color.Black;
            this.lblCustLoyalty.Location = new System.Drawing.Point(661, 676);
            this.lblCustLoyalty.Name = "lblCustLoyalty";
            this.lblCustLoyalty.Size = new System.Drawing.Size(301, 25);
            this.lblCustLoyalty.TabIndex = 81;
            this.lblCustLoyalty.Text = "Customer Loyalty Discount:";
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Lime;
            this.pictureBox6.Location = new System.Drawing.Point(1036, 609);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(34, 25);
            this.pictureBox6.TabIndex = 82;
            this.pictureBox6.TabStop = false;
            // 
            // lblClassBeforeDiscount
            // 
            this.lblClassBeforeDiscount.AutoSize = true;
            this.lblClassBeforeDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClassBeforeDiscount.ForeColor = System.Drawing.Color.Black;
            this.lblClassBeforeDiscount.Location = new System.Drawing.Point(661, 636);
            this.lblClassBeforeDiscount.Name = "lblClassBeforeDiscount";
            this.lblClassBeforeDiscount.Size = new System.Drawing.Size(242, 25);
            this.lblClassBeforeDiscount.TabIndex = 83;
            this.lblClassBeforeDiscount.Text = "Cost Before Discount:";
            // 
            // CreateBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.lblClassBeforeDiscount);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.lblCustLoyalty);
            this.Controls.Add(this.lblClassCost);
            this.Controls.Add(this.lblDepositAmount);
            this.Controls.Add(this.lblEstimatedCostLabel);
            this.Controls.Add(this.txtFilterCustomers);
            this.Controls.Add(this.lblFilterCustomers);
            this.Controls.Add(this.listBoxCustomers);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataViewTraining);
            this.Controls.Add(this.cmbTrainType);
            this.Controls.Add(this.lblTrainType);
            this.Controls.Add(this.txtEndDate);
            this.Controls.Add(this.lblEndDate);
            this.Controls.Add(this.lblStartDate);
            this.Controls.Add(this.txtStartDate);
            this.Controls.Add(this.txtStaffName);
            this.Controls.Add(this.lblStaff);
            this.Controls.Add(this.btnCreateBooking);
            this.Controls.Add(this.lblTraining);
            this.Controls.Add(this.cmbSelectTraining);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.txtDOB);
            this.Controls.Add(this.lblDOB);
            this.Controls.Add(this.lblAdvancedEligible);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblCustomerName);
            this.Controls.Add(this.txtOwner);
            this.Controls.Add(this.cmbSelectDog);
            this.Controls.Add(this.lblCreateNewBooking);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.pictureBox5);
            this.Name = "CreateBooking";
            this.Text = "CreateBooking";
            this.Load += new System.EventHandler(this.CreateBooking_Load);
            this.Controls.SetChildIndex(this.pictureBox5, 0);
            this.Controls.SetChildIndex(this.btnBack, 0);
            this.Controls.SetChildIndex(this.lblCreateNewBooking, 0);
            this.Controls.SetChildIndex(this.cmbSelectDog, 0);
            this.Controls.SetChildIndex(this.txtOwner, 0);
            this.Controls.SetChildIndex(this.lblCustomerName, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.lblAdvancedEligible, 0);
            this.Controls.SetChildIndex(this.lblDOB, 0);
            this.Controls.SetChildIndex(this.txtDOB, 0);
            this.Controls.SetChildIndex(this.lblAge, 0);
            this.Controls.SetChildIndex(this.txtAge, 0);
            this.Controls.SetChildIndex(this.cmbSelectTraining, 0);
            this.Controls.SetChildIndex(this.lblTraining, 0);
            this.Controls.SetChildIndex(this.btnCreateBooking, 0);
            this.Controls.SetChildIndex(this.lblStaff, 0);
            this.Controls.SetChildIndex(this.txtStaffName, 0);
            this.Controls.SetChildIndex(this.txtStartDate, 0);
            this.Controls.SetChildIndex(this.lblStartDate, 0);
            this.Controls.SetChildIndex(this.lblEndDate, 0);
            this.Controls.SetChildIndex(this.txtEndDate, 0);
            this.Controls.SetChildIndex(this.lblTrainType, 0);
            this.Controls.SetChildIndex(this.cmbTrainType, 0);
            this.Controls.SetChildIndex(this.dataViewTraining, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.pictureBox2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.pictureBox3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.pictureBox4, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.listBoxCustomers, 0);
            this.Controls.SetChildIndex(this.lblFilterCustomers, 0);
            this.Controls.SetChildIndex(this.txtFilterCustomers, 0);
            this.Controls.SetChildIndex(this.lblEstimatedCostLabel, 0);
            this.Controls.SetChildIndex(this.lblDepositAmount, 0);
            this.Controls.SetChildIndex(this.lblClassCost, 0);
            this.Controls.SetChildIndex(this.lblCustLoyalty, 0);
            this.Controls.SetChildIndex(this.pictureBox6, 0);
            this.Controls.SetChildIndex(this.lblClassBeforeDiscount, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dataViewTraining)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblCreateNewBooking;
        private System.Windows.Forms.ComboBox cmbSelectDog;
        private System.Windows.Forms.TextBox txtOwner;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblAdvancedEligible;
        private System.Windows.Forms.Label lblDOB;
        private System.Windows.Forms.MaskedTextBox txtDOB;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.ComboBox cmbSelectTraining;
        private System.Windows.Forms.Label lblTraining;
        private System.Windows.Forms.Button btnCreateBooking;
        private System.Windows.Forms.Timer clkValidBooking;
        private System.Windows.Forms.Label lblStaff;
        private System.Windows.Forms.TextBox txtStaffName;
        private System.Windows.Forms.MaskedTextBox txtStartDate;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.MaskedTextBox txtEndDate;
        private System.Windows.Forms.Label lblTrainType;
        private System.Windows.Forms.ComboBox cmbTrainType;
        private System.Windows.Forms.DataGridView dataViewTraining;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox listBoxCustomers;
        private System.Windows.Forms.TextBox txtFilterCustomers;
        private System.Windows.Forms.Label lblFilterCustomers;
        private System.Windows.Forms.Label lblEstimatedCostLabel;
        private System.Windows.Forms.Label lblDepositAmount;
        private System.Windows.Forms.Label lblClassCost;
        private System.Windows.Forms.Label lblCustLoyalty;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label lblClassBeforeDiscount;
    }
}