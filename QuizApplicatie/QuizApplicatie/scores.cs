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
    public partial class scores : Form
    {
        public scores()
        {
            InitializeComponent();
            MySqlConnection connection = new MySqlConnection("Data Source = localhost; Initial Catalog = quizappliatie; User ID = root; Password = ");
            connection.Open();
            MySqlCommand cmd = new MySqlCommand("select * from vragen where id = " + id, connection);
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                
            }
            VragenGrid.Rows.Add("A", "B", "C", "D");
        }

        private void BackBtn_Click_1(object sender, EventArgs e)
        {
            Close();
        }
    }
}
