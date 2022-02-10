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
    public partial class Members : Form
    {
        public Members()
        {
            InitializeComponent();
            Apply(TeDhenat);
        }
        private void Members_FormClosing(object sender, FormClosingEventArgs e) => Environment.Exit(0);
        TeDhenat TeDhenat = new TeDhenat();
        KatiBanues KatiBanues = new KatiBanues();
        Pagesa Pagesa = new Pagesa();
        Sherbimet Sherbimet = new Sherbimet();
        public Rregullimet Rregullimet = new Rregullimet();


        #region Menu
        void Apply(UserControl control)
        {
            if (!panel3.Controls.Contains(control))
            {
                control.Dock = DockStyle.Fill;
                panel3.Controls.Clear();
                panel3.Controls.Add(control);
                panel3.Refresh();
            }
        }

        private void tedhenatbtn_Click(object sender, EventArgs e) => Apply(TeDhenat);

        private void floorbtn_Click(object sender, EventArgs e) => Apply(KatiBanues);

        private void pagesabtn_Click(object sender, EventArgs e) => Apply(Pagesa);

        private void servicesbtn_Click(object sender, EventArgs e) => Apply(Sherbimet);

        private void button4_Click(object sender, EventArgs e) => Apply(Rregullimet);
        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            Kyqu kyqu = new Kyqu();
            Hide();
            kyqu.ShowDialog();
            Close();
        }
    }
}
