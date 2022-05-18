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
    public partial class ogrenciTestEkrani : Form
    {
        public ogrenciTestEkrani()
        {
            InitializeComponent();
        }

        HashSet<string> hashSet = new HashSet<string>();

        SqlDataReader dr;
        

        private void geriDön15Btn_Click(object sender, EventArgs e)
        {
            ogrenciEkrani ogrEkran = new ogrenciEkrani();
            ogrEkran.Show();
            this.Hide();
            timer.Stop();
        }


        void soruGetir()
        {
            DataTable ApprovedQuestions = new DataTable();
            SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-K4L20RV;Initial Catalog=sinavSistemi;Integrated Security=True");
            baglanti.Open();
            SqlCommand komut = new SqlCommand("SELECT Top 10 * FROM ApprovedQuestions order by NEWID()", baglanti);
            dr = komut.ExecuteReader();



            while (dr.Read())
            {
                if (hashSet.Contains(dr["QuestionID"].ToString()))
                {
                    continue;
                }
                else
                {
                    hashSet.Add(dr["QuestionID"].ToString());
                }

                soruNoLbl.Text = dr["QuestionID"].ToString();
                uniteNoLbl.Text = dr["UnitID"].ToString();
                bolumNoLbl.Text = dr["SectionID"].ToString();
                soruResmiPictureBox.ImageLocation = dr["PicturePath"].ToString();
                soruLbl.Text = dr["QuestionText"].ToString();
                AoptionRbtn.Text = dr["OptionA"].ToString();
                BoptionRbtn.Text = dr["OptionB"].ToString();
                CoptionRbtn.Text = dr["OptionC"].ToString();
                DoptionRbtn.Text = dr["OptionD"].ToString();

                break;

            }


            baglanti.Close();
        }

        private void ogrenciTestEkrani_Load(object sender, EventArgs e)
        {
            timer.Enabled = true;
            timer.Start();
            soruGetir();
         
            nick.Text = ogrenciGirisEkrani.nick;
            
        }



        int soruSayac=0;
        int dogruSayisi = 0;    //dogru sayi adedini tutar
        int yanlisSayisi = 0; //yanlış sayı adedini tutar
        string selectedOption = "";
        private void sonrakiSoruBtn_Click(object sender, EventArgs e)
        {

            
            if (AoptionRbtn.Checked)
            {   
                selectedOption = AoptionRbtn.Text;
            }
            else if(BoptionRbtn.Checked)
            {
                selectedOption = BoptionRbtn.Text;

            }
            else if(CoptionRbtn.Checked)
            {
                selectedOption = CoptionRbtn.Text;

            }
            else
            {
                selectedOption = DoptionRbtn.Text;
            }

            

            string dogruCevap = ""; //databaseden gelen RightAnwer bilgisini tutar
            String userID=""; // SolvedQuestions tablosuna userID taşımak için oluşturulan değişkenimiz

            SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-K4L20RV;Initial Catalog=sinavSistemi;Integrated Security=True");
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select userID from Users where kullaniciAdi='"+nick.Text+"'", baglanti);
            SqlDataReader dr2;
            dr2 = komut.ExecuteReader();

            while(dr2.Read())
            {
                userID = dr2["userID"].ToString();  
            }
            dr2.Close();
            baglanti.Close();



            SqlConnection baglanti3 = new SqlConnection("Data Source=DESKTOP-K4L20RV;Initial Catalog=sinavSistemi;Integrated Security=True");
            baglanti3.Open();
            SqlCommand komut3 = new SqlCommand("select RightAnswer from ApprovedQuestions where QuestionID='" + soruNoLbl.Text + "'", baglanti3);
            SqlDataReader dr3;
            dr3 = komut3.ExecuteReader();

            while (dr3.Read())
            {
                dogruCevap = dr3["RightAnswer"].ToString();
            }
            dr3.Close();
            baglanti3.Close();

            


            SqlConnection baglanti2 = new SqlConnection("Data Source=DESKTOP-K4L20RV;Initial Catalog=sinavSistemi;Integrated Security=True");
            SqlCommand komut2 = new SqlCommand("insert into SolvedQuestions (userID, QuestionID, kullaniciAdi, selectedOption, QuestionStatus) values (@userID, @QuestionID, @kullaniciAdi, @selectedOption, @QuestionStatus)", baglanti2);
            baglanti2.Open();


            komut2.Parameters.AddWithValue("@userID", userID);
            komut2.Parameters.AddWithValue("@QuestionID", soruNoLbl.Text);
            komut2.Parameters.AddWithValue("@kullaniciAdi", nick.Text);
            komut2.Parameters.AddWithValue("@selectedOption", selectedOption);

            if (selectedOption == dogruCevap)
            {
                komut2.Parameters.AddWithValue("@QuestionStatus", "DOĞRU");
                dogruSayisi++;
            }
            else
            {
                komut2.Parameters.AddWithValue("@QuestionStatus", "YANLIŞ");
                yanlisSayisi++;
            }

            dagruSayisiLbl.Text = dogruSayisi.ToString();
            yanlisSayisiLbl.Text = yanlisSayisi.ToString();
            komut2.ExecuteNonQuery();
            baglanti2.Close();

            

            if (soruSayac == 9)
            {
                MessageBox.Show("sınavınız bitmiştir");
                sonrakiSoruBtn.Enabled = false;

            }
            else
                soruSayac++;

            soruGetir(); // databaseden rastgele soru getiren fonskiyon
            

        }



        int sayac = 600;
        private void timer_Tick(object sender, EventArgs e)
        {

            kalanSureLbl.Text = Convert.ToString(sayac);

            if(sayac==0)
            {
                AoptionRbtn.Enabled = false;
                BoptionRbtn.Enabled = false;
                CoptionRbtn.Enabled = false;
                DoptionRbtn.Enabled = false;
                sonrakiSoruBtn.Enabled = false;
                timer.Enabled = false;
                MessageBox.Show("süre bitmiştir");
            }
            else
            {
                sayac--;
            }

        }
    }
}
