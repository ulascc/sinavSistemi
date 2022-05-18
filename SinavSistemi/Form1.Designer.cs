namespace SinavSistemi
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ogrenciGirisBtn = new System.Windows.Forms.Button();
            this.adminGirisBtn = new System.Windows.Forms.Button();
            this.sınavSorumlusuGirisBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ogrenciGirisBtn
            // 
            this.ogrenciGirisBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ogrenciGirisBtn.Location = new System.Drawing.Point(105, 355);
            this.ogrenciGirisBtn.Name = "ogrenciGirisBtn";
            this.ogrenciGirisBtn.Size = new System.Drawing.Size(152, 103);
            this.ogrenciGirisBtn.TabIndex = 0;
            this.ogrenciGirisBtn.Text = "ÖĞRENCİ";
            this.ogrenciGirisBtn.UseVisualStyleBackColor = true;
            this.ogrenciGirisBtn.Click += new System.EventHandler(this.ogrenciGirisBtn_Click);
            // 
            // adminGirisBtn
            // 
            this.adminGirisBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.adminGirisBtn.Location = new System.Drawing.Point(744, 355);
            this.adminGirisBtn.Name = "adminGirisBtn";
            this.adminGirisBtn.Size = new System.Drawing.Size(152, 107);
            this.adminGirisBtn.TabIndex = 1;
            this.adminGirisBtn.Text = "ADMİN";
            this.adminGirisBtn.UseVisualStyleBackColor = true;
            this.adminGirisBtn.Click += new System.EventHandler(this.adminGirisBtn_Click);
            // 
            // sınavSorumlusuGirisBtn
            // 
            this.sınavSorumlusuGirisBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sınavSorumlusuGirisBtn.Location = new System.Drawing.Point(428, 355);
            this.sınavSorumlusuGirisBtn.Name = "sınavSorumlusuGirisBtn";
            this.sınavSorumlusuGirisBtn.Size = new System.Drawing.Size(152, 103);
            this.sınavSorumlusuGirisBtn.TabIndex = 2;
            this.sınavSorumlusuGirisBtn.Text = "SINAV SORUMLUSU";
            this.sınavSorumlusuGirisBtn.UseVisualStyleBackColor = true;
            this.sınavSorumlusuGirisBtn.Click += new System.EventHandler(this.sınavSorumlusuGirisBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(376, 40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(257, 215);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.sınavSorumlusuGirisBtn);
            this.Controls.Add(this.adminGirisBtn);
            this.Controls.Add(this.ogrenciGirisBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ogrenciGirisBtn;
        private System.Windows.Forms.Button adminGirisBtn;
        private System.Windows.Forms.Button sınavSorumlusuGirisBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

