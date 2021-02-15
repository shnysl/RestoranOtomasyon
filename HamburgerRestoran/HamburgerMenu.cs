using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HamburgerRestoran
{
    public class HamburgerMenu
    {
		private string _menuAdi;

		public  string MenuAdi
		{
			get { return _menuAdi; }
			set 
			{ 
				if (value == "")
				{
					throw new Exception("Lütfen menü adını yazınız.");
				}
				else
				{
					_menuAdi = value;
				}
			}
		}

		private decimal _menuFiyati;

		public decimal MenuFiyati
		{
			get { return _menuFiyati; }
			set 
			{ 
				if (value < 1)
				{
					throw new Exception("Lütfen fiyatını giriniz");
				}
				else
				{
					_menuFiyati = value;
				}

			}
		}
	}
}
