namespace SinavSistemi
{
    partial class adminKullanicilarEkrani
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
            this.geriDön13Btn = new System.Windows.Forms.Button();
            this.kullanicilarDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.kullanicilarDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // geriDön13Btn
            // 
            this.geriDön13Btn.Location = new System.Drawing.Point(725, 0);
            this.geriDön13Btn.Name = "geriDön13Btn";
            this.geriDön13Btn.Size = new System.Drawing.Size(75, 23);
            this.geriDön13Btn.TabIndex = 0;
            this.geriDön13Btn.Text = "geri dön";
            this.geriDön13Btn.UseVisualStyleBackColor = true;
            this.geriDön13Btn.Click += new System.EventHandler(this.geriDön13Btn_Click);
            // 
            // kullanicilarDataGridView
            // 
            this.kullanicilarDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.kullanicilarDataGridView.Location = new System.Drawing.Point(3, 26);
            this.kullanicilarDataGridView.Name = "kullanicilarDataGridView";
            this.kullanicilarDataGridView.Size = new System.Drawing.Size(797, 189);
            this.kullanicilarDataGridView.TabIndex = 1;
            // 
            // adminKullanicilarEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.kullanicilarDataGridView);
            this.Controls.Add(this.geriDön13Btn);
            this.Name = "adminKullanicilarEkrani";
            this.Text = "adminKullanicilarEkrani";
            this.Load += new System.EventHandler(this.adminKullanicilarEkrani_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kullanicilarDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button geriDön13Btn;
        private System.Windows.Forms.DataGridView kullanicilarDataGridView;
    }
}