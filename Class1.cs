using System;

public class IndexerUziti
{
	public int pocetUziti = 0;

	public IndexerUziti()
	{
	}

	public void PridejUziti() 
	{
		pocetUziti++;
	}
	public void KolikUziti() 
	{
		Console.WriteLine($"Program kalkulačka jste použili {pocetUziti}-krát.");
	}

	public void ResetUziti() 
	{ 
		pocetUziti = 0; 
	}
}
