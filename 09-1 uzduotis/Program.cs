using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_1_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Liepkite vartotojui įvesti tris skaičius. Su switch patikrinkite pirmąjį skaičių:
                ar jis lygus 1: išveskite visų trijų skaičių sumą;
                ar jis lygus 2: išveskite pirmo ir trečio skaičių skirtumą;
                ar jis lygus 3: išveskite antro ir trečio skaičių sandaugą.*/

            var a = 2;
            var b = 7;
            var c = 5;

            switch (a)
            {
                case 1:
                    Console.WriteLine(a + b + c);
                    break;
                case 2:
                    Console.WriteLine(a - c);
                    break;
                case 3:
                    Console.WriteLine(b * c);
                    break;
                default:
                    Console.WriteLine("skaicius nerastas");
                    break;
            }
        }
    }
}
