using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P08SlowoStatic
{
    internal class Zawodnik
    {
        public string Imie { get; set; }
        public static string Nazwisko { get; set; }

        public string PrzedstawSie()
        {
            return $"Nazywam sie {Imie} {Nazwisko}";
        }

        public static void PowiedzKimJest()
        {
            Console.WriteLine($"Jestem {Nazwisko}");
        }
    }
}
