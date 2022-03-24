using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace QuizApplicatie
{
    public partial class scores : Form
    {
        int antwoordId = 0;
        public scores()
        {
            InitializeComponent();
            RefreshAntwoordGrid();
        }
        private void RefreshAntwoordGrid()
        {
            AntwoordGrid.Rows.Clear();

            //string query = "SELECT antwoord.id, speler.naam, antwoord.vraagId, antwoord.tijd, antwoord.strafTijd, antwoord.IsGoedBeantwoord, antwoord.datum FROM antwoord INNER JOIN speler ON antwoord.userId = speler.id;";
            string query = "SELECT * FROM antwoord;";
            var Antwoorden = new List<AntwoordenClass>();

            using (MySqlConnection connection = new MySqlConnection())
            {
                connection.ConnectionString = "Data Source = localhost; Initial Catalog = quizapplicatie; User ID = root; Password = ";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    connection.Open();
                    MySqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            AntwoordenClass LeAntwoord = new AntwoordenClass();
                            LeAntwoord.id = (int)reader["id"];
                            LeAntwoord.userId = (int)reader["userId"];
                            LeAntwoord.tijd = (int)reader["tijd"];
                            LeAntwoord.strafTijd = (int)reader["strafTijd"];
                            LeAntwoord.datum = (DateTime)reader["datum"];

                            Antwoorden.Add(LeAntwoord);
                        }
                    }
                    reader.Close();
                }
            }
            for (int i = 1; i <= Antwoorden.Count; i++)
            {
                var Andwoord = Antwoorden[i - 1];

                if (Andwoord != null)
                {
                    AntwoordGrid.Rows.Add(Andwoord.id, Andwoord.userId, Andwoord.tijd + Andwoord.strafTijd, Andwoord.tijd, Andwoord.strafTijd, Andwoord.datum);
                }
            }
        }
        private void BackBtn_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void AntwoordGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            antwoordId = (int)AntwoordGrid.SelectedCells[0].Value;
        }
    }
}
