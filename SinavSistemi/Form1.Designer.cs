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
            this.ogrenciGirisBtn = new System.Windows.Forms.Button();
            this.adminGirisBtn = new System.Windows.Forms.Button();
            this.sınavSorumlusuGirisBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ogrenciGirisBtn
            // 
            this.ogrenciGirisBtn.Location = new System.Drawing.Point(150, 164);
            this.ogrenciGirisBtn.Name = "ogrenciGirisBtn";
            this.ogrenciGirisBtn.Size = new System.Drawing.Size(73, 34);
            this.ogrenciGirisBtn.TabIndex = 0;
            this.ogrenciGirisBtn.Text = "öğrenci";
            this.ogrenciGirisBtn.UseVisualStyleBackColor = true;
            this.ogrenciGirisBtn.Click += new System.EventHandler(this.ogrenciGirisBtn_Click);
            // 
            // adminGirisBtn
            // 
            this.adminGirisBtn.Location = new System.Drawing.Point(306, 164);
            this.adminGirisBtn.Name = "adminGirisBtn";
            this.adminGirisBtn.Size = new System.Drawing.Size(75, 34);
            this.adminGirisBtn.TabIndex = 1;
            this.adminGirisBtn.Text = "admin";
            this.adminGirisBtn.UseVisualStyleBackColor = true;
            this.adminGirisBtn.Click += new System.EventHandler(this.adminGirisBtn_Click);
            // 
            // sınavSorumlusuGirisBtn
            // 
            this.sınavSorumlusuGirisBtn.Location = new System.Drawing.Point(460, 164);
            this.sınavSorumlusuGirisBtn.Name = "sınavSorumlusuGirisBtn";
            this.sınavSorumlusuGirisBtn.Size = new System.Drawing.Size(75, 34);
            this.sınavSorumlusuGirisBtn.TabIndex = 2;
            this.sınavSorumlusuGirisBtn.Text = "sınav sorumlusu";
            this.sınavSorumlusuGirisBtn.UseVisualStyleBackColor = true;
            this.sınavSorumlusuGirisBtn.Click += new System.EventHandler(this.sınavSorumlusuGirisBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.sınavSorumlusuGirisBtn);
            this.Controls.Add(this.adminGirisBtn);
            this.Controls.Add(this.ogrenciGirisBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ogrenciGirisBtn;
        private System.Windows.Forms.Button adminGirisBtn;
        private System.Windows.Forms.Button sınavSorumlusuGirisBtn;
    }
}

