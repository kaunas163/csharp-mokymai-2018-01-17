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
    }
}
