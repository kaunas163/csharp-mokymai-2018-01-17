using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_2_pakartojias
{
    class Program
    {
        static void Main(string[] args)
        {
            /* sudėti į masyvą skaičius kurie dalinasi iš 5 ir patenka tarp [30-150] rėžius. Masyvą išvesti gražiai */

            var skaiciai = new int[120];
            var indeksas = 0;

            for (int t = 30; t <= 150; t++)
            {
                if (t % 5 == 0)
                {
                    skaiciai[indeksas] = t;
                    indeksas++;
                }
            }

            foreach (var skaicius in skaiciai)
            {
                Console.Write("[{0}]", skaicius);
            }

            Console.WriteLine();

            for (int i = 0; i < indeksas; i++)
            {
                Console.Write("[{0}]", skaiciai[i]);
            }

            Console.WriteLine();

            // rasti skaičių sumą, vidurkį, didžiausią, mažiausią skaičius
            // iš turimo masyvo

            // sumos paieška

            var suma = 0;

            for (int i = 0; i < indeksas; i++)
            {
                suma += skaiciai[i];
            }

            Console.WriteLine("suma: " + suma);

            // vidurkio paieška

            var vidurkis = (double) suma / indeksas;

            Console.WriteLine("vidurkis: " + vidurkis);
            
            // didžiausio skaičiaus paieška

            var didziausias = skaiciai[indeksas-1];

            Console.WriteLine("didziausias: " + didziausias);

            // mažiausio skaičiaus paieška

            var maziausias = skaiciai[0];

            Console.WriteLine("maziausias: " + maziausias);
        }
    }
}
