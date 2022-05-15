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
    public partial class adminSoruOnaylamaEkrani : Form
    {
        public adminSoruOnaylamaEkrani()
        {
            InitializeComponent();
        }


        SqlConnection baglanti2 = new SqlConnection("Data Source=DESKTOP-K4L20RV;Initial Catalog=sinavSistemi;Integrated Security=True");
        // dataBasedeki soruların form load oldugunda  DataGridView acılması için yazılan fonskiyon
        void load_data()
        {
            SqlCommand komut = new SqlCommand("select * from Questions",baglanti2);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            sorularDataGridView.DataSource = dt;
            sorularDataGridView.AllowUserToAddRows = false;         // kullanıcının veri eklemesini engeller
            DataGridViewCheckBoxColumn checkRow = new DataGridViewCheckBoxColumn(); // 37-41 kodları satırlara CheckBoxkutucugu ekledi
            checkRow.Width = 40;
            checkRow.Name = "satirSec";
            checkRow.HeaderText = "";
            sorularDataGridView.Columns.Insert(0, checkRow);
            baglanti2.Close();
        }


        private void adminSoruOnaylamaEkrani_Load(object sender, EventArgs e)
        {
            //dataGridView();
            load_data();
        }
        
        private void soruSilBtn_Click(object sender, EventArgs e)
        {

            SqlCommand komut = new SqlCommand();
            baglanti2.Open();
            komut.Connection = baglanti2;
            komut.CommandText = "delete from Questions where QuestionID=" + silinecekSoruTextBox.Text + "";
            komut.ExecuteNonQuery();
            baglanti2.Close();
            load_data();
        }

        private void geriDön12Btn_Click(object sender, EventArgs e)
        {
            adminEkrani adminEkran = new adminEkrani();
            adminEkran.Show();
            this.Hide();
        }

        private void soruOnaylaBtn_Click(object sender, EventArgs e)
        {
            foreach(DataGridViewRow  row in sorularDataGridView.Rows)
            {
                bool secilen = Convert.ToBoolean(row.Cells["satirSec"].Value);

                if(secilen)
                {
                    SqlCommand komut2 = new SqlCommand("insert into ApprovedQuestions (QuestionID, UnitID, SectionID, PicturePath, QuestionText, OptionA, OptionB, OptionC, OptionD, Rightanswer) " +
                        "values (@QuestionID, @UnitID, @SectionID, @PicturePath, @QuestionText, @OptionA, @OptionB, @OptionC, @OptionD, @Rightanswer)", baglanti2);
                    
                    komut2.Parameters.AddWithValue("QuestionID", row.Cells["QuestionID"].Value);
                    komut2.Parameters.AddWithValue("UnitID", row.Cells["UnitID"].Value);
                    komut2.Parameters.AddWithValue("SectionID", row.Cells["SectionID"].Value);
                    komut2.Parameters.AddWithValue("PicturePath", row.Cells["PicturePath"].Value);
                    komut2.Parameters.AddWithValue("QuestionText", row.Cells["QuestionText"].Value);
                    komut2.Parameters.AddWithValue("OptionA", row.Cells["OptionA"].Value);
                    komut2.Parameters.AddWithValue("OptionB", row.Cells["OptionB"].Value);
                    komut2.Parameters.AddWithValue("OptionC", row.Cells["OptionC"].Value);
                    komut2.Parameters.AddWithValue("OptionD", row.Cells["OptionD"].Value);
                    komut2.Parameters.AddWithValue("Rightanswer", row.Cells["Rightanswer"].Value);


                    baglanti2.Open();
                    komut2.ExecuteNonQuery();
                    baglanti2.Close();
                }

                MessageBox.Show("secilen sorular onaylanmıştır");

            }

             

        }
    }
}
