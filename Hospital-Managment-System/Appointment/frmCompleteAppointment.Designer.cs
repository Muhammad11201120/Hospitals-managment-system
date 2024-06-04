namespace Hospital_Managment_System.Appointment
{
    partial class frmCompleteAppointment
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
            this.panelForms = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.gbNeedPrescription = new System.Windows.Forms.GroupBox();
            this.chkNo = new System.Windows.Forms.RadioButton();
            this.chkYes = new System.Windows.Forms.RadioButton();
            this.gbPrescription = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.txtSpecialInstructions = new System.Windows.Forms.TextBox();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.txtFrequency = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDosage = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMedicationName = new System.Windows.Forms.TextBox();
            this.gbMedicalRecordInfo = new System.Windows.Forms.GroupBox();
            this.lblAppointmentID = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtAdditionalNotes = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblPatientName = new System.Windows.Forms.Label();
            this.lblNationalNo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDiagnosis = new System.Windows.Forms.TextBox();
            this.txtVisitDescription = new System.Windows.Forms.TextBox();
            this.lblVisitDescriptionLength = new System.Windows.Forms.Label();
            this.lblDiagnosisLength = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblSpecialInstructionsLength = new System.Windows.Forms.Label();
            this.panelForms.SuspendLayout();
            this.gbNeedPrescription.SuspendLayout();
            this.gbPrescription.SuspendLayout();
            this.gbMedicalRecordInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelForms
            // 
            this.panelForms.BackColor = System.Drawing.SystemColors.Control;
            this.panelForms.Controls.Add(this.btnCancel);
            this.panelForms.Controls.Add(this.btnSave);
            this.panelForms.Controls.Add(this.gbNeedPrescription);
            this.panelForms.Controls.Add(this.gbPrescription);
            this.panelForms.Controls.Add(this.gbMedicalRecordInfo);
            this.panelForms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelForms.Location = new System.Drawing.Point(0, 0);
            this.panelForms.Name = "panelForms";
            this.panelForms.Size = new System.Drawing.Size(1440, 900);
            this.panelForms.TabIndex = 3;
            // 
            // btnCancel
            // 
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(1132, 840);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(138, 45);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(1291, 840);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(138, 45);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // gbNeedPrescription
            // 
            this.gbNeedPrescription.Controls.Add(this.chkNo);
            this.gbNeedPrescription.Controls.Add(this.chkYes);
            this.gbNeedPrescription.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbNeedPrescription.Location = new System.Drawing.Point(528, 405);
            this.gbNeedPrescription.Name = "gbNeedPrescription";
            this.gbNeedPrescription.Size = new System.Drawing.Size(341, 82);
            this.gbNeedPrescription.TabIndex = 6;
            this.gbNeedPrescription.TabStop = false;
            this.gbNeedPrescription.Text = "Need a prescription?";
            // 
            // chkNo
            // 
            this.chkNo.AutoSize = true;
            this.chkNo.Checked = true;
            this.chkNo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkNo.Location = new System.Drawing.Point(74, 43);
            this.chkNo.Name = "chkNo";
            this.chkNo.Size = new System.Drawing.Size(54, 27);
            this.chkNo.TabIndex = 3;
            this.chkNo.TabStop = true;
            this.chkNo.Text = "No";
            this.chkNo.UseVisualStyleBackColor = true;
            this.chkNo.CheckedChanged += new System.EventHandler(this.chkNo_CheckedChanged);
            // 
            // chkYes
            // 
            this.chkYes.AutoSize = true;
            this.chkYes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkYes.Location = new System.Drawing.Point(207, 43);
            this.chkYes.Name = "chkYes";
            this.chkYes.Size = new System.Drawing.Size(55, 27);
            this.chkYes.TabIndex = 4;
            this.chkYes.Text = "Yes";
            this.chkYes.UseVisualStyleBackColor = true;
            this.chkYes.CheckedChanged += new System.EventHandler(this.chkYes_CheckedChanged);
            // 
            // gbPrescription
            // 
            this.gbPrescription.Controls.Add(this.lblSpecialInstructionsLength);
            this.gbPrescription.Controls.Add(this.label11);
            this.gbPrescription.Controls.Add(this.label10);
            this.gbPrescription.Controls.Add(this.label9);
            this.gbPrescription.Controls.Add(this.dtpStartDate);
            this.gbPrescription.Controls.Add(this.txtSpecialInstructions);
            this.gbPrescription.Controls.Add(this.dtpEndDate);
            this.gbPrescription.Controls.Add(this.label8);
            this.gbPrescription.Controls.Add(this.txtFrequency);
            this.gbPrescription.Controls.Add(this.label4);
            this.gbPrescription.Controls.Add(this.txtDosage);
            this.gbPrescription.Controls.Add(this.label3);
            this.gbPrescription.Controls.Add(this.txtMedicationName);
            this.gbPrescription.Enabled = false;
            this.gbPrescription.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPrescription.Location = new System.Drawing.Point(20, 493);
            this.gbPrescription.Name = "gbPrescription";
            this.gbPrescription.Size = new System.Drawing.Size(1405, 325);
            this.gbPrescription.TabIndex = 3;
            this.gbPrescription.TabStop = false;
            this.gbPrescription.Text = "Prescription";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(55, 162);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(93, 23);
            this.label11.TabIndex = 15;
            this.label11.Text = "Start Date";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(505, 162);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 23);
            this.label10.TabIndex = 14;
            this.label10.Text = "End Date";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(973, 162);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(252, 23);
            this.label9.TabIndex = 11;
            this.label9.Text = "Special instructions (Optional)";
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Location = new System.Drawing.Point(59, 188);
            this.dtpStartDate.MaxDate = new System.DateTime(2026, 12, 31, 0, 0, 0, 0);
            this.dtpStartDate.MinDate = new System.DateTime(2024, 6, 4, 0, 0, 0, 0);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(301, 30);
            this.dtpStartDate.TabIndex = 8;
            this.dtpStartDate.Value = new System.DateTime(2024, 6, 4, 0, 0, 0, 0);
            // 
            // txtSpecialInstructions
            // 
            this.txtSpecialInstructions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSpecialInstructions.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSpecialInstructions.Location = new System.Drawing.Point(977, 188);
            this.txtSpecialInstructions.MaxLength = 200;
            this.txtSpecialInstructions.Multiline = true;
            this.txtSpecialInstructions.Name = "txtSpecialInstructions";
            this.txtSpecialInstructions.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtSpecialInstructions.Size = new System.Drawing.Size(341, 108);
            this.txtSpecialInstructions.TabIndex = 10;
            this.txtSpecialInstructions.TextChanged += new System.EventHandler(this.txtSpecialInstructions_TextChanged);
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Location = new System.Drawing.Point(508, 188);
            this.dtpEndDate.MinDate = new System.DateTime(2024, 6, 4, 0, 0, 0, 0);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(301, 30);
            this.dtpEndDate.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(974, 55);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 23);
            this.label8.TabIndex = 11;
            this.label8.Text = "Frequency";
            // 
            // txtFrequency
            // 
            this.txtFrequency.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFrequency.Location = new System.Drawing.Point(977, 81);
            this.txtFrequency.Name = "txtFrequency";
            this.txtFrequency.Size = new System.Drawing.Size(341, 30);
            this.txtFrequency.TabIndex = 7;
            this.txtFrequency.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFrequency_KeyPress);
            this.txtFrequency.Validating += new System.ComponentModel.CancelEventHandler(this.txtVisitDescription_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(505, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 23);
            this.label4.TabIndex = 9;
            this.label4.Text = "Dosage";
            // 
            // txtDosage
            // 
            this.txtDosage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDosage.Location = new System.Drawing.Point(508, 81);
            this.txtDosage.Name = "txtDosage";
            this.txtDosage.Size = new System.Drawing.Size(301, 30);
            this.txtDosage.TabIndex = 6;
            this.txtDosage.Validating += new System.ComponentModel.CancelEventHandler(this.txtVisitDescription_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(55, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 23);
            this.label3.TabIndex = 7;
            this.label3.Text = "Medication Name";
            // 
            // txtMedicationName
            // 
            this.txtMedicationName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMedicationName.Location = new System.Drawing.Point(58, 81);
            this.txtMedicationName.Name = "txtMedicationName";
            this.txtMedicationName.Size = new System.Drawing.Size(302, 30);
            this.txtMedicationName.TabIndex = 5;
            this.txtMedicationName.Validating += new System.ComponentModel.CancelEventHandler(this.txtVisitDescription_Validating);
            // 
            // gbMedicalRecordInfo
            // 
            this.gbMedicalRecordInfo.Controls.Add(this.lblDiagnosisLength);
            this.gbMedicalRecordInfo.Controls.Add(this.lblVisitDescriptionLength);
            this.gbMedicalRecordInfo.Controls.Add(this.lblAppointmentID);
            this.gbMedicalRecordInfo.Controls.Add(this.label13);
            this.gbMedicalRecordInfo.Controls.Add(this.label7);
            this.gbMedicalRecordInfo.Controls.Add(this.txtAdditionalNotes);
            this.gbMedicalRecordInfo.Controls.Add(this.label6);
            this.gbMedicalRecordInfo.Controls.Add(this.label5);
            this.gbMedicalRecordInfo.Controls.Add(this.lblPatientName);
            this.gbMedicalRecordInfo.Controls.Add(this.lblNationalNo);
            this.gbMedicalRecordInfo.Controls.Add(this.label2);
            this.gbMedicalRecordInfo.Controls.Add(this.label1);
            this.gbMedicalRecordInfo.Controls.Add(this.txtDiagnosis);
            this.gbMedicalRecordInfo.Controls.Add(this.txtVisitDescription);
            this.gbMedicalRecordInfo.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbMedicalRecordInfo.Location = new System.Drawing.Point(20, 21);
            this.gbMedicalRecordInfo.Name = "gbMedicalRecordInfo";
            this.gbMedicalRecordInfo.Size = new System.Drawing.Size(1405, 368);
            this.gbMedicalRecordInfo.TabIndex = 2;
            this.gbMedicalRecordInfo.TabStop = false;
            this.gbMedicalRecordInfo.Text = "Medical Record Info";
            // 
            // lblAppointmentID
            // 
            this.lblAppointmentID.AutoSize = true;
            this.lblAppointmentID.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppointmentID.ForeColor = System.Drawing.Color.Red;
            this.lblAppointmentID.Location = new System.Drawing.Point(203, 49);
            this.lblAppointmentID.Name = "lblAppointmentID";
            this.lblAppointmentID.Size = new System.Drawing.Size(70, 31);
            this.lblAppointmentID.TabIndex = 11;
            this.lblAppointmentID.Text = "[????]";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(35, 56);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(146, 23);
            this.label13.TabIndex = 10;
            this.label13.Text = "Appointment ID:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(973, 140);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(233, 23);
            this.label7.TabIndex = 9;
            this.label7.Text = "Additional Notes (Optional)";
            // 
            // txtAdditionalNotes
            // 
            this.txtAdditionalNotes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAdditionalNotes.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdditionalNotes.Location = new System.Drawing.Point(977, 166);
            this.txtAdditionalNotes.MaxLength = 200;
            this.txtAdditionalNotes.Multiline = true;
            this.txtAdditionalNotes.Name = "txtAdditionalNotes";
            this.txtAdditionalNotes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtAdditionalNotes.Size = new System.Drawing.Size(341, 162);
            this.txtAdditionalNotes.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(504, 140);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 23);
            this.label6.TabIndex = 7;
            this.label6.Text = "Diagnosis";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(55, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 23);
            this.label5.TabIndex = 6;
            this.label5.Text = "Visit Description";
            // 
            // lblPatientName
            // 
            this.lblPatientName.AutoSize = true;
            this.lblPatientName.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPatientName.ForeColor = System.Drawing.Color.Red;
            this.lblPatientName.Location = new System.Drawing.Point(585, 49);
            this.lblPatientName.Name = "lblPatientName";
            this.lblPatientName.Size = new System.Drawing.Size(70, 31);
            this.lblPatientName.TabIndex = 5;
            this.lblPatientName.Text = "[????]";
            // 
            // lblNationalNo
            // 
            this.lblNationalNo.AutoSize = true;
            this.lblNationalNo.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNationalNo.ForeColor = System.Drawing.Color.Red;
            this.lblNationalNo.Location = new System.Drawing.Point(1016, 49);
            this.lblNationalNo.Name = "lblNationalNo";
            this.lblNationalNo.Size = new System.Drawing.Size(70, 31);
            this.lblNationalNo.TabIndex = 4;
            this.lblNationalNo.Text = "[????]";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(438, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Patient Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(887, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "NationalNo:";
            // 
            // txtDiagnosis
            // 
            this.txtDiagnosis.AllowDrop = true;
            this.txtDiagnosis.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDiagnosis.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiagnosis.Location = new System.Drawing.Point(508, 166);
            this.txtDiagnosis.MaxLength = 200;
            this.txtDiagnosis.Multiline = true;
            this.txtDiagnosis.Name = "txtDiagnosis";
            this.txtDiagnosis.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDiagnosis.Size = new System.Drawing.Size(341, 162);
            this.txtDiagnosis.TabIndex = 1;
            this.txtDiagnosis.TextChanged += new System.EventHandler(this.txtDiagnosis_TextChanged);
            this.txtDiagnosis.Validating += new System.ComponentModel.CancelEventHandler(this.txtVisitDescription_Validating);
            // 
            // txtVisitDescription
            // 
            this.txtVisitDescription.AllowDrop = true;
            this.txtVisitDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtVisitDescription.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVisitDescription.Location = new System.Drawing.Point(58, 166);
            this.txtVisitDescription.MaxLength = 200;
            this.txtVisitDescription.Multiline = true;
            this.txtVisitDescription.Name = "txtVisitDescription";
            this.txtVisitDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtVisitDescription.Size = new System.Drawing.Size(335, 162);
            this.txtVisitDescription.TabIndex = 0;
            this.txtVisitDescription.TextChanged += new System.EventHandler(this.txtVisitDescription_TextChanged);
            this.txtVisitDescription.Validating += new System.ComponentModel.CancelEventHandler(this.txtVisitDescription_Validating);
            // 
            // lblVisitDescriptionLength
            // 
            this.lblVisitDescriptionLength.AutoSize = true;
            this.lblVisitDescriptionLength.Location = new System.Drawing.Point(55, 331);
            this.lblVisitDescriptionLength.Name = "lblVisitDescriptionLength";
            this.lblVisitDescriptionLength.Size = new System.Drawing.Size(40, 23);
            this.lblVisitDescriptionLength.TabIndex = 12;
            this.lblVisitDescriptionLength.Text = "200";
            // 
            // lblDiagnosisLength
            // 
            this.lblDiagnosisLength.AutoSize = true;
            this.lblDiagnosisLength.Location = new System.Drawing.Point(505, 331);
            this.lblDiagnosisLength.Name = "lblDiagnosisLength";
            this.lblDiagnosisLength.Size = new System.Drawing.Size(40, 23);
            this.lblDiagnosisLength.TabIndex = 13;
            this.lblDiagnosisLength.Text = "200";
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkRate = 20;
            this.errorProvider1.ContainerControl = this;
            // 
            // lblSpecialInstructionsLength
            // 
            this.lblSpecialInstructionsLength.AutoSize = true;
            this.lblSpecialInstructionsLength.Location = new System.Drawing.Point(973, 299);
            this.lblSpecialInstructionsLength.Name = "lblSpecialInstructionsLength";
            this.lblSpecialInstructionsLength.Size = new System.Drawing.Size(40, 23);
            this.lblSpecialInstructionsLength.TabIndex = 16;
            this.lblSpecialInstructionsLength.Text = "200";
            // 
            // frmCompleteAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1440, 900);
            this.Controls.Add(this.panelForms);
            this.Name = "frmCompleteAppointment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCompleteAppointment";
            this.Load += new System.EventHandler(this.frmCompleteAppointment_Load);
            this.panelForms.ResumeLayout(false);
            this.gbNeedPrescription.ResumeLayout(false);
            this.gbNeedPrescription.PerformLayout();
            this.gbPrescription.ResumeLayout(false);
            this.gbPrescription.PerformLayout();
            this.gbMedicalRecordInfo.ResumeLayout(false);
            this.gbMedicalRecordInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelForms;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox gbNeedPrescription;
        private System.Windows.Forms.RadioButton chkNo;
        private System.Windows.Forms.RadioButton chkYes;
        private System.Windows.Forms.GroupBox gbPrescription;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.TextBox txtSpecialInstructions;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtFrequency;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDosage;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMedicationName;
        private System.Windows.Forms.GroupBox gbMedicalRecordInfo;
        private System.Windows.Forms.Label lblAppointmentID;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtAdditionalNotes;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblPatientName;
        private System.Windows.Forms.Label lblNationalNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDiagnosis;
        private System.Windows.Forms.TextBox txtVisitDescription;
        private System.Windows.Forms.Label lblVisitDescriptionLength;
        private System.Windows.Forms.Label lblDiagnosisLength;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label lblSpecialInstructionsLength;
    }
}