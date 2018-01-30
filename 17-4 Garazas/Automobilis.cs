using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_4_Garazas
{
    class Automobilis
    {
        // modelis, marke, gamybos, rida, galia kw, darbinis turis, spalva - propg
        // pilnas konstruktorius - ctor (ConstrucTOR)
        // isvedimo metodas

        public string Marke { get; private set; }
        public string Modelis { get; private set; }
        public int GamybosMetai { get; private set; }
        public int Rida { get; private set; }
        public int GaliaKW { get; private set; }
        public double DarbinisTuris { get; private set; }
        public string Spalva { get; private set; }

        public Automobilis(string marke, string modelis, int gamybosMetai, int rida, int galiaKw, double darbinisTuris, string spalva)
        {
            Marke = marke;
            Modelis = modelis;
            GamybosMetai = gamybosMetai;
            Rida = rida;
            GaliaKW = galiaKw;
            DarbinisTuris = darbinisTuris;
            Spalva = spalva;
        }

        public void Isvedimas()
        {
            Console.WriteLine("Automobilis {0} {1} ({2} m.), {3} km, {4} kw, {5} l, {6}", Marke, Modelis, GamybosMetai, Rida, GaliaKW, DarbinisTuris, Spalva);
        }

        // nauji metodai:
        // - atsukti rida
        // - perdazyti
        // - pakelti galia

        public void AtsuktiRida()
        {
            Console.WriteLine("Dabartine rida: " + Rida);
            Console.Write("Iveskite norima: ");
            var naujaRida = Convert.ToInt32(Console.ReadLine());
            Rida = naujaRida;
            Console.WriteLine("Rida pakeista i: " + Rida);
        }

        public void Perdazyti()
        {
            Console.WriteLine("Dabartine spalva: " + Spalva);
            Console.Write("Iveskite norima: ");
            var naujaSpalva = Console.ReadLine();
            Spalva = naujaSpalva;
            Console.WriteLine("Spalva pakeista i: " + Spalva);
        }

        public void PakeltiGalia()
        {
            Console.WriteLine("Dabartine galia: " + GaliaKW);
            Console.Write("Iveskite norima: ");
            var naujaGalia = Convert.ToInt32(Console.ReadLine());
            GaliaKW = naujaGalia;
            Console.WriteLine("Galia pakeista i: " + GaliaKW);
        }

    } // class automobilis
}
