using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TaxiApp.Models.Classes
{
	public class Dispecer : Korisnik
	{
		public Dispecer()
		{
		}

		public Dispecer(string _korsnickoIme, string _loznka, string _ime, string _prezime, string _pol, string _jmbg, string _kontaktTelefon, string _email)
		{
			KorisnickoIme = _korsnickoIme;
			Lozinka = _loznka;
			Prezime = _prezime;
			if (_pol == "m")
				PolKorisnika = Pol.MUSKI;
			else
				PolKorisnika = Pol.ZENSKI;
			JMBG = _jmbg;
			KontaktTelefon = _kontaktTelefon;
			Email = _email;
		}
	}
}