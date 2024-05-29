namespace Hospital_Managment_System
{
    partial class ctrlFindDoctor
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ctrlEmployeeCardWithFilter1 = new Hospital_Managment_System.Empolyee.EmployeeControls.ctrlEmployeeCardWithFilter();
            this.gbFilters = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblDoctorID = new System.Windows.Forms.Label();
            this.lblDoctorPrice = new System.Windows.Forms.Label();
            this.gbFilters.SuspendLayout();
            this.SuspendLayout();
            // 
            // ctrlEmployeeCardWithFilter1
            // 
            this.ctrlEmployeeCardWithFilter1.AutoSize = true;
            this.ctrlEmployeeCardWithFilter1.FilterEnabled = true;
            this.ctrlEmployeeCardWithFilter1.Location = new System.Drawing.Point(0, 4);
            this.ctrlEmployeeCardWithFilter1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ctrlEmployeeCardWithFilter1.Name = "ctrlEmployeeCardWithFilter1";
            this.ctrlEmployeeCardWithFilter1.ShowAddEmployee = true;
            this.ctrlEmployeeCardWithFilter1.Size = new System.Drawing.Size(986, 429);
            this.ctrlEmployeeCardWithFilter1.TabIndex = 0;
            this.ctrlEmployeeCardWithFilter1.OnEmployeeSelected += new System.Action<int>(this.ctrlEmployeeCardWithFilter1_OnEmployeeSelected_1);
            // 
            // gbFilters
            // 
            this.gbFilters.BackColor = System.Drawing.SystemColors.Control;
            this.gbFilters.Controls.Add(this.lblDoctorPrice);
            this.gbFilters.Controls.Add(this.lblDoctorID);
            this.gbFilters.Controls.Add(this.label2);
            this.gbFilters.Controls.Add(this.label1);
            this.gbFilters.Location = new System.Drawing.Point(2, 439);
            this.gbFilters.Margin = new System.Windows.Forms.Padding(2);
            this.gbFilters.Name = "gbFilters";
            this.gbFilters.Padding = new System.Windows.Forms.Padding(2);
            this.gbFilters.Size = new System.Drawing.Size(980, 81);
            this.gbFilters.TabIndex = 19;
            this.gbFilters.TabStop = false;
            this.gbFilters.Text = "Filter";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(84, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 25);
            this.label1.TabIndex = 19;
            this.label1.Text = "Doctor ID :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(662, 28);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 25);
            this.label2.TabIndex = 20;
            this.label2.Text = "Price :";
            // 
            // lblDoctorID
            // 
            this.lblDoctorID.AutoSize = true;
            this.lblDoctorID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDoctorID.Location = new System.Drawing.Point(206, 28);
            this.lblDoctorID.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblDoctorID.Name = "lblDoctorID";
            this.lblDoctorID.Size = new System.Drawing.Size(46, 25);
            this.lblDoctorID.TabIndex = 120;
            this.lblDoctorID.Text = "N/A";
            // 
            // lblDoctorPrice
            // 
            this.lblDoctorPrice.AutoSize = true;
            this.lblDoctorPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDoctorPrice.Location = new System.Drawing.Point(754, 28);
            this.lblDoctorPrice.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblDoctorPrice.Name = "lblDoctorPrice";
            this.lblDoctorPrice.Size = new System.Drawing.Size(46, 25);
            this.lblDoctorPrice.TabIndex = 121;
            this.lblDoctorPrice.Text = "N/A";
            // 
            // ctrlFindDoctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbFilters);
            this.Controls.Add(this.ctrlEmployeeCardWithFilter1);
            this.Name = "ctrlFindDoctor";
            this.Size = new System.Drawing.Size(1068, 558);
            this.gbFilters.ResumeLayout(false);
            this.gbFilters.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Empolyee.EmployeeControls.ctrlEmployeeCardWithFilter ctrlEmployeeCardWithFilter1;
        private System.Windows.Forms.GroupBox gbFilters;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDoctorPrice;
        private System.Windows.Forms.Label lblDoctorID;
    }
}
