namespace SinavSistemi
{
    partial class sinavSorumlusuEkrani
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(sinavSorumlusuEkrani));
            this.sorumluSoruEkleBtn = new System.Windows.Forms.Button();
            this.sorumluOgrenciSonuclariBtn = new System.Windows.Forms.Button();
            this.sorumluCıkısBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // sorumluSoruEkleBtn
            // 
            this.sorumluSoruEkleBtn.BackColor = System.Drawing.Color.Firebrick;
            this.sorumluSoruEkleBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sorumluSoruEkleBtn.Location = new System.Drawing.Point(25, 179);
            this.sorumluSoruEkleBtn.Name = "sorumluSoruEkleBtn";
            this.sorumluSoruEkleBtn.Size = new System.Drawing.Size(250, 42);
            this.sorumluSoruEkleBtn.TabIndex = 0;
            this.sorumluSoruEkleBtn.Text = "SORU EKLE";
            this.sorumluSoruEkleBtn.UseVisualStyleBackColor = false;
            this.sorumluSoruEkleBtn.Click += new System.EventHandler(this.sorumluSoruEkleBtn_Click);
            // 
            // sorumluOgrenciSonuclariBtn
            // 
            this.sorumluOgrenciSonuclariBtn.BackColor = System.Drawing.Color.IndianRed;
            this.sorumluOgrenciSonuclariBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sorumluOgrenciSonuclariBtn.Location = new System.Drawing.Point(25, 227);
            this.sorumluOgrenciSonuclariBtn.Name = "sorumluOgrenciSonuclariBtn";
            this.sorumluOgrenciSonuclariBtn.Size = new System.Drawing.Size(185, 41);
            this.sorumluOgrenciSonuclariBtn.TabIndex = 1;
            this.sorumluOgrenciSonuclariBtn.Text = "ÖĞRENCİ SONUÇLARI";
            this.sorumluOgrenciSonuclariBtn.UseVisualStyleBackColor = false;
            this.sorumluOgrenciSonuclariBtn.Click += new System.EventHandler(this.sorumluOgrenciSonuclariBtn_Click);
            // 
            // sorumluCıkısBtn
            // 
            this.sorumluCıkısBtn.BackColor = System.Drawing.Color.RosyBrown;
            this.sorumluCıkısBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sorumluCıkısBtn.Location = new System.Drawing.Point(25, 274);
            this.sorumluCıkısBtn.Name = "sorumluCıkısBtn";
            this.sorumluCıkısBtn.Size = new System.Drawing.Size(123, 32);
            this.sorumluCıkısBtn.TabIndex = 2;
            this.sorumluCıkısBtn.Text = "ÇIKIŞ YAP";
            this.sorumluCıkısBtn.UseVisualStyleBackColor = false;
            this.sorumluCıkısBtn.Click += new System.EventHandler(this.sorumluCıkısBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(25, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 133);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // sinavSorumlusuEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.sorumluCıkısBtn);
            this.Controls.Add(this.sorumluOgrenciSonuclariBtn);
            this.Controls.Add(this.sorumluSoruEkleBtn);
            this.Name = "sinavSorumlusuEkrani";
            this.Text = "sinavSorumlusuEkrani";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button sorumluSoruEkleBtn;
        private System.Windows.Forms.Button sorumluOgrenciSonuclariBtn;
        private System.Windows.Forms.Button sorumluCıkısBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}