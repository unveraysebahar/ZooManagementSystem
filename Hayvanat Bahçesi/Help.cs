using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hayvanat_Bahçesi
{
    public partial class Help : Form
    {
        public Help()
        {
            InitializeComponent();
        }

        private void Help_Load(object sender, EventArgs e)
        {
            StreamReader streamReader = File.OpenText(@"C:\Users\User\Desktop\Help.txt");
            string file;
            while((file=streamReader.ReadLine())!=null)
            {
                listBox1.Items.Add(file);
            }
            streamReader.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }
    }
}
