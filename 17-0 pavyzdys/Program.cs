using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_0_pavyzdys
{
    class Automobilis
    {
        // prop -> tab x 2

        // kintamieji

        public string Spalva { get; set; }
        public string Marke { get; set; }
        public string Modelis { get; set; }
        public int Rida { get; set; }
        public int Pavaros { get; set; }
        public double DarbinisTuris { get; set; }
        public int GaliaKw { get; set; }

        // ctor

        public Automobilis()
        {
            
        }

        public Automobilis(string Spalva, string marke, string modelis, int rida, int pavaros, double darbinisTuris, int galiaKw)
        {
            this.Spalva = Spalva;
            Marke = marke;
            Modelis = modelis;
            Rida = rida;
            Pavaros = pavaros;
            DarbinisTuris = darbinisTuris;
            GaliaKw = galiaKw;
        }

        public void Isvedimas()
        {
            Console.WriteLine("Automobilio {0} {1} duomenys", Marke, Modelis);
            Console.WriteLine("Spalva: " + Spalva);
            Console.WriteLine("Rida: " + Rida);
            Console.WriteLine("Pavaros: " + Pavaros);
            Console.WriteLine("Darbinis turis: " + DarbinisTuris);
            Console.WriteLine("Galia, kw: " + GaliaKw);
            Console.WriteLine();
        }

        public void Ivedimas()
        {
            Console.Write("Iveskite marke: ");
            Marke = Console.ReadLine();

            Console.Write("Iveskite modeli: ");
            Modelis = Console.ReadLine();

            Console.Write("Iveskite spalva: ");
            Spalva = Console.ReadLine();

            Console.Write("Iveskite rida: ");
            Rida = Convert.ToInt32(Console.ReadLine());

            Console.Write("Iveskite pavaras: ");
            Pavaros = Convert.ToInt32(Console.ReadLine());

            Console.Write("Iveskite darbini turi: ");
            //DarbinisTuris = Convert.ToDouble(Console.ReadLine());

            string darbTuris = Console.ReadLine(); // nuskaitom is konsoles kaip teksta
            double darbTurisSk; // kur saugosim skaiciu jei pavyks konvertuoti

            // bandom konvertuoti, jei pavyksta bool pavyko = true
            bool pavyko = double.TryParse(darbTuris, out darbTurisSk);

            if (pavyko) // jei pavyko
            {
                DarbinisTuris = darbTurisSk; // priskiriam nauja reiksme
            }
            else // jei nepavyko
            {
                DarbinisTuris = 0; // priskiriam defaulta
            }

            // galim visa ta nuskaityma su "apsauga" sudeti i do while

            Console.Write("Iveskite galia (kw): ");
            GaliaKw = Convert.ToInt32(Console.ReadLine());
        }

    } // automobilis klases pabaiga

    class Program
    {
        static void Main(string[] args)
        {
            Automobilis automobilis = new Automobilis();

            automobilis.Marke = "AAA";
            automobilis.Modelis = "BBB";
            automobilis.Spalva = "Raudona";
            automobilis.DarbinisTuris = 2.0;
            automobilis.Rida = 300000;
            automobilis.Pavaros = 5;
            automobilis.GaliaKw = 150;

            Console.WriteLine(automobilis.Marke);
            Console.WriteLine(automobilis.Modelis);
            //...
            Console.WriteLine();

            automobilis.Isvedimas();

            var auto2 = new Automobilis // object initializer (?)
            {
                Marke = "ahbssj",
                Modelis = "shgh",
                Spalva = "sdgh",
                DarbinisTuris = 1.6,
                Rida = 20000,
                Pavaros = 4,
                GaliaKw = 50
            };

            Console.WriteLine(auto2.DarbinisTuris);
            Console.WriteLine(auto2.GaliaKw);
            //...
            Console.WriteLine();

            auto2.Isvedimas();

            var auto3 = new Automobilis("juoda", "afs", "dsgdg", 25000, 5, 2, 120);
            Console.WriteLine(auto3.GaliaKw);
            Console.WriteLine(auto3.Marke);
            Console.WriteLine(auto3.Spalva);
            //...
            Console.WriteLine();

            auto3.Isvedimas();

            var auto4 = new Automobilis();
            auto4.Ivedimas();
            auto4.Isvedimas();

        } // main metodo pabaiga
    } // class program pabaiga
}
