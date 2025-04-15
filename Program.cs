using System;


class Program
{
	static void Main()
	{
		Console.WriteLine("Jednoduchá kalkulačka v C#");
		
		Console.Write("Zadejte první číslo: ");
		double cislo1 = Convert.ToDouble(Console.ReadLine());

		Console.Write("Zadejte druhé číslo: ");
		double cislo2 = Convert.ToDouble(Console.ReadLine());

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

