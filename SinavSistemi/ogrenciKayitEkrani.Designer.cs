namespace SinavSistemi
{
    partial class ogrenciKayitEkrani
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.kullaniciAdiTextBox = new System.Windows.Forms.TextBox();
            this.sifreTextBox = new System.Windows.Forms.TextBox();
            this.MailTextBox = new System.Windows.Forms.TextBox();
            this.soyisimTextBox = new System.Windows.Forms.TextBox();
            this.isimTextBox = new System.Windows.Forms.TextBox();
            this.kayitOlBtn = new System.Windows.Forms.Button();
            this.geriDön4Btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "kullanıcı adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "isim";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(73, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "soyisim";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(73, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "e mail";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(73, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "şifre";
            // 
            // kullaniciAdiTextBox
            // 
            this.kullaniciAdiTextBox.Location = new System.Drawing.Point(187, 42);
            this.kullaniciAdiTextBox.Name = "kullaniciAdiTextBox";
            this.kullaniciAdiTextBox.Size = new System.Drawing.Size(100, 20);
            this.kullaniciAdiTextBox.TabIndex = 5;
            // 
            // sifreTextBox
            // 
            this.sifreTextBox.Location = new System.Drawing.Point(187, 175);
            this.sifreTextBox.Name = "sifreTextBox";
            this.sifreTextBox.Size = new System.Drawing.Size(100, 20);
            this.sifreTextBox.TabIndex = 6;
            // 
            // MailTextBox
            // 
            this.MailTextBox.Location = new System.Drawing.Point(187, 144);
            this.MailTextBox.Name = "MailTextBox";
            this.MailTextBox.Size = new System.Drawing.Size(100, 20);
            this.MailTextBox.TabIndex = 7;
            // 
            // soyisimTextBox
            // 
            this.soyisimTextBox.Location = new System.Drawing.Point(187, 108);
            this.soyisimTextBox.Name = "soyisimTextBox";
            this.soyisimTextBox.Size = new System.Drawing.Size(100, 20);
            this.soyisimTextBox.TabIndex = 8;
            // 
            // isimTextBox
            // 
            this.isimTextBox.Location = new System.Drawing.Point(187, 76);
            this.isimTextBox.Name = "isimTextBox";
            this.isimTextBox.Size = new System.Drawing.Size(100, 20);
            this.isimTextBox.TabIndex = 9;
            // 
            // kayitOlBtn
            // 
            this.kayitOlBtn.Location = new System.Drawing.Point(212, 225);
            this.kayitOlBtn.Name = "kayitOlBtn";
            this.kayitOlBtn.Size = new System.Drawing.Size(75, 23);
            this.kayitOlBtn.TabIndex = 10;
            this.kayitOlBtn.Text = "kayıt ol";
            this.kayitOlBtn.UseVisualStyleBackColor = true;
            this.kayitOlBtn.Click += new System.EventHandler(this.kayitOlBtn_Click);
            // 
            // geriDön4Btn
            // 
            this.geriDön4Btn.Location = new System.Drawing.Point(724, 2);
            this.geriDön4Btn.Name = "geriDön4Btn";
            this.geriDön4Btn.Size = new System.Drawing.Size(75, 23);
            this.geriDön4Btn.TabIndex = 11;
            this.geriDön4Btn.Text = "geri dön";
            this.geriDön4Btn.UseVisualStyleBackColor = true;
            this.geriDön4Btn.Click += new System.EventHandler(this.geriDön4Btn_Click);
            // 
            // ogrenciKayitEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.geriDön4Btn);
            this.Controls.Add(this.kayitOlBtn);
            this.Controls.Add(this.isimTextBox);
            this.Controls.Add(this.soyisimTextBox);
            this.Controls.Add(this.MailTextBox);
            this.Controls.Add(this.sifreTextBox);
            this.Controls.Add(this.kullaniciAdiTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ogrenciKayitEkrani";
            this.Text = "ogrenciKayitEkrani";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox kullaniciAdiTextBox;
        private System.Windows.Forms.TextBox sifreTextBox;
        private System.Windows.Forms.TextBox MailTextBox;
        private System.Windows.Forms.TextBox soyisimTextBox;
        private System.Windows.Forms.TextBox isimTextBox;
        private System.Windows.Forms.Button kayitOlBtn;
        private System.Windows.Forms.Button geriDön4Btn;
    }
}