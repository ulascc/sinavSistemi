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
    public partial class sinavSorumlusuSifremiUnuttumEkrani : Form
    {
        public sinavSorumlusuSifremiUnuttumEkrani()
        {
            InitializeComponent();
        }

        private void geriDön8Btn_Click(object sender, EventArgs e)
        {
            sinavSorumlusuGirisEkrani sorumluGiris = new sinavSorumlusuGirisEkrani();
            sorumluGiris.Show();
            this.Hide(); 
        }

        private void sorumluYeniSifreAlBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("yeni şifreniz mailinize gönderilmiştir");
        }
    }
}
