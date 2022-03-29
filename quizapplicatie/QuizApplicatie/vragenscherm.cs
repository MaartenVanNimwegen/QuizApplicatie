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
        int defaultQuestionIndividualTimer = 10;
        int QuestionIndividualTimer = 10;
        bool CorrectInput;
        string CorrectAnswer = "";
        string GivenInput = "";
        bool AcceptingInput = false;
        VraagClass currentquestion;
        int TijdVanBeantwoorden = 0;
        int defaultAftelNaarVolgende = 3;
        int AftelNaarVolgende = 3;
        int QuestionsCurrentListIndex = 0;
        List<VraagClass> Questions;

        bool IsCountingDown = false;


        int strafTijdFouteVraag = 10;


        // SETTINGS
        int QuestionAmount = 5;
        int TimerStart = 0;

        public VragenScherm()
        {
            Questions = GetQuestions(QuestionAmount);

            InitializeComponent();

            GlobalTimeLabel.Text = TimerStart.ToString() + "s";
            QuestionTimeLabel.Text = TimerStart.ToString() + "s";

            AftelNaarVolgende = defaultAftelNaarVolgende;
            QuestionIndividualTimer = defaultQuestionIndividualTimer;

            AskQuestion(Questions[QuestionsCurrentListIndex], QuestionsCurrentListIndex);
        }



        private void AskQuestion(VraagClass Question, int QIndex)
        {
            TijdVanBeantwoorden = 0;
            VraagLable.Text = Question.vraag;
            currentquestion = Question;

            QuestionIndividualTimer = defaultQuestionIndividualTimer;

            ResetColors();

            // Random selecteren van correct antwoord positie A of B
            Random rnd = new Random();
            int Dice = rnd.Next(1, 2);

            if (Dice == 1)
            {
                CorrectAnswer = "A";
                AnswerA.Text = Question.correctantwoord;
                AnswerB.Text = Question.incorrectantwoord;
            }
            else if (Dice == 2)
            {
                CorrectAnswer = "B";
                AnswerA.Text = Question.incorrectantwoord;
                AnswerB.Text = Question.correctantwoord;
            }

            Questions.RemoveAt(QIndex);

            QuestionsCurrentListIndex = GetRandomQuestionListId();

            QuestionIndividualTimer = defaultQuestionIndividualTimer;
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

        private int GetRandomQuestionListId()
        {
            Random rnd = new Random();
            int Rid = rnd.Next(0, Questions.Count - 1);
            
            return Rid;
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
        /// <summary>
        /// Terug naar het hoofdmenu met checkup
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        private void ResetColors()
        {
            AnswerA.BackColor = Color.FromArgb(41, 76, 146);
            ALetter.BackColor = Color.FromArgb(41, 76, 146);

            AnswerB.BackColor = Color.FromArgb(41, 76, 146);
            BLetter.BackColor = Color.FromArgb(41, 76, 146);

            AnswerA.ForeColor = Color.White;
            AnswerB.ForeColor = Color.White;

            ALetter.ForeColor = Color.White;
            BLetter.ForeColor = Color.White;
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
                // De speler heeft niks beantwoord binnen de tijd

                AcceptingInput = false;
                TimerPlaying = false;
                CorrectInput = false;
                HasGivenInput = true;

                if (CorrectAnswer == "A")
                {
                    AnswerA.BackColor = Color.FromArgb(61, 196, 45);
                    ALetter.BackColor = Color.FromArgb(61, 196, 45);

                    AnswerB.BackColor = Color.FromArgb(242, 57, 24);
                    BLetter.BackColor = Color.FromArgb(242, 57, 24);
                }
                else
                {
                    AnswerA.BackColor = Color.FromArgb(242, 57, 24);
                    ALetter.BackColor = Color.FromArgb(242, 57, 24);

                    AnswerB.BackColor = Color.FromArgb(61, 196, 45);
                    BLetter.BackColor = Color.FromArgb(61, 196, 45);
                }

                antwoord = false;
                AntwoordOpslaan(id, vraagId, antwoord, defaultQuestionIndividualTimer, strafTijdFouteVraag);
            }
        }

        // Score opslaan vars
        public static string naam = NaamInvullen.naam;
        public static int id = 0;
        public static int vraagId = 0;
        public static bool antwoord = true;
        public static int strafTijd = 0;
        public static int tijd = 0;
        /// <summary>
        /// Bij keypress wordt de naam opgehaald hier word het antwoord geregistreerd en met de juiste score opgeslagen.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
            int BeantwoordTijd = TijdVanBeantwoorden;

            if (AcceptingInput)
            {
                //int questionTime = 
                if (e.KeyCode == Keys.A || e.KeyCode == Keys.B)
                {
                    AcceptingInput = false;
                    HasGivenInput = true;
                    TimerPlaying = false;

                    if (CorrectAnswer == "A")
                    {
                        AnswerA.BackColor = Color.FromArgb(61, 196, 45);
                        ALetter.BackColor = Color.FromArgb(61, 196, 45);

                        AnswerB.BackColor = Color.FromArgb(242, 57, 24);
                        BLetter.BackColor = Color.FromArgb(242, 57, 24);
                    }
                    else
                    {
                        AnswerA.BackColor = Color.FromArgb(242, 57, 24);
                        ALetter.BackColor = Color.FromArgb(242, 57, 24);

                        AnswerB.BackColor = Color.FromArgb(61, 196, 45);
                        BLetter.BackColor = Color.FromArgb(61, 196, 45);
                    }
                    AcceptingInput = false;
                }


                if (e.KeyCode == Keys.A)
                {
                    HasGivenInput = true;
                    GivenInput = "A";

                    AnswerA.ForeColor = Color.Yellow;
                    ALetter.ForeColor = Color.Yellow;

                    if (CorrectAnswer == "A")
                    {
                        CorrectInput = true;
                        AftelNaarVolgende = defaultAftelNaarVolgende;
                        IsCountingDown = true;
                        antwoord = true;
                        AntwoordOpslaan(id, vraagId, antwoord, BeantwoordTijd, 0);
                    }
                    else
                    {
                        CorrectInput = false;
                        AftelNaarVolgende = defaultAftelNaarVolgende;
                        IsCountingDown = true;
                        antwoord = false;
                        AntwoordOpslaan(id, vraagId, antwoord, BeantwoordTijd, strafTijdFouteVraag);

                    }
                }
                else if (e.KeyCode == Keys.B)
                {
                    HasGivenInput = true;
                    GivenInput = "B";

                    AnswerB.ForeColor = Color.Yellow;

                    if (CorrectAnswer == "B")
                    {
                        CorrectInput = true;
                        AftelNaarVolgende = defaultAftelNaarVolgende;
                        IsCountingDown = true;
                        antwoord = true;
                        AntwoordOpslaan(id, vraagId, antwoord, BeantwoordTijd, 0);
                    }
                    else
                    {
                        CorrectInput = false;
                        AftelNaarVolgende = defaultAftelNaarVolgende;
                        IsCountingDown = true;
                        antwoord = false;
                        AntwoordOpslaan(id, vraagId, antwoord, BeantwoordTijd, strafTijdFouteVraag);
                    }
                }
            }
        }
        /// <summary>
        /// Deze functie slaat de behaalde score op met de gegeven parameters
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="vraagId"></param>
        /// <param name="antwoord"></param>
        /// <param name="tijd"></param>
        /// <param name="strafTijd"></param>
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
        /// <summary>
        /// Timer die per vraag bijhoud hoelang je erover gedaan hebt.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TijdVanAntwoorden_Tick(object sender, EventArgs e)
        {
            if(AcceptingInput == true)
            {
                TijdVanBeantwoorden ++;
            }
        }

        private void AftelTimerVolgendeVraag_Tick(object sender, EventArgs e)
        {
            if (HasGivenInput == true && IsCountingDown == true)
            {
                if (AftelNaarVolgende > 0)
                {
                    AftelNaarVolgende--;
                    //BLetter.Text = AftelNaarVolgende.ToString();
                }

                if (AftelNaarVolgende == 0)
                {
                    IsCountingDown = false;
                    //ALetter.Text = "L";

                    if (Questions.Count > 0)
                    {
                        AskQuestion(Questions[QuestionsCurrentListIndex], QuestionsCurrentListIndex);
                    } else
                    {
                        // RESULTATEN SCHERM
                    }
                }
            }
        }
        
        private void ResultatenschermOpenen(int userId, )
        {
            string query = "SELECT andwoord.userId, SUM(andwoord.tijd) AS Tijd, SUM(andwoord.strafTijd) AS StrafTijd,SUM(andwoord.tijd+andwoord.strafTijd) AS TotaalScore FROM andwoord INNER JOIN speler ON andwoord.userId = speler.id GROUP BY andwoord.userId, speler.naam";

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
    }
}
