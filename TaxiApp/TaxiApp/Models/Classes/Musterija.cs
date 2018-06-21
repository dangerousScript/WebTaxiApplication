using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TaxiApp.Models.Classes
{
	public class Musterija : Korisnik
	{
		public Musterija()
		{

		}

		// ctor za musteriju
		public Musterija(string _korisnickoIme, string _lozinka, string _ime, string _prezime, string _pol, string _jmbg, string _kontaktTelefon, string _email)
		{
			KorisnickoIme = _korisnickoIme;
			Lozinka = _lozinka;
			Ime = _ime;
			Prezime = _prezime;
			if (_pol == "m")
				PolKorisnika = Pol.MUSKI;
			else
				PolKorisnika = Pol.ZENSKI;
			JMBG = _jmbg;
			KontaktTelefon = _kontaktTelefon;
			Email = _email;
			UlogaKorisnika = Uloga.MUSTERIJA;
		}
	}
}