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
    public partial class vraagtoevoegen : Form
    {
        private string Vraag = "";
        private string GoedAntwoord = "";
        private string FoutAntwoord = "";

        public vraagtoevoegen()
        {
            InitializeComponent();
        }
        private void PlusjeBtn_Click(object sender, EventArgs e)
        {
            Vraag = VraagTextbox.Text;
            GoedAntwoord = GoedAntwoordTextbox.Text;
            FoutAntwoord = FoutAntwoordTextbox.Text;
        
            if (VraagTextbox.Text.Length <= 0 || GoedAntwoordTextbox.Text.Length <= 0 || FoutAntwoordTextbox.Text.Length <= 0)
            {
                MessageBox.Show("Niet alle velden zijn ingevuld!");
            }
            else if (VraagTextbox.Text.Length > 200 || GoedAntwoordTextbox.Text.Length > 200 || FoutAntwoordTextbox.Text.Length > 200)
            {
                MessageBox.Show("Het maximale aantal karakters te gebruiken in één of meer van de velden is 50!");
            }
            else
            {
                MySqlConnection connection = new MySqlConnection("Data Source = localhost; Initial Catalog = quizapplicatie; User ID = root; Password = ");
                connection.Open();
                MySqlCommand cmd = new MySqlCommand("INSERT INTO `vragen` (`Vraag`, `GoedAntwoord`, `FoutAntwoord`) VALUES ( '" + Vraag + "', '" + GoedAntwoord + "', '" + FoutAntwoord + "');", connection);
                cmd.ExecuteReader();
                MessageBox.Show("Vraag toegevoegd");
                VraagTextbox.Text = "";
                GoedAntwoordTextbox.Text = "";
                FoutAntwoordTextbox.Text = "";
            }
        }
    }
}
