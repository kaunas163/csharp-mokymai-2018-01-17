using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_1_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Susikurkite šiuos kintamuosius iškart su reikšmėmis:
            Vardas;
            Pavardė;
            Amžius.
            Pasirašykite metodą kuris leistų vartotojui pakeisti šių kintamųjų reikšmes ir tai sugebėtų atnaujinti main’e.
            Išveskite kintamųjų reikšmes main metode prieš kviečiant papildomą metodą ir po papildomo metodo kvietimo. */

            var vardas = "HBjsdjd";
            var pavarde = "nfkjdngjkdf";
            var amzius = 20;

            Isvedimas(vardas, pavarde, amzius);
            Ivedimas(ref vardas, ref pavarde, ref amzius);
            Isvedimas(vardas, pavarde, amzius);

        } // main pabaiga

        public static void Ivedimas(ref string vardas, ref string pavarde, ref int amzius)
        {
            Console.WriteLine("Programoje ivestas vardas: " + vardas);
            Console.Write("Iveskite nauja: ");
            vardas = Console.ReadLine();

            Console.WriteLine("Programoje ivesta pavarde: " + pavarde);
            Console.Write("Iveskite nauja: ");
            pavarde = Console.ReadLine();

            Console.WriteLine("Programoje ivestas amzius: " + amzius);
            Console.Write("Iveskite nauja: ");
            amzius = Convert.ToInt32(Console.ReadLine());
        }

        public static void Isvedimas(string vardas, string pavarde, int amzius)
        {
            Console.WriteLine("{0} {1} ({2} m.)", vardas, pavarde, amzius);
        }

    } // class program pabaiga
}
