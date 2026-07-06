using P02PolaczenieZBaza;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P05KontrolkaDataGridView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnWyslij_Click(object sender, EventArgs e)
        {
            dgvDane.Rows.Clear();

            PolaczenieZBaza pzb= new PolaczenieZBaza();

            (string[] naglowki, object[][] wynik) =pzb.WyslijPolecenieSQLPlusNaglowki(txtPolecenieSQL.Text);

            dgvDane.ColumnCount = wynik[0].Length;

            for (int i = 0; i < naglowki.Length; i++)
                dgvDane.Columns[i].HeaderText = naglowki[i];

            foreach (var wiersz in wynik)
                dgvDane.Rows.Add(wiersz);

        }
    }
}
