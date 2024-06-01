namespace Hospital_Managment_System.Appointment
{
    partial class frmAddNewAppontment
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
            this.btnSave = new System.Windows.Forms.Button();
            this.tcPatientInfo = new System.Windows.Forms.TabControl();
            this.tbPatientInfo = new System.Windows.Forms.TabPage();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.cbCountry = new System.Windows.Forms.ComboBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.dtpDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNationalNo = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.btnDoctorInfoNext = new System.Windows.Forms.Button();
            this.tbAppontmentInfo = new System.Windows.Forms.TabPage();
            this.dtpAppontmentDate = new System.Windows.Forms.DateTimePicker();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.label13 = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.cbDoctors = new System.Windows.Forms.ComboBox();
            this.pictureBox13 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cbSpecialty = new System.Windows.Forms.ComboBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.label15 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblTitle = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblPatientID = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.lblAppontmentID = new System.Windows.Forms.Label();
            this.Label99 = new System.Windows.Forms.Label();
            this.tcPatientInfo.SuspendLayout();
            this.tbPatientInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            this.tbAppontmentInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(665, 522);
            this.btnSave.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(147, 46);
            this.btnSave.TabIndex = 122;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tcPatientInfo
            // 
            this.tcPatientInfo.Controls.Add(this.tbPatientInfo);
            this.tcPatientInfo.Controls.Add(this.tbAppontmentInfo);
            this.tcPatientInfo.Location = new System.Drawing.Point(13, 97);
            this.tcPatientInfo.Margin = new System.Windows.Forms.Padding(4);
            this.tcPatientInfo.Name = "tcPatientInfo";
            this.tcPatientInfo.SelectedIndex = 0;
            this.tcPatientInfo.Size = new System.Drawing.Size(803, 415);
            this.tcPatientInfo.TabIndex = 121;
            // 
            // tbPatientInfo
            // 
            this.tbPatientInfo.BackColor = System.Drawing.Color.Gainsboro;
            this.tbPatientInfo.Controls.Add(this.txtLastName);
            this.tbPatientInfo.Controls.Add(this.pictureBox9);
            this.tbPatientInfo.Controls.Add(this.pictureBox2);
            this.tbPatientInfo.Controls.Add(this.rbFemale);
            this.tbPatientInfo.Controls.Add(this.rbMale);
            this.tbPatientInfo.Controls.Add(this.label5);
            this.tbPatientInfo.Controls.Add(this.cbCountry);
            this.tbPatientInfo.Controls.Add(this.pictureBox8);
            this.tbPatientInfo.Controls.Add(this.label10);
            this.tbPatientInfo.Controls.Add(this.label7);
            this.tbPatientInfo.Controls.Add(this.pictureBox7);
            this.tbPatientInfo.Controls.Add(this.pictureBox3);
            this.tbPatientInfo.Controls.Add(this.pictureBox5);
            this.tbPatientInfo.Controls.Add(this.pictureBox4);
            this.tbPatientInfo.Controls.Add(this.pictureBox10);
            this.tbPatientInfo.Controls.Add(this.pictureBox12);
            this.tbPatientInfo.Controls.Add(this.dtpDateOfBirth);
            this.tbPatientInfo.Controls.Add(this.label2);
            this.tbPatientInfo.Controls.Add(this.txtAddress);
            this.tbPatientInfo.Controls.Add(this.label12);
            this.tbPatientInfo.Controls.Add(this.txtEmail);
            this.tbPatientInfo.Controls.Add(this.label6);
            this.tbPatientInfo.Controls.Add(this.txtPhone);
            this.tbPatientInfo.Controls.Add(this.label4);
            this.tbPatientInfo.Controls.Add(this.label3);
            this.tbPatientInfo.Controls.Add(this.txtNationalNo);
            this.tbPatientInfo.Controls.Add(this.label9);
            this.tbPatientInfo.Controls.Add(this.label11);
            this.tbPatientInfo.Controls.Add(this.txtFirstName);
            this.tbPatientInfo.Controls.Add(this.btnDoctorInfoNext);
            this.tbPatientInfo.Location = new System.Drawing.Point(4, 25);
            this.tbPatientInfo.Margin = new System.Windows.Forms.Padding(4);
            this.tbPatientInfo.Name = "tbPatientInfo";
            this.tbPatientInfo.Padding = new System.Windows.Forms.Padding(4);
            this.tbPatientInfo.Size = new System.Drawing.Size(795, 386);
            this.tbPatientInfo.TabIndex = 0;
            this.tbPatientInfo.Text = "Patient Info ";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(493, 63);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtLastName.MaxLength = 50;
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(272, 24);
            this.txtLastName.TabIndex = 155;
            this.txtLastName.Validating += new System.ComponentModel.CancelEventHandler(this.ValidateEmptyTextBox);
            // 
            // pictureBox9
            // 
            this.pictureBox9.Image = global::Hospital_Managment_System.Properties.Resources.Woman_32;
            this.pictureBox9.Location = new System.Drawing.Point(255, 139);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(31, 26);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox9.TabIndex = 150;
            this.pictureBox9.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Hospital_Managment_System.Properties.Resources.Man_32;
            this.pictureBox2.Location = new System.Drawing.Point(147, 139);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(31, 26);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 149;
            this.pictureBox2.TabStop = false;
            // 
            // rbFemale
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.Location = new System.Drawing.Point(292, 139);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(71, 21);
            this.rbFemale.TabIndex = 125;
            this.rbFemale.Text = "Female";
            this.rbFemale.UseVisualStyleBackColor = true;
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Checked = true;
            this.rbMale.Location = new System.Drawing.Point(189, 139);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(55, 21);
            this.rbMale.TabIndex = 124;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "Male";
            this.rbMale.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(50, 138);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 25);
            this.label5.TabIndex = 148;
            this.label5.Text = "Gendor:";
            // 
            // cbCountry
            // 
            this.cbCountry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCountry.FormattingEnabled = true;
            this.cbCountry.Location = new System.Drawing.Point(598, 176);
            this.cbCountry.Name = "cbCountry";
            this.cbCountry.Size = new System.Drawing.Size(167, 24);
            this.cbCountry.TabIndex = 128;
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = global::Hospital_Managment_System.Properties.Resources.Person_32;
            this.pictureBox8.Location = new System.Drawing.Point(147, 63);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(31, 26);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox8.TabIndex = 147;
            this.pictureBox8.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(613, 33);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 25);
            this.label10.TabIndex = 146;
            this.label10.Text = "Last";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(287, 33);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 25);
            this.label7.TabIndex = 145;
            this.label7.Text = "First";
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::Hospital_Managment_System.Properties.Resources.Address_32;
            this.pictureBox7.Location = new System.Drawing.Point(147, 215);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(31, 26);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 144;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Hospital_Managment_System.Properties.Resources.Country_32;
            this.pictureBox3.Location = new System.Drawing.Point(560, 179);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(31, 26);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 143;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::Hospital_Managment_System.Properties.Resources.Email_32;
            this.pictureBox5.Location = new System.Drawing.Point(147, 176);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(31, 26);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 142;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Hospital_Managment_System.Properties.Resources.Calendar_32;
            this.pictureBox4.Location = new System.Drawing.Point(560, 104);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(31, 26);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 141;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox10
            // 
            this.pictureBox10.Image = global::Hospital_Managment_System.Properties.Resources.Count_32;
            this.pictureBox10.Location = new System.Drawing.Point(147, 102);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(31, 26);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox10.TabIndex = 140;
            this.pictureBox10.TabStop = false;
            // 
            // pictureBox12
            // 
            this.pictureBox12.Image = global::Hospital_Managment_System.Properties.Resources.Phone_32;
            this.pictureBox12.Location = new System.Drawing.Point(559, 139);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Size = new System.Drawing.Size(31, 26);
            this.pictureBox12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox12.TabIndex = 139;
            this.pictureBox12.TabStop = false;
            // 
            // dtpDateOfBirth
            // 
            this.dtpDateOfBirth.CustomFormat = "dd/M/yyyy";
            this.dtpDateOfBirth.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDateOfBirth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDateOfBirth.Location = new System.Drawing.Point(598, 102);
            this.dtpDateOfBirth.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtpDateOfBirth.Name = "dtpDateOfBirth";
            this.dtpDateOfBirth.Size = new System.Drawing.Size(167, 27);
            this.dtpDateOfBirth.TabIndex = 123;
            this.dtpDateOfBirth.Value = new System.DateTime(2000, 12, 31, 0, 0, 0, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(463, 179);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 25);
            this.label2.TabIndex = 138;
            this.label2.Text = "Country:";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(185, 215);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAddress.MaxLength = 50;
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(580, 94);
            this.txtAddress.TabIndex = 129;
            this.txtAddress.Validating += new System.ComponentModel.CancelEventHandler(this.ValidateEmptyTextBox);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(41, 214);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(99, 25);
            this.label12.TabIndex = 137;
            this.label12.Text = "Address:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(185, 176);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtEmail.MaxLength = 50;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(167, 24);
            this.txtEmail.TabIndex = 127;
            this.txtEmail.Validating += new System.ComponentModel.CancelEventHandler(this.txtEmail_Validating);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(68, 175);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 25);
            this.label6.TabIndex = 136;
            this.label6.Text = "Email:";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(598, 139);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPhone.MaxLength = 50;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(167, 24);
            this.txtPhone.TabIndex = 126;
            this.txtPhone.Validating += new System.ComponentModel.CancelEventHandler(this.ValidateEmptyTextBox);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(477, 139);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 25);
            this.label4.TabIndex = 135;
            this.label4.Text = "Phone:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(415, 105);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 25);
            this.label3.TabIndex = 134;
            this.label3.Text = "Date Of Birth:";
            // 
            // txtNationalNo
            // 
            this.txtNationalNo.Location = new System.Drawing.Point(185, 102);
            this.txtNationalNo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNationalNo.MaxLength = 50;
            this.txtNationalNo.Name = "txtNationalNo";
            this.txtNationalNo.Size = new System.Drawing.Size(167, 24);
            this.txtNationalNo.TabIndex = 122;
            this.txtNationalNo.Validating += new System.ComponentModel.CancelEventHandler(this.txtNationalNo_Validating);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(9, 102);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(131, 25);
            this.label9.TabIndex = 133;
            this.label9.Text = "National No:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(65, 65);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(75, 25);
            this.label11.TabIndex = 132;
            this.label11.Text = "Name:";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(185, 63);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtFirstName.MaxLength = 50;
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(272, 24);
            this.txtFirstName.TabIndex = 121;
            this.txtFirstName.Validating += new System.ComponentModel.CancelEventHandler(this.ValidateEmptyTextBox);
            // 
            // btnDoctorInfoNext
            // 
            this.btnDoctorInfoNext.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDoctorInfoNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoctorInfoNext.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDoctorInfoNext.Location = new System.Drawing.Point(618, 326);
            this.btnDoctorInfoNext.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnDoctorInfoNext.Name = "btnDoctorInfoNext";
            this.btnDoctorInfoNext.Size = new System.Drawing.Size(147, 46);
            this.btnDoctorInfoNext.TabIndex = 120;
            this.btnDoctorInfoNext.Text = "Next";
            this.btnDoctorInfoNext.UseVisualStyleBackColor = true;
            this.btnDoctorInfoNext.Click += new System.EventHandler(this.btnDoctorInfoNext_Click);
            // 
            // tbAppontmentInfo
            // 
            this.tbAppontmentInfo.BackColor = System.Drawing.Color.Silver;
            this.tbAppontmentInfo.Controls.Add(this.dtpAppontmentDate);
            this.tbAppontmentInfo.Controls.Add(this.pictureBox11);
            this.tbAppontmentInfo.Controls.Add(this.label13);
            this.tbAppontmentInfo.Controls.Add(this.lblPrice);
            this.tbAppontmentInfo.Controls.Add(this.cbDoctors);
            this.tbAppontmentInfo.Controls.Add(this.pictureBox13);
            this.tbAppontmentInfo.Controls.Add(this.label1);
            this.tbAppontmentInfo.Controls.Add(this.label8);
            this.tbAppontmentInfo.Controls.Add(this.cbSpecialty);
            this.tbAppontmentInfo.Controls.Add(this.pictureBox6);
            this.tbAppontmentInfo.Controls.Add(this.label15);
            this.tbAppontmentInfo.Location = new System.Drawing.Point(4, 25);
            this.tbAppontmentInfo.Margin = new System.Windows.Forms.Padding(4);
            this.tbAppontmentInfo.Name = "tbAppontmentInfo";
            this.tbAppontmentInfo.Padding = new System.Windows.Forms.Padding(4);
            this.tbAppontmentInfo.Size = new System.Drawing.Size(795, 386);
            this.tbAppontmentInfo.TabIndex = 1;
            this.tbAppontmentInfo.Text = "Appontment Info";
            // 
            // dtpAppontmentDate
            // 
            this.dtpAppontmentDate.Location = new System.Drawing.Point(190, 165);
            this.dtpAppontmentDate.Name = "dtpAppontmentDate";
            this.dtpAppontmentDate.Size = new System.Drawing.Size(237, 24);
            this.dtpAppontmentDate.TabIndex = 163;
            // 
            // pictureBox11
            // 
            this.pictureBox11.Image = global::Hospital_Managment_System.Properties.Resources.Calendar_32;
            this.pictureBox11.Location = new System.Drawing.Point(145, 161);
            this.pictureBox11.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(36, 32);
            this.pictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox11.TabIndex = 162;
            this.pictureBox11.TabStop = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(9, 165);
            this.label13.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(124, 25);
            this.label13.TabIndex = 161;
            this.label13.Text = "Date Time :";
            // 
            // lblPrice
            // 
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblPrice.Location = new System.Drawing.Point(572, 110);
            this.lblPrice.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(86, 49);
            this.lblPrice.TabIndex = 159;
            this.lblPrice.Text = "0";
            this.lblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbDoctors
            // 
            this.cbDoctors.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDoctors.FormattingEnabled = true;
            this.cbDoctors.Location = new System.Drawing.Point(190, 110);
            this.cbDoctors.Margin = new System.Windows.Forms.Padding(4);
            this.cbDoctors.Name = "cbDoctors";
            this.cbDoctors.Size = new System.Drawing.Size(237, 24);
            this.cbDoctors.TabIndex = 119;
            this.cbDoctors.SelectedIndexChanged += new System.EventHandler(this.cbDoctors_SelectedIndexChanged);
            // 
            // pictureBox13
            // 
            this.pictureBox13.Image = global::Hospital_Managment_System.Properties.Resources.doctor1;
            this.pictureBox13.Location = new System.Drawing.Point(145, 107);
            this.pictureBox13.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox13.Name = "pictureBox13";
            this.pictureBox13.Size = new System.Drawing.Size(36, 32);
            this.pictureBox13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox13.TabIndex = 121;
            this.pictureBox13.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 110);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 25);
            this.label1.TabIndex = 120;
            this.label1.Text = "Doctor :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(565, 59);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 25);
            this.label8.TabIndex = 117;
            this.label8.Text = "Price :";
            // 
            // cbSpecialty
            // 
            this.cbSpecialty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSpecialty.FormattingEnabled = true;
            this.cbSpecialty.Location = new System.Drawing.Point(190, 55);
            this.cbSpecialty.Margin = new System.Windows.Forms.Padding(4);
            this.cbSpecialty.Name = "cbSpecialty";
            this.cbSpecialty.Size = new System.Drawing.Size(237, 24);
            this.cbSpecialty.TabIndex = 99;
            this.cbSpecialty.SelectedIndexChanged += new System.EventHandler(this.cbSpecialty_SelectedIndexChanged);
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::Hospital_Managment_System.Properties.Resources.task_types;
            this.pictureBox6.Location = new System.Drawing.Point(145, 52);
            this.pictureBox6.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(36, 32);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 101;
            this.pictureBox6.TabStop = false;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(19, 55);
            this.label15.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(114, 25);
            this.label15.TabIndex = 100;
            this.label15.Text = "Specialty :";
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(509, 522);
            this.btnClose.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(147, 46);
            this.btnClose.TabIndex = 123;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTitle.Location = new System.Drawing.Point(-254, 9);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(1458, 49);
            this.lblTitle.TabIndex = 126;
            this.lblTitle.Text = "Add New Appontment";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Hospital_Managment_System.Properties.Resources.PersonDetails_321;
            this.pictureBox1.Location = new System.Drawing.Point(145, 64);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(31, 26);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 158;
            this.pictureBox1.TabStop = false;
            // 
            // lblPatientID
            // 
            this.lblPatientID.AutoSize = true;
            this.lblPatientID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPatientID.Location = new System.Drawing.Point(186, 64);
            this.lblPatientID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPatientID.Name = "lblPatientID";
            this.lblPatientID.Size = new System.Drawing.Size(49, 25);
            this.lblPatientID.TabIndex = 157;
            this.lblPatientID.Text = "N/A";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(19, 64);
            this.label22.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(119, 25);
            this.label22.TabIndex = 156;
            this.label22.Text = "Patient ID :";
            // 
            // lblAppontmentID
            // 
            this.lblAppontmentID.AutoSize = true;
            this.lblAppontmentID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppontmentID.Location = new System.Drawing.Point(719, 64);
            this.lblAppontmentID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAppontmentID.Name = "lblAppontmentID";
            this.lblAppontmentID.Size = new System.Drawing.Size(49, 25);
            this.lblAppontmentID.TabIndex = 160;
            this.lblAppontmentID.Text = "N/A";
            // 
            // Label99
            // 
            this.Label99.AutoSize = true;
            this.Label99.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label99.Location = new System.Drawing.Point(543, 64);
            this.Label99.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label99.Name = "Label99";
            this.Label99.Size = new System.Drawing.Size(168, 25);
            this.Label99.TabIndex = 159;
            this.Label99.Text = "Appontment ID :";
            // 
            // frmAddNewAppontment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 594);
            this.Controls.Add(this.lblAppontmentID);
            this.Controls.Add(this.Label99);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblPatientID);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tcPatientInfo);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmAddNewAppontment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAddNewForm";
            this.Load += new System.EventHandler(this.frmAddNewAppontment_Load);
            this.tcPatientInfo.ResumeLayout(false);
            this.tbPatientInfo.ResumeLayout(false);
            this.tbPatientInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            this.tbAppontmentInfo.ResumeLayout(false);
            this.tbAppontmentInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TabControl tcPatientInfo;
        private System.Windows.Forms.TabPage tbPatientInfo;
        private System.Windows.Forms.Button btnDoctorInfoNext;
        private System.Windows.Forms.TabPage tbAppontmentInfo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbSpecialty;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.RadioButton rbFemale;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbCountry;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.PictureBox pictureBox12;
        private System.Windows.Forms.DateTimePicker dtpDateOfBirth;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNationalNo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblPatientID;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.ComboBox cbDoctors;
        private System.Windows.Forms.PictureBox pictureBox13;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.DateTimePicker dtpAppontmentDate;
        private System.Windows.Forms.PictureBox pictureBox11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblAppontmentID;
        private System.Windows.Forms.Label Label99;
    }
}