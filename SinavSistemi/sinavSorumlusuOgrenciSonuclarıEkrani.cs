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
    public partial class sinavSorumlusuOgrenciSonuclarıEkrani : Form
    {
        public sinavSorumlusuOgrenciSonuclarıEkrani()
        {
            InitializeComponent();
        }

        private void geriDön9Btn_Click(object sender, EventArgs e)
        {
            sinavSorumlusuEkrani sorumluEkran = new sinavSorumlusuEkrani();
            sorumluEkran.Show();
            this.Hide();
        }
       
        private void sinavSorumlusuOgrenciSonuclarıEkrani_Load(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-K4L20RV;Initial Catalog=sinavSistemi;Integrated Security=True");
            SqlCommand komut = new SqlCommand("select sq.kullaniciAdi as 'Kullanici', sq.QuestionStatus as 'soru durumu',count (sq.QuestionStatus) as 'D/Y sayısı'"+
            "from ApprovedQuestions aq inner join SolvedQuestions sq on aq.QuestionID=sq.QuestionID group by sq.QuestionStatus, sq.kullaniciAdi", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            ogrenciSonuclariDataGridView.DataSource = dt;
            ogrenciSonuclariDataGridView.AllowUserToAddRows = false;      // kullanıcının veri eklemesini engeller
  

        }
    }
}
