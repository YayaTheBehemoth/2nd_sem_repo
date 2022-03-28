using System;
using System.Collections.Generic;
namespace TilstandsMaskine
{
	class Tilstande
	{
		private static void Main()
		{
			Console.WriteLine("Hallo, Tilstandsmaskine!");
			KontoType kontotype = Controller.CreateKontoType("Ungdomskonto",
				"En kontotype til unge under 25, som for at beskytte de unge ikke tillader at der hæves på en konto med saldo under 0");

			Konto k1 = Controller.CreateKonto(kontotype);

			Controller.HævEllerIndsætBeløb(k1, 100);
			Console.WriteLine(k1);

			// tilføj flere transaktioner og se hvad der sker
		}
	}

	//Controller
	class Controller
	{
		public static KontoType CreateKontoType(string navn, string beskrivelse)
		{
			KontoType kontoType = new KontoType(navn, beskrivelse);
			Storage.AddKontoType(kontoType);
			return kontoType;
		}
		public static Konto CreateKonto(KontoType kontoType)
		{
			Konto konto = new(kontoType);

			return konto;
		}

		public static void HævEllerIndsætBeløb(Konto konto, int beløb)
		{
			try
			{
				konto.HævEllerIndsætBeløb(beløb);
			}
			catch (Exception exception)
			{
				Console.WriteLine(exception.Message);
			}
		}

	}

	//Model
	enum Tilstand
	{
		Åben,
		Lukket,
		Spærret,
		Overtrukket
	}

	public class Konto
	{
		private int nr;

		private List <Transaktion> transaktioner;
		private KontoType kontoType;
		private Tilstand tilstand;

		public Konto(KontoType kontoType)
		{
			this.kontoType = kontoType;
			this.nr = this.kontoType.GetKonti().Count + 1;
			kontoType.AddKonto(this);
			this.tilstand = Tilstand.Åben;
			transaktioner = new List <Transaktion>();
		}

		public Transaktion HævEllerIndsætBeløb(double beløb)
		{
			Transaktion? transaktion = null;
			if (!(tilstand == Tilstand.Overtrukket && beløb < 0))
			{
				transaktion = new Transaktion(beløb);
				transaktioner.Add(transaktion);
				if (beregnSaldo() < 0)
				{
					tilstand = Tilstand.Overtrukket;
				}
				else
				{
					tilstand = Tilstand.Åben;
				}
			}
			else
				throw new Exception("Du forsøger at hæve på en overtrukket konto!");

			return transaktion;
		}

		double beregnSaldo()
		{
			double saldo = 0;
			foreach (var transaktion in transaktioner)
			{
				saldo += transaktion.GetBeløb();
			}
			return saldo;

		}

		override public string ToString()
		{
			return "Saldo konto nr. " + nr + " er " + beregnSaldo() + ".";
		}

	}

	public class KontoType
	{
		private string navn;
		private string beskrivelse;
		private List<Konto> konti;

		public KontoType(string navn, string beskrivelse)
		{
			this.navn = navn;
			this.beskrivelse = beskrivelse;
			konti = new List<Konto>();
		}

		public string GetNavn()
		{
			return this.navn;
		}

		public void SetNavn(string navn)
		{
			this.navn = navn;
		}

		public string GetBeskrivelse()
		{
			return this.beskrivelse;
		}

		public void SetBeskrivelse(string beskrivelse)
		{
			this.beskrivelse = beskrivelse;
		}

		public List <Konto> GetKonti()
		{
			return this.konti;
		}

		public void AddKonto(Konto konto)
		{
			konti.Add(konto);
		}

	}

	public class Transaktion
	{
		private DateTime dato;
		private double beløb;

		public Transaktion(double beløb)
		{
			this.beløb = beløb;
			this.dato = new DateTime();
			this.dato = DateTime.Now;
		}

		public double GetBeløb()
		{
			return this.beløb;
		}

		public DateTime GetDato()
		{
			return this.dato;
		}
	}

	//Storage
	public class Storage
	{
		public static List<KontoType> kontoTyper = new List<KontoType>();

		public static void AddKontoType(KontoType kontoType)
		{
			if (!kontoTyper.Contains(kontoType))
			{
				kontoTyper.Add(kontoType);
			}
		}

	}

}