namespace Hospital_Managment_System.Empolyee.Doctor.DoctorForms
{
    partial class frmShowDoctorDetails
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
            this.btnClose = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.ctrlEmployeeCard1 = new Hospital_Managment_System.Empolyee.EmployeeControls.ctrlEmployeeCard();
            this.gbDoctorInfo = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.lblSpecialty = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblDoctorPrice = new System.Windows.Forms.Label();
            this.lblDoctorID = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbDoctorInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(714, 423);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(130, 42);
            this.btnClose.TabIndex = 16;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Red;
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(879, 53);
            this.lblTitle.TabIndex = 15;
            this.lblTitle.Text = "Doctor Details ";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ctrlEmployeeCard1
            // 
            this.ctrlEmployeeCard1.AutoSize = true;
            this.ctrlEmployeeCard1.EditedVisible = true;
            this.ctrlEmployeeCard1.Location = new System.Drawing.Point(12, 69);
            this.ctrlEmployeeCard1.Name = "ctrlEmployeeCard1";
            this.ctrlEmployeeCard1.Size = new System.Drawing.Size(839, 271);
            this.ctrlEmployeeCard1.TabIndex = 22;
            // 
            // gbDoctorInfo
            // 
            this.gbDoctorInfo.BackColor = System.Drawing.SystemColors.Control;
            this.gbDoctorInfo.Controls.Add(this.pictureBox1);
            this.gbDoctorInfo.Controls.Add(this.pictureBox6);
            this.gbDoctorInfo.Controls.Add(this.pictureBox11);
            this.gbDoctorInfo.Controls.Add(this.lblSpecialty);
            this.gbDoctorInfo.Controls.Add(this.label4);
            this.gbDoctorInfo.Controls.Add(this.lblDoctorPrice);
            this.gbDoctorInfo.Controls.Add(this.lblDoctorID);
            this.gbDoctorInfo.Controls.Add(this.label2);
            this.gbDoctorInfo.Controls.Add(this.label1);
            this.gbDoctorInfo.Location = new System.Drawing.Point(12, 345);
            this.gbDoctorInfo.Margin = new System.Windows.Forms.Padding(2);
            this.gbDoctorInfo.Name = "gbDoctorInfo";
            this.gbDoctorInfo.Padding = new System.Windows.Forms.Padding(2);
            this.gbDoctorInfo.Size = new System.Drawing.Size(832, 66);
            this.gbDoctorInfo.TabIndex = 21;
            this.gbDoctorInfo.TabStop = false;
            this.gbDoctorInfo.Text = "Doctor Info :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Hospital_Managment_System.Properties.Resources.doctor1;
            this.pictureBox1.Location = new System.Drawing.Point(167, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(31, 26);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 124;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::Hospital_Managment_System.Properties.Resources.task_types;
            this.pictureBox6.Location = new System.Drawing.Point(423, 21);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(31, 26);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 119;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox11
            // 
            this.pictureBox11.Image = global::Hospital_Managment_System.Properties.Resources.Price;
            this.pictureBox11.Location = new System.Drawing.Point(629, 20);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(31, 26);
            this.pictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox11.TabIndex = 120;
            this.pictureBox11.TabStop = false;
            // 
            // lblSpecialty
            // 
            this.lblSpecialty.AutoSize = true;
            this.lblSpecialty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSpecialty.Location = new System.Drawing.Point(460, 24);
            this.lblSpecialty.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSpecialty.Name = "lblSpecialty";
            this.lblSpecialty.Size = new System.Drawing.Size(35, 20);
            this.lblSpecialty.TabIndex = 123;
            this.lblSpecialty.Text = "N/A";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(327, 23);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 20);
            this.label4.TabIndex = 122;
            this.label4.Text = "Specialty :";
            // 
            // lblDoctorPrice
            // 
            this.lblDoctorPrice.AutoSize = true;
            this.lblDoctorPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDoctorPrice.Location = new System.Drawing.Point(667, 23);
            this.lblDoctorPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDoctorPrice.Name = "lblDoctorPrice";
            this.lblDoctorPrice.Size = new System.Drawing.Size(35, 20);
            this.lblDoctorPrice.TabIndex = 121;
            this.lblDoctorPrice.Text = "N/A";
            // 
            // lblDoctorID
            // 
            this.lblDoctorID.AutoSize = true;
            this.lblDoctorID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDoctorID.Location = new System.Drawing.Point(206, 23);
            this.lblDoctorID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDoctorID.Name = "lblDoctorID";
            this.lblDoctorID.Size = new System.Drawing.Size(35, 20);
            this.lblDoctorID.TabIndex = 120;
            this.lblDoctorID.Text = "N/A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(567, 23);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 20);
            this.label2.TabIndex = 20;
            this.label2.Text = "Price :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(72, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 20);
            this.label1.TabIndex = 19;
            this.label1.Text = "Doctor ID :";
            // 
            // frmShowDoctorDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 476);
            this.Controls.Add(this.ctrlEmployeeCard1);
            this.Controls.Add(this.gbDoctorInfo);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmShowDoctorDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Show Doctor Details";
            this.Load += new System.EventHandler(this.frmShowDoctorDetails_Load);
            this.gbDoctorInfo.ResumeLayout(false);
            this.gbDoctorInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblTitle;
        private EmployeeControls.ctrlEmployeeCard ctrlEmployeeCard1;
        private System.Windows.Forms.GroupBox gbDoctorInfo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox11;
        private System.Windows.Forms.Label lblSpecialty;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblDoctorPrice;
        private System.Windows.Forms.Label lblDoctorID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}