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
            this.geriDön9Btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // geriDön9Btn
            // 
            this.geriDön9Btn.Location = new System.Drawing.Point(725, 1);
            this.geriDön9Btn.Name = "geriDön9Btn";
            this.geriDön9Btn.Size = new System.Drawing.Size(75, 23);
            this.geriDön9Btn.TabIndex = 0;
            this.geriDön9Btn.Text = "geri dön";
            this.geriDön9Btn.UseVisualStyleBackColor = true;
            this.geriDön9Btn.Click += new System.EventHandler(this.geriDön9Btn_Click);
            // 
            // sinavSorumlusuOgrenciSonuclarıEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.geriDön9Btn);
            this.Name = "sinavSorumlusuOgrenciSonuclarıEkrani";
            this.Text = "sinavSorumlusuOgrenciSonuclarıEkrani";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button geriDön9Btn;
    }
}