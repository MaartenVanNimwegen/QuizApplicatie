using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizApplicatie
{
    class AntwoordenClass
    {
        public int id { get; set; }
        public int userId { get; set; }
        public int vraagId { get; set; }
        public int tijd { get; set; }
        public int strafTijd { get; set; }
        public DateTime datum { get; set; }
    }
}
