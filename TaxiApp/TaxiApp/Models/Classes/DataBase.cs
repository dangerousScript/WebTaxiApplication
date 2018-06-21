using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TaxiApp.Models.Classes
{
	public class DataBase
	{
		public Dictionary<string, Korisnik> Korisnici = new Dictionary<string, Korisnik>()
		{
			{ "client1", new Musterija("client1", "12345", "Petar", "Petrovic", "m", "01010203421", "55214214", "test@test.com") },
			{ "vozac1", new Vozac("vozac1", "12345", "Marina", "Maric", "z", "214421421421", "241234", "mmm@ttt.com", new Automobil("vozac1", 2015, "NS-422-AB", 24, TipAutomobila.PUTNICKI)) },
			{ "vozac2", new Vozac("vozac2", "12345", "Janko", "Jankovic", "m", "2421234212", "5215422", "jjja@swdwa.com", new Automobil("vozac2", 2017, "NS-YYYY", 61, TipAutomobila.KOMBI)) },
			{ "dispecer1", new Dispecer("dispecer1", "12345", "Marija", "Markovic", "z", "1523421321", "5212423", "admin@admin.com") }
		};
	}
}