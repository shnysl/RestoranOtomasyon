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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            string extralar = "";
            decimal Ciro = 0;
            decimal extraSatis = 0;
            int ToplamMenu = 0;
            foreach (var item in ((myMDIForm)MdiParent).SiparisGetir())
            {
                foreach (var item1 in item.sExtraGetir())
                {
                    extralar += item1.ExtraMazlzemeAdi + " ";
                    extraSatis += item1.ExtraMalzemeFiyati;
                }
                Ciro += item.Toplam;
                ToplamMenu += item.Adet;
                lbSiparisListesi.Items.Add($"{item.sMenuAdi} Menüsünden {item.Adet} Adet {item.Boyut} Boy Extralar => {extralar} TOPLAM TUTAR : {item.Toplam}-TL");
            }
            lblCiro.Text = Ciro.ToString() + "-TL";
            lblExtraMalzemeGeliri.Text = extraSatis.ToString() + "-TL";
            lblSatilanUrunAdedi.Text = ToplamMenu.ToString();
            lblToplamSiparisSayisi.Text = ((myMDIForm)MdiParent).SiparisGetir().Count().ToString();
        }
    }
}
