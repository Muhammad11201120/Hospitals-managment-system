﻿namespace Hospital_Managment_System.Empolyee.Doctor
{
    partial class frmAddUpdateDoctor
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.tcDoctorInfo = new System.Windows.Forms.TabControl();
            this.tbEmployeeInfo = new System.Windows.Forms.TabPage();
            this.btnDoctorInfoNext = new System.Windows.Forms.Button();
            this.tbDoctorInfo = new System.Windows.Forms.TabPage();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbSpecialty = new System.Windows.Forms.ComboBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.label15 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnBack = new System.Windows.Forms.Button();
            this.ctrlEmployeeCardWithFilter1 = new Hospital_Managment_System.Empolyee.EmployeeControls.ctrlEmployeeCardWithFilter();
            this.tcDoctorInfo.SuspendLayout();
            this.tbEmployeeInfo.SuspendLayout();
            this.tbDoctorInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Black", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTitle.Location = new System.Drawing.Point(354, 9);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(445, 80);
            this.lblTitle.TabIndex = 116;
            this.lblTitle.Text = "Add New Doctor";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tcDoctorInfo
            // 
            this.tcDoctorInfo.Controls.Add(this.tbEmployeeInfo);
            this.tcDoctorInfo.Controls.Add(this.tbDoctorInfo);
            this.tcDoctorInfo.Location = new System.Drawing.Point(52, 158);
            this.tcDoctorInfo.Margin = new System.Windows.Forms.Padding(4);
            this.tcDoctorInfo.Name = "tcDoctorInfo";
            this.tcDoctorInfo.SelectedIndex = 0;
            this.tcDoctorInfo.Size = new System.Drawing.Size(997, 529);
            this.tcDoctorInfo.TabIndex = 117;
            this.tcDoctorInfo.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tcDoctorInfo_Selecting);
            // 
            // tbEmployeeInfo
            // 
            this.tbEmployeeInfo.BackColor = System.Drawing.SystemColors.Control;
            this.tbEmployeeInfo.Controls.Add(this.ctrlEmployeeCardWithFilter1);
            this.tbEmployeeInfo.Controls.Add(this.btnDoctorInfoNext);
            this.tbEmployeeInfo.Location = new System.Drawing.Point(4, 25);
            this.tbEmployeeInfo.Margin = new System.Windows.Forms.Padding(4);
            this.tbEmployeeInfo.Name = "tbEmployeeInfo";
            this.tbEmployeeInfo.Padding = new System.Windows.Forms.Padding(4);
            this.tbEmployeeInfo.Size = new System.Drawing.Size(989, 500);
            this.tbEmployeeInfo.TabIndex = 0;
            this.tbEmployeeInfo.Text = "Employee Info ";
            // 
            // btnDoctorInfoNext
            // 
            this.btnDoctorInfoNext.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDoctorInfoNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoctorInfoNext.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDoctorInfoNext.Location = new System.Drawing.Point(833, 444);
            this.btnDoctorInfoNext.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnDoctorInfoNext.Name = "btnDoctorInfoNext";
            this.btnDoctorInfoNext.Size = new System.Drawing.Size(147, 46);
            this.btnDoctorInfoNext.TabIndex = 120;
            this.btnDoctorInfoNext.Text = "Next";
            this.btnDoctorInfoNext.UseVisualStyleBackColor = true;
            this.btnDoctorInfoNext.Click += new System.EventHandler(this.btnDoctorInfoNext_Click);
            // 
            // tbDoctorInfo
            // 
            this.tbDoctorInfo.Controls.Add(this.pictureBox11);
            this.tbDoctorInfo.Controls.Add(this.txtPrice);
            this.tbDoctorInfo.Controls.Add(this.label8);
            this.tbDoctorInfo.Controls.Add(this.cbSpecialty);
            this.tbDoctorInfo.Controls.Add(this.pictureBox6);
            this.tbDoctorInfo.Controls.Add(this.label15);
            this.tbDoctorInfo.Location = new System.Drawing.Point(4, 25);
            this.tbDoctorInfo.Margin = new System.Windows.Forms.Padding(4);
            this.tbDoctorInfo.Name = "tbDoctorInfo";
            this.tbDoctorInfo.Padding = new System.Windows.Forms.Padding(4);
            this.tbDoctorInfo.Size = new System.Drawing.Size(989, 500);
            this.tbDoctorInfo.TabIndex = 1;
            this.tbDoctorInfo.Text = "Doctor Info";
            this.tbDoctorInfo.UseVisualStyleBackColor = true;
            // 
            // pictureBox11
            // 
            this.pictureBox11.Image = global::Hospital_Managment_System.Properties.Resources.Price;
            this.pictureBox11.Location = new System.Drawing.Point(388, 192);
            this.pictureBox11.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(36, 32);
            this.pictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox11.TabIndex = 118;
            this.pictureBox11.TabStop = false;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(433, 194);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtPrice.MaxLength = 50;
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(194, 24);
            this.txtPrice.TabIndex = 116;
            this.txtPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSalary_KeyPress);
            this.txtPrice.Validating += new System.ComponentModel.CancelEventHandler(this.txtSalary_Validating);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(307, 193);
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
            this.cbSpecialty.Location = new System.Drawing.Point(433, 133);
            this.cbSpecialty.Margin = new System.Windows.Forms.Padding(4);
            this.cbSpecialty.Name = "cbSpecialty";
            this.cbSpecialty.Size = new System.Drawing.Size(194, 24);
            this.cbSpecialty.TabIndex = 99;
            this.cbSpecialty.Validating += new System.ComponentModel.CancelEventHandler(this.cbSpecialty_Validating);
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::Hospital_Managment_System.Properties.Resources.Specialty;
            this.pictureBox6.Location = new System.Drawing.Point(388, 130);
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
            this.label15.Location = new System.Drawing.Point(268, 133);
            this.label15.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(114, 25);
            this.label15.TabIndex = 100;
            this.label15.Text = "Specialty :";
            // 
            // btnSave
            // 
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(514, 706);
            this.btnSave.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(147, 46);
            this.btnSave.TabIndex = 118;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnBack
            // 
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.Image = global::Hospital_Managment_System.Properties.Resources.left_arrow;
            this.btnBack.Location = new System.Drawing.Point(12, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(48, 43);
            this.btnBack.TabIndex = 126;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // ctrlEmployeeCardWithFilter1
            // 
            this.ctrlEmployeeCardWithFilter1.AutoSize = true;
            this.ctrlEmployeeCardWithFilter1.FilterEnabled = true;
            this.ctrlEmployeeCardWithFilter1.Location = new System.Drawing.Point(3, 5);
            this.ctrlEmployeeCardWithFilter1.Margin = new System.Windows.Forms.Padding(5);
            this.ctrlEmployeeCardWithFilter1.Name = "ctrlEmployeeCardWithFilter1";
            this.ctrlEmployeeCardWithFilter1.ShowAddEmployee = true;
            this.ctrlEmployeeCardWithFilter1.Size = new System.Drawing.Size(986, 429);
            this.ctrlEmployeeCardWithFilter1.TabIndex = 121;
            // 
            // frmAddUpdateDoctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(1098, 829);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tcDoctorInfo);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmAddUpdateDoctor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmAddUpdateDoctor_Load);
            this.tcDoctorInfo.ResumeLayout(false);
            this.tbEmployeeInfo.ResumeLayout(false);
            this.tbEmployeeInfo.PerformLayout();
            this.tbDoctorInfo.ResumeLayout(false);
            this.tbDoctorInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TabControl tcDoctorInfo;
        private System.Windows.Forms.TabPage tbEmployeeInfo;
        private System.Windows.Forms.TabPage tbDoctorInfo;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox cbSpecialty;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.PictureBox pictureBox11;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnDoctorInfoNext;
        private EmployeeControls.ctrlEmployeeCardWithFilter ctrlEmployeeCardWithFilter1;
        private System.Windows.Forms.Button btnBack;
    }
}