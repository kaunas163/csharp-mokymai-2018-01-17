using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_4_Garazas
{
    class Program
    {
        static void Main(string[] args)
        {
            var garazas = new Garazas("Pas Petra", "Kaunas, kazkur prie visu garazu", 1, new List<Automobilis>
            {
                new Automobilis("Audi", "qwerty", 2000, 320000, 66, 1.6, "juoda"),
                new Automobilis("BMW", "rtyui", 2001, 500453, 80, 1.8, "raudona"),
                new Automobilis("Mercedes", "fghj", 1999, 452931, 120, 2.2, "pilka"),
                new Automobilis("Citroen", "vbnm", 2005, 45935, 50, 1.2, "rozine"),
                new Automobilis("Audi", "yuiop", 2003, 454887, 70, 1.8, "melyna")
            });

            garazas.Isvedimas();
            garazas.Skaiciavimai();
            garazas.AtnaujintiPasirinkta();
        }
    }
}
