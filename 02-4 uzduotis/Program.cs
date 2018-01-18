using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_4_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Susikurkite skaičiaus kintamąjį, kurį išveskite penkis kartus toje pačioje eilutėje su tarpais tarp šių skaičių (skaičius - 25, rezultatas - 25 25 25 25 25).*/

            var skaicius = 25;

            //cw ir tab du kartus

            Console.WriteLine("{0} {0} {0} {0} {0}", skaicius);

            Console.WriteLine(skaicius + " " + skaicius + " " + skaicius + " " + skaicius + " " + skaicius);
        }
    }
}
