using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LotoAplikacija
{
    public partial class FrmLoto : Form
    {
        private Loto loto;
        public FrmLoto()
        {
            InitializeComponent();
            loto = new Loto();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnUplati_Click(object sender, EventArgs e)
        {
            List<string> vrijednosti = new List<string>();
            vrijednosti.Add(txtUplaceniBroj1.Text);
            vrijednosti.Add(txtUplaceniBroj2.Text);
            vrijednosti.Add(txtUplaceniBroj3.Text);
            vrijednosti.Add(txtUplaceniBroj4.Text);
            vrijednosti.Add(txtUplaceniBroj5.Text);
            vrijednosti.Add(txtUplaceniBroj6.Text);
            vrijednosti.Add(txtUplaceniBroj7.Text);
            bool ispravnaKombinacija = loto.UnesiUplaceneBrojeve(vrijednosti);
            if (ispravnaKombinacija == true)
            {
                btnOdigraj.Enabled = true;
            }
            else {
                btnOdigraj.Enabled = false;
                MessageBox.Show("Kombinacija uplacenih nije valja. NE VALJA, NE VALJA, NE VALJA !!!");
            }
        }

        private void btnOdigraj_Click(object sender, EventArgs e)
        {
            loto.GenenrirajDobitnuKombinaciju();
            txtDobitniBroj1.Text = loto.DobitniBrojevi[0].ToString();
            txtDobitniBroj2.Text = loto.DobitniBrojevi[1].ToString();
            txtDobitniBroj3.Text = loto.DobitniBrojevi[2].ToString();
            txtDobitniBroj4.Text = loto.DobitniBrojevi[3].ToString();
            txtDobitniBroj5.Text = loto.DobitniBrojevi[4].ToString();
            txtDobitniBroj6.Text = loto.DobitniBrojevi[5].ToString();
            txtDobitniBroj7.Text = loto.DobitniBrojevi[6].ToString();
            int brojPogodaka = loto.IzracunajBrojPogodaka();
            lblBrojPogodaka.Text = brojPogodaka.ToString();
        }

    }
}
