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
    public partial class VragenBeheer : Form
    {
        int questionId = 0;

        public VragenBeheer()
        {
            InitializeComponent();

            RefreshDataGrid();
        }

        private void RefreshDataGrid()
        {
            VragenGrid.Rows.Clear();


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


            for (int i = 1; i <= Vragen.Count; i++)
            {
                var Vraag = Vragen[i - 1];

                if (Vraag != null)
                {
                    VragenGrid.Rows.Add(Vraag.id, Vraag.vraag, Vraag.correctantwoord, Vraag.incorrectantwoord);
                }
            }
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void VragenGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            questionId = (int)VragenGrid.SelectedCells[0].Value;
            int selectedColumn = e.ColumnIndex;

            if (selectedColumn != 5)
            {
                vraagwijzigen myForm = new vraagwijzigen(questionId);
                DialogResult dialogResult = myForm.ShowDialog();
                if (dialogResult == DialogResult.OK)
                {
                    RefreshDataGrid();
                }
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Weet je zeker dat je deze vraag wilt verwijderen?", "Artikel verwijderen", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    MySqlConnection connection = new MySqlConnection("Data Source = localhost; Initial Catalog = quizapplicatie; User ID = root; Password = ");
                    connection.Open();
                    MySqlCommand cmd = new MySqlCommand("DELETE FROM vragen where id = " + questionId + "", connection);
                    cmd.ExecuteReader();
                    MessageBox.Show("Vraag verwijderd");
                    RefreshDataGrid();
                }
            }
        }
        private void CancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            vraagtoevoegen myForm = new vraagtoevoegen();
            myForm.ShowDialog();

            RefreshDataGrid();
        }
    }
}
