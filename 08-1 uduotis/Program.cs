using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_1_uduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Liepkite įvesti tris skaičius. Suraskite kuris iš šių skaičių yra didžiausias.*/

            Console.WriteLine("iveskite tris skaicius");
            var a = Convert.ToInt32(Console.ReadLine());
            var b = Convert.ToInt32(Console.ReadLine());
            var c = Convert.ToInt32(Console.ReadLine());

            if (a > b && a > c)
            {
                Console.WriteLine("a didziausias");
            }
            else if (b > a && b > c)
            {
                Console.WriteLine("b didziausias");
            }
            else if (c > a && c > b)
            {
                Console.WriteLine("c didziausias");
            }
            else
            {
                Console.WriteLine("bent du vienodi");
            }
        }
    }
}
