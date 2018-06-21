using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TaxiApp.Models.Classes
{
	public class Komentar
	{
		public string Opis { get; set; }
		public DateTime DatumObjave { get; set; }
		public Korisnik Korisnik { get; set; }
		public Voznja Voznja { get; set; }
		public OcenaVoznje Ocena { get; set; }

		public Komentar(string _opis, DateTime _datumObjave, Korisnik _korisnik, Voznja _voznja, OcenaVoznje _ocena)
		{
			this.Opis = _opis;
			this.DatumObjave = _datumObjave;
			this.Korisnik = _korisnik;
			this.Voznja = _voznja;
			this.Ocena = _ocena;
		}
	}
}