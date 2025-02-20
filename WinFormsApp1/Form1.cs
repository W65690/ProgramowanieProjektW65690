using Microsoft.Data.Sqlite;
using System.Diagnostics.Eventing.Reader;
using System.Xml.Linq;
namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private SqliteConnection sqlite_conn;
        private SqliteCommand sqlite_cmd;
        public Form1()
        {
            InitializeComponent();
            InitializeDatabase();
        }
        private void InitializeDatabase()
        {
            sqlite_conn = new SqliteConnection("Data Source=w65690.db");
            sqlite_conn.Open();
            sqlite_cmd = sqlite_conn.CreateCommand();
            using (sqlite_conn)
            {
                sqlite_cmd.CommandText = "CREATE TABLE IF NOT EXISTS ksiazki (id INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT, tytul TEXT, autor TEXT, rok TEXT, gatunek TEXT);";
                sqlite_cmd.ExecuteNonQuery();
            }
        }
        private void dodawanie_Click(object sender, EventArgs e)
        {
            Form2 dodawanieForm = new Form2();
            dodawanieForm.Show();
        }
        private void szukaj_Click(object sender, EventArgs e)
        {
            string autor = text1.Text.Trim();
            string tytul = text2.Text.Trim();

            if (string.IsNullOrEmpty(autor) && string.IsNullOrEmpty(tytul))
            {
                lista1.Items.Add("Proszê wpisaæ autora lub tytu³.");
                return;
            }
            lista1.Items.Clear();
            sqlite_cmd.Parameters.Clear();

            if (!string.IsNullOrEmpty(autor))
            {
                sqlite_cmd.CommandText = "SELECT * FROM ksiazki WHERE autor COLLATE NOCASE = @autor;";
                sqlite_cmd.Parameters.AddWithValue("@autor", autor);
            }
            else
            {
                sqlite_cmd.CommandText = "SELECT * FROM ksiazki WHERE tytul COLLATE NOCASE = @tytul;";
                sqlite_cmd.Parameters.AddWithValue("@tytul", tytul);
            }
            using (SqliteDataReader reader = sqlite_cmd.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        lista1.Items.Add($"{reader["autor"]}: {reader["tytul"]} rok wydania: {reader["rok"]} gatunek: ${reader["gatunek"]} ");
                    }
                }
                else
                {
                    lista1.Items.Add("Nie znaleziono ksi¹¿ki.");
                }
            }
            text1.Clear();
            text2.Clear();
        }
    }

}
