using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_0_1_pavyzdziai
{
    class Program
    {
        static void Main(string[] args)
        {
            var nuvaziuotiKilometrazai = new List<int>();
            Program programa = new Program();

            programa.Ivedimas(nuvaziuotiKilometrazai);
            programa.Isvedimas(nuvaziuotiKilometrazai, "PRADINIAI DUOMENYS");
            programa.Skaiciavimai(nuvaziuotiKilometrazai);

            List<int> atrinkti = programa.Atrinkimas(nuvaziuotiKilometrazai);
            programa.Isvedimas(atrinkti, "ATRINKTI DUOMENYS");

        } // metodo main pabaiga

        public void Ivedimas(List<int> sarasas)
        {
            var dar = true;

            while (dar)
            {
                Console.Write("iveskite kilometraza: ");
                var km = Convert.ToInt32(Console.ReadLine());
                sarasas.Add(km);

                Console.WriteLine("norit kartoti? t/n");
                var kartoti = Console.ReadLine();
                if (kartoti != "t")
                {
                    dar = false;
                }
            }
        }

        public void Isvedimas(List<int> sarasas, string komentaras)
        {
            Console.WriteLine(komentaras);

            foreach (var km in sarasas)
            {
                Console.Write("[{0}]", km);
            }

            Console.WriteLine();
        }

        public int Suma(List<int> sarasas)
        {
            return sarasas.Sum();
        }

        public int Maziausias(List<int> sarasas)
        {
            return sarasas.Min();
        }

        public int Didziausias(List<int> sarasas)
        {
            return sarasas.Max();
        }

        public double Vidurkis(List<int> sarasas)
        {
            var vidurkis = (double) Suma(sarasas) / sarasas.Count;
            return vidurkis;
        }

        public void Skaiciavimai(List<int> sarasas)
        {
            Console.WriteLine("Suma: " + Suma(sarasas));
            Console.WriteLine("Min: " + Maziausias(sarasas));
            Console.WriteLine("Max: " + Didziausias(sarasas));
            Console.WriteLine("Vidurkis: " + Vidurkis(sarasas));
        }

        public List<int> Atrinkimas(List<int> pradiniai)
        {
            // daugiau nei 300k, laikysim jau kaip graba

            var atrinkti = new List<int>();

            foreach (var km in pradiniai)
            {
                if (km > 300000)
                {
                    atrinkti.Add(km);
                }
            }

            return atrinkti;
        }

    } // class program pabaiga
}
