using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_4_Garazas
{
    class Garazas
    {
        public string Pavadinimas { get; private set; }
        public string Adresas { get; private set; }
        public int MeistruSkaicius { get; private set; }
        public List<Automobilis> Automobiliai { get; private set; }

        public Garazas(string pavadinimas, string adresas, int meistruSkaicius, List<Automobilis> automobiliai)
        {
            Pavadinimas = pavadinimas;
            Adresas = adresas;
            MeistruSkaicius = meistruSkaicius;
            Automobiliai = automobiliai;
        }

        public void Isvedimas() // garazo isvedimas
        {
            Console.WriteLine("Garaziukas {0} randasi adresu {1}, jame dirba {2} meistrai", Pavadinimas, Adresas, MeistruSkaicius);

            Console.WriteLine("Remontuojami automobiliai:");

            for (var i = 0; i < Automobiliai.Count; i++)
            {
                Console.Write(i+1 + " auto: ");
                Automobiliai[i].Isvedimas();
            }
        }

        public void AtnaujintiPasirinkta()
        {
            Console.Write("Kuri automobili keisti: ");
            var kuris = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Pasirinktas automobilis:");
            Automobiliai[kuris - 1].Isvedimas();

            Console.WriteLine("1 - atsukti rida");
            Console.WriteLine("2 - perdazyti");
            Console.WriteLine("3 - padidinti galia");

            var pasirinkimas = Convert.ToInt32(Console.ReadLine());

            switch (pasirinkimas)
            {
                case 1:
                    Automobiliai[kuris - 1].AtsuktiRida();
                    break;
                case 2:
                    Automobiliai[kuris - 1].Perdazyti();
                    break;
                case 3:
                    Automobiliai[kuris - 1].PakeltiGalia();
                    break;
            }

            Console.WriteLine("Atnaujintas automobilis:");
            Automobiliai[kuris - 1].Isvedimas();
        }

        public void Skaiciavimai()
        {
            Console.WriteLine("SKAICIAVIMAI");

            Console.WriteLine("Total rida: " + TotalRida());

            Console.Write("Didziausia galia: ");
            //DidziausiaGalia().Isvedimas();
            var didziausia = DidziausiaGalia();
            didziausia.Isvedimas();
        }

        public int TotalRida()
        {
            var sum = 0;

            foreach (var auto in Automobiliai)
            {
                sum += auto.Rida;
            }

            return sum;
        }

        public Automobilis DidziausiaGalia()
        {
            var didziausia = Automobiliai.First(); // objektas

            foreach (var auto in Automobiliai)
            {
                if (auto.GaliaKW > didziausia.GaliaKW) // lygina pagal savybes
                {
                    didziausia = auto; // prisiskiria objekta
                }
            }

            return didziausia;
        }

    } // class garazas pabaiga
}
