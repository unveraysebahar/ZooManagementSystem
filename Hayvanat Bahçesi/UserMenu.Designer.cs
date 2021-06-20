namespace Hayvanat_Bahçesi
{
    partial class UserMenu
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
            this.ZookeeperToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ListOfAnimalsWithCagesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generalInformationAboutAnimalsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.VeterinaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ListOfAnimalsWithHealthStatusBilgileriToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.generalInformationAboutAnimalsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TicketClerkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TicketSalesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ZookeeperToolStripMenuItem,
            this.VeterinaryToolStripMenuItem,
            this.TicketClerkToolStripMenuItem,
            this.HelpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(400, 29);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ZookeeperToolStripMenuItem
            // 
            this.ZookeeperToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ListOfAnimalsWithCagesToolStripMenuItem,
            this.generalInformationAboutAnimalsToolStripMenuItem1});
            this.ZookeeperToolStripMenuItem.Name = "ZookeeperToolStripMenuItem";
            this.ZookeeperToolStripMenuItem.Size = new System.Drawing.Size(96, 25);
            this.ZookeeperToolStripMenuItem.Text = "Zookeeper";
            // 
            // ListOfAnimalsWithCagesToolStripMenuItem
            // 
            this.ListOfAnimalsWithCagesToolStripMenuItem.Name = "ListOfAnimalsWithCagesToolStripMenuItem";
            this.ListOfAnimalsWithCagesToolStripMenuItem.Size = new System.Drawing.Size(339, 26);
            this.ListOfAnimalsWithCagesToolStripMenuItem.Text = "List of Animals with Cages";
            this.ListOfAnimalsWithCagesToolStripMenuItem.Click += new System.EventHandler(this.ListOfAnimalsWithCagesToolStripMenuItem_Click);
            // 
            // generalInformationAboutAnimalsToolStripMenuItem1
            // 
            this.generalInformationAboutAnimalsToolStripMenuItem1.Name = "generalInformationAboutAnimalsToolStripMenuItem1";
            this.generalInformationAboutAnimalsToolStripMenuItem1.Size = new System.Drawing.Size(339, 26);
            this.generalInformationAboutAnimalsToolStripMenuItem1.Text = "General Information about Animals";
            this.generalInformationAboutAnimalsToolStripMenuItem1.Click += new System.EventHandler(this.generalInformationAboutAnimalsToolStripMenuItem1_Click);
            // 
            // VeterinaryToolStripMenuItem
            // 
            this.VeterinaryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ListOfAnimalsWithHealthStatusBilgileriToolStripMenuItem1,
            this.generalInformationAboutAnimalsToolStripMenuItem});
            this.VeterinaryToolStripMenuItem.Name = "VeterinaryToolStripMenuItem";
            this.VeterinaryToolStripMenuItem.Size = new System.Drawing.Size(96, 25);
            this.VeterinaryToolStripMenuItem.Text = "Veterinary";
            // 
            // ListOfAnimalsWithHealthStatusBilgileriToolStripMenuItem1
            // 
            this.ListOfAnimalsWithHealthStatusBilgileriToolStripMenuItem1.Name = "ListOfAnimalsWithHealthStatusBilgileriToolStripMenuItem1";
            this.ListOfAnimalsWithHealthStatusBilgileriToolStripMenuItem1.Size = new System.Drawing.Size(367, 26);
            this.ListOfAnimalsWithHealthStatusBilgileriToolStripMenuItem1.Text = "List of Animals with Health Information";
            this.ListOfAnimalsWithHealthStatusBilgileriToolStripMenuItem1.Click += new System.EventHandler(this.ListOfAnimalsWithHealthStatusBilgileriToolStripMenuItem1_Click);
            // 
            // generalInformationAboutAnimalsToolStripMenuItem
            // 
            this.generalInformationAboutAnimalsToolStripMenuItem.Name = "generalInformationAboutAnimalsToolStripMenuItem";
            this.generalInformationAboutAnimalsToolStripMenuItem.Size = new System.Drawing.Size(367, 26);
            this.generalInformationAboutAnimalsToolStripMenuItem.Text = "General Information about Animals";
            this.generalInformationAboutAnimalsToolStripMenuItem.Click += new System.EventHandler(this.generalInformationAboutAnimalsToolStripMenuItem_Click);
            // 
            // TicketClerkToolStripMenuItem
            // 
            this.TicketClerkToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TicketSalesToolStripMenuItem});
            this.TicketClerkToolStripMenuItem.Name = "TicketClerkToolStripMenuItem";
            this.TicketClerkToolStripMenuItem.Size = new System.Drawing.Size(103, 25);
            this.TicketClerkToolStripMenuItem.Text = "Ticket Clerk";
            // 
            // TicketSalesToolStripMenuItem
            // 
            this.TicketSalesToolStripMenuItem.Name = "TicketSalesToolStripMenuItem";
            this.TicketSalesToolStripMenuItem.Size = new System.Drawing.Size(173, 26);
            this.TicketSalesToolStripMenuItem.Text = "Ticket Sales";
            this.TicketSalesToolStripMenuItem.Click += new System.EventHandler(this.TicketSalesToolStripMenuItem_Click);
            // 
            // HelpToolStripMenuItem
            // 
            this.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem";
            this.HelpToolStripMenuItem.Size = new System.Drawing.Size(56, 25);
            this.HelpToolStripMenuItem.Text = "Help";
            this.HelpToolStripMenuItem.Click += new System.EventHandler(this.HelpToolStripMenuItem_Click);
            // 
            // UserMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(400, 200);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "UserMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form2";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ZookeeperToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem VeterinaryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TicketClerkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ListOfAnimalsWithCagesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ListOfAnimalsWithHealthStatusBilgileriToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem TicketSalesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HelpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generalInformationAboutAnimalsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generalInformationAboutAnimalsToolStripMenuItem1;
    }
}