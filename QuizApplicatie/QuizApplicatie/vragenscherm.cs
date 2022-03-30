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

        // vars voor passtrough
        private int userId;
        public int IsGoedBeantwoord;
        public int AantalFouteVragen;
        public int StrafTijd = 0;
        public int Tijd = 0;

        public string naam = NaamInvullen.naam;
        public int id = 0;
        public int vraagId = 0;
        public bool antwoord = true;

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

        bool IsQuizCustom;
        int AantalVragenCustom;
        int secondenpervraag;
        int aantalstrafseconde;
        int aantathuidigestrafseconde;
        int aantatstrafseconde;

        bool IsCountingDown = false;

        Color IncorrectColor = Color.FromArgb(216, 34, 10);
        Color CorrectColor = Color.FromArgb(54, 183, 47);
        Color SelectedColor = Color.FromArgb(234, 228, 171);
        Color DefaultColor = Color.FromArgb(41, 76, 146);


        int strafTijdFouteVraag = 10;


        // SETTINGS
        int QuestionAmount = 20;
        int TimerStart = 0;

        public VragenScherm(bool QuizIsCustom, int tijdPerVraag, int strafseconde, int aantalvragen, string Naam)
        {
            IsQuizCustom = QuizIsCustom;
            AantalVragenCustom = aantalvragen;
            secondenpervraag = tijdPerVraag;
            aantalstrafseconde = strafseconde;
            naam = Naam;

            CheckIfQuizIsCustom();

            Questions = GetQuestions(QuestionAmount);

            InitializeComponent();

            GlobalTimeLabel.Text = TimerStart.ToString() + "s";
            QuestionTimeLabel.Text = TimerStart.ToString() + "s";
            

            AftelNaarVolgende = defaultAftelNaarVolgende;
            QuestionIndividualTimer = defaultQuestionIndividualTimer;

            AskQuestion(Questions[QuestionsCurrentListIndex], QuestionsCurrentListIndex);
        }

        private void CheckIfQuizIsCustom()
        {
            if(IsQuizCustom == true)
            {
                QuestionAmount = AantalVragenCustom;
                defaultQuestionIndividualTimer = secondenpervraag;
                strafTijdFouteVraag = aantalstrafseconde;
            }
        }

        private void AskQuestion(VraagClass Question, int QIndex)
        {
            TijdVanBeantwoorden = 0;
            VraagLable.Text = Question.vraag;
            currentquestion = Question;

            QuestionIndividualTimer = defaultQuestionIndividualTimer;

            ResetColors();

            // Random selecteren van correct antwoord positie A of B
            var random = new Random();
            var randomBool = random.Next(2) == 1;

            if (randomBool == true)
            {
                CorrectAnswer = "A";
                AnswerA.Text = Question.correctantwoord;
                AnswerB.Text = Question.incorrectantwoord;
            }
            else
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
                connection.ConnectionString = DatabaseSettings.Connectionstring;
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
            int Rid = 0;

            if (Questions.Count > 0)
            {
                Random rnd = new Random();
                Rid = rnd.Next(0, Questions.Count - 1);
            }

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
            AnswerA.BackColor = DefaultColor;
            ALetter.BackColor = DefaultColor;

            AnswerB.BackColor = DefaultColor;
            BLetter.BackColor = DefaultColor;

            AnswerA.ForeColor = Color.White;
            AnswerB.ForeColor = Color.White;

            ALetter.ForeColor = Color.White;
            BLetter.ForeColor = Color.White;

            SelectedA.BackColor = DefaultColor;
            SelectedB.BackColor = DefaultColor;
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
            else if (QuestionIndividualTimer <= 0 && AcceptingInput == true)
            {
                // De speler heeft niks beantwoord binnen de tijd

                AcceptingInput = false;
                HasGivenInput = true;
                TimerPlaying = false;

                string query = "SELECT id FROM speler WHERE naam = '" + naam + "'";

                using (MySqlConnection connection = new MySqlConnection())
                {
                    connection.ConnectionString = DatabaseSettings.Connectionstring;
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

                if (CorrectAnswer == "A")
                {
                    AnswerA.BackColor = CorrectColor;
                    ALetter.BackColor = CorrectColor;
                    SelectedA.BackColor = CorrectColor;

                    AnswerB.BackColor = IncorrectColor;
                    BLetter.BackColor = IncorrectColor;
                    SelectedB.BackColor = IncorrectColor;
                }
                else
                {
                    AnswerA.BackColor = IncorrectColor;
                    ALetter.BackColor = IncorrectColor;
                    SelectedA.BackColor = IncorrectColor;

                    AnswerB.BackColor = CorrectColor;
                    BLetter.BackColor = CorrectColor;
                    SelectedB.BackColor = CorrectColor;
                }

                CorrectInput = false;
                AftelNaarVolgende = defaultAftelNaarVolgende;
                IsCountingDown = true;
                strafsecondeberekenen();
                AntwoordOpslaan(id, vraagId, false, defaultQuestionIndividualTimer, strafTijdFouteVraag);
            }
        }
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
                connection.ConnectionString = DatabaseSettings.Connectionstring;
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
                        AnswerA.BackColor = CorrectColor;
                        ALetter.BackColor = CorrectColor;

                        AnswerB.BackColor = IncorrectColor;
                        BLetter.BackColor = IncorrectColor;
                    }
                    else
                    {
                        AnswerA.BackColor = IncorrectColor;
                        ALetter.BackColor = IncorrectColor;

                        AnswerB.BackColor = CorrectColor;
                        BLetter.BackColor = CorrectColor;
                    }
                }


                if (e.KeyCode == Keys.A)
                {
                    GivenInput = "A";

                    AnswerA.ForeColor = SelectedColor;
                    ALetter.ForeColor = SelectedColor;
                    SelectedA.BackColor = SelectedColor;

                    if (CorrectAnswer == "A")
                    {
                        SelectedB.BackColor = IncorrectColor;

                        CorrectInput = true;
                        AftelNaarVolgende = defaultAftelNaarVolgende;
                        IsCountingDown = true;
                        antwoord = true;
                        AntwoordOpslaan(id, vraagId, antwoord, BeantwoordTijd, 0);
                    }
                    else
                    {
                        SelectedB.BackColor = CorrectColor;

                        CorrectInput = false;
                        AftelNaarVolgende = defaultAftelNaarVolgende;
                        IsCountingDown = true;
                        antwoord = false;
                        AntwoordOpslaan(id, vraagId, antwoord, BeantwoordTijd, strafTijdFouteVraag);
                        strafsecondeberekenen();
                    }
                }
                else if (e.KeyCode == Keys.B)
                {
                    HasGivenInput = true;
                    GivenInput = "B";

                    AnswerB.ForeColor = SelectedColor;
                    BLetter.ForeColor = SelectedColor;
                    SelectedB.BackColor = SelectedColor;

                    if (CorrectAnswer == "B")
                    {
                        SelectedA.BackColor = IncorrectColor;
                        CorrectInput = true;
                        AftelNaarVolgende = defaultAftelNaarVolgende;
                        IsCountingDown = true;
                        antwoord = true;
                        AntwoordOpslaan(id, vraagId, antwoord, BeantwoordTijd, 0);
                    }
                    else
                    {
                        SelectedA.BackColor = CorrectColor;
                        CorrectInput = false;
                        AftelNaarVolgende = defaultAftelNaarVolgende;
                        IsCountingDown = true;
                        antwoord = false;
                        AntwoordOpslaan(id, vraagId, antwoord, BeantwoordTijd, strafTijdFouteVraag);
                        strafsecondeberekenen();
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
                connection.ConnectionString = DatabaseSettings.Connectionstring;
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

        //
        public void CheckAantalVragen()
        {
            string query = "SELECT id FROM speler WHERE naam = '" + naam + "'";

            using (MySqlConnection connection = new MySqlConnection())
            {
                connection.ConnectionString = DatabaseSettings.Connectionstring;
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    connection.Open();
                    MySqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            userId = (int)reader["id"];
                        }
                    }
                    reader.Close();
                    connection.Close();
                }
            }

            string query2 = "SELECT sum(IsGoedBeandwoord) AS IsGoedBeandwoord FROM andwoord WHERE userId = " + userId + "";

            using (MySqlConnection connection = new MySqlConnection())
            {
                connection.ConnectionString = DatabaseSettings.Connectionstring;
                using (MySqlCommand command2 = new MySqlCommand(query2, connection))
                {
                    connection.Open();
                    MySqlDataReader reader = command2.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            IsGoedBeantwoord = Convert.ToInt32(reader["IsGoedBeandwoord"]);
                            //IsGoedBeantwoord = 2;

                        }
                    }
                    connection.Close();
                    AantalFouteVragen = QuestionAmount - IsGoedBeantwoord;
                }
            }
        }
        //

        
        
        private void AftelTimerVolgendeVraag_Tick(object sender, EventArgs e)
        {
            if (HasGivenInput == true && IsCountingDown == true)
            {
                if (AftelNaarVolgende > 0)
                {
                    AftelNaarVolgende--;
                }

                if (AftelNaarVolgende == 0)
                {
                    IsCountingDown = false;

                    if (Questions.Count > 0)
                    {
                        AskQuestion(Questions[QuestionsCurrentListIndex], QuestionsCurrentListIndex);
                    } else
                    {
                        CheckAantalVragen();
                        Resultaten myForm = new Resultaten(IsGoedBeantwoord, AantalFouteVragen, AantalFouteVragen * strafTijdFouteVraag, GlobalTimer);
                        myForm.ShowDialog();
                        Close();
                    }
                }
            }
        }
        public void strafsecondeberekenen()
        {
            aantathuidigestrafseconde = int.Parse(ExtraSecondsLabel.Text);
            aantatstrafseconde = aantathuidigestrafseconde + aantalstrafseconde;
            ExtraSecondsLabel.Text = aantatstrafseconde.ToString();
        }
    }
}
