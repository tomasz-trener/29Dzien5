using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace P03ZawodnicyCRUD
{
    public class ManagerZawodnikow
    {
        private Zawodnik[] zawodnicyCache; 
        public Zawodnik[] WczytajZawodnikow()
        {
            string url = "http://tomaszles.pl/wp-content/uploads/2019/06/zawodnicy.txt";

            WebClient wc = new WebClient();
            string dane = wc.DownloadString(url);

            string[] wiersze = dane.Split(new string[1] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);
            Zawodnik[] zawodnicy = new Zawodnik[wiersze.Length - 1];

            for (int i = 1; i < wiersze.Length; i++)
            {
                string[] komorki = wiersze[i].Split(';');
                Zawodnik z = new Zawodnik();
                z.Id_zawodnika = Convert.ToInt32(komorki[0]);

                if (!string.IsNullOrEmpty(komorki[1]))
                    z.Id_trenera = Convert.ToInt32(komorki[1]);

                z.Imie = komorki[2];
                z.Nazwisko = komorki[3];
                z.Kraj = komorki[4];
                z.DataUrodzenia = Convert.ToDateTime(komorki[5]);
                z.Wzrost = Convert.ToInt32(komorki[6]);
                z.Waga = Convert.ToInt32(komorki[7]);

                zawodnicy[i - 1] = z;
            }
            zawodnicyCache = zawodnicy;
            return zawodnicy;
        }

        public string[] PodajKraje()
        {
            // unikam ponownego wczytywania danych dzieki zastosowaniu cachu 
            //   Zawodnik[] zawodnicy = WczytajZawodnikow();
            if (zawodnicyCache == null)
                throw new Exception("Najpierw wczytaj zawodnikow");
            
            Zawodnik[] zawodnicy = zawodnicyCache;

            HashSet<string> kraje = new HashSet<string>();
            foreach (var z in zawodnicy)
                kraje.Add(z.Kraj);

            List<string> posortowaneKraje = kraje.ToList();
            posortowaneKraje.Sort(); // sortowanie alfabetyczne 
//            posortowaneKraje.Reverse(); // ewentualnie mozna odwrocic kolejnosc 

            return posortowaneKraje.ToArray();

        }

        public Zawodnik[] PodajZawodnikow(string kraj)
        {
            List<Zawodnik> zawodnicy = new List<Zawodnik>();
            foreach (var z in zawodnicyCache )
                if(z.Kraj == kraj)
                    zawodnicy.Add(z);

            posrotujZawodnikowPoNazwisku(zawodnicy);
            return zawodnicy.ToArray();
        }

        private void posrotujZawodnikowPoNazwisku(List<Zawodnik> zawodnicy)
        {
            for (int i = 0; i < zawodnicy.Count-1; i++)
            {
                for (int j = 0; j < zawodnicy.Count-1-i; j++)
                {
                    if (string.Compare(zawodnicy[j].Nazwisko, zawodnicy[j+1].Nazwisko) > 0)
                    {
                        Zawodnik temp = zawodnicy[j];
                        zawodnicy[j] = zawodnicy[j+1];
                        zawodnicy[j+1] = temp;
                    }
                }
            }
        }

        public double PodajSredniWzrost(string kraj)
        {
            Zawodnik[] zawodnicy = PodajZawodnikow(kraj);

            double suma = 0;
            foreach (var zawodnik in zawodnicy)
                suma += zawodnik.Wzrost;

            return suma / zawodnicy.Length;
        }
    }
}
