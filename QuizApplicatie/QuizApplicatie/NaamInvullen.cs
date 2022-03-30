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
    public partial class NaamInvullen : Form
    {
        public static string naam = "";
        int QuizIsCustom = 0;


        public NaamInvullen()
        {
            InitializeComponent();
        }

        private void StartQuiz_Click(object sender, EventArgs e)
        {
            if (NaamVeld.Text.Length > 0)
            {
                naam = NaamVeld.Text;

                string query = "INSERT INTO speler (naam, QuizIsCustom) VALUES ('" + naam + "', '" + QuizIsCustom + "')";

                using (MySqlConnection connection = new MySqlConnection())
                {
                    connection.ConnectionString = "Data Source = localhost; Initial Catalog = quizapplicatie; User ID = root; Password = ";
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        connection.Open();
                        MySqlDataReader reader = command.ExecuteReader();
                        connection.Close();
                        Close();
                    }
                }

                VragenScherm myForm = new VragenScherm(false, 10, 10, 10, naam);
                myForm.ShowDialog();
            }
            else if (NaamVeld.Text.Length == 0)
            {
                MessageBox.Show("Vul uw naam in!");
            }
        }
    }
}
