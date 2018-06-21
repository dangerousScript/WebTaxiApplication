using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TaxiApp.Models.Classes
{
	public class Vozac : Korisnik
	{
		// polja korisnika + dodatna
		Lokacija lokacija;
		Automobil automobil;

		public Vozac()
		{
		}

		// ctor za vozace
		public Vozac(string _korsnickoIme, string _loznka, string _ime, string _prezime, string _pol, string _jmbg, string _kontaktTelefon, string _email, Automobil _automobil)
		{
			KorisnickoIme = _korsnickoIme;
			Lozinka = _loznka;
			Ime = _ime;
			Prezime = _prezime;
			if (_pol == "m")
				PolKorisnika = Pol.MUSKI;
			else
				PolKorisnika = Pol.ZENSKI;
			JMBG = _jmbg;
			KontaktTelefon = _kontaktTelefon;
			Email = _email;
			UlogaKorisnika = Uloga.VOZAC;
			this.Automobil = _automobil;
			this.Lokacija = new Lokacija();
		}

		public Lokacija Lokacija { get => lokacija; set => lokacija = value; }
		public Automobil Automobil { get => automobil; set => automobil = value; }
	}
}