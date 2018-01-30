using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace _17_3_Seima
{
    class Zmogus
    {
        public string Vardas { get; private set; }
        public string Pavarde { get; private set; }
        public int UgisCm { get; private set; }
        public int Amzius { get; private set; }
        public char Lytis { get; private set; }

        public Zmogus()
        {
            Ivedimas();
        }

        public Zmogus(string vardas, string pavarde, int ugisCm, int amzius, char lytis)
        {
            Vardas = vardas;
            Pavarde = pavarde;
            UgisCm = ugisCm;
            Amzius = amzius;
            Lytis = lytis;
        }

        public void Isvedimas()
        {
            Console.WriteLine("{0} {1} ({2} m.), kurio ugis {3} yra lyties {4}", Vardas, Pavarde, Amzius, UgisCm, Lytis);
        }

        public void Ivedimas()
        {
            Console.WriteLine("Iveskite duomenis apie zmogu");

            Console.Write("Vardas: ");
            Vardas = Console.ReadLine();

            Console.Write("Pavarde: ");
            Pavarde = Console.ReadLine();

            Console.Write("Amziu: ");
            Amzius = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ugis, cm: ");
            UgisCm = Convert.ToInt32(Console.ReadLine());

            Console.Write("Lytis: ");
            Lytis = Convert.ToChar(Console.Read());
            Console.ReadLine();
        }
    }
}
