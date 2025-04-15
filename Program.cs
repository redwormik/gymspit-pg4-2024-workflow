using System;


class Program
{
	static void Main()
	{
		Console.WriteLine("Jednoduchá kalkulačka v C#");
		
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

		Console.WriteLine("Vyberte operaci:");
		Console.WriteLine("1 - Sčítání");
		Console.WriteLine("2 - Odčítání");
		Console.WriteLine("3 - Násobení");
		Console.WriteLine("4 - Dělení");
		Console.Write("Zadejte číslo operace: ");
		string vstup = Console.ReadLine();

		double vysledek;

		switch (vstup)
		{
			case "1":
				vysledek = cislo1 + cislo2;
				Console.WriteLine($"Výsledek: {vysledek}");
				break;
			case "2":
				vysledek = cislo1 - cislo2;
				Console.WriteLine($"Výsledek: {vysledek}");
				break;
			case "3":
				vysledek = cislo1 * cislo2;
				Console.WriteLine($"Výsledek: {vysledek}");
				break;
			case "4":
				if (cislo2 != 0) {
					vysledek = cislo1 / cislo2;
					Console.WriteLine($"Výsledek: {vysledek}");
				} else {
					Console.WriteLine("Chyba: Dělení nulou není povoleno.");
				}
				break;
			default:
				Console.WriteLine("Neplatná vstup operace.");
				break;
		}

		Console.WriteLine("Stiskněte libovolnou klávesu pro ukončení.");
		Console.ReadKey();
	}
}

