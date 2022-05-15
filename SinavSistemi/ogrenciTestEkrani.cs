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

        private void geriDön15Btn_Click(object sender, EventArgs e)
        {
            ogrenciEkrani ogrEkran = new ogrenciEkrani();
            ogrEkran.Show();
            this.Hide();
        }


        private void ogrenciTestEkrani_Load(object sender, EventArgs e)
        {
           
            SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-K4L20RV;Initial Catalog=sinavSistemi;Integrated Security=True");
            SqlCommand komut = new SqlCommand("select top 1* from ApprovedQuestions order by NEWID()", baglanti);
            komut.Connection = baglanti;
            baglanti.Open();
            SqlDataReader dr = komut.ExecuteReader();

            while (dr.Read())
                {

                    uniteNoLbl.Text = dr["UnitID"].ToString();
                    bolumNoLbl.Text = dr["SectionID"].ToString();
                 // soruResmiPictureBox = dr["PicturePath"].ToString();
                    soruLbl.Text = dr["QuestionText"].ToString();
                    AoptionRbtn.Text = dr["OptionA"].ToString();
                    BoptionRbtn.Text = dr["OptionB"].ToString();
                    CoptionRbtn.Text = dr["OptionC"].ToString();
                    DoptionRbtn.Text = dr["OptionD"].ToString();
                    
                    break;
                }
            
            baglanti.Close();

            nick.Text = ogrenciGirisEkrani.nick;
            
        }

        private void sonrakiSoruBtn_Click(object sender, EventArgs e)
        {

            DataTable ApprovedQuestions = new DataTable();

            SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-K4L20RV;Initial Catalog=sinavSistemi;Integrated Security=True");
            SqlCommand komut = new SqlCommand("SELECT Top 5 * FROM ApprovedQuestions", baglanti);
            SqlDataReader dr = komut.ExecuteReader();
            baglanti.Open();


            while (dr.Read())
            {
                
                uniteNoLbl.Text = dr["UnitID"].ToString();
                bolumNoLbl.Text = dr["SectionID"].ToString();
                // soruResmiPictureBox = dr["PicturePath"].ToString();
                soruLbl.Text = dr["QuestionText"].ToString();
                AoptionRbtn.Text = dr["OptionA"].ToString();
                BoptionRbtn.Text = dr["OptionB"].ToString();
                CoptionRbtn.Text = dr["OptionC"].ToString();
                DoptionRbtn.Text = dr["OptionD"].ToString();

                break;

            }

            baglanti.Close();
        }
    }
}
