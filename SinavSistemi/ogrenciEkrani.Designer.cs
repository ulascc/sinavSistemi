namespace SinavSistemi
{
    partial class ogrenciEkrani
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ogrenciEkrani));
            this.testeBaslaBtn = new System.Windows.Forms.Button();
            this.ogrenciSonuclarımBtn = new System.Windows.Forms.Button();
            this.ogrenciCıkısYapBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // testeBaslaBtn
            // 
            this.testeBaslaBtn.BackColor = System.Drawing.Color.SeaGreen;
            this.testeBaslaBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.testeBaslaBtn.Location = new System.Drawing.Point(362, 273);
            this.testeBaslaBtn.Name = "testeBaslaBtn";
            this.testeBaslaBtn.Size = new System.Drawing.Size(343, 55);
            this.testeBaslaBtn.TabIndex = 0;
            this.testeBaslaBtn.Text = "TESTE BAŞLA";
            this.testeBaslaBtn.UseVisualStyleBackColor = false;
            this.testeBaslaBtn.Click += new System.EventHandler(this.testeBaslaBtn_Click);
            // 
            // ogrenciSonuclarımBtn
            // 
            this.ogrenciSonuclarımBtn.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ogrenciSonuclarımBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ogrenciSonuclarımBtn.Location = new System.Drawing.Point(414, 353);
            this.ogrenciSonuclarımBtn.Name = "ogrenciSonuclarımBtn";
            this.ogrenciSonuclarımBtn.Size = new System.Drawing.Size(248, 51);
            this.ogrenciSonuclarımBtn.TabIndex = 1;
            this.ogrenciSonuclarımBtn.Text = "SONUÇLARIM";
            this.ogrenciSonuclarımBtn.UseVisualStyleBackColor = false;
            this.ogrenciSonuclarımBtn.Click += new System.EventHandler(this.ogrenciSonuclarımBtn_Click);
            // 
            // ogrenciCıkısYapBtn
            // 
            this.ogrenciCıkısYapBtn.BackColor = System.Drawing.Color.MediumAquamarine;
            this.ogrenciCıkısYapBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ogrenciCıkısYapBtn.Location = new System.Drawing.Point(468, 426);
            this.ogrenciCıkısYapBtn.Name = "ogrenciCıkısYapBtn";
            this.ogrenciCıkısYapBtn.Size = new System.Drawing.Size(150, 45);
            this.ogrenciCıkısYapBtn.TabIndex = 2;
            this.ogrenciCıkısYapBtn.Text = "ÇIKIŞ YAP";
            this.ogrenciCıkısYapBtn.UseVisualStyleBackColor = false;
            this.ogrenciCıkısYapBtn.Click += new System.EventHandler(this.ogrenciCıkısYapBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(392, 39);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(291, 191);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // ogrenciEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ogrenciCıkısYapBtn);
            this.Controls.Add(this.ogrenciSonuclarımBtn);
            this.Controls.Add(this.testeBaslaBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ogrenciEkrani";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ogrenciEkrani";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button testeBaslaBtn;
        private System.Windows.Forms.Button ogrenciSonuclarımBtn;
        private System.Windows.Forms.Button ogrenciCıkısYapBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}