using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SinavSistemi
{
    public partial class sinavSorumlusuGirisEkrani : Form
    {
        public sinavSorumlusuGirisEkrani()
        {
            InitializeComponent();
        }

        private void geriDönBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 frm1 = new Form1();
            frm1.Show();
        }

        private void sorumluKayitOlBtn_Click(object sender, EventArgs e)
        {
            sinavSorumlusuKayitEkrani sorumluKayit = new sinavSorumlusuKayitEkrani();
            sorumluKayit.Show();
            this.Hide();
        }

        SqlConnection baglanti;
        SqlCommand komut;
        SqlDataReader dr;

        private void sorumluGirisBtn_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = sorumluKullaniciAdiTextBox.Text;
            string sifre = SorumluSifreTextBox.Text;
            baglanti = new SqlConnection("Data Source=DESKTOP-K4L20RV;Initial Catalog=sinavSistemi;Integrated Security=True");
            komut = new SqlCommand();
            baglanti.Open();
            komut.Connection = baglanti;

            komut.CommandText = "select * from Users where kullaniciAdi= '" + sorumluKullaniciAdiTextBox.Text + "' and sifre='" + SorumluSifreTextBox.Text + "'and userTypeID=2";
            dr = komut.ExecuteReader();

            if (dr.Read())
            {
                sinavSorumlusuEkrani sorumluEkran = new sinavSorumlusuEkrani();
                sorumluEkran.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı adını ve şifrenizi kontrol ediniz.");
            }
            baglanti.Close();
        }

        private void sorumluSifremiUnuttumLbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            sinavSorumlusuSifremiUnuttumEkrani sorumluSifremiUnuttum = new sinavSorumlusuSifremiUnuttumEkrani();
            sorumluSifremiUnuttum.Show();
            this.Hide();
        }
    }
}
