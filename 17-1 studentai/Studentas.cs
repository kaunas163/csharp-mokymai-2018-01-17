using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_1_studentai
{
    class Studentas
    {
        public string Vardas { get; set; }
        public string Pavarde { get; set; }
        public int UgisCM { get; set; }
        public int Amzius { get; set; }
        public char Lytis { get; set; }

        public Studentas()
        {
            
        }

        public Studentas(string vardas, string pavarde, int ugisCm, int amzius, char lytis) // ctorp -> tab x 2
        {
            Vardas = vardas;
            Pavarde = pavarde;
            UgisCM = ugisCm;
            Amzius = amzius;
            Lytis = lytis;
        }

        // isvedimo metodas
    }
}
