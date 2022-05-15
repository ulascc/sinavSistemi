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
    public partial class adminGirisEkrani : Form
    {
        public adminGirisEkrani()
        {
            InitializeComponent();
        }

        private void geriDön3Btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 frm1 = new Form1();
            frm1.Show();
        }

        private void adminKayitOlBtn_Click(object sender, EventArgs e)
        {
            adminKayitEkrani adminKayit = new adminKayitEkrani();
            adminKayit.Show();
            this.Hide();
        }

        SqlConnection baglanti;
        SqlCommand komut;
        SqlDataReader dr;

        private void adminGirisBtn_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = adminKullaniciAdiTextBox.Text;
            string sifre = adminSifreTextBox.Text;
            baglanti = new SqlConnection("Data Source=DESKTOP-K4L20RV;Initial Catalog=sinavSistemi;Integrated Security=True");
            komut = new SqlCommand();
            baglanti.Open();
            komut.Connection = baglanti;

            komut.CommandText = "select * from Users where kullaniciAdi= '" + adminKullaniciAdiTextBox.Text + "' and sifre='" + adminSifreTextBox.Text + "'and userTypeID=3";
            dr = komut.ExecuteReader();

            if (dr.Read())
            {
                adminEkrani adminEkran = new adminEkrani();
                adminEkran.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı adını ve şifrenizi kontrol ediniz.");
            }
            baglanti.Close();

        }

        private void adminSifremiUnuttumLbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            adminSifremiUnuttumEkrani adminSifremiUnuttum = new adminSifremiUnuttumEkrani();
            adminSifremiUnuttum.Show();
            this.Hide();
        }
    }
}


