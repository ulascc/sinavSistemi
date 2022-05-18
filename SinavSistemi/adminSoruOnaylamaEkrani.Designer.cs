namespace SinavSistemi
{
    partial class adminSoruOnaylamaEkrani
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
            this.sorularDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.silinecekSoruTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.soruSilBtn = new System.Windows.Forms.Button();
            this.soruOnaylaBtn = new System.Windows.Forms.Button();
            this.geriDön12Btn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sorularDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // sorularDataGridView
            // 
            this.sorularDataGridView.AllowUserToDeleteRows = false;
            this.sorularDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sorularDataGridView.Location = new System.Drawing.Point(0, 100);
            this.sorularDataGridView.Name = "sorularDataGridView";
            this.sorularDataGridView.Size = new System.Drawing.Size(1000, 207);
            this.sorularDataGridView.TabIndex = 0;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(273, 137);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(8, 8);
            this.dataGridView2.TabIndex = 1;
            // 
            // silinecekSoruTextBox
            // 
            this.silinecekSoruTextBox.Location = new System.Drawing.Point(405, 465);
            this.silinecekSoruTextBox.Name = "silinecekSoruTextBox";
            this.silinecekSoruTextBox.Size = new System.Drawing.Size(64, 20);
            this.silinecekSoruTextBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(388, 439);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Silmek İstediğiniz Soru ID\'sini Yazınız";
            // 
            // soruSilBtn
            // 
            this.soruSilBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.soruSilBtn.Location = new System.Drawing.Point(489, 462);
            this.soruSilBtn.Name = "soruSilBtn";
            this.soruSilBtn.Size = new System.Drawing.Size(75, 23);
            this.soruSilBtn.TabIndex = 4;
            this.soruSilBtn.Text = "Soruyu Sil";
            this.soruSilBtn.UseVisualStyleBackColor = true;
            this.soruSilBtn.Click += new System.EventHandler(this.soruSilBtn_Click);
            // 
            // soruOnaylaBtn
            // 
            this.soruOnaylaBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.soruOnaylaBtn.Location = new System.Drawing.Point(436, 362);
            this.soruOnaylaBtn.Name = "soruOnaylaBtn";
            this.soruOnaylaBtn.Size = new System.Drawing.Size(118, 32);
            this.soruOnaylaBtn.TabIndex = 5;
            this.soruOnaylaBtn.Text = "Soruyu Onayla";
            this.soruOnaylaBtn.UseVisualStyleBackColor = true;
            this.soruOnaylaBtn.Click += new System.EventHandler(this.soruOnaylaBtn_Click);
            // 
            // geriDön12Btn
            // 
            this.geriDön12Btn.Location = new System.Drawing.Point(922, 0);
            this.geriDön12Btn.Name = "geriDön12Btn";
            this.geriDön12Btn.Size = new System.Drawing.Size(78, 27);
            this.geriDön12Btn.TabIndex = 6;
            this.geriDön12Btn.Text = "Geri Dön";
            this.geriDön12Btn.UseVisualStyleBackColor = true;
            this.geriDön12Btn.Click += new System.EventHandler(this.geriDön12Btn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(384, 330);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(222, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Onaylamak İstediğiniz Soruları Seçiniz";
            // 
            // adminSoruOnaylamaEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.geriDön12Btn);
            this.Controls.Add(this.soruOnaylaBtn);
            this.Controls.Add(this.soruSilBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.silinecekSoruTextBox);
            this.Controls.Add(this.sorularDataGridView);
            this.Controls.Add(this.dataGridView2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "adminSoruOnaylamaEkrani";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "adminSoruOnaylamaEkrani";
            this.Load += new System.EventHandler(this.adminSoruOnaylamaEkrani_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sorularDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView sorularDataGridView;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TextBox silinecekSoruTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button soruSilBtn;
        private System.Windows.Forms.Button soruOnaylaBtn;
        private System.Windows.Forms.Button geriDön12Btn;
        private System.Windows.Forms.Label label2;
    }
}