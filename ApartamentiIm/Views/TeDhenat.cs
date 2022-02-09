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
        }

        private void TeDhenat_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        string strCon = @"Driver={Microsoft Access Driver (*.mdb, *.accdb)};Dbq=" + 
            Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data.accdb") + ";";
        void LoadData()
        {
            // Load DB
            dataGridView1.Columns.Clear();
            string strSql = "select * from TeDhenat";

            using (OdbcConnection con = new OdbcConnection(strCon))
            using (OdbcDataAdapter dadapter = new OdbcDataAdapter(strSql, con))
            {
                DataTable table = new DataTable();
                dadapter.Fill(table);

                dataGridView1.DataSource = table;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string query = $"UPDATE TeDhenat SET Emri = '{textBox2.Text}' Mbiemri='{textBox3.Text}' Hyrja='{textBox4.Text}' Dalja='{textBox5.Text}' Antaret='{textBox6.Text}' Kati='{textBox7.Text}' Qellimi='{textBox8.Text}' Kontakt='{textBox9.Text}' WHERE ID = '{textBox1.Text}'";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = $"INSERT INTO TeDhenat (Emri, Mbiemri, Hyrja, Dalja, Antaret, Kati, Qellimi, Kontakt) VALUES ('{textBox2.Text}', '{textBox3.Text}', '{textBox4.Text}', '{textBox5.Text}', '{textBox6.Text}', '{textBox7.Text}', '{textBox8.Text}', '{textBox9.Text}'";
            using (var con = new OleDbConnection(strCon))
            using (var command = new OleDbCommand(query, con))
            {
                var reader = command.ExecuteReader();
                while (reader.Read())
                {

                }
                con.Open();
                con.Close();
            }
            LoadData();
        }
    }
}
