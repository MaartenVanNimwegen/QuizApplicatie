﻿using System;
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
            vragenscherm myForm = new vragenscherm();
            myForm.ShowDialog();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CustomQuizBtn_Click(object sender, EventArgs e)
        {

        }

        private void VragenbeheerBtn_Click(object sender, EventArgs e)
        {

        }

        private void ScoresBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
