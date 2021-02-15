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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                HamburgerMenu menu = new HamburgerMenu();
                menu.MenuAdi = tbManuAdi.Text;
                menu.MenuFiyati = nUDMenuFiyati.Value;
                ((myMDIForm)MdiParent).rMenuEkle(menu);
                this.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }
    }
}
