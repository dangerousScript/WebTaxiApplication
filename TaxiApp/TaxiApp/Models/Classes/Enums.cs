using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TaxiApp.Models.Classes
{
	public enum Pol
	{
		MUSKI,
		ZENSKI
	};

	public enum Uloga
	{
		MUSTERIJA,
		VOZAC,
		DISPECER
	};

	public enum TipAutomobila
	{
		PUTNICKI,
		KOMBI
	};

	public enum StatusVoznje
	{
		KREIRANA_NA_CEKANJU,
		OTKAZANA,
		FORMIRANA,
		OBRADJENA,
		PRIHVACENA,
		NEUSPESNA,
		USPESNA
	};

	public enum OcenaVoznje
	{
		NULA = 0,
		JEDAN = 1,
		DVA = 2,
		TRI = 3,
		CETIRI = 4,
		PET = 5
	}
}