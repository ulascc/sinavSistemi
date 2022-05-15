using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
    }
}
