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
            foreach (var auto in Automobiliai)
            {
                auto.Isvedimas();
            }
        }
    }
}
