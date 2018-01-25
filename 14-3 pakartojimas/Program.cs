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
            /* Leisti vartotojui pasirinkti kiek duomenų jis nori suvesti. Šiuos duomenis sukelti į masyvą, rasti: vidurkį, min, max, sumą. Atlikti atrinkimą į kitą masyvą duomenų, kurie tenkina šią sąlygą: visos temperatūros, kurios yra daugiau už vidurkį. Abiejų masyvų duomenis išvesti. Iš atrinktų temperatūrų masyvo rasti vidurkį. */

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


        }
    }
}
