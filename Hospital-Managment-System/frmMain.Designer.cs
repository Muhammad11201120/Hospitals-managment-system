namespace Hospital_Managment_System
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose( bool disposing )
        {
            if ( disposing && ( components != null ) )
            {
                components.Dispose();
            }
            base.Dispose( disposing );
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.findEmployeeUnderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.empolyeesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewDoctorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allDoctorsListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.findDoctorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            this.specialtiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allSpecialtiesListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uSERSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.findUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hospitalSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.signOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.empolyeesToolStripMenuItem,
            this.toolStripMenuItem4,
            this.specialtiesToolStripMenuItem,
            this.uSERSToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(920, 72);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.findEmployeeUnderToolStripMenuItem});
            this.toolStripMenuItem1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem1.Image = global::Hospital_Managment_System.Properties.Resources.human_resources;
            this.toolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(190, 68);
            this.toolStripMenuItem1.Text = "Empolyees";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Image = global::Hospital_Managment_System.Properties.Resources.salesman__1_;
            this.toolStripMenuItem2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(282, 38);
            this.toolStripMenuItem2.Text = "Add New Empolyee";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Image = global::Hospital_Managment_System.Properties.Resources.human_resources__1_;
            this.toolStripMenuItem3.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(282, 38);
            this.toolStripMenuItem3.Text = "All Employees List";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // findEmployeeUnderToolStripMenuItem
            // 
            this.findEmployeeUnderToolStripMenuItem.Image = global::Hospital_Managment_System.Properties.Resources.stakeholder_analysis;
            this.findEmployeeUnderToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.findEmployeeUnderToolStripMenuItem.Name = "findEmployeeUnderToolStripMenuItem";
            this.findEmployeeUnderToolStripMenuItem.Size = new System.Drawing.Size(282, 38);
            this.findEmployeeUnderToolStripMenuItem.Text = "Find Employee";
            this.findEmployeeUnderToolStripMenuItem.Click += new System.EventHandler(this.findEmployeeUnderToolStripMenuItem_Click);
            // 
            // empolyeesToolStripMenuItem
            // 
            this.empolyeesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewDoctorToolStripMenuItem,
            this.allDoctorsListToolStripMenuItem,
            this.findDoctorToolStripMenuItem});
            this.empolyeesToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empolyeesToolStripMenuItem.Image = global::Hospital_Managment_System.Properties.Resources.doctor__2_;
            this.empolyeesToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.empolyeesToolStripMenuItem.Name = "empolyeesToolStripMenuItem";
            this.empolyeesToolStripMenuItem.Size = new System.Drawing.Size(157, 68);
            this.empolyeesToolStripMenuItem.Text = "Doctors";
            this.empolyeesToolStripMenuItem.Click += new System.EventHandler(this.empolyeesToolStripMenuItem_Click);
            // 
            // addNewDoctorToolStripMenuItem
            // 
            this.addNewDoctorToolStripMenuItem.Image = global::Hospital_Managment_System.Properties.Resources.doctor__3_;
            this.addNewDoctorToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.addNewDoctorToolStripMenuItem.Name = "addNewDoctorToolStripMenuItem";
            this.addNewDoctorToolStripMenuItem.Size = new System.Drawing.Size(451, 38);
            this.addNewDoctorToolStripMenuItem.Text = "Add New Doctor";
            this.addNewDoctorToolStripMenuItem.Click += new System.EventHandler(this.addNewDoctorToolStripMenuItem_Click);
            // 
            // allDoctorsListToolStripMenuItem
            // 
            this.allDoctorsListToolStripMenuItem.Image = global::Hospital_Managment_System.Properties.Resources.doctor1;
            this.allDoctorsListToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.allDoctorsListToolStripMenuItem.Name = "allDoctorsListToolStripMenuItem";
            this.allDoctorsListToolStripMenuItem.Size = new System.Drawing.Size(451, 38);
            this.allDoctorsListToolStripMenuItem.Text = "All Doctors List (NOT IMPLEMENTED)";
            this.allDoctorsListToolStripMenuItem.Click += new System.EventHandler(this.allDoctorsListToolStripMenuItem_Click);
            // 
            // findDoctorToolStripMenuItem
            // 
            this.findDoctorToolStripMenuItem.Image = global::Hospital_Managment_System.Properties.Resources.doctor__1_;
            this.findDoctorToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.findDoctorToolStripMenuItem.Name = "findDoctorToolStripMenuItem";
            this.findDoctorToolStripMenuItem.Size = new System.Drawing.Size(451, 38);
            this.findDoctorToolStripMenuItem.Text = "Find Doctor ";
            this.findDoctorToolStripMenuItem.Click += new System.EventHandler(this.findDoctorToolStripMenuItem_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem5,
            this.toolStripMenuItem6,
            this.toolStripMenuItem7});
            this.toolStripMenuItem4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            this.toolStripMenuItem4.Image = global::Hospital_Managment_System.Properties.Resources.user__3_;
            this.toolStripMenuItem4.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(139, 68);
            this.toolStripMenuItem4.Text = "Users";
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Image = global::Hospital_Managment_System.Properties.Resources.user__4_;
            this.toolStripMenuItem5.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(448, 38);
            this.toolStripMenuItem5.Text = "Add New User (NOT IMPLEMENTED)";
            this.toolStripMenuItem5.Click += new System.EventHandler(this.toolStripMenuItem5_Click);
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Image = global::Hospital_Managment_System.Properties.Resources.user__1_;
            this.toolStripMenuItem6.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(448, 38);
            this.toolStripMenuItem6.Text = "All Users List (NOT IMPLEMENTED)";
            this.toolStripMenuItem6.Click += new System.EventHandler(this.toolStripMenuItem6_Click);
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.Image = global::Hospital_Managment_System.Properties.Resources.user__2_;
            this.toolStripMenuItem7.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new System.Drawing.Size(448, 38);
            this.toolStripMenuItem7.Text = "Find User (NOT IMPLEMENTED)";
            this.toolStripMenuItem7.Click += new System.EventHandler(this.toolStripMenuItem7_Click);
            // 
            // specialtiesToolStripMenuItem
            // 
            this.specialtiesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.allSpecialtiesListToolStripMenuItem});
            this.specialtiesToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.specialtiesToolStripMenuItem.Image = global::Hospital_Managment_System.Properties.Resources.task_types;
            this.specialtiesToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.specialtiesToolStripMenuItem.Name = "specialtiesToolStripMenuItem";
            this.specialtiesToolStripMenuItem.Size = new System.Drawing.Size(155, 68);
            this.specialtiesToolStripMenuItem.Text = "Specialties";
            // 
            // allSpecialtiesListToolStripMenuItem
            // 
            this.allSpecialtiesListToolStripMenuItem.Name = "allSpecialtiesListToolStripMenuItem";
            this.allSpecialtiesListToolStripMenuItem.Size = new System.Drawing.Size(248, 28);
            this.allSpecialtiesListToolStripMenuItem.Text = "All Specialties List";
            this.allSpecialtiesListToolStripMenuItem.Click += new System.EventHandler(this.allSpecialtiesListToolStripMenuItem_Click);
            // 
            // uSERSToolStripMenuItem
            // 
            this.uSERSToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.findUserToolStripMenuItem,
            this.hospitalSettingsToolStripMenuItem,
            this.signOutToolStripMenuItem});
            this.uSERSToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            this.uSERSToolStripMenuItem.Image = global::Hospital_Managment_System.Properties.Resources.gear__1_;
            this.uSERSToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.uSERSToolStripMenuItem.Name = "uSERSToolStripMenuItem";
            this.uSERSToolStripMenuItem.Size = new System.Drawing.Size(160, 68);
            this.uSERSToolStripMenuItem.Text = "Settings";
            // 
            // findUserToolStripMenuItem
            // 
            this.findUserToolStripMenuItem.Image = global::Hospital_Managment_System.Properties.Resources.task_types;
            this.findUserToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.findUserToolStripMenuItem.Name = "findUserToolStripMenuItem";
            this.findUserToolStripMenuItem.Size = new System.Drawing.Size(468, 38);
            this.findUserToolStripMenuItem.Text = "Specialties (NOT IMPLEMENTED)";
            this.findUserToolStripMenuItem.Click += new System.EventHandler(this.findUserToolStripMenuItem_Click);
            // 
            // hospitalSettingsToolStripMenuItem
            // 
            this.hospitalSettingsToolStripMenuItem.Image = global::Hospital_Managment_System.Properties.Resources.hospital;
            this.hospitalSettingsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.hospitalSettingsToolStripMenuItem.Name = "hospitalSettingsToolStripMenuItem";
            this.hospitalSettingsToolStripMenuItem.Size = new System.Drawing.Size(468, 38);
            this.hospitalSettingsToolStripMenuItem.Text = "Hospital Settings (NOT IMPLEMENTED)";
            // 
            // signOutToolStripMenuItem
            // 
            this.signOutToolStripMenuItem.Image = global::Hospital_Managment_System.Properties.Resources.sign_out_32__2;
            this.signOutToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.signOutToolStripMenuItem.Name = "signOutToolStripMenuItem";
            this.signOutToolStripMenuItem.Size = new System.Drawing.Size(468, 38);
            this.signOutToolStripMenuItem.Text = "Sign out";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 692);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem empolyeesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewDoctorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem findEmployeeUnderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uSERSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem findUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allDoctorsListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem findDoctorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem7;
        private System.Windows.Forms.ToolStripMenuItem hospitalSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem signOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem specialtiesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allSpecialtiesListToolStripMenuItem;
    }
}

