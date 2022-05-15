namespace SinavSistemi
{
    partial class adminGirisEkrani
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
            this.geriDön3Btn = new System.Windows.Forms.Button();
            this.adminGirisBtn = new System.Windows.Forms.Button();
            this.adminSifreTextBox = new System.Windows.Forms.TextBox();
            this.adminKullaniciAdiTextBox = new System.Windows.Forms.TextBox();
            this.AdminSifre = new System.Windows.Forms.Label();
            this.adminKullaniciAdi = new System.Windows.Forms.Label();
            this.adminKayitOlBtn = new System.Windows.Forms.Button();
            this.adminSifremiUnuttumLbl = new System.Windows.Forms.LinkLabel();
            this.sinavSistemiDataSet1 = new SinavSistemi.sinavSistemiDataSet();
            ((System.ComponentModel.ISupportInitialize)(this.sinavSistemiDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // geriDön3Btn
            // 
            this.geriDön3Btn.Location = new System.Drawing.Point(724, 1);
            this.geriDön3Btn.Name = "geriDön3Btn";
            this.geriDön3Btn.Size = new System.Drawing.Size(75, 23);
            this.geriDön3Btn.TabIndex = 0;
            this.geriDön3Btn.Text = "geri dön";
            this.geriDön3Btn.UseVisualStyleBackColor = true;
            this.geriDön3Btn.Click += new System.EventHandler(this.geriDön3Btn_Click);
            // 
            // adminGirisBtn
            // 
            this.adminGirisBtn.Location = new System.Drawing.Point(176, 142);
            this.adminGirisBtn.Name = "adminGirisBtn";
            this.adminGirisBtn.Size = new System.Drawing.Size(75, 23);
            this.adminGirisBtn.TabIndex = 10;
            this.adminGirisBtn.Text = "giris yap";
            this.adminGirisBtn.UseVisualStyleBackColor = true;
            this.adminGirisBtn.Click += new System.EventHandler(this.adminGirisBtn_Click);
            // 
            // adminSifreTextBox
            // 
            this.adminSifreTextBox.Location = new System.Drawing.Point(151, 98);
            this.adminSifreTextBox.Name = "adminSifreTextBox";
            this.adminSifreTextBox.Size = new System.Drawing.Size(100, 20);
            this.adminSifreTextBox.TabIndex = 9;
            this.adminSifreTextBox.UseSystemPasswordChar = true;
            // 
            // adminKullaniciAdiTextBox
            // 
            this.adminKullaniciAdiTextBox.Location = new System.Drawing.Point(151, 67);
            this.adminKullaniciAdiTextBox.Name = "adminKullaniciAdiTextBox";
            this.adminKullaniciAdiTextBox.Size = new System.Drawing.Size(100, 20);
            this.adminKullaniciAdiTextBox.TabIndex = 8;
            // 
            // AdminSifre
            // 
            this.AdminSifre.AutoSize = true;
            this.AdminSifre.Location = new System.Drawing.Point(83, 101);
            this.AdminSifre.Name = "AdminSifre";
            this.AdminSifre.Size = new System.Drawing.Size(26, 13);
            this.AdminSifre.TabIndex = 7;
            this.AdminSifre.Text = "şifre";
            // 
            // adminKullaniciAdi
            // 
            this.adminKullaniciAdi.AutoSize = true;
            this.adminKullaniciAdi.Location = new System.Drawing.Point(83, 70);
            this.adminKullaniciAdi.Name = "adminKullaniciAdi";
            this.adminKullaniciAdi.Size = new System.Drawing.Size(62, 13);
            this.adminKullaniciAdi.TabIndex = 6;
            this.adminKullaniciAdi.Text = "kullanıcı adı";
            // 
            // adminKayitOlBtn
            // 
            this.adminKayitOlBtn.Location = new System.Drawing.Point(176, 171);
            this.adminKayitOlBtn.Name = "adminKayitOlBtn";
            this.adminKayitOlBtn.Size = new System.Drawing.Size(75, 23);
            this.adminKayitOlBtn.TabIndex = 11;
            this.adminKayitOlBtn.Text = "kayıt ol";
            this.adminKayitOlBtn.UseVisualStyleBackColor = true;
            this.adminKayitOlBtn.Click += new System.EventHandler(this.adminKayitOlBtn_Click);
            // 
            // adminSifremiUnuttumLbl
            // 
            this.adminSifremiUnuttumLbl.AutoSize = true;
            this.adminSifremiUnuttumLbl.Location = new System.Drawing.Point(174, 216);
            this.adminSifremiUnuttumLbl.Name = "adminSifremiUnuttumLbl";
            this.adminSifremiUnuttumLbl.Size = new System.Drawing.Size(77, 13);
            this.adminSifremiUnuttumLbl.TabIndex = 12;
            this.adminSifremiUnuttumLbl.TabStop = true;
            this.adminSifremiUnuttumLbl.Text = "şifremi unuttum";
            this.adminSifremiUnuttumLbl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.adminSifremiUnuttumLbl_LinkClicked);
            // 
            // sinavSistemiDataSet1
            // 
            this.sinavSistemiDataSet1.DataSetName = "sinavSistemiDataSet";
            this.sinavSistemiDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // adminGirisEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.adminSifremiUnuttumLbl);
            this.Controls.Add(this.adminKayitOlBtn);
            this.Controls.Add(this.adminGirisBtn);
            this.Controls.Add(this.adminSifreTextBox);
            this.Controls.Add(this.adminKullaniciAdiTextBox);
            this.Controls.Add(this.AdminSifre);
            this.Controls.Add(this.adminKullaniciAdi);
            this.Controls.Add(this.geriDön3Btn);
            this.Name = "adminGirisEkrani";
            this.Text = "adminGirisEkrani";
            ((System.ComponentModel.ISupportInitialize)(this.sinavSistemiDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button geriDön3Btn;
        private System.Windows.Forms.Button adminGirisBtn;
        private System.Windows.Forms.TextBox adminSifreTextBox;
        private System.Windows.Forms.TextBox adminKullaniciAdiTextBox;
        private System.Windows.Forms.Label AdminSifre;
        private System.Windows.Forms.Label adminKullaniciAdi;
        private System.Windows.Forms.Button adminKayitOlBtn;
        private System.Windows.Forms.LinkLabel adminSifremiUnuttumLbl;
        private sinavSistemiDataSet sinavSistemiDataSet1;
    }
}