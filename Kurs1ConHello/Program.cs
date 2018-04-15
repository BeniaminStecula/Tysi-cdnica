using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kurs1ConHello
{
	class Program
	{
		static void Main(string[] args)
		{
			string version="1v3";
			Console.WriteLine($"Tysiącdnica wersja:\t{version}");	//#############################version
			string imie1;
			string imie;
			bool pajac=false;
			int rok;
			int miesiac;
			int dzien;

			try
			{
				if (args.Length > 3)
				{
					imie1 = args[0];
					rok = int.Parse(args[1]);
					miesiac = int.Parse(args[2]);
					dzien = int.Parse(args[3]);
				}
				else
				{
					Console.Write("Imię:\t");
					imie1 = Console.ReadLine();
					Console.WriteLine("\nPodaj swoją datę urodzin.");
					Console.Write("Rok:\t\t");
					rok = int.Parse(Console.ReadLine());
					Console.Write("Miesiąc:\t");
					miesiac = int.Parse(Console.ReadLine());
					Console.Write("Dzień:\t\t");
					dzien = int.Parse(Console.ReadLine());
				}
			}
			catch
			{
				Console.WriteLine("Nie znasz swojej daty urodzenia?");
				Console.ReadKey();
				return;
			}
			if (imie1 == "michal") { imie = "amvpio"; pajac = true; }
			else if (imie1 == "amvpio") { imie = "michal"; pajac = true; }
			else imie = imie1.Substring(0, 1).ToUpper() + imie1.Substring(1).ToLower();

			Console.WriteLine($"\nGood morning {imie}, that's a nice Tnetennba!");

			DateTime urodzenie = new DateTime(rok, miesiac, dzien, 0, 0, 0);
			Console.WriteLine($"\nData urodzenia:\t{urodzenie.ToLongDateString()}");

			TimeSpan dni = DateTime.Now - urodzenie;
			Console.WriteLine($"\nMasz {String.Format("{0:0.0000}", dni.TotalDays)} dni.");

			double daysToNextAnniversary = 1000 - (dni.TotalDays % 1000);
			int ktoraTysiacdnica = 1000 * (1+dni.Days/1000);
			Console.WriteLine($"\nNastępna tysiącdnica ({ktoraTysiacdnica}) będzie za {String.Format("{0:0.0}", daysToNextAnniversary)} dni!");
			Console.WriteLine($"Będzie to dnia: {DateTime.Now.AddDays(daysToNextAnniversary).ToLongDateString()} roku!");

			Console.Write($"\nTysiącdnica {ktoraTysiacdnica} dnia oznacza, że tego dnia obchodzisz {ktoraTysiacdnica+1} dzień swojego życia, czyli rozpocząłeś nową tysiącdnicę. Cieszymy się, że jesteś z nami {imie}.");

			if (pajac == true) Console.Write($" Brawo! Znalazłeś easter egga: 'EG3C{imie1}'- koniecznie mnie o tym powiadom.");
			Console.WriteLine();

			Console.WriteLine("\nKoniec");
			Console.ReadKey();
		}
	}
}
