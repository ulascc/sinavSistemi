namespace SinavSistemi
{
    partial class adminSifremiUnuttumEkrani
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
            this.adminYeniSifreAlBtn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.geriDön17Btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(360, 264);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "E Mail";
            // 
            // adminYeniSifreAlBtn
            // 
            this.adminYeniSifreAlBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.adminYeniSifreAlBtn.Location = new System.Drawing.Point(446, 312);
            this.adminYeniSifreAlBtn.Name = "adminYeniSifreAlBtn";
            this.adminYeniSifreAlBtn.Size = new System.Drawing.Size(118, 33);
            this.adminYeniSifreAlBtn.TabIndex = 1;
            this.adminYeniSifreAlBtn.Text = "Yeni Şifre Al";
            this.adminYeniSifreAlBtn.UseVisualStyleBackColor = true;
            this.adminYeniSifreAlBtn.Click += new System.EventHandler(this.adminYeniSifreAlBtn_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(434, 266);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(143, 20);
            this.textBox1.TabIndex = 2;
            // 
            // geriDön17Btn
            // 
            this.geriDön17Btn.Location = new System.Drawing.Point(926, 0);
            this.geriDön17Btn.Name = "geriDön17Btn";
            this.geriDön17Btn.Size = new System.Drawing.Size(75, 23);
            this.geriDön17Btn.TabIndex = 3;
            this.geriDön17Btn.Text = "Geri Dön";
            this.geriDön17Btn.UseVisualStyleBackColor = true;
            this.geriDön17Btn.Click += new System.EventHandler(this.geriDön17Btn_Click);
            // 
            // adminSifremiUnuttumEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.geriDön17Btn);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.adminYeniSifreAlBtn);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "adminSifremiUnuttumEkrani";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "adminSifremiUnuttumEkrani";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button adminYeniSifreAlBtn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button geriDön17Btn;
    }
}