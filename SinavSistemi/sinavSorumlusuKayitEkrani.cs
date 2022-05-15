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
    public partial class sinavSorumlusuKayitEkrani : Form
    {
        public sinavSorumlusuKayitEkrani()
        {
            InitializeComponent();
        }

        SqlConnection connect = new SqlConnection("Data Source=DESKTOP-K4L20RV;Initial Catalog=sinavSistemi;Integrated Security=True");
        private void sorumluKayitOlBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (connect.State == ConnectionState.Closed)
                    connect.Open();

                

                string kayit = "insert into Users (kullaniciAdi,adi,soyadi,eMail,sifre,userTypeID) values (@kullaniciAdi,@adi,@soyadi,@eMail,@sifre,@userTypeID)";
                SqlCommand komut = new SqlCommand(kayit, connect);

                komut.Parameters.AddWithValue("@kullaniciAdi", sorumluKullaniciAdiTextBox.Text);
                komut.Parameters.AddWithValue("@adi", sorumluİsimTextBox.Text);
                komut.Parameters.AddWithValue("@soyadi", sorumluSoyisimTextBox.Text);
                komut.Parameters.AddWithValue("@eMail", sorumluMailTextBox.Text);
                komut.Parameters.AddWithValue("@sifre", sorumluSifreTextBox.Text);
                komut.Parameters.AddWithValue("@userTypeID", 2);

                komut.ExecuteNonQuery();
                connect.Close();
                MessageBox.Show("kayıt olundu");
            }
            catch (Exception hata)
            {
                MessageBox.Show("hata oluştu " + hata.Message);
            }
        }

        private void geriDön7Btn_Click(object sender, EventArgs e)
        {
            sinavSorumlusuGirisEkrani sorumluGiris = new sinavSorumlusuGirisEkrani();
            sorumluGiris.Show();
            this.Hide();
        }
    }
}
