using System;


class Program
{
	static void Main()
	{
		Console.WriteLine("!!! Vítejte v programu kalkulačka !!!");

		bool pokracovat = true;

		while (pokracovat) {
			double cislo1, cislo2;

			// Načtení prvního čísla
			while (true) {
				Console.Write("Zadejte první číslo: ");
				if (double.TryParse(Console.ReadLine(), out cislo1)) {
					break;
				} else {
					Console.WriteLine("Neplatný vstup. Zadejte prosím číslo.");
				}
			}

			// Načtení druhého čísla
			while (true) {
				Console.Write("Zadejte druhé číslo: ");
				if (double.TryParse(Console.ReadLine(), out cislo2)) {
					break;
				} else {
					Console.WriteLine("Neplatný vstup. Zadejte prosím číslo.");
				}
			}

			// Výběr operace
			Console.WriteLine("Vyberte početní operaci:");
			Console.WriteLine("[1] - Sčítání");
			Console.WriteLine("[2] - Odčítání");
			Console.WriteLine("[3] - Násobení");
			Console.WriteLine("[4] - Dělení");

			string operacniVstup = Console.ReadLine();
			Console.WriteLine($"Výsledek: {Vypocet(operacniVstup, cislo1, cislo2)}");

			// Dotaz na pokračování
			Console.Write("Chcete pokračovat? (a/n): ");
			string odpoved = Console.ReadLine().Trim().ToLower();

			if (odpoved == "n") {
				pokracovat = false;
				Console.WriteLine("Děkujeme za použití kalkulačky. Nashledanou!");
			}

			Console.WriteLine();
		}
	}


	static double Vypocet(string vstup, double cislo1, double cislo2)
	{
		double vysledek = double.NaN;

		switch (vstup) {
			case "1":
				vysledek = cislo1 + cislo2;
				break;
			case "2":
				vysledek = cislo1 - cislo2;
				break;
			case "3":
				vysledek = cislo1 * cislo2;
				break;
			case "4":
				if (cislo2 != 0) {
					vysledek = cislo1 / cislo2;
				} else {
					Console.WriteLine("Chyba: Dělení nulou není povoleno.");
				}
				break;
			default:
				Console.WriteLine("Neplatný vstup operace.");
				break;
		}

		return vysledek;
	}
}
