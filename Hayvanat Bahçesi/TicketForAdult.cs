using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hayvanat_Bahçesi
{
    public partial class TicketForAdult : Form
    {
        public TicketForAdult()
        {
            InitializeComponent();
        }

        private void TicketSales_Load(object sender, EventArgs e)
        {
            label3.Text = DateTime.Now.ToShortDateString();

            label6.Text = DateTime.Now.ToLongTimeString();

        }
    }
}
