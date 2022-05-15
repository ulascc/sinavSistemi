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
            this.mailTextBox.Location = new System.Drawing.Point(127, 76);
            this.mailTextBox.Name = "mailTextBox";
            this.mailTextBox.Size = new System.Drawing.Size(100, 20);
            this.mailTextBox.TabIndex = 0;
            // 
            // mail
            // 
            this.mail.AutoSize = true;
            this.mail.Location = new System.Drawing.Point(84, 79);
            this.mail.Name = "mail";
            this.mail.Size = new System.Drawing.Size(25, 13);
            this.mail.TabIndex = 1;
            this.mail.Text = "mail";
            // 
            // yeniSifreAlBtn
            // 
            this.yeniSifreAlBtn.Location = new System.Drawing.Point(152, 115);
            this.yeniSifreAlBtn.Name = "yeniSifreAlBtn";
            this.yeniSifreAlBtn.Size = new System.Drawing.Size(75, 23);
            this.yeniSifreAlBtn.TabIndex = 2;
            this.yeniSifreAlBtn.Text = "yeni sifre al";
            this.yeniSifreAlBtn.UseVisualStyleBackColor = true;
            this.yeniSifreAlBtn.Click += new System.EventHandler(this.yeniSifreAlBtn_Click);
            // 
            // geriDön6Btn
            // 
            this.geriDön6Btn.Location = new System.Drawing.Point(725, 1);
            this.geriDön6Btn.Name = "geriDön6Btn";
            this.geriDön6Btn.Size = new System.Drawing.Size(75, 23);
            this.geriDön6Btn.TabIndex = 3;
            this.geriDön6Btn.Text = "geri dön";
            this.geriDön6Btn.UseVisualStyleBackColor = true;
            this.geriDön6Btn.Click += new System.EventHandler(this.geriDön6Btn_Click);
            // 
            // ogrenciSifremiUnuttumEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.geriDön6Btn);
            this.Controls.Add(this.yeniSifreAlBtn);
            this.Controls.Add(this.mail);
            this.Controls.Add(this.mailTextBox);
            this.Name = "ogrenciSifremiUnuttumEkrani";
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