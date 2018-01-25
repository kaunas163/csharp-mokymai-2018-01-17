using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_0_1_pavyzdziai
{
    class Program
    {
        static void Main(string[] args)
        {
            var pinigai = new List<int>
            {
                650, 99, 87, 85, 364, 85, 365, 789,
                74, 522, 889, 999, 14, 41
            };

            foreach (var pinigas in pinigai)
            {
                Console.Write("[{0}] ", pinigas);
            }

            // rasti min, max, average

            var maziausias = pinigai.Min();
            var didziausias = pinigai.Max();
            var vidurkis = pinigai.Average();

            Console.WriteLine("maziausias: " + maziausias);
            Console.WriteLine("didziausias: " + didziausias);
            Console.WriteLine("vidurkis: " + vidurkis);
            Console.WriteLine();

            // atrinkti į kitą sąrašą mažesnius į vidurkį

            var mazesnUzVid = new List<int>();

            foreach (var pinigas in pinigai)
            {
                if (pinigas < vidurkis)
                {
                    mazesnUzVid.Add(pinigas);
                }
            }

            Console.WriteLine("mazesni uz vidurki:");

            foreach (var i in mazesnUzVid)
            {
                Console.Write(i + ", ");
            }

            Console.WriteLine();

            // atrinkti į naują sąrąšą lyginius skaičius



            // atrinkti į kitą sąrašą skaičius esančius tarp 100 ir max
        }
    }
}
