using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_5
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Liepkite vartotojui įvedinėti atsitiktinius skaičius. Šį ciklą vykdyti tol, kol įvestas skaičius nesidalins iš 9.*/

            Console.WriteLine("iveskite bet koki skaiciu");
            var skaicius = Convert.ToInt32(Console.ReadLine());

            while (skaicius % 9 != 0)
            {
                skaicius = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("ivedete skaiciu kuris dalinasi is 9");
        }
    }
}
