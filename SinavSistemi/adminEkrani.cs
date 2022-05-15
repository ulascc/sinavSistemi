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
    public partial class adminEkrani : Form
    {
        public adminEkrani()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            adminSoruOnaylamaEkrani adminSoruOnaylama = new adminSoruOnaylamaEkrani();
            adminSoruOnaylama.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            adminKullanicilarEkrani adminKullanici = new adminKullanicilarEkrani();
            adminKullanici.Show();
            this.Hide();
        }

        private void adminCıkısYapBtn_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            this.Hide();
        }
    }
}
