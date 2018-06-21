using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TaxiApp.Models.Classes
{
	public class Lokacija
	{
		public double XKoordinate { get; set; }
		public double YKoordinate { get; set; }
		public Adresa Adresa { get; set; }

		public Lokacija()
		{
		}

		public Lokacija(double _xKoordinate, double _yKoordinate, Adresa _adresa)
		{
			this.XKoordinate = _xKoordinate;
			this.YKoordinate = _yKoordinate;
			this.Adresa = _adresa;
		}
	}
}