namespace Hayvanat_Bahçesi
{
    partial class SystemAdminMenu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ListOfUsersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ListOfEmployeesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listOfZookeepersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listOfVeterinariesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ListOfAnimalsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.listOfCagesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ListOfUsersToolStripMenuItem,
            this.ListOfEmployeesToolStripMenuItem,
            this.listOfZookeepersToolStripMenuItem,
            this.listOfVeterinariesToolStripMenuItem,
            this.ListOfAnimalsToolStripMenuItem1,
            this.listOfCagesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1034, 29);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ListOfUsersToolStripMenuItem
            // 
            this.ListOfUsersToolStripMenuItem.Name = "ListOfUsersToolStripMenuItem";
            this.ListOfUsersToolStripMenuItem.Size = new System.Drawing.Size(109, 25);
            this.ListOfUsersToolStripMenuItem.Text = "List of Users";
            this.ListOfUsersToolStripMenuItem.Click += new System.EventHandler(this.ListOfUsersToolStripMenuItem_Click);
            // 
            // ListOfEmployeesToolStripMenuItem
            // 
            this.ListOfEmployeesToolStripMenuItem.Name = "ListOfEmployeesToolStripMenuItem";
            this.ListOfEmployeesToolStripMenuItem.Size = new System.Drawing.Size(145, 25);
            this.ListOfEmployeesToolStripMenuItem.Text = "List of Employees";
            this.ListOfEmployeesToolStripMenuItem.Click += new System.EventHandler(this.ListOfEmployeesToolStripMenuItem_Click);
            // 
            // listOfZookeepersToolStripMenuItem
            // 
            this.listOfZookeepersToolStripMenuItem.Name = "listOfZookeepersToolStripMenuItem";
            this.listOfZookeepersToolStripMenuItem.Size = new System.Drawing.Size(149, 25);
            this.listOfZookeepersToolStripMenuItem.Text = "List of Zookeepers";
            this.listOfZookeepersToolStripMenuItem.Click += new System.EventHandler(this.listOfZookeepersToolStripMenuItem_Click);
            // 
            // listOfVeterinariesToolStripMenuItem
            // 
            this.listOfVeterinariesToolStripMenuItem.Name = "listOfVeterinariesToolStripMenuItem";
            this.listOfVeterinariesToolStripMenuItem.Size = new System.Drawing.Size(153, 25);
            this.listOfVeterinariesToolStripMenuItem.Text = "List of Veterinaries";
            this.listOfVeterinariesToolStripMenuItem.Click += new System.EventHandler(this.listOfVeterinariesToolStripMenuItem_Click);
            // 
            // ListOfAnimalsToolStripMenuItem1
            // 
            this.ListOfAnimalsToolStripMenuItem1.Name = "ListOfAnimalsToolStripMenuItem1";
            this.ListOfAnimalsToolStripMenuItem1.Size = new System.Drawing.Size(126, 25);
            this.ListOfAnimalsToolStripMenuItem1.Text = "List of Animals";
            this.ListOfAnimalsToolStripMenuItem1.Click += new System.EventHandler(this.ListOfAnimalsToolStripMenuItem1_Click);
            // 
            // listOfCagesToolStripMenuItem
            // 
            this.listOfCagesToolStripMenuItem.Name = "listOfCagesToolStripMenuItem";
            this.listOfCagesToolStripMenuItem.Size = new System.Drawing.Size(110, 25);
            this.listOfCagesToolStripMenuItem.Text = "List of Cages";
            this.listOfCagesToolStripMenuItem.Click += new System.EventHandler(this.listOfCagesToolStripMenuItem_Click);
            // 
            // SystemAdminMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 331);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "SystemAdminMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "FormSystemAdminMenu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ListOfUsersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ListOfEmployeesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ListOfAnimalsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem listOfZookeepersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listOfVeterinariesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listOfCagesToolStripMenuItem;
    }
}