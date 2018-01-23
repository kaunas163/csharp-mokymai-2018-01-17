using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_7_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite du skaicius");
            var pirmas = Convert.ToInt32(Console.ReadLine());
            var antras = Convert.ToInt32(Console.ReadLine());

            var atsakymas = 0;

            for (int i = 0; i < antras; i++)
            {
                //atsakymas += pirmas;
                atsakymas = atsakymas + pirmas;
            }

            Console.WriteLine("daugyba: " + atsakymas);
        }
    }
}
