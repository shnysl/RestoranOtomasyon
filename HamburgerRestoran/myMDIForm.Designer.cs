namespace HamburgerRestoran
{
    partial class myMDIForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.sİPARİŞYÖNETİMİToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.siparişOluşturToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.siparişBilgileriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.üRÜNYÖNETİMİToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hamburgerMenüEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.extraMalzemeEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.sİPARİŞYÖNETİMİToolStripMenuItem,
            this.üRÜNYÖNETİMİToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(12, 20);
            // 
            // sİPARİŞYÖNETİMİToolStripMenuItem
            // 
            this.sİPARİŞYÖNETİMİToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.siparişOluşturToolStripMenuItem,
            this.siparişBilgileriToolStripMenuItem});
            this.sİPARİŞYÖNETİMİToolStripMenuItem.Name = "sİPARİŞYÖNETİMİToolStripMenuItem";
            this.sİPARİŞYÖNETİMİToolStripMenuItem.Size = new System.Drawing.Size(115, 20);
            this.sİPARİŞYÖNETİMİToolStripMenuItem.Text = "SİPARİŞ YÖNETİMİ";
            // 
            // siparişOluşturToolStripMenuItem
            // 
            this.siparişOluşturToolStripMenuItem.Name = "siparişOluşturToolStripMenuItem";
            this.siparişOluşturToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.siparişOluşturToolStripMenuItem.Text = "Sipariş Oluştur";
            this.siparişOluşturToolStripMenuItem.Click += new System.EventHandler(this.siparişOluşturToolStripMenuItem_Click);
            // 
            // siparişBilgileriToolStripMenuItem
            // 
            this.siparişBilgileriToolStripMenuItem.Name = "siparişBilgileriToolStripMenuItem";
            this.siparişBilgileriToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.siparişBilgileriToolStripMenuItem.Text = "Sipariş Bilgileri";
            this.siparişBilgileriToolStripMenuItem.Click += new System.EventHandler(this.siparişBilgileriToolStripMenuItem_Click);
            // 
            // üRÜNYÖNETİMİToolStripMenuItem
            // 
            this.üRÜNYÖNETİMİToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hamburgerMenüEkleToolStripMenuItem,
            this.extraMalzemeEkleToolStripMenuItem});
            this.üRÜNYÖNETİMİToolStripMenuItem.Name = "üRÜNYÖNETİMİToolStripMenuItem";
            this.üRÜNYÖNETİMİToolStripMenuItem.Size = new System.Drawing.Size(108, 20);
            this.üRÜNYÖNETİMİToolStripMenuItem.Text = "ÜRÜN YÖNETİMİ";
            // 
            // hamburgerMenüEkleToolStripMenuItem
            // 
            this.hamburgerMenüEkleToolStripMenuItem.Name = "hamburgerMenüEkleToolStripMenuItem";
            this.hamburgerMenüEkleToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.hamburgerMenüEkleToolStripMenuItem.Text = "Hamburger Menü Ekle";
            this.hamburgerMenüEkleToolStripMenuItem.Click += new System.EventHandler(this.hamburgerMenüEkleToolStripMenuItem_Click);
            // 
            // extraMalzemeEkleToolStripMenuItem
            // 
            this.extraMalzemeEkleToolStripMenuItem.Name = "extraMalzemeEkleToolStripMenuItem";
            this.extraMalzemeEkleToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.extraMalzemeEkleToolStripMenuItem.Text = "Extra Malzeme Ekle";
            this.extraMalzemeEkleToolStripMenuItem.Click += new System.EventHandler(this.extraMalzemeEkleToolStripMenuItem_Click);
            // 
            // myMDIForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "myMDIForm";
            this.Text = "myMDIForm";
            this.Load += new System.EventHandler(this.myMDIForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem sİPARİŞYÖNETİMİToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem siparişOluşturToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem siparişBilgileriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem üRÜNYÖNETİMİToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hamburgerMenüEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem extraMalzemeEkleToolStripMenuItem;
    }
}