using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P09Indeksery
{
    internal class Zawodnik
    {
        public string Imie {  get; set; }
        public string Nazwisko { get; set; }

        public char this[int a]
        {
            get
            {
                return Nazwisko[a];
            }
        }

          
        public string this[string nazwaWlasciwosci]
        {
            get
            {
                return this.GetType().GetProperty(nazwaWlasciwosci).GetValue(this,null).ToString();
            }
            set
            {
                this.GetType().GetProperty(nazwaWlasciwosci).SetValue(this,value, null);
            }
        }
    }
}
