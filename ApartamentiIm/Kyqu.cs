using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApartamentiIm
{
    public partial class Kyqu : Form
    {
        public Kyqu()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void mbyllebtn_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void kyqubtn_Click(object sender, EventArgs e)
        {
            // Check info

            Members members = new Members();
            Hide();
            members.ShowDialog();
        }
    }
}
