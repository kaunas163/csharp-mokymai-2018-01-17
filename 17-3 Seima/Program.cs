using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_3_Seima
{
    class Program
    {
        static void Main(string[] args)
        {
            /*var zmogus1 = new Zmogus();
            zmogus1.Isvedimas();

            var zmogus2 = new Zmogus("Jonas", "Petraitis", 190, 50, 'v');
            zmogus2.Isvedimas();*/
            
            var seima1 = new Seima("Kaunas", new List<Zmogus>
            {
                new Zmogus("rtyui", "jhghdf", 12, 82, 'm'),
                new Zmogus("sdfdh", "uityu", 45, 10, 'v'),
                new Zmogus("shghd", "dfh", 57, 45, 'v')
            });
            seima1.Isvedimas();

            /*new List<int>
            {
                41,
                4548,
                48
            };*/

            var seima2 = new Seima();
            seima2.Isvedimas();

            var zmones = new List<Zmogus>
            {
                new Zmogus("rtyui", "jhghdf", 12, 82, 'm'),
                new Zmogus("sdfdh", "uityu", 45, 10, 'v'),
                new Zmogus("shghd", "dfh", 57, 45, 'v')
            };

            var seima3 = new Seima("Kaunas", zmones);
            seima3.Isvedimas();
        }
    }
}
