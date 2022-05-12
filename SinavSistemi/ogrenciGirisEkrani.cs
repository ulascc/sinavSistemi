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
    public partial class ogrenciGirisEkrani : Form
    {
        public ogrenciGirisEkrani()
        {
            InitializeComponent();
        }

        private void ogrKayitOlBtn_Click(object sender, EventArgs e)
        {
            ogrenciKayitEkrani ogrKayit = new ogrenciKayitEkrani();
            ogrKayit.Show();
            this.Hide();
        }

        private void geriDön2Btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 frm1 = new Form1();
            frm1.Show();
        }


        SqlConnection baglanti;
        SqlCommand komut;
        SqlDataReader dr;

        private void ogrGirisBtn_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = ogrenciKullaniciAdiTextBox.Text;
            string sifre = ogrenciSifreTextBox.Text;
            baglanti = new SqlConnection("Data Source=DESKTOP-K4L20RV;Initial Catalog=sinavSistemi;Integrated Security=True");
            komut = new SqlCommand();
            baglanti.Open();
            komut.Connection = baglanti;

            komut.CommandText = "select * from Users where kullaniciAdi= '" + ogrenciKullaniciAdiTextBox.Text + "' and sifre='" + ogrenciSifreTextBox.Text + "'";
            dr = komut.ExecuteReader();

            if (dr.Read())
            {
                ogrenciEkrani ogrEkrani = new ogrenciEkrani();
                ogrEkrani.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı adını ve şifrenizi kontrol ediniz.");
            }
            baglanti.Close();
        }
    }
}
