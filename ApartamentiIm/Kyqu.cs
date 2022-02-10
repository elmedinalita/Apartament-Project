using ApartamentiIm.Views;
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
            var user = perdoruesibox.Text;
            var pass = fjalekaimbox.Text;
            if (!user.Contains("@") && !user.Contains(".com"))
            {
                MessageBox.Show("Perdoruesi nuk eshte i plote");
                return;
            }
            if (pass.Length < 8)
            {
                MessageBox.Show("Passwordi duhet te permbaje te pakten 8 karaktere");
                return;
            }
            // temp
            //var usr = Program.Members.Rregullimet.Users.Where(u => u.Emri == user && u.Fjalkalimi == pass).FirstOrDefault();
            foreach (var usr in Program.Users)
            {
                if (usr.Emri == user && usr.Fjalkalimi == pass)
                {
                    Hide();
                    Members members = new Members();
                    members.ShowDialog();
                    Close();
                    return;
                }
            }

            MessageBox.Show("Te dhenat e pasakta");
        }
    }
}
