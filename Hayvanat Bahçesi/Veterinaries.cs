using Hayvanat_Bahçesi.ORM.Context;
using Hayvanat_Bahçesi.ORM.Entity.ConditionalMapping;
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
    public partial class Veterinaries : Form
    {
        public Veterinaries()
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
            txtGraduateUniversity.Clear();
            txtProfession.Clear();
        }

        void GetVeterinariesList()
        {
            listView1.Items.Clear();
            var list = db.Veterinaries.ToList();

            foreach (var vet in list)
            {
                ListViewItem li = new ListViewItem(vet.VeterinaryID.ToString());
                li.SubItems.Add(vet.FirstName);
                li.SubItems.Add(vet.LastName);
                li.SubItems.Add(vet.GenderV.ToString());
                li.SubItems.Add(vet.Age.ToString());
                li.SubItems.Add(vet.Phone);
                li.SubItems.Add(vet.Address);
                li.SubItems.Add(vet.GraduateUniversity);
                li.SubItems.Add(vet.Profession);

                li.Tag = vet.VeterinaryID;
                listView1.Items.Add(li);
            }

        }

        void GetVeterinariesList(string filterKey)
        {
            listView1.Items.Clear();
            var list = db.Veterinaries
                .Where(i => i.FirstName.Contains(filterKey) || i.LastName.Contains(filterKey) || i.GenderV.ToString().Contains(filterKey) || i.GraduateUniversity.Contains(filterKey) || i.Profession.Contains(filterKey))
                .ToList();

            foreach (var vet in list)
            {
                ListViewItem li = new ListViewItem(vet.VeterinaryID.ToString());
                li.SubItems.Add(vet.FirstName);
                li.SubItems.Add(vet.LastName);
                li.SubItems.Add(vet.GenderV.ToString());
                li.SubItems.Add(vet.Age.ToString());
                li.SubItems.Add(vet.Phone);
                li.SubItems.Add(vet.Address);
                li.SubItems.Add(vet.GraduateUniversity);
                li.SubItems.Add(vet.Profession);

                li.Tag = vet.VeterinaryID;
                listView1.Items.Add(li);
            }

        }

        void AddVeterinary()
        {

            Veterinary vet = new Veterinary();
            vet.FirstName = txtFirstName.Text;
            vet.LastName = txtLastName.Text;
            vet.GenderV = (ORM.Entity.ConditionalMapping.GenderV)Enum.Parse(typeof(ORM.Entity.ConditionalMapping.GenderV), cmbGender.Text);
            vet.Age = Convert.ToInt32(txtAge.Text);
            vet.Phone = txtPhone.Text;
            vet.Address = txtAddress.Text;
            vet.GraduateUniversity = txtGraduateUniversity.Text;
            vet.Profession = txtProfession.Text;

            db.Veterinaries.Add(vet);

            bool result = db.SaveChanges() > 0;

            MessageBox.Show(result ? "Veterinary added" : "Operation error!");
            GetVeterinariesList();
            CleanForm();
        }

        void UpdateVeterinary(int id)
        {
            var vet = db.Veterinaries.Find(id);

            vet.FirstName = txtFirstName.Text;
            vet.LastName = txtLastName.Text;
            vet.GenderV = (ORM.Entity.ConditionalMapping.GenderV)Enum.Parse(typeof(ORM.Entity.ConditionalMapping.GenderV), cmbGender.Text);
            vet.Age = Convert.ToInt32(txtAge.Text);
            vet.Phone = txtPhone.Text;
            vet.Address = txtAddress.Text;
            vet.GraduateUniversity = txtGraduateUniversity.Text;
            vet.Profession = txtProfession.Text;

            db.Entry(vet).State = System.Data.Entity.EntityState.Modified;

            db.SaveChanges();
            GetVeterinariesList();
            CleanForm();

            btnSave.Text = "Add";
            groupBox1.Text = "Add Veterinary";
        }

        private void editToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            int editItemId = (int)listView1.SelectedItems[0].Tag;

            var vet = db.Veterinaries.Find(editItemId);

            if (vet != null)
            {

                groupBox1.Text = "Edit Veterinary";
                txtFirstName.Text = vet.FirstName;
                txtLastName.Text = vet.LastName;
                cmbGender.Text = vet.GenderV.ToString();
                txtAge.Text = vet.Age.ToString();
                txtPhone.Text = vet.Phone;
                txtAddress.Text = vet.Address;
                txtGraduateUniversity.Text = vet.GraduateUniversity;
                txtProfession.Text = vet.Profession;

                btnSave.Text = "Update";
                groupBox1.Tag = vet.VeterinaryID;

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
                    var vet = db.Veterinaries.Find(item);
                    if (vet != null)
                    {
                        db.Veterinaries.Remove(vet);
                        db.SaveChanges();
                        GetVeterinariesList();
                    }
                }
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            GetVeterinariesList(txtSearch.Text);
        }

        private void Veterinaries_Load(object sender, EventArgs e)
        {
            cmbGender.Items.AddRange(Enum.GetNames(typeof(ORM.Entity.ConditionalMapping.GenderV)));

            GetVeterinariesList();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int vetID = 0;

            if (groupBox1.Tag != null)
            {
                vetID = (int)groupBox1.Tag;

                UpdateVeterinary(vetID);
            }
            else
            {
                AddVeterinary();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }
    }
}

