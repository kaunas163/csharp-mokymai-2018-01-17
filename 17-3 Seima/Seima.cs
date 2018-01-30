using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_3_Seima
{
    class Seima
    {
        public string Adresas { get; private set; }
//        public List<Zmogus> Zmones { get; private set; } = new List<Zmogus>();
        public List<Zmogus> Zmones { get; private set; } = new List<Zmogus>();

        /*public Seima()
        {
            Zmones = new List<Zmogus>();
        }*/

        public Seima()
        {
            //Zmones = new List<Zmogus>();
            Ivedimas(); // seimos ivedimo metodas
        }

        public Seima(string adresas, List<Zmogus> zmones)
        {
            Adresas = adresas;
            Zmones = zmones;
        }

        public void Isvedimas()
        {
            Console.WriteLine("Seima gyvena {0} adresu", Adresas);

            foreach (var zmogus in Zmones)
            {
                zmogus.Isvedimas();
            }
        }

        public void Ivedimas()
        {
            Console.Write("Iveskite adresa: ");
            Adresas = Console.ReadLine();

            // klausti kiek zmoniu suvesti

            Console.WriteLine("Kiek zmoniu seimoje?");
            var kiek = Convert.ToInt32(Console.ReadLine());

            // sukti for cikla tiek kartu kiek reikia

            for (int i = 0; i < kiek; i++)
            {
                // kurti tuscia zmogaus objekta naudojant () - tuscia konstruktoriu

                var zmogus = new Zmogus(); // zmogaus konstruktorius iskvies ivedimo metoda

                // zmogaus objekta ikelti i zmoniu sarasa

                Zmones.Add(zmogus); // List<Zmogus>
            }
        }
    }
}
