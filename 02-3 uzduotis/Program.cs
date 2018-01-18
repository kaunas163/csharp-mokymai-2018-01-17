using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_3_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Susikurkite skaičiaus kintamąjį, kurį išveskite penkis kartus toje pačioje eilutėje be tarpų tarp šių skaičių (skaičius - 25, išvedimas - 2525252525)*/

            var skaicius = 25;

            Console.WriteLine("{0}{0}{0}{0}{0}", skaicius);
            //Console.WriteLine(skaicius + skaicius);

            Console.Write(skaicius);
            Console.Write(skaicius);
            Console.Write(skaicius);
            Console.Write(skaicius);
            Console.WriteLine(skaicius);
        }
    }
}
