using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form2 : Form
    {
        private SqliteConnection sqlite_conn;
        private SqliteCommand sqlite_cmd;
        public Form2()
        {
            InitializeComponent();
            InitializeDatabase();
        }
        private void InitializeDatabase()
        {
            sqlite_conn = new SqliteConnection("Data Source=w65690.db");
            sqlite_conn.Open();
            sqlite_cmd = sqlite_conn.CreateCommand();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void dodaj_Click(object sender, EventArgs e)
        {
            string autor = textBox2.Text;
            string tytul = textBox1.Text;
            string rok = textBox3.Text;
            string gatunek = textBox4.Text;
            sqlite_cmd.CommandText = $"INSERT INTO ksiazki (autor, tytul, rok, gatunek) VALUES ('{autor}', '{tytul}','{rok}','{gatunek}');";
            sqlite_cmd.ExecuteNonQuery();
            MessageBox.Show("Dodano ksiazke");
            textBox2.Clear();
            textBox1.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }
    }
}
