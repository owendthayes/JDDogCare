namespace JDDogCare.GUI
{
    partial class AddEditDeleteDogs
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
            this.btnBack = new System.Windows.Forms.Button();
            this.txtDogName = new System.Windows.Forms.TextBox();
            this.lblDogID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.chkBasicTraining = new System.Windows.Forms.CheckBox();
            this.lblBasicTraining = new System.Windows.Forms.Label();
            this.lblDOB = new System.Windows.Forms.Label();
            this.llbCustName = new System.Windows.Forms.Label();
            this.lblEditDelete = new System.Windows.Forms.Label();
            this.lblAdd = new System.Windows.Forms.Label();
            this.chkNewBasic = new System.Windows.Forms.CheckBox();
            this.txtNewDogName = new System.Windows.Forms.TextBox();
            this.btnSaveChanges = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSaveNewDog = new System.Windows.Forms.Button();
            this.cmbEditDOBDay = new System.Windows.Forms.ComboBox();
            this.cmbEditDOBMonth = new System.Windows.Forms.ComboBox();
            this.cmbEditDOBYear = new System.Windows.Forms.ComboBox();
            this.cmbAddDOBYear = new System.Windows.Forms.ComboBox();
            this.cmbAddDOBMonth = new System.Windows.Forms.ComboBox();
            this.cmbAddDOBDay = new System.Windows.Forms.ComboBox();
            this.listBoxCustomers = new System.Windows.Forms.ListBox();
            this.lblSelectCustomer = new System.Windows.Forms.Label();
            this.listBoxDogs = new System.Windows.Forms.ListBox();
            this.btnEditDog = new System.Windows.Forms.Button();
            this.btnAddNewDog = new System.Windows.Forms.Button();
            this.btnBackToSelection = new System.Windows.Forms.Button();
            this.lblAddNewDog = new System.Windows.Forms.Label();
            this.lblSelectWhatYouWant = new System.Windows.Forms.Label();
            this.lblFilterCustomers = new System.Windows.Forms.Label();
            this.txtFilterCustomers = new System.Windows.Forms.TextBox();
            this.btnClearFilter = new System.Windows.Forms.Button();
            this.lblDOBValid = new System.Windows.Forms.Label();
            this.clkDOB = new System.Windows.Forms.Timer(this.components);
            this.cmbNewOwner = new System.Windows.Forms.Label();
            this.cmbOwner = new System.Windows.Forms.Label();
            this.txtNewDogID = new System.Windows.Forms.Label();
            this.txtDogID = new System.Windows.Forms.Label();
            this.txtDogBreed = new System.Windows.Forms.ComboBox();
            this.txtNewDogBreed = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(18, 648);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(189, 64);
            this.btnBack.TabIndex = 15;
            this.btnBack.Text = "Back to Menu";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // txtDogName
            // 
            this.txtDogName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDogName.Location = new System.Drawing.Point(798, 433);
            this.txtDogName.Name = "txtDogName";
            this.txtDogName.Size = new System.Drawing.Size(225, 29);
            this.txtDogName.TabIndex = 11;
            this.txtDogName.Visible = false;
            // 
            // lblDogID
            // 
            this.lblDogID.AutoSize = true;
            this.lblDogID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblDogID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDogID.Location = new System.Drawing.Point(577, 390);
            this.lblDogID.Name = "lblDogID";
            this.lblDogID.Size = new System.Drawing.Size(27, 24);
            this.lblDogID.TabIndex = 22;
            this.lblDogID.Text = "ID";
            this.lblDogID.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(577, 480);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 24);
            this.label1.TabIndex = 23;
            this.label1.Text = "Breed";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(577, 436);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 24);
            this.label2.TabIndex = 24;
            this.label2.Text = "Dog Name";
            this.label2.Visible = false;
            // 
            // chkBasicTraining
            // 
            this.chkBasicTraining.AutoSize = true;
            this.chkBasicTraining.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBasicTraining.Location = new System.Drawing.Point(798, 576);
            this.chkBasicTraining.Name = "chkBasicTraining";
            this.chkBasicTraining.Size = new System.Drawing.Size(15, 14);
            this.chkBasicTraining.TabIndex = 16;
            this.chkBasicTraining.UseVisualStyleBackColor = true;
            this.chkBasicTraining.Visible = false;
            // 
            // lblBasicTraining
            // 
            this.lblBasicTraining.AutoSize = true;
            this.lblBasicTraining.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblBasicTraining.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBasicTraining.Location = new System.Drawing.Point(577, 570);
            this.lblBasicTraining.Name = "lblBasicTraining";
            this.lblBasicTraining.Size = new System.Drawing.Size(215, 24);
            this.lblBasicTraining.TabIndex = 29;
            this.lblBasicTraining.Text = "Basic Training Complete";
            this.lblBasicTraining.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.lblBasicTraining.Visible = false;
            // 
            // lblDOB
            // 
            this.lblDOB.AutoSize = true;
            this.lblDOB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblDOB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDOB.Location = new System.Drawing.Point(577, 525);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(110, 24);
            this.lblDOB.TabIndex = 30;
            this.lblDOB.Text = "Date of Birth";
            this.lblDOB.Visible = false;
            // 
            // llbCustName
            // 
            this.llbCustName.AutoSize = true;
            this.llbCustName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.llbCustName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llbCustName.Location = new System.Drawing.Point(576, 339);
            this.llbCustName.Name = "llbCustName";
            this.llbCustName.Size = new System.Drawing.Size(67, 24);
            this.llbCustName.TabIndex = 32;
            this.llbCustName.Text = "Owner";
            this.llbCustName.Visible = false;
            // 
            // lblEditDelete
            // 
            this.lblEditDelete.AutoSize = true;
            this.lblEditDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblEditDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditDelete.Location = new System.Drawing.Point(702, 272);
            this.lblEditDelete.Name = "lblEditDelete";
            this.lblEditDelete.Size = new System.Drawing.Size(235, 31);
            this.lblEditDelete.TabIndex = 36;
            this.lblEditDelete.Text = "Edit or Delete Dog";
            this.lblEditDelete.Visible = false;
            // 
            // lblAdd
            // 
            this.lblAdd.AutoSize = true;
            this.lblAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdd.Location = new System.Drawing.Point(702, 272);
            this.lblAdd.Name = "lblAdd";
            this.lblAdd.Size = new System.Drawing.Size(181, 31);
            this.lblAdd.TabIndex = 37;
            this.lblAdd.Text = "Add New Dog";
            this.lblAdd.Visible = false;
            // 
            // chkNewBasic
            // 
            this.chkNewBasic.AutoSize = true;
            this.chkNewBasic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkNewBasic.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkNewBasic.Location = new System.Drawing.Point(798, 576);
            this.chkNewBasic.Name = "chkNewBasic";
            this.chkNewBasic.Size = new System.Drawing.Size(15, 14);
            this.chkNewBasic.TabIndex = 9;
            this.chkNewBasic.UseVisualStyleBackColor = true;
            this.chkNewBasic.Visible = false;
            this.chkNewBasic.CheckedChanged += new System.EventHandler(this.chkNewBasic_CheckedChanged);
            // 
            // txtNewDogName
            // 
            this.txtNewDogName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNewDogName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewDogName.Location = new System.Drawing.Point(798, 433);
            this.txtNewDogName.Name = "txtNewDogName";
            this.txtNewDogName.Size = new System.Drawing.Size(225, 29);
            this.txtNewDogName.TabIndex = 4;
            this.txtNewDogName.Visible = false;
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnSaveChanges.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveChanges.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveChanges.Location = new System.Drawing.Point(638, 638);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(211, 32);
            this.btnSaveChanges.TabIndex = 16;
            this.btnSaveChanges.Text = "Save Changes";
            this.btnSaveChanges.UseVisualStyleBackColor = false;
            this.btnSaveChanges.Visible = false;
            this.btnSaveChanges.Click += new System.EventHandler(this.btnSaveChanges_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(855, 638);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(211, 32);
            this.btnDelete.TabIndex = 17;
            this.btnDelete.Text = "Archive Dog";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Visible = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSaveNewDog
            // 
            this.btnSaveNewDog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnSaveNewDog.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveNewDog.Enabled = false;
            this.btnSaveNewDog.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveNewDog.Location = new System.Drawing.Point(757, 638);
            this.btnSaveNewDog.Name = "btnSaveNewDog";
            this.btnSaveNewDog.Size = new System.Drawing.Size(211, 32);
            this.btnSaveNewDog.TabIndex = 10;
            this.btnSaveNewDog.TabStop = false;
            this.btnSaveNewDog.Text = "Save Dog";
            this.btnSaveNewDog.UseVisualStyleBackColor = false;
            this.btnSaveNewDog.Visible = false;
            this.btnSaveNewDog.Click += new System.EventHandler(this.btnSaveNewDog_Click);
            // 
            // cmbEditDOBDay
            // 
            this.cmbEditDOBDay.DropDownHeight = 150;
            this.cmbEditDOBDay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEditDOBDay.Enabled = false;
            this.cmbEditDOBDay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbEditDOBDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEditDOBDay.FormattingEnabled = true;
            this.cmbEditDOBDay.IntegralHeight = false;
            this.cmbEditDOBDay.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.cmbEditDOBDay.Location = new System.Drawing.Point(797, 522);
            this.cmbEditDOBDay.Name = "cmbEditDOBDay";
            this.cmbEditDOBDay.Size = new System.Drawing.Size(60, 32);
            this.cmbEditDOBDay.TabIndex = 13;
            this.cmbEditDOBDay.Visible = false;
            this.cmbEditDOBDay.SelectedIndexChanged += new System.EventHandler(this.cmbEditDOBDay_SelectedIndexChanged);
            // 
            // cmbEditDOBMonth
            // 
            this.cmbEditDOBMonth.DropDownHeight = 150;
            this.cmbEditDOBMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEditDOBMonth.Enabled = false;
            this.cmbEditDOBMonth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbEditDOBMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEditDOBMonth.FormattingEnabled = true;
            this.cmbEditDOBMonth.IntegralHeight = false;
            this.cmbEditDOBMonth.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12"});
            this.cmbEditDOBMonth.Location = new System.Drawing.Point(864, 522);
            this.cmbEditDOBMonth.Name = "cmbEditDOBMonth";
            this.cmbEditDOBMonth.Size = new System.Drawing.Size(59, 32);
            this.cmbEditDOBMonth.TabIndex = 14;
            this.cmbEditDOBMonth.Visible = false;
            this.cmbEditDOBMonth.SelectedIndexChanged += new System.EventHandler(this.cmbEditDOBMonth_SelectedIndexChanged);
            // 
            // cmbEditDOBYear
            // 
            this.cmbEditDOBYear.DropDownHeight = 150;
            this.cmbEditDOBYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEditDOBYear.Enabled = false;
            this.cmbEditDOBYear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbEditDOBYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEditDOBYear.FormattingEnabled = true;
            this.cmbEditDOBYear.IntegralHeight = false;
            this.cmbEditDOBYear.Items.AddRange(new object[] {
            "2000",
            "2001",
            "2002",
            "2003",
            "2004",
            "2005",
            "2006",
            "2007",
            "2008",
            "2009",
            "2010",
            "2011",
            "2012",
            "2013",
            "2014",
            "2015",
            "2016",
            "2017",
            "2018",
            "2019",
            "2020"});
            this.cmbEditDOBYear.Location = new System.Drawing.Point(928, 522);
            this.cmbEditDOBYear.Name = "cmbEditDOBYear";
            this.cmbEditDOBYear.Size = new System.Drawing.Size(95, 32);
            this.cmbEditDOBYear.TabIndex = 15;
            this.cmbEditDOBYear.Visible = false;
            this.cmbEditDOBYear.SelectedIndexChanged += new System.EventHandler(this.cmbEditDOBYear_SelectedIndexChanged);
            // 
            // cmbAddDOBYear
            // 
            this.cmbAddDOBYear.DropDownHeight = 150;
            this.cmbAddDOBYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAddDOBYear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbAddDOBYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAddDOBYear.FormattingEnabled = true;
            this.cmbAddDOBYear.IntegralHeight = false;
            this.cmbAddDOBYear.Items.AddRange(new object[] {
            "2000",
            "2001",
            "2002",
            "2003",
            "2004",
            "2005",
            "2006",
            "2007",
            "2008",
            "2009",
            "2010",
            "2011",
            "2012",
            "2013",
            "2014",
            "2015",
            "2016",
            "2017",
            "2018",
            "2019",
            "2020",
            "2021"});
            this.cmbAddDOBYear.Location = new System.Drawing.Point(927, 522);
            this.cmbAddDOBYear.Name = "cmbAddDOBYear";
            this.cmbAddDOBYear.Size = new System.Drawing.Size(95, 32);
            this.cmbAddDOBYear.TabIndex = 8;
            this.cmbAddDOBYear.Visible = false;
            this.cmbAddDOBYear.SelectedIndexChanged += new System.EventHandler(this.cmbAddDOBYear_SelectedIndexChanged);
            // 
            // cmbAddDOBMonth
            // 
            this.cmbAddDOBMonth.DropDownHeight = 150;
            this.cmbAddDOBMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAddDOBMonth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbAddDOBMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAddDOBMonth.FormattingEnabled = true;
            this.cmbAddDOBMonth.IntegralHeight = false;
            this.cmbAddDOBMonth.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12"});
            this.cmbAddDOBMonth.Location = new System.Drawing.Point(864, 522);
            this.cmbAddDOBMonth.Name = "cmbAddDOBMonth";
            this.cmbAddDOBMonth.Size = new System.Drawing.Size(59, 32);
            this.cmbAddDOBMonth.TabIndex = 7;
            this.cmbAddDOBMonth.Visible = false;
            this.cmbAddDOBMonth.SelectedIndexChanged += new System.EventHandler(this.cmbAddDOBMonth_SelectedIndexChanged);
            // 
            // cmbAddDOBDay
            // 
            this.cmbAddDOBDay.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmbAddDOBDay.DropDownHeight = 150;
            this.cmbAddDOBDay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAddDOBDay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbAddDOBDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAddDOBDay.FormattingEnabled = true;
            this.cmbAddDOBDay.IntegralHeight = false;
            this.cmbAddDOBDay.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.cmbAddDOBDay.Location = new System.Drawing.Point(797, 522);
            this.cmbAddDOBDay.Name = "cmbAddDOBDay";
            this.cmbAddDOBDay.Size = new System.Drawing.Size(60, 32);
            this.cmbAddDOBDay.TabIndex = 6;
            this.cmbAddDOBDay.Visible = false;
            this.cmbAddDOBDay.SelectedIndexChanged += new System.EventHandler(this.cmbAddDOBDay_SelectedIndexChanged);
            // 
            // listBoxCustomers
            // 
            this.listBoxCustomers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.listBoxCustomers.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxCustomers.FormattingEnabled = true;
            this.listBoxCustomers.ItemHeight = 25;
            this.listBoxCustomers.Location = new System.Drawing.Point(11, 263);
            this.listBoxCustomers.Name = "listBoxCustomers";
            this.listBoxCustomers.Size = new System.Drawing.Size(266, 379);
            this.listBoxCustomers.TabIndex = 65;
            this.listBoxCustomers.Visible = false;
            this.listBoxCustomers.SelectedIndexChanged += new System.EventHandler(this.listBoxCustomers_SelectedIndexChanged);
            this.listBoxCustomers.SelectedValueChanged += new System.EventHandler(this.listBoxCustomers_SelectedValueChanged);
            // 
            // lblSelectCustomer
            // 
            this.lblSelectCustomer.AutoSize = true;
            this.lblSelectCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblSelectCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectCustomer.Location = new System.Drawing.Point(12, 179);
            this.lblSelectCustomer.Name = "lblSelectCustomer";
            this.lblSelectCustomer.Size = new System.Drawing.Size(643, 31);
            this.lblSelectCustomer.TabIndex = 66;
            this.lblSelectCustomer.Text = "Select a Customer then select a dog to edit or delete";
            this.lblSelectCustomer.Visible = false;
            // 
            // listBoxDogs
            // 
            this.listBoxDogs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.listBoxDogs.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxDogs.FormattingEnabled = true;
            this.listBoxDogs.ItemHeight = 25;
            this.listBoxDogs.Location = new System.Drawing.Point(294, 263);
            this.listBoxDogs.Name = "listBoxDogs";
            this.listBoxDogs.Size = new System.Drawing.Size(266, 379);
            this.listBoxDogs.TabIndex = 67;
            this.listBoxDogs.Visible = false;
            this.listBoxDogs.SelectedIndexChanged += new System.EventHandler(this.listBoxDogs_SelectedIndexChanged);
            // 
            // btnEditDog
            // 
            this.btnEditDog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnEditDog.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditDog.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditDog.Location = new System.Drawing.Point(65, 285);
            this.btnEditDog.Name = "btnEditDog";
            this.btnEditDog.Size = new System.Drawing.Size(525, 247);
            this.btnEditDog.TabIndex = 68;
            this.btnEditDog.Text = "View/Edit a Dog";
            this.btnEditDog.UseVisualStyleBackColor = false;
            this.btnEditDog.Click += new System.EventHandler(this.btnEditDog_Click);
            // 
            // btnAddNewDog
            // 
            this.btnAddNewDog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnAddNewDog.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddNewDog.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewDog.Location = new System.Drawing.Point(667, 285);
            this.btnAddNewDog.Name = "btnAddNewDog";
            this.btnAddNewDog.Size = new System.Drawing.Size(521, 247);
            this.btnAddNewDog.TabIndex = 69;
            this.btnAddNewDog.Text = "Add a New Dog";
            this.btnAddNewDog.UseVisualStyleBackColor = false;
            this.btnAddNewDog.Click += new System.EventHandler(this.btnAddNewDog_Click);
            // 
            // btnBackToSelection
            // 
            this.btnBackToSelection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnBackToSelection.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBackToSelection.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackToSelection.Location = new System.Drawing.Point(18, 648);
            this.btnBackToSelection.Name = "btnBackToSelection";
            this.btnBackToSelection.Size = new System.Drawing.Size(189, 64);
            this.btnBackToSelection.TabIndex = 71;
            this.btnBackToSelection.Text = "Back to Selection";
            this.btnBackToSelection.UseVisualStyleBackColor = false;
            this.btnBackToSelection.Visible = false;
            this.btnBackToSelection.Click += new System.EventHandler(this.btnBackToSelection_Click);
            // 
            // lblAddNewDog
            // 
            this.lblAddNewDog.AutoSize = true;
            this.lblAddNewDog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblAddNewDog.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddNewDog.Location = new System.Drawing.Point(12, 179);
            this.lblAddNewDog.Name = "lblAddNewDog";
            this.lblAddNewDog.Size = new System.Drawing.Size(611, 31);
            this.lblAddNewDog.TabIndex = 72;
            this.lblAddNewDog.Text = "Enter information and click save to add a new dog";
            this.lblAddNewDog.Visible = false;
            // 
            // lblSelectWhatYouWant
            // 
            this.lblSelectWhatYouWant.AutoSize = true;
            this.lblSelectWhatYouWant.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblSelectWhatYouWant.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectWhatYouWant.Location = new System.Drawing.Point(12, 179);
            this.lblSelectWhatYouWant.Name = "lblSelectWhatYouWant";
            this.lblSelectWhatYouWant.Size = new System.Drawing.Size(399, 31);
            this.lblSelectWhatYouWant.TabIndex = 73;
            this.lblSelectWhatYouWant.Text = "Select what you would like to do";
            // 
            // lblFilterCustomers
            // 
            this.lblFilterCustomers.AutoSize = true;
            this.lblFilterCustomers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblFilterCustomers.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilterCustomers.Location = new System.Drawing.Point(14, 222);
            this.lblFilterCustomers.Name = "lblFilterCustomers";
            this.lblFilterCustomers.Size = new System.Drawing.Size(253, 24);
            this.lblFilterCustomers.TabIndex = 74;
            this.lblFilterCustomers.Text = "Filter Customers by Surname";
            this.lblFilterCustomers.Visible = false;
            this.lblFilterCustomers.Click += new System.EventHandler(this.lblFilterCustomers_Click);
            // 
            // txtFilterCustomers
            // 
            this.txtFilterCustomers.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFilterCustomers.Location = new System.Drawing.Point(273, 219);
            this.txtFilterCustomers.Name = "txtFilterCustomers";
            this.txtFilterCustomers.Size = new System.Drawing.Size(177, 29);
            this.txtFilterCustomers.TabIndex = 1;
            this.txtFilterCustomers.Visible = false;
            this.txtFilterCustomers.TextChanged += new System.EventHandler(this.txtFilterCustomers_TextChanged);
            // 
            // btnClearFilter
            // 
            this.btnClearFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnClearFilter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClearFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearFilter.Location = new System.Drawing.Point(456, 218);
            this.btnClearFilter.Name = "btnClearFilter";
            this.btnClearFilter.Size = new System.Drawing.Size(81, 32);
            this.btnClearFilter.TabIndex = 76;
            this.btnClearFilter.Text = "Clear";
            this.btnClearFilter.UseVisualStyleBackColor = false;
            this.btnClearFilter.Visible = false;
            this.btnClearFilter.Click += new System.EventHandler(this.btnClearFilter_Click);
            // 
            // lblDOBValid
            // 
            this.lblDOBValid.AutoSize = true;
            this.lblDOBValid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDOBValid.ForeColor = System.Drawing.Color.Red;
            this.lblDOBValid.Location = new System.Drawing.Point(1035, 525);
            this.lblDOBValid.Name = "lblDOBValid";
            this.lblDOBValid.Size = new System.Drawing.Size(231, 20);
            this.lblDOBValid.TabIndex = 77;
            this.lblDOBValid.Text = "Dog must be 1 year or older";
            this.lblDOBValid.Visible = false;
            // 
            // clkDOB
            // 
            this.clkDOB.Tick += new System.EventHandler(this.clkDOB_Tick);
            // 
            // cmbNewOwner
            // 
            this.cmbNewOwner.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cmbNewOwner.BackColor = System.Drawing.Color.White;
            this.cmbNewOwner.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmbNewOwner.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbNewOwner.ForeColor = System.Drawing.Color.Black;
            this.cmbNewOwner.Location = new System.Drawing.Point(798, 339);
            this.cmbNewOwner.Name = "cmbNewOwner";
            this.cmbNewOwner.Size = new System.Drawing.Size(225, 32);
            this.cmbNewOwner.TabIndex = 2;
            // 
            // cmbOwner
            // 
            this.cmbOwner.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cmbOwner.BackColor = System.Drawing.Color.White;
            this.cmbOwner.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmbOwner.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbOwner.ForeColor = System.Drawing.Color.Black;
            this.cmbOwner.Location = new System.Drawing.Point(797, 339);
            this.cmbOwner.Name = "cmbOwner";
            this.cmbOwner.Size = new System.Drawing.Size(225, 32);
            this.cmbOwner.TabIndex = 9;
            // 
            // txtNewDogID
            // 
            this.txtNewDogID.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtNewDogID.BackColor = System.Drawing.Color.White;
            this.txtNewDogID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNewDogID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewDogID.ForeColor = System.Drawing.Color.Black;
            this.txtNewDogID.Location = new System.Drawing.Point(797, 390);
            this.txtNewDogID.Name = "txtNewDogID";
            this.txtNewDogID.Size = new System.Drawing.Size(225, 32);
            this.txtNewDogID.TabIndex = 3;
            // 
            // txtDogID
            // 
            this.txtDogID.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtDogID.BackColor = System.Drawing.Color.White;
            this.txtDogID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDogID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDogID.ForeColor = System.Drawing.Color.Black;
            this.txtDogID.Location = new System.Drawing.Point(797, 389);
            this.txtDogID.Name = "txtDogID";
            this.txtDogID.Size = new System.Drawing.Size(225, 32);
            this.txtDogID.TabIndex = 10;
            // 
            // txtDogBreed
            // 
            this.txtDogBreed.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtDogBreed.Enabled = false;
            this.txtDogBreed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDogBreed.FormattingEnabled = true;
            this.txtDogBreed.Items.AddRange(new object[] {
            "Boxer",
            "Bulldog",
            "Cockapoo",
            "Cocker Spaniel",
            "German Shepherd",
            "Golden Retriever",
            "Jack Russell Terrier",
            "Labrador",
            "Poodle",
            "Pug",
            "Whippet"});
            this.txtDogBreed.Location = new System.Drawing.Point(797, 480);
            this.txtDogBreed.Name = "txtDogBreed";
            this.txtDogBreed.Size = new System.Drawing.Size(224, 28);
            this.txtDogBreed.TabIndex = 78;
            this.txtDogBreed.SelectedIndexChanged += new System.EventHandler(this.txtDogBreed_SelectedIndexChanged);
            this.txtDogBreed.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDogBreed_KeyDown);
            this.txtDogBreed.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtDogBreed_MouseClick);
            // 
            // txtNewDogBreed
            // 
            this.txtNewDogBreed.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtNewDogBreed.Enabled = false;
            this.txtNewDogBreed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewDogBreed.FormattingEnabled = true;
            this.txtNewDogBreed.Items.AddRange(new object[] {
            "Boxer",
            "Bulldog",
            "Cockapoo",
            "Cocker Spaniel",
            "German Shepherd",
            "Golden Retriever",
            "Jack Russell Terrier",
            "Labrador",
            "Poodle",
            "Pug",
            "Whippet"});
            this.txtNewDogBreed.Location = new System.Drawing.Point(797, 480);
            this.txtNewDogBreed.Name = "txtNewDogBreed";
            this.txtNewDogBreed.Size = new System.Drawing.Size(224, 28);
            this.txtNewDogBreed.TabIndex = 79;
            this.txtNewDogBreed.Visible = false;
            this.txtNewDogBreed.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNewDogBreed_KeyDown);
            this.txtNewDogBreed.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtNewDogBreed_MouseClick);
            // 
            // AddEditDeleteDogs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.txtNewDogBreed);
            this.Controls.Add(this.btnAddNewDog);
            this.Controls.Add(this.txtNewDogID);
            this.Controls.Add(this.txtDogBreed);
            this.Controls.Add(this.txtDogID);
            this.Controls.Add(this.btnEditDog);
            this.Controls.Add(this.cmbOwner);
            this.Controls.Add(this.cmbNewOwner);
            this.Controls.Add(this.lblDOBValid);
            this.Controls.Add(this.btnClearFilter);
            this.Controls.Add(this.txtFilterCustomers);
            this.Controls.Add(this.lblFilterCustomers);
            this.Controls.Add(this.lblSelectWhatYouWant);
            this.Controls.Add(this.lblAddNewDog);
            this.Controls.Add(this.btnBackToSelection);
            this.Controls.Add(this.listBoxDogs);
            this.Controls.Add(this.lblSelectCustomer);
            this.Controls.Add(this.listBoxCustomers);
            this.Controls.Add(this.cmbAddDOBYear);
            this.Controls.Add(this.cmbAddDOBMonth);
            this.Controls.Add(this.cmbAddDOBDay);
            this.Controls.Add(this.cmbEditDOBYear);
            this.Controls.Add(this.cmbEditDOBMonth);
            this.Controls.Add(this.cmbEditDOBDay);
            this.Controls.Add(this.btnSaveNewDog);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSaveChanges);
            this.Controls.Add(this.chkNewBasic);
            this.Controls.Add(this.txtNewDogName);
            this.Controls.Add(this.lblAdd);
            this.Controls.Add(this.lblEditDelete);
            this.Controls.Add(this.llbCustName);
            this.Controls.Add(this.lblDOB);
            this.Controls.Add(this.lblBasicTraining);
            this.Controls.Add(this.chkBasicTraining);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblDogID);
            this.Controls.Add(this.txtDogName);
            this.Controls.Add(this.btnBack);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "AddEditDeleteDogs";
            this.Text = "10";
            this.Load += new System.EventHandler(this.txtDogBreed_Load);
            this.Controls.SetChildIndex(this.btnBack, 0);
            this.Controls.SetChildIndex(this.txtDogName, 0);
            this.Controls.SetChildIndex(this.lblDogID, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.chkBasicTraining, 0);
            this.Controls.SetChildIndex(this.lblBasicTraining, 0);
            this.Controls.SetChildIndex(this.lblDOB, 0);
            this.Controls.SetChildIndex(this.llbCustName, 0);
            this.Controls.SetChildIndex(this.lblEditDelete, 0);
            this.Controls.SetChildIndex(this.lblAdd, 0);
            this.Controls.SetChildIndex(this.txtNewDogName, 0);
            this.Controls.SetChildIndex(this.chkNewBasic, 0);
            this.Controls.SetChildIndex(this.btnSaveChanges, 0);
            this.Controls.SetChildIndex(this.btnDelete, 0);
            this.Controls.SetChildIndex(this.btnSaveNewDog, 0);
            this.Controls.SetChildIndex(this.cmbEditDOBDay, 0);
            this.Controls.SetChildIndex(this.cmbEditDOBMonth, 0);
            this.Controls.SetChildIndex(this.cmbEditDOBYear, 0);
            this.Controls.SetChildIndex(this.cmbAddDOBDay, 0);
            this.Controls.SetChildIndex(this.cmbAddDOBMonth, 0);
            this.Controls.SetChildIndex(this.cmbAddDOBYear, 0);
            this.Controls.SetChildIndex(this.listBoxCustomers, 0);
            this.Controls.SetChildIndex(this.lblSelectCustomer, 0);
            this.Controls.SetChildIndex(this.listBoxDogs, 0);
            this.Controls.SetChildIndex(this.btnBackToSelection, 0);
            this.Controls.SetChildIndex(this.lblAddNewDog, 0);
            this.Controls.SetChildIndex(this.lblSelectWhatYouWant, 0);
            this.Controls.SetChildIndex(this.lblFilterCustomers, 0);
            this.Controls.SetChildIndex(this.txtFilterCustomers, 0);
            this.Controls.SetChildIndex(this.btnClearFilter, 0);
            this.Controls.SetChildIndex(this.lblDOBValid, 0);
            this.Controls.SetChildIndex(this.cmbNewOwner, 0);
            this.Controls.SetChildIndex(this.cmbOwner, 0);
            this.Controls.SetChildIndex(this.btnEditDog, 0);
            this.Controls.SetChildIndex(this.txtDogID, 0);
            this.Controls.SetChildIndex(this.txtDogBreed, 0);
            this.Controls.SetChildIndex(this.txtNewDogID, 0);
            this.Controls.SetChildIndex(this.btnAddNewDog, 0);
            this.Controls.SetChildIndex(this.txtNewDogBreed, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TextBox txtDogName;
        private System.Windows.Forms.Label lblDogID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkBasicTraining;
        private System.Windows.Forms.Label lblBasicTraining;
        private System.Windows.Forms.Label lblDOB;
        private System.Windows.Forms.Label llbCustName;
        private System.Windows.Forms.Label lblEditDelete;
        private System.Windows.Forms.Label lblAdd;
        private System.Windows.Forms.CheckBox chkNewBasic;
        private System.Windows.Forms.TextBox txtNewDogName;
        private System.Windows.Forms.Button btnSaveChanges;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSaveNewDog;
        private System.Windows.Forms.ComboBox cmbEditDOBDay;
        private System.Windows.Forms.ComboBox cmbEditDOBMonth;
        private System.Windows.Forms.ComboBox cmbEditDOBYear;
        private System.Windows.Forms.ComboBox cmbAddDOBYear;
        private System.Windows.Forms.ComboBox cmbAddDOBMonth;
        private System.Windows.Forms.ComboBox cmbAddDOBDay;
        private System.Windows.Forms.ListBox listBoxCustomers;
        private System.Windows.Forms.Label lblSelectCustomer;
        private System.Windows.Forms.ListBox listBoxDogs;
        private System.Windows.Forms.Button btnEditDog;
        private System.Windows.Forms.Button btnAddNewDog;
        private System.Windows.Forms.Button btnBackToSelection;
        private System.Windows.Forms.Label lblAddNewDog;
        private System.Windows.Forms.Label lblSelectWhatYouWant;
        private System.Windows.Forms.Label lblFilterCustomers;
        private System.Windows.Forms.TextBox txtFilterCustomers;
        private System.Windows.Forms.Button btnClearFilter;
        private System.Windows.Forms.Label lblDOBValid;
        private System.Windows.Forms.Timer clkDOB;
        private System.Windows.Forms.Label cmbNewOwner;
        private System.Windows.Forms.Label cmbOwner;
        private System.Windows.Forms.Label txtNewDogID;
        private System.Windows.Forms.Label txtDogID;
        private System.Windows.Forms.ComboBox txtDogBreed;
        private System.Windows.Forms.ComboBox txtNewDogBreed;
    }
}