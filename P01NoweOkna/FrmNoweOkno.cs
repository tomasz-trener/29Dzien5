using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P01NoweOkna
{
    public partial class FrmNoweOkno : Form
    {
        FrmStartowy frmStartowy;
        public FrmNoweOkno(FrmStartowy frmStartowy)
        {
            this.frmStartowy = frmStartowy;
            InitializeComponent();
        }

        public TextBox TxtFrmNoweOknoWiadomosc
        {
            get
            {
                return txtFrmNoweOknoWiadomosc;
            }
        }

        // następnie chcemy z poziomu nowego okna odwołać się
        // do okna statowego. jak to zrobić ? 

        private void btnWyslij_Click(object sender, EventArgs e)
        {
            frmStartowy.TxtFormularzStartowyWiadomosc.Text =
                txtFrmNoweOknoWiadomosc.Text;
        }

        private void btnOdbierz_Click(object sender, EventArgs e)
        {
            txtFrmNoweOknoWiadomosc.Text =
                frmStartowy.TxtFormularzStartowyWiadomosc.Text;
        }
    }
}
