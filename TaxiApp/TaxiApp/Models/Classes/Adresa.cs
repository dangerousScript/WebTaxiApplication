using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TaxiApp.Models.Classes
{
	public class Adresa
	{
		public string Ulica { get; set; }
		public int Broj { get; set; }
		public string Grad { get; set; }
		public int PostanskiBroj { get; set; }

		public Adresa(string _ulica, int _broj, string _grad, int _postanskiBroj)
		{
			this.Ulica = _ulica;
			this.Broj = _broj;
			this.Grad = _grad;
			this.PostanskiBroj = _postanskiBroj;
		}
	}
}