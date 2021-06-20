 using Hayvanat_Bahçesi.ORM.Context;
using Hayvanat_Bahçesi.ORM.Entity.EntitySplitting;
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
    public partial class Login : Form

    {    
        ApplicationDbContext db;
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '*';
        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            using (db = new ApplicationDbContext())
            {

                var result = db.Users.Any(i => i.Username == txtUsername.Text && i.Password == txtPassword.Text);
                
                if (result == true)
                {
                        UserMenu f2 = new UserMenu(this);
                        f2.Show();
                        this.Hide();
                }
                else
                {
                    MessageBox.Show("Login information is incorrect!");
                }

            }
        }

        private void btnSystemAdminLogin_Click(object sender, EventArgs e)
        {
           
                if (txtSystemAdminUsername.Text == "bahar" && txtSystemAdminPassword.Text == "123")
                {
                SystemAdminMenu fsam = new SystemAdminMenu(this);
                fsam.Show();
                this.Hide();
                }
                else

                {
                    MessageBox.Show("Login information is incorrect!");
                }

        }

        private void button1_Click(object sender, EventArgs e)
        {
                this.Close();
                Application.Exit();
        }
    }
}
