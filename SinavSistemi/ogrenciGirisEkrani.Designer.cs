namespace SinavSistemi
{
    partial class ogrenciGirisEkrani
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.kullaniciAdi = new System.Windows.Forms.Label();
            this.sifre = new System.Windows.Forms.Label();
            this.ogrenciKullaniciAdiTextBox = new System.Windows.Forms.TextBox();
            this.ogrenciSifreTextBox = new System.Windows.Forms.TextBox();
            this.ogrGirisBtn = new System.Windows.Forms.Button();
            this.ogrKayitOlBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.geriDön2Btn = new System.Windows.Forms.Button();
            this.ogrSifremiUnuttumLbl = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // kullaniciAdi
            // 
            this.kullaniciAdi.AutoSize = true;
            this.kullaniciAdi.Location = new System.Drawing.Point(99, 46);
            this.kullaniciAdi.Name = "kullaniciAdi";
            this.kullaniciAdi.Size = new System.Drawing.Size(62, 13);
            this.kullaniciAdi.TabIndex = 0;
            this.kullaniciAdi.Text = "kullanıcı adı";
            // 
            // sifre
            // 
            this.sifre.AutoSize = true;
            this.sifre.Location = new System.Drawing.Point(99, 77);
            this.sifre.Name = "sifre";
            this.sifre.Size = new System.Drawing.Size(26, 13);
            this.sifre.TabIndex = 1;
            this.sifre.Text = "şifre";
            // 
            // ogrenciKullaniciAdiTextBox
            // 
            this.ogrenciKullaniciAdiTextBox.Location = new System.Drawing.Point(167, 43);
            this.ogrenciKullaniciAdiTextBox.Name = "ogrenciKullaniciAdiTextBox";
            this.ogrenciKullaniciAdiTextBox.Size = new System.Drawing.Size(100, 20);
            this.ogrenciKullaniciAdiTextBox.TabIndex = 2;
            // 
            // ogrenciSifreTextBox
            // 
            this.ogrenciSifreTextBox.Location = new System.Drawing.Point(167, 74);
            this.ogrenciSifreTextBox.Name = "ogrenciSifreTextBox";
            this.ogrenciSifreTextBox.Size = new System.Drawing.Size(100, 20);
            this.ogrenciSifreTextBox.TabIndex = 3;
            this.ogrenciSifreTextBox.UseSystemPasswordChar = true;
            // 
            // ogrGirisBtn
            // 
            this.ogrGirisBtn.Location = new System.Drawing.Point(192, 118);
            this.ogrGirisBtn.Name = "ogrGirisBtn";
            this.ogrGirisBtn.Size = new System.Drawing.Size(75, 23);
            this.ogrGirisBtn.TabIndex = 4;
            this.ogrGirisBtn.Text = "giris yap";
            this.ogrGirisBtn.UseVisualStyleBackColor = true;
            this.ogrGirisBtn.Click += new System.EventHandler(this.ogrGirisBtn_Click);
            // 
            // ogrKayitOlBtn
            // 
            this.ogrKayitOlBtn.Location = new System.Drawing.Point(283, 118);
            this.ogrKayitOlBtn.Name = "ogrKayitOlBtn";
            this.ogrKayitOlBtn.Size = new System.Drawing.Size(75, 23);
            this.ogrKayitOlBtn.TabIndex = 5;
            this.ogrKayitOlBtn.Text = "kayıt ol";
            this.ogrKayitOlBtn.UseVisualStyleBackColor = true;
            this.ogrKayitOlBtn.Click += new System.EventHandler(this.ogrKayitOlBtn_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(628, 108);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(8, 8);
            this.button1.TabIndex = 6;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // geriDön2Btn
            // 
            this.geriDön2Btn.Location = new System.Drawing.Point(729, 2);
            this.geriDön2Btn.Name = "geriDön2Btn";
            this.geriDön2Btn.Size = new System.Drawing.Size(69, 30);
            this.geriDön2Btn.TabIndex = 7;
            this.geriDön2Btn.Text = "geri dön";
            this.geriDön2Btn.UseVisualStyleBackColor = true;
            this.geriDön2Btn.Click += new System.EventHandler(this.geriDön2Btn_Click);
            // 
            // ogrSifremiUnuttumLbl
            // 
            this.ogrSifremiUnuttumLbl.AutoSize = true;
            this.ogrSifremiUnuttumLbl.Location = new System.Drawing.Point(189, 166);
            this.ogrSifremiUnuttumLbl.Name = "ogrSifremiUnuttumLbl";
            this.ogrSifremiUnuttumLbl.Size = new System.Drawing.Size(77, 13);
            this.ogrSifremiUnuttumLbl.TabIndex = 8;
            this.ogrSifremiUnuttumLbl.TabStop = true;
            this.ogrSifremiUnuttumLbl.Text = "sifremi unuttum";
            this.ogrSifremiUnuttumLbl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ogrSifremiUnuttumLbl_LinkClicked);
            // 
            // ogrenciGirisEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ogrSifremiUnuttumLbl);
            this.Controls.Add(this.geriDön2Btn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ogrKayitOlBtn);
            this.Controls.Add(this.ogrGirisBtn);
            this.Controls.Add(this.ogrenciSifreTextBox);
            this.Controls.Add(this.ogrenciKullaniciAdiTextBox);
            this.Controls.Add(this.sifre);
            this.Controls.Add(this.kullaniciAdi);
            this.Name = "ogrenciGirisEkrani";
            this.Text = "ogrenciGirisEkrani";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label kullaniciAdi;
        private System.Windows.Forms.Label sifre;
        private System.Windows.Forms.TextBox ogrenciSifreTextBox;
        private System.Windows.Forms.Button ogrGirisBtn;
        private System.Windows.Forms.Button ogrKayitOlBtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button geriDön2Btn;
        private System.Windows.Forms.LinkLabel ogrSifremiUnuttumLbl;
        public System.Windows.Forms.TextBox ogrenciKullaniciAdiTextBox;
    }
}