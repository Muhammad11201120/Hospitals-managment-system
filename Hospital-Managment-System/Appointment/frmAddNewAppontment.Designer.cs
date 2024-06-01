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
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblPatientID = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.lblAppontmentID = new System.Windows.Forms.Label();
            this.Label99 = new System.Windows.Forms.Label();
            this.tcPatientInfo = new System.Windows.Forms.TabControl();
            this.tbEmployeeInfo = new System.Windows.Forms.TabPage();
            this.btnDoctorInfoNext = new System.Windows.Forms.Button();
            this.tbDoctorInfo = new System.Windows.Forms.TabPage();
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ctrlPatientInfoWithFilter1 = new Hospital_Managment_System.Appointment.ctrlPatientInfoWithFilter();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.tcPatientInfo.SuspendLayout();
            this.tbEmployeeInfo.SuspendLayout();
            this.tbDoctorInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(687, 656);
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
            this.btnClose.Location = new System.Drawing.Point(530, 656);
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
            // tcPatientInfo
            // 
            this.tcPatientInfo.Controls.Add(this.tbEmployeeInfo);
            this.tcPatientInfo.Controls.Add(this.tbDoctorInfo);
            this.tcPatientInfo.Location = new System.Drawing.Point(24, 107);
            this.tcPatientInfo.Margin = new System.Windows.Forms.Padding(4);
            this.tcPatientInfo.Name = "tcPatientInfo";
            this.tcPatientInfo.SelectedIndex = 0;
            this.tcPatientInfo.Size = new System.Drawing.Size(810, 539);
            this.tcPatientInfo.TabIndex = 186;
            // 
            // tbEmployeeInfo
            // 
            this.tbEmployeeInfo.BackColor = System.Drawing.SystemColors.Control;
            this.tbEmployeeInfo.Controls.Add(this.ctrlPatientInfoWithFilter1);
            this.tbEmployeeInfo.Controls.Add(this.btnDoctorInfoNext);
            this.tbEmployeeInfo.Location = new System.Drawing.Point(4, 25);
            this.tbEmployeeInfo.Margin = new System.Windows.Forms.Padding(4);
            this.tbEmployeeInfo.Name = "tbEmployeeInfo";
            this.tbEmployeeInfo.Padding = new System.Windows.Forms.Padding(4);
            this.tbEmployeeInfo.Size = new System.Drawing.Size(802, 510);
            this.tbEmployeeInfo.TabIndex = 0;
            this.tbEmployeeInfo.Text = "Employee Info ";
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
            // 
            // tbDoctorInfo
            // 
            this.tbDoctorInfo.Controls.Add(this.dtpAppontmentDate);
            this.tbDoctorInfo.Controls.Add(this.label13);
            this.tbDoctorInfo.Controls.Add(this.lblPrice);
            this.tbDoctorInfo.Controls.Add(this.cbDoctors);
            this.tbDoctorInfo.Controls.Add(this.label1);
            this.tbDoctorInfo.Controls.Add(this.label8);
            this.tbDoctorInfo.Controls.Add(this.cbSpecialty);
            this.tbDoctorInfo.Controls.Add(this.label15);
            this.tbDoctorInfo.Controls.Add(this.pictureBox11);
            this.tbDoctorInfo.Controls.Add(this.pictureBox13);
            this.tbDoctorInfo.Controls.Add(this.pictureBox6);
            this.tbDoctorInfo.Location = new System.Drawing.Point(4, 25);
            this.tbDoctorInfo.Margin = new System.Windows.Forms.Padding(4);
            this.tbDoctorInfo.Name = "tbDoctorInfo";
            this.tbDoctorInfo.Padding = new System.Windows.Forms.Padding(4);
            this.tbDoctorInfo.Size = new System.Drawing.Size(802, 510);
            this.tbDoctorInfo.TabIndex = 1;
            this.tbDoctorInfo.Text = "Doctor Info";
            this.tbDoctorInfo.UseVisualStyleBackColor = true;
            // 
            // dtpAppontmentDate
            // 
            this.dtpAppontmentDate.Location = new System.Drawing.Point(256, 255);
            this.dtpAppontmentDate.Name = "dtpAppontmentDate";
            this.dtpAppontmentDate.Size = new System.Drawing.Size(237, 24);
            this.dtpAppontmentDate.TabIndex = 196;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(75, 255);
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
            this.lblPrice.Location = new System.Drawing.Point(638, 200);
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
            this.cbDoctors.Location = new System.Drawing.Point(256, 200);
            this.cbDoctors.Margin = new System.Windows.Forms.Padding(4);
            this.cbDoctors.Name = "cbDoctors";
            this.cbDoctors.Size = new System.Drawing.Size(237, 24);
            this.cbDoctors.TabIndex = 190;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(111, 200);
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
            this.label8.Location = new System.Drawing.Point(631, 149);
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
            this.cbSpecialty.Location = new System.Drawing.Point(256, 145);
            this.cbSpecialty.Margin = new System.Windows.Forms.Padding(4);
            this.cbSpecialty.Name = "cbSpecialty";
            this.cbSpecialty.Size = new System.Drawing.Size(237, 24);
            this.cbSpecialty.TabIndex = 186;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(85, 145);
            this.label15.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(114, 25);
            this.label15.TabIndex = 187;
            this.label15.Text = "Specialty :";
            // 
            // pictureBox11
            // 
            this.pictureBox11.Image = global::Hospital_Managment_System.Properties.Resources.Calendar_32;
            this.pictureBox11.Location = new System.Drawing.Point(211, 251);
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
            this.pictureBox13.Location = new System.Drawing.Point(211, 197);
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
            this.pictureBox6.Location = new System.Drawing.Point(211, 142);
            this.pictureBox6.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(36, 32);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 188;
            this.pictureBox6.TabStop = false;
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
            // ctrlPatientInfoWithFilter1
            // 
            this.ctrlPatientInfoWithFilter1.FilterEnabled = true;
            this.ctrlPatientInfoWithFilter1.Location = new System.Drawing.Point(6, 7);
            this.ctrlPatientInfoWithFilter1.Name = "ctrlPatientInfoWithFilter1";
            this.ctrlPatientInfoWithFilter1.ShowAddPatient = true;
            this.ctrlPatientInfoWithFilter1.Size = new System.Drawing.Size(785, 432);
            this.ctrlPatientInfoWithFilter1.TabIndex = 121;
            this.ctrlPatientInfoWithFilter1.OnPatientSelected += new System.Action<int>(this.ctrlPatientInfoWithFilter1_OnPatientSelected);
            // 
            // frmAddNewAppontment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 736);
            this.Controls.Add(this.tcPatientInfo);
            this.Controls.Add(this.lblAppontmentID);
            this.Controls.Add(this.Label99);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblPatientID);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmAddNewAppontment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAddNewForm";
            this.Load += new System.EventHandler(this.frmAddNewAppontment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.tcPatientInfo.ResumeLayout(false);
            this.tbEmployeeInfo.ResumeLayout(false);
            this.tbDoctorInfo.ResumeLayout(false);
            this.tbDoctorInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblPatientID;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label lblAppontmentID;
        private System.Windows.Forms.Label Label99;
        private System.Windows.Forms.TabControl tcPatientInfo;
        private System.Windows.Forms.TabPage tbEmployeeInfo;
        private System.Windows.Forms.Button btnDoctorInfoNext;
        private System.Windows.Forms.TabPage tbDoctorInfo;
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
    }
}