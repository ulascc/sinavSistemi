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
    public partial class adminSifremiUnuttumEkrani : Form
    {
        public adminSifremiUnuttumEkrani()
        {
            InitializeComponent();
        }

        private void adminYeniSifreAlBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("yeni şifreniz mailinize gönderilmiştir");
        }

        private void geriDön17Btn_Click(object sender, EventArgs e)
        {
            adminGirisEkrani adminGiris = new adminGirisEkrani();
            adminGiris.Show();
            this.Hide();
        }
    }
}
