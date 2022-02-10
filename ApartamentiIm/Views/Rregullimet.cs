using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApartamentiIm.Views
{
    public partial class Rregullimet : UserControl
    {
        public Rregullimet()
        {
            InitializeComponent();
            dataGridView1.Columns.Clear();
            dataGridView1.DataSource = Program.Users;
            dataGridView1.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Ruaj
            Program.Users.Add(new Perdorues
            {
                Emri = textBox2.Text,
                Fjalkalimi = textBox3.Text
            });
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Ndrysho
            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("Ju lutem shtoni te dhena!");
                return; // Nese nuk kemi rreshta nuk kemi cfare te ndryshojme
            }
            dataGridView1.SelectedRows[0].Cells["Emri"].Value = textBox2.Text;
            dataGridView1.SelectedRows[0].Cells["Fjalkalimi"].Value = textBox3.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Fshi
            dataGridView1.Rows.Remove(dataGridView1.SelectedRows[0]);

            // Nese nuk kemi me rreshta pastrojme textBoxes
            if (dataGridView1.Rows.Count > 0)
                return;
            // Reset textboxes
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                // Update textBoxes on selection change
                textBox2.Text = dataGridView1.SelectedRows[0].Cells["Emri"].Value.ToString();
                textBox3.Text = dataGridView1.SelectedRows[0].Cells["Fjalkalimi"].Value.ToString();
            }
            catch { }
        }
    }
}
