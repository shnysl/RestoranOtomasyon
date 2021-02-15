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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                ExtraMalzemeMenu malzeme = new ExtraMalzemeMenu();
                malzeme.ExtraMazlzemeAdi = tbExtraMalzemeAdi.Text;
                malzeme.ExtraMalzemeFiyati = nUDMalzemeFiyati.Value;
                ((myMDIForm)MdiParent).rExtraMalzemeEkle(malzeme);
                this.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }
    }
}
