namespace Hospital_Managment_System.Empolyee
{
    partial class frmEmployees
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnDoctors = new System.Windows.Forms.Button();
            this.btnUsers = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 296);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 26;
            this.dataGridView1.Size = new System.Drawing.Size(1137, 436);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnDoctors
            // 
            this.btnDoctors.Location = new System.Drawing.Point(898, 12);
            this.btnDoctors.Name = "btnDoctors";
            this.btnDoctors.Size = new System.Drawing.Size(118, 108);
            this.btnDoctors.TabIndex = 1;
            this.btnDoctors.Text = "Doctors";
            this.btnDoctors.UseVisualStyleBackColor = true;
            this.btnDoctors.Click += new System.EventHandler(this.btnDoctors_Click);
            // 
            // btnUsers
            // 
            this.btnUsers.Location = new System.Drawing.Point(1031, 12);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Size = new System.Drawing.Size(118, 108);
            this.btnUsers.TabIndex = 2;
            this.btnUsers.Text = "Users";
            this.btnUsers.UseVisualStyleBackColor = true;
            // 
            // frmEmployees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1161, 767);
            this.Controls.Add(this.btnUsers);
            this.Controls.Add(this.btnDoctors);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmEmployees";
            this.Text = "frmEmployees";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnDoctors;
        private System.Windows.Forms.Button btnUsers;
    }
}