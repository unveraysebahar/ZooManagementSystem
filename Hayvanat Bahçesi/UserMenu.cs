using Hayvanat_Bahçesi.ORM.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hayvanat_Bahçesi
{
    public partial class UserMenu : Form
    {
        Login mainform;
        public UserMenu(Login f1)
        {
            mainform = f1;
            InitializeComponent();
        }

        public UserMenu()
        {
            InitializeComponent();
        }

        void ChildForm(Form _childform)
        {
            this.Width = _childform.Width + 22;
            this.Height = _childform.Height + 68;

            bool durum = false;
            foreach (Form frm in this.MdiChildren)
            {
                if (frm.Text == _childform.Text)
                {
                    durum = true;
                    frm.Activate();
                }
                else
                {
                    frm.Close();
                }
            }

            if (durum == false)
            {
                _childform.MdiParent = this;
                _childform.Show();
            }
        }

        private void ListOfAnimalsWithHealthStatusBilgileriToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ChildForm(new VeterinaryForm());
        }

        private void generalInformationAboutAnimalsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChildForm(new AnimalsInformation());
        }

        private void generalInformationAboutAnimalsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ChildForm(new AnimalsInformation());
        }

        private void ListOfAnimalsWithCagesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChildForm(new ZookeeperForm());
        }

        private void TicketSalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChildForm(new TicketClerkForm());
        }

        private void HelpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChildForm(new Help());
        }
    }
}
