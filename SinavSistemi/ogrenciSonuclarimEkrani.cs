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
    public partial class ogrenciSonuclarimEkrani : Form
    {
        public ogrenciSonuclarimEkrani()
        {
            InitializeComponent();
        }

        private void geriDön14Btn_Click(object sender, EventArgs e)
        {
            ogrenciEkrani ogrEkran = new ogrenciEkrani();
            ogrEkran.Show();
            this.Hide();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-K4L20RV;Initial Catalog=sinavSistemi;Integrated Security=True");

        // dataBasedeki çözülen soruların form load oldugunda  DataGridView acılması için yazılan fonskiyon
        void loadData()
        {
            string nick = "";
            nick = ogrenciGirisEkrani.nick;

            SqlCommand komut = new SqlCommand("select sq.kullaniciAdi as 'Kullanici', sq.QuestionID as 'Soru No', aq.QuestionText as 'Soru', sq.selectedOption as 'Secilen Cevap', aq.RightAnswer as 'Dogru Cevap', sq.QuestionStatus as 'Soru Durumu' from ApprovedQuestions aq inner join SolvedQuestions sq on aq.QuestionID=sq.QuestionID  where sq.kullaniciAdi='" + nick + "'group by sq.kullaniciAdi, sq.QuestionID,  aq.QuestionText, aq.RightAnswer, sq.selectedOption, sq.QuestionStatus", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            ogrenciCevaplariDataGridView.DataSource = dt;
            ogrenciCevaplariDataGridView.AllowUserToAddRows = false;      // kullanıcının veri eklemesini engeller
            baglanti.Close();
        }


        private void ogrenciSonuclarimEkrani_Load(object sender, EventArgs e)
        {
            loadData();
        }

        Bitmap bitmap;
        private void sonucYazdirBtn_Click(object sender, EventArgs e)
        {
            int height = ogrenciCevaplariDataGridView.Height;
            ogrenciCevaplariDataGridView.Height = ogrenciCevaplariDataGridView.RowCount * ogrenciCevaplariDataGridView.RowTemplate.Height * 2;
            bitmap = new Bitmap(ogrenciCevaplariDataGridView.Width, ogrenciCevaplariDataGridView.Height);
            ogrenciCevaplariDataGridView.DrawToBitmap(bitmap, new Rectangle(0, 0, ogrenciCevaplariDataGridView.Width, ogrenciCevaplariDataGridView.Height));
            printPreviewDialog1.PrintPreviewControl.Zoom = 1;
            printPreviewDialog1.ShowDialog();
            ogrenciCevaplariDataGridView.Height = height;
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bitmap, 0, 0); 
        }
    }
}
