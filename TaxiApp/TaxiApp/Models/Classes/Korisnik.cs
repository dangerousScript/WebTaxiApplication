using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TaxiApp.Models.Classes
{
	public class Korisnik
	{
		public string KorisnickoIme { get; set; }
		public string Lozinka { get; set; }
		public string Ime { get; set; }
		public string Prezime { get; set; }
		public Pol PolKorisnika { get; set; }
		public string JMBG { get; set; }
		public string KontaktTelefon { get; set; }
		public string Email { get; set; }
		public Uloga UlogaKorisnika { get; set; }
		public Dictionary<string, Voznja> Voznje { get; set; }
	}
}