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
    }
}
