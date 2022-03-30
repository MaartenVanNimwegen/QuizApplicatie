using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizApplicatie
{
    public partial class CustomQuiz : Form
    {
        string Naam;
        public CustomQuiz(string naam)
        {
            InitializeComponent();
            Naam = naam;
        }
        
        int tijdPerVraag;
        int strafseconde;
        int aantalvragen;
        bool QuizIsCustom;

        private void Backbtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void startcustomquiz_Click(object sender, EventArgs e)
        {
            tijdPerVraag = int.Parse(TijdPerVraagAantal.Text);
            strafseconde = int.Parse(StrafsecondenAantal.Text);
            aantalvragen = int.Parse(AantalVragenAantal.Text);
            QuizIsCustom = true;

            VragenScherm myForm = new VragenScherm(QuizIsCustom, tijdPerVraag, strafseconde, aantalvragen, Naam);
            myForm.ShowDialog();
            Close();
        }
    }
}
