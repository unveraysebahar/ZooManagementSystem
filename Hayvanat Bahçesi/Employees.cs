using Hayvanat_Bahçesi.ORM.Context;
using Hayvanat_Bahçesi.ORM.Entity.TableSplitting;
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
    public partial class Employees : Form
    {
        ApplicationDbContext db = new ApplicationDbContext();

        public Employees()
        {
            InitializeComponent();
        }

        private void FormEmployees_Load(object sender, EventArgs e)
        {
            cmbGender.Items.AddRange(Enum.GetNames(typeof(GenderE)));
            cmbTitle.Items.AddRange(Enum.GetNames(typeof(Title)));

            GetEmployeesList();

        }

        void CleanForm()
        {
            txtFirstName.Clear();
            txtLastName.Clear();
            cmbGender.Items.RemoveAt(cmbGender.SelectedIndex);
            cmbTitle.Items.RemoveAt(cmbTitle.SelectedIndex);
            txtEmail.Clear();
            txtPhone.Clear();
            txtAddress.Clear();
        }

        void GetEmployeesList()
        {
            listView1.Items.Clear();
            var list = db.Employees.ToList();

            foreach (var employee in list)
            {
                ListViewItem li = new ListViewItem(employee.EmployeeID.ToString());
                li.SubItems.Add(employee.FirstName);
                li.SubItems.Add(employee.LastName);
                li.SubItems.Add(employee.GenderE.ToString());
                li.SubItems.Add(employee.Title.ToString());
                li.SubItems.Add(employee.EmployeeContactDetail.Email);
                li.SubItems.Add(employee.EmployeeContactDetail.Phone);
                li.SubItems.Add(employee.EmployeeContactDetail.Address);
                li.Tag = employee.EmployeeID;
                listView1.Items.Add(li);
            }

        }

        void GetEmployeesList(string filterKey)
        {
            listView1.Items.Clear();
            var list = db.Employees
                .Where(i => i.FirstName.Contains(filterKey) || i.LastName.Contains(filterKey) || i.GenderE.ToString().Contains(filterKey) || i.Title.ToString().Contains(filterKey) || i.EmployeeContactDetail.Email.Contains(filterKey) || i.EmployeeContactDetail.Phone.Contains(filterKey) || i.EmployeeContactDetail.Address.Contains(filterKey))
                .ToList();

            foreach (var employee in list)
            {
                ListViewItem li = new ListViewItem(employee.EmployeeID.ToString());
                li.SubItems.Add(employee.FirstName);
                li.SubItems.Add(employee.LastName);
                li.SubItems.Add(employee.GenderE.ToString());
                li.SubItems.Add(employee.Title.ToString());
                li.SubItems.Add(employee.EmployeeContactDetail.Email);
                li.SubItems.Add(employee.EmployeeContactDetail.Phone);
                li.SubItems.Add(employee.EmployeeContactDetail.Address);

                li.Tag = employee.EmployeeID;
                listView1.Items.Add(li);
            }

        }

        void AddEmployee()
        {

            ORM.Entity.TableSplitting.Employee employee = new ORM.Entity.TableSplitting.Employee();
            employee.FirstName = txtFirstName.Text;
            employee.LastName = txtLastName.Text;
            employee.GenderE = (GenderE)Enum.Parse(typeof(GenderE), cmbGender.Text);
            employee.Title = (Title)Enum.Parse(typeof(Title), cmbTitle.Text);
            //employee.EmployeeId = 5;
            EmployeeContactDetail contactDetail = new EmployeeContactDetail()
            {
                Email = txtEmail.Text,
                Phone = txtPhone.Text,
                Address = txtAddress.Text,

             //EmployeeId= 5
             //EmployeeId = employee.EmployeeId

            };

            //contactDetail.Employee = employee;

            employee.EmployeeContactDetail = contactDetail;

            //db.Employees.Add(contactDetail);

            db.Employees.Add(employee);

            bool result = db.SaveChanges() > 0;

            MessageBox.Show(result ? "Employee added" : "Operation error!");
            GetEmployeesList();
            CleanForm();
        }

        void UpdateEmployee(int id)
        {
            var employee = db.Employees.Find(id);

            employee.FirstName = txtFirstName.Text;
            employee.LastName = txtLastName.Text;
            employee.GenderE = (GenderE)Enum.Parse(typeof(GenderE), cmbGender.Text);
            employee.Title = (Title)Enum.Parse(typeof(Title), cmbTitle.Text);
            employee.EmployeeContactDetail = new EmployeeContactDetail();
            employee.EmployeeContactDetail.Email = txtEmail.Text;
            employee.EmployeeContactDetail.Phone = txtPhone.Text;
            employee.EmployeeContactDetail.Address = txtAddress.Text;

            db.Entry(employee).State = System.Data.Entity.EntityState.Modified;

            db.SaveChanges();
            GetEmployeesList();
            CleanForm();

            btnSave.Text = "Add";
            groupBox1.Text = "Add Employee";
        }

        private void txtSearch_TextChanged_1(object sender, EventArgs e)
        {
            GetEmployeesList(txtSearch.Text);
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int editItemId = (int)listView1.SelectedItems[0].Tag;

            var employee = db.Employees.Find(editItemId);


            if (employee != null)
            {

                groupBox1.Text = "Edit Employee";
                txtFirstName.Text = employee.FirstName;
                txtLastName.Text = employee.LastName;
                cmbGender.Text = employee.GenderE.ToString();
                cmbTitle.Text = employee.Title.ToString();
                txtEmail.Text = employee.EmployeeContactDetail.Email;
                txtPhone.Text = employee.EmployeeContactDetail.Phone;
                txtAddress.Text = employee.EmployeeContactDetail.Address;

                btnSave.Text = "Update";
                groupBox1.Tag = employee.EmployeeID;

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
                    var contact = db.Employees.Find(item);
                    if (contact != null)
                    {
                        db.Employees.Remove(contact);
                        db.SaveChanges();
                        GetEmployeesList();
                    }
                }
            }
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            int employeeId = 0;

            if (groupBox1.Tag != null)
            {
                employeeId = (int)groupBox1.Tag;

                UpdateEmployee(employeeId);
            }
            else
            {
                AddEmployee();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }
    }
}
