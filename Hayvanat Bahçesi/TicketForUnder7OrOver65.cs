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
    public partial class TicketForUnder7OrOver65 : Form
    {
        public TicketForUnder7OrOver65()
        {
            InitializeComponent();
        }

        private void TicketForUnder7OrOver65_Load(object sender, EventArgs e)
        {
            label3.Text = DateTime.Now.ToShortDateString();

            label6.Text = DateTime.Now.ToLongTimeString();
        }
    }
}
