namespace Hospital_Managment_System.Empolyee
{
    partial class frmFindDoctorInfo
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
            this.ctrlFindDoctor1 = new Hospital_Managment_System.ctrlFindDoctor();
            this.SuspendLayout();
            // 
            // ctrlFindDoctor1
            // 
            this.ctrlFindDoctor1.FilterEnabled = true;
            this.ctrlFindDoctor1.Location = new System.Drawing.Point(-1, 1);
            this.ctrlFindDoctor1.Name = "ctrlFindDoctor1";
            this.ctrlFindDoctor1.ShowAddDoctor = true;
            this.ctrlFindDoctor1.Size = new System.Drawing.Size(1068, 558);
            this.ctrlFindDoctor1.TabIndex = 0;
            // 
            // frmFindDoctorInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 528);
            this.Controls.Add(this.ctrlFindDoctor1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frmFindDoctorInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);

        }

        #endregion

        private ctrlFindDoctor ctrlFindDoctor1;
    }
}