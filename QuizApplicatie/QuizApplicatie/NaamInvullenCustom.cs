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
    public partial class NaamInvullenCustom : Form
    {
        string naam = "";
        int QuizIsCustom = 1;


        public NaamInvullenCustom()
        {
            InitializeComponent();
        }

        private void StartQuizCustom_Click(object sender, EventArgs e)
        {
            if (NaamVeldCustom.Text.Length > 0)
            {
                naam = NaamVeldCustom.Text;

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

                CustomQuiz myForm = new CustomQuiz();
                myForm.ShowDialog();
            }
            else if (NaamVeldCustom.Text.Length == 0)
            {
                MessageBox.Show("Vul uw naam in!");
            }
        }
    }
}
