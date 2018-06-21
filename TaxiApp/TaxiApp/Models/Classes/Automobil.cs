using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TaxiApp.Models.Classes
{
	public class Automobil
	{
		public string Vozac { get; set; }
		public int GodisteAutomobila { get; set; }
		public string BrojRegistarskeOznake { get; set; }
		public int IdVozila { get; set; }
		public TipAutomobila TipAutomobila { get; set; }

		public Automobil(string _vozac, int _godAuta, string _brRegOznake, int _idVozila, TipAutomobila _tipAutomobila)
		{
			this.Vozac = _vozac;
			this.GodisteAutomobila = _godAuta;
			this.BrojRegistarskeOznake = _brRegOznake;
			this.IdVozila = _idVozila;
			this.TipAutomobila = _tipAutomobila;
		}
	}
}