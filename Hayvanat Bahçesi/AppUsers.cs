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
    public partial class AppUsers : Form
    {
        ApplicationDbContext db = new ApplicationDbContext();

        public AppUsers()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            GetUsersList();
        }

        void CleanForm()
        {
            txtUsername.Clear();
            txtPassword.Clear();
            txtContactNumber.Clear();
            txtAddress.Clear();
            txtAuthorization.Clear();
        }

        void GetUsersList()
        {
            listView1.Items.Clear();
            var list = db.Users.ToList();

            foreach (var appUser in list)
            {
                ListViewItem li = new ListViewItem(appUser.Id.ToString());
                li.SubItems.Add(appUser.Username);
                li.SubItems.Add(appUser.Password);
                li.SubItems.Add(appUser.ContactNumber);
                li.SubItems.Add(appUser.Address);
                li.Tag = appUser.Id;
                listView1.Items.Add(li);
            }
        }

        void GetUsersList(string filterKey)
        {
            listView1.Items.Clear();

            var list = db.Users
                .Where(i => i.Username.Contains(filterKey) || i.Password.Contains(filterKey) || i.ContactNumber.Contains(filterKey) || i.Address.Contains(filterKey))
                .ToList();

            foreach (var appUser in list)
            {
                ListViewItem li = new ListViewItem(appUser.Id.ToString());
                li.SubItems.Add(appUser.Username);
                li.SubItems.Add(appUser.Password);
                li.SubItems.Add(appUser.ContactNumber);
                li.SubItems.Add(appUser.Address);
                li.Tag = appUser.Id;
                listView1.Items.Add(li);
            }
        }

        void AddUser()
        {
            ORM.Entity.EntitySplitting.AppUser appUser = new ORM.Entity.EntitySplitting.AppUser();
            appUser.Username = txtUsername.Text;
            appUser.Password = txtPassword.Text;
            appUser.ContactNumber = txtContactNumber.Text;
            appUser.Address = txtAddress.Text;

            db.Users.Add(appUser);
            bool result = db.SaveChanges() > 0;
            MessageBox.Show(result ? "User Added" : "Operation Error!");

            GetUsersList();
            CleanForm();
        }

        void UpdateUser(int id)
        {
            var AppUser = db.Users.Find(id);

            AppUser.Username= txtUsername.Text;
            AppUser.Password= txtPassword.Text;
            AppUser.ContactNumber = txtContactNumber.Text;
            AppUser.Address = txtAddress.Text;
            db.Entry(AppUser).State = System.Data.Entity.EntityState.Modified;

            db.SaveChanges();

            GetUsersList();
            CleanForm();

            btnSave.Text = "Add";
            groupBox1.Text = "Add User";
        }

        private void txtSearch_TextChanged_1(object sender, EventArgs e)
        {
            GetUsersList(txtSearch.Text);
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int editItemId = (int)listView1.SelectedItems[0].Tag;

            var appUser = db.Users.Find(editItemId);

            if (appUser != null)
            {
                groupBox1.Text = "Edit User";
                txtUsername.Text = appUser.Username;
                txtPassword.Text = appUser.Password;
                txtContactNumber.Text = appUser.ContactNumber;
                txtAddress.Text = appUser.Address;
                btnSave.Text = "Update";
                groupBox1.Tag = appUser.Id;
            }
            else
            {
                MessageBox.Show("No Records Found", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<int> deletelist = new List<int>();

            foreach (ListViewItem item in listView1.SelectedItems)
            {
                deletelist.Add((int)item.Tag);
            }

            DialogResult dr = MessageBox
                .Show(deletelist.Count > 1 ? "More than one record will be deleted. Are you sure?" : "Are you sure you want to delete this record?",
                "Warning",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Warning);

            if (dr == DialogResult.OK)
            {
                foreach (var item in deletelist)
                {
                    var contact = db.Users.Find(item);
                    if (contact != null)
                    {
                        db.Users.Remove(contact);
                        db.SaveChanges();
                        GetUsersList();
                    }
                }
            }
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            int userId = 0;

            if (groupBox1.Tag != null)
            {
                userId = (int)groupBox1.Tag;
                UpdateUser(userId);
            }
            else
            {
                AddUser();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }


    }
}
