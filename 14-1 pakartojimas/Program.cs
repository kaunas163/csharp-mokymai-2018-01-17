using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_1_pakartojimas
{
    class Program
    {
        static void Main(string[] args)
        {
            /* rasti visų skaičių iš [10-100] rėžių, kurie dalinasi iš 3 sumą */

            var suma = 0;

            for (int i = 10; i <= 100; i++)
            {
                if (i % 3 == 0)
                {
                    suma += i;
                }
            }

            Console.WriteLine("suma: " + suma);
        }
    }
}
