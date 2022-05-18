namespace SinavSistemi
{
    partial class ogrenciSifremiUnuttumEkrani
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
            this.mailTextBox = new System.Windows.Forms.TextBox();
            this.mail = new System.Windows.Forms.Label();
            this.yeniSifreAlBtn = new System.Windows.Forms.Button();
            this.geriDön6Btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mailTextBox
            // 
            this.mailTextBox.Location = new System.Drawing.Point(440, 234);
            this.mailTextBox.Name = "mailTextBox";
            this.mailTextBox.Size = new System.Drawing.Size(172, 20);
            this.mailTextBox.TabIndex = 0;
            // 
            // mail
            // 
            this.mail.AutoSize = true;
            this.mail.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mail.Location = new System.Drawing.Point(373, 232);
            this.mail.Name = "mail";
            this.mail.Size = new System.Drawing.Size(59, 22);
            this.mail.TabIndex = 1;
            this.mail.Text = "E Mail";
            // 
            // yeniSifreAlBtn
            // 
            this.yeniSifreAlBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.yeniSifreAlBtn.Location = new System.Drawing.Point(457, 276);
            this.yeniSifreAlBtn.Name = "yeniSifreAlBtn";
            this.yeniSifreAlBtn.Size = new System.Drawing.Size(139, 45);
            this.yeniSifreAlBtn.TabIndex = 2;
            this.yeniSifreAlBtn.Text = "YENİ SİFRE AL";
            this.yeniSifreAlBtn.UseVisualStyleBackColor = true;
            this.yeniSifreAlBtn.Click += new System.EventHandler(this.yeniSifreAlBtn_Click);
            // 
            // geriDön6Btn
            // 
            this.geriDön6Btn.Location = new System.Drawing.Point(925, 0);
            this.geriDön6Btn.Name = "geriDön6Btn";
            this.geriDön6Btn.Size = new System.Drawing.Size(75, 23);
            this.geriDön6Btn.TabIndex = 3;
            this.geriDön6Btn.Text = "Geri Dön";
            this.geriDön6Btn.UseVisualStyleBackColor = true;
            this.geriDön6Btn.Click += new System.EventHandler(this.geriDön6Btn_Click);
            // 
            // ogrenciSifremiUnuttumEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.geriDön6Btn);
            this.Controls.Add(this.yeniSifreAlBtn);
            this.Controls.Add(this.mail);
            this.Controls.Add(this.mailTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ogrenciSifremiUnuttumEkrani";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ogrenciSifremiUnuttumEkrani";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox mailTextBox;
        private System.Windows.Forms.Label mail;
        private System.Windows.Forms.Button yeniSifreAlBtn;
        private System.Windows.Forms.Button geriDön6Btn;
    }
}