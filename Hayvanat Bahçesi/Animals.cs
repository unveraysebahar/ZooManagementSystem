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
    public partial class FormAnimals : Form
    {
        ApplicationDbContext db = new ApplicationDbContext();
        public ORM.Entity.ManyToMany.Animal animal = new ORM.Entity.ManyToMany.Animal();
        public FormAnimals()
        {
            InitializeComponent();
        }

        private void FormAnimals_Load(object sender, EventArgs e)
        {
            GetAnimalsList();
        }

        void CleanForm()
        {
            txtName.Clear();
            txtAge.Clear();
            txtGender.Clear();
            txtWeight.Clear();
            txtWeight.Clear();
            txtClass.Clear();
            txtOrder.Clear();
            txtFamily.Clear();
            txtGenus.Clear();
            txtSpecies.Clear();
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

                li.Tag = animal.AnimalID;
                listView1.Items.Add(li);
            }
        }

        void GetAnimalsList(string filterKey)
        {
            listView1.Items.Clear();

            var list = db.Animals
                .Where(i => i.Name.Contains(filterKey) || i.Age.ToString().Contains(filterKey) || i.Gender.Contains(filterKey) || i.Weight.Contains(filterKey) || i.Color.Contains(filterKey) || i.Class.Contains(filterKey) || i.Order.Contains(filterKey) || i.Family.Contains(filterKey) || i.Genus.Contains(filterKey) || i.Species.Contains(filterKey))
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
                li.Tag = animal.AnimalID;
                listView1.Items.Add(li);
            }
        }

        void AddAnimal()
        {
            //  animal = new ORM.Entity.ManyToMany.Animal();
            //animal = new ORM.Entity.ManyToMany.Animal() { 
            // Age=5,Name ="a"
            //};

            //ORM.Entity.ManyToMany.Animal_Baby animal_Baby = new ORM.Entity.ManyToMany.Animal_Baby() {  BirthWeight= "10", DateOfBirth= DateTime.Now.ToString()};
            //animal.Animal_Babies= new List<Animal_Baby> { animal_Baby };
            //db.Animals.Add(animal);
            //bool result = db.SaveChanges() > 0;

            animal.Name= txtName.Text;
            animal.Age = Convert.ToInt32(txtAge.Text);
            animal.Gender = txtGender.Text;
            animal.Weight = txtWeight.Text;
            animal.Color = txtColor.Text;
            animal.Class = txtClass.Text;
            animal.Order = txtOrder.Text;
            animal.Family = txtFamily.Text;
            animal.Genus = txtGenus.Text;
            animal.Species = txtSpecies.Text;

            db.Animals.Add(animal);
             bool result = db.SaveChanges() > 0;
            MessageBox.Show(result ? "Animal Added" : "Operation Error!");

            GetAnimalsList();
            CleanForm();
        }

        void UpdateAnimal(int id)
        {
            animal = db.Animals.Find(id);

            animal.Name = txtName.Text;
            animal.Age = Convert.ToInt32(txtAge.Text);
            animal.Gender = txtGender.Text;
            animal.Weight = txtWeight.Text;
            animal.Color = txtColor.Text;
            animal.Class = txtClass.Text;
            animal.Order = txtOrder.Text;
            animal.Family = txtFamily.Text;
            animal.Genus = txtGenus.Text;
            animal.Species = txtSpecies.Text;

            db.Entry(animal).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();

            GetAnimalsList();
            CleanForm();

            btnSave.Text = "Add";
            groupBox1.Text = "Add Animal";
        }

        private void txtSearch_TextChanged_1(object sender, EventArgs e)
        {
            GetAnimalsList(txtSearch.Text);
        }

        private void editToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            int editItemId = (int)listView1.SelectedItems[0].Tag;

             animal = db.Animals.Find(editItemId);


            if (animal != null)
            {

                groupBox1.Text = "Edit Animal";
                txtName.Text = animal.Name;
                txtAge.Text = animal.Age.ToString();
                txtGender.Text = animal.Gender;
                txtWeight.Text = animal.Weight;
                txtColor.Text = animal.Color;
                txtClass.Text = animal.Class;
                txtOrder.Text = animal.Order;
                txtFamily.Text = animal.Family;
                txtGenus.Text = animal.Genus;
                txtSpecies.Text = animal.Species;

                btnSave.Text = "Update";
                groupBox1.Tag = animal.AnimalID;

            }

            else
            {

                MessageBox.Show("No Records Found", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void deleteToolStripMenuItem_Click_1(object sender, EventArgs e)
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
                    var animal = db.Animals.Find(item);
                    if (animal != null)
                    {
                        db.Animals.Remove(animal);
                        db.SaveChanges();
                        GetAnimalsList();
                    }
                }
            }
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            int AnimalID = 0;

            if (groupBox1.Tag != null)
            {
                AnimalID = (int)groupBox1.Tag;

                UpdateAnimal(AnimalID);
            }
            else
            {
                AddAnimal();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void btnBaby_Click(object sender, EventArgs e)
        {
            Animals_Babies ab = new Animals_Babies(this);
            ab.Show();
        }
    }
}
