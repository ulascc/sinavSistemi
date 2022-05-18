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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ogrenciGirisBtn_Click(object sender, EventArgs e)
        {
            ogrenciGirisEkrani ogrGiris =new ogrenciGirisEkrani();
            ogrGiris.Show();
            this.Hide(); 
  
        }

        private void adminGirisBtn_Click(object sender, EventArgs e)
        {
            adminGirisEkrani adminGiris = new adminGirisEkrani();
            adminGiris.Show();
            this.Hide();
        }

        private void sınavSorumlusuGirisBtn_Click(object sender, EventArgs e)
        {
            sinavSorumlusuGirisEkrani sinavS = new sinavSorumlusuGirisEkrani();
            sinavS.Show();
            this.Hide();
        }
    }
}
