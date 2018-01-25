using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_3_pakartojimas
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Leisti vartotojui pasirinkti kiek duomenų jis nori suvesti. Šiuos duomenis sukelti į masyvą, rasti: sumą, vidurkį, min, max. Atlikti atrinkimą į kitą masyvą, duomenų, kurie tenkina šią sąlygą: visos temperatūros, kurios yra daugiau už vidurkį. Abiejų masyvų duomenis išvesti. Iš atrinktų temperatūrų masyvo rasti vidurkį. */

            Console.WriteLine("Kiek temperatūrų norite suvesti?");
            var kiek = Convert.ToInt32(Console.ReadLine());

            var temperaturos = new int[kiek];

            for (int i = 0; i < kiek; i++)
            {
                Console.Write("Iveskite {0}-aja temp: ", i+1);
                temperaturos[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("IVESTI DUOMENYS");

            foreach (var temperatura in temperaturos)
            {
                Console.Write("[{0}] ", temperatura);
            }

            Console.WriteLine();

            // SUMA

            var suma = 0;

            foreach (var temp in temperaturos)
            {
                suma += temp;
                // suma = suma + temp;
            }

            Console.WriteLine("suma: " + suma);

            // VIDURKIS

            var vidurkis = (double)suma / temperaturos.Length;

            Console.WriteLine("vidurkis: " + Math.Round(vidurkis, 2));

            // MAZIAUSIA TEMP

            var maziausias = temperaturos[0];

            foreach (var temp in temperaturos)
            {
                if (temp < maziausias)
                {
                    maziausias = temp;
                }
            }

            Console.WriteLine("maziausia: " + maziausias);

            // DIDZIAUSIA TEMPERATURA

            var didziausia = 0;

            foreach (var temp in temperaturos)
            {
                if (temp > didziausia)
                {
                    didziausia = temp;
                }
            }

            Console.WriteLine("didziausia: " + didziausia);

            // ATRINKIMAS
            // temperatūros, kurios yra didesnės už vidurkį

            var atrinkta = new int[kiek];
            var kiekAtrinkta = 0;

            foreach (var temp in temperaturos)
            {
                if (temp > vidurkis)
                {
                    atrinkta[kiekAtrinkta] = temp;
                    kiekAtrinkta++;
                }
            }

            Console.WriteLine("ATRINKTI DUOMENYS");

            for (int i = 0; i < kiekAtrinkta; i++)
            {
                Console.Write("[{0}] ", atrinkta[i]);
            }

            Console.WriteLine();
        }
    }
}
