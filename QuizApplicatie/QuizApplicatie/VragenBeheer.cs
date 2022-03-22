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
    public partial class VragenBeheer : Form
    {
        public static string rowIndex = "";


        public VragenBeheer()
        {
            InitializeComponent();
            
            VragenGrid.Rows.Add("A", "B", "C", "D");
            VragenGrid.Rows.Add("A", "B", "C", "D");
        }
        private void CancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            vraagtoevoegen myForm = new vraagtoevoegen();
            myForm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            vraagwijzigen myForm = new vraagwijzigen();
            myForm.ShowDialog();
        }

        private void VragenGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (VragenGrid.CurrentCell != null)
            {
                rowIndex = VragenGrid.SelectedCells[0].Value.ToString();
            }
        }
    }
}
