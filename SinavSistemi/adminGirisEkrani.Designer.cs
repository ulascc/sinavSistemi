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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(adminGirisEkrani));
            this.geriDön3Btn = new System.Windows.Forms.Button();
            this.adminGirisBtn = new System.Windows.Forms.Button();
            this.adminSifreTextBox = new System.Windows.Forms.TextBox();
            this.adminKullaniciAdiTextBox = new System.Windows.Forms.TextBox();
            this.AdminSifre = new System.Windows.Forms.Label();
            this.adminKullaniciAdi = new System.Windows.Forms.Label();
            this.adminKayitOlBtn = new System.Windows.Forms.Button();
            this.adminSifremiUnuttumLbl = new System.Windows.Forms.LinkLabel();
            this.sinavSistemiDataSet1 = new SinavSistemi.sinavSistemiDataSet();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.sinavSistemiDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // geriDön3Btn
            // 
            this.geriDön3Btn.Location = new System.Drawing.Point(925, 0);
            this.geriDön3Btn.Name = "geriDön3Btn";
            this.geriDön3Btn.Size = new System.Drawing.Size(75, 23);
            this.geriDön3Btn.TabIndex = 0;
            this.geriDön3Btn.Text = "Geri Dön";
            this.geriDön3Btn.UseVisualStyleBackColor = true;
            this.geriDön3Btn.Click += new System.EventHandler(this.geriDön3Btn_Click);
            // 
            // adminGirisBtn
            // 
            this.adminGirisBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.adminGirisBtn.Location = new System.Drawing.Point(481, 320);
            this.adminGirisBtn.Name = "adminGirisBtn";
            this.adminGirisBtn.Size = new System.Drawing.Size(118, 38);
            this.adminGirisBtn.TabIndex = 10;
            this.adminGirisBtn.Text = "GİRİŞ YAP";
            this.adminGirisBtn.UseVisualStyleBackColor = true;
            this.adminGirisBtn.Click += new System.EventHandler(this.adminGirisBtn_Click);
            // 
            // adminSifreTextBox
            // 
            this.adminSifreTextBox.Location = new System.Drawing.Point(457, 268);
            this.adminSifreTextBox.Name = "adminSifreTextBox";
            this.adminSifreTextBox.Size = new System.Drawing.Size(127, 20);
            this.adminSifreTextBox.TabIndex = 9;
            this.adminSifreTextBox.UseSystemPasswordChar = true;
            // 
            // adminKullaniciAdiTextBox
            // 
            this.adminKullaniciAdiTextBox.Location = new System.Drawing.Point(457, 219);
            this.adminKullaniciAdiTextBox.Name = "adminKullaniciAdiTextBox";
            this.adminKullaniciAdiTextBox.Size = new System.Drawing.Size(127, 20);
            this.adminKullaniciAdiTextBox.TabIndex = 8;
            // 
            // AdminSifre
            // 
            this.AdminSifre.AutoSize = true;
            this.AdminSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.AdminSifre.Location = new System.Drawing.Point(345, 266);
            this.AdminSifre.Name = "AdminSifre";
            this.AdminSifre.Size = new System.Drawing.Size(47, 20);
            this.AdminSifre.TabIndex = 7;
            this.AdminSifre.Text = "Şifre";
            // 
            // adminKullaniciAdi
            // 
            this.adminKullaniciAdi.AutoSize = true;
            this.adminKullaniciAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.adminKullaniciAdi.Location = new System.Drawing.Point(345, 219);
            this.adminKullaniciAdi.Name = "adminKullaniciAdi";
            this.adminKullaniciAdi.Size = new System.Drawing.Size(106, 20);
            this.adminKullaniciAdi.TabIndex = 6;
            this.adminKullaniciAdi.Text = "Kullanıcı Adı";
            // 
            // adminKayitOlBtn
            // 
            this.adminKayitOlBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.adminKayitOlBtn.Location = new System.Drawing.Point(482, 375);
            this.adminKayitOlBtn.Name = "adminKayitOlBtn";
            this.adminKayitOlBtn.Size = new System.Drawing.Size(117, 42);
            this.adminKayitOlBtn.TabIndex = 11;
            this.adminKayitOlBtn.Text = "KAYIT OL";
            this.adminKayitOlBtn.UseVisualStyleBackColor = true;
            this.adminKayitOlBtn.Click += new System.EventHandler(this.adminKayitOlBtn_Click);
            // 
            // adminSifremiUnuttumLbl
            // 
            this.adminSifremiUnuttumLbl.AutoSize = true;
            this.adminSifremiUnuttumLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.adminSifremiUnuttumLbl.Location = new System.Drawing.Point(507, 436);
            this.adminSifremiUnuttumLbl.Name = "adminSifremiUnuttumLbl";
            this.adminSifremiUnuttumLbl.Size = new System.Drawing.Size(92, 15);
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
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(439, 34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(171, 155);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // adminGirisEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.adminSifremiUnuttumLbl);
            this.Controls.Add(this.adminKayitOlBtn);
            this.Controls.Add(this.adminGirisBtn);
            this.Controls.Add(this.adminSifreTextBox);
            this.Controls.Add(this.adminKullaniciAdiTextBox);
            this.Controls.Add(this.AdminSifre);
            this.Controls.Add(this.adminKullaniciAdi);
            this.Controls.Add(this.geriDön3Btn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "adminGirisEkrani";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "adminGirisEkrani";
            ((System.ComponentModel.ISupportInitialize)(this.sinavSistemiDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}