using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_6_random
{
    class Program
    {
        static void Main(string[] args)
        {
            var randomas = new Random();
            var suma = 0;
            var didziausias = 0;

            for (int i = 0; i < 50; i++)
            {
                // pirmas budas:
                //Console.Write(randomas.Next(20) + " "); // [0-20)

                // antras budas:
                var skaicius = randomas.Next(5, 50); // [5-50)
                Console.Write(skaicius + " ");

                suma += skaicius;

                if (skaicius > didziausias)
                {
                    didziausias = skaicius;
                }
            }

            Console.WriteLine();
            Console.WriteLine("suma: " + suma);
            Console.WriteLine("didziausias: " + didziausias);
        }
    }
}
