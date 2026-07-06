using P04Zawodnicy.Shared.Domain;
using P04Zawodnicy.Shared.Services;
using System;
using System.Windows.Forms;

namespace P03AplikacjaBazodanowaZawodnicy
{
    public partial class FrmStartowy : Form
    {
        ManagerZawodnikow mz;
        public FrmStartowy()
        {

            InitializeComponent();

            mz = new ManagerZawodnikow();
            
            lbDane.DataSource = 
                mz.WczytajZawodnikow();
           
            cbKraje.DataSource = mz.PodajKraje();

        }

        private void btnSzczegoly_Click(object sender, EventArgs e)
        {
            Zawodnik zawodnik = (Zawodnik)lbDane.SelectedItem;
            FrmSzczegoly frmSzczegoly = new FrmSzczegoly(TrybOkna.Edycja,mz,this, zawodnik);
            frmSzczegoly.Show();
        }



        private void cbKraje_SelectedIndexChanged(object sender, EventArgs e)
        {
            string zaznaczonyKraj = (string)cbKraje.SelectedItem;

            lbDane.DataSource = mz.PodajZawodnikow(zaznaczonyKraj);
            lbDane.DisplayMember = "ImieNazwisko";
        }

        private void btnNowy_Click(object sender, EventArgs e)
        {
            FrmSzczegoly frmSzczegoly = new FrmSzczegoly(TrybOkna.Dodawanie, mz,this);
            frmSzczegoly.Show();
        }

        private void btnOdswiez_Click(object sender, EventArgs e)
        {
            OdswiezDane("AUT");
        }

        public void OdswiezDane(string kraj)
        {
            lbDane.DataSource = null;
            lbDane.DataSource = mz.PodajZawodnikow(kraj);
            lbDane.DisplayMember = "ImieNazwisko";
        }

        private void btnGenerujPDF_Click(object sender, EventArgs e)
        {
            Zawodnik[] zawodnicy = (Zawodnik[])lbDane.DataSource;

            if (zawodnicy == null || zawodnicy.Length == 0)
            {
                MessageBox.Show("Pusty zbiór danych", "Ostrzeżenie", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Pliki pdf (*.pdf)|*.pdf";
            sfd.Title = "Wskaż miejsce zapisu raportu PDF";
            sfd.InitialDirectory = "C:\\dane";
            sfd.FileName = cbKraje.Text + "_" + DateTime.Now.ToString("ssmmhhddMMyy");

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                PDFManager pm = new PDFManager(sfd.FileName);
                pm.WygenerujPDF(zawodnicy);
            }
        }
    }
}
