using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TaxiApp.Models.Classes;
using TaxiApp.Models;

namespace TaxiApp.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult Index()
        {
            return View();
        }

		public ActionResult Register()
		{
			return View();
		}

		[HttpPost]
		public ActionResult Register(MusterijaModel musterija)
		{
			if(ModelState.IsValid)
			{
				Pol p;
				Enum.TryParse(musterija.Pol, out p);

				Musterija m = new Musterija()
				{
					KorisnickoIme = musterija.KorisnickoIme,
					Lozinka = musterija.Lozinka,
					Ime = musterija.Ime,
					Prezime = musterija.Prezime,
					PolKorisnika = p,
					JMBG = musterija.JMBG,
					KontaktTelefon = musterija.KontaktTelefon,
					Email = musterija.Email,
					UlogaKorisnika = Uloga.MUSTERIJA,
					Voznje = new Dictionary<string, Voznja>()
				};

				DataBase.Korisnici.Add(m.KorisnickoIme, m);
				ModelState.Clear();
				ViewBag.Message = "Korisnik: " + m.KorisnickoIme + " uspesno kreiran.";
			}

			return View();
		}
    }
}