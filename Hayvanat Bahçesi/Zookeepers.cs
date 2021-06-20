using Hayvanat_Bahçesi.ORM.Context;
using Hayvanat_Bahçesi.ORM.Entity.ManyToMany;
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
    public partial class Zookeepers : Form
    {
        public Zookeepers()
        {
            InitializeComponent();
        }

        ApplicationDbContext db = new ApplicationDbContext();

        void CleanForm()
        {
            txtFirstName.Clear();
            txtLastName.Clear();
            cmbGender.Items.RemoveAt(cmbGender.SelectedIndex);
            txtAge.Clear();
            txtPhone.Clear();
            txtAddress.Clear();
            txtKindOfAnimalCareFor.Clear();
        }

        void GetZookeepersList()
        {
            listView1.Items.Clear();
            var list = db.Zookeepers.ToList();

            foreach (var zok in list)
            {
                ListViewItem li = new ListViewItem(zok.ZookeeperID.ToString());
                li.SubItems.Add(zok.FirstName);
                li.SubItems.Add(zok.LastName);
                li.SubItems.Add(zok.Gender.ToString());
                li.SubItems.Add(zok.Age.ToString());
                li.SubItems.Add(zok.Phone);
                li.SubItems.Add(zok.Address);
                li.SubItems.Add(zok.KindOfAnimalCaredFor);

                li.Tag = zok.ZookeeperID;
                listView1.Items.Add(li);
            }

        }

        void GetZookeepersList(string filterKey)
        {
            listView1.Items.Clear();
            var list = db.Zookeepers
                .Where(i => i.FirstName.Contains(filterKey) || i.LastName.Contains(filterKey) || i.Gender.ToString().Contains(filterKey) || i.KindOfAnimalCaredFor.Contains(filterKey))
                .ToList();

            foreach (var zok in list)
            {
                ListViewItem li = new ListViewItem(zok.ZookeeperID.ToString());
                li.SubItems.Add(zok.FirstName);
                li.SubItems.Add(zok.LastName);
                li.SubItems.Add(zok.Gender.ToString());
                li.SubItems.Add(zok.Age.ToString());
                li.SubItems.Add(zok.Phone);
                li.SubItems.Add(zok.Address);
                li.SubItems.Add(zok.KindOfAnimalCaredFor);

                li.Tag = zok.ZookeeperID;
                listView1.Items.Add(li);
            }

        }

        void AddZookeeper()
        {

            Zookeeper zok = new Zookeeper();
            zok.FirstName = txtFirstName.Text;
            zok.LastName = txtLastName.Text;
            zok.Gender = (Gender)Enum.Parse(typeof(Gender), cmbGender.Text);
            zok.Age = Convert.ToInt32(txtAge.Text);
            zok.Phone = txtPhone.Text;
            zok.Address = txtAddress.Text;
            zok.KindOfAnimalCaredFor = txtKindOfAnimalCareFor.Text;

            db.Zookeepers.Add(zok);

            bool result = db.SaveChanges() > 0;

            MessageBox.Show(result ? "Zookeeper added" : "Operation error!");
            GetZookeepersList();
            CleanForm();
        }

        void UpdateZookeeper(int id)
        {
            var zok = db.Zookeepers.Find(id);

            zok.FirstName = txtFirstName.Text;
            zok.LastName = txtLastName.Text;
            zok.Gender = (Gender)Enum.Parse(typeof(Gender), cmbGender.Text);
            zok.Age = Convert.ToInt32(txtAge.Text);
            zok.Phone = txtPhone.Text;
            zok.Address = txtAddress.Text;
            zok.KindOfAnimalCaredFor = txtKindOfAnimalCareFor.Text;

            db.Entry(zok).State = System.Data.Entity.EntityState.Modified;

            db.SaveChanges();
            GetZookeepersList();
            CleanForm();

            btnSave.Text = "Add";
            groupBox1.Text = "Add Zookeeper";
        }

        private void txtSearch_TextChanged_1(object sender, EventArgs e)
        {
            GetZookeepersList(txtSearch.Text);
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            int zokID = 0;

            if (groupBox1.Tag != null)
            {
                zokID = (int)groupBox1.Tag;

                UpdateZookeeper(zokID);
            }
            else
            {
                AddZookeeper();
            }
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int editItemId = (int)listView1.SelectedItems[0].Tag;

            var zok = db.Zookeepers.Find(editItemId);

            if (zok != null)
            {

                groupBox1.Text = "Edit Zookeeper";
                txtFirstName.Text = zok.FirstName;
                txtLastName.Text = zok.LastName;
                cmbGender.Text = zok.Gender.ToString();
                txtAge.Text = zok.Age.ToString();
                txtPhone.Text = zok.Phone;
                txtAddress.Text = zok.Address;
                txtKindOfAnimalCareFor.Text = zok.KindOfAnimalCaredFor;

                btnSave.Text = "Update";
                groupBox1.Tag = zok.ZookeeperID;

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
                    var zok = db.Zookeepers.Find(item);
                    if (zok != null)
                    {
                        db.Zookeepers.Remove(zok);
                        db.SaveChanges();
                        GetZookeepersList();
                    }
                }
            }
        }

        private void Zookeepers_Load(object sender, EventArgs e)
        {
            cmbGender.Items.AddRange(Enum.GetNames(typeof(Gender)));

            GetZookeepersList();
        }
    }
}
