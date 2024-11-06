using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace P10KonwertowanieARzutowane
{
    class Zawodnik
    {
        public string Imie { get; set; }
    }
    class Krzeslo 
    {
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            string a = "5";

            int b = Convert.ToInt32(a); // przerobienie jednego typu na inny typ 

            object c = (object)a;  // rzutowanie czyli potraktowanie napisu jako object 

            Zawodnik z = new Zawodnik() { Imie = "Jan" };
            object d = z; // rzutowanie (niejawne) 

            string imie = ((Zawodnik)d).Imie; // rztowanie jawne jest konieczne 

            Zawodnik z2 = (Zawodnik)d; // rzutowanie jawne 


            //Krzeslo k = (Krzeslo)d; // nie moge tak rzutowac bo krzeslo nie jest zawodnikiem 

            //Krzeslo k2 = Convert.ToKrzeslo(z);

        }
    }
}
