using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_0_pavyzdziai
{
    class Program
    {
        static void Main(string[] args)
        {
            // studentu pazymiai

            int[] pazymiai = {10, 8, 3, 5, 8, 7, 9};

            Console.WriteLine(pazymiai[1]); // 8
            Console.WriteLine(pazymiai[3]); // 5
            Console.WriteLine(pazymiai[5]); // 7
            Console.WriteLine(pazymiai[6]); // 9
            Console.WriteLine(pazymiai[2]); // 3
            Console.WriteLine(pazymiai[0]); // 10

            // 3 -> 4
            pazymiai[2] = 4;

            // 7 -> 1
            pazymiai[5] = 1;

            // 10 -> 9
            pazymiai[0] = 9;

            Console.WriteLine();

            foreach (var pazymys in pazymiai)
            {
                Console.Write(pazymys + " ");
            }

            Console.WriteLine();

            for (int i = 0; i < pazymiai.Length; i++)
            {
                Console.Write(pazymiai[i] + " ");
            }

            Console.WriteLine();

            // vardai

            var vardai = new string[7];

            for (int i = 0; i < vardai.Length; i++)
            {
                Console.Write("iveskite varda: ");
                vardai[i] = Console.ReadLine();
            }

            Console.WriteLine();

            foreach (var vardas in vardai)
            {
                Console.Write(vardas + ", ");
            }

            Console.WriteLine();

            // pazymiai 2

            Console.WriteLine("kiek pazymiu norite suvesti?");
            var kiek = Convert.ToInt32(Console.ReadLine());

            var pazymiai2 = new int[kiek];

            for (int i = 0; i < pazymiai2.Length; i++)
            {
                Console.Write("iveskite {0}-aji pazymi: ", i+1);
                pazymiai2[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("ivesti pazymiai:");

            foreach (var pazymys in pazymiai2)
            {
                Console.Write("[{0}]", pazymys);
            }

            Console.WriteLine();

            // algoritmas - suma

            var suma = 0;

            foreach (var pazymys in pazymiai2)
            {
                suma += pazymys;
                // suma = suma + pazymys;
            }

            Console.WriteLine("suma: " + suma);

            // algoritmas - min pazymys

            var maziausias = pazymiai2[0];

            foreach (var pazymys in pazymiai2)
            {
                if (pazymys < maziausias)
                {
                    maziausias = pazymys;
                }
            }

            Console.WriteLine("maziausias: " + maziausias);

            Console.WriteLine("maziausias: " + pazymiai2.Min());

            // algoritmas - max pazymys

            var didziausias = 0;

            foreach (var pazymys in pazymiai2)
            {
                if (pazymys > didziausias)
                {
                    didziausias = pazymys;
                }
            }

            Console.WriteLine("didziausias: " + didziausias);

            Console.WriteLine("didziausias: " + pazymiai2.Max());

            // vidurkis

            // sumos algoritmas

            var vidurkis = (double)suma / pazymiai2.Length;

            Console.WriteLine("vidurkis: " + vidurkis);

            Console.WriteLine("vidurkis: " + pazymiai2.Average());
        }
    }
}
