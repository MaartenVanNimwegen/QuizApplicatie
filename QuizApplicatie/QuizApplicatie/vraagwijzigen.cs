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
    public partial class vraagwijzigen : Form
    {
        private static string id = "";

        private string HuidigVraag = "";
        private string HuidigGoedAntwoord = "";
        private string HuidigFoutAntwoord = "";

        private string Vraag = "";
        private string GoedAntwoord = "";
        private string FoutAntwoord = "";

        public vraagwijzigen()
        {
            InitializeComponent();
            //id = rowId; 

            MySqlConnection connection = new MySqlConnection("Data Source = localhost; Initial Catalog = quizappliatie; User ID = root; Password = ");
            connection.Open();
            MySqlCommand cmd = new MySqlCommand("select * from vragen where id = " + id, connection);
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                HuidigVraag = (string)reader["Vraag"];
                HuidigGoedAntwoord = (string)reader["GoedAntwoord"];
                HuidigFoutAntwoord = (string)reader["FoutAntwoord"];
            }
            VraagTextbox.Text = HuidigVraag;
            GoedAntwoordTextbox.Text = HuidigGoedAntwoord;
            FoutAntwoordTextbox.Text = HuidigFoutAntwoord;
        }

        private void WijzigenBtn_Click(object sender, EventArgs e)
        {
            Vraag = VraagTextbox.Text;
            GoedAntwoord = GoedAntwoordTextbox.Text;
            FoutAntwoord = FoutAntwoordTextbox.Text;

            if (VraagTextbox.Text.Length <= 0 || GoedAntwoordTextbox.Text.Length <= 0 || FoutAntwoordTextbox.Text.Length <= 0)
            {
                MessageBox.Show("Niet alle velden zijn ingevuld!");
            }
            else if (VraagTextbox.Text.Length > 50 || GoedAntwoordTextbox.Text.Length > 50 || FoutAntwoordTextbox.Text.Length > 50)
            {
                MessageBox.Show("Het maximale aantal karakters te gebruiken in één of meer van de velden is 50!");
            }
            else
            {
                MySqlConnection connection = new MySqlConnection("Data Source = localhost; Initial Catalog = quizapplicatie; User ID = root; Password = ");
                connection.Open();
                MySqlCommand cmd = new MySqlCommand("UPDATE artikelen SET Vraag='" + Vraag + "', GoedAntwoord='" + GoedAntwoord + "', FoutAntwoord='" + FoutAntwoord + "'", connection);
                cmd.ExecuteReader();
                MessageBox.Show("Vraag gewijzigd");
                VraagTextbox.Text = "";
                GoedAntwoordTextbox.Text = "";
                FoutAntwoordTextbox.Text = "";
            }
        }
    }
}
