using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TaxiApp.Models.Classes
{
	public class Voznja
	{
		public DateTime Datum_Vreme { get; set; }
		public Lokacija LokacijaNaKojuDolaziTaxi { get; set; }
		public TipAutomobila TipAutomobila { get; set; }
		public Musterija Musterija { get; set; }
		public Lokacija Odrediste { get; set; }
		public Dispecer Dispecer { get; set; }
		public Vozac Vozac { get; set; }
		public int Iznos { get; set; }
		public string Komentar { get; set; }
		public StatusVoznje StatusVoznje { get; set; }

		public Voznja(DateTime _datumVreme, Lokacija _lokacija, TipAutomobila _tipAutomobila, Musterija _musterija, Lokacija _odrediste, Dispecer _dispecer, Vozac _vozac, int _iznos, string _komentar)
		{
			this.Datum_Vreme = _datumVreme;
			this.LokacijaNaKojuDolaziTaxi = _lokacija;
			this.TipAutomobila = _tipAutomobila;
			this.Musterija = _musterija;
			this.Odrediste = _odrediste;
			this.Dispecer = _dispecer;
			this.Vozac = _vozac;
			this.Iznos = _iznos;
			this.Komentar = _komentar;
			this.StatusVoznje = StatusVoznje.KREIRANA_NA_CEKANJU;
		}
	}
}