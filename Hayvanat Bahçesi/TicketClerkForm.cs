using Hayvanat_Bahçesi.ORM.Context;
using Hayvanat_Bahçesi.ORM.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hayvanat_Bahçesi
{
    public partial class TicketClerkForm : Form
    {
        ApplicationDbContext db = new ApplicationDbContext();

        public TicketClerkForm()
        {
            InitializeComponent();
        }

        private void TicketSales_Load(object sender, EventArgs e)
        {
            GetVisitorsList();

        }

        void CleanForm()
        {
            txtVisitorName.Clear();
            txtVisitDate.Clear();
            txtDayOfVisit.Clear();
            txtVisitTime.Clear();
            txtPaidTicket.Clear();
        }

        void GetVisitorsList()
        {
            listView1.Items.Clear();
            var list = db.Visitors.ToList();

            foreach (var visitor in list)
            {
                ListViewItem li = new ListViewItem(visitor.VisitorID.ToString());
                li.SubItems.Add(visitor.VisitorName);
                li.SubItems.Add(visitor.VisitDate);
                li.SubItems.Add(visitor.DayOfVisit);
                li.SubItems.Add(visitor.VisitTime);
                li.SubItems.Add(visitor.PaidTicket);
                li.Tag = visitor.VisitorID;
                listView1.Items.Add(li);
            }
        }

        void GetVisitorsList(string filterKey)
        {
            listView1.Items.Clear();

            var list = db.Visitors
                .Where(i => i.VisitorName.Contains(filterKey) || i.VisitDate.Contains(filterKey) ||i.DayOfVisit.Contains(filterKey) || i.VisitTime.Contains(filterKey) || i.PaidTicket.Contains(filterKey))
                .ToList();

            foreach (var visitor in list)
            {
                ListViewItem li = new ListViewItem(visitor.VisitorID.ToString());
                li.SubItems.Add(visitor.VisitorName);
                li.SubItems.Add(visitor.VisitDate);
                li.SubItems.Add(visitor.DayOfVisit);
                li.SubItems.Add(visitor.VisitTime);
                li.SubItems.Add(visitor.PaidTicket);
                li.Tag = visitor.VisitorID;
                listView1.Items.Add(li);
            }
        }

        void AddVisitor()
        {
            Visitor visitor = new Visitor();
            visitor.VisitorName = txtVisitorName.Text;
            visitor.VisitDate = txtVisitDate.Text;
            visitor.DayOfVisit = txtDayOfVisit.Text;
            visitor.VisitTime = txtVisitTime.Text;
            visitor.PaidTicket = txtPaidTicket.Text;

            db.Visitors.Add(visitor);
            bool result = db.SaveChanges() > 0;

            MessageBox.Show(result ? "Visitor Added" : "Operation Error!");
            GetVisitorsList();
            CleanForm();
        }

        void UpdateVisitor(int id)
        {
            var visitor = db.Visitors.Find(id);

            visitor.VisitorName = txtVisitorName.Text;
            visitor.VisitDate = txtVisitDate.Text;
            visitor.DayOfVisit = txtDayOfVisit.Text;
            visitor.VisitTime = txtVisitTime.Text;
            visitor.PaidTicket = txtPaidTicket.Text;

            db.Entry(visitor).State = System.Data.Entity.EntityState.Modified;

            db.SaveChanges();
            GetVisitorsList();
            CleanForm();

            btnSave.Text = "Add";
            groupBox1.Text = "Add Visitor";
        }

        private void txtSearch_TextChanged_1(object sender, EventArgs e)
        {
            GetVisitorsList(txtSearch.Text);
        }

        private void editToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            int editItemId = (int)listView1.SelectedItems[0].Tag;

            var visitor = db.Visitors.Find(editItemId);

            if (visitor != null)
            {
                groupBox1.Text = "Edit Visitor";
                txtVisitorName.Text = visitor.VisitorName;
                txtVisitDate.Text = visitor.VisitDate;
                txtDayOfVisit.Text = visitor.DayOfVisit;
                txtVisitTime.Text = visitor.VisitTime;
                txtPaidTicket.Text = visitor.PaidTicket;

                btnSave.Text = "Update";
                groupBox1.Tag = visitor.VisitorID;
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
                    var visitor = db.Visitors.Find(item);
                    if (visitor != null)
                    {
                        db.Visitors.Remove(visitor);
                        db.SaveChanges();
                        GetVisitorsList();
                    }
                }
            }
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            int visitorID = 0;

            if (groupBox1.Tag != null)
            {
                visitorID = (int)groupBox1.Tag;
                UpdateVisitor(visitorID);
            }
            else
            {
                AddVisitor();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void btnStudent_Click(object sender, EventArgs e)
        {
            TicketForStudent student = new TicketForStudent();
            student.Show();
        }

        private void btnAdult_Click(object sender, EventArgs e)
        {
            TicketForAdult adult = new TicketForAdult();
            adult.Show();
        }

        private void btnChild_Click(object sender, EventArgs e)
        {
            TicketForChild child = new TicketForChild();
            child.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TicketForUnder7OrOver65 free = new TicketForUnder7OrOver65();
            free.Show();
        }
    }
}

