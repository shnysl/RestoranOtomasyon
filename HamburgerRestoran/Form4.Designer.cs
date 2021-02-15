namespace HamburgerRestoran
{
    partial class Form4
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
            this.nUDMalzemeFiyati = new System.Windows.Forms.NumericUpDown();
            this.tbExtraMalzemeAdi = new System.Windows.Forms.TextBox();
            this.lblExtraMalzemeFiyati = new System.Windows.Forms.Label();
            this.lblExtraMalzemeAdi = new System.Windows.Forms.Label();
            this.lblExtraMalzeme = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nUDMalzemeFiyati)).BeginInit();
            this.SuspendLayout();
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(179, 168);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(285, 45);
            this.btnKaydet.TabIndex = 17;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // nUDMalzemeFiyati
            // 
            this.nUDMalzemeFiyati.DecimalPlaces = 2;
            this.nUDMalzemeFiyati.Location = new System.Drawing.Point(179, 111);
            this.nUDMalzemeFiyati.Name = "nUDMalzemeFiyati";
            this.nUDMalzemeFiyati.Size = new System.Drawing.Size(285, 26);
            this.nUDMalzemeFiyati.TabIndex = 16;
            this.nUDMalzemeFiyati.ThousandsSeparator = true;
            // 
            // tbExtraMalzemeAdi
            // 
            this.tbExtraMalzemeAdi.Location = new System.Drawing.Point(179, 64);
            this.tbExtraMalzemeAdi.Name = "tbExtraMalzemeAdi";
            this.tbExtraMalzemeAdi.Size = new System.Drawing.Size(285, 26);
            this.tbExtraMalzemeAdi.TabIndex = 15;
            // 
            // lblExtraMalzemeFiyati
            // 
            this.lblExtraMalzemeFiyati.AutoSize = true;
            this.lblExtraMalzemeFiyati.Location = new System.Drawing.Point(113, 111);
            this.lblExtraMalzemeFiyati.Name = "lblExtraMalzemeFiyati";
            this.lblExtraMalzemeFiyati.Size = new System.Drawing.Size(51, 20);
            this.lblExtraMalzemeFiyati.TabIndex = 14;
            this.lblExtraMalzemeFiyati.Text = "Fiyat :";
            // 
            // lblExtraMalzemeAdi
            // 
            this.lblExtraMalzemeAdi.AutoSize = true;
            this.lblExtraMalzemeAdi.Location = new System.Drawing.Point(15, 67);
            this.lblExtraMalzemeAdi.Name = "lblExtraMalzemeAdi";
            this.lblExtraMalzemeAdi.Size = new System.Drawing.Size(149, 20);
            this.lblExtraMalzemeAdi.TabIndex = 13;
            this.lblExtraMalzemeAdi.Text = "Exrta Malzeme Adi :";
            // 
            // lblExtraMalzeme
            // 
            this.lblExtraMalzeme.AutoSize = true;
            this.lblExtraMalzeme.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblExtraMalzeme.Location = new System.Drawing.Point(27, 17);
            this.lblExtraMalzeme.Name = "lblExtraMalzeme";
            this.lblExtraMalzeme.Size = new System.Drawing.Size(190, 20);
            this.lblExtraMalzeme.TabIndex = 12;
            this.lblExtraMalzeme.Text = "Extra Malzeme Bilgileri";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 230);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.nUDMalzemeFiyati);
            this.Controls.Add(this.tbExtraMalzemeAdi);
            this.Controls.Add(this.lblExtraMalzemeFiyati);
            this.Controls.Add(this.lblExtraMalzemeAdi);
            this.Controls.Add(this.lblExtraMalzeme);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form4";
            this.Text = "Form4";
            ((System.ComponentModel.ISupportInitialize)(this.nUDMalzemeFiyati)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.NumericUpDown nUDMalzemeFiyati;
        private System.Windows.Forms.TextBox tbExtraMalzemeAdi;
        private System.Windows.Forms.Label lblExtraMalzemeFiyati;
        private System.Windows.Forms.Label lblExtraMalzemeAdi;
        private System.Windows.Forms.Label lblExtraMalzeme;
    }
}