using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pracownicy_MVP.Model
{
    [Serializable]
    public class employing
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Date { get; set; }
        public string Salary { get; set; }
        public string Job_title { get; set; }
        public string Contract { get; set; }
    }
}
