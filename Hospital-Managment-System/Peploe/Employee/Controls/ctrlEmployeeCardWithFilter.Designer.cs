namespace Hospital_Managment_System.Empolyee.EmployeeControls
{
    partial class ctrlEmployeeCardWithFilter
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
            this.ctrlEmployeeCard1 = new Hospital_Managment_System.Empolyee.EmployeeControls.ctrlEmployeeCard();
            this.gbFilters = new System.Windows.Forms.GroupBox();
            this.btnAddNewEmployee = new System.Windows.Forms.Button();
            this.btnFind = new System.Windows.Forms.Button();
            this.cbFilterBy = new System.Windows.Forms.ComboBox();
            this.txtFilterValue = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbFilters.SuspendLayout();
            this.SuspendLayout();
            // 
            // ctrlEmployeeCard1
            // 
            this.ctrlEmployeeCard1.AutoSize = true;
            this.ctrlEmployeeCard1.EditedVisible = true;
            this.ctrlEmployeeCard1.Location = new System.Drawing.Point(0, 91);
            this.ctrlEmployeeCard1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.ctrlEmployeeCard1.Name = "ctrlEmployeeCard1";
            this.ctrlEmployeeCard1.Size = new System.Drawing.Size(980, 333);
            this.ctrlEmployeeCard1.TabIndex = 0;
            // 
            // gbFilters
            // 
            this.gbFilters.BackColor = System.Drawing.SystemColors.Control;
            this.gbFilters.Controls.Add(this.btnAddNewEmployee);
            this.gbFilters.Controls.Add(this.btnFind);
            this.gbFilters.Controls.Add(this.cbFilterBy);
            this.gbFilters.Controls.Add(this.txtFilterValue);
            this.gbFilters.Controls.Add(this.label1);
            this.gbFilters.Location = new System.Drawing.Point(4, 4);
            this.gbFilters.Margin = new System.Windows.Forms.Padding(2);
            this.gbFilters.Name = "gbFilters";
            this.gbFilters.Padding = new System.Windows.Forms.Padding(2);
            this.gbFilters.Size = new System.Drawing.Size(980, 81);
            this.gbFilters.TabIndex = 18;
            this.gbFilters.TabStop = false;
            this.gbFilters.Text = "Filter";
            // 
            // btnAddNewEmployee
            // 
            this.btnAddNewEmployee.BackgroundImage = global::Hospital_Managment_System.Properties.Resources.Add_Person_40;
            this.btnAddNewEmployee.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddNewEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddNewEmployee.Location = new System.Drawing.Point(736, 18);
            this.btnAddNewEmployee.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAddNewEmployee.Name = "btnAddNewEmployee";
            this.btnAddNewEmployee.Size = new System.Drawing.Size(61, 47);
            this.btnAddNewEmployee.TabIndex = 22;
            this.btnAddNewEmployee.UseVisualStyleBackColor = true;
            this.btnAddNewEmployee.Click += new System.EventHandler(this.btnAddNewEmployee_Click);
            // 
            // btnFind
            // 
            this.btnFind.BackgroundImage = global::Hospital_Managment_System.Properties.Resources.SearchPerson;
            this.btnFind.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFind.Location = new System.Drawing.Point(651, 18);
            this.btnFind.Margin = new System.Windows.Forms.Padding(2);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(61, 47);
            this.btnFind.TabIndex = 21;
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // cbFilterBy
            // 
            this.cbFilterBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilterBy.FormattingEnabled = true;
            this.cbFilterBy.Items.AddRange(new object[] {
            "Employee ID"});
            this.cbFilterBy.Location = new System.Drawing.Point(192, 30);
            this.cbFilterBy.Margin = new System.Windows.Forms.Padding(2);
            this.cbFilterBy.Name = "cbFilterBy";
            this.cbFilterBy.Size = new System.Drawing.Size(188, 24);
            this.cbFilterBy.TabIndex = 16;
            this.cbFilterBy.SelectedIndexChanged += new System.EventHandler(this.cbFilterBy_SelectedIndexChanged);
            // 
            // txtFilterValue
            // 
            this.txtFilterValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFilterValue.Location = new System.Drawing.Point(422, 30);
            this.txtFilterValue.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtFilterValue.Name = "txtFilterValue";
            this.txtFilterValue.Size = new System.Drawing.Size(192, 24);
            this.txtFilterValue.TabIndex = 17;
            this.txtFilterValue.Visible = false;
            this.txtFilterValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFilterValue_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(84, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 25);
            this.label1.TabIndex = 19;
            this.label1.Text = "Find By:";
            // 
            // ctrlEmployeeCardWithFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.gbFilters);
            this.Controls.Add(this.ctrlEmployeeCard1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ctrlEmployeeCardWithFilter";
            this.Size = new System.Drawing.Size(1147, 506);
            this.Load += new System.EventHandler(this.ctrlEmployeeCardWithFilter_Load);
            this.gbFilters.ResumeLayout(false);
            this.gbFilters.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ctrlEmployeeCard ctrlEmployeeCard1;
        private System.Windows.Forms.GroupBox gbFilters;
        private System.Windows.Forms.Button btnAddNewEmployee;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.ComboBox cbFilterBy;
        private System.Windows.Forms.TextBox txtFilterValue;
        private System.Windows.Forms.Label label1;
        
    }
}
