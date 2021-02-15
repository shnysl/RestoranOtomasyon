using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HamburgerRestoran
{
    public class Siparis
    {
        public Guid siparisNo { get; set; }
        public string sMenuAdi { get; set; }
        public decimal sMenuFiyati { get; set; }

        List<ExtraMalzemeMenu> sExrta = new List<ExtraMalzemeMenu>();
        public void sExtraEkle(ExtraMalzemeMenu a)
        {
            sExrta.Add(a);
        }
        public List<ExtraMalzemeMenu> sExtraGetir()
        {
            return sExrta;
        }
        public int Adet { get; set; }
        public string Boyut { get; set; }
        public decimal Toplam { get; set; }

    }
}
