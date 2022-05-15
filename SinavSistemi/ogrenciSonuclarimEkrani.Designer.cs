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
            this.geriDön14Btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // geriDön14Btn
            // 
            this.geriDön14Btn.Location = new System.Drawing.Point(726, 1);
            this.geriDön14Btn.Name = "geriDön14Btn";
            this.geriDön14Btn.Size = new System.Drawing.Size(75, 23);
            this.geriDön14Btn.TabIndex = 0;
            this.geriDön14Btn.Text = "geri dön";
            this.geriDön14Btn.UseVisualStyleBackColor = true;
            this.geriDön14Btn.Click += new System.EventHandler(this.geriDön14Btn_Click);
            // 
            // ogrenciSonuclarimEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.geriDön14Btn);
            this.Name = "ogrenciSonuclarimEkrani";
            this.Text = "ogrenciSonuclarimEkrani";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button geriDön14Btn;
    }
}