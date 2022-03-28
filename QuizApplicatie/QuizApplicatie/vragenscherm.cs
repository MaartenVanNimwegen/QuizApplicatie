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

            for (int i = 0; i <= QuestionAmount; i++)
            {
                //AskQuestion(Questions[i]);
            }
        }

<<<<<<< HEAD
        

        private bool AskQuestion(VraagClass Question)
        {
            bool Correct;
=======
        //private bool AskQuestion(VraagClass Question)
        //{
        //    bool Correct;
>>>>>>> 96eb17f1c1a4e73e9ccc4872d078e4ef44b2f47c



        //    return Correct;
        //}

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

            List<int> Qids = NewNumber(Amount, 1, Vragen.Count);
            var SortedQuestions = new List<VraagClass>();

            for (int i = 0; i <= Amount - 1; i++)
            {
                var Vraag = Vragen[i];

                if (Vraag != null)
                {
                    SortedQuestions.Insert(i,  Vragen[Qids[i]] );
                }
            }

            return SortedQuestions;
        }

        private List<int> NewNumber(int Amount, int Start, int End)
        {

            int MyNumber = 0;
            Random Number = new Random();
            List<int> randomList = new List<int>();

            for (int i = 0; i <= Amount; i++)
            {
                MyNumber = Number.Next(Start, End);
                if (!randomList.Contains(MyNumber))
                {
                    randomList.Add(MyNumber);
                }
            }

            return randomList;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            string message = "Weet je zeker dat je de quiz wilt beëindigen? Je scores zullen verloren raken.";
            string caption = "Quiz beëindigen";
            var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Close();
            }
                
        }

        private void timer1_Tick(object sender, EventArgs e)
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
            } else if (QuestionIndividualTimer <= 0)
            {
                AcceptingInput = false;
                TimerPlaying = false;
                CorrectInput = false;

                // Wrong answer procedure
            }
        }
    }
}
