using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HamburgerRestoran
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public List<Siparis> onSiparislerim = new List<Siparis>();
        decimal Hesapla()
        {
            decimal etoplam = 0;
            decimal boyut = 0;
            foreach (CheckBox item in flpExtraMalzeme.Controls)
            {
                if (item.Checked)
                {
                    etoplam += decimal.Parse(item.Tag.ToString());
                }

            }
            foreach (RadioButton item in gbBoyut.Controls)
            {

                if (item.Checked)
                {
                    boyut = decimal.Parse(item.Tag.ToString());
                }
            }
            lblTutarRakam.Text = ((((nUDMenuAdedi.Value) * ((decimal)cbMenü.SelectedValue) * boyut)) + etoplam).ToString() + " - ₺";
            return ((((nUDMenuAdedi.Value) * ((decimal)cbMenü.SelectedValue) * boyut)) + etoplam);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbMenü.Items.Clear();
            flpExtraMalzeme.Controls.Clear();
            rbKucuk.AutoCheck = true;
            pbResim.Image = Image.FromFile(@"..\..\Images\hamburger.png");
            cbMenü.DisplayMember = "MenuAdi";
            cbMenü.ValueMember = "MenuFiyati";
            cbMenü.DataSource = ((myMDIForm)MdiParent).HamburgerMenuGetir();
            foreach (ExtraMalzemeMenu item in ((myMDIForm)MdiParent).ExtraMalzemeGetir())
            {
                CheckBox cb = new CheckBox();
                cb.Name = item.ExtraMazlzemeAdi;
                cb.Text = item.ExtraMazlzemeAdi;
                cb.Tag = item.ExtraMalzemeFiyati;
                cb.Click += Cb_Click;
                flpExtraMalzeme.Controls.Add(cb);
            }
        }

        private void Cb_Click(object sender, EventArgs e)
        {
            Hesapla();
        }

        public void SiparisEkle()
        {
            if (!rbBuyuk.Checked && !rbOrta.Checked && !rbKucuk.Checked)
            {
                MessageBox.Show("Lütfen boyut seçin");
            }
            else
            {
                string extralar = "";
                Siparis siparis = new Siparis();
                siparis.sMenuAdi = cbMenü.Text;
                siparis.sMenuFiyati = Convert.ToDecimal(cbMenü.SelectedValue);
                foreach (CheckBox item in flpExtraMalzeme.Controls)
                {
                    if (item.Checked)
                    {
                        ExtraMalzemeMenu a = new ExtraMalzemeMenu();
                        a.ExtraMazlzemeAdi = item.Text;
                        a.ExtraMalzemeFiyati = Convert.ToDecimal(item.Tag);
                        siparis.sExtraEkle(a);
                        extralar += " " + item.Text;
                    }
                }
                foreach (RadioButton item in gbBoyut.Controls)
                {
                    if (item.Checked)
                    {
                        siparis.Boyut = item.Text;
                    }
                }
                siparis.siparisNo = Guid.NewGuid();
                siparis.Adet = Convert.ToInt16(nUDMenuAdedi.Value);
                siparis.Toplam = Hesapla();
                lbSiparis.Items.Add($"{ siparis.sMenuAdi} Menüsünden {siparis.Adet} Adet {siparis.Boyut} Boy Extralar => {extralar} TOPLAM TUTAR {siparis.Toplam}-TL");
                lbSiparis.ValueMember = siparis.siparisNo.ToString();
                onSiparislerim.Add(siparis);
            }
            //cbMenü.SelectedIndex = -1;
            rbBuyuk.Checked = false;
            rbOrta.Checked = false;
            rbKucuk.Checked = false;
            foreach (CheckBox item in flpExtraMalzeme.Controls)
            {
                item.Checked = false;
            }
            nUDMenuAdedi.Value = 1;
            Hesapla();
        }
        private void btnSiparisEkle_Click(object sender, EventArgs e)
        {
            SiparisEkle();
        }

        private void cbMenü_SelectedIndexChanged(object sender, EventArgs e)
        {
            Hesapla();
        }

        private void rbBuyuk_CheckedChanged(object sender, EventArgs e)
        {
            Hesapla();
        }

        private void nUDMenuAdedi_ValueChanged(object sender, EventArgs e)
        {
            Hesapla();
        }

        private void btnSiparisiTamamla_Click(object sender, EventArgs e)
        {
            decimal siparisGenelToplam = 0;
            foreach (var item in onSiparislerim)
            {
                siparisGenelToplam += item.Toplam;
            }
            if (onSiparislerim.Count == 0)
            {
                MessageBox.Show("Henüz Sipariş Eklemediniz");
            }
            else
            {
                if (MessageBox.Show($"Toplam Sipariş Ücreti : {siparisGenelToplam}\nSiparişi Tamamlamak İster misiniz?", "Sipariş Bilgisi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    ((myMDIForm)MdiParent).SiparisEkle(onSiparislerim);
                    onSiparislerim.Clear();
                    lbSiparis.Items.Clear();
                }
                else
                {
                    MessageBox.Show("Siparişiniz iptal edilmiştir.", "Sipariş Bilgisi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    onSiparislerim.Clear();
                    lbSiparis.Items.Clear();
                }
            }
        }

        private void lbSiparis_DoubleClick(object sender, EventArgs e)
        {
            int a = 0;
            lbSiparis.Items.Remove(lbSiparis.SelectedItem);
            foreach (var item in onSiparislerim)
            {
                if(item.siparisNo.ToString() == lbSiparis.ValueMember)
                {
                    a = onSiparislerim.IndexOf(item);
                }
            }
            onSiparislerim.RemoveAt(a);
        }
    }
}
