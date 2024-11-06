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
        Zawodnik wyswietlanyZawodnik;
        ManagerZawodnikow mz;
        FrmStartowy frmStartowy;
        public FrmSzczegoly(Zawodnik zawodnik, ManagerZawodnikow mz, FrmStartowy frmStartowy )
        {
            InitializeComponent();

            this.wyswietlanyZawodnik = zawodnik;
            this.mz = mz;
            this.frmStartowy = frmStartowy;

            txtImie.Text = zawodnik.Imie;
            txtNazwisko.Text = zawodnik.Nazwisko;
            txtKraj.Text = zawodnik.Kraj;
            dtpDataUr.Value = zawodnik.DataUrodzenia;
            numWzrost.Value = zawodnik.Wzrost;
            numWaga.Value = zawodnik.Waga;
        }


        private void btnZapisz_Click(object sender, EventArgs e)
        {
            wyswietlanyZawodnik.Imie = txtImie.Text;
            wyswietlanyZawodnik.Nazwisko = txtNazwisko.Text;
            wyswietlanyZawodnik.Kraj = txtKraj.Text;
            wyswietlanyZawodnik.DataUrodzenia = dtpDataUr.Value;
            wyswietlanyZawodnik.Waga = Convert.ToInt32(numWaga.Value);
            wyswietlanyZawodnik.Wzrost = Convert.ToInt32(numWzrost.Value);

            mz.Zapisz();
        }

        private void btnUsun_Click(object sender, EventArgs e)
        {
           DialogResult dr= MessageBox.Show($"Czy napewno chcesz usunać zawodika {wyswietlanyZawodnik.ImieNazwisko} ?", "Usuwanie",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes) 
            {
                mz.Usun(wyswietlanyZawodnik.Id_zawodnika);
                this.Close();
                mz.Zapisz();
                frmStartowy.Odswiez();

            }

        }
    }
}
