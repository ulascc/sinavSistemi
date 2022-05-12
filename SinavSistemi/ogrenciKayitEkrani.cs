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
    public partial class ogrenciKayitEkrani : Form
    {
        public ogrenciKayitEkrani()
        {
            InitializeComponent();
        }

        private void geriDön4Btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            ogrenciGirisEkrani ogrenciGiris = new ogrenciGirisEkrani();
            ogrenciGiris.Show();
        }

       // static string conString = "Data Source=DESKTOP\\K4L20RV;Initial Catalog=sinavSistemi;Integrated Security=True";
        SqlConnection connect = new SqlConnection("Data Source=DESKTOP-K4L20RV;Initial Catalog=sinavSistemi;Integrated Security=True");

        private void kayitOlBtn_Click(object sender, EventArgs e)
        {
            

            try
            {
                if (connect.State == ConnectionState.Closed)
                    connect.Open();
                  
                //hangi tablo?? UserID elle girildi...

                string kayit = "insert into Users (kullaniciAdi,adi,soyadi,eMail,sifre) values (@kullaniciAdi,@adi,@soyadi,@eMail,@sifre)";
                SqlCommand komut = new SqlCommand(kayit,connect);

                komut.Parameters.AddWithValue("@kullaniciAdi", kullaniciAdiTextBox.Text);
                komut.Parameters.AddWithValue("@adi", isimTextBox.Text);
                komut.Parameters.AddWithValue("@soyadi", soyisimTextBox.Text);
                komut.Parameters.AddWithValue("@eMail", MailTextBox.Text);
                komut.Parameters.AddWithValue("@sifre", sifreTextBox.Text);

                komut.ExecuteNonQuery();
                connect.Close();
                MessageBox.Show("kayıt olundu");
            }
            catch (Exception hata)
            {
                MessageBox.Show("hata oluştu " + hata.Message);
            }
        }
    }
}
