using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P08SlowoStatic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Zawodnik z = new Zawodnik();
            z.Imie = "Jan";
            Zawodnik.Nazwisko = "Kowalski";

            Console.WriteLine(z.PrzedstawSie());

            Zawodnik.Nazwisko = "Nowak";
            Zawodnik z2 = new Zawodnik();
            z2.Imie = "Adam";

            Console.WriteLine(z2.PrzedstawSie());

            Zawodnik.PowiedzKimJest();

            Console.ReadLine();

        }
    }
}
