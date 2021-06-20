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
    public partial class VeterinaryForm : Form
    {       
        ApplicationDbContext db = new ApplicationDbContext();

        public VeterinaryForm()
        {
            InitializeComponent();
        }

        private void VeterinaryForm_Load(object sender, EventArgs e)
        {
            GetAnimalsList();
        }

        void CleanForm()
        {
            txtVaccine.Clear();
            txtDisease.Clear();
        }

        void GetAnimalsList()
        {
            listView1.Items.Clear();
            var list = db.Animals.ToList();

            foreach (var animal in list)
            {
                ListViewItem li = new ListViewItem(animal.AnimalID.ToString());
                li.SubItems.Add(animal.Name);
                li.SubItems.Add(animal.Age.ToString());
                li.SubItems.Add(animal.Gender);
                li.SubItems.Add(animal.Weight);
                li.SubItems.Add(animal.Color);
                li.SubItems.Add(animal.Class);
                li.SubItems.Add(animal.Order);
                li.SubItems.Add(animal.Family);
                li.SubItems.Add(animal.Genus);
                li.SubItems.Add(animal.Species);
                li.SubItems.Add(animal.Vaccine);
                li.SubItems.Add(animal.Disease);


                li.Tag = animal.AnimalID;
                listView1.Items.Add(li);
            }
        }

        void GetAnimalsList(string filterKey)
        {
            listView1.Items.Clear();

            var list = db.Animals
                .Where(i => i.Name.Contains(filterKey) || i.Age.ToString().Contains(filterKey) || i.Gender.Contains(filterKey) || i.Weight.Contains(filterKey) || i.Color.Contains(filterKey) || i.Class.Contains(filterKey) || i.Order.Contains(filterKey) || i.Family.Contains(filterKey) || i.Genus.Contains(filterKey) || i.Species.Contains(filterKey) || i.Vaccine.Contains(filterKey) || i.Disease.Contains(filterKey))
                .ToList();

            foreach (var animal in list)
            {
                ListViewItem li = new ListViewItem(animal.AnimalID.ToString());
                li.SubItems.Add(animal.Name);
                li.SubItems.Add(animal.Age.ToString());
                li.SubItems.Add(animal.Gender);
                li.SubItems.Add(animal.Weight);
                li.SubItems.Add(animal.Color);
                li.SubItems.Add(animal.Class);
                li.SubItems.Add(animal.Order);
                li.SubItems.Add(animal.Family);
                li.SubItems.Add(animal.Genus);
                li.SubItems.Add(animal.Species);
                li.SubItems.Add(animal.Vaccine);
                li.SubItems.Add(animal.Disease);

                li.Tag = animal.AnimalID;
                listView1.Items.Add(li);
            }
        }

        void UpdateAnimalHealthInformation(int id)
        {
            var animal = db.Animals.Find(id);

            animal.Vaccine = txtVaccine.Text;
            animal.Disease = txtDisease.Text;

            db.Entry(animal).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();

            GetAnimalsList();
            CleanForm();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            GetAnimalsList(txtSearch.Text);
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int editItemId = (int)listView1.SelectedItems[0].Tag;

            var animal = db.Animals.Find(editItemId);


            if (animal != null)
            {

                groupBox1.Text = "Edit Animal Health Information";

                txtVaccine.Text = animal.Vaccine;
                txtDisease.Text = animal.Disease;

                btnSave.Text = "Update";
                groupBox1.Tag = animal.AnimalID;

            }

            else
            {

                MessageBox.Show("No Records Found", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int AnimalID = 0;

            AnimalID = (int)groupBox1.Tag;

            UpdateAnimalHealthInformation(AnimalID);
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }
    }
}
