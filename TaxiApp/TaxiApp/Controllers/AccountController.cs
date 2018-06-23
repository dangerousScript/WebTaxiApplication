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

		// register
		public ActionResult Register()
		{
			return View();
		}

		[HttpPost]
		public ActionResult Register(MusterijaModel musterija)
		{
			string[] lines = System.IO.File.ReadAllLines(System.Web.Hosting.HostingEnvironment.MapPath("~/App_Data/Users.txt"));

			foreach (var i in lines)
			{
				if(String.Equals(i.Split('|')[0], musterija.KorisnickoIme))
				{
					return RedirectToAction("RegisterError");
				}
			}

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

				string user = m.KorisnickoIme + "|" + m.Lozinka + "|" + m.Ime + "|" + m.Prezime + "|" + m.PolKorisnika.ToString() + "|" + m.JMBG + "|" + m.KontaktTelefon + "|" + m.Email + "|musterija|[]\n";
				System.IO.File.AppendAllText(System.Web.Hosting.HostingEnvironment.MapPath("~/App_Data/Users.txt"), user);

				ModelState.Clear();
				ViewBag.Message = "Korisnik: " + m.KorisnickoIme + " uspesno kreiran.";
			}

			return View();
		}

		public ActionResult RegisterError()
		{
			ViewBag.Message = "Korisnicko ime vec postoji!";
			return View();
		}

		// login
		public ActionResult Login()
		{
			return View();
		}

		[HttpPost]
		public ActionResult Login(Korisnik korisnik)
		{
			string[] lines = System.IO.File.ReadAllLines(System.Web.Hosting.HostingEnvironment.MapPath("~/App_Data/Users.txt"));
			bool _exists = false;
			Korisnik k = null;

			foreach(var i in lines)
			{
				if (String.Equals(i.Split('|')[0], korisnik.KorisnickoIme) && String.Equals(i.Split('|')[1], korisnik.Lozinka))
				{
					_exists = true;

					k = new Korisnik();
					k.KorisnickoIme = i.Split('|')[0];
					k.Lozinka = i.Split('|')[1];
					k.Ime = i.Split('|')[2];
					k.Prezime = i.Split('|')[3];
					//k.Pol = i.Split('|')[4];
					k.JMBG = i.Split('|')[5];
					k.KontaktTelefon = i.Split('|')[6];
					k.Email = i.Split('|')[7];
					if(i.Split('|')[8] == "musterija")
					{
						k.UlogaKorisnika = Uloga.MUSTERIJA;
					}
					else if (i.Split('|')[8] == "vozac")
					{
						k.UlogaKorisnika = Uloga.VOZAC;
					}
					else
					{
						k.UlogaKorisnika = Uloga.DISPECER;
					}
				}
			}

			if (_exists)
			{
				Session["KorisnickoIme"] = korisnik.KorisnickoIme;

				if (k.UlogaKorisnika == Uloga.DISPECER)
					return RedirectToAction("LoggedDispecer");
				else if (k.UlogaKorisnika == Uloga.VOZAC)
					return RedirectToAction("LoggedVozac");
				else
					return RedirectToAction("LoggedMusterija");
			}
			else
			{
				ModelState.AddModelError("", "Username or password is wrong!");
			}

			return View();
		}

		public ActionResult LoggedDispecer()
		{
			return View();
		}

		public ActionResult LoggedVozac()
		{
			return View();
		}

		public ActionResult LoggedMusterija()
		{
			return View();
		}

		public ActionResult Logout()
		{
			Session.Clear();
			return RedirectToAction("Login");
		}
    }
}