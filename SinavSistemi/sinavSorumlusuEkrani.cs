using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SinavSistemi
{
    public partial class sinavSorumlusuEkrani : Form
    {
        public sinavSorumlusuEkrani()
        {
            InitializeComponent();
        }

        private void sorumluSoruEkleBtn_Click(object sender, EventArgs e)
        {
            sinavSorumlusuSoruEKleEkrani sorumluSoruEkle = new sinavSorumlusuSoruEKleEkrani();
            sorumluSoruEkle.Show();
            this.Hide();
        }

        private void sorumluOgrenciSonuclariBtn_Click(object sender, EventArgs e)
        {
            sinavSorumlusuOgrenciSonuclarıEkrani sorumluOgrSonucları = new sinavSorumlusuOgrenciSonuclarıEkrani();
            sorumluOgrSonucları.Show();
            this.Hide();
        }

        private void sorumluCıkısBtn_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            this.Hide();
        }
    }
}
