using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_0_pavyzdziai
{
    class Matematika
    {
        public static int Suma(int a, int b)
        {
            return a + b;
        }

        public static int Skirtumas(int a, int b)
        {
            var skirtumas = a - b;
            return skirtumas;
        }

        public static int Sandauga(int a, int b)
        {
            return a * b;
        }

        public static double Dalmuo(int a, int b)
        {
            return (double) a / b;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Program.Pasisveikinti();
            Atsisveikinti();
            
            var programa = new Program(); // objektas, kuriamas viena karta
            programa.Pinigai();
            programa.Automobilis();

            var suma = Matematika.Suma(5, 4);
            Console.WriteLine(suma);

            Console.WriteLine(Matematika.Suma(4, 8));

            // iskviesti visus likusius metodus

            Console.WriteLine(Matematika.Skirtumas(7, 5));
            Console.WriteLine(Matematika.Sandauga(5, 4));
            Console.WriteLine(Matematika.Dalmuo(7, 5));
        }

        public static void Pasisveikinti()
        {
            Console.WriteLine("jusu vardas?");
            Console.WriteLine("Labas, " + Console.ReadLine());
        }

        public static void Atsisveikinti()
        {
            Console.WriteLine("viso gero");
        }

        public void Pinigai()
        {
            Console.WriteLine("Pasakykite ka daro pinigai");
            var pinigai = Console.ReadLine();
            Console.WriteLine("aciu, jusu atsakymas priimtas, jis yra:");
            Console.WriteLine(pinigai);
        }

        public void Automobilis()
        {
            Console.WriteLine("ka vairuojate?");
            var auto = Console.ReadLine();
            if (auto == "kamaz")
            {
                Console.WriteLine("nice");
            }
        }
    }
}
