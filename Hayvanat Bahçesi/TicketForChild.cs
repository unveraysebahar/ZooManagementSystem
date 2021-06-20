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
    public partial class TicketForChild : Form
    {
        public TicketForChild()
        {
            InitializeComponent();
        }

        private void DiscountedTicket_Load(object sender, EventArgs e)
        {
            label3.Text = DateTime.Now.ToShortDateString();

            label6.Text = DateTime.Now.ToLongTimeString();
        }
    }
}
