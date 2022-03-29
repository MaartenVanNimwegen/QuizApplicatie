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
    public partial class Resultaten : Form
    {
        private int goedantwoord;
        private int foutantwoord;
        private int tijd;
        private int strafTijd;
        private int totaletijd;

        public Resultaten(int GoedAntwoord, int FoutAntwoord, int StrafTijd, int Tijd)
        {
            InitializeComponent();

            goedantwoord = GoedAntwoord;
            foutantwoord = FoutAntwoord;
            strafTijd = StrafTijd;
            tijd = Tijd;
            totaletijd = tijd + strafTijd;

            GoedBeantwoordeVragen.Text = "Goed beantwoorde vragen: " + goedantwoord.ToString();
            FoutBeantwoordeVragen.Text = "Fout beantwoorde vragen: " + foutantwoord.ToString();
            TijdLabel.Text = "Tijd: " + tijd.ToString() + "s";
            StrafSeconden.Text = "Strafseconden: " + strafTijd.ToString() + "s";
            TotaleScore.Text = "Totale tijd: " + totaletijd.ToString() + "s";
        }

        private void TerugNaarHoofdmenu_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
