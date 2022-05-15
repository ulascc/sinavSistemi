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
    public partial class adminKullanicilarEkrani : Form
    {
        public adminKullanicilarEkrani()
        {
            InitializeComponent();
        }

        private void geriDön13Btn_Click(object sender, EventArgs e)
        {
            adminEkrani adminEkran = new adminEkrani();
            adminEkran.Show();
            this.Hide();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-K4L20RV;Initial Catalog=sinavSistemi;Integrated Security=True");
        private void adminKullanicilarEkrani_Load(object sender, EventArgs e)
        { 

                SqlCommand komut = new SqlCommand("select * from Users", baglanti);
                SqlDataAdapter da = new SqlDataAdapter(komut);
                DataTable dt = new DataTable();
                da.Fill(dt);
                kullanicilarDataGridView.DataSource = dt;
                kullanicilarDataGridView.AllowUserToAddRows = false;      // kullanıcının veri eklemesini engeller
                    
        }
    }
}
