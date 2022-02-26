using System;
using System.Windows.Forms;

namespace ApartamentiIm.Views
{
    public partial class TeDhenat : UserControl
    {
        public TeDhenat()
        {
            InitializeComponent();
            // Add demo data
            dataGridView1.Rows.Add(new[]{
                "1",
                "Emri1",
                "Mbiemri1",
                "Kontakt1",
                DateTime.Now.ToString("D"),
                DateTime.Now.ToString("D"),
                "Qellimi1",
                "Kati1",
                "Antaret1",
            });
            dataGridView1.Rows.Add(new[]{
                "2",
                "Emri2",
                "Mbiemri2",
                "Kontakt2",
                DateTime.Now.ToString("D"),
                DateTime.Now.ToString("D"),
                "Qellimi2",
                "Kati2",
                "Antaret2",
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
            dataGridView1.SelectedRows[0].Cells["Id"].Value = textBox1.Text;
            dataGridView1.SelectedRows[0].Cells["Emri"].Value = textBox2.Text;
            dataGridView1.SelectedRows[0].Cells["Mbiemri"].Value = textBox3.Text;
            dataGridView1.SelectedRows[0].Cells["Kontakt"].Value = textBox9.Text;
            dataGridView1.SelectedRows[0].Cells["Hyrja"].Value = dateTimePicker1.Value.ToLongDateString();
            dataGridView1.SelectedRows[0].Cells["Dalja"].Value = dateTimePicker2.Value.ToLongDateString();
            dataGridView1.SelectedRows[0].Cells["Qellimi"].Value = textBox8.Text;
            dataGridView1.SelectedRows[0].Cells["Kati"].Value = textBox5.Text;
            dataGridView1.SelectedRows[0].Cells["Antaret"].Value = textBox6.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "" || textBox3.Text == "" ||  textBox6.Text == "" ||
                textBox8.Text == "" || textBox9.Text == "")
            {
                MessageBox.Show("Ju lutem plotesoni te gjitha fushat.");
                return;
            }
            // Shto
            dataGridView1.Rows.Add(new[]{
                (dataGridView1.Rows.Count + 1).ToString(),
                textBox2.Text,
                textBox3.Text,
                textBox9.Text,
                dateTimePicker1.Value.ToLongDateString(),
                dateTimePicker2.Value.ToLongDateString(),
                textBox8.Text,
                textBox5.Text,
                textBox6.Text,
            });
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
            dateTimePicker1.Value = DateTime.Now;
            dateTimePicker2.Value = DateTime.Now;
            textBox6.Text = "";
            textBox5.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            // Update textBoxes on selection change
            if (dataGridView1.Rows.Count == 0)
                return; // Nese nuk kemi rreshta skemi cfare te dhena te shfaqim ne textBoxes.
            textBox1.Text = dataGridView1.SelectedRows[0].Cells["Id"].Value.ToString();
            textBox2.Text = dataGridView1.SelectedRows[0].Cells["Emri"].Value.ToString();
            textBox3.Text = dataGridView1.SelectedRows[0].Cells["Mbiemri"].Value.ToString();
            textBox9.Text = dataGridView1.SelectedRows[0].Cells["Kontakt"].Value.ToString();
            dateTimePicker1.Value = DateTime.Parse(dataGridView1.SelectedRows[0].Cells["Hyrja"].Value.ToString());
            dateTimePicker2.Value = DateTime.Parse(dataGridView1.SelectedRows[0].Cells["Dalja"].Value.ToString());
            textBox8.Text = dataGridView1.SelectedRows[0].Cells["Qellimi"].Value.ToString();
            textBox5.Text = dataGridView1.SelectedRows[0].Cells["Kati"].Value.ToString();
            textBox6.Text = dataGridView1.SelectedRows[0].Cells["Antaret"].Value.ToString();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
