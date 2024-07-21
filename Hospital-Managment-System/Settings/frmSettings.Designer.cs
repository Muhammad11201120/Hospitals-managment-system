namespace Hospital_Managment_System.Settings
{
    partial class frmSettings
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnHospitalInfo = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelForms = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(150)))), ((int)(((byte)(190)))));
            this.panel1.Controls.Add(this.btnHospitalInfo);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(216, 690);
            this.panel1.TabIndex = 2;
            // 
            // btnHospitalInfo
            // 
            this.btnHospitalInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHospitalInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHospitalInfo.FlatAppearance.BorderSize = 0;
            this.btnHospitalInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHospitalInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHospitalInfo.ForeColor = System.Drawing.Color.White;
            this.btnHospitalInfo.Image = global::Hospital_Managment_System.Properties.Resources.hospital;
            this.btnHospitalInfo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHospitalInfo.Location = new System.Drawing.Point(0, 102);
            this.btnHospitalInfo.Name = "btnHospitalInfo";
            this.btnHospitalInfo.Size = new System.Drawing.Size(216, 51);
            this.btnHospitalInfo.TabIndex = 1;
            this.btnHospitalInfo.Text = "Hospital Info";
            this.btnHospitalInfo.UseVisualStyleBackColor = true;
            this.btnHospitalInfo.Click += new System.EventHandler(this.btnHospitalInfo_Click);
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(216, 102);
            this.panel2.TabIndex = 2;
            // 
            // panelForms
            // 
            this.panelForms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelForms.Location = new System.Drawing.Point(216, 0);
            this.panelForms.Name = "panelForms";
            this.panelForms.Size = new System.Drawing.Size(1122, 690);
            this.panelForms.TabIndex = 3;
            // 
            // frmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1338, 690);
            this.Controls.Add(this.panelForms);
            this.Controls.Add(this.panel1);
            this.Name = "frmSettings";
            this.Text = "frmSettings";
            this.Load += new System.EventHandler(this.frmSettings_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnHospitalInfo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelForms;
    }
}