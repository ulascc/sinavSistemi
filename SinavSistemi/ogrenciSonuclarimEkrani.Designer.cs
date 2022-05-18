namespace SinavSistemi
{
    partial class ogrenciSonuclarimEkrani
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ogrenciSonuclarimEkrani));
            this.geriDön14Btn = new System.Windows.Forms.Button();
            this.ogrenciCevaplariDataGridView = new System.Windows.Forms.DataGridView();
            this.sonucYazdirBtn = new System.Windows.Forms.Button();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciCevaplariDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // geriDön14Btn
            // 
            this.geriDön14Btn.Location = new System.Drawing.Point(925, 0);
            this.geriDön14Btn.Name = "geriDön14Btn";
            this.geriDön14Btn.Size = new System.Drawing.Size(75, 23);
            this.geriDön14Btn.TabIndex = 0;
            this.geriDön14Btn.Text = "Geri Dön";
            this.geriDön14Btn.UseVisualStyleBackColor = true;
            this.geriDön14Btn.Click += new System.EventHandler(this.geriDön14Btn_Click);
            // 
            // ogrenciCevaplariDataGridView
            // 
            this.ogrenciCevaplariDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ogrenciCevaplariDataGridView.Location = new System.Drawing.Point(165, 260);
            this.ogrenciCevaplariDataGridView.Name = "ogrenciCevaplariDataGridView";
            this.ogrenciCevaplariDataGridView.Size = new System.Drawing.Size(668, 186);
            this.ogrenciCevaplariDataGridView.TabIndex = 1;
            // 
            // sonucYazdirBtn
            // 
            this.sonucYazdirBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sonucYazdirBtn.Location = new System.Drawing.Point(427, 468);
            this.sonucYazdirBtn.Name = "sonucYazdirBtn";
            this.sonucYazdirBtn.Size = new System.Drawing.Size(158, 57);
            this.sonucYazdirBtn.TabIndex = 2;
            this.sonucYazdirBtn.Text = "SONUÇLARIMI YAZDIR";
            this.sonucYazdirBtn.UseVisualStyleBackColor = true;
            this.sonucYazdirBtn.Click += new System.EventHandler(this.sonucYazdirBtn_Click);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Text = "Baskı önizleme";
            this.printPreviewDialog1.Visible = false;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printDialog1
            // 
            this.printDialog1.Document = this.printDocument1;
            this.printDialog1.UseEXDialog = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(406, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(216, 187);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(456, 219);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "SONUÇLARIM";
            // 
            // ogrenciSonuclarimEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.sonucYazdirBtn);
            this.Controls.Add(this.ogrenciCevaplariDataGridView);
            this.Controls.Add(this.geriDön14Btn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ogrenciSonuclarimEkrani";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ogrenciSonuclarimEkrani";
            this.Load += new System.EventHandler(this.ogrenciSonuclarimEkrani_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciCevaplariDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button geriDön14Btn;
        private System.Windows.Forms.DataGridView ogrenciCevaplariDataGridView;
        private System.Windows.Forms.Button sonucYazdirBtn;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}