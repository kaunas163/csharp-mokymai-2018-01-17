using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_tarpine_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var darbo_valandos = 8;

            Console.Write("Kiek darbuotojas gali iškepti kepalų per valandą: ");
            var darb_iskepti_per_val = Convert.ToInt32(Console.ReadLine());

            Console.Write("Kiek darbuotojų turi kepykla: ");
            var darbuotoju = Convert.ToInt32(Console.ReadLine());

            Console.Write("Vieno kepalo savikaina: ");
            var savikaina = Convert.ToInt32(Console.ReadLine());

            Console.Write("Vieno kepalo pardavimo kaina: ");
            var pardavimo_kaina = Convert.ToInt32(Console.ReadLine());

            Console.Write("Kiek kepykla turi tą dieną užsakymų:");
            var dienos_uzsakymai = Convert.ToInt32(Console.ReadLine());

            // Suskaičiuoti kiek kepykla per vieną darbo dieną spės iškepti duonos kepalų.
            var per_diena_spes_kepalu = darbo_valandos * darbuotoju * darb_iskepti_per_val;

            // Visu kepalu savikaina
            var visu_savikaina = per_diena_spes_kepalu * savikaina;

            // gautas pajamas pardavus
            var pajamos = per_diena_spes_kepalu * pardavimo_kaina;

            // pelnas
            var pelnas = pajamos - visu_savikaina;

            Console.WriteLine("Suskaičiuoti kiek kepykla per vieną darbo dieną spės iškepti duonos kepalų: " + per_diena_spes_kepalu);

            Console.WriteLine("savikaina: " + visu_savikaina);

            Console.WriteLine("pajamos: " + pajamos);

            Console.WriteLine("pelnas: " + pelnas);

            if (per_diena_spes_kepalu >= dienos_uzsakymai)
            {
                Console.WriteLine("spes");
            }
            else
            {
                Console.WriteLine("nespes, truksta {0} kepalu", dienos_uzsakymai - per_diena_spes_kepalu);
            }
        }
    }
}
