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
    public partial class ogrenciSifremiUnuttumEkrani : Form
    {
        public ogrenciSifremiUnuttumEkrani()
        {
            InitializeComponent();
        }

        
        private void yeniSifreAlBtn_Click(object sender, EventArgs e)
        { 

            MessageBox.Show("yeni şifreniz mailinize gönderilmiştir");
            
        }

        private void geriDön6Btn_Click(object sender, EventArgs e)
        {
            ogrenciGirisEkrani ogrGirisEkrani = new ogrenciGirisEkrani();
            ogrGirisEkrani.Show();
            this.Hide();
        }
    }
}
