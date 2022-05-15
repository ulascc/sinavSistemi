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
    public partial class ogrenciEkrani : Form
    {
        public ogrenciEkrani()
        {
            InitializeComponent();
        }

        private void testeBaslaBtn_Click(object sender, EventArgs e)
        {
            ogrenciTestEkrani ogrTest = new ogrenciTestEkrani();
            ogrTest.Show();
            this.Hide();
        }

        private void ogrenciCıkısYapBtn_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            this.Hide();
        }

        private void ogrenciSonuclarımBtn_Click(object sender, EventArgs e)
        {
            ogrenciSonuclarimEkrani ogrSonuclarim = new ogrenciSonuclarimEkrani();
            ogrSonuclarim.Show();
            this.Hide();
        }
    }
}
