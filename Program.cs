using System;


class Program
{
	static void Main()
	{
		Console.WriteLine("!!! Vítejte v programu kalkulačka !!!");
		
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

		Console.WriteLine("Vyberte početní operaci:");
		Console.WriteLine("[1] - Sčítání");
		Console.WriteLine("[2] - Odčítání");
		Console.WriteLine("[3] - Násobení");
		Console.WriteLine("[4] - Dělení");
		Console.Write("Zadejte číslo operace: ");
		string operacniVstup = Console.ReadLine();

        Console.WriteLine($"Výsledek: {Vypocet(operacniVstup, cislo1, cislo2)}");

		Console.WriteLine("Stiskněte libovolnou klávesu pro ukončení.");
		Console.ReadKey();
	}

	double Vypocet(string vstup, double cislo1, double cislo2)
	{
        double vysledek;

        switch (vstup)
        {
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
                if (cislo2 != 0)
                {
                    vysledek = cislo1 / cislo2;
                }
                else
                {
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

