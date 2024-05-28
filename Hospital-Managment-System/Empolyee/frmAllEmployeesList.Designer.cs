namespace Hospital_Managment_System.Empolyee
{
    partial class frmAllEmployeesList
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
            this.components = new System.ComponentModel.Container();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cmsEmployees = new System.Windows.Forms.ContextMenuStrip( this.components );
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxIlter = new System.Windows.Forms.ComboBox();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblRecordCount = new System.Windows.Forms.Label();
            this.showPersonalInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewEmployeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            ( ( System.ComponentModel.ISupportInitialize ) ( this.dataGridView1 ) ).BeginInit();
            this.cmsEmployees.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font( "Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ) );
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb( ( ( int ) ( ( ( byte ) ( 192 ) ) ) ), ( ( int ) ( ( ( byte ) ( 0 ) ) ) ), ( ( int ) ( ( ( byte ) ( 0 ) ) ) ) );
            this.lblTitle.Location = new System.Drawing.Point( 387, 77 );
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size( 928, 39 );
            this.lblTitle.TabIndex = 116;
            this.lblTitle.Text = "Employees List";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add( this.dataGridView1 );
            this.panel1.Location = new System.Drawing.Point( 12, 200 );
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size( 1679, 396 );
            this.panel1.TabIndex = 117;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ContextMenuStrip = this.cmsEmployees;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point( 0, 0 );
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size( 1679, 396 );
            this.dataGridView1.TabIndex = 0;
            // 
            // cmsEmployees
            // 
            this.cmsEmployees.Items.AddRange( new System.Windows.Forms.ToolStripItem[] {
            this.showPersonalInfoToolStripMenuItem,
            this.toolStripSeparator1,
            this.addNewEmployeeToolStripMenuItem,
            this.updateToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.toolStripSeparator2,
            this.exitToolStripMenuItem} );
            this.cmsEmployees.Name = "cmsEmployees";
            this.cmsEmployees.Size = new System.Drawing.Size( 198, 206 );
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size( 194, 6 );
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size( 194, 6 );
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClose.Font = new System.Drawing.Font( "Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ) );
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point( 1564, 604 );
            this.btnClose.Margin = new System.Windows.Forms.Padding( 4, 5, 4, 5 );
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size( 126, 37 );
            this.btnClose.TabIndex = 118;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler( this.btnClose_Click );
            // 
            // btnAddNew
            // 
            this.btnAddNew.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAddNew.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddNew.Font = new System.Drawing.Font( "Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ) );
            this.btnAddNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddNew.Location = new System.Drawing.Point( 1565, 158 );
            this.btnAddNew.Margin = new System.Windows.Forms.Padding( 4, 5, 4, 5 );
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size( 126, 37 );
            this.btnAddNew.TabIndex = 119;
            this.btnAddNew.Text = "Add New";
            this.btnAddNew.UseVisualStyleBackColor = true;
            this.btnAddNew.Click += new System.EventHandler( this.btnAddNew_Click );
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font( "Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ) );
            this.label1.Location = new System.Drawing.Point( 9, 174 );
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size( 69, 18 );
            this.label1.TabIndex = 120;
            this.label1.Text = "Filter By: ";
            // 
            // cbxIlter
            // 
            this.cbxIlter.FormattingEnabled = true;
            this.cbxIlter.Items.AddRange( new object[] {
            "None",
            "EmployeeID",
            "NationalNo",
            "Name",
            "Gender",
            "PhoneNumber",
            "Email",
            "Country"} );
            this.cbxIlter.Location = new System.Drawing.Point( 85, 174 );
            this.cbxIlter.Name = "cbxIlter";
            this.cbxIlter.Size = new System.Drawing.Size( 196, 21 );
            this.cbxIlter.TabIndex = 121;
            this.cbxIlter.SelectedIndexChanged += new System.EventHandler( this.cbxIlter_SelectedIndexChanged );
            // 
            // txtFilter
            // 
            this.txtFilter.Location = new System.Drawing.Point( 287, 174 );
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size( 206, 20 );
            this.txtFilter.TabIndex = 122;
            this.txtFilter.TextChanged += new System.EventHandler( this.txtFilter_TextChanged );
            this.txtFilter.KeyPress += new System.Windows.Forms.KeyPressEventHandler( this.txtFilter_KeyPress );
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font( "Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ) );
            this.label2.Location = new System.Drawing.Point( 12, 613 );
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size( 85, 18 );
            this.label2.TabIndex = 123;
            this.label2.Text = "# Records: ";
            // 
            // lblRecordCount
            // 
            this.lblRecordCount.AutoSize = true;
            this.lblRecordCount.Font = new System.Drawing.Font( "Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ) );
            this.lblRecordCount.Location = new System.Drawing.Point( 94, 613 );
            this.lblRecordCount.Name = "lblRecordCount";
            this.lblRecordCount.Size = new System.Drawing.Size( 16, 18 );
            this.lblRecordCount.TabIndex = 124;
            this.lblRecordCount.Text = "0";
            // 
            // showPersonalInfoToolStripMenuItem
            // 
            this.showPersonalInfoToolStripMenuItem.Image = global::Hospital_Managment_System.Properties.Resources.PersonDetails_3221;
            this.showPersonalInfoToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.showPersonalInfoToolStripMenuItem.Name = "showPersonalInfoToolStripMenuItem";
            this.showPersonalInfoToolStripMenuItem.Size = new System.Drawing.Size( 197, 38 );
            this.showPersonalInfoToolStripMenuItem.Text = "Show Detalis";
            // 
            // addNewEmployeeToolStripMenuItem
            // 
            this.addNewEmployeeToolStripMenuItem.Image = global::Hospital_Managment_System.Properties.Resources.AddPerson_321;
            this.addNewEmployeeToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.addNewEmployeeToolStripMenuItem.Name = "addNewEmployeeToolStripMenuItem";
            this.addNewEmployeeToolStripMenuItem.Size = new System.Drawing.Size( 197, 38 );
            this.addNewEmployeeToolStripMenuItem.Text = "Add New Employee";
            this.addNewEmployeeToolStripMenuItem.Click += new System.EventHandler( this.addNewEmployeeToolStripMenuItem_Click );
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.Image = global::Hospital_Managment_System.Properties.Resources.edit_321;
            this.updateToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Size = new System.Drawing.Size( 197, 38 );
            this.updateToolStripMenuItem.Text = "Update";
            this.updateToolStripMenuItem.Click += new System.EventHandler( this.updateToolStripMenuItem_Click );
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Image = global::Hospital_Managment_System.Properties.Resources.Delete_32_21;
            this.deleteToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size( 197, 38 );
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler( this.deleteToolStripMenuItem_Click );
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Image = global::Hospital_Managment_System.Properties.Resources.cross_321;
            this.exitToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size( 197, 38 );
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler( this.exitToolStripMenuItem_Click );
            // 
            // frmAllEmployeesList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 13F );
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size( 1703, 655 );
            this.Controls.Add( this.lblRecordCount );
            this.Controls.Add( this.label2 );
            this.Controls.Add( this.txtFilter );
            this.Controls.Add( this.cbxIlter );
            this.Controls.Add( this.label1 );
            this.Controls.Add( this.btnAddNew );
            this.Controls.Add( this.btnClose );
            this.Controls.Add( this.panel1 );
            this.Controls.Add( this.lblTitle );
            this.Font = new System.Drawing.Font( "Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ) );
            this.Name = "frmAllEmployeesList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler( this.frmAllEmployeesList_Load );
            this.panel1.ResumeLayout( false );
            ( ( System.ComponentModel.ISupportInitialize ) ( this.dataGridView1 ) ).EndInit();
            this.cmsEmployees.ResumeLayout( false );
            this.ResumeLayout( false );
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxIlter;
        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblRecordCount;
        private System.Windows.Forms.ContextMenuStrip cmsEmployees;
        private System.Windows.Forms.ToolStripMenuItem showPersonalInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem addNewEmployeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}