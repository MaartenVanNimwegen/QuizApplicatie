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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            VragenScherm myForm = new VragenScherm();
            myForm.ShowDialog();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CustomQuizBtn_Click(object sender, EventArgs e)
        {
            CustomQuiz myForm = new CustomQuiz();
            myForm.ShowDialog();
        }

        private void VragenbeheerBtn_Click(object sender, EventArgs e)
        {
            VragenBeheer myForm = new VragenBeheer();
            myForm.ShowDialog();
        }

        private void ScoresBtn_Click(object sender, EventArgs e)
        {
            scores myForm = new scores();
            myForm.ShowDialog();
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
