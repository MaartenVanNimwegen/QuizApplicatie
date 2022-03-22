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
        public VragenBeheer()
        {
            InitializeComponent();


            VragenGrid.Rows.Add("A", "B", "C", "D");
            VragenGrid.Rows.Add("A", "B", "C", "D");
        }

        private void VragenGrid_DoubleClick(object sender, EventArgs e)
        {

        }
    }
}
