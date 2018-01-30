using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_1_studentai
{
    class Studentas
    {
        // bendri visu studentu duomenys
        public string Vardas { get; set; }
        public string Pavarde { get; set; }
        public int UgisCM { get; set; }
        public int Amzius { get; set; }
        public char Lytis { get; set; }

        // tuscias studento konstruktorius
        public Studentas()
        {
            
        }

        // studento konstruktorius, priimantis duomenis
        public Studentas(string vardas, string pavarde, int ugisCm, int amzius, char lytis) // ctorp -> tab x 2
        {
            Vardas = vardas;
            Pavarde = pavarde;
            UgisCM = ugisCm;
            Amzius = amzius;
            Lytis = lytis;
        }

        // studento isvedimas
        // siuo atveju kvieciamas grupes klases isvedime, prie kiekvieno studento
        public void Isvedimas()
        {
            Console.WriteLine("Studentas/-e {0} {1} ({2} m.), yra {3} cm ugio, jo/-os lytis - {4}", Vardas, Pavarde, Amzius, UgisCM, Lytis);
            // visi kintamieji pasiekiami is klases, del scope ribu
            Console.WriteLine();
        }
    }
}
