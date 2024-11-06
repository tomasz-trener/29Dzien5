using P08ZadanieFiltorwanieDanych;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P03ZawodnicyCRUD
{
    public partial class FrmStartowy : Form
    {
        ManagerZawodnikow mz = new ManagerZawodnikow();
        
        public FrmStartowy()
        {
            InitializeComponent();

            mz.WczytajZawodnikow();
            cbKraje.DataSource = mz.PodajKraje();
        }

        public void Odswiez()
        {
            mz.WczytajZawodnikow();
            cbKraje.DataSource = mz.PodajKraje();
        }
      

        private void btnTemperatuara_Click(object sender, EventArgs e)
        {
            // chcemy odczytac, który zawodnik jest akutalnie zaznaczony 
            Zawodnik zaznaczony = (Zawodnik)lbDane.SelectedItem;

            ManagerPogody mp = new ManagerPogody(Jednostka.Celsjusz);
            double temp = mp.PodajTemperature(zaznaczony.Kraj);

            lblRaport.Text = string.Format("W kraju {0}, skąd pochodzi zawodnik {1} temepratura wynosi {2}",
                zaznaczony.Kraj, zaznaczony.ImieNazwisko, temp);

            int rozmiar = this.Width;
            lblRaport.MaximumSize = new Size(rozmiar - 45, 0);
            lblRaport.AutoSize = true;
        
        }

        private void cbKraje_SelectedIndexChanged(object sender, EventArgs e)
        {
            string zaznaczonyKraj = (string)cbKraje.SelectedItem;

            if(zaznaczonyKraj != null)
            {
                lbDane.DataSource = mz.PodajZawodnikow(zaznaczonyKraj);
                lbDane.DisplayMember = "ImieNazwisko";

                double wzrost = mz.PodajSredniWzrost(zaznaczonyKraj);
                lblRaportWzrost.Text = string.Format("Sredni wzrost : {0:0.00} cm", wzrost);
            }

           
        }

        private void btnSzczegoly_Click(object sender, EventArgs e)
        {
            Zawodnik zawodnik = (Zawodnik)lbDane.SelectedItem;
            FrmSzczegoly frmSzczegoly = new FrmSzczegoly(zawodnik, mz, this, TrybOkienka.Edycja);
            frmSzczegoly.Show();
        }

        private void btnNowy_Click(object sender, EventArgs e)
        {
            Zawodnik z = new Zawodnik()
            {
                DataUrodzenia = DateTime.Now,
            };
            FrmSzczegoly frmSzczegoly = new FrmSzczegoly(z, mz, this, TrybOkienka.Dodawanie);
            frmSzczegoly.Show();
        }
    }
}
