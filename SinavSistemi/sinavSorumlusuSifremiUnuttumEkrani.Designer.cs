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
            this.geriDön8Btn.Location = new System.Drawing.Point(726, 0);
            this.geriDön8Btn.Name = "geriDön8Btn";
            this.geriDön8Btn.Size = new System.Drawing.Size(75, 23);
            this.geriDön8Btn.TabIndex = 0;
            this.geriDön8Btn.Text = "geri dön";
            this.geriDön8Btn.UseVisualStyleBackColor = true;
            this.geriDön8Btn.Click += new System.EventHandler(this.geriDön8Btn_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(100, 66);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "mail";
            // 
            // sorumluYeniSifreAlBtn
            // 
            this.sorumluYeniSifreAlBtn.Location = new System.Drawing.Point(125, 105);
            this.sorumluYeniSifreAlBtn.Name = "sorumluYeniSifreAlBtn";
            this.sorumluYeniSifreAlBtn.Size = new System.Drawing.Size(75, 23);
            this.sorumluYeniSifreAlBtn.TabIndex = 3;
            this.sorumluYeniSifreAlBtn.Text = "yeni sifre al";
            this.sorumluYeniSifreAlBtn.UseVisualStyleBackColor = true;
            this.sorumluYeniSifreAlBtn.Click += new System.EventHandler(this.sorumluYeniSifreAlBtn_Click);
            // 
            // sinavSorumlusuSifremiUnuttumEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.sorumluYeniSifreAlBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.geriDön8Btn);
            this.Name = "sinavSorumlusuSifremiUnuttumEkrani";
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