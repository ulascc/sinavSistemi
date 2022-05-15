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
    public partial class sinavSorumlusuSoruEKleEkrani : Form
    {
        public sinavSorumlusuSoruEKleEkrani()
        {
            InitializeComponent();
        }

        private void geriDön11Btn_Click(object sender, EventArgs e)
        {
            sinavSorumlusuEkrani sorumluEkran = new sinavSorumlusuEkrani();
            sorumluEkran.Show();
            this.Hide();
        }

        private void temizleTextBox_Click(object sender, EventArgs e)
        {
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                        (control as TextBox).Clear();
                    else
                        func(control.Controls);
            };

            func(Controls);
        }

        private void soruResimSecBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openDialog = new OpenFileDialog();
            openDialog.ShowDialog();

            soruResimPictureBox.ImageLocation = openDialog.FileName;
            soruResimYoluTextBox.Text = openDialog.FileName;

        }

        SqlConnection connect = new SqlConnection("Data Source=DESKTOP-K4L20RV;Initial Catalog=sinavSistemi;Integrated Security=True");

        private void soruEkleTextBox_Click(object sender, EventArgs e)
        {

            if(ATextBox.Text== DogruCevapTextBox.Text || BTextBox.Text == DogruCevapTextBox.Text || CTextBox.Text == DogruCevapTextBox.Text || DTextBox.Text == DogruCevapTextBox.Text)
            {
                try
                {
                    if (connect.State == ConnectionState.Closed)
                        connect.Open();


                    string kayit = "insert into Questions (UnitID, SectionID, PicturePath, QuestionText,OptionA, OptionB, OptionC, OptionD,RightAnswer) " +
                                                  "values (@UnitID, @SectionID, @PicturePath, @QuestionText,@OptionA, @OptionB, @OptionC, @OptionD, @RightAnswer)";
                    SqlCommand komut = new SqlCommand(kayit, connect);

                    komut.Parameters.AddWithValue("@UnitID", UniteNoTextBox.Text);
                    komut.Parameters.AddWithValue("@SectionID", bolumNoTextBox.Text);
                    komut.Parameters.AddWithValue("@PicturePath", soruResimYoluTextBox.Text);
                    komut.Parameters.AddWithValue("@QuestionText", soruRichTextBox.Text);
                    komut.Parameters.AddWithValue("@OptionA", ATextBox.Text);
                    komut.Parameters.AddWithValue("@OptionB", BTextBox.Text);
                    komut.Parameters.AddWithValue("@OptionC", CTextBox.Text);
                    komut.Parameters.AddWithValue("@OptionD", DTextBox.Text);
                    komut.Parameters.AddWithValue("@RightAnswer", DogruCevapTextBox.Text);


                    komut.ExecuteNonQuery();
                    connect.Close();
                    MessageBox.Show("soru eklenmiştir");
                }
                catch (Exception hata)
                {
                    MessageBox.Show("hata oluştu " + hata.Message);
                }
            }
            else
            {
                MessageBox.Show("dogru cevap şıklarda yok");
            }

        }
    }
}
