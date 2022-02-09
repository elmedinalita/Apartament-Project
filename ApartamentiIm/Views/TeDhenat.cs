using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApartamentiIm.Views
{
    public partial class TeDhenat : UserControl
    {
        public TeDhenat()
        {
            InitializeComponent();
            dataGridView1.Columns.Clear();
            dataGridView1.DataSource = Users;
            Users.Add(new User {
                Id = 1,
                Emri = "usdw",
                Mbiemri = "usdw",
                Hyrja = "usdw",
                Dalja = "usdw",
                Antaret = "usdw",
                Kati = "usdw",
                Qellimi = "usdw",
                Kontakt = "usdw",
            });
            Users.Add(new User
            {
                Id = 2,
                Emri = "awewe",
                Mbiemri = "awewe",
                Hyrja = "awewe",
                Dalja = "awewe",
                Antaret = "awewe",
                Kati = "usdw",
                Qellimi = "awewe",
                Kontakt = "usdw",
            });
        }

        BindingList<User> Users = new BindingList<User>();
        private void TeDhenat_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string selected = dataGridView1.SelectedRows[0].Cells["Id"].Value.ToString();
            var user = Users.Where(u => u.Id.ToString() == selected).FirstOrDefault();
            user.Id = int.Parse(textBox1.Text);
            user.Emri = textBox2.Text;
            user.Mbiemri = textBox3.Text;
            user.Hyrja = textBox4.Text;
            user.Dalja = textBox5.Text;
            user.Antaret = textBox6.Text;
            user.Kati = textBox7.Text;
            user.Qellimi = textBox8.Text;
            user.Kontakt = textBox9.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Add
            Users.Add(new User {
                Id = Users.Count + 1,
                Emri = textBox2.Text,
                Mbiemri = textBox3.Text,
                Hyrja = textBox4.Text,
                Dalja = textBox5.Text,
                Antaret = textBox6.Text,
                Kati = textBox7.Text,
                Qellimi = textBox8.Text,
                Kontakt = textBox9.Text
            });
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string selected = dataGridView1.SelectedRows[0].Cells["Id"].Value.ToString();
            var user = Users.Where(u => u.Id.ToString() == selected).FirstOrDefault();
            Users.Remove(user);
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                string selected = dataGridView1.SelectedRows[0].Cells["Id"].Value.ToString();
                var user = Users.Where(u => u.Id.ToString() == selected).FirstOrDefault();

                textBox1.Text = user.Id.ToString();
                textBox2.Text = user.Emri;
                textBox3.Text = user.Mbiemri;
                textBox4.Text = user.Hyrja;
                textBox5.Text = user.Dalja;
                textBox6.Text = user.Antaret;
                textBox7.Text = user.Kati;
                textBox8.Text = user.Qellimi;
                textBox9.Text = user.Kontakt;
            }
            catch { }
        }
    }
}
