using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_0_pavyzdziai
{
    class Program
    {
        static void Main(string[] args)
        {
            var pazymiai = new List<int>();

            Console.WriteLine("iveskite pazymius, o noredami sustabdyti parasykite -1");

            int pazymys;

            do
            {
                pazymys = Convert.ToInt32(Console.ReadLine());

                if (pazymys != -1)
                {
                    pazymiai.Add(pazymys);
                }

            } while (pazymys != -1);

            Console.WriteLine();

            foreach (var paz in pazymiai)
            {
                Console.WriteLine(paz);
            }
        }
    }
}
