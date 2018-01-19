using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_1_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("iveskite tris skaicius");
            var a = Convert.ToInt32(Console.ReadLine());
            var b = Convert.ToInt32(Console.ReadLine());
            var c = Convert.ToInt32(Console.ReadLine());

            // cia if salygos pagal uzduoti

            if (a == b)
            {
                Console.WriteLine("pirmas ir antras skaiciai lygus");
            }

            if (b == c)
            {
                Console.WriteLine("antras ir trecias skaiciai lygus");
            }

            if (a % 2 == 0)
            {
                Console.WriteLine("pirmas skaicius lyginis");
            }
        }
    }
}
