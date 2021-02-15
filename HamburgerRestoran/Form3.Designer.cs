namespace HamburgerRestoran
{
    partial class Form3
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
            this.btnKaydet = new System.Windows.Forms.Button();
            this.nUDMenuFiyati = new System.Windows.Forms.NumericUpDown();
            this.tbManuAdi = new System.Windows.Forms.TextBox();
            this.lblMenuFiyati = new System.Windows.Forms.Label();
            this.lblMenuAdi = new System.Windows.Forms.Label();
            this.lblMenuBilgileri = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nUDMenuFiyati)).BeginInit();
            this.SuspendLayout();
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(164, 160);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(285, 45);
            this.btnKaydet.TabIndex = 11;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // nUDMenuFiyati
            // 
            this.nUDMenuFiyati.DecimalPlaces = 2;
            this.nUDMenuFiyati.Location = new System.Drawing.Point(164, 103);
            this.nUDMenuFiyati.Name = "nUDMenuFiyati";
            this.nUDMenuFiyati.Size = new System.Drawing.Size(285, 26);
            this.nUDMenuFiyati.TabIndex = 10;
            this.nUDMenuFiyati.ThousandsSeparator = true;
            // 
            // tbManuAdi
            // 
            this.tbManuAdi.Location = new System.Drawing.Point(164, 56);
            this.tbManuAdi.Name = "tbManuAdi";
            this.tbManuAdi.Size = new System.Drawing.Size(285, 26);
            this.tbManuAdi.TabIndex = 9;
            // 
            // lblMenuFiyati
            // 
            this.lblMenuFiyati.AutoSize = true;
            this.lblMenuFiyati.Location = new System.Drawing.Point(98, 103);
            this.lblMenuFiyati.Name = "lblMenuFiyati";
            this.lblMenuFiyati.Size = new System.Drawing.Size(51, 20);
            this.lblMenuFiyati.TabIndex = 8;
            this.lblMenuFiyati.Text = "Fiyat :";
            // 
            // lblMenuAdi
            // 
            this.lblMenuAdi.AutoSize = true;
            this.lblMenuAdi.Location = new System.Drawing.Point(65, 59);
            this.lblMenuAdi.Name = "lblMenuAdi";
            this.lblMenuAdi.Size = new System.Drawing.Size(84, 20);
            this.lblMenuAdi.TabIndex = 7;
            this.lblMenuAdi.Text = "Menü Adı :";
            // 
            // lblMenuBilgileri
            // 
            this.lblMenuBilgileri.AutoSize = true;
            this.lblMenuBilgileri.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMenuBilgileri.Location = new System.Drawing.Point(12, 9);
            this.lblMenuBilgileri.Name = "lblMenuBilgileri";
            this.lblMenuBilgileri.Size = new System.Drawing.Size(116, 20);
            this.lblMenuBilgileri.TabIndex = 6;
            this.lblMenuBilgileri.Text = "Menü Bilgileri";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 230);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.nUDMenuFiyati);
            this.Controls.Add(this.tbManuAdi);
            this.Controls.Add(this.lblMenuFiyati);
            this.Controls.Add(this.lblMenuAdi);
            this.Controls.Add(this.lblMenuBilgileri);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form3";
            this.Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.nUDMenuFiyati)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.NumericUpDown nUDMenuFiyati;
        private System.Windows.Forms.TextBox tbManuAdi;
        private System.Windows.Forms.Label lblMenuFiyati;
        private System.Windows.Forms.Label lblMenuAdi;
        private System.Windows.Forms.Label lblMenuBilgileri;
    }
}