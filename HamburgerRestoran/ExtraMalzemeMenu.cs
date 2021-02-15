using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HamburgerRestoran
{
    public class ExtraMalzemeMenu
    {
		private string _extraMazlzemeAdi;

		public string ExtraMazlzemeAdi
		{
			get { return _extraMazlzemeAdi; }
			set
			{
				if (value == "")
				{
					throw new Exception("Lütfen malzeme adını yazınız.");
				}
				else
				{
					_extraMazlzemeAdi = value;
				}
			}
		}

		private decimal _extraMalzemeFiyati;

		public decimal ExtraMalzemeFiyati
		{
			get { return _extraMalzemeFiyati; }
			set
			{
				if (value < 1)
				{
					throw new Exception("Lütfen fiyatını giriniz");
				}
				else
				{
					_extraMalzemeFiyati = value;
				}

			}
		}

	}
}
