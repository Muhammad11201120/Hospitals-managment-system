namespace Hospital_Managment_System.Appointment
{
    partial class ctrlPatientInfoWithFilter
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
            this.gbFilters = new System.Windows.Forms.GroupBox();
            this.btnAddNewPatient = new System.Windows.Forms.Button();
            this.btnFind = new System.Windows.Forms.Button();
            this.cbFilterBy = new System.Windows.Forms.ComboBox();
            this.txtFilterValue = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ctrlPatient1 = new Hospital_Managment_System.Appointment.ctrlPatient();
            this.gbFilters.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbFilters
            // 
            this.gbFilters.BackColor = System.Drawing.SystemColors.Control;
            this.gbFilters.Controls.Add(this.btnAddNewPatient);
            this.gbFilters.Controls.Add(this.btnFind);
            this.gbFilters.Controls.Add(this.cbFilterBy);
            this.gbFilters.Controls.Add(this.txtFilterValue);
            this.gbFilters.Controls.Add(this.label1);
            this.gbFilters.Location = new System.Drawing.Point(2, 0);
            this.gbFilters.Margin = new System.Windows.Forms.Padding(2);
            this.gbFilters.Name = "gbFilters";
            this.gbFilters.Padding = new System.Windows.Forms.Padding(2);
            this.gbFilters.Size = new System.Drawing.Size(670, 66);
            this.gbFilters.TabIndex = 19;
            this.gbFilters.TabStop = false;
            this.gbFilters.Text = "Filter";
            // 
            // btnAddNewPatient
            // 
            this.btnAddNewPatient.BackgroundImage = global::Hospital_Managment_System.Properties.Resources.Add_Person_40;
            this.btnAddNewPatient.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddNewPatient.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddNewPatient.Location = new System.Drawing.Point(573, 20);
            this.btnAddNewPatient.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAddNewPatient.Name = "btnAddNewPatient";
            this.btnAddNewPatient.Size = new System.Drawing.Size(52, 38);
            this.btnAddNewPatient.TabIndex = 22;
            this.btnAddNewPatient.UseVisualStyleBackColor = true;
            this.btnAddNewPatient.Click += new System.EventHandler(this.btnAddNewPatient_Click);
            // 
            // btnFind
            // 
            this.btnFind.BackgroundImage = global::Hospital_Managment_System.Properties.Resources.SearchPerson;
            this.btnFind.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFind.Location = new System.Drawing.Point(501, 20);
            this.btnFind.Margin = new System.Windows.Forms.Padding(2);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(52, 38);
            this.btnFind.TabIndex = 21;
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // cbFilterBy
            // 
            this.cbFilterBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilterBy.FormattingEnabled = true;
            this.cbFilterBy.Items.AddRange(new object[] {
            "Patient ID"});
            this.cbFilterBy.Location = new System.Drawing.Point(107, 29);
            this.cbFilterBy.Margin = new System.Windows.Forms.Padding(2);
            this.cbFilterBy.Name = "cbFilterBy";
            this.cbFilterBy.Size = new System.Drawing.Size(162, 21);
            this.cbFilterBy.TabIndex = 16;
            this.cbFilterBy.SelectedIndexChanged += new System.EventHandler(this.cbFilterBy_SelectedIndexChanged);
            // 
            // txtFilterValue
            // 
            this.txtFilterValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFilterValue.Location = new System.Drawing.Point(304, 29);
            this.txtFilterValue.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtFilterValue.Name = "txtFilterValue";
            this.txtFilterValue.Size = new System.Drawing.Size(165, 20);
            this.txtFilterValue.TabIndex = 17;
            this.txtFilterValue.Visible = false;
            this.txtFilterValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFilterValue_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 20);
            this.label1.TabIndex = 19;
            this.label1.Text = "Find By:";
            // 
            // ctrlPatient1
            // 
            this.ctrlPatient1.AutoSize = true;
            this.ctrlPatient1.EditedVisible = true;
            this.ctrlPatient1.Location = new System.Drawing.Point(2, 70);
            this.ctrlPatient1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ctrlPatient1.Name = "ctrlPatient1";
            this.ctrlPatient1.Size = new System.Drawing.Size(685, 284);
            this.ctrlPatient1.TabIndex = 20;
            // 
            // ctrlPatientInfoWithFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.ctrlPatient1);
            this.Controls.Add(this.gbFilters);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ctrlPatientInfoWithFilter";
            this.Size = new System.Drawing.Size(690, 356);
            this.Load += new System.EventHandler(this.ctrlPatientInfoWithFilter_Load);
            this.gbFilters.ResumeLayout(false);
            this.gbFilters.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbFilters;
        private System.Windows.Forms.Button btnAddNewPatient;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.ComboBox cbFilterBy;
        private System.Windows.Forms.TextBox txtFilterValue;
        private System.Windows.Forms.Label label1;
        private ctrlPatient ctrlPatient1;
    }
}
