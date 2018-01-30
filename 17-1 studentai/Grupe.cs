using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_1_studentai
{
    class Grupe
    {
        // studentu sarasas / objektu sarasas / objektu rinkinys
        // = new list... reikia, nes reikia pirmosios saraso rodykles ram'uose
        // kitaip neis deti duomenu i sarasas
        // List<Studentas> - sarase esanciu visu elementu tipas Studento klases, t.y.
        // yra dedami objektai i sarasa
        public List<Studentas> Studentai { get; set; } = new List<Studentas>();

        // galima sarasas inicializuoti ir konstruktoriuje
        // bet jei bus keli skirtingi konstruktoriai, gali buti sunku
        // visuose juose sugaudyti butinus dalykus
        /*public Grupe()
        {
            Studentai = new List<Studentas>();
        }*/

        // tuscias grupes konstruktorius
        public Grupe()
        {
            // studentai.add(kuriamas naujas studento objektas naudojant jo konstruktoriu)
            // Studentai yra studentu sarasas, esantis grupes klaseje
            Studentai.Add(new Studentas("Tom", "Smith", 180, 20, 'v'));
            Studentai.Add(new Studentas("Jerry", "Jerysimo", 180, 23, 'v'));
            Studentai.Add(new Studentas("Angela", "Mitt", 160, 21, 'm'));
            Studentai.Add(new Studentas("William", "Smith", 175, 19, 'v'));
            Studentai.Add(new Studentas("Jessica", "Montero", 155, 24, 'm'));

            // galima kurti objekta atskirai ir tada deti i sarasa
            // bet nebutina daryti tokiu dvieju zingsniu atskirai
            var studentas = new Studentas("Tom", "Jerry", 30, 40, 'v');
            Studentai.Add(studentas);
        }

        // grupes klases isvedimas
        public void Isvedimas()
        {
            Console.WriteLine("Studentai");

            // eina per studentu sarasas, kiekviena karta issiskirdamas
            // atskira studenta is saraso
            foreach (var studentas in Studentai)
            {
                // naudoja studento isvedimo metoda / isvedimo metoda
                // esanti studento klaseje
                studentas.Isvedimas();
            }

            Console.WriteLine("Skaiciavimai");

            Console.WriteLine("Zemiausias studentas");

            var zemiausias = ZemiausiasStudentas();
            zemiausias.Isvedimas();

            //ZemiausiasStudentas().Isvedimas(); // objektas.jo_metodas

        } // grupe klases isvedimo metodo pabaiga

        // grupes klaseje nauji metodai:

        // zemiausias studentas
        // ras zemiausia studenta ir grazins visa rasto studento objekta
        public Studentas ZemiausiasStudentas()
        {
            var zemiausias = Studentai.First();
            //dar galima: var zemiausias = Studentai[0];

            // eina per studentu sarasa
            foreach (var studentas in Studentai)
            {
                // lygina pagal tam tikras studentu SAVYBES
                if (studentas.UgisCM < zemiausias.UgisCM)
                {
                    // priskiria visa OBJEKTA
                    zemiausias = studentas;
                }
            }

            // grazina visa objekta
            return zemiausias;
        }

        // vyriausias studentas
        // kiek moteru
        // kiek vyru
        // amziu vidurkis
    }
}
