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
    public partial class Animals_Babies : Form
    {
        ApplicationDbContext db = new ApplicationDbContext();
        //ORM.Entity.ManyToMany.Animal _animal = new ORM.Entity.ManyToMany.Animal();

        FormAnimals frmAnimals = null;

        public Animals_Babies(FormAnimals _frmAnimals)
        {
            InitializeComponent();
            this.frmAnimals = _frmAnimals;
           //_animal = animal;
           //_animal.Animal_Babies = new List<Animal_Baby>();
        }

        private void Animals_Babies_Load(object sender, EventArgs e)
        {
            GetBabiesList();
        }

        void CleanForm()
        {
            txtDateOfBirth.Clear();
            txtBirthWeight.Clear();
        }

        void GetBabiesList()
        {
            listView1.Items.Clear();
            var list = db.Animal_Babies.Where(i => i.AnimalBabyID == frmAnimals.animal.AnimalID).ToList();

            foreach (var baby in list)
            {
                ListViewItem li = new ListViewItem(baby.AnimalBabyID.ToString());
                li.SubItems.Add(baby.DateOfBirth);
                li.SubItems.Add(baby.BirthWeight);
                li.Tag = baby.AnimalBabyID;
                listView1.Items.Add(li);
            }
        }

        void GetBabiesList(string filterKey)
        {
            listView1.Items.Clear();

            var list = db.Animal_Babies
                .Where(i =>i.AnimalBabyID== frmAnimals.animal.AnimalID && (i.DateOfBirth.Contains(filterKey) || i.BirthWeight.Contains(filterKey)))
                .ToList();

            foreach (var baby in list)
            {
                ListViewItem li = new ListViewItem(baby.AnimalBabyID.ToString());
                li.SubItems.Add(baby.DateOfBirth);
                li.SubItems.Add(baby.BirthWeight);
                li.Tag = baby.AnimalBabyID;
                listView1.Items.Add(li);
            }
        }

        void AddBaby()
        {
            Animal_Baby baby = new Animal_Baby();

            baby.DateOfBirth = txtDateOfBirth.Text;
            baby.BirthWeight = txtBirthWeight.Text;


            //_animal.Animal_Babies.Add(baby);
            //frmAnimals.animal.Animal_Babies = new List<Animal_Baby>() { baby };
            db.Animal_Babies.Add(baby); 
            bool result = db.SaveChanges() > 0;

            MessageBox.Show(result ? "Baby Added" : "Operation Error!");
            GetBabiesList();
            CleanForm();
        }

        void UpdateBaby(int id)
        {
            var baby = db.Animal_Babies.Find(id);

            baby.DateOfBirth = txtDateOfBirth.Text;
            baby.BirthWeight = txtBirthWeight.Text;

            db.Entry(baby).State = System.Data.Entity.EntityState.Modified;

            db.SaveChanges();
            GetBabiesList();
            CleanForm();

            btnSave.Text = "Add";
            groupBox1.Text = "Add Baby";
        }

        private void txtSearch_TextChanged_1(object sender, EventArgs e)
        {
            GetBabiesList(txtSearch.Text);
        }

        private void editToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            int editItemId = (int)listView1.SelectedItems[0].Tag;

            var baby = db.Animal_Babies.Find(editItemId);

            if (baby != null)
            {
                groupBox1.Text = "Edit Baby";
                txtDateOfBirth.Text = baby.DateOfBirth;
                txtBirthWeight.Text = baby.BirthWeight;
                btnSave.Text = "Update";
                groupBox1.Tag = baby.AnimalBabyID;
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
                    var baby = db.Animal_Babies.Find(item);
                    if (baby != null)
                    {
                        db.Animal_Babies.Remove(baby);
                        db.SaveChanges();
                        GetBabiesList();
                    }
                }
            }
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {

            int BabyID = 0;

            if (groupBox1.Tag != null)
            {
                BabyID = (int)groupBox1.Tag;
                UpdateBaby(BabyID);
            }
            else
            {
                AddBaby();
            }

            Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }
    }
}
