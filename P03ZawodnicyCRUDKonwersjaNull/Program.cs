using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P03ZawodnicyCRUDKonwersjaNull
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            string b = null;
            string c = "a" + a + b;
            string d = b + a + "a";
            string e = b + a;

            string f = a + b;

         //   string g = a + a;
        }
    }
}
