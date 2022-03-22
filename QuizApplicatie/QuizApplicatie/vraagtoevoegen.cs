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
        private string naam = "";
        private string beschrijving = "";
        private string categorie = "";
        private string img = "";
        private string Artikelnummer = "";

        public vraagtoevoegen()
        {
            InitializeComponent();
        }
        private void PlusjeBtn_Click(object sender, EventArgs e)
        {
            naam = titleTextbox.Text;
            beschrijving = beschrijvingTextbox.Text;
            categorie = CategorieTextbox.Text;
            img = ImgurlTextbox.Text;
            Artikelnummer = ArtikelnummerInput.Text;

            if (titleTextbox.Text.Length <= 0 && beschrijvingTextbox.Text.Length <= 0 && CategorieTextbox.Text.Length <= 0 && ArtikelnummerInput.Text.Length <= 0)
            {
                MessageBox.Show("Niet alle velden zijn ingevuld!");
            }
            else if (titleTextbox.Text.Length > 50 || beschrijvingTextbox.Text.Length > 50 || CategorieTextbox.Text.Length > 50 || ArtikelnummerInput.Text.Length > 50)
            {
                MessageBox.Show("Het maximale aantal karakters te gebruiken in één of meer van de velden is 50!");
            }
            else
            {
                MySqlConnection connection = new MySqlConnection("Data Source = localhost; Initial Catalog = AUSfp; User ID = root; Password = ");
                connection.Open();
                MySqlCommand cmd = new MySqlCommand("INSERT INTO `artikelen` (`Artikelnummer`, `naam`, `categorie`, `inleverdatum`, `beschrijving`, `toevoeger`, `toegevoegdOp`, `img`) VALUES ( '" + Artikelnummer + "', '" + naam + "', '" + categorie + "', now(), '" + beschrijving + "', '" + Login.naam + "', now(),'" + img + "');", connection);
                cmd.ExecuteReader();
                MessageBox.Show("Artikel toegevoegd");
            }
        }
    }
}
