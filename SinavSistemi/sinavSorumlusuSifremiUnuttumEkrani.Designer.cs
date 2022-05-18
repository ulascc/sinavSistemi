namespace SinavSistemi
{
    partial class sinavSorumlusuSifremiUnuttumEkrani
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
            this.geriDön8Btn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.sorumluYeniSifreAlBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // geriDön8Btn
            // 
            this.geriDön8Btn.Location = new System.Drawing.Point(926, 1);
            this.geriDön8Btn.Name = "geriDön8Btn";
            this.geriDön8Btn.Size = new System.Drawing.Size(75, 23);
            this.geriDön8Btn.TabIndex = 0;
            this.geriDön8Btn.Text = "Geri Dön";
            this.geriDön8Btn.UseVisualStyleBackColor = true;
            this.geriDön8Btn.Click += new System.EventHandler(this.geriDön8Btn_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(427, 207);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(169, 20);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(359, 207);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "E Mail";
            // 
            // sorumluYeniSifreAlBtn
            // 
            this.sorumluYeniSifreAlBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sorumluYeniSifreAlBtn.Location = new System.Drawing.Point(451, 251);
            this.sorumluYeniSifreAlBtn.Name = "sorumluYeniSifreAlBtn";
            this.sorumluYeniSifreAlBtn.Size = new System.Drawing.Size(133, 37);
            this.sorumluYeniSifreAlBtn.TabIndex = 3;
            this.sorumluYeniSifreAlBtn.Text = "YENİ ŞİFRE AL";
            this.sorumluYeniSifreAlBtn.UseVisualStyleBackColor = true;
            this.sorumluYeniSifreAlBtn.Click += new System.EventHandler(this.sorumluYeniSifreAlBtn_Click);
            // 
            // sinavSorumlusuSifremiUnuttumEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.sorumluYeniSifreAlBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.geriDön8Btn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "sinavSorumlusuSifremiUnuttumEkrani";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "sinavSorumlusuSifremiUnuttumEkrani";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button geriDön8Btn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button sorumluYeniSifreAlBtn;
    }
}