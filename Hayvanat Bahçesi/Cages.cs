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
    public partial class Cages : Form
    {
        ApplicationDbContext db = new ApplicationDbContext();

        public Cages()
        {
            InitializeComponent();
        }

        private void Cages_Load(object sender, EventArgs e)
        {
            GetCagesList();
        }

        void CleanForm()
        {
            txtCageName.Clear();
            txtSize.Clear();
            txtHeat.Clear();
            txtFloorMaterial.Clear();
            txtAnimalSpeciesInCage.Clear();
            txtLocation.Clear();
        }

        void GetCagesList()
        {
            listView1.Items.Clear();
            var list = db.Cages.ToList();

            foreach (var cage in list)
            {
                ListViewItem li = new ListViewItem(cage.CageID.ToString());
                li.SubItems.Add(cage.CageName);
                li.SubItems.Add(cage.Size);
                li.SubItems.Add(cage.Heat);
                li.SubItems.Add(cage.FloorMaterial);
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
                .Where(i => i.CageName.Contains(filterKey) || i.Size.Contains(filterKey) || i.Heat.Contains(filterKey) || i.FloorMaterial.Contains(filterKey) || i.AnimalSpeciesInCage.Contains(filterKey))
                .ToList();

            foreach (var cage in list)
            {
                ListViewItem li = new ListViewItem(cage.CageID.ToString());
                li.SubItems.Add(cage.CageName);
                li.SubItems.Add(cage.Size);
                li.SubItems.Add(cage.Heat);
                li.SubItems.Add(cage.FloorMaterial);
                li.SubItems.Add(cage.AnimalSpeciesInCage);
                li.SubItems.Add(cage.Location);
                li.Tag = cage.CageID;
                listView1.Items.Add(li);
            }
        }

        void AddCage()
        {
            Cage cage = new Cage();

            cage.CageName = txtCageName.Text;
            cage.Size = txtSize.Text;
            cage.Heat = txtHeat.Text;
            cage.FloorMaterial = txtFloorMaterial.Text;
            cage.AnimalSpeciesInCage = txtAnimalSpeciesInCage.Text;
            cage.Location = txtLocation.Text;

            db.Cages.Add(cage);
            bool result = db.SaveChanges() > 0;

            MessageBox.Show(result ? "Cage Added" : "Operation Error!");
            GetCagesList();
            CleanForm();
        }

        void UpdateCage(int id)
        {
            var cage = db.Cages.Find(id);

            cage.CageName = txtCageName.Text;
            cage.Size = txtSize.Text;
            cage.Heat = txtHeat.Text;
            cage.FloorMaterial = txtFloorMaterial.Text;
            cage.AnimalSpeciesInCage = txtAnimalSpeciesInCage.Text;
            cage.Location = txtLocation.Text;

            db.Entry(cage).State = System.Data.Entity.EntityState.Modified;

            db.SaveChanges();
            GetCagesList();
            CleanForm();

            btnSave.Text = "Add";
            groupBox1.Text = "Add Cage";
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            GetCagesList(txtSearch.Text);
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int editItemId = (int)listView1.SelectedItems[0].Tag;

            var cage = db.Cages.Find(editItemId);

            if (cage != null)
            {
                groupBox1.Text = "Edit Cage";
                txtCageName.Text = cage.CageName;
                txtSize.Text = cage.Size;
                txtHeat.Text = cage.Heat;
                txtFloorMaterial.Text = cage.FloorMaterial;
                txtAnimalSpeciesInCage.Text = cage.AnimalSpeciesInCage;
                txtLocation.Text = cage.Location;
                btnSave.Text = "Update";
                groupBox1.Tag = cage.CageID;
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
                    var contact = db.Cages.Find(item);
                    if (contact != null)
                    {
                        db.Cages.Remove(contact);
                        db.SaveChanges();
                        GetCagesList();
                    }
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int cageId = 0;

            if (groupBox1.Tag != null)
            {
                cageId = (int)groupBox1.Tag;
                UpdateCage(cageId);
            }
            else
            {
                AddCage();
            }
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }
    }
}
