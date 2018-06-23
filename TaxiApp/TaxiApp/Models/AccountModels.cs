using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using TaxiApp.Models.Classes;

namespace TaxiApp.Models
{
	public class MusterijaModel
	{
		[Required(ErrorMessage = "Korisnicko ime je obavezno.")]
		[Display(Name = "Korisnicko ime")]
		public string KorisnickoIme { get; set; }

		[Required(ErrorMessage = "Lozinka je obavezna.")]
		[DataType(DataType.Password)]
		public string Lozinka { get; set; }

		[Required(ErrorMessage = "Potvrdite lozinku koju ste uneli.")]
		[StringLength(20, ErrorMessage = "Lozinka mora biti najmanje {2} dugacka.", MinimumLength = 3)]
		[DataType(DataType.Password)]
		[Display(Name = "Potvrda lozinke")]
		public string PotvrdaLozinke { get; set; }

		[Required(ErrorMessage = "Ime je obavezno.")]
		public string Ime { get; set; }

		[Required(ErrorMessage = "Prezime je obavezno.")]
		public string Prezime { get; set; }

		[Required(ErrorMessage = "Pol je obavezan.")]
		public string Pol { get; set; }

		[Required(ErrorMessage = "JMBG je obavezan.")]
		public string JMBG { get; set; }

		[Required(ErrorMessage = "Kontakt telefon je obavezan.")]
		[Display(Name = "Kontakt telefon")]
		public string KontaktTelefon { get; set; }

		[Required(ErrorMessage = "Email je obavezan.")]
		[EmailAddress(ErrorMessage = "Email nije ispravan.")]
		public string Email { get; set; }
	}

	public class LoginModel
	{
		[Required(ErrorMessage = "Korisnicko ime je obavezno.")]
		[Display(Name = "Korisnicko ime")]
		public string KorisnickoIme { get; set; }

		[Required(ErrorMessage = "Lozinka je obavezna.")]
		[DataType(DataType.Password)]
		public string Lozinka { get; set; }
	}
}