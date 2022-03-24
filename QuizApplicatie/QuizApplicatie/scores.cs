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
        int userId = 0;

        public scores()
        {
            InitializeComponent();
            RefreshAntwoordGrid();
        }
        private void RefreshAntwoordGrid()
        {
            AntwoordGrid.Rows.Clear();

            string query = "SELECT * FROM antwoord";
            string query2 = "SELECT naam FROM speler WHERE 'id' = '" + userId + "'";
            string query3 = "SELECT * FROM vragen";

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
                            userId = reader.GetInt32(1);
                            using (MySqlCommand command2 = new MySqlCommand(query2, connection))
                            {
                                reader.Close();
                                MySqlDataReader reader2 = command2.ExecuteReader();
                            }

                        }
                    }
                    reader.Close();
                }
            }
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
                            LeAntwoord.id = reader.GetInt32(0);
                            LeAntwoord.userId = reader.GetInt32(1);
                            LeAntwoord.vraagId= reader.GetInt32(2);
                            LeAntwoord.tijd = reader.GetInt32(3);
                            LeAntwoord.strafTijd= reader.GetInt32(4);
                            LeAntwoord.IsGoedBeantwoord = reader.GetInt32(5);

                            Antwoorden.Add(LeAntwoord);
                        }
                    }
                    reader.Close();
                }
            }

            for (int i = 1; i <= Antwoorden.Count; i++)
            {
                var Antwoord = Antwoorden[i - 1];

                if (Antwoord != null)
                {
                    AntwoordGrid.Rows.Add(Antwoord.id, Antwoord.userId, Antwoord.vraagId, Antwoord.tijd, Antwoord.strafTijd, Antwoord.IsGoedBeantwoord, Antwoord.datum);
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
