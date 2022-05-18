namespace SinavSistemi
{
    partial class sinavSorumlusuOgrenciSonuclarıEkrani
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(sinavSorumlusuOgrenciSonuclarıEkrani));
            this.geriDön9Btn = new System.Windows.Forms.Button();
            this.ogrenciSonuclariDataGridView = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciSonuclariDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // geriDön9Btn
            // 
            this.geriDön9Btn.Location = new System.Drawing.Point(925, 0);
            this.geriDön9Btn.Name = "geriDön9Btn";
            this.geriDön9Btn.Size = new System.Drawing.Size(75, 23);
            this.geriDön9Btn.TabIndex = 0;
            this.geriDön9Btn.Text = "Geri Dön";
            this.geriDön9Btn.UseVisualStyleBackColor = true;
            this.geriDön9Btn.Click += new System.EventHandler(this.geriDön9Btn_Click);
            // 
            // ogrenciSonuclariDataGridView
            // 
            this.ogrenciSonuclariDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ogrenciSonuclariDataGridView.Location = new System.Drawing.Point(346, 283);
            this.ogrenciSonuclariDataGridView.Name = "ogrenciSonuclariDataGridView";
            this.ogrenciSonuclariDataGridView.Size = new System.Drawing.Size(350, 198);
            this.ogrenciSonuclariDataGridView.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(369, 34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(302, 172);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(426, 249);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "ÖĞRENCİ SONUÇLARI";
            // 
            // sinavSorumlusuOgrenciSonuclarıEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ogrenciSonuclariDataGridView);
            this.Controls.Add(this.geriDön9Btn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "sinavSorumlusuOgrenciSonuclarıEkrani";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "sinavSorumlusuOgrenciSonuclarıEkrani";
            this.Load += new System.EventHandler(this.sinavSorumlusuOgrenciSonuclarıEkrani_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciSonuclariDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button geriDön9Btn;
        private System.Windows.Forms.DataGridView ogrenciSonuclariDataGridView;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}