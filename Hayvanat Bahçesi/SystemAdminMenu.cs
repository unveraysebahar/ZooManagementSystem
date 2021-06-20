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
    public partial class SystemAdminMenu : Form
    {
        Login mainform;
        public SystemAdminMenu()
        {
            InitializeComponent();
        }

        public SystemAdminMenu(Login f1)
        {
            mainform = f1;
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

        private void ListOfUsersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChildForm(new AppUsers());
        }

        private void ListOfEmployeesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChildForm(new Employees());
        }

        private void ListOfAnimalsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ChildForm(new FormAnimals());
        }

        private void listOfZookeepersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChildForm(new Zookeepers());
        }

        private void listOfVeterinariesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChildForm(new Veterinaries());
        }

        private void listOfCagesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChildForm(new Cages());
        }
    }
}
