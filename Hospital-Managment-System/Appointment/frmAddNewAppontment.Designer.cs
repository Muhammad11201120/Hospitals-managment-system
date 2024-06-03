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
            this.btnClose = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.tcPatientInfo = new System.Windows.Forms.TabControl();
            this.tbPatientInfo = new System.Windows.Forms.TabPage();
            this.ctrlPatientInfoWithFilter1 = new Hospital_Managment_System.Appointment.ctrlPatientInfoWithFilter();
            this.btnDoctorInfoNext = new System.Windows.Forms.Button();
            this.tbAppointmentInfo = new System.Windows.Forms.TabPage();
            this.txtAppointmentDate = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.flpAvailableAppointments = new System.Windows.Forms.FlowLayoutPanel();
            this.lblAppontmentID = new System.Windows.Forms.Label();
            this.Label99 = new System.Windows.Forms.Label();
            this.dtpAppontmentDate = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.cbDoctors = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cbSpecialty = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.pictureBox13 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tcPatientInfo.SuspendLayout();
            this.tbPatientInfo.SuspendLayout();
            this.tbAppointmentInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(687, 630);
            this.btnSave.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(147, 46);
            this.btnSave.TabIndex = 122;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(530, 630);
            this.btnClose.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(147, 46);
            this.btnClose.TabIndex = 123;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(879, 49);
            this.lblTitle.TabIndex = 126;
            this.lblTitle.Text = "Add New Appontment";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tcPatientInfo
            // 
            this.tcPatientInfo.Controls.Add(this.tbPatientInfo);
            this.tcPatientInfo.Controls.Add(this.tbAppointmentInfo);
            this.tcPatientInfo.Location = new System.Drawing.Point(24, 81);
            this.tcPatientInfo.Margin = new System.Windows.Forms.Padding(4);
            this.tcPatientInfo.Name = "tcPatientInfo";
            this.tcPatientInfo.SelectedIndex = 0;
            this.tcPatientInfo.Size = new System.Drawing.Size(835, 539);
            this.tcPatientInfo.TabIndex = 186;
            this.tcPatientInfo.SelectedIndexChanged += new System.EventHandler(this.tcPatientInfo_SelectedIndexChanged);
            // 
            // tbPatientInfo
            // 
            this.tbPatientInfo.BackColor = System.Drawing.SystemColors.Control;
            this.tbPatientInfo.Controls.Add(this.ctrlPatientInfoWithFilter1);
            this.tbPatientInfo.Controls.Add(this.btnDoctorInfoNext);
            this.tbPatientInfo.Location = new System.Drawing.Point(4, 25);
            this.tbPatientInfo.Margin = new System.Windows.Forms.Padding(4);
            this.tbPatientInfo.Name = "tbPatientInfo";
            this.tbPatientInfo.Padding = new System.Windows.Forms.Padding(4);
            this.tbPatientInfo.Size = new System.Drawing.Size(827, 510);
            this.tbPatientInfo.TabIndex = 0;
            this.tbPatientInfo.Text = "Patient Info ";
            // 
            // ctrlPatientInfoWithFilter1
            // 
            this.ctrlPatientInfoWithFilter1.AutoSize = true;
            this.ctrlPatientInfoWithFilter1.FilterEnabled = true;
            this.ctrlPatientInfoWithFilter1.Location = new System.Drawing.Point(6, 7);
            this.ctrlPatientInfoWithFilter1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.ctrlPatientInfoWithFilter1.Name = "ctrlPatientInfoWithFilter1";
            this.ctrlPatientInfoWithFilter1.ShowAddPatient = true;
            this.ctrlPatientInfoWithFilter1.Size = new System.Drawing.Size(805, 438);
            this.ctrlPatientInfoWithFilter1.TabIndex = 121;
            this.ctrlPatientInfoWithFilter1.OnPatientSelected += new System.Action<int>(this.ctrlPatientInfoWithFilter1_OnPatientSelected);
            // 
            // btnDoctorInfoNext
            // 
            this.btnDoctorInfoNext.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDoctorInfoNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoctorInfoNext.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDoctorInfoNext.Location = new System.Drawing.Point(644, 448);
            this.btnDoctorInfoNext.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnDoctorInfoNext.Name = "btnDoctorInfoNext";
            this.btnDoctorInfoNext.Size = new System.Drawing.Size(147, 46);
            this.btnDoctorInfoNext.TabIndex = 120;
            this.btnDoctorInfoNext.Text = "Next";
            this.btnDoctorInfoNext.UseVisualStyleBackColor = true;
            this.btnDoctorInfoNext.Click += new System.EventHandler(this.btnDoctorInfoNext_Click);
            // 
            // tbAppointmentInfo
            // 
            this.tbAppointmentInfo.Controls.Add(this.txtAppointmentDate);
            this.tbAppointmentInfo.Controls.Add(this.label3);
            this.tbAppointmentInfo.Controls.Add(this.label2);
            this.tbAppointmentInfo.Controls.Add(this.flpAvailableAppointments);
            this.tbAppointmentInfo.Controls.Add(this.lblAppontmentID);
            this.tbAppointmentInfo.Controls.Add(this.Label99);
            this.tbAppointmentInfo.Controls.Add(this.dtpAppontmentDate);
            this.tbAppointmentInfo.Controls.Add(this.label13);
            this.tbAppointmentInfo.Controls.Add(this.lblPrice);
            this.tbAppointmentInfo.Controls.Add(this.cbDoctors);
            this.tbAppointmentInfo.Controls.Add(this.label1);
            this.tbAppointmentInfo.Controls.Add(this.label8);
            this.tbAppointmentInfo.Controls.Add(this.cbSpecialty);
            this.tbAppointmentInfo.Controls.Add(this.label15);
            this.tbAppointmentInfo.Controls.Add(this.pictureBox11);
            this.tbAppointmentInfo.Controls.Add(this.pictureBox13);
            this.tbAppointmentInfo.Controls.Add(this.pictureBox6);
            this.tbAppointmentInfo.Location = new System.Drawing.Point(4, 25);
            this.tbAppointmentInfo.Margin = new System.Windows.Forms.Padding(4);
            this.tbAppointmentInfo.Name = "tbAppointmentInfo";
            this.tbAppointmentInfo.Padding = new System.Windows.Forms.Padding(4);
            this.tbAppointmentInfo.Size = new System.Drawing.Size(827, 510);
            this.tbAppointmentInfo.TabIndex = 1;
            this.tbAppointmentInfo.Text = "Appointment Info";
            this.tbAppointmentInfo.UseVisualStyleBackColor = true;
            // 
            // txtAppointmentDate
            // 
            this.txtAppointmentDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtAppointmentDate.Location = new System.Drawing.Point(135, 372);
            this.txtAppointmentDate.Margin = new System.Windows.Forms.Padding(4);
            this.txtAppointmentDate.Multiline = true;
            this.txtAppointmentDate.Name = "txtAppointmentDate";
            this.txtAppointmentDate.ReadOnly = true;
            this.txtAppointmentDate.Size = new System.Drawing.Size(179, 32);
            this.txtAppointmentDate.TabIndex = 202;
            this.txtAppointmentDate.Validating += new System.ComponentModel.CancelEventHandler(this.txtAppointmentDate_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(10, 326);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(197, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Appointment Date :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 272);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(252, 25);
            this.label2.TabIndex = 200;
            this.label2.Text = "Available Appointments :";
            // 
            // flpAvailableAppointments
            // 
            this.flpAvailableAppointments.AutoScroll = true;
            this.flpAvailableAppointments.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flpAvailableAppointments.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.flpAvailableAppointments.Location = new System.Drawing.Point(336, 272);
            this.flpAvailableAppointments.Margin = new System.Windows.Forms.Padding(4);
            this.flpAvailableAppointments.Name = "flpAvailableAppointments";
            this.flpAvailableAppointments.Size = new System.Drawing.Size(453, 158);
            this.flpAvailableAppointments.TabIndex = 199;
            // 
            // lblAppontmentID
            // 
            this.lblAppontmentID.AutoSize = true;
            this.lblAppontmentID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppontmentID.Location = new System.Drawing.Point(281, 50);
            this.lblAppontmentID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAppontmentID.Name = "lblAppontmentID";
            this.lblAppontmentID.Size = new System.Drawing.Size(49, 25);
            this.lblAppontmentID.TabIndex = 198;
            this.lblAppontmentID.Text = "N/A";
            // 
            // Label99
            // 
            this.Label99.AutoSize = true;
            this.Label99.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label99.Location = new System.Drawing.Point(105, 50);
            this.Label99.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label99.Name = "Label99";
            this.Label99.Size = new System.Drawing.Size(168, 25);
            this.Label99.TabIndex = 197;
            this.Label99.Text = "Appontment ID :";
            // 
            // dtpAppontmentDate
            // 
            this.dtpAppontmentDate.CustomFormat = "";
            this.dtpAppontmentDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpAppontmentDate.Location = new System.Drawing.Point(330, 219);
            this.dtpAppontmentDate.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.dtpAppontmentDate.Name = "dtpAppontmentDate";
            this.dtpAppontmentDate.Size = new System.Drawing.Size(237, 24);
            this.dtpAppontmentDate.TabIndex = 196;
            this.dtpAppontmentDate.Value = new System.DateTime(2024, 6, 3, 9, 26, 55, 0);
            this.dtpAppontmentDate.ValueChanged += new System.EventHandler(this.dtpAppontmentDate_ValueChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(149, 219);
            this.label13.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(124, 25);
            this.label13.TabIndex = 194;
            this.label13.Text = "Date Time :";
            // 
            // lblPrice
            // 
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblPrice.Location = new System.Drawing.Point(239, 454);
            this.lblPrice.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(86, 49);
            this.lblPrice.TabIndex = 193;
            this.lblPrice.Text = "0";
            this.lblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbDoctors
            // 
            this.cbDoctors.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDoctors.FormattingEnabled = true;
            this.cbDoctors.Location = new System.Drawing.Point(330, 164);
            this.cbDoctors.Margin = new System.Windows.Forms.Padding(4);
            this.cbDoctors.Name = "cbDoctors";
            this.cbDoctors.Size = new System.Drawing.Size(237, 24);
            this.cbDoctors.TabIndex = 190;
            this.cbDoctors.SelectedIndexChanged += new System.EventHandler(this.cbDoctors_SelectedIndexChanged_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(186, 164);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 25);
            this.label1.TabIndex = 191;
            this.label1.Text = "Doctor :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(134, 466);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 25);
            this.label8.TabIndex = 189;
            this.label8.Text = "Price :";
            // 
            // cbSpecialty
            // 
            this.cbSpecialty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSpecialty.FormattingEnabled = true;
            this.cbSpecialty.Location = new System.Drawing.Point(330, 108);
            this.cbSpecialty.Margin = new System.Windows.Forms.Padding(4);
            this.cbSpecialty.Name = "cbSpecialty";
            this.cbSpecialty.Size = new System.Drawing.Size(237, 24);
            this.cbSpecialty.TabIndex = 186;
            this.cbSpecialty.SelectedIndexChanged += new System.EventHandler(this.cbSpecialty_SelectedIndexChanged_1);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(159, 108);
            this.label15.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(114, 25);
            this.label15.TabIndex = 187;
            this.label15.Text = "Specialty :";
            // 
            // pictureBox11
            // 
            this.pictureBox11.Image = global::Hospital_Managment_System.Properties.Resources.Calendar_32;
            this.pictureBox11.Location = new System.Drawing.Point(285, 214);
            this.pictureBox11.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(36, 32);
            this.pictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox11.TabIndex = 195;
            this.pictureBox11.TabStop = false;
            // 
            // pictureBox13
            // 
            this.pictureBox13.Image = global::Hospital_Managment_System.Properties.Resources.doctor1;
            this.pictureBox13.Location = new System.Drawing.Point(285, 161);
            this.pictureBox13.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox13.Name = "pictureBox13";
            this.pictureBox13.Size = new System.Drawing.Size(36, 32);
            this.pictureBox13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox13.TabIndex = 192;
            this.pictureBox13.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::Hospital_Managment_System.Properties.Resources.task_types;
            this.pictureBox6.Location = new System.Drawing.Point(285, 106);
            this.pictureBox6.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(36, 32);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 188;
            this.pictureBox6.TabStop = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmAddNewAppontment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(879, 736);
            this.Controls.Add(this.tcPatientInfo);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Name = "frmAddNewAppontment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAddNewForm";
            this.Load += new System.EventHandler(this.frmAddNewAppontment_Load);
            this.tcPatientInfo.ResumeLayout(false);
            this.tbPatientInfo.ResumeLayout(false);
            this.tbPatientInfo.PerformLayout();
            this.tbAppointmentInfo.ResumeLayout(false);
            this.tbAppointmentInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TabControl tcPatientInfo;
        private System.Windows.Forms.TabPage tbPatientInfo;
        private System.Windows.Forms.Button btnDoctorInfoNext;
        private System.Windows.Forms.TabPage tbAppointmentInfo;
        private System.Windows.Forms.DateTimePicker dtpAppontmentDate;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.ComboBox cbDoctors;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbSpecialty;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.PictureBox pictureBox11;
        private System.Windows.Forms.PictureBox pictureBox13;
        private System.Windows.Forms.PictureBox pictureBox6;
        private ctrlPatientInfoWithFilter ctrlPatientInfoWithFilter1;
        private System.Windows.Forms.Label lblAppontmentID;
        private System.Windows.Forms.Label Label99;
        private System.Windows.Forms.FlowLayoutPanel flpAvailableAppointments;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAppointmentDate;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}