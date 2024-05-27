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
            this.empolyeesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewEmpolyeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allEmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.empolyeesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(920, 72);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // empolyeesToolStripMenuItem
            // 
            this.empolyeesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewEmpolyeeToolStripMenuItem,
            this.allEmToolStripMenuItem});
            this.empolyeesToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empolyeesToolStripMenuItem.Image = global::Hospital_Managment_System.Properties.Resources.human_resources;
            this.empolyeesToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.empolyeesToolStripMenuItem.Name = "empolyeesToolStripMenuItem";
            this.empolyeesToolStripMenuItem.Size = new System.Drawing.Size(190, 68);
            this.empolyeesToolStripMenuItem.Text = "Empolyees";
            // 
            // addNewEmpolyeeToolStripMenuItem
            // 
            this.addNewEmpolyeeToolStripMenuItem.Image = global::Hospital_Managment_System.Properties.Resources.salesman;
            this.addNewEmpolyeeToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.addNewEmpolyeeToolStripMenuItem.Name = "addNewEmpolyeeToolStripMenuItem";
            this.addNewEmpolyeeToolStripMenuItem.Size = new System.Drawing.Size(282, 38);
            this.addNewEmpolyeeToolStripMenuItem.Text = "Add New Empolyee";
            this.addNewEmpolyeeToolStripMenuItem.Click += new System.EventHandler(this.addNewEmpolyeeToolStripMenuItem_Click);
            // 
            // allEmToolStripMenuItem
            // 
            this.allEmToolStripMenuItem.Name = "allEmToolStripMenuItem";
            this.allEmToolStripMenuItem.Size = new System.Drawing.Size(282, 38);
            this.allEmToolStripMenuItem.Text = "All Employees List";
            this.allEmToolStripMenuItem.Click += new System.EventHandler(this.allEmToolStripMenuItem_Click);
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
        private System.Windows.Forms.ToolStripMenuItem addNewEmpolyeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allEmToolStripMenuItem;
    }
}

