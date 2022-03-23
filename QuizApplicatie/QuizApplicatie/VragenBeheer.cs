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
        public static string rowIndex = "";


        public VragenBeheer()
        {
            InitializeComponent();

            RefreshDataGrid();
            //VragenGrid.Rows.Add("A", "B", "C", "D");
            //VragenGrid.Rows.Add("A", "B", "C", "D");
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

        private void VragenGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (VragenGrid.CurrentCell != null)
            {
                rowIndex = VragenGrid.SelectedCells[0].Value.ToString();
            }
            vraagwijzigen myForm = new vraagwijzigen(rowIndex);
            DialogResult dialogResult = myForm.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                RefreshDataGrid();
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
