﻿using System;
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
    public partial class sinavSorumlusuGirisEkrani : Form
    {
        public sinavSorumlusuGirisEkrani()
        {
            InitializeComponent();
        }

        private void geriDönBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 frm1 = new Form1();
            frm1.Show();
        }
    }
}
