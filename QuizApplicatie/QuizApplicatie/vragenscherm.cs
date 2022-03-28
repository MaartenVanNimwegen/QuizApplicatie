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
            VraagLable.Text = Question.vraag;


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

        private void VragenScherm_KeyDown(object sender, KeyEventArgs e)
        {
            if (AcceptingInput)
            {
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
                }


                if (e.KeyCode == Keys.A)
                {
                    HasGivenInput = true;
                    AnswerA.ForeColor = Color.Yellow;

                    if (CorrectAnswer == "A")
                    {
                        CorrectInput = true;
                    }
                    else
                    {
                        CorrectInput = false;
                    }
                }
                else if (e.KeyCode == Keys.B)
                {
                    HasGivenInput = true;
                    AnswerB.ForeColor = Color.Yellow;


                }
            }
        }

    }
}
