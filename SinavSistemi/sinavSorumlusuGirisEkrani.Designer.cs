﻿namespace SinavSistemi
{
    partial class sinavSorumlusuGirisEkrani
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
            this.geriDönBtn = new System.Windows.Forms.Button();
            this.sorumluKullaniciAdi = new System.Windows.Forms.Label();
            this.sorumluSifre = new System.Windows.Forms.Label();
            this.SorumluSifreTextBox = new System.Windows.Forms.TextBox();
            this.sorumluGirisBtn = new System.Windows.Forms.Button();
            this.sorumluKullaniciAdiTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // geriDönBtn
            // 
            this.geriDönBtn.Location = new System.Drawing.Point(724, 2);
            this.geriDönBtn.Name = "geriDönBtn";
            this.geriDönBtn.Size = new System.Drawing.Size(75, 23);
            this.geriDönBtn.TabIndex = 0;
            this.geriDönBtn.Text = "geri dön";
            this.geriDönBtn.UseVisualStyleBackColor = true;
            this.geriDönBtn.Click += new System.EventHandler(this.geriDönBtn_Click);
            // 
            // sorumluKullaniciAdi
            // 
            this.sorumluKullaniciAdi.AutoSize = true;
            this.sorumluKullaniciAdi.Location = new System.Drawing.Point(73, 67);
            this.sorumluKullaniciAdi.Name = "sorumluKullaniciAdi";
            this.sorumluKullaniciAdi.Size = new System.Drawing.Size(62, 13);
            this.sorumluKullaniciAdi.TabIndex = 1;
            this.sorumluKullaniciAdi.Text = "kullanıcı adı";
            // 
            // sorumluSifre
            // 
            this.sorumluSifre.AutoSize = true;
            this.sorumluSifre.Location = new System.Drawing.Point(73, 104);
            this.sorumluSifre.Name = "sorumluSifre";
            this.sorumluSifre.Size = new System.Drawing.Size(26, 13);
            this.sorumluSifre.TabIndex = 2;
            this.sorumluSifre.Text = "sifre";
            // 
            // SorumluSifreTextBox
            // 
            this.SorumluSifreTextBox.Location = new System.Drawing.Point(165, 97);
            this.SorumluSifreTextBox.Name = "SorumluSifreTextBox";
            this.SorumluSifreTextBox.Size = new System.Drawing.Size(100, 20);
            this.SorumluSifreTextBox.TabIndex = 4;
            // 
            // sorumluGirisBtn
            // 
            this.sorumluGirisBtn.Location = new System.Drawing.Point(190, 135);
            this.sorumluGirisBtn.Name = "sorumluGirisBtn";
            this.sorumluGirisBtn.Size = new System.Drawing.Size(75, 23);
            this.sorumluGirisBtn.TabIndex = 5;
            this.sorumluGirisBtn.Text = "giris yap";
            this.sorumluGirisBtn.UseVisualStyleBackColor = true;
            // 
            // sorumluKullaniciAdiTextBox
            // 
            this.sorumluKullaniciAdiTextBox.Location = new System.Drawing.Point(165, 60);
            this.sorumluKullaniciAdiTextBox.Name = "sorumluKullaniciAdiTextBox";
            this.sorumluKullaniciAdiTextBox.Size = new System.Drawing.Size(100, 20);
            this.sorumluKullaniciAdiTextBox.TabIndex = 6;
            // 
            // sinavSorumlusuGirisEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.sorumluKullaniciAdiTextBox);
            this.Controls.Add(this.sorumluGirisBtn);
            this.Controls.Add(this.SorumluSifreTextBox);
            this.Controls.Add(this.sorumluSifre);
            this.Controls.Add(this.sorumluKullaniciAdi);
            this.Controls.Add(this.geriDönBtn);
            this.Name = "sinavSorumlusuGirisEkrani";
            this.Text = "sinavSorumlusuGirisEkrani";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button geriDönBtn;
        private System.Windows.Forms.Label sorumluKullaniciAdi;
        private System.Windows.Forms.Label sorumluSifre;
        private System.Windows.Forms.TextBox SorumluSifreTextBox;
        private System.Windows.Forms.Button sorumluGirisBtn;
        private System.Windows.Forms.TextBox sorumluKullaniciAdiTextBox;
    }
}