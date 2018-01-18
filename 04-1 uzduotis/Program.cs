using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_1_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Liepkite vartotojui įvesti savo vardą ir amžių. Į ekraną išveskite:
“Jūsų vardas {vardas}, o amžius {amžius}.”*/

            Console.WriteLine("Iveskite varda:");
            var vardas = Console.ReadLine();

            Console.WriteLine("Iveskite amziu:");
            var amzius = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Jūsų vardas {0}, o amžius {1}.", vardas, amzius);
        }
    }
}
