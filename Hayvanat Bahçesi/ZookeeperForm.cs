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
    public partial class ZookeeperForm : Form
    {
        ApplicationDbContext db = new ApplicationDbContext();

        public ZookeeperForm()
        {
            InitializeComponent();
        }

        private void AnimalsWithCages_Load(object sender, EventArgs e)
        {   
            GetZookeepersList();
            GetCagesList();
        }

        void GetCagesList()
        {
            listView1.Items.Clear();
            var list = db.Cages.ToList();

            foreach (var cage in list)
            {
                ListViewItem li = new ListViewItem(cage.CageID.ToString());
                li.SubItems.Add(cage.CageName);
                li.SubItems.Add(cage.AnimalSpeciesInCage);
                li.SubItems.Add(cage.Location);
                li.Tag = cage.CageID;
                listView1.Items.Add(li);
            }
        }

        void GetCagesList(string filterKey)
        {
            listView1.Items.Clear();

            var list = db.Cages
                .Where(i => i.CageName.Contains(filterKey) || i.AnimalSpeciesInCage.Contains(filterKey))
                .ToList();

            foreach (var cage in list)
            {
                ListViewItem li = new ListViewItem(cage.CageID.ToString());
                li.SubItems.Add(cage.CageName);
                li.SubItems.Add(cage.AnimalSpeciesInCage);
                li.SubItems.Add(cage.Location);
                li.Tag = cage.CageID;
                listView1.Items.Add(li);
            }
        }

        void GetZookeepersList()
        {
            listView2.Items.Clear();
            var list = db.Zookeepers.ToList();

            foreach (var zok in list)
            {
                ListViewItem li = new ListViewItem(zok.ZookeeperID.ToString());
                li.SubItems.Add(zok.FirstName);
                li.SubItems.Add(zok.LastName);
                li.SubItems.Add(zok.Phone);
                li.SubItems.Add(zok.KindOfAnimalCaredFor);

                li.Tag = zok.ZookeeperID;
                listView2.Items.Add(li);
            }
        }

        void GetZookeepersList(string filterKey)
        {
            listView2.Items.Clear();
            var list = db.Zookeepers
                .Where(i => i.FirstName.Contains(filterKey) || i.LastName.Contains(filterKey) || i.KindOfAnimalCaredFor.Contains(filterKey))
                .ToList();

            foreach (var zok in list)
            {
                ListViewItem li = new ListViewItem(zok.ZookeeperID.ToString());
                li.SubItems.Add(zok.FirstName);
                li.SubItems.Add(zok.LastName);
                li.SubItems.Add(zok.Phone);
                li.SubItems.Add(zok.KindOfAnimalCaredFor);

                li.Tag = zok.ZookeeperID;
                listView2.Items.Add(li);
            }

        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            GetCagesList(txtSearch.Text);
        }

        private void txtSearch2_TextChanged(object sender, EventArgs e)
        {
            GetZookeepersList(txtSearch2.Text);
        }

    }
}
