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
    public partial class myMDIForm : Form
    {
        public myMDIForm()
        {
            InitializeComponent();
        }
        List<HamburgerMenu> rHamburgerMenu = new List<HamburgerMenu>();
        List<ExtraMalzemeMenu> rExtraMalzemeMenu = new List<ExtraMalzemeMenu>();
        List<Siparis> siparislerim = new List<Siparis>();
        string[] standartmenuler = new string[10] { "Steak House", "24", "Chicken Royal", "26", "BigKing", "28", "Whooper", "30", "Fish", "32" };
        string[] standartextralar = new string[10] { "Soğan", "3", "Ranch", "3,5", "Barbeku", "4", "Acı Sos", "5,5", "Hardal", "5" };
        public void SiparisEkle(List<Siparis> a)
        {
            siparislerim.AddRange(a);
        }
        public List<Siparis> SiparisGetir()
        {
            return siparislerim;
        }
        public void rMenuEkle(HamburgerMenu a)
        {
            rHamburgerMenu.Add(a);
        }
        public void rExtraMalzemeEkle(ExtraMalzemeMenu a)
        {
            rExtraMalzemeMenu.Add(a);
        }

        public List<HamburgerMenu> HamburgerMenuGetir()
        {
            return rHamburgerMenu;
        }
        public List<ExtraMalzemeMenu> ExtraMalzemeGetir()
        {
            return rExtraMalzemeMenu;
        }

        void ChildForm(Form _ChildForm)
        {
            foreach (Form item in this.MdiChildren)
            {
                item.Close();
            }
            this.Width = _ChildForm.Width + 20;
            this.Height = _ChildForm.Height + 70;
            _ChildForm.MdiParent = this;
            _ChildForm.Dock = DockStyle.Fill;
            _ChildForm.Show();
        }

        private void siparişOluşturToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChildForm(new Form1());
        }

        private void siparişBilgileriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChildForm(new Form2());
        }

        private void hamburgerMenüEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChildForm(new Form3());
        }

        private void extraMalzemeEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChildForm(new Form4());
        }

        private void myMDIForm_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 5; i++)
            {
                HamburgerMenu hmenu = new HamburgerMenu();
                ExtraMalzemeMenu emenu = new ExtraMalzemeMenu();
                hmenu.MenuAdi = standartmenuler[i * 2];
                hmenu.MenuFiyati = Convert.ToDecimal(standartmenuler[(i * 2) + 1]);
                emenu.ExtraMazlzemeAdi = standartextralar[i * 2];
                emenu.ExtraMalzemeFiyati = Convert.ToDecimal(standartextralar[(i * 2) + 1]);
                rMenuEkle(hmenu);
                rExtraMalzemeEkle(emenu);

            }
        }
    }
}
