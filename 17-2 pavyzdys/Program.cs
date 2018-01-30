using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SqlServer.Server;

namespace _17_2_pavyzdys
{
    class Meska
    {
        public string Rusis;  // attribute

        public int Amzius { get; private set; } // property

        public Meska(string rusis) // metodas - konstruktorius
        {
            Rusis = rusis;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var meska = new Meska("hsbdh");
        }
    }
}
