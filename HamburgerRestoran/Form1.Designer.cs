namespace HamburgerRestoran
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.pbResim = new System.Windows.Forms.PictureBox();
            this.lbSiparis = new System.Windows.Forms.ListBox();
            this.lblMenuSecin = new System.Windows.Forms.Label();
            this.cbMenü = new System.Windows.Forms.ComboBox();
            this.gbBoyut = new System.Windows.Forms.GroupBox();
            this.rbBuyuk = new System.Windows.Forms.RadioButton();
            this.rbOrta = new System.Windows.Forms.RadioButton();
            this.rbKucuk = new System.Windows.Forms.RadioButton();
            this.lblExtraMazleme = new System.Windows.Forms.Label();
            this.flpExtraMalzeme = new System.Windows.Forms.FlowLayoutPanel();
            this.lblAdet = new System.Windows.Forms.Label();
            this.nUDMenuAdedi = new System.Windows.Forms.NumericUpDown();
            this.btnSiparisEkle = new System.Windows.Forms.Button();
            this.btnSiparisiTamamla = new System.Windows.Forms.Button();
            this.lblTutuar = new System.Windows.Forms.Label();
            this.lblTutarRakam = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbResim)).BeginInit();
            this.gbBoyut.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUDMenuAdedi)).BeginInit();
            this.SuspendLayout();
            // 
            // pbResim
            // 
            this.pbResim.Location = new System.Drawing.Point(12, 12);
            this.pbResim.Name = "pbResim";
            this.pbResim.Size = new System.Drawing.Size(283, 218);
            this.pbResim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbResim.TabIndex = 0;
            this.pbResim.TabStop = false;
            // 
            // lbSiparis
            // 
            this.lbSiparis.FormattingEnabled = true;
            this.lbSiparis.ItemHeight = 20;
            this.lbSiparis.Location = new System.Drawing.Point(301, 12);
            this.lbSiparis.Name = "lbSiparis";
            this.lbSiparis.Size = new System.Drawing.Size(766, 604);
            this.lbSiparis.TabIndex = 1;
            this.lbSiparis.DoubleClick += new System.EventHandler(this.lbSiparis_DoubleClick);
            // 
            // lblMenuSecin
            // 
            this.lblMenuSecin.AutoSize = true;
            this.lblMenuSecin.Location = new System.Drawing.Point(12, 243);
            this.lblMenuSecin.Name = "lblMenuSecin";
            this.lblMenuSecin.Size = new System.Drawing.Size(93, 20);
            this.lblMenuSecin.TabIndex = 2;
            this.lblMenuSecin.Text = "Menü Seçin";
            // 
            // cbMenü
            // 
            this.cbMenü.FormattingEnabled = true;
            this.cbMenü.Location = new System.Drawing.Point(12, 266);
            this.cbMenü.Name = "cbMenü";
            this.cbMenü.Size = new System.Drawing.Size(283, 28);
            this.cbMenü.TabIndex = 3;
            this.cbMenü.SelectedIndexChanged += new System.EventHandler(this.cbMenü_SelectedIndexChanged);
            // 
            // gbBoyut
            // 
            this.gbBoyut.Controls.Add(this.rbBuyuk);
            this.gbBoyut.Controls.Add(this.rbOrta);
            this.gbBoyut.Controls.Add(this.rbKucuk);
            this.gbBoyut.Location = new System.Drawing.Point(14, 306);
            this.gbBoyut.Name = "gbBoyut";
            this.gbBoyut.Size = new System.Drawing.Size(281, 64);
            this.gbBoyut.TabIndex = 4;
            this.gbBoyut.TabStop = false;
            this.gbBoyut.Text = "Boyut Seçin";
            // 
            // rbBuyuk
            // 
            this.rbBuyuk.AutoSize = true;
            this.rbBuyuk.Location = new System.Drawing.Point(193, 25);
            this.rbBuyuk.Name = "rbBuyuk";
            this.rbBuyuk.Size = new System.Drawing.Size(71, 24);
            this.rbBuyuk.TabIndex = 2;
            this.rbBuyuk.TabStop = true;
            this.rbBuyuk.Tag = "2";
            this.rbBuyuk.Text = "Büyük";
            this.rbBuyuk.UseVisualStyleBackColor = true;
            this.rbBuyuk.CheckedChanged += new System.EventHandler(this.rbBuyuk_CheckedChanged);
            // 
            // rbOrta
            // 
            this.rbOrta.AutoSize = true;
            this.rbOrta.Location = new System.Drawing.Point(106, 25);
            this.rbOrta.Name = "rbOrta";
            this.rbOrta.Size = new System.Drawing.Size(58, 24);
            this.rbOrta.TabIndex = 1;
            this.rbOrta.TabStop = true;
            this.rbOrta.Tag = "1,5";
            this.rbOrta.Text = "Orta";
            this.rbOrta.UseVisualStyleBackColor = true;
            this.rbOrta.CheckedChanged += new System.EventHandler(this.rbBuyuk_CheckedChanged);
            // 
            // rbKucuk
            // 
            this.rbKucuk.AutoSize = true;
            this.rbKucuk.Location = new System.Drawing.Point(6, 25);
            this.rbKucuk.Name = "rbKucuk";
            this.rbKucuk.Size = new System.Drawing.Size(71, 24);
            this.rbKucuk.TabIndex = 0;
            this.rbKucuk.TabStop = true;
            this.rbKucuk.Tag = "1";
            this.rbKucuk.Text = "Küçük";
            this.rbKucuk.UseVisualStyleBackColor = true;
            this.rbKucuk.CheckedChanged += new System.EventHandler(this.rbBuyuk_CheckedChanged);
            // 
            // lblExtraMazleme
            // 
            this.lblExtraMazleme.AutoSize = true;
            this.lblExtraMazleme.Location = new System.Drawing.Point(20, 380);
            this.lblExtraMazleme.Name = "lblExtraMazleme";
            this.lblExtraMazleme.Size = new System.Drawing.Size(158, 20);
            this.lblExtraMazleme.TabIndex = 5;
            this.lblExtraMazleme.Text = "Extra Malzeme Seçin";
            // 
            // flpExtraMalzeme
            // 
            this.flpExtraMalzeme.Location = new System.Drawing.Point(12, 413);
            this.flpExtraMalzeme.Name = "flpExtraMalzeme";
            this.flpExtraMalzeme.Size = new System.Drawing.Size(283, 159);
            this.flpExtraMalzeme.TabIndex = 6;
            // 
            // lblAdet
            // 
            this.lblAdet.AutoSize = true;
            this.lblAdet.Location = new System.Drawing.Point(20, 584);
            this.lblAdet.Name = "lblAdet";
            this.lblAdet.Size = new System.Drawing.Size(51, 20);
            this.lblAdet.TabIndex = 7;
            this.lblAdet.Text = "Adet :";
            this.lblAdet.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // nUDMenuAdedi
            // 
            this.nUDMenuAdedi.Location = new System.Drawing.Point(77, 582);
            this.nUDMenuAdedi.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nUDMenuAdedi.Name = "nUDMenuAdedi";
            this.nUDMenuAdedi.Size = new System.Drawing.Size(218, 26);
            this.nUDMenuAdedi.TabIndex = 8;
            this.nUDMenuAdedi.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nUDMenuAdedi.ValueChanged += new System.EventHandler(this.nUDMenuAdedi_ValueChanged);
            // 
            // btnSiparisEkle
            // 
            this.btnSiparisEkle.Location = new System.Drawing.Point(12, 621);
            this.btnSiparisEkle.Name = "btnSiparisEkle";
            this.btnSiparisEkle.Size = new System.Drawing.Size(283, 41);
            this.btnSiparisEkle.TabIndex = 9;
            this.btnSiparisEkle.Text = "Sipariş Ekle";
            this.btnSiparisEkle.UseVisualStyleBackColor = true;
            this.btnSiparisEkle.Click += new System.EventHandler(this.btnSiparisEkle_Click);
            // 
            // btnSiparisiTamamla
            // 
            this.btnSiparisiTamamla.Location = new System.Drawing.Point(784, 621);
            this.btnSiparisiTamamla.Name = "btnSiparisiTamamla";
            this.btnSiparisiTamamla.Size = new System.Drawing.Size(283, 41);
            this.btnSiparisiTamamla.TabIndex = 10;
            this.btnSiparisiTamamla.Text = "SİPARİŞİ TAMAMLA";
            this.btnSiparisiTamamla.UseVisualStyleBackColor = true;
            this.btnSiparisiTamamla.Click += new System.EventHandler(this.btnSiparisiTamamla_Click);
            // 
            // lblTutuar
            // 
            this.lblTutuar.AutoSize = true;
            this.lblTutuar.Location = new System.Drawing.Point(309, 634);
            this.lblTutuar.Name = "lblTutuar";
            this.lblTutuar.Size = new System.Drawing.Size(114, 20);
            this.lblTutuar.TabIndex = 11;
            this.lblTutuar.Text = "Toplam Tutar : ";
            // 
            // lblTutarRakam
            // 
            this.lblTutarRakam.AutoSize = true;
            this.lblTutarRakam.Location = new System.Drawing.Point(441, 634);
            this.lblTutarRakam.Name = "lblTutarRakam";
            this.lblTutarRakam.Size = new System.Drawing.Size(62, 20);
            this.lblTutarRakam.TabIndex = 12;
            this.lblTutarRakam.Text = "0,00 TL";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1079, 677);
            this.Controls.Add(this.lblTutarRakam);
            this.Controls.Add(this.lblTutuar);
            this.Controls.Add(this.btnSiparisiTamamla);
            this.Controls.Add(this.btnSiparisEkle);
            this.Controls.Add(this.nUDMenuAdedi);
            this.Controls.Add(this.lblAdet);
            this.Controls.Add(this.flpExtraMalzeme);
            this.Controls.Add(this.lblExtraMazleme);
            this.Controls.Add(this.gbBoyut);
            this.Controls.Add(this.cbMenü);
            this.Controls.Add(this.lblMenuSecin);
            this.Controls.Add(this.lbSiparis);
            this.Controls.Add(this.pbResim);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbResim)).EndInit();
            this.gbBoyut.ResumeLayout(false);
            this.gbBoyut.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUDMenuAdedi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbResim;
        private System.Windows.Forms.ListBox lbSiparis;
        private System.Windows.Forms.Label lblMenuSecin;
        private System.Windows.Forms.GroupBox gbBoyut;
        private System.Windows.Forms.RadioButton rbBuyuk;
        private System.Windows.Forms.RadioButton rbOrta;
        private System.Windows.Forms.RadioButton rbKucuk;
        private System.Windows.Forms.Label lblExtraMazleme;
        private System.Windows.Forms.FlowLayoutPanel flpExtraMalzeme;
        private System.Windows.Forms.Label lblAdet;
        private System.Windows.Forms.NumericUpDown nUDMenuAdedi;
        private System.Windows.Forms.Button btnSiparisEkle;
        private System.Windows.Forms.Button btnSiparisiTamamla;
        private System.Windows.Forms.Label lblTutuar;
        private System.Windows.Forms.Label lblTutarRakam;
        private System.Windows.Forms.ComboBox cbMenü;
    }
}

