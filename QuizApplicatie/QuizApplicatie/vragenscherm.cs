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
    public partial class VragenScherm : Form
    {
        List<VraagClass> Vragen = new List<VraagClass>();
        bool HasGivenInput = false;
        bool TimerPlaying = false;
        int GlobalTimer = 0;
        int QuestionIndividualTimer = 0;
        bool CorrectInput;
        string CorrectAnswer = "";
        bool AcceptingInput = false;
        VraagClass currentquestion;
        int TijdVanBeantwoorden = 0;

        int strafTijdFouteVraag = 10;


        // SETTINGS
        int QuestionAmount = 5;
        int TimerStart = 0;

        public VragenScherm()
        {
            List<VraagClass> Questions = GetQuestions(QuestionAmount);

            InitializeComponent();

            GlobalTimeLabel.Text = TimerStart.ToString() + "s";
            QuestionTimeLabel.Text = TimerStart.ToString() + "s";

            for (int i = 0; i <= QuestionAmount - 1; i++)
            {
                AskQuestion(Questions[i]);
            }
        }



        private void AskQuestion(VraagClass Question)
        {
            TijdVanBeantwoorden = 0;
            VraagLable.Text = Question.vraag;
            currentquestion = Question;

            // Random selecteren van correct antwoord positie A of B
            Random rnd = new Random();
            int Dice = rnd.Next(1, 2);

            if (Dice == 1)
            {
                AnswerA.Text = Question.correctantwoord;
                AnswerB.Text = Question.incorrectantwoord;
            }
            else if (Dice == 2)
            {
                AnswerA.Text = Question.incorrectantwoord;
                AnswerB.Text = Question.correctantwoord;
            }

            QuestionIndividualTimer = 90;
            TimerPlaying = true;
            AcceptingInput = true;
        }

        private List<VraagClass> GetQuestions(int Amount)
        {
            string query = "SELECT * FROM vragen";

            var Vragen = new List<VraagClass>();


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
                            VraagClass LeVraag = new VraagClass();
                            LeVraag.id = reader.GetInt32(0);
                            LeVraag.vraag = reader.GetString(1);
                            LeVraag.correctantwoord = reader.GetString(2);
                            LeVraag.incorrectantwoord = reader.GetString(3);

                            Vragen.Add(LeVraag);
                        }
                    }
                    reader.Close();
                }
            }

            // unieke ids van de vragen.
            List<int> Qids = NewNumber(Amount, 1, Vragen.Count);

            // de vragen die bij de ids (zie hierboven) horen.
            List<VraagClass> SortedQuestions = Vragen.Where(vraag => Qids.Contains(vraag.id)).ToList();

            return SortedQuestions;
        }

        private List<int> NewNumber(int Amount, int Start, int End)
        {

            int MyNumber = 0;
            Random Number = new Random();
            List<int> randomList = new List<int>();

            while (randomList.Count < Amount)
            {
                MyNumber = Number.Next(Start, End);
                if (!randomList.Contains(MyNumber))
                {
                    randomList.Add(MyNumber);
                }
            }

            return randomList;
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            string message = "Weet je zeker dat je de quiz wilt beëindigen? Je scores zullen verloren raken.";
            string caption = "Quiz beëindigen";
            var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Close();
            }

        }

        private void GlobalTimer_Tick(object sender, EventArgs e)
        {
            if (TimerPlaying == true)
            {
                GlobalTimer++;
                GlobalTimeLabel.Text = GlobalTimer.ToString() + "s";
            }

            if (TimerPlaying == true && QuestionIndividualTimer > 0)
            {
                QuestionIndividualTimer--;
                QuestionTimeLabel.Text = QuestionIndividualTimer.ToString() + "s";
            }
            else if (QuestionIndividualTimer <= 0)
            {
                AcceptingInput = false;
                TimerPlaying = false;
                CorrectInput = false;

                // Wrong answer procedure
            }
        }

        // Score opslaan vars
        public static string naam = NaamInvullen.naam;
        public static int id = 0;
        public static int vraagId = 0;
        public static bool antwoord = true;
        public static int strafTijd = 0;
        public static int tijd = 0;

        public void VragenScherm_KeyDown(object sender, KeyEventArgs e)
        {
            //
            string query = "SELECT id FROM speler WHERE naam = '" + naam + "'";

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
                            id = (int)reader["id"];
                        }
                    }
                    reader.Close();

                }
            }
            // Score opslaan vars
            int vraagId = currentquestion.id;
            bool antwoord = true;
            int tijd = 0;
            int strafTijd = 0;
            int BeantwoordTijd = TijdVanBeantwoorden;

            if (AcceptingInput)
            {
                //int questionTime = 
                if (e.KeyCode == Keys.A || e.KeyCode == Keys.B)
                {
                    if (CorrectAnswer == "A")
                    {
                        AnswerA.BackColor = Color.Green;
                        AnswerB.BackColor = Color.Red;
                    }
                    else
                    {
                        AnswerA.BackColor = Color.Red;
                        AnswerB.BackColor = Color.Green;
                    }
                    AcceptingInput = false;
                }


                if (e.KeyCode == Keys.A)
                {
                    HasGivenInput = true;
                    AnswerA.ForeColor = Color.Yellow;

                    if (CorrectAnswer == "A")
                    {
                        CorrectInput = true;
                        antwoord = true;
                        AntwoordOpslaan(id, vraagId, antwoord, BeantwoordTijd, 0);
                    }
                    else
                    {
                        CorrectInput = false;
                        antwoord = false;
                        AntwoordOpslaan(id, vraagId, antwoord, BeantwoordTijd, strafTijdFouteVraag);

                    }
                }
                else if (e.KeyCode == Keys.B)
                {
                    HasGivenInput = true;
                    AnswerB.ForeColor = Color.Yellow;

                    if (CorrectAnswer == "B")
                    {
                        CorrectInput = true;
                        antwoord = true;
                        AntwoordOpslaan(id, vraagId, antwoord, BeantwoordTijd, 0);
                    }
                    else
                    {
                        CorrectInput = false;
                        antwoord = false;
                        AntwoordOpslaan(id, vraagId, antwoord, BeantwoordTijd, strafTijdFouteVraag);
                    }
                }

            }
        }
        private void AntwoordOpslaan(int userId, int vraagId, bool antwoord, int tijd, int strafTijd)
        {
            int AntwoordOpVraag = 0;
            if (antwoord == true)
            {
                AntwoordOpVraag = 1;
            }
            else
            {
                AntwoordOpVraag = 0;
            }

            string query = "INSERT INTO andwoord (userId, vraagId, tijd, strafTijd, IsGoedBeandwoord, datum) VALUES ('" + userId + "', '" + vraagId + "', '" + tijd + "', '" + strafTijd + "', '" + AntwoordOpVraag + "', now())";


            using (MySqlConnection connection = new MySqlConnection())
            {
                connection.ConnectionString = "Data Source = localhost; Initial Catalog = quizapplicatie; User ID = root; Password = ";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    connection.Open();
                    MySqlDataReader reader = command.ExecuteReader();
                    connection.Close();
                }
            }
        }

        private void TijdVanAntwoorden_Tick(object sender, EventArgs e)
        {
            if(AcceptingInput == true)
            {
                TijdVanBeantwoorden ++;
            }
        }
    }
}