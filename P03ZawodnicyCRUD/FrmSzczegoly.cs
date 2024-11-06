using P03ZawodnicyCRUD;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P08ZadanieFiltorwanieDanych
{
    public partial class FrmSzczegoly : Form
    {
        Zawodnik zawodnik;
        ManagerZawodnikow mz;
        public FrmSzczegoly(Zawodnik zawodnik, ManagerZawodnikow mz)
        {
            InitializeComponent();

            this.zawodnik = zawodnik;
            this.mz = mz;

            txtImie.Text = zawodnik.Imie;
            txtNazwisko.Text = zawodnik.Nazwisko;
            txtKraj.Text = zawodnik.Kraj;
            dtpDataUr.Value = zawodnik.DataUrodzenia;
            numWzrost.Value = zawodnik.Wzrost;
            numWaga.Value = zawodnik.Waga;
        }


        private void btnZapisz_Click(object sender, EventArgs e)
        {
            zawodnik.Imie = txtImie.Text;
            zawodnik.Nazwisko = txtNazwisko.Text;
            zawodnik.Kraj = txtKraj.Text;
            zawodnik.DataUrodzenia = dtpDataUr.Value;
            zawodnik.Waga = Convert.ToInt32(numWaga.Value);
            zawodnik.Wzrost = Convert.ToInt32(numWzrost.Value);

            mz.Zapisz();
        }
    }
}
